// Generated from d:\GitHub\Antlr_Trial\AntlrParserTrial\AntlrParserTrial\Grammar.g4 by ANTLR 4.9.2
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class GrammarParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.9.2", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		SELECT=1, FROM=2, JOIN=3, DOT=4, COMMA=5, SPACE=6, EOL=7, IDENTIFIER=8, 
		VARNAME=9, WS=10;
	public static final int
		RULE_statement = 0, RULE_basicSelectStatement = 1, RULE_joinedSelectStatement = 2, 
		RULE_basicSelector = 3, RULE_joinedSelector = 4, RULE_basicTargetter = 5, 
		RULE_joinedTargetter = 6, RULE_bextidentifier = 7, RULE_varassidentifier = 8, 
		RULE_sidentifier = 9;
	private static String[] makeRuleNames() {
		return new String[] {
			"statement", "basicSelectStatement", "joinedSelectStatement", "basicSelector", 
			"joinedSelector", "basicTargetter", "joinedTargetter", "bextidentifier", 
			"varassidentifier", "sidentifier"
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

	@Override
	public String getGrammarFileName() { return "Grammar.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public GrammarParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	public static class StatementContext extends ParserRuleContext {
		public BasicSelectStatementContext basicSelectStatement() {
			return getRuleContext(BasicSelectStatementContext.class,0);
		}
		public JoinedSelectStatementContext joinedSelectStatement() {
			return getRuleContext(JoinedSelectStatementContext.class,0);
		}
		public StatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_statement; }
	}

	public final StatementContext statement() throws RecognitionException {
		StatementContext _localctx = new StatementContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_statement);
		try {
			setState(22);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,0,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(20);
				basicSelectStatement();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(21);
				joinedSelectStatement();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class BasicSelectStatementContext extends ParserRuleContext {
		public BasicSelectorContext basicSelector() {
			return getRuleContext(BasicSelectorContext.class,0);
		}
		public BasicTargetterContext basicTargetter() {
			return getRuleContext(BasicTargetterContext.class,0);
		}
		public BasicSelectStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_basicSelectStatement; }
	}

	public final BasicSelectStatementContext basicSelectStatement() throws RecognitionException {
		BasicSelectStatementContext _localctx = new BasicSelectStatementContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_basicSelectStatement);
		try {
			enterOuterAlt(_localctx, 1);
			{
			{
			setState(24);
			basicSelector();
			setState(25);
			basicTargetter();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class JoinedSelectStatementContext extends ParserRuleContext {
		public JoinedSelectorContext joinedSelector() {
			return getRuleContext(JoinedSelectorContext.class,0);
		}
		public JoinedTargetterContext joinedTargetter() {
			return getRuleContext(JoinedTargetterContext.class,0);
		}
		public JoinedSelectStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_joinedSelectStatement; }
	}

	public final JoinedSelectStatementContext joinedSelectStatement() throws RecognitionException {
		JoinedSelectStatementContext _localctx = new JoinedSelectStatementContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_joinedSelectStatement);
		try {
			enterOuterAlt(_localctx, 1);
			{
			{
			setState(27);
			joinedSelector();
			setState(28);
			joinedTargetter();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class BasicSelectorContext extends ParserRuleContext {
		public TerminalNode SELECT() { return getToken(GrammarParser.SELECT, 0); }
		public TerminalNode IDENTIFIER() { return getToken(GrammarParser.IDENTIFIER, 0); }
		public List<BextidentifierContext> bextidentifier() {
			return getRuleContexts(BextidentifierContext.class);
		}
		public BextidentifierContext bextidentifier(int i) {
			return getRuleContext(BextidentifierContext.class,i);
		}
		public BasicSelectorContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_basicSelector; }
	}

	public final BasicSelectorContext basicSelector() throws RecognitionException {
		BasicSelectorContext _localctx = new BasicSelectorContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_basicSelector);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(30);
			match(SELECT);
			setState(31);
			match(IDENTIFIER);
			setState(35);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,1,_ctx);
			while ( _alt!=1 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1+1 ) {
					{
					{
					setState(32);
					bextidentifier();
					}
					} 
				}
				setState(37);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,1,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class JoinedSelectorContext extends ParserRuleContext {
		public TerminalNode SELECT() { return getToken(GrammarParser.SELECT, 0); }
		public List<SidentifierContext> sidentifier() {
			return getRuleContexts(SidentifierContext.class);
		}
		public SidentifierContext sidentifier(int i) {
			return getRuleContext(SidentifierContext.class,i);
		}
		public List<TerminalNode> COMMA() { return getTokens(GrammarParser.COMMA); }
		public TerminalNode COMMA(int i) {
			return getToken(GrammarParser.COMMA, i);
		}
		public JoinedSelectorContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_joinedSelector; }
	}

	public final JoinedSelectorContext joinedSelector() throws RecognitionException {
		JoinedSelectorContext _localctx = new JoinedSelectorContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_joinedSelector);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(38);
			match(SELECT);
			setState(39);
			sidentifier();
			setState(44);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,2,_ctx);
			while ( _alt!=1 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1+1 ) {
					{
					{
					setState(40);
					match(COMMA);
					setState(41);
					sidentifier();
					}
					} 
				}
				setState(46);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,2,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class BasicTargetterContext extends ParserRuleContext {
		public TerminalNode FROM() { return getToken(GrammarParser.FROM, 0); }
		public TerminalNode IDENTIFIER() { return getToken(GrammarParser.IDENTIFIER, 0); }
		public BasicTargetterContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_basicTargetter; }
	}

	public final BasicTargetterContext basicTargetter() throws RecognitionException {
		BasicTargetterContext _localctx = new BasicTargetterContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_basicTargetter);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(47);
			match(FROM);
			setState(48);
			match(IDENTIFIER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class JoinedTargetterContext extends ParserRuleContext {
		public TerminalNode FROM() { return getToken(GrammarParser.FROM, 0); }
		public List<VarassidentifierContext> varassidentifier() {
			return getRuleContexts(VarassidentifierContext.class);
		}
		public VarassidentifierContext varassidentifier(int i) {
			return getRuleContext(VarassidentifierContext.class,i);
		}
		public TerminalNode JOIN() { return getToken(GrammarParser.JOIN, 0); }
		public JoinedTargetterContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_joinedTargetter; }
	}

	public final JoinedTargetterContext joinedTargetter() throws RecognitionException {
		JoinedTargetterContext _localctx = new JoinedTargetterContext(_ctx, getState());
		enterRule(_localctx, 12, RULE_joinedTargetter);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(50);
			match(FROM);
			setState(51);
			varassidentifier();
			setState(52);
			match(JOIN);
			setState(53);
			varassidentifier();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class BextidentifierContext extends ParserRuleContext {
		public TerminalNode COMMA() { return getToken(GrammarParser.COMMA, 0); }
		public TerminalNode IDENTIFIER() { return getToken(GrammarParser.IDENTIFIER, 0); }
		public BextidentifierContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_bextidentifier; }
	}

	public final BextidentifierContext bextidentifier() throws RecognitionException {
		BextidentifierContext _localctx = new BextidentifierContext(_ctx, getState());
		enterRule(_localctx, 14, RULE_bextidentifier);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(55);
			match(COMMA);
			setState(56);
			match(IDENTIFIER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class VarassidentifierContext extends ParserRuleContext {
		public TerminalNode IDENTIFIER() { return getToken(GrammarParser.IDENTIFIER, 0); }
		public TerminalNode VARNAME() { return getToken(GrammarParser.VARNAME, 0); }
		public VarassidentifierContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_varassidentifier; }
	}

	public final VarassidentifierContext varassidentifier() throws RecognitionException {
		VarassidentifierContext _localctx = new VarassidentifierContext(_ctx, getState());
		enterRule(_localctx, 16, RULE_varassidentifier);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(58);
			match(IDENTIFIER);
			setState(59);
			match(VARNAME);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class SidentifierContext extends ParserRuleContext {
		public TerminalNode VARNAME() { return getToken(GrammarParser.VARNAME, 0); }
		public TerminalNode DOT() { return getToken(GrammarParser.DOT, 0); }
		public TerminalNode IDENTIFIER() { return getToken(GrammarParser.IDENTIFIER, 0); }
		public SidentifierContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_sidentifier; }
	}

	public final SidentifierContext sidentifier() throws RecognitionException {
		SidentifierContext _localctx = new SidentifierContext(_ctx, getState());
		enterRule(_localctx, 18, RULE_sidentifier);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(61);
			match(VARNAME);
			setState(62);
			match(DOT);
			setState(63);
			match(IDENTIFIER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3\fD\4\2\t\2\4\3\t"+
		"\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13\t\13\3"+
		"\2\3\2\5\2\31\n\2\3\3\3\3\3\3\3\4\3\4\3\4\3\5\3\5\3\5\7\5$\n\5\f\5\16"+
		"\5\'\13\5\3\6\3\6\3\6\3\6\7\6-\n\6\f\6\16\6\60\13\6\3\7\3\7\3\7\3\b\3"+
		"\b\3\b\3\b\3\b\3\t\3\t\3\t\3\n\3\n\3\n\3\13\3\13\3\13\3\13\3\13\4%.\2"+
		"\f\2\4\6\b\n\f\16\20\22\24\2\2\2<\2\30\3\2\2\2\4\32\3\2\2\2\6\35\3\2\2"+
		"\2\b \3\2\2\2\n(\3\2\2\2\f\61\3\2\2\2\16\64\3\2\2\2\209\3\2\2\2\22<\3"+
		"\2\2\2\24?\3\2\2\2\26\31\5\4\3\2\27\31\5\6\4\2\30\26\3\2\2\2\30\27\3\2"+
		"\2\2\31\3\3\2\2\2\32\33\5\b\5\2\33\34\5\f\7\2\34\5\3\2\2\2\35\36\5\n\6"+
		"\2\36\37\5\16\b\2\37\7\3\2\2\2 !\7\3\2\2!%\7\n\2\2\"$\5\20\t\2#\"\3\2"+
		"\2\2$\'\3\2\2\2%&\3\2\2\2%#\3\2\2\2&\t\3\2\2\2\'%\3\2\2\2()\7\3\2\2)."+
		"\5\24\13\2*+\7\7\2\2+-\5\24\13\2,*\3\2\2\2-\60\3\2\2\2./\3\2\2\2.,\3\2"+
		"\2\2/\13\3\2\2\2\60.\3\2\2\2\61\62\7\4\2\2\62\63\7\n\2\2\63\r\3\2\2\2"+
		"\64\65\7\4\2\2\65\66\5\22\n\2\66\67\7\5\2\2\678\5\22\n\28\17\3\2\2\29"+
		":\7\7\2\2:;\7\n\2\2;\21\3\2\2\2<=\7\n\2\2=>\7\13\2\2>\23\3\2\2\2?@\7\13"+
		"\2\2@A\7\6\2\2AB\7\n\2\2B\25\3\2\2\2\5\30%.";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}