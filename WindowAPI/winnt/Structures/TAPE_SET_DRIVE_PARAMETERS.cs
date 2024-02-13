namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TAPE_SET_DRIVE_PARAMETERS
    {
        public bool ECC;
        public bool Compression;
        public bool DataPadding;
        public bool ReportSetmarks;
        public uint EOTWarningZoneSize;
    }



}