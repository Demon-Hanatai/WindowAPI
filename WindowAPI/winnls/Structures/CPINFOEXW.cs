namespace WindowAPI.winnls.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CPINFOEXW
    {
        public uint MaxCharSize;
        public byte DefaultChar;
        public StringBuilder UnicodeDefaultChar;
        public uint CodePage;
    }



}