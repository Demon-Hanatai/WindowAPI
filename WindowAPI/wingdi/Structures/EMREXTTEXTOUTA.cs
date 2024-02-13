namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMREXTTEXTOUTA
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint iGraphicsMode;
        public float exScale;
        public float eyScale;
        public EMRTEXT emrtext;
    }



}