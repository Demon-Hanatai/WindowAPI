using WindowAPI.mstcpip.Enums;

namespace WindowAPI.mstcpip.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SOCKET_SECURITY_SETTINGS
    {
        public _SOCKET_SECURITY_PROTOCOL SecurityProtocol;
        public uint SecurityFlags;
    }



}