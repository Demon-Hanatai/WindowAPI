namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DISPLAYCONFIG_PATH_INFO
    {
        public nint sourceInfo;
        public nint targetInfo;
        public int flags;
    }



}