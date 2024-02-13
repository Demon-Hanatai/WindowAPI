namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRSETICMPROFILE
    {
        public EMR emr;
        public uint dwFlags;
        public uint cbName;
        public uint cbData;
        public byte Data;
    }



}