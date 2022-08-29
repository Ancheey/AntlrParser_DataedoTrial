// Generated from d:\GitHub\Antlr_Trial\AntlrParserTrial\AntlrParserTrial\SQL.g4 by ANTLR 4.9.2
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class SQLParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.9.2", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, T__2=3, AND=4, OR=5, AS=6, WHERE=7, ON=8, SELECT=9, FROM=10, 
		JOIN=11, DOT=12, COMMA=13, SPACE=14, EOL=15, MATH_SIGN=16, BOOL_OPS=17, 
		IDENTIFIER=18, NUMBER=19, STRING=20, WS=21;
	public static final int
		RULE_statement = 0, RULE_basicSelectStatement = 1, RULE_joinedSelectStatement = 2, 
		RULE_basicSelector = 3, RULE_joinedSelector = 4, RULE_basicTargetter = 5, 
		RULE_joinedTargetter = 6, RULE_joinedMatcher = 7, RULE_whereLookup = 8, 
		RULE_asStatement = 9, RULE_variableAssignmentIdentifier = 10, RULE_specificIdentifier = 11, 
		RULE_function = 12, RULE_boolFunction = 13, RULE_variable = 14;
	private static String[] makeRuleNames() {
		return new String[] {
			"statement", "basicSelectStatement", "joinedSelectStatement", "basicSelector", 
			"joinedSelector", "basicTargetter", "joinedTargetter", "joinedMatcher", 
			"whereLookup", "asStatement", "variableAssignmentIdentifier", "specificIdentifier", 
			"function", "boolFunction", "variable"
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

	@Override
	public String getGrammarFileName() { return "SQL.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public SQLParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	public static class StatementContext extends ParserRuleContext {
		public TerminalNode EOL() { return getToken(SQLParser.EOL, 0); }
		public BasicSelectStatementContext basicSelectStatement() {
			return getRuleContext(BasicSelectStatementContext.class,0);
		}
		public JoinedSelectStatementContext joinedSelectStatement() {
			return getRuleContext(JoinedSelectStatementContext.class,0);
		}
		public WhereLookupContext whereLookup() {
			return getRuleContext(WhereLookupContext.class,0);
		}
		public StatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_statement; }
	}

	public final StatementContext statement() throws RecognitionException {
		StatementContext _localctx = new StatementContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_statement);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(32);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,0,_ctx) ) {
			case 1:
				{
				setState(30);
				basicSelectStatement();
				}
				break;
			case 2:
				{
				setState(31);
				joinedSelectStatement();
				}
				break;
			}
			setState(35);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==WHERE) {
				{
				setState(34);
				whereLookup();
				}
			}

			setState(37);
			match(EOL);
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
			setState(39);
			basicSelector();
			setState(40);
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
			setState(42);
			joinedSelector();
			setState(43);
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
		public TerminalNode SELECT() { return getToken(SQLParser.SELECT, 0); }
		public List<TerminalNode> IDENTIFIER() { return getTokens(SQLParser.IDENTIFIER); }
		public TerminalNode IDENTIFIER(int i) {
			return getToken(SQLParser.IDENTIFIER, i);
		}
		public List<TerminalNode> COMMA() { return getTokens(SQLParser.COMMA); }
		public TerminalNode COMMA(int i) {
			return getToken(SQLParser.COMMA, i);
		}
		public List<AsStatementContext> asStatement() {
			return getRuleContexts(AsStatementContext.class);
		}
		public AsStatementContext asStatement(int i) {
			return getRuleContext(AsStatementContext.class,i);
		}
		public BasicSelectorContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_basicSelector; }
	}

	public final BasicSelectorContext basicSelector() throws RecognitionException {
		BasicSelectorContext _localctx = new BasicSelectorContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_basicSelector);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(45);
			match(SELECT);
			setState(46);
			match(IDENTIFIER);
			setState(54);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==COMMA) {
				{
				{
				setState(47);
				match(COMMA);
				setState(50);
				_errHandler.sync(this);
				switch ( getInterpreter().adaptivePredict(_input,2,_ctx) ) {
				case 1:
					{
					setState(48);
					match(IDENTIFIER);
					}
					break;
				case 2:
					{
					setState(49);
					asStatement();
					}
					break;
				}
				}
				}
				setState(56);
				_errHandler.sync(this);
				_la = _input.LA(1);
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
		public TerminalNode SELECT() { return getToken(SQLParser.SELECT, 0); }
		public List<SpecificIdentifierContext> specificIdentifier() {
			return getRuleContexts(SpecificIdentifierContext.class);
		}
		public SpecificIdentifierContext specificIdentifier(int i) {
			return getRuleContext(SpecificIdentifierContext.class,i);
		}
		public List<TerminalNode> COMMA() { return getTokens(SQLParser.COMMA); }
		public TerminalNode COMMA(int i) {
			return getToken(SQLParser.COMMA, i);
		}
		public List<AsStatementContext> asStatement() {
			return getRuleContexts(AsStatementContext.class);
		}
		public AsStatementContext asStatement(int i) {
			return getRuleContext(AsStatementContext.class,i);
		}
		public JoinedSelectorContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_joinedSelector; }
	}

	public final JoinedSelectorContext joinedSelector() throws RecognitionException {
		JoinedSelectorContext _localctx = new JoinedSelectorContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_joinedSelector);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(57);
			match(SELECT);
			setState(58);
			specificIdentifier();
			setState(66);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==COMMA) {
				{
				{
				setState(59);
				match(COMMA);
				setState(62);
				_errHandler.sync(this);
				switch ( getInterpreter().adaptivePredict(_input,4,_ctx) ) {
				case 1:
					{
					setState(60);
					specificIdentifier();
					}
					break;
				case 2:
					{
					setState(61);
					asStatement();
					}
					break;
				}
				}
				}
				setState(68);
				_errHandler.sync(this);
				_la = _input.LA(1);
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
		public TerminalNode FROM() { return getToken(SQLParser.FROM, 0); }
		public SpecificIdentifierContext specificIdentifier() {
			return getRuleContext(SpecificIdentifierContext.class,0);
		}
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
			setState(69);
			match(FROM);
			setState(70);
			specificIdentifier();
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
		public TerminalNode FROM() { return getToken(SQLParser.FROM, 0); }
		public List<VariableAssignmentIdentifierContext> variableAssignmentIdentifier() {
			return getRuleContexts(VariableAssignmentIdentifierContext.class);
		}
		public VariableAssignmentIdentifierContext variableAssignmentIdentifier(int i) {
			return getRuleContext(VariableAssignmentIdentifierContext.class,i);
		}
		public TerminalNode JOIN() { return getToken(SQLParser.JOIN, 0); }
		public TerminalNode ON() { return getToken(SQLParser.ON, 0); }
		public JoinedMatcherContext joinedMatcher() {
			return getRuleContext(JoinedMatcherContext.class,0);
		}
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
			setState(72);
			match(FROM);
			setState(73);
			variableAssignmentIdentifier();
			setState(74);
			match(JOIN);
			setState(75);
			variableAssignmentIdentifier();
			setState(76);
			match(ON);
			setState(77);
			joinedMatcher();
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

	public static class JoinedMatcherContext extends ParserRuleContext {
		public List<SpecificIdentifierContext> specificIdentifier() {
			return getRuleContexts(SpecificIdentifierContext.class);
		}
		public SpecificIdentifierContext specificIdentifier(int i) {
			return getRuleContext(SpecificIdentifierContext.class,i);
		}
		public JoinedMatcherContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_joinedMatcher; }
	}

	public final JoinedMatcherContext joinedMatcher() throws RecognitionException {
		JoinedMatcherContext _localctx = new JoinedMatcherContext(_ctx, getState());
		enterRule(_localctx, 14, RULE_joinedMatcher);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(79);
			specificIdentifier();
			setState(80);
			match(T__0);
			setState(81);
			specificIdentifier();
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

	public static class WhereLookupContext extends ParserRuleContext {
		public TerminalNode WHERE() { return getToken(SQLParser.WHERE, 0); }
		public List<VariableContext> variable() {
			return getRuleContexts(VariableContext.class);
		}
		public VariableContext variable(int i) {
			return getRuleContext(VariableContext.class,i);
		}
		public WhereLookupContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_whereLookup; }
	}

	public final WhereLookupContext whereLookup() throws RecognitionException {
		WhereLookupContext _localctx = new WhereLookupContext(_ctx, getState());
		enterRule(_localctx, 16, RULE_whereLookup);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(83);
			match(WHERE);
			setState(85); 
			_errHandler.sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					setState(84);
					variable();
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				setState(87); 
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,6,_ctx);
			} while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER );
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

	public static class AsStatementContext extends ParserRuleContext {
		public List<SpecificIdentifierContext> specificIdentifier() {
			return getRuleContexts(SpecificIdentifierContext.class);
		}
		public SpecificIdentifierContext specificIdentifier(int i) {
			return getRuleContext(SpecificIdentifierContext.class,i);
		}
		public TerminalNode AS() { return getToken(SQLParser.AS, 0); }
		public TerminalNode IDENTIFIER() { return getToken(SQLParser.IDENTIFIER, 0); }
		public List<TerminalNode> MATH_SIGN() { return getTokens(SQLParser.MATH_SIGN); }
		public TerminalNode MATH_SIGN(int i) {
			return getToken(SQLParser.MATH_SIGN, i);
		}
		public AsStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_asStatement; }
	}

	public final AsStatementContext asStatement() throws RecognitionException {
		AsStatementContext _localctx = new AsStatementContext(_ctx, getState());
		enterRule(_localctx, 18, RULE_asStatement);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(89);
			specificIdentifier();
			setState(94);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==MATH_SIGN) {
				{
				{
				setState(90);
				match(MATH_SIGN);
				setState(91);
				specificIdentifier();
				}
				}
				setState(96);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(97);
			match(AS);
			setState(98);
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

	public static class VariableAssignmentIdentifierContext extends ParserRuleContext {
		public List<TerminalNode> IDENTIFIER() { return getTokens(SQLParser.IDENTIFIER); }
		public TerminalNode IDENTIFIER(int i) {
			return getToken(SQLParser.IDENTIFIER, i);
		}
		public SpecificIdentifierContext specificIdentifier() {
			return getRuleContext(SpecificIdentifierContext.class,0);
		}
		public VariableAssignmentIdentifierContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_variableAssignmentIdentifier; }
	}

	public final VariableAssignmentIdentifierContext variableAssignmentIdentifier() throws RecognitionException {
		VariableAssignmentIdentifierContext _localctx = new VariableAssignmentIdentifierContext(_ctx, getState());
		enterRule(_localctx, 20, RULE_variableAssignmentIdentifier);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(102);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,8,_ctx) ) {
			case 1:
				{
				setState(100);
				specificIdentifier();
				}
				break;
			case 2:
				{
				setState(101);
				match(IDENTIFIER);
				}
				break;
			}
			setState(104);
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

	public static class SpecificIdentifierContext extends ParserRuleContext {
		public List<TerminalNode> IDENTIFIER() { return getTokens(SQLParser.IDENTIFIER); }
		public TerminalNode IDENTIFIER(int i) {
			return getToken(SQLParser.IDENTIFIER, i);
		}
		public TerminalNode DOT() { return getToken(SQLParser.DOT, 0); }
		public SpecificIdentifierContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_specificIdentifier; }
	}

	public final SpecificIdentifierContext specificIdentifier() throws RecognitionException {
		SpecificIdentifierContext _localctx = new SpecificIdentifierContext(_ctx, getState());
		enterRule(_localctx, 22, RULE_specificIdentifier);
		try {
			setState(110);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,9,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				{
				setState(106);
				match(IDENTIFIER);
				setState(107);
				match(DOT);
				setState(108);
				match(IDENTIFIER);
				}
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(109);
				match(IDENTIFIER);
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

	public static class FunctionContext extends ParserRuleContext {
		public TerminalNode IDENTIFIER() { return getToken(SQLParser.IDENTIFIER, 0); }
		public List<VariableContext> variable() {
			return getRuleContexts(VariableContext.class);
		}
		public VariableContext variable(int i) {
			return getRuleContext(VariableContext.class,i);
		}
		public List<TerminalNode> COMMA() { return getTokens(SQLParser.COMMA); }
		public TerminalNode COMMA(int i) {
			return getToken(SQLParser.COMMA, i);
		}
		public FunctionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_function; }
	}

	public final FunctionContext function() throws RecognitionException {
		FunctionContext _localctx = new FunctionContext(_ctx, getState());
		enterRule(_localctx, 24, RULE_function);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(112);
			match(IDENTIFIER);
			setState(113);
			match(T__1);
			setState(122);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << AND) | (1L << OR) | (1L << AS) | (1L << WHERE) | (1L << ON) | (1L << SELECT) | (1L << FROM) | (1L << JOIN) | (1L << DOT) | (1L << COMMA) | (1L << SPACE) | (1L << EOL) | (1L << MATH_SIGN) | (1L << BOOL_OPS) | (1L << IDENTIFIER) | (1L << NUMBER) | (1L << STRING) | (1L << WS))) != 0)) {
				{
				setState(114);
				variable();
				setState(119);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while (_la==COMMA) {
					{
					{
					setState(115);
					match(COMMA);
					setState(116);
					variable();
					}
					}
					setState(121);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				}
			}

			setState(124);
			match(T__2);
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

	public static class BoolFunctionContext extends ParserRuleContext {
		public TerminalNode BOOL_OPS() { return getToken(SQLParser.BOOL_OPS, 0); }
		public List<VariableContext> variable() {
			return getRuleContexts(VariableContext.class);
		}
		public VariableContext variable(int i) {
			return getRuleContext(VariableContext.class,i);
		}
		public BoolFunctionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_boolFunction; }
	}

	public final BoolFunctionContext boolFunction() throws RecognitionException {
		BoolFunctionContext _localctx = new BoolFunctionContext(_ctx, getState());
		enterRule(_localctx, 26, RULE_boolFunction);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(127);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,12,_ctx) ) {
			case 1:
				{
				setState(126);
				match(T__1);
				}
				break;
			}
			{
			setState(129);
			_la = _input.LA(1);
			if ( _la <= 0 || (_la==T__2) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			{
			setState(130);
			variable();
			}
			setState(131);
			match(BOOL_OPS);
			{
			setState(132);
			variable();
			}
			}
			setState(135);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,13,_ctx) ) {
			case 1:
				{
				setState(134);
				match(T__2);
				}
				break;
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

	public static class VariableContext extends ParserRuleContext {
		public TerminalNode STRING() { return getToken(SQLParser.STRING, 0); }
		public TerminalNode NUMBER() { return getToken(SQLParser.NUMBER, 0); }
		public TerminalNode IDENTIFIER() { return getToken(SQLParser.IDENTIFIER, 0); }
		public SpecificIdentifierContext specificIdentifier() {
			return getRuleContext(SpecificIdentifierContext.class,0);
		}
		public FunctionContext function() {
			return getRuleContext(FunctionContext.class,0);
		}
		public BoolFunctionContext boolFunction() {
			return getRuleContext(BoolFunctionContext.class,0);
		}
		public VariableContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_variable; }
	}

	public final VariableContext variable() throws RecognitionException {
		VariableContext _localctx = new VariableContext(_ctx, getState());
		enterRule(_localctx, 28, RULE_variable);
		try {
			setState(143);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,14,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(137);
				match(STRING);
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(138);
				match(NUMBER);
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
				setState(139);
				match(IDENTIFIER);
				}
				break;
			case 4:
				enterOuterAlt(_localctx, 4);
				{
				setState(140);
				specificIdentifier();
				}
				break;
			case 5:
				enterOuterAlt(_localctx, 5);
				{
				setState(141);
				function();
				}
				break;
			case 6:
				enterOuterAlt(_localctx, 6);
				{
				setState(142);
				boolFunction();
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

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3\27\u0094\4\2\t\2"+
		"\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13"+
		"\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\3\2\3\2\5\2#\n\2\3"+
		"\2\5\2&\n\2\3\2\3\2\3\3\3\3\3\3\3\4\3\4\3\4\3\5\3\5\3\5\3\5\3\5\5\5\65"+
		"\n\5\7\5\67\n\5\f\5\16\5:\13\5\3\6\3\6\3\6\3\6\3\6\5\6A\n\6\7\6C\n\6\f"+
		"\6\16\6F\13\6\3\7\3\7\3\7\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\t\3\t\3\t\3\t"+
		"\3\n\3\n\6\nX\n\n\r\n\16\nY\3\13\3\13\3\13\7\13_\n\13\f\13\16\13b\13\13"+
		"\3\13\3\13\3\13\3\f\3\f\5\fi\n\f\3\f\3\f\3\r\3\r\3\r\3\r\5\rq\n\r\3\16"+
		"\3\16\3\16\3\16\3\16\7\16x\n\16\f\16\16\16{\13\16\5\16}\n\16\3\16\3\16"+
		"\3\17\5\17\u0082\n\17\3\17\3\17\3\17\3\17\3\17\3\17\5\17\u008a\n\17\3"+
		"\20\3\20\3\20\3\20\3\20\3\20\5\20\u0092\n\20\3\20\2\2\21\2\4\6\b\n\f\16"+
		"\20\22\24\26\30\32\34\36\2\3\3\2\5\5\2\u0097\2\"\3\2\2\2\4)\3\2\2\2\6"+
		",\3\2\2\2\b/\3\2\2\2\n;\3\2\2\2\fG\3\2\2\2\16J\3\2\2\2\20Q\3\2\2\2\22"+
		"U\3\2\2\2\24[\3\2\2\2\26h\3\2\2\2\30p\3\2\2\2\32r\3\2\2\2\34\u0081\3\2"+
		"\2\2\36\u0091\3\2\2\2 #\5\4\3\2!#\5\6\4\2\" \3\2\2\2\"!\3\2\2\2#%\3\2"+
		"\2\2$&\5\22\n\2%$\3\2\2\2%&\3\2\2\2&\'\3\2\2\2\'(\7\21\2\2(\3\3\2\2\2"+
		")*\5\b\5\2*+\5\f\7\2+\5\3\2\2\2,-\5\n\6\2-.\5\16\b\2.\7\3\2\2\2/\60\7"+
		"\13\2\2\608\7\24\2\2\61\64\7\17\2\2\62\65\7\24\2\2\63\65\5\24\13\2\64"+
		"\62\3\2\2\2\64\63\3\2\2\2\65\67\3\2\2\2\66\61\3\2\2\2\67:\3\2\2\28\66"+
		"\3\2\2\289\3\2\2\29\t\3\2\2\2:8\3\2\2\2;<\7\13\2\2<D\5\30\r\2=@\7\17\2"+
		"\2>A\5\30\r\2?A\5\24\13\2@>\3\2\2\2@?\3\2\2\2AC\3\2\2\2B=\3\2\2\2CF\3"+
		"\2\2\2DB\3\2\2\2DE\3\2\2\2E\13\3\2\2\2FD\3\2\2\2GH\7\f\2\2HI\5\30\r\2"+
		"I\r\3\2\2\2JK\7\f\2\2KL\5\26\f\2LM\7\r\2\2MN\5\26\f\2NO\7\n\2\2OP\5\20"+
		"\t\2P\17\3\2\2\2QR\5\30\r\2RS\7\3\2\2ST\5\30\r\2T\21\3\2\2\2UW\7\t\2\2"+
		"VX\5\36\20\2WV\3\2\2\2XY\3\2\2\2YW\3\2\2\2YZ\3\2\2\2Z\23\3\2\2\2[`\5\30"+
		"\r\2\\]\7\22\2\2]_\5\30\r\2^\\\3\2\2\2_b\3\2\2\2`^\3\2\2\2`a\3\2\2\2a"+
		"c\3\2\2\2b`\3\2\2\2cd\7\b\2\2de\7\24\2\2e\25\3\2\2\2fi\5\30\r\2gi\7\24"+
		"\2\2hf\3\2\2\2hg\3\2\2\2ij\3\2\2\2jk\7\24\2\2k\27\3\2\2\2lm\7\24\2\2m"+
		"n\7\16\2\2nq\7\24\2\2oq\7\24\2\2pl\3\2\2\2po\3\2\2\2q\31\3\2\2\2rs\7\24"+
		"\2\2s|\7\4\2\2ty\5\36\20\2uv\7\17\2\2vx\5\36\20\2wu\3\2\2\2x{\3\2\2\2"+
		"yw\3\2\2\2yz\3\2\2\2z}\3\2\2\2{y\3\2\2\2|t\3\2\2\2|}\3\2\2\2}~\3\2\2\2"+
		"~\177\7\5\2\2\177\33\3\2\2\2\u0080\u0082\7\4\2\2\u0081\u0080\3\2\2\2\u0081"+
		"\u0082\3\2\2\2\u0082\u0083\3\2\2\2\u0083\u0084\n\2\2\2\u0084\u0085\5\36"+
		"\20\2\u0085\u0086\7\23\2\2\u0086\u0087\5\36\20\2\u0087\u0089\3\2\2\2\u0088"+
		"\u008a\7\5\2\2\u0089\u0088\3\2\2\2\u0089\u008a\3\2\2\2\u008a\35\3\2\2"+
		"\2\u008b\u0092\7\26\2\2\u008c\u0092\7\25\2\2\u008d\u0092\7\24\2\2\u008e"+
		"\u0092\5\30\r\2\u008f\u0092\5\32\16\2\u0090\u0092\5\34\17\2\u0091\u008b"+
		"\3\2\2\2\u0091\u008c\3\2\2\2\u0091\u008d\3\2\2\2\u0091\u008e\3\2\2\2\u0091"+
		"\u008f\3\2\2\2\u0091\u0090\3\2\2\2\u0092\37\3\2\2\2\21\"%\648@DY`hpy|"+
		"\u0081\u0089\u0091";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}