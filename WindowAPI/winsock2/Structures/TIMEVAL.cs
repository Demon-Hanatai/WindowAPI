namespace WindowAPI.winsock2.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TIMEVAL
    {
        public int tv_sec;
        public int tv_usec;
    }



}