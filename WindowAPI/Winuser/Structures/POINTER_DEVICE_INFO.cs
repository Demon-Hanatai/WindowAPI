
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct POINTER_DEVICE_INFO
    {
        public uint displayOrientation;
        public IntPtr device;
        public IntPtr pointerDeviceType;
        public IntPtr monitor;
        public uint startingCursorId;
        public ushort maxActiveContacts;
    }



}