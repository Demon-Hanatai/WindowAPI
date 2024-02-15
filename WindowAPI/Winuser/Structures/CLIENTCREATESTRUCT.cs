namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CLIENTCREATESTRUCT
    {
        public nint hWindowMenu;
        public uint idFirstChild;
    }



}