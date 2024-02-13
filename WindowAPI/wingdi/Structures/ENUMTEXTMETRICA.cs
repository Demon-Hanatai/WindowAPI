namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ENUMTEXTMETRICA
    {
        public NEWTEXTMETRICEXA etmNewTextMetricEx;
        public AXESLISTA etmAxesList;
    }



}