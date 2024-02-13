namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct IMAGE_DEBUG_DIRECTORY
    {
        public uint Characteristics;
        public uint TimeDateStamp;
        public short MajorVersion;
        public short MinorVersion;
        public uint Type;
        public uint SizeOfData;
        public uint AddressOfRawData;
        public uint PointerToRawData;
    }



}