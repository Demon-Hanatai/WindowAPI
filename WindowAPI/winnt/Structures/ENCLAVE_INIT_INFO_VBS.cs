namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ENCLAVE_INIT_INFO_VBS
    {
        public uint Length;
        public uint ThreadCount;
    }



}