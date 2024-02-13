namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRCREATEPALETTE
    {
        public EMR emr;
        public uint ihPal;
        public LOGPALETTE lgpl;
    }



}