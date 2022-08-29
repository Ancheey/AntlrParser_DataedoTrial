// See https://aka.ms/new-console-template for more information
using AntlrParserTrial;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;

String input = "SELECT PurchaseOrderID FROM PurchaseOrderDetail;";

ICharStream stream = CharStreams.fromString(input);
ITokenSource lexer = new SQLLexer(stream);
ITokenStream tokens = new CommonTokenStream(lexer);
SQLParser parser = new SQLParser(tokens);

parser.BuildParseTree = true;

SQLBaseListener ListenerSelectBase = new SQLListenerSelectBase();
SQLBaseListener ListenerSelectJoined = new SQLListenerSelectJoined();
parser.AddParseListener(ListenerSelectBase);
parser.AddParseListener(ListenerSelectJoined);


IParseTree tree = parser.statement();


List<string> strings = new List<string>(((IColumnParser)ListenerSelectBase).GetUsedColumns());
if(strings.Count == 0)
{
    strings = new List<string>(((IColumnParser)ListenerSelectJoined).GetUsedColumns());
}


if (strings.Count > 0)
{
    Console.Write("Użyte kolumny: {0}", strings[0]);
}
for (int i = 1; i < strings.Count; i++)
{
    Console.Write(", {0}",strings[i]);
}



