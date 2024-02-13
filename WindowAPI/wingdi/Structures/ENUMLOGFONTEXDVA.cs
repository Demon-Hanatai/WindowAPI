namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ENUMLOGFONTEXDVA
    {
        public ENUMLOGFONTEXA elfEnumLogfontEx;
        public DESIGNVECTOR elfDesignVector;
    }



}