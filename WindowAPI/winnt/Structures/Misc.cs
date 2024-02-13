namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct Misc
    {
        public byte Name;
        public uint PhysicalAddress;
        public uint VirtualSize;
        public uint VirtualAddress;
        public uint SizeOfRawData;
        public uint PointerToRawData;
        public uint PointerToRelocations;
        public uint PointerToLinenumbers;
        public short NumberOfRelocations;
        public short NumberOfLinenumbers;
        public uint Characteristics;
    }



}