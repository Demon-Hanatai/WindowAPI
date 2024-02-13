namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct COLORADJUSTMENT
    {
        public short caSize;
        public short caFlags;
        public short caIlluminantIndex;
        public short caRedGamma;
        public short caGreenGamma;
        public short caBlueGamma;
        public short caReferenceBlack;
        public short caReferenceWhite;
        public short caContrast;
        public short caBrightness;
        public short caColorfulness;
        public short caRedGreenTint;
    }



}