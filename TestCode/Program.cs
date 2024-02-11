using System.Runtime.InteropServices;
using WindowAPI.Winbase.h;



namespace Program
{
    public unsafe class Program
    {
       
        public static void Main(string[] args)
        {
            IntPtr h = Functions.LocalAlloc(0, 300);
            *(byte*)h = 34;
            Console.WriteLine(*(byte*)h);
            Console.ReadLine();
        }
    
    }
}