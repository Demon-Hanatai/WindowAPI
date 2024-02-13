namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SERIALKEYSA
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