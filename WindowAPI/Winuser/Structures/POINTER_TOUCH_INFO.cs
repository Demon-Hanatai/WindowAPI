
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct POINTER_TOUCH_INFO
    {
        public POINTER_INFO pointerInfo;
        public IntPtr touchFlags;
        public IntPtr touchMask;
        public IntPtr rcContact;
        public IntPtr rcContactRaw;
        public IntPtr orientation;
        public IntPtr pressure;
    }



}