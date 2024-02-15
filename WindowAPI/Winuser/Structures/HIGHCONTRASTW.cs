namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct HIGHCONTRASTW
    {
        public uint cbSize;
        public uint dwFlags;
        public string lpszDefaultScheme;
    }



}