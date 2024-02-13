namespace WindowAPI.Winbase.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct GenericReserved
    {
        public short StructureVersion;
        public short StructureSize;
        public int Protocol;
        public short ProtocolMajorVersion;
        public short ProtocolMinorVersion;
        public short ProtocolRevision;
        public short Reserved;
        public int Flags;
        public int Capabilities;
        public int ShareFlags;
        public int CachingFlags;
    }



}