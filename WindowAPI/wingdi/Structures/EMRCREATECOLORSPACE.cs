namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRCREATECOLORSPACE
    {
        public EMR emr;
        public uint ihCS;
        public LOGCOLORSPACEA lcs;
    }



}