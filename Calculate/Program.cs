using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace Calculate;

public class ProgramBase
{
    public Func<string?> ReadLine { get; init; }
    public Func<bool> WriteLine { get; init; }

    public ProgramBase()
    {
        ReadLine = () => { return Console.ReadLine(); };
        WriteLine = () => { Console.WriteLine(); return true; };
    }

    public ProgramBase(Func<string> readLine, Func<bool> writeLine)
    {
        ReadLine = readLine;
        WriteLine = writeLine;
    }

    static void Main()
    {
        
    }
}