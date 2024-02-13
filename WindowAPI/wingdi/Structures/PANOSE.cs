namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct PANOSE
    {
        public byte bFamilyType;
        public byte bSerifStyle;
        public byte bWeight;
        public byte bProportion;
        public byte bContrast;
        public byte bStrokeVariation;
        public byte bArmStyle;
        public byte bLetterform;
        public byte bMidline;
        public byte bXHeight;
    }



}