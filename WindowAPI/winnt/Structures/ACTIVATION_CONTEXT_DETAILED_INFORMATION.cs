namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ACTIVATION_CONTEXT_DETAILED_INFORMATION
    {
        public uint dwFlags;
        public uint ulFormatVersion;
        public uint ulAssemblyCount;
        public uint ulRootManifestPathType;
        public uint ulRootManifestPathChars;
        public uint ulRootConfigurationPathType;
        public uint ulRootConfigurationPathChars;
        public uint ulAppDirPathType;
        public uint ulAppDirPathChars;
        public string lpRootManifestPath;
        public string lpRootConfigurationPath;
        public string lpAppDirPath;
    }



}