namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ENCLAVE_CREATE_INFO_VBS
    {
        public uint Flags;
        public byte OwnerID;
    }



}