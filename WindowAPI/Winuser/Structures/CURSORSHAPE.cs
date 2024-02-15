namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CURSORSHAPE
    {
        public int xHotSpot;
        public int yHotSpot;
        public int cx;
        public int cy;
        public int cbWidth;
        public byte Planes;
        public byte BitsPixel;
    }



}