namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MENUBARINFO
    {
        public uint cbSize;
        public RECT rcBar;
        public nint hMenu;
        public nint hwndMenu;
    }



}