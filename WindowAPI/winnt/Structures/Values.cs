namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct Values
    {
        public string Name;
        public short ValueType;
        public short Reserved;
        public uint Flags;
        public uint ValueCount;
        public int pInt64;
        public uint pUint64;
        public int pFqbn;
        public int pOctetString;
    }



}