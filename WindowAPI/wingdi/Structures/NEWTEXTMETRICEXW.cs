namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct NEWTEXTMETRICEXW
    {
        public NEWTEXTMETRICW ntmTm;
        public FONTSIGNATURE ntmFontSig;
    }



}