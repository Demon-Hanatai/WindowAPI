namespace WindowAPI.winnls.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct NLSVERSIONINFO
    {
        public uint dwNLSVersionInfoSize;
        public uint dwNLSVersion;
        public uint dwDefinedVersion;
    }



}