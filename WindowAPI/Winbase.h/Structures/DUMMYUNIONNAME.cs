namespace WindowAPI.Winbase.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DUMMYUNIONNAME
    {
        public bool ReplaceIfExists;
        public uint Flags;
        public IntPtr RootDirectory;
        public uint FileNameLength;
    }



}