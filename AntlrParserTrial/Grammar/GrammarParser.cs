//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.10.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Grammar.g4 by ANTLR 4.10.1

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
public partial class GrammarParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		SELECT=1, FROM=2, JOIN=3, DOT=4, COMMA=5, SPACE=6, EOL=7, IDENTIFIER=8, 
		VARNAME=9, WS=10;
	public const int
		RULE_statement = 0, RULE_basicSelectStatement = 1, RULE_joinedSelectStatement = 2, 
		RULE_basicSelector = 3, RULE_joinedSelector = 4, RULE_basicTargetter = 5, 
		RULE_joinedTargetter = 6, RULE_bextidentifier = 7, RULE_varassidentifier = 8, 
		RULE_sidentifier = 9;
	public static readonly string[] ruleNames = {
		"statement", "basicSelectStatement", "joinedSelectStatement", "basicSelector", 
		"joinedSelector", "basicTargetter", "joinedTargetter", "bextidentifier", 
		"varassidentifier", "sidentifier"
	};

	private static readonly string[] _LiteralNames = {
		null, "'SELECT'", "'FROM'", "'JOIN'", "'.'", "','"
	};
	private static readonly string[] _SymbolicNames = {
		null, "SELECT", "FROM", "JOIN", "DOT", "COMMA", "SPACE", "EOL", "IDENTIFIER", 
		"VARNAME", "WS"
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

	public override string GrammarFileName { get { return "Grammar.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static GrammarParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public GrammarParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public GrammarParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class StatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public BasicSelectStatementContext basicSelectStatement() {
			return GetRuleContext<BasicSelectStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public JoinedSelectStatementContext joinedSelectStatement() {
			return GetRuleContext<JoinedSelectStatementContext>(0);
		}
		public StatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.EnterStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.ExitStatement(this);
		}
	}

	[RuleVersion(0)]
	public StatementContext statement() {
		StatementContext _localctx = new StatementContext(Context, State);
		EnterRule(_localctx, 0, RULE_statement);
		try {
			State = 22;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,0,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 20;
				basicSelectStatement();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 21;
				joinedSelectStatement();
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
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.EnterBasicSelectStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
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
			State = 24;
			basicSelector();
			State = 25;
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
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.EnterJoinedSelectStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
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
			State = 27;
			joinedSelector();
			State = 28;
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
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SELECT() { return GetToken(GrammarParser.SELECT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IDENTIFIER() { return GetToken(GrammarParser.IDENTIFIER, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BextidentifierContext[] bextidentifier() {
			return GetRuleContexts<BextidentifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public BextidentifierContext bextidentifier(int i) {
			return GetRuleContext<BextidentifierContext>(i);
		}
		public BasicSelectorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_basicSelector; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.EnterBasicSelector(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.ExitBasicSelector(this);
		}
	}

	[RuleVersion(0)]
	public BasicSelectorContext basicSelector() {
		BasicSelectorContext _localctx = new BasicSelectorContext(Context, State);
		EnterRule(_localctx, 6, RULE_basicSelector);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 30;
			Match(SELECT);
			State = 31;
			Match(IDENTIFIER);
			State = 35;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,1,Context);
			while ( _alt!=1 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1+1 ) {
					{
					{
					State = 32;
					bextidentifier();
					}
					} 
				}
				State = 37;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,1,Context);
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
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SELECT() { return GetToken(GrammarParser.SELECT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public SidentifierContext[] sidentifier() {
			return GetRuleContexts<SidentifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public SidentifierContext sidentifier(int i) {
			return GetRuleContext<SidentifierContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(GrammarParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(GrammarParser.COMMA, i);
		}
		public JoinedSelectorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_joinedSelector; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.EnterJoinedSelector(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.ExitJoinedSelector(this);
		}
	}

	[RuleVersion(0)]
	public JoinedSelectorContext joinedSelector() {
		JoinedSelectorContext _localctx = new JoinedSelectorContext(Context, State);
		EnterRule(_localctx, 8, RULE_joinedSelector);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 38;
			Match(SELECT);
			State = 39;
			sidentifier();
			State = 44;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,2,Context);
			while ( _alt!=1 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1+1 ) {
					{
					{
					State = 40;
					Match(COMMA);
					State = 41;
					sidentifier();
					}
					} 
				}
				State = 46;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,2,Context);
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
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FROM() { return GetToken(GrammarParser.FROM, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IDENTIFIER() { return GetToken(GrammarParser.IDENTIFIER, 0); }
		public BasicTargetterContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_basicTargetter; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.EnterBasicTargetter(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
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
			State = 47;
			Match(FROM);
			State = 48;
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

	public partial class JoinedTargetterContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FROM() { return GetToken(GrammarParser.FROM, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public VarassidentifierContext[] varassidentifier() {
			return GetRuleContexts<VarassidentifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public VarassidentifierContext varassidentifier(int i) {
			return GetRuleContext<VarassidentifierContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode JOIN() { return GetToken(GrammarParser.JOIN, 0); }
		public JoinedTargetterContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_joinedTargetter; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.EnterJoinedTargetter(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
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
			State = 50;
			Match(FROM);
			State = 51;
			varassidentifier();
			State = 52;
			Match(JOIN);
			State = 53;
			varassidentifier();
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

	public partial class BextidentifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA() { return GetToken(GrammarParser.COMMA, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IDENTIFIER() { return GetToken(GrammarParser.IDENTIFIER, 0); }
		public BextidentifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_bextidentifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.EnterBextidentifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.ExitBextidentifier(this);
		}
	}

	[RuleVersion(0)]
	public BextidentifierContext bextidentifier() {
		BextidentifierContext _localctx = new BextidentifierContext(Context, State);
		EnterRule(_localctx, 14, RULE_bextidentifier);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 55;
			Match(COMMA);
			State = 56;
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

	public partial class VarassidentifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IDENTIFIER() { return GetToken(GrammarParser.IDENTIFIER, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VARNAME() { return GetToken(GrammarParser.VARNAME, 0); }
		public VarassidentifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_varassidentifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.EnterVarassidentifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.ExitVarassidentifier(this);
		}
	}

	[RuleVersion(0)]
	public VarassidentifierContext varassidentifier() {
		VarassidentifierContext _localctx = new VarassidentifierContext(Context, State);
		EnterRule(_localctx, 16, RULE_varassidentifier);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 58;
			Match(IDENTIFIER);
			State = 59;
			Match(VARNAME);
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

	public partial class SidentifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VARNAME() { return GetToken(GrammarParser.VARNAME, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(GrammarParser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IDENTIFIER() { return GetToken(GrammarParser.IDENTIFIER, 0); }
		public SidentifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_sidentifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.EnterSidentifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.ExitSidentifier(this);
		}
	}

	[RuleVersion(0)]
	public SidentifierContext sidentifier() {
		SidentifierContext _localctx = new SidentifierContext(Context, State);
		EnterRule(_localctx, 18, RULE_sidentifier);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 61;
			Match(VARNAME);
			State = 62;
			Match(DOT);
			State = 63;
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

	private static int[] _serializedATN = {
		4,1,10,66,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,2,7,
		7,7,2,8,7,8,2,9,7,9,1,0,1,0,3,0,23,8,0,1,1,1,1,1,1,1,2,1,2,1,2,1,3,1,3,
		1,3,5,3,34,8,3,10,3,12,3,37,9,3,1,4,1,4,1,4,1,4,5,4,43,8,4,10,4,12,4,46,
		9,4,1,5,1,5,1,5,1,6,1,6,1,6,1,6,1,6,1,7,1,7,1,7,1,8,1,8,1,8,1,9,1,9,1,
		9,1,9,1,9,2,35,44,0,10,0,2,4,6,8,10,12,14,16,18,0,0,58,0,22,1,0,0,0,2,
		24,1,0,0,0,4,27,1,0,0,0,6,30,1,0,0,0,8,38,1,0,0,0,10,47,1,0,0,0,12,50,
		1,0,0,0,14,55,1,0,0,0,16,58,1,0,0,0,18,61,1,0,0,0,20,23,3,2,1,0,21,23,
		3,4,2,0,22,20,1,0,0,0,22,21,1,0,0,0,23,1,1,0,0,0,24,25,3,6,3,0,25,26,3,
		10,5,0,26,3,1,0,0,0,27,28,3,8,4,0,28,29,3,12,6,0,29,5,1,0,0,0,30,31,5,
		1,0,0,31,35,5,8,0,0,32,34,3,14,7,0,33,32,1,0,0,0,34,37,1,0,0,0,35,36,1,
		0,0,0,35,33,1,0,0,0,36,7,1,0,0,0,37,35,1,0,0,0,38,39,5,1,0,0,39,44,3,18,
		9,0,40,41,5,5,0,0,41,43,3,18,9,0,42,40,1,0,0,0,43,46,1,0,0,0,44,45,1,0,
		0,0,44,42,1,0,0,0,45,9,1,0,0,0,46,44,1,0,0,0,47,48,5,2,0,0,48,49,5,8,0,
		0,49,11,1,0,0,0,50,51,5,2,0,0,51,52,3,16,8,0,52,53,5,3,0,0,53,54,3,16,
		8,0,54,13,1,0,0,0,55,56,5,5,0,0,56,57,5,8,0,0,57,15,1,0,0,0,58,59,5,8,
		0,0,59,60,5,9,0,0,60,17,1,0,0,0,61,62,5,9,0,0,62,63,5,4,0,0,63,64,5,8,
		0,0,64,19,1,0,0,0,3,22,35,44
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
