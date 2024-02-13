namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TTPOLYGONHEADER
    {
        public uint cb;
        public uint dwType;
        public POINTFX pfxStart;
    }



}