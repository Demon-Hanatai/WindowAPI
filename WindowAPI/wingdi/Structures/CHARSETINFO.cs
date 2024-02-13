namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CHARSETINFO
    {
        public uint ciCharset;
        public uint ciACP;
        public FONTSIGNATURE fs;
    }



}