namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRGRADIENTFILL
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint nVer;
        public uint nTri;
        public int ulMode;
        public TRIVERTEX Ver;
    }



}