namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRSETARCDIRECTION
    {
        public EMR emr;
        public uint iArcDirection;
    }



}