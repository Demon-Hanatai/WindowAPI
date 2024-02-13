namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRRESIZEPALETTE
    {
        public EMR emr;
        public uint ihPal;
        public uint cEntries;
    }



}