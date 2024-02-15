namespace WindowAPI.winsock2.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct WSAPOLLFD
    {
        public short fd;
        public short events;
        public short revents;
    }



}