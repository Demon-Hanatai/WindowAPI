namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MENUGETOBJECTINFO
    {
        public uint dwFlags;
        public uint uPos;
        public IntPtr hmenu;
        public IntPtr riid;
        public IntPtr pvObj;
    }



}