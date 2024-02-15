namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct POINTER_TOUCH_INFO
    {
        public POINTER_INFO pointerInfo;
        public nint touchFlags;
        public nint touchMask;
        public RECT rcContact;
        public RECT rcContactRaw;
        public int orientation;
        public int pressure;
    }



}