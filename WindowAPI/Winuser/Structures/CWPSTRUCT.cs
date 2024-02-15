namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CWPSTRUCT
    {
        public nint lParam;
        public nint wParam;
        public uint message;
        public nint hwnd;
    }



}