using CajuLang.lexer;
using CajuLang.Lexer.token;

namespace Main;

public class Program
{
    public static void Main(string[] args)
    {
        string filePath = args[0];
        Console.WriteLine(filePath);

        string source = File.ReadAllText(filePath);

        //criando o bjeto Lexer pra poder criar os tokens
        Lexer lexer = new Lexer(source);
        List<Token> tokens = lexer.ScanTokens();
        for (int i = 0; i < tokens.Count; i++)
        {
            Console.WriteLine($"{tokens[i].Type} -> \"{tokens[i].Value}\""); 
        }
    }
}