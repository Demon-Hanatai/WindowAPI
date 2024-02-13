namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRCREATECOLORSPACEW
    {
        public EMR emr;
        public uint ihCS;
        public LOGCOLORSPACEW lcs;
        public uint dwFlags;
        public uint cbData;
        public byte Data;
    }



}