namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ACCESSTIMEOUT
    {
        public uint cbSize;
        public uint dwFlags;
        public uint iTimeOutMSec;
    }



}