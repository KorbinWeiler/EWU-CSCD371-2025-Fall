using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace Calculate;

public class Program
{
    private Func<string> ReadLine { get; set; }
    private Func<bool> WriteLine { get; set; }

    public Program()
    {
        ReadLine = () => { return Console.ReadLine(); };
        WriteLine = () => { Console.WriteLine(); return true; };
    }

    public Program(Func<string> readLine, Func<bool> writeLine)
    {
        ReadLine = readLine;
        WriteLine = writeLine;
    }
}