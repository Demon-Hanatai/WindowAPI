
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct POINTER_PEN_INFO
    {
        public POINTER_INFO pointerInfo;
        public IntPtr penFlags;
        public IntPtr penMask;
        public IntPtr pressure;
        public IntPtr rotation;
        public IntPtr tiltX;
        public IntPtr tiltY;
    }



}