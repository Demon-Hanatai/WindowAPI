namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CWPRETSTRUCT
    {
        public nint lResult;
        public nint lParam;
        public nint wParam;
        public uint message;
        public nint hwnd;
    }



}