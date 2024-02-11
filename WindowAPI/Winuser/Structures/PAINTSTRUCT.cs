
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct PAINTSTRUCT
    {
        public IntPtr hdc;
        public bool fErase;
        public IntPtr rcPaint;
        public bool fRestore;
        public bool fIncUpdate;
    }



}