namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ENUMLOGFONTEXW
    {
        public LOGFONTW elfLogFont;
        public StringBuilder elfFullName;
    }



}