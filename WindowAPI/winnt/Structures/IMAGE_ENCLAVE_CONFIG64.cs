namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct IMAGE_ENCLAVE_CONFIG64
    {
        public uint Size;
        public uint MinimumRequiredConfigSize;
        public uint PolicyFlags;
        public uint NumberOfImports;
        public uint ImportList;
        public uint ImportEntrySize;
        public byte FamilyID;
        public byte ImageID;
        public uint ImageVersion;
        public uint SecurityVersion;
        public int EnclaveSize;
        public uint NumberOfThreads;
        public uint EnclaveFlags;
    }



}