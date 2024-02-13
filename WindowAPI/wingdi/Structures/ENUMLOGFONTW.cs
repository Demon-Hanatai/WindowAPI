namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ENUMLOGFONTW
    {
        public LOGFONTW elfLogFont;
        public StringBuilder elfFullName;
    }



}