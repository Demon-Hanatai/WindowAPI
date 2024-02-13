namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct GROUP_AFFINITY
    {
        public int Mask;
        public short Group;
        public short Reserved;
    }



}