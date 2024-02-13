namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRPOLYDRAW16
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint cpts;
        public POINTS apts;
        public byte abTypes;
    }



}