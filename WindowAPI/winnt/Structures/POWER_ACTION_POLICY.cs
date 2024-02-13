namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct POWER_ACTION_POLICY
    {
        public POWER_ACTION Action;
        public uint Flags;
        public uint EventCode;
    }



}