namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct RGNDATA
    {
        public RGNDATAHEADER rdh;
        public char Buffer;
    }



}