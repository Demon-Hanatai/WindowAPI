namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DISPLAY_DEVICEW
    {
        public uint cb;
        public StringBuilder DeviceName;
        public uint StateFlags;
    }



}