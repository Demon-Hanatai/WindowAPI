namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRPLGBLT
    {
        public EMR emr;
        public RECTL rclBounds;
        public POINTL aptlDest;
        public int xSrc;
        public int ySrc;
        public int cxSrc;
        public int cySrc;
        public int xformSrc;
        public int crBkColorSrc;
        public uint iUsageSrc;
        public uint offBmiSrc;
        public uint cbBmiSrc;
        public uint offBitsSrc;
        public uint cbBitsSrc;
        public int xMask;
        public int yMask;
        public uint iUsageMask;
        public uint offBmiMask;
        public uint cbBmiMask;
        public uint offBitsMask;
        public uint cbBitsMask;
    }



}