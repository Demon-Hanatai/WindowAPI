namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRFORMAT
    {
        public uint dSignature;
        public uint nVersion;
        public uint cbData;
        public uint offData;
    }



}