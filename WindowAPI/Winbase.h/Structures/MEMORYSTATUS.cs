namespace WindowAPI.Winbase.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MEMORYSTATUS
    {
        public uint dwLength;
        public uint dwMemoryLoad;
        public int dwTotalPhys;
        public int dwAvailPhys;
        public int dwTotalPageFile;
        public int dwAvailPageFile;
        public int dwTotalVirtual;
        public int dwAvailVirtual;
    }



}