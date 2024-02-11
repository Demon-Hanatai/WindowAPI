
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct POINTER_DEVICE_PROPERTY
    {
        public IntPtr logicalMin;
        public IntPtr logicalMax;
        public IntPtr physicalMin;
        public IntPtr physicalMax;
        public IntPtr unit;
        public IntPtr unitExponent;
        public ushort usagePageId;
        public ushort usageId;
    }



}