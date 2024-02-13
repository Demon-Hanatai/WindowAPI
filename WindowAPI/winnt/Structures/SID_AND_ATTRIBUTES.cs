namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SID_AND_ATTRIBUTES
    {
        public int Sid;

        public uint Attributes;
    }



}