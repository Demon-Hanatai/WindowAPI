namespace WindowAPI.winsock2.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct WSANETWORKEVENTS
    {
        public int lNetworkEvents;
        public int iErrorCode;
    }



}