namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MENUGETOBJECTINFO
    {
        public uint dwFlags;
        public uint uPos;
        public nint hmenu;
        public nint riid;
        public nint pvObj;
    }



}