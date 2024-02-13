namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct JOBOBJECT_END_OF_JOB_TIME_INFORMATION
    {
        public uint EndOfJobTimeAction;
    }



}