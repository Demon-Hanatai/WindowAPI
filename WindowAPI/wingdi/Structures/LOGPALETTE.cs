namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct LOGPALETTE
    {
        public short palVersion;
        public short palNumEntries;
        public PALETTEENTRY palPalEntry;
    }



}