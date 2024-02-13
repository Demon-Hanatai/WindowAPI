namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SID_AND_ATTRIBUTES_HASH
    {
        public uint SidCount;
        public int SidAttr;
        public nint Hash;
    }



}