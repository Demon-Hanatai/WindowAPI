namespace WindowAPI.mstcpip.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct INET_PORT_RESERVATION_INSTANCE
    {
        public INET_PORT_RANGE Reservation;
        public INET_PORT_RESERVATION_TOKEN Token;
    }



}