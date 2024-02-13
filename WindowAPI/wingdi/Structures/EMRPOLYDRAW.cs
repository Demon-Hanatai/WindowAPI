namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRPOLYDRAW
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint cptl;
        public POINTL aptl;
        public byte abTypes;
    }



}