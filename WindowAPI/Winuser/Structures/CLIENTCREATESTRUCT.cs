namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CLIENTCREATESTRUCT
    {
        public IntPtr hWindowMenu;
        public uint idFirstChild;
    }



}