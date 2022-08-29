// Generated from d:\GitHub\Antlr_Trial\AntlrParserTrial\AntlrParserTrial\SQL.g4 by ANTLR 4.9.2
import org.antlr.v4.runtime.Lexer;
import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.Token;
import org.antlr.v4.runtime.TokenStream;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.misc.*;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class SQLLexer extends Lexer {
	static { RuntimeMetaData.checkVersion("4.9.2", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, T__2=3, AND=4, OR=5, AS=6, WHERE=7, ON=8, SELECT=9, FROM=10, 
		JOIN=11, DOT=12, COMMA=13, SPACE=14, EOL=15, MATH_SIGN=16, BOOL_OPS=17, 
		IDENTIFIER=18, NUMBER=19, STRING=20, WS=21;
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	private static String[] makeRuleNames() {
		return new String[] {
			"T__0", "T__1", "T__2", "AND", "OR", "AS", "WHERE", "ON", "SELECT", "FROM", 
			"JOIN", "DOT", "COMMA", "SPACE", "EOL", "MATH_SIGN", "BOOL_OPS", "IDENTIFIER", 
			"NUMBER", "STRING", "WS"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "'='", "'('", "')'", "'AND'", "'OR'", "'AS'", "'WHERE'", "'ON'", 
			"'SELECT'", "'FROM'", "'JOIN'", "'.'", "','"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, null, null, null, "AND", "OR", "AS", "WHERE", "ON", "SELECT", "FROM", 
			"JOIN", "DOT", "COMMA", "SPACE", "EOL", "MATH_SIGN", "BOOL_OPS", "IDENTIFIER", 
			"NUMBER", "STRING", "WS"
		};
	}
	private static final String[] _SYMBOLIC_NAMES = makeSymbolicNames();
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}


	public SQLLexer(CharStream input) {
		super(input);
		_interp = new LexerATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@Override
	public String getGrammarFileName() { return "SQL.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public String[] getChannelNames() { return channelNames; }

	@Override
	public String[] getModeNames() { return modeNames; }

	@Override
	public ATN getATN() { return _ATN; }

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\2\27\u0091\b\1\4\2"+
		"\t\2\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4"+
		"\13\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22"+
		"\t\22\4\23\t\23\4\24\t\24\4\25\t\25\4\26\t\26\3\2\3\2\3\3\3\3\3\4\3\4"+
		"\3\5\3\5\3\5\3\5\3\6\3\6\3\6\3\7\3\7\3\7\3\b\3\b\3\b\3\b\3\b\3\b\3\t\3"+
		"\t\3\t\3\n\3\n\3\n\3\n\3\n\3\n\3\n\3\13\3\13\3\13\3\13\3\13\3\f\3\f\3"+
		"\f\3\f\3\f\3\r\3\r\3\16\3\16\3\17\6\17]\n\17\r\17\16\17^\3\17\3\17\3\20"+
		"\5\20d\n\20\3\21\3\21\3\22\3\22\3\22\3\22\3\22\3\22\3\22\5\22o\n\22\3"+
		"\23\6\23r\n\23\r\23\16\23s\3\23\6\23w\n\23\r\23\16\23x\5\23{\n\23\3\24"+
		"\6\24~\n\24\r\24\16\24\177\3\25\3\25\3\25\6\25\u0085\n\25\r\25\16\25\u0086"+
		"\3\25\3\25\3\26\6\26\u008c\n\26\r\26\16\26\u008d\3\26\3\26\2\2\27\3\3"+
		"\5\4\7\5\t\6\13\7\r\b\17\t\21\n\23\13\25\f\27\r\31\16\33\17\35\20\37\21"+
		"!\22#\23%\24\'\25)\26+\27\3\2\t\3\3==\5\2,-//\61\61\4\2C\\c|\3\2\62;\3"+
		"\2))\5\2\62;C\\c|\5\2\13\f\17\17\"\"\2\u009b\2\3\3\2\2\2\2\5\3\2\2\2\2"+
		"\7\3\2\2\2\2\t\3\2\2\2\2\13\3\2\2\2\2\r\3\2\2\2\2\17\3\2\2\2\2\21\3\2"+
		"\2\2\2\23\3\2\2\2\2\25\3\2\2\2\2\27\3\2\2\2\2\31\3\2\2\2\2\33\3\2\2\2"+
		"\2\35\3\2\2\2\2\37\3\2\2\2\2!\3\2\2\2\2#\3\2\2\2\2%\3\2\2\2\2\'\3\2\2"+
		"\2\2)\3\2\2\2\2+\3\2\2\2\3-\3\2\2\2\5/\3\2\2\2\7\61\3\2\2\2\t\63\3\2\2"+
		"\2\13\67\3\2\2\2\r:\3\2\2\2\17=\3\2\2\2\21C\3\2\2\2\23F\3\2\2\2\25M\3"+
		"\2\2\2\27R\3\2\2\2\31W\3\2\2\2\33Y\3\2\2\2\35\\\3\2\2\2\37c\3\2\2\2!e"+
		"\3\2\2\2#n\3\2\2\2%q\3\2\2\2\'}\3\2\2\2)\u0081\3\2\2\2+\u008b\3\2\2\2"+
		"-.\7?\2\2.\4\3\2\2\2/\60\7*\2\2\60\6\3\2\2\2\61\62\7+\2\2\62\b\3\2\2\2"+
		"\63\64\7C\2\2\64\65\7P\2\2\65\66\7F\2\2\66\n\3\2\2\2\678\7Q\2\289\7T\2"+
		"\29\f\3\2\2\2:;\7C\2\2;<\7U\2\2<\16\3\2\2\2=>\7Y\2\2>?\7J\2\2?@\7G\2\2"+
		"@A\7T\2\2AB\7G\2\2B\20\3\2\2\2CD\7Q\2\2DE\7P\2\2E\22\3\2\2\2FG\7U\2\2"+
		"GH\7G\2\2HI\7N\2\2IJ\7G\2\2JK\7E\2\2KL\7V\2\2L\24\3\2\2\2MN\7H\2\2NO\7"+
		"T\2\2OP\7Q\2\2PQ\7O\2\2Q\26\3\2\2\2RS\7L\2\2ST\7Q\2\2TU\7K\2\2UV\7P\2"+
		"\2V\30\3\2\2\2WX\7\60\2\2X\32\3\2\2\2YZ\7.\2\2Z\34\3\2\2\2[]\7\"\2\2\\"+
		"[\3\2\2\2]^\3\2\2\2^\\\3\2\2\2^_\3\2\2\2_`\3\2\2\2`a\b\17\2\2a\36\3\2"+
		"\2\2bd\t\2\2\2cb\3\2\2\2d \3\2\2\2ef\t\3\2\2f\"\3\2\2\2go\4>@\2hi\7>\2"+
		"\2io\7?\2\2jk\7@\2\2ko\7?\2\2lo\5\t\5\2mo\5\13\6\2ng\3\2\2\2nh\3\2\2\2"+
		"nj\3\2\2\2nl\3\2\2\2nm\3\2\2\2o$\3\2\2\2pr\t\4\2\2qp\3\2\2\2rs\3\2\2\2"+
		"sq\3\2\2\2st\3\2\2\2tz\3\2\2\2uw\t\5\2\2vu\3\2\2\2wx\3\2\2\2xv\3\2\2\2"+
		"xy\3\2\2\2y{\3\2\2\2zv\3\2\2\2z{\3\2\2\2{&\3\2\2\2|~\t\5\2\2}|\3\2\2\2"+
		"~\177\3\2\2\2\177}\3\2\2\2\177\u0080\3\2\2\2\u0080(\3\2\2\2\u0081\u0084"+
		"\7)\2\2\u0082\u0083\n\6\2\2\u0083\u0085\t\7\2\2\u0084\u0082\3\2\2\2\u0085"+
		"\u0086\3\2\2\2\u0086\u0084\3\2\2\2\u0086\u0087\3\2\2\2\u0087\u0088\3\2"+
		"\2\2\u0088\u0089\7)\2\2\u0089*\3\2\2\2\u008a\u008c\t\b\2\2\u008b\u008a"+
		"\3\2\2\2\u008c\u008d\3\2\2\2\u008d\u008b\3\2\2\2\u008d\u008e\3\2\2\2\u008e"+
		"\u008f\3\2\2\2\u008f\u0090\b\26\3\2\u0090,\3\2\2\2\r\2^cnqsxz\177\u0086"+
		"\u008d\4\2\3\2\b\2\2";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}