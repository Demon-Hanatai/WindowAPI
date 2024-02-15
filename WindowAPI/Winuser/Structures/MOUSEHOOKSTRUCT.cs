namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MOUSEHOOKSTRUCT
    {
        public POINT pt;
        public nint hwnd;
        public uint wHitTestCode;
        public int dwExtraInfo;
    }



}