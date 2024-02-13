namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TOUCH_HIT_TESTING_INPUT
    {
        public int pointerId;
        public POINT point;
        public RECT boundingBox;
        public RECT nonOccludedBoundingBox;
        public int orientation;
    }



}