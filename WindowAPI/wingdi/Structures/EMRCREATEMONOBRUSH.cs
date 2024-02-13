namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRCREATEMONOBRUSH
    {
        public EMR emr;
        public uint ihBrush;
        public uint iUsage;
        public uint offBmi;
        public uint cbBmi;
        public uint offBits;
        public uint cbBits;
    }



}