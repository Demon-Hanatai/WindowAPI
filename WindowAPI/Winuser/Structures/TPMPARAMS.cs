namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TPMPARAMS
    {
        public uint cbSize;
        public RECT rcExclude;
    }



}