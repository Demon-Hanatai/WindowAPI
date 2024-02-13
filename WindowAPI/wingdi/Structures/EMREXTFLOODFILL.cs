namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMREXTFLOODFILL
    {
        public EMR emr;
        public POINTL ptlStart;
        public int crColor;
        public uint iMode;
    }



}