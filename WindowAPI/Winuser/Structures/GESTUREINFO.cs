namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct GESTUREINFO
    {
        public uint cbSize;
        public uint dwFlags;
        public uint dwID;
        public IntPtr hwndTarget;
        public POINTS ptsLocation;
        public uint dwInstanceID;
        public uint dwSequenceID;
        public int ullArguments;
        public uint cbExtraArgs;
    }



}