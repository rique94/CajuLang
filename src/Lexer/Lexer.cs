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

            //caso seja espaço vazio
            if (char.IsWhiteSpace(c))
            {
                //verificando se antes havia palavra
                if (wordChar.Count > 0)
                {
                    //gerando um token de Identifier
                    string word = string.Concat(wordChar);
                    tokens.Add(new Token(TokenType.Identifier, word));
                    wordChar.Clear();
                }
            }
            //caso seja letra, underline ou número
            else if (char.IsLetter(c) || c == '_' || (wordChar.Count > 0 && char.IsDigit(c)))
            {
                //guardando a letra
                wordChar.Add(c);
            }
            //caso a ultima tenha sido letra ou underline e agora temos um caractere especial
            else if (
                wordChar.Count > 0 &&
                !char.IsLetter(c) &&
                c != '_' &&
                !char.IsDigit(c)
            )
            {
                //cocatenando a palavra e guardando ela
                string word = string.Concat(wordChar);
                //gerando o token
                tokens.Add(new Token(TokenType.Identifier, word));
                //limpando o array de caracteres 
                wordChar.Clear();

                //criando o token
                Token token = VerifyToken(c);
                tokens.Add(token);

            }
            // caso seja um carcatere especial
            else
            {
                //chamando função que cria token
                Token token = VerifyToken(c);
                tokens.Add(token);
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

    private Token VerifyToken(char c)
    {

        Token token;
        switch (c)
        {
            case '(':
                token = new Token(TokenType.LeftParen, "(");
                return token;

            case ')':
                token = new Token(TokenType.RightParen, ")");
                return token;

            case ';':
                token = new Token(TokenType.Semicolon, ";");
                return token;

            case '\"':
                //lista de caracteres pra string depois concatenar
                List<char> chars = new List<char>();
                //pegando a string
                while (_current + 1 < _source.Length && _source[_current + 1] != '\"')
                {
                    chars.Add(_source[_current + 1]);
                    _current++;
                }
                string text = string.Concat(chars);
                token = new Token(TokenType.String, text);

                //saindo do ultimo caractere e da aspas de fechamento
                _current++;
                return token;

            default:
                token = new Token(TokenType.Error, "");
                return token;
        }


    }
}