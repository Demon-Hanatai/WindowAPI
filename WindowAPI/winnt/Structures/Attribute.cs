namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct Attribute
    {
        public short Version;
        public short Reserved;
        public uint AttributeCount;
        public int pAttributeV1;
    }



}