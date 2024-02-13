namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MESSAGE_RESOURCE_ENTRY
    {
        public short Length;
        public short Flags;
        public byte Text;
    }



}