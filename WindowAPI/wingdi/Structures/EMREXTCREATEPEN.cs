namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMREXTCREATEPEN
    {
        public EMR emr;
        public uint ihPen;
        public uint offBmi;
        public uint cbBmi;
        public uint offBits;
        public uint cbBits;
        public int elp;
    }



}