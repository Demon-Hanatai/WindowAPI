namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRTEXT
    {
        public POINTL ptlReference;
        public uint nChars;
        public uint offString;
        public uint fOptions;
        public RECTL rcl;
        public uint offDx;
    }



}