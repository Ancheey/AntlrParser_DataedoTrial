using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using AntlrParserTrial;
namespace SQLParserTester;

[TestClass]
public class MainTest
{
    [TestMethod]
    [DataRow("SELECT PurchaseOrderID FROM PurchaseOrderDetaily;",1)]
    [DataRow("SELECT CustomerName, City FROM Customers;",2)]
    public void TestSQLListenerBase(string input, int colAmt)
    {
        ICharStream stream = CharStreams.fromString(input);
        ITokenSource lexer = new SQLLexer(stream);
        ITokenStream tokens = new CommonTokenStream(lexer);
        SQLParser parser = new SQLParser(tokens);

        parser.BuildParseTree = true;

        SQLBaseListener ListenerSelectBase = new SQLListenerSelectBase();

        parser.AddParseListener(ListenerSelectBase);

        IParseTree tree = parser.statement();

        List<string> strings = new List<string>(((IColumnParser)ListenerSelectBase).GetUsedColumns());
        Assert.AreEqual(colAmt, strings.Count);
    }


    [TestMethod]
    [DataRow("SELECT c.CustomerName,\r\n c.City,\r\ns.PurchaseID,\r\n s.PurchaseDate\r\nFROM Customers c JOIN Sales s ON s.CustomerID = c.ID;", 4)]
    [DataRow("SELECT pod.PurchaseOrderID, pod.ReceivedQty, \r\npod.RejectedQty,\r\nrp.RejectedQty / pod.ReceivedQty AS RejectRatio, \r\npod.DueDate\r\nFROM Purchasing.PurchaseOrderDetail pod JOIN \r\nSalesRejectedProducts rp\r\nON pod.RejectedId = rp.Id\r\nWHERE RejectedQty / ReceivedQty > 0\r\nAND DueDate > CONVERT(DATETIME, '20010630', 101);", 5)]
    public void TestSQLListenerJoined(string input, int colAmt)
    {
        ICharStream stream = CharStreams.fromString(input);
        ITokenSource lexer = new SQLLexer(stream);
        ITokenStream tokens = new CommonTokenStream(lexer);
        SQLParser parser = new SQLParser(tokens);

        parser.BuildParseTree = true;

        SQLBaseListener ListenerSelectJoined = new SQLListenerSelectJoined();

        parser.AddParseListener(ListenerSelectJoined);

        IParseTree tree = parser.statement();

        List<string> strings = new List<string>(((IColumnParser)ListenerSelectJoined).GetUsedColumns());
        Assert.AreEqual(colAmt, strings.Count);
    }
}