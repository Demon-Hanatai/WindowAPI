namespace WindowAPI.winnls.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct NLSVERSIONINFOEX
    {
        public uint dwNLSVersionInfoSize;
        public uint dwNLSVersion;
        public uint dwDefinedVersion;
        public uint dwEffectiveId;
        public LUID guidCustomVersion;
    }



}