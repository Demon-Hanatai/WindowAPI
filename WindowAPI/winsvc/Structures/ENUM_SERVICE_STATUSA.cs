namespace WindowAPI.winsvc.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ENUM_SERVICE_STATUSA
    {
        public string lpServiceName;
        public string lpDisplayName;
        public RASTERIZER_STATUS ServiceStatus;
    }



}