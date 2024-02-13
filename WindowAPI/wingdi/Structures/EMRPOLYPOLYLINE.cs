namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRPOLYPOLYLINE
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint nPolys;
        public uint cptl;
        public uint aPolyCounts;
        public POINTL aptl;
    }



}