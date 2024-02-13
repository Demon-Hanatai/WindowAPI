namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct BITMAPCOREINFO
    {
        public BITMAPCOREHEADER bmciHeader;
        public RGBTRIPLE bmciColors;
    }



}