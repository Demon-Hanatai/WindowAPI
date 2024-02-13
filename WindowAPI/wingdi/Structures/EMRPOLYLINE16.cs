namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRPOLYLINE16
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint cpts;
        public POINTS apts;
    }



}