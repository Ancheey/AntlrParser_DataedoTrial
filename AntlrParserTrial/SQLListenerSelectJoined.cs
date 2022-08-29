using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntlrParserTrial
{
    public class SQLListenerSelectJoined : SQLBaseListener, IColumnParser
    {
        //Contains the var names and assigned tables
        public Dictionary<string, string> varTabPair = new Dictionary<string, string>();

        //contains the var names and columns drawn from these vars
        public List<KeyValuePair<string, string>> colVarPair = new List<KeyValuePair<string, string>>();



        /// <summary>
        /// If assignment is not yet complete (Selector did not finish its job) this method adds
        /// a key val pair to the colVarPair list. Key is the full name of the column while
        /// value is the variable used.
        /// </summary>
        public override void ExitSpecificIdentifier(SQLParser.SpecificIdentifierContext context)
        {
            if (!shouldBeAssigning || colVarPair.Any(x =>
                x.Key == context.IDENTIFIER()[1].GetText() &&
                x.Value == context.IDENTIFIER()[0].GetText()))
                return;

            colVarPair.Add(
                new KeyValuePair<string, string>(
                    context.IDENTIFIER()[1].GetText(),
                    context.IDENTIFIER()[0].GetText())
                );

        }


        /// <summary>
        /// This method runs when a VarAssIdentifier is found by ANTLR4. That means a variable assignment
        /// happened and now the variable and it's true name are saved in the dictionary varTabPair
        /// This method will not try to overwhrite already existing variables.
        /// </summary>
        public override void ExitVariableAssignmentIdentifier(SQLParser.VariableAssignmentIdentifierContext context)
        {
            if (!varTabPair.ContainsKey(context.IDENTIFIER()[context.IDENTIFIER().Length > 1 ? 1 : 0].GetText()))
            {
                //Assign true name to a variable
                string text = context.IDENTIFIER().Length > 1 ? context.IDENTIFIER()[0].GetText() : context.specificIdentifier().GetText();
                varTabPair[context.IDENTIFIER()[context.IDENTIFIER().Length > 1 ? 1 : 0].GetText()] = text;
            }
        }

        /// <summary>
        /// This part stops anything after the select statement to be considered a noteworthy column reference
        /// </summary>
        public override void ExitJoinedSelector(SQLParser.JoinedSelectorContext context)
        {
            shouldBeAssigning = false;
        }
        /// <summary>
        /// This part stops anything after the select statement to be considered a noteworthy column reference
        /// </summary>
        public override void EnterJoinedSelector(SQLParser.JoinedSelectorContext context)
        {
            shouldBeAssigning = true;
        }

        /// <summary>
        /// This method is requested by IColumnParser used to parse the columns collected by the listener
        /// </summary>
        /// <returns>An array of strings containing the columns along with their tables</returns>
        public IEnumerable<string> GetUsedColumns()
        {
            List<string> strings = new List<string>();
            foreach (KeyValuePair<string, string> kvp in colVarPair)
            {
                if (varTabPair.ContainsKey(kvp.Value))
                {
                    strings.Add($"{varTabPair[kvp.Value]}.{kvp.Key}");
                }
            }
            return strings;
        }
    }
}
