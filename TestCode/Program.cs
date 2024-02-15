using WindowAPI.windef.Structures;
using WindowAPI.winuser.Structures;
using static WindowAPI.wingdi.Functions;
using static WindowAPI.winuser.Functions;
using static WindowAPI.console.Functions;
class Program
{

    static unsafe void Main()
    {
        GetWindowTextA(GetTopWindow(IntPtr.Zero),out string e, 200);
        Console.WriteLine(e);
        Console.ReadLine();
    }
}
