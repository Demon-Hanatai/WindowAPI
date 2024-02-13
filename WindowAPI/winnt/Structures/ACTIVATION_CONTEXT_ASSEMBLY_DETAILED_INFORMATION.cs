namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION
    {
        public uint ulFlags;
        public uint ulEncodedAssemblyIdentityLength;
        public uint ulManifestPathType;
        public uint ulManifestPathLength;
        public int liManifestLastWriteTime;
        public uint ulPolicyPathType;
        public uint ulPolicyPathLength;
        public int liPolicyLastWriteTime;
        public uint ulMetadataSatelliteRosterIndex;
        public uint ulManifestVersionMajor;
        public uint ulManifestVersionMinor;
        public uint ulPolicyVersionMajor;
        public uint ulPolicyVersionMinor;
        public uint ulAssemblyDirectoryNameLength;
        public string lpAssemblyEncodedAssemblyIdentity;
        public string lpAssemblyManifestPath;
        public string lpAssemblyPolicyPath;
        public string lpAssemblyDirectoryName;
        public uint ulFileCount;
    }



}