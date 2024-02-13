namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMROFFSETCLIPRGN
    {
        public EMR emr;
        public POINTL ptlOffset;
    }



}