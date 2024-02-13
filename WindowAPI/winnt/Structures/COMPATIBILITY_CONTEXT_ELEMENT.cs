namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct COMPATIBILITY_CONTEXT_ELEMENT
    {
        public int Id;
        public ACTCTX_COMPATIBILITY_ELEMENT_TYPE Type;
        public int MaxVersionTested;
    }



}