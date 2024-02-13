namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct POINTER_INFO
    {
        public POINTER_INPUT_TYPE pointerType;
        public int pointerId;
        public int frameId;
        public int pointerFlags;
        public IntPtr sourceDevice;
        public IntPtr hwndTarget;
        public POINT ptPixelLocation;
        public POINT ptHimetricLocation;
        public POINT ptPixelLocationRaw;
        public POINT ptHimetricLocationRaw;
        public uint dwTime;
        public int historyCount;
        public int InputData;
        public uint dwKeyStates;
        public int PerformanceCount;
        public POINTER_BUTTON_CHANGE_TYPE ButtonChangeType;
    }



}