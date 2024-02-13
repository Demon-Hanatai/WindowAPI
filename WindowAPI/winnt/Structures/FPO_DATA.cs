namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct FPO_DATA
    {
        public uint ulOffStart;
        public uint cbProcSize;
        public uint cdwLocals;
        public short cdwParams;
    }



}