namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRSETVIEWPORTORGEX
    {
        public EMR emr;
        public POINTL ptlOrigin;
    }



}