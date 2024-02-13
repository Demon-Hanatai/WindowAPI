namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ENUMTEXTMETRICW
    {
        public NEWTEXTMETRICEXW etmNewTextMetricEx;
        public AXESLISTW etmAxesList;
    }



}