namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ACE_HEADER
    {
        public byte AceType;
        public byte AceFlags;
        public short AceSize;
    }



}