namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMREXTCREATEFONTINDIRECTW
    {
        public EMR emr;
        public uint ihFont;
        public EXTLOGFONTW elfw;
    }



}