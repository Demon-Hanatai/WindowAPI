namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ENUMLOGFONTA
    {
        public LOGFONTA elfLogFont;
        public byte elfFullName;
    }



}