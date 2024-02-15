namespace WindowAPI.winsvc.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ENUM_SERVICE_STATUS_PROCESSW
    {
        public string lpServiceName;
        public string lpDisplayName;
        public ENUM_SERVICE_STATUS_PROCESSA ServiceStatusProcess;
    }



}