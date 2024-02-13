namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRSETMAPPERFLAGS
    {
        public EMR emr;
        public uint dwFlags;
    }



}