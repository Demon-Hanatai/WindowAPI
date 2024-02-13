namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct UKNOW2
    {
        public uint LowPart;
        public uint HighPart;

        public int QuadPart;
    }



}