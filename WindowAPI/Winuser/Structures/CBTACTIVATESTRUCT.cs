namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CBTACTIVATESTRUCT
    {
        public bool fMouse;
        public IntPtr hWndActive;
    }



}