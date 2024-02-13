namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MENUBARINFO
    {
        public uint cbSize;
        public RECT rcBar;
        public IntPtr hMenu;
        public IntPtr hwndMenu;
    }



}