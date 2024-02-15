namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct USAGE_PROPERTIES
    {
        public ushort level;
        public ushort page;
        public ushort usage;
        public int logicalMinimum;
        public int logicalMaximum;
        public ushort unit;
        public ushort exponent;
        public byte count;
        public int physicalMinimum;
        public int physicalMaximum;
    }



}