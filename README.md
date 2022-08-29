# AntlrParserTrial
Ten projekt zawiera bardzo okrojoną wersję parsera SQL.

Pliki utworzone w pełni przeze mnie:<br>
SQL.g4<br>
Program.cs<br>
SQLListenerSelectBase.cs<br>
SQLListenerSelectJoined.cs<br>
IColumnParser.cs<br>
Projekt: SQLParserTester.csproj<br>

Większość podstawowych funkcji typu SELECT oraz funkcji SELECT z zastosowaniem JOIN powinno działać.

Zastosowane zostały testy dla obu rodzajów SELECTa

Plik SQL.g4 zawiera własnoręcznie napisane zasady dla ANTLR4 bazowane na <a href="https://github.com/antlr/grammars-v4/tree/master/sql/mysql/Positive-Technologies">ANTLR Grammars v4</a>

Folder Mysql zawieraja parser i lexer na którym bazowałem swój research.
Folder Grammar zawiera starą wersję użytego SQLParsera przed zmianą nazwy.
