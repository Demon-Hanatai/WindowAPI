namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct LASTINPUTINFO
    {
        public uint cbSize;
        public uint dwTime;
    }



}