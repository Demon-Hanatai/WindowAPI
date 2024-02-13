namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TAPE_GET_DRIVE_PARAMETERS
    {
        public bool ECC;
        public bool Compression;
        public bool DataPadding;
        public bool ReportSetmarks;
        public uint DefaultBlockSize;
        public uint MaximumBlockSize;
        public uint MinimumBlockSize;
        public uint MaximumPartitionCount;
        public uint FeaturesLow;
        public uint FeaturesHigh;
        public uint EOTWarningZoneSize;
    }



}