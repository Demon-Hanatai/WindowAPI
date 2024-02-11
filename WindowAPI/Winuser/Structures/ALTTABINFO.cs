
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ALTTABINFO
    {
        public uint cbSize;
        public IntPtr cItems;
        public IntPtr cColumns;
        public IntPtr cRows;
        public IntPtr iColFocus;
        public IntPtr iRowFocus;
        public IntPtr cxItem;
        public IntPtr cyItem;
        public IntPtr ptStart;
    }



}