namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct POINTER_DEVICE_INFO
    {
        public uint displayOrientation;
        public IntPtr device;
        public POINTER_DEVICE_TYPE pointerDeviceType;
        public IntPtr monitor;
        public uint startingCursorId;
        public ushort maxActiveContacts;
        public StringBuilder productString;
    }



}