namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ENUMLOGFONTEXDVW
    {
        public ENUMLOGFONTEXW elfEnumLogfontEx;
        public DESIGNVECTOR elfDesignVector;
    }



}