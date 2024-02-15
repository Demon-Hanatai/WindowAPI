namespace WindowAPI.minwinbase.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct Detailed
    {
        public uint Version;
        public uint Flags;
        public nint LocalizedReasonModule;
        public uint LocalizedReasonId;
        public uint ReasonStringCount;
        public string SimpleReasonString;
    }



}