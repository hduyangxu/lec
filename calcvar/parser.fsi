// Signature file for parser generated by fsyacc
module Parser
type token = 
  | EOF
  | RPAREN
  | LPAREN
  | UMINUS
  | DIVIDE
  | TIMES
  | MINUS
  | PLUS
  | EQUAL
  | VARIABLE of (string)
  | NUMERAL of (int)
type tokenId = 
    | TOKEN_EOF
    | TOKEN_RPAREN
    | TOKEN_LPAREN
    | TOKEN_UMINUS
    | TOKEN_DIVIDE
    | TOKEN_TIMES
    | TOKEN_MINUS
    | TOKEN_PLUS
    | TOKEN_EQUAL
    | TOKEN_VARIABLE
    | TOKEN_NUMERAL
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__starttoplevel
    | NONTERM_toplevel
    | NONTERM_expression
/// This function maps tokens to integer indexes
val tagOfToken: token -> int

/// This function maps integer indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val toplevel : (FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> FSharp.Text.Lexing.LexBuffer<'cty> -> (Syntax.command) 
