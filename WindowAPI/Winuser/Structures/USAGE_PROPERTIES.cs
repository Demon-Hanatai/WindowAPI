
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct USAGE_PROPERTIES
    {
        public ushort level;
        public ushort page;
        public ushort usage;
        public IntPtr logicalMinimum;
        public IntPtr logicalMaximum;
        public ushort unit;
        public ushort exponent;
        public IntPtr count;
        public IntPtr physicalMinimum;
        public IntPtr physicalMaximum;
    }



}