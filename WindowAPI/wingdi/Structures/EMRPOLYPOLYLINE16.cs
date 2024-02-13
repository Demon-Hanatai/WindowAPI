namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRPOLYPOLYLINE16
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint nPolys;
        public uint cpts;
        public uint aPolyCounts;
        public POINTS apts;
    }



}