
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SERIALKEYSW
    {
        public IntPtr cbSize;
        public uint dwFlags;
        public string lpszActivePort;
        public string lpszPort;
        public IntPtr iBaudRate;
        public IntPtr iPortState;
        public IntPtr iActive;
    }



}