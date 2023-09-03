%{
    int contAnd = 0, contBreak = 0, contDo = 0, contElse = 0, contElseIf = 0, contEnd = 0, contFalse = 0, contFor = 0, contFunction = 0, contIf = 0, contIn = 0, contNil = 0, contNot = 0, contOr = 0, contRepeat = 0, contReturn = 0, contThen = 0, contTrue = 0, contUntil = 0, contWhile = 0, contPrint = 0;
    int contLocal = 0;
    int linea = 1;
    int identificadores = 0, enteros = 0, flotantes = 0;
%}

%%
\n  {linea++;}
"and"                   {contAnd++; /* printf("and en %d\n", linea); */}
"break"                 {contBreak++; /* printf("break en %d\n", linea); */}
"do"                    {contDo++;}
"else"                  {contElse++;}
"elseif"                {contElseIf++;}
"end"                   {contEnd++;}
"false"                 {contFalse++;}
"for"                   {contFor++;}
"function"              {contFunction++;}
"if"                    {contIf++;}
"in"                    {contIn++;}
"local"                 {contLocal++;}
"nil"                   {contNil++;}
"not"                   {contNot++;}
"or"                    {contOr++;}
"repeat"                {contRepeat++;}
"return"                {contReturn++;}
"then"                  {contThen++;}
"true"                  {contTrue++;}
"until"                 {contUntil++;}
"while"                 {contWhile++;}
"print"                 {contPrint++;}
\".*\"                  {}
--.*                    {}
[0-9]*                  {enteros++; /* printf("%s en %d\n", yytext,linea); */}
[0-9]*\.[0-9]*            {flotantes++; /* printf("%s en %d\n", yytext,linea); */}
[[:alpha:]_][[:alnum:]_]* { identificadores++; /* printf("%s en %d\n", yytext,linea); */}
. {}
%%

int main(){
    yylex();
 /*    printf("And: %d\n", contAnd);
    printf("Break: %d\n", contBreak);
    printf("Do: %d\n", contDo);
    printf("Else: %d\n", contElse);
    printf("Else If: %d\n", contElseIf);
    printf("end: %d\n", contEnd);
    printf("false: %d\n", contFalse);
    printf("for: %d\n", contFor);
    printf("function: %d\n", contFunction);
    printf("if: %d\n", contIf);
    printf("local: %d\n", contLocal);
    printf("in: %d\n", contIn);
    printf("Nil: %d\n", contNil);
    printf("not: %d\n", contNot);
    printf("repeat: %d\n", contRepeat);
    printf("or: %d\n", contOr);
    printf("return: %d\n", contReturn);
    printf("then: %d\n", contThen);
    printf("true: %d\n", contTrue);
    printf("until: %d\n", contUntil);
    printf("while: %d\n", contWhile);
    printf("print: %d\n",contPrint); */
    /* printf("identificadores: %d\n",identificadores); */
    printf("enteros: %d\n",enteros);
    printf("flotantes: %d\n",flotantes);
    return 0;
}
