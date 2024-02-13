namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct METARECORD
    {
        public uint rdSize;
        public short rdFunction;
        public short rdParm;
    }



}