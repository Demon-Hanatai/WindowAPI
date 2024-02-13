namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct LUID
    {
        public uint LowPart;
        public int HighPart;
    }



}