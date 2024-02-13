namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRSETCOLORADJUSTMENT
    {
        public EMR emr;
        public COLORADJUSTMENT ColorAdjustment;
    }



}