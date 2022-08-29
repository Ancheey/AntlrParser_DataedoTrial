# AntlrParserTrial
Ten projekt zawiera bardzo okrojoną wersję parsera SQL.

Pliki utworzone w pełni przeze mnie:
SQL.g4
Program.cs
SQLListenerSelectBase.cs
SQLListenerSelectJoined.cs
IColumnParser.cs
Projekt: SQLParserTester.csproj

Większość podstawowych funkcji typu SELECT oraz funkcji SELECT z zastosowaniem JOIN powinno działać.

Zastosowane zostały testy dla obu rodzajów SELECTa

Plik SQL.g4 zawiera własnoręcznie napisane zasady dla ANTLR4 bazowane na https://github.com/antlr/grammars-v4/tree/master/sql/mysql/Positive-Technologies

Folder Mysql zawieraja parser i lexer na którym bazowałem swój research.
Folder Grammar zawiera starą wersję użytego SQLParsera przed zmianą nazwy.
