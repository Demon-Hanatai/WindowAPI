namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRSETWORLDTRANSFORM
    {
        public EMR emr;
        public XFORM xform;
    }



}