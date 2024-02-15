namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MDINEXTMENU
    {
        public nint hmenuIn;
        public nint hmenuNext;
        public nint hwndNext;
    }



}