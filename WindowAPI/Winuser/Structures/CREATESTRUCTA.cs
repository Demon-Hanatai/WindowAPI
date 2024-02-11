
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CREATESTRUCTA
    {
        public IntPtr lpCreateParams;
        public IntPtr hInstance;
        public IntPtr hMenu;
        public IntPtr hwndParent;
        public IntPtr cy;
        public IntPtr cx;
        public IntPtr y;
        public IntPtr x;
        public int style;
        public string lpszName;
        public string lpszClass;
        public uint dwExStyle;
    }



}