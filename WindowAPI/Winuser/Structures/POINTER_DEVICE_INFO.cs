using WindowAPI.winuser.Enums;

namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct POINTER_DEVICE_INFO
    {
        public uint displayOrientation;
        public nint device;
        public POINTER_DEVICE_TYPE pointerDeviceType;
        public nint monitor;
        public uint startingCursorId;
        public ushort maxActiveContacts;
        public StringBuilder productString;
    }



}