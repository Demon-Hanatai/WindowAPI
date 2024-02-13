namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ACCESS_DENIED_CALLBACK_ACE
    {
        public nint Header;
        public int Mask;
        public uint SidStart;
    }



}