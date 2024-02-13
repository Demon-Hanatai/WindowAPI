namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRCOLORCORRECTPALETTE
    {
        public EMR emr;
        public uint ihPalette;
        public uint nFirstEntry;
        public uint nPalEntries;
        public uint nReserved;
    }



}