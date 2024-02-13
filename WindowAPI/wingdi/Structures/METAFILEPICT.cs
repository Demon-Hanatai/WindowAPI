namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct METAFILEPICT
    {
        public int mm;
        public int xExt;
        public int yExt;
        public nint hMF;
    }



}