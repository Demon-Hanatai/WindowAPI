namespace WindowAPI.Winbase.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct FILE_STORAGE_INFO
    {
        public int LogicalBytesPerSector;
        public int PhysicalBytesPerSectorForAtomicity;
        public int PhysicalBytesPerSectorForPerformance;
        public int FileSystemEffectivePhysicalBytesPerSectorForAtomicity;
        public int Flags;
        public int ByteOffsetForSectorAlignment;
        public int ByteOffsetForPartitionAlignment;
    }



}