namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRMODIFYWORLDTRANSFORM
    {
        public EMR emr;
        public XFORM xform;
        public uint iMode;
    }



}