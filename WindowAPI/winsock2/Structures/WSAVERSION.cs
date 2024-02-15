using WindowAPI.winsock2.Enums;


namespace WindowAPI.winsock2.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct WSAVERSION
    {
        public uint dwVersion;
        public _WSAEcomparator ecHow;
    }



}