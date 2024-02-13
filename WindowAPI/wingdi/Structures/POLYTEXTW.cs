namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct POLYTEXTW
    {
        public int x;
        public int y;
        public uint n;
        public string lpstr;
        public uint uiFlags;
        public RECT rcl;
    }



}