namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EXTLOGPEN
    {
        public uint elpPenStyle;
        public uint elpWidth;
        public uint elpBrushStyle;
        public int elpColor;
        public int elpHatch;
        public uint elpNumEntries;
        public uint elpStyleEntry;
    }



}