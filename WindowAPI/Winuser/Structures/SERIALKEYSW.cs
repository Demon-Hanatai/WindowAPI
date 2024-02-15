namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SERIALKEYSW
    {
        public uint cbSize;
        public uint dwFlags;
        public string lpszActivePort;
        public string lpszPort;
        public uint iBaudRate;
        public uint iPortState;
        public uint iActive;
    }



}