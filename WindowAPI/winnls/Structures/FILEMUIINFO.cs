namespace WindowAPI.winnls.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct FILEMUIINFO
    {
        public uint dwSize;
        public uint dwVersion;
        public uint dwFileType;
        public byte pChecksum;
        public byte pServiceChecksum;
        public uint dwLanguageNameOffset;
        public uint dwTypeIDMainSize;
        public uint dwTypeIDMainOffset;
        public uint dwTypeNameMainOffset;
        public uint dwTypeIDMUISize;
        public uint dwTypeIDMUIOffset;
        public uint dwTypeNameMUIOffset;
    }



}