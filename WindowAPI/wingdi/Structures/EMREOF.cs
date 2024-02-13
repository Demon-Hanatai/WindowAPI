namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMREOF
    {
        public EMR emr;
        public uint nPalEntries;
        public uint offPalEntries;
        public uint nSizeLast;
    }



}