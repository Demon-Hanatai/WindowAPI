namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRPOLYTEXTOUTA
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint iGraphicsMode;
        public float exScale;
        public float eyScale;
        public int cStrings;
        public EMRTEXT aemrtext;
    }



}