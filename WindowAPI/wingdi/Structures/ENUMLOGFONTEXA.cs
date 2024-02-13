namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ENUMLOGFONTEXA
    {
        public LOGFONTA elfLogFont;
        public byte elfFullName;
    }



}