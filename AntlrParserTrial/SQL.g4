grammar SQL;


statement: 
    (basicSelectStatement | joinedSelectStatement) whereLookup? EOL
;

basicSelectStatement: (basicSelector basicTargetter);
joinedSelectStatement: (joinedSelector joinedTargetter);

basicSelector:
    SELECT IDENTIFIER (COMMA (IDENTIFIER | asStatement))*
;
joinedSelector:
    SELECT specificIdentifier (COMMA (specificIdentifier | asStatement))*
;
basicTargetter:
    FROM specificIdentifier
;
joinedTargetter:
    FROM  variableAssignmentIdentifier JOIN variableAssignmentIdentifier ON joinedMatcher
;
joinedMatcher:
    specificIdentifier '=' specificIdentifier
;
whereLookup:
    WHERE (variable)+
;
asStatement:
    specificIdentifier (MATH_SIGN specificIdentifier)* AS IDENTIFIER
;
variableAssignmentIdentifier:
    (specificIdentifier | IDENTIFIER) IDENTIFIER
;
specificIdentifier: 
    (IDENTIFIER DOT IDENTIFIER) | IDENTIFIER
;
function:
    IDENTIFIER '(' (variable (COMMA variable)*)? ')'
;
boolFunction:
    ('(')?(~(')')(variable) BOOL_OPS (variable))(')')?
;
variable:
    STRING | NUMBER | IDENTIFIER | specificIdentifier | function | boolFunction
;


AND     : 'AND';
OR      : 'OR';
AS      : 'AS';
WHERE   : 'WHERE';
ON      : 'ON';
SELECT  : 'SELECT';
FROM    : 'FROM';
JOIN    : 'JOIN';
DOT     : '.';
COMMA   : ',';
SPACE   : ' '+ -> channel(HIDDEN);
EOL     : EOF | ';';
MATH_SIGN : '/' | '*' | '-' | '+';
BOOL_OPS : '>' | '<' | '='| '<=' | '>=' | AND | OR;
IDENTIFIER:
    ([A-Z] | [a-z])+([0-9]+)?
;
NUMBER:
[0-9]+
;
STRING:
'\''(~'\'' [a-zA-Z0-9])+'\''
;

WS      : [ \t\r\n]+ -> skip;