using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntlrParserTrial
{
    public class SQLListenerSelectBase : SQLBaseListener, IColumnParser
    {
        List<string> columns = new List<string>();
        string? table = "";

        /// <summary>
        /// This method finds all identifiers in the select statement
        /// </summary>
        public override void ExitBasicSelector(SQLParser.BasicSelectorContext context)
        {
            foreach(ITerminalNode node in context.IDENTIFIER())
            {
                columns.Add(node.GetText());
            }
            shouldBeAssigning = false;
        }
        public override void EnterBasicSelector(SQLParser.BasicSelectorContext context)
        {
            shouldBeAssigning = true;
        }
        /// <summary>
        /// This method finds all identifiers that might be cointained in "AS" statements
        /// </summary>
        public override void ExitSpecificIdentifier(SQLParser.SpecificIdentifierContext context)
        {
            //this stops repeats
            if (!shouldBeAssigning || columns.Any(x =>
                x == context.IDENTIFIER()[context.IDENTIFIER().Length - 1].GetText()))
                return;
            columns.Add(context.IDENTIFIER()[context.IDENTIFIER().Length - 1].GetText());

        }
        /// <summary>
        /// Finds the table name
        /// </summary>
        public override void ExitBasicTargetter(SQLParser.BasicTargetterContext context)
        {
            table = context.specificIdentifier().GetText();
        }
        /// <summary>
        /// This method is requested by IColumnParser used to parse the columns collected by the listener
        /// </summary>
        /// <returns>An array of strings containing the columns along with their table</returns>
        public IEnumerable<string> GetUsedColumns()
        {
            List<string> strings = new List<string>();
            foreach (string s in columns)
            {
                strings.Add($"{table}.{s}");
            }
            return strings;
        }
    }
}
