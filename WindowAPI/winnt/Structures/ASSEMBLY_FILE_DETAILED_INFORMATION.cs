namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ASSEMBLY_FILE_DETAILED_INFORMATION
    {
        public uint ulFlags;
        public uint ulFilenameLength;
        public uint ulPathLength;
        public string lpFileName;
        public string lpFilePath;
    }



}