namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRSETPIXELV
    {
        public EMR emr;
        public POINTL ptlPixel;
        public int crColor;
    }



}