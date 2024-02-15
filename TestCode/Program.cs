using WindowAPI.windef.Structures;
using WindowAPI.winuser.h.Structures;
using static WindowAPI.wingdi.Functions;
using static WindowAPI.winuser.Functions;
using static WindowAPI.console.Functions;
class Program
{

    static unsafe void Main()
    {
        string e = "HELLOWORLD";
        IntPtr r = new IntPtr(&e);
        Console.ReadLine();
    }
}
