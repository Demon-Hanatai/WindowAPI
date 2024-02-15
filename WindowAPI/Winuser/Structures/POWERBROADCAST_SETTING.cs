namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct POWERBROADCAST_SETTING
    {
        public int PowerSetting;
        public uint DataLength;
        public char Data;
    }



}