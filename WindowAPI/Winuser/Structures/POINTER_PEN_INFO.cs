namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct POINTER_PEN_INFO
    {
        public POINTER_INFO pointerInfo;
        public int penFlags;
        public int penMask;
        public int pressure;
        public int rotation;
        public int tiltX;
        public int tiltY;
    }



}