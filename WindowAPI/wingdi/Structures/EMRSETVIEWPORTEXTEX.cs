namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRSETVIEWPORTEXTEX
    {
        public EMR emr;
        public int szlExtent;
    }



}