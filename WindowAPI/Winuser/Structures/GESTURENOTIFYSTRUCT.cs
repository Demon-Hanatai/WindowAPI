namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct GESTURENOTIFYSTRUCT
    {
        public uint cbSize;
        public uint dwFlags;
        public IntPtr hwndTarget;
        public POINTS ptsLocation;
        public uint dwInstanceID;
    }



}