namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRSETBKCOLOR
    {
        public EMR emr;
        public int crColor;
    }



}