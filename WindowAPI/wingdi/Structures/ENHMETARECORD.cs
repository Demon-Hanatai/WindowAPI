namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ENHMETARECORD
    {
        public uint iType;
        public uint nSize;
        public uint dParm;
    }



}