namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CBTACTIVATESTRUCT
    {
        public bool fMouse;
        public nint hWndActive;
    }



}