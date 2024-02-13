namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct WTSSESSION_NOTIFICATION
    {
        public uint cbSize;
        public uint dwSessionId;
    }



}