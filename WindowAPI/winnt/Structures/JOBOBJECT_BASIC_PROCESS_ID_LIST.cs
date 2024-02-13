namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct JOBOBJECT_BASIC_PROCESS_ID_LIST
    {
        public uint NumberOfAssignedProcesses;
        public uint NumberOfProcessIdsInList;
        public int ProcessIdList;
    }



}