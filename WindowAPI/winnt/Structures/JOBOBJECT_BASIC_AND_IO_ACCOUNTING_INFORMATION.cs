namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct JOBOBJECT_BASIC_AND_IO_ACCOUNTING_INFORMATION
    {
        public JOBOBJECT_BASIC_ACCOUNTING_INFORMATION BasicInfo;
        public IO_COUNTERS IoInfo;
    }



}