namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct GESTURENOTIFYSTRUCT
    {
        public uint cbSize;
        public uint dwFlags;
        public nint hwndTarget;
        public POINTS ptsLocation;
        public uint dwInstanceID;
    }



}