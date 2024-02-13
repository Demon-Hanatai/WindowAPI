namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct HELPINFO
    {
        public uint cbSize;
        public int iContextType;
        public int iCtrlId;
        public IntPtr hItemHandle;
        public uint dwContextId;
        public POINT MousePos;
    }



}