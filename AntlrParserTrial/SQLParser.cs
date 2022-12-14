//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.10.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from SQL.g4 by ANTLR 4.10.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.CLSCompliant(false)]
public partial class SQLParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, AND=4, OR=5, AS=6, WHERE=7, ON=8, SELECT=9, FROM=10, 
		JOIN=11, DOT=12, COMMA=13, SPACE=14, EOL=15, MATH_SIGN=16, BOOL_OPS=17, 
		IDENTIFIER=18, NUMBER=19, STRING=20, WS=21;
	public const int
		RULE_statement = 0, RULE_basicSelectStatement = 1, RULE_joinedSelectStatement = 2, 
		RULE_basicSelector = 3, RULE_joinedSelector = 4, RULE_basicTargetter = 5, 
		RULE_joinedTargetter = 6, RULE_joinedMatcher = 7, RULE_whereLookup = 8, 
		RULE_asStatement = 9, RULE_variableAssignmentIdentifier = 10, RULE_specificIdentifier = 11, 
		RULE_function = 12, RULE_boolFunction = 13, RULE_variable = 14;
	public static readonly string[] ruleNames = {
		"statement", "basicSelectStatement", "joinedSelectStatement", "basicSelector", 
		"joinedSelector", "basicTargetter", "joinedTargetter", "joinedMatcher", 
		"whereLookup", "asStatement", "variableAssignmentIdentifier", "specificIdentifier", 
		"function", "boolFunction", "variable"
	};

	private static readonly string[] _LiteralNames = {
		null, "'='", "'('", "')'", "'AND'", "'OR'", "'AS'", "'WHERE'", "'ON'", 
		"'SELECT'", "'FROM'", "'JOIN'", "'.'", "','"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, "AND", "OR", "AS", "WHERE", "ON", "SELECT", "FROM", 
		"JOIN", "DOT", "COMMA", "SPACE", "EOL", "MATH_SIGN", "BOOL_OPS", "IDENTIFIER", 
		"NUMBER", "STRING", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "SQL.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static SQLParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public SQLParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public SQLParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class StatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EOL() { return GetToken(SQLParser.EOL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BasicSelectStatementContext basicSelectStatement() {
			return GetRuleContext<BasicSelectStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public JoinedSelectStatementContext joinedSelectStatement() {
			return GetRuleContext<JoinedSelectStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public WhereLookupContext whereLookup() {
			return GetRuleContext<WhereLookupContext>(0);
		}
		public StatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLListener typedListener = listener as ISQLListener;
			if (typedListener != null) typedListener.EnterStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLListener typedListener = listener as ISQLListener;
			if (typedListener != null) typedListener.ExitStatement(this);
		}
	}

	[RuleVersion(0)]
	public StatementContext statement() {
		StatementContext _localctx = new StatementContext(Context, State);
		EnterRule(_localctx, 0, RULE_statement);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 32;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,0,Context) ) {
			case 1:
				{
				State = 30;
				basicSelectStatement();
				}
				break;
			case 2:
				{
				State = 31;
				joinedSelectStatement();
				}
				break;
			}
			State = 35;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WHERE) {
				{
				State = 34;
				whereLookup();
				}
			}

			State = 37;
			Match(EOL);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BasicSelectStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public BasicSelectorContext basicSelector() {
			return GetRuleContext<BasicSelectorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public BasicTargetterContext basicTargetter() {
			return GetRuleContext<BasicTargetterContext>(0);
		}
		public BasicSelectStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_basicSelectStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLListener typedListener = listener as ISQLListener;
			if (typedListener != null) typedListener.EnterBasicSelectStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLListener typedListener = listener as ISQLListener;
			if (typedListener != null) typedListener.ExitBasicSelectStatement(this);
		}
	}

	[RuleVersion(0)]
	public BasicSelectStatementContext basicSelectStatement() {
		BasicSelectStatementContext _localctx = new BasicSelectStatementContext(Context, State);
		EnterRule(_localctx, 2, RULE_basicSelectStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 39;
			basicSelector();
			State = 40;
			basicTargetter();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class JoinedSelectStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public JoinedSelectorContext joinedSelector() {
			return GetRuleContext<JoinedSelectorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public JoinedTargetterContext joinedTargetter() {
			return GetRuleContext<JoinedTargetterContext>(0);
		}
		public JoinedSelectStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_joinedSelectStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLListener typedListener = listener as ISQLListener;
			if (typedListener != null) typedListener.EnterJoinedSelectStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLListener typedListener = listener as ISQLListener;
			if (typedListener != null) typedListener.ExitJoinedSelectStatement(this);
		}
	}

	[RuleVersion(0)]
	public JoinedSelectStatementContext joinedSelectStatement() {
		JoinedSelectStatementContext _localctx = new JoinedSelectStatementContext(Context, State);
		EnterRule(_localctx, 4, RULE_joinedSelectStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 42;
			joinedSelector();
			State = 43;
			joinedTargetter();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BasicSelectorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SELECT() { return GetToken(SQLParser.SELECT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] IDENTIFIER() { return GetTokens(SQLParser.IDENTIFIER); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IDENTIFIER(int i) {
			return GetToken(SQLParser.IDENTIFIER, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLParser.COMMA, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AsStatementContext[] asStatement() {
			return GetRuleContexts<AsStatementContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AsStatementContext asStatement(int i) {
			return GetRuleContext<AsStatementContext>(i);
		}
		public BasicSelectorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_basicSelector; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLListener typedListener = listener as ISQLListener;
			if (typedListener != null) typedListener.EnterBasicSelector(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLListener typedListener = listener as ISQLListener;
			if (typedListener != null) typedListener.ExitBasicSelector(this);
		}
	}

	[RuleVersion(0)]
	public BasicSelectorContext basicSelector() {
		BasicSelectorContext _localctx = new BasicSelectorContext(Context, State);
		EnterRule(_localctx, 6, RULE_basicSelector);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 45;
			Match(SELECT);
			State = 46;
			Match(IDENTIFIER);
			State = 54;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 47;
				Match(COMMA);
				State = 50;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,2,Context) ) {
				case 1:
					{
					State = 48;
					Match(IDENTIFIER);
					}
					break;
				case 2:
					{
					State = 49;
					asStatement();
					}
					break;
				}
				}
				}
				State = 56;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class JoinedSelectorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SELECT() { return GetToken(SQLParser.SELECT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public SpecificIdentifierContext[] specificIdentifier() {
			return GetRuleContexts<SpecificIdentifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public SpecificIdentifierContext specificIdentifier(int i) {
			return GetRuleContext<SpecificIdentifierContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLParser.COMMA, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AsStatementContext[] asStatement() {
			return GetRuleContexts<AsStatementContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AsStatementContext asStatement(int i) {
			return GetRuleContext<AsStatementContext>(i);
		}
		public JoinedSelectorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_joinedSelector; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLListener typedListener = listener as ISQLListener;
			if (typedListener != null) typedListener.EnterJoinedSelector(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLListener typedListener = listener as ISQLListener;
			if (typedListener != null) typedListener.ExitJoinedSelector(this);
		}
	}

	[RuleVersion(0)]
	public JoinedSelectorContext joinedSelector() {
		JoinedSelectorContext _localctx = new JoinedSelectorContext(Context, State);
		EnterRule(_localctx, 8, RULE_joinedSelector);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 57;
			Match(SELECT);
			State = 58;
			specificIdentifier();
			State = 66;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 59;
				Match(COMMA);
				State = 62;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,4,Context) ) {
				case 1:
					{
					State = 60;
					specificIdentifier();
					}
					break;
				case 2:
					{
					State = 61;
					asStatement();
					}
					break;
				}
				}
				}
				State = 68;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BasicTargetterContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FROM() { return GetToken(SQLParser.FROM, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public SpecificIdentifierContext specificIdentifier() {
			return GetRuleContext<SpecificIdentifierContext>(0);
		}
		public BasicTargetterContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_basicTargetter; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLListener typedListener = listener as ISQLListener;
			if (typedListener != null) typedListener.EnterBasicTargetter(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLListener typedListener = listener as ISQLListener;
			if (typedListener != null) typedListener.ExitBasicTargetter(this);
		}
	}

	[RuleVersion(0)]
	public BasicTargetterContext basicTargetter() {
		BasicTargetterContext _localctx = new BasicTargetterContext(Context, State);
		EnterRule(_localctx, 10, RULE_basicTargetter);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 69;
			Match(FROM);
			State = 70;
			specificIdentifier();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class JoinedTargetterContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FROM() { return GetToken(SQLParser.FROM, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public VariableAssignmentIdentifierContext[] variableAssignmentIdentifier() {
			return GetRuleContexts<VariableAssignmentIdentifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableAssignmentIdentifierContext variableAssignmentIdentifier(int i) {
			return GetRuleContext<VariableAssignmentIdentifierContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode JOIN() { return GetToken(SQLParser.JOIN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ON() { return GetToken(SQLParser.ON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public JoinedMatcherContext joinedMatcher() {
			return GetRuleContext<JoinedMatcherContext>(0);
		}
		public JoinedTargetterContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_joinedTargetter; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLListener typedListener = listener as ISQLListener;
			if (typedListener != null) typedListener.EnterJoinedTargetter(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLListener typedListener = listener as ISQLListener;
			if (typedListener != null) typedListener.ExitJoinedTargetter(this);
		}
	}

	[RuleVersion(0)]
	public JoinedTargetterContext joinedTargetter() {
		JoinedTargetterContext _localctx = new JoinedTargetterContext(Context, State);
		EnterRule(_localctx, 12, RULE_joinedTargetter);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 72;
			Match(FROM);
			State = 73;
			variableAssignmentIdentifier();
			State = 74;
			Match(JOIN);
			State = 75;
			variableAssignmentIdentifier();
			State = 76;
			Match(ON);
			State = 77;
			joinedMatcher();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class JoinedMatcherContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public SpecificIdentifierContext[] specificIdentifier() {
			return GetRuleContexts<SpecificIdentifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public SpecificIdentifierContext specificIdentifier(int i) {
			return GetRuleContext<SpecificIdentifierContext>(i);
		}
		public JoinedMatcherContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_joinedMatcher; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLListener typedListener = listener as ISQLListener;
			if (typedListener != null) typedListener.EnterJoinedMatcher(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLListener typedListener = listener as ISQLListener;
			if (typedListener != null) typedListener.ExitJoinedMatcher(this);
		}
	}

	[RuleVersion(0)]
	public JoinedMatcherContext joinedMatcher() {
		JoinedMatcherContext _localctx = new JoinedMatcherContext(Context, State);
		EnterRule(_localctx, 14, RULE_joinedMatcher);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 79;
			specificIdentifier();
			State = 80;
			Match(T__0);
			State = 81;
			specificIdentifier();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class WhereLookupContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHERE() { return GetToken(SQLParser.WHERE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public VariableContext[] variable() {
			return GetRuleContexts<VariableContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableContext variable(int i) {
			return GetRuleContext<VariableContext>(i);
		}
		public WhereLookupContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_whereLookup; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLListener typedListener = listener as ISQLListener;
			if (typedListener != null) typedListener.EnterWhereLookup(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLListener typedListener = listener as ISQLListener;
			if (typedListener != null) typedListener.ExitWhereLookup(this);
		}
	}

	[RuleVersion(0)]
	public WhereLookupContext whereLookup() {
		WhereLookupContext _localctx = new WhereLookupContext(Context, State);
		EnterRule(_localctx, 16, RULE_whereLookup);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 83;
			Match(WHERE);
			State = 85;
			ErrorHandler.Sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					State = 84;
					variable();
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 87;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,6,Context);
			} while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AsStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public SpecificIdentifierContext[] specificIdentifier() {
			return GetRuleContexts<SpecificIdentifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public SpecificIdentifierContext specificIdentifier(int i) {
			return GetRuleContext<SpecificIdentifierContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AS() { return GetToken(SQLParser.AS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IDENTIFIER() { return GetToken(SQLParser.IDENTIFIER, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] MATH_SIGN() { return GetTokens(SQLParser.MATH_SIGN); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MATH_SIGN(int i) {
			return GetToken(SQLParser.MATH_SIGN, i);
		}
		public AsStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_asStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLListener typedListener = listener as ISQLListener;
			if (typedListener != null) typedListener.EnterAsStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLListener typedListener = listener as ISQLListener;
			if (typedListener != null) typedListener.ExitAsStatement(this);
		}
	}

	[RuleVersion(0)]
	public AsStatementContext asStatement() {
		AsStatementContext _localctx = new AsStatementContext(Context, State);
		EnterRule(_localctx, 18, RULE_asStatement);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 89;
			specificIdentifier();
			State = 94;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==MATH_SIGN) {
				{
				{
				State = 90;
				Match(MATH_SIGN);
				State = 91;
				specificIdentifier();
				}
				}
				State = 96;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 97;
			Match(AS);
			State = 98;
			Match(IDENTIFIER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class VariableAssignmentIdentifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] IDENTIFIER() { return GetTokens(SQLParser.IDENTIFIER); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IDENTIFIER(int i) {
			return GetToken(SQLParser.IDENTIFIER, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public SpecificIdentifierContext specificIdentifier() {
			return GetRuleContext<SpecificIdentifierContext>(0);
		}
		public VariableAssignmentIdentifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_variableAssignmentIdentifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLListener typedListener = listener as ISQLListener;
			if (typedListener != null) typedListener.EnterVariableAssignmentIdentifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLListener typedListener = listener as ISQLListener;
			if (typedListener != null) typedListener.ExitVariableAssignmentIdentifier(this);
		}
	}

	[RuleVersion(0)]
	public VariableAssignmentIdentifierContext variableAssignmentIdentifier() {
		VariableAssignmentIdentifierContext _localctx = new VariableAssignmentIdentifierContext(Context, State);
		EnterRule(_localctx, 20, RULE_variableAssignmentIdentifier);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 102;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,8,Context) ) {
			case 1:
				{
				State = 100;
				specificIdentifier();
				}
				break;
			case 2:
				{
				State = 101;
				Match(IDENTIFIER);
				}
				break;
			}
			State = 104;
			Match(IDENTIFIER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SpecificIdentifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] IDENTIFIER() { return GetTokens(SQLParser.IDENTIFIER); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IDENTIFIER(int i) {
			return GetToken(SQLParser.IDENTIFIER, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(SQLParser.DOT, 0); }
		public SpecificIdentifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_specificIdentifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLListener typedListener = listener as ISQLListener;
			if (typedListener != null) typedListener.EnterSpecificIdentifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLListener typedListener = listener as ISQLListener;
			if (typedListener != null) typedListener.ExitSpecificIdentifier(this);
		}
	}

	[RuleVersion(0)]
	public SpecificIdentifierContext specificIdentifier() {
		SpecificIdentifierContext _localctx = new SpecificIdentifierContext(Context, State);
		EnterRule(_localctx, 22, RULE_specificIdentifier);
		try {
			State = 110;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,9,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				{
				State = 106;
				Match(IDENTIFIER);
				State = 107;
				Match(DOT);
				State = 108;
				Match(IDENTIFIER);
				}
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 109;
				Match(IDENTIFIER);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FunctionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IDENTIFIER() { return GetToken(SQLParser.IDENTIFIER, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public VariableContext[] variable() {
			return GetRuleContexts<VariableContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableContext variable(int i) {
			return GetRuleContext<VariableContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLParser.COMMA, i);
		}
		public FunctionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_function; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLListener typedListener = listener as ISQLListener;
			if (typedListener != null) typedListener.EnterFunction(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLListener typedListener = listener as ISQLListener;
			if (typedListener != null) typedListener.ExitFunction(this);
		}
	}

	[RuleVersion(0)]
	public FunctionContext function() {
		FunctionContext _localctx = new FunctionContext(Context, State);
		EnterRule(_localctx, 24, RULE_function);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 112;
			Match(IDENTIFIER);
			State = 113;
			Match(T__1);
			State = 122;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << AND) | (1L << OR) | (1L << AS) | (1L << WHERE) | (1L << ON) | (1L << SELECT) | (1L << FROM) | (1L << JOIN) | (1L << DOT) | (1L << COMMA) | (1L << SPACE) | (1L << EOL) | (1L << MATH_SIGN) | (1L << BOOL_OPS) | (1L << IDENTIFIER) | (1L << NUMBER) | (1L << STRING) | (1L << WS))) != 0)) {
				{
				State = 114;
				variable();
				State = 119;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==COMMA) {
					{
					{
					State = 115;
					Match(COMMA);
					State = 116;
					variable();
					}
					}
					State = 121;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				}
			}

			State = 124;
			Match(T__2);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BoolFunctionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BOOL_OPS() { return GetToken(SQLParser.BOOL_OPS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public VariableContext[] variable() {
			return GetRuleContexts<VariableContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableContext variable(int i) {
			return GetRuleContext<VariableContext>(i);
		}
		public BoolFunctionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_boolFunction; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLListener typedListener = listener as ISQLListener;
			if (typedListener != null) typedListener.EnterBoolFunction(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLListener typedListener = listener as ISQLListener;
			if (typedListener != null) typedListener.ExitBoolFunction(this);
		}
	}

	[RuleVersion(0)]
	public BoolFunctionContext boolFunction() {
		BoolFunctionContext _localctx = new BoolFunctionContext(Context, State);
		EnterRule(_localctx, 26, RULE_boolFunction);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 127;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,12,Context) ) {
			case 1:
				{
				State = 126;
				Match(T__1);
				}
				break;
			}
			{
			State = 129;
			_la = TokenStream.LA(1);
			if ( _la <= 0 || (_la==T__2) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			{
			State = 130;
			variable();
			}
			State = 131;
			Match(BOOL_OPS);
			{
			State = 132;
			variable();
			}
			}
			State = 135;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,13,Context) ) {
			case 1:
				{
				State = 134;
				Match(T__2);
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class VariableContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STRING() { return GetToken(SQLParser.STRING, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NUMBER() { return GetToken(SQLParser.NUMBER, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IDENTIFIER() { return GetToken(SQLParser.IDENTIFIER, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public SpecificIdentifierContext specificIdentifier() {
			return GetRuleContext<SpecificIdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public FunctionContext function() {
			return GetRuleContext<FunctionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public BoolFunctionContext boolFunction() {
			return GetRuleContext<BoolFunctionContext>(0);
		}
		public VariableContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_variable; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLListener typedListener = listener as ISQLListener;
			if (typedListener != null) typedListener.EnterVariable(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLListener typedListener = listener as ISQLListener;
			if (typedListener != null) typedListener.ExitVariable(this);
		}
	}

	[RuleVersion(0)]
	public VariableContext variable() {
		VariableContext _localctx = new VariableContext(Context, State);
		EnterRule(_localctx, 28, RULE_variable);
		try {
			State = 143;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,14,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 137;
				Match(STRING);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 138;
				Match(NUMBER);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 139;
				Match(IDENTIFIER);
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 140;
				specificIdentifier();
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 141;
				function();
				}
				break;
			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 142;
				boolFunction();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static int[] _serializedATN = {
		4,1,21,146,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,2,7,
		7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,7,14,
		1,0,1,0,3,0,33,8,0,1,0,3,0,36,8,0,1,0,1,0,1,1,1,1,1,1,1,2,1,2,1,2,1,3,
		1,3,1,3,1,3,1,3,3,3,51,8,3,5,3,53,8,3,10,3,12,3,56,9,3,1,4,1,4,1,4,1,4,
		1,4,3,4,63,8,4,5,4,65,8,4,10,4,12,4,68,9,4,1,5,1,5,1,5,1,6,1,6,1,6,1,6,
		1,6,1,6,1,6,1,7,1,7,1,7,1,7,1,8,1,8,4,8,86,8,8,11,8,12,8,87,1,9,1,9,1,
		9,5,9,93,8,9,10,9,12,9,96,9,9,1,9,1,9,1,9,1,10,1,10,3,10,103,8,10,1,10,
		1,10,1,11,1,11,1,11,1,11,3,11,111,8,11,1,12,1,12,1,12,1,12,1,12,5,12,118,
		8,12,10,12,12,12,121,9,12,3,12,123,8,12,1,12,1,12,1,13,3,13,128,8,13,1,
		13,1,13,1,13,1,13,1,13,1,13,3,13,136,8,13,1,14,1,14,1,14,1,14,1,14,1,14,
		3,14,144,8,14,1,14,0,0,15,0,2,4,6,8,10,12,14,16,18,20,22,24,26,28,0,1,
		1,0,3,3,149,0,32,1,0,0,0,2,39,1,0,0,0,4,42,1,0,0,0,6,45,1,0,0,0,8,57,1,
		0,0,0,10,69,1,0,0,0,12,72,1,0,0,0,14,79,1,0,0,0,16,83,1,0,0,0,18,89,1,
		0,0,0,20,102,1,0,0,0,22,110,1,0,0,0,24,112,1,0,0,0,26,127,1,0,0,0,28,143,
		1,0,0,0,30,33,3,2,1,0,31,33,3,4,2,0,32,30,1,0,0,0,32,31,1,0,0,0,33,35,
		1,0,0,0,34,36,3,16,8,0,35,34,1,0,0,0,35,36,1,0,0,0,36,37,1,0,0,0,37,38,
		5,15,0,0,38,1,1,0,0,0,39,40,3,6,3,0,40,41,3,10,5,0,41,3,1,0,0,0,42,43,
		3,8,4,0,43,44,3,12,6,0,44,5,1,0,0,0,45,46,5,9,0,0,46,54,5,18,0,0,47,50,
		5,13,0,0,48,51,5,18,0,0,49,51,3,18,9,0,50,48,1,0,0,0,50,49,1,0,0,0,51,
		53,1,0,0,0,52,47,1,0,0,0,53,56,1,0,0,0,54,52,1,0,0,0,54,55,1,0,0,0,55,
		7,1,0,0,0,56,54,1,0,0,0,57,58,5,9,0,0,58,66,3,22,11,0,59,62,5,13,0,0,60,
		63,3,22,11,0,61,63,3,18,9,0,62,60,1,0,0,0,62,61,1,0,0,0,63,65,1,0,0,0,
		64,59,1,0,0,0,65,68,1,0,0,0,66,64,1,0,0,0,66,67,1,0,0,0,67,9,1,0,0,0,68,
		66,1,0,0,0,69,70,5,10,0,0,70,71,3,22,11,0,71,11,1,0,0,0,72,73,5,10,0,0,
		73,74,3,20,10,0,74,75,5,11,0,0,75,76,3,20,10,0,76,77,5,8,0,0,77,78,3,14,
		7,0,78,13,1,0,0,0,79,80,3,22,11,0,80,81,5,1,0,0,81,82,3,22,11,0,82,15,
		1,0,0,0,83,85,5,7,0,0,84,86,3,28,14,0,85,84,1,0,0,0,86,87,1,0,0,0,87,85,
		1,0,0,0,87,88,1,0,0,0,88,17,1,0,0,0,89,94,3,22,11,0,90,91,5,16,0,0,91,
		93,3,22,11,0,92,90,1,0,0,0,93,96,1,0,0,0,94,92,1,0,0,0,94,95,1,0,0,0,95,
		97,1,0,0,0,96,94,1,0,0,0,97,98,5,6,0,0,98,99,5,18,0,0,99,19,1,0,0,0,100,
		103,3,22,11,0,101,103,5,18,0,0,102,100,1,0,0,0,102,101,1,0,0,0,103,104,
		1,0,0,0,104,105,5,18,0,0,105,21,1,0,0,0,106,107,5,18,0,0,107,108,5,12,
		0,0,108,111,5,18,0,0,109,111,5,18,0,0,110,106,1,0,0,0,110,109,1,0,0,0,
		111,23,1,0,0,0,112,113,5,18,0,0,113,122,5,2,0,0,114,119,3,28,14,0,115,
		116,5,13,0,0,116,118,3,28,14,0,117,115,1,0,0,0,118,121,1,0,0,0,119,117,
		1,0,0,0,119,120,1,0,0,0,120,123,1,0,0,0,121,119,1,0,0,0,122,114,1,0,0,
		0,122,123,1,0,0,0,123,124,1,0,0,0,124,125,5,3,0,0,125,25,1,0,0,0,126,128,
		5,2,0,0,127,126,1,0,0,0,127,128,1,0,0,0,128,129,1,0,0,0,129,130,8,0,0,
		0,130,131,3,28,14,0,131,132,5,17,0,0,132,133,3,28,14,0,133,135,1,0,0,0,
		134,136,5,3,0,0,135,134,1,0,0,0,135,136,1,0,0,0,136,27,1,0,0,0,137,144,
		5,20,0,0,138,144,5,19,0,0,139,144,5,18,0,0,140,144,3,22,11,0,141,144,3,
		24,12,0,142,144,3,26,13,0,143,137,1,0,0,0,143,138,1,0,0,0,143,139,1,0,
		0,0,143,140,1,0,0,0,143,141,1,0,0,0,143,142,1,0,0,0,144,29,1,0,0,0,15,
		32,35,50,54,62,66,87,94,102,110,119,122,127,135,143
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
