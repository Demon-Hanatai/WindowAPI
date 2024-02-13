namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRSELECTCLIPPATH
    {
        public EMR emr;
        public uint iMode;
    }



}