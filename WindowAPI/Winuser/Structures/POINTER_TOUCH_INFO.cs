namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct POINTER_TOUCH_INFO
    {
        public POINTER_INFO pointerInfo;
        public IntPtr touchFlags;
        public IntPtr touchMask;
        public RECT rcContact;
        public RECT rcContactRaw;
        public int orientation;
        public int pressure;
    }



}