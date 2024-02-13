namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MDINEXTMENU
    {
        public IntPtr hmenuIn;
        public IntPtr hmenuNext;
        public IntPtr hwndNext;
    }



}