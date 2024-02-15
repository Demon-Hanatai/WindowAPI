namespace WindowAPI.mstcpip.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SOCKET_SECURITY_SETTINGS_IPSEC
    {
        public _SOCKET_SECURITY_PROTOCOL SecurityProtocol;
        public uint SecurityFlags;
        public uint IpsecFlags;
        public LUID AuthipMMPolicyKey;
        public LUID AuthipQMPolicyKey;
        public LUID Reserved;
        public uint Reserved2;
        public uint UserNameStringLen;
        public uint DomainNameStringLen;
        public uint PasswordStringLen;
        public string AllStrings;
    }



}