namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRSETMITERLIMIT
    {
        public EMR emr;
        public float eMiterLimit;
    }



}