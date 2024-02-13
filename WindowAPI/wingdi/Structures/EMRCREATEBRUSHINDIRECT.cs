namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRCREATEBRUSHINDIRECT
    {
        public EMR emr;
        public uint ihBrush;
        public LOGBRUSH32 lb;
    }



}