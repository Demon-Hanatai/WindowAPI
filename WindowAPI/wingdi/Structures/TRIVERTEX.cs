namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TRIVERTEX
    {
        public int x;
        public int y;
        public int Red;
        public int Green;
        public int Blue;
        public int Alpha;
    }



}