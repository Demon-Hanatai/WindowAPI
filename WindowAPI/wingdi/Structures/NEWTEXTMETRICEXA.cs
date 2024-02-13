namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct NEWTEXTMETRICEXA
    {
        public NEWTEXTMETRICA ntmTm;
        public FONTSIGNATURE ntmFontSig;
    }



}