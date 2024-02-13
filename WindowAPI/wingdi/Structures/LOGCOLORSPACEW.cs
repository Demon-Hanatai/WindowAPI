namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct LOGCOLORSPACEW
    {
        public uint lcsSignature;
        public uint lcsVersion;
        public uint lcsSize;
        public int lcsCSType;
        public nint lcsIntent;
        public CIEXYZTRIPLE lcsEndpoints;
        public uint lcsGammaRed;
        public uint lcsGammaGreen;
        public uint lcsGammaBlue;
        public StringBuilder lcsFilename;
    }



}