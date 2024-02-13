namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct OUTLINETEXTMETRICA
    {
        public uint otmSize;
        public int otmTextMetrics;
        public byte otmFiller;
        public int otmPanoseNumber;
        public uint otmfsSelection;
        public uint otmfsType;
        public int otmsCharSlopeRise;
        public int otmsCharSlopeRun;
        public int otmItalicAngle;
        public uint otmEMSquare;
        public int otmAscent;
        public int otmDescent;
        public uint otmLineGap;
        public uint otmsCapEmHeight;
        public uint otmsXHeight;
        public RECT otmrcFontBox;
        public int otmMacAscent;
        public int otmMacDescent;
        public uint otmMacLineGap;
        public uint otmusMinimumPPEM;
        public POINT otmptSubscriptSize;
        public POINT otmptSubscriptOffset;
        public POINT otmptSuperscriptSize;
        public POINT otmptSuperscriptOffset;
        public uint otmsStrikeoutSize;
        public int otmsStrikeoutPosition;
        public int otmsUnderscoreSize;
        public int otmsUnderscorePosition;
        public int otmpFamilyName;
        public int otmpFaceName;
        public int otmpStyleName;
        public int otmpFullName;
    }



}