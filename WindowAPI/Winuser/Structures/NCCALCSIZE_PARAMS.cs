namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct NCCALCSIZE_PARAMS
    {
        public RECT rgrc;
        public int lppos;
    }



}