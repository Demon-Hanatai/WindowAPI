namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct IMAGE_FILE_HEADER
    {
        public short Machine;
        public short NumberOfSections;
        public uint TimeDateStamp;
        public uint PointerToSymbolTable;
        public uint NumberOfSymbols;
        public short SizeOfOptionalHeader;
        public short Characteristics;
    }



}