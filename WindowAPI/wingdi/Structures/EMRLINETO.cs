namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRLINETO
    {
        public EMR emr;
        public POINTL ptl;
    }



}