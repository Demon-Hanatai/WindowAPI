namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TPMPARAMS
    {
        public uint cbSize;
        public RECT rcExclude;
    }



}