
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct HIGHCONTRASTW
    {
        public IntPtr cbSize;
        public uint dwFlags;
        public string lpszDefaultScheme;
    }



}