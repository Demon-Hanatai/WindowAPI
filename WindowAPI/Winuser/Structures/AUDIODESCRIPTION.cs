namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct AUDIODESCRIPTION
    {
        public uint cbSize;
        public bool Enabled;
        public int Locale;
    }



}