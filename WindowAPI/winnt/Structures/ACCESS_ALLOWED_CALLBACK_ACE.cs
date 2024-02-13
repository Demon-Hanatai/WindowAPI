namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ACCESS_ALLOWED_CALLBACK_ACE
    {
        public nint Header;
        public int Mask;
        public uint SidStart;
    }



}