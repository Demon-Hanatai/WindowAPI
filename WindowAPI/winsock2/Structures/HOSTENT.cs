namespace WindowAPI.winsock2.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct HOSTENT
    {
        public short h_addrtype;
        public short h_length;
    }



}