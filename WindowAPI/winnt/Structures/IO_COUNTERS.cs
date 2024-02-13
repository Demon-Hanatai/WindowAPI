namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct IO_COUNTERS
    {
        public int ReadOperationCount;
        public int WriteOperationCount;
        public int OtherOperationCount;
        public int ReadTransferCount;
        public int WriteTransferCount;
        public int OtherTransferCount;
    }



}