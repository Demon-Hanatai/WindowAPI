namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRANGLEARC
    {
        public EMR emr;
        public POINTL ptlCenter;
        public uint nRadius;
        public float eStartAngle;
        public float eSweepAngle;
    }



}