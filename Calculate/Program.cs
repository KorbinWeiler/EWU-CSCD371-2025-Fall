using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace Calculate;

public class Program
{
    public Func<string?> ReadLine { get; init; }
    public Action<string> WriteLine { get; init; }

    public Program()
    {
        ReadLine = () => { return Console.ReadLine(); };
        WriteLine = (value) => { Console.WriteLine(value);};
    }

    public Program(Func<string> readLine, Action<string> writeLine)
    {
        ReadLine = readLine;
        WriteLine = writeLine;
    }

    static void Main()
    {
        
    }
}