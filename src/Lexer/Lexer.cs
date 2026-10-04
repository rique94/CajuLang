using CajuLang.Lexer.token;

namespace CajuLang.lexer;


//class
public class Lexer
{
    private readonly string _source;
    private int _current = 0;

    //constructor
    public Lexer(string source)
    {
        _source = source;
    }

    //methods
    public List<Token> ScanTokens()
    {
        var tokens = new List<Token>();

        List<char> wordChar = new List<char>();


        while (_current < _source.Length)
        {
            char c = _source[_current];

            if (char.IsLetter(c))
            {
                wordChar.Add(c);
            }
            if (_current > 0 && !char.IsLetter(c) && char.IsLetter(_source[_current - 1]))
            {
                string word = string.Concat(wordChar);
                tokens.Add(new Token(TokenType.Identifier, word));
                wordChar.Clear();
            }
            else
            {
                //case
                switch (c)
                {


                    case '(':
                        tokens.Add(new Token(TokenType.LeftParen, "("));
                        break;

                    case ')':
                        tokens.Add(new Token(TokenType.RightParen, ")"));
                        break;
                }
            }

            _current++;
        }

        if (wordChar.Count > 0)
        {
            string word = string.Concat(wordChar);
            tokens.Add(new Token(TokenType.Identifier, word));
            wordChar.Clear();
        }

        tokens.Add(new Token(TokenType.EOF, ""));

        return tokens;
    }
}