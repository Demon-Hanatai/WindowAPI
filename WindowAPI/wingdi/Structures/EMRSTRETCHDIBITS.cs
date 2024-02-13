namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRSTRETCHDIBITS
    {
        public EMR emr;
        public RECTL rclBounds;
        public int xDest;
        public int yDest;
        public int xSrc;
        public int ySrc;
        public int cxSrc;
        public int cySrc;
        public uint offBmiSrc;
        public uint cbBmiSrc;
        public uint offBitsSrc;
        public uint cbBitsSrc;
        public uint iUsageSrc;
        public uint dwRop;
        public int cxDest;
        public int cyDest;
    }



}