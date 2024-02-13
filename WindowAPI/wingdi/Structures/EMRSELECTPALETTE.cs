namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRSELECTPALETTE
    {
        public EMR emr;
        public uint ihPal;
    }



}