
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct AUDIODESCRIPTION
    {
        public IntPtr cbSize;
        public bool Enabled;
        public IntPtr Locale;
    }



}