namespace WindowAPI.winsock2.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct AFPROTOCOLS
    {
        public int iAddressFamily;
        public int iProtocol;
    }



}