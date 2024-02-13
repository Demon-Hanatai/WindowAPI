namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct GLYPHMETRICSFLOAT
    {
        public float gmfBlackBoxX;
        public float gmfBlackBoxY;
        public POINTFLOAT gmfptGlyphOrigin;
        public float gmfCellIncX;
        public float gmfCellIncY;
    }



}