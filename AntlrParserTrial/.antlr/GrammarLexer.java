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
public class GrammarLexer extends Lexer {
	static { RuntimeMetaData.checkVersion("4.9.2", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		SELECT=1, FROM=2, JOIN=3, DOT=4, COMMA=5, SPACE=6, EOL=7, IDENTIFIER=8, 
		VARNAME=9, WS=10;
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	private static String[] makeRuleNames() {
		return new String[] {
			"SELECT", "FROM", "JOIN", "DOT", "COMMA", "SPACE", "EOL", "IDENTIFIER", 
			"VARNAME", "WS"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "'SELECT'", "'FROM'", "'JOIN'", "'.'", "','"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, "SELECT", "FROM", "JOIN", "DOT", "COMMA", "SPACE", "EOL", "IDENTIFIER", 
			"VARNAME", "WS"
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


	public GrammarLexer(CharStream input) {
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
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\2\fn\b\1\4\2\t\2\4"+
		"\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13\t"+
		"\13\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\3\3\3\3\3\3\3\3\3\3\4\3\4\3\4\3\4\3"+
		"\4\3\5\3\5\3\6\3\6\3\7\6\7.\n\7\r\7\16\7/\3\7\3\7\3\b\5\b\65\n\b\3\t\3"+
		"\t\3\t\3\t\7\t;\n\t\f\t\16\t>\13\t\3\t\3\t\3\t\3\t\3\t\7\tE\n\t\f\t\16"+
		"\tH\13\t\3\t\3\t\3\t\7\tM\n\t\f\t\16\tP\13\t\3\t\3\t\3\t\7\tU\n\t\f\t"+
		"\16\tX\13\t\5\tZ\n\t\3\n\6\n]\n\n\r\n\16\n^\3\n\6\nb\n\n\r\n\16\nc\5\n"+
		"f\n\n\3\13\6\13i\n\13\r\13\16\13j\3\13\3\13\2\2\f\3\3\5\4\7\5\t\6\13\7"+
		"\r\b\17\t\21\n\23\13\25\f\3\2\13\3\3==\3\2$$\3\2bb\3\2__\4\2C\\aa\6\2"+
		"\62;C\\aac|\4\2C\\c|\3\2\62;\5\2\13\f\17\17\"\"\2{\2\3\3\2\2\2\2\5\3\2"+
		"\2\2\2\7\3\2\2\2\2\t\3\2\2\2\2\13\3\2\2\2\2\r\3\2\2\2\2\17\3\2\2\2\2\21"+
		"\3\2\2\2\2\23\3\2\2\2\2\25\3\2\2\2\3\27\3\2\2\2\5\36\3\2\2\2\7#\3\2\2"+
		"\2\t(\3\2\2\2\13*\3\2\2\2\r-\3\2\2\2\17\64\3\2\2\2\21Y\3\2\2\2\23\\\3"+
		"\2\2\2\25h\3\2\2\2\27\30\7U\2\2\30\31\7G\2\2\31\32\7N\2\2\32\33\7G\2\2"+
		"\33\34\7E\2\2\34\35\7V\2\2\35\4\3\2\2\2\36\37\7H\2\2\37 \7T\2\2 !\7Q\2"+
		"\2!\"\7O\2\2\"\6\3\2\2\2#$\7L\2\2$%\7Q\2\2%&\7K\2\2&\'\7P\2\2\'\b\3\2"+
		"\2\2()\7\60\2\2)\n\3\2\2\2*+\7.\2\2+\f\3\2\2\2,.\7\"\2\2-,\3\2\2\2./\3"+
		"\2\2\2/-\3\2\2\2/\60\3\2\2\2\60\61\3\2\2\2\61\62\b\7\2\2\62\16\3\2\2\2"+
		"\63\65\t\2\2\2\64\63\3\2\2\2\65\20\3\2\2\2\66<\7$\2\2\67;\n\3\2\289\7"+
		"$\2\29;\7$\2\2:\67\3\2\2\2:8\3\2\2\2;>\3\2\2\2<:\3\2\2\2<=\3\2\2\2=?\3"+
		"\2\2\2><\3\2\2\2?Z\7$\2\2@F\7b\2\2AE\n\4\2\2BC\7b\2\2CE\7b\2\2DA\3\2\2"+
		"\2DB\3\2\2\2EH\3\2\2\2FD\3\2\2\2FG\3\2\2\2GI\3\2\2\2HF\3\2\2\2IZ\7b\2"+
		"\2JN\7]\2\2KM\n\5\2\2LK\3\2\2\2MP\3\2\2\2NL\3\2\2\2NO\3\2\2\2OQ\3\2\2"+
		"\2PN\3\2\2\2QZ\7_\2\2RV\t\6\2\2SU\t\7\2\2TS\3\2\2\2UX\3\2\2\2VT\3\2\2"+
		"\2VW\3\2\2\2WZ\3\2\2\2XV\3\2\2\2Y\66\3\2\2\2Y@\3\2\2\2YJ\3\2\2\2YR\3\2"+
		"\2\2Z\22\3\2\2\2[]\t\b\2\2\\[\3\2\2\2]^\3\2\2\2^\\\3\2\2\2^_\3\2\2\2_"+
		"e\3\2\2\2`b\t\t\2\2a`\3\2\2\2bc\3\2\2\2ca\3\2\2\2cd\3\2\2\2df\3\2\2\2"+
		"ea\3\2\2\2ef\3\2\2\2f\24\3\2\2\2gi\t\n\2\2hg\3\2\2\2ij\3\2\2\2jh\3\2\2"+
		"\2jk\3\2\2\2kl\3\2\2\2lm\b\13\3\2m\26\3\2\2\2\20\2/\64:<DFNVY^cej\4\2"+
		"\3\2\b\2\2";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}