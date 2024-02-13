namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct PROCESS_DYNAMIC_EH_CONTINUATION_TARGET
    {
        public int TargetAddress;
        public int Flags;
    }



}