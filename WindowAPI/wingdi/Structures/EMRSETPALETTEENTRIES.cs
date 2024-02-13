namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRSETPALETTEENTRIES
    {
        public EMR emr;
        public uint ihPal;
        public uint iStart;
        public uint cEntries;
        public PALETTEENTRY aPalEntries;
    }



}