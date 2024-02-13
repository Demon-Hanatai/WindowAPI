namespace WindowAPI.windef.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct RECT
    {
        public int left;
        public int top;
        public int right;
        public int bottom;
    }



}