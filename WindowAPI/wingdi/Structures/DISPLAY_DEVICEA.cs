namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DISPLAY_DEVICEA
    {
        public uint cb;
        public char DeviceName;
        public uint StateFlags;
    }



}