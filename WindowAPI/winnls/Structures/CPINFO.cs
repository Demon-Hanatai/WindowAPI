namespace WindowAPI.winnls.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CPINFO
    {
        public uint MaxCharSize;
        public byte DefaultChar;
    }



}