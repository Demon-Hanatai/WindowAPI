namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EXTLOGFONTA
    {
        public LOGFONTA elfLogFont;
        public byte elfFullName;
        public uint elfVersion;
        public uint elfStyleSize;
        public uint elfMatch;
        public uint elfReserved;
        public uint elfCulture;
        public PANOSE elfPanose;
    }



}