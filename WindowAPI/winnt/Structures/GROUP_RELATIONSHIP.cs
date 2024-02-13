namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct GROUP_RELATIONSHIP
    {
        public short MaximumGroupCount;
        public short ActiveGroupCount;
        public byte Reserved;
    }



}