namespace CajuLang.Lexer.token;

public enum TokenType
{
    Identifier,
    String,

    LeftParen,
    RightParen,
    Semicolon,

    EOF
}
public class Token
{
    //atributtes
    public TokenType Type {get;}
    public string? Value {get;}

    //constructor
    public Token (TokenType token, string value)
    {
        Type = token;
        Value = value;
    }
}