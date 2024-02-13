namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRCOLORMATCHTOTARGET
    {
        public EMR emr;
        public uint dwAction;
        public uint dwFlags;
        public uint cbName;
        public uint cbData;
        public byte Data;
    }



}