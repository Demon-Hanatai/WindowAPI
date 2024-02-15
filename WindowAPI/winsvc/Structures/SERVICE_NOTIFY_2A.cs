namespace WindowAPI.winsvc.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SERVICE_NOTIFY_2A
    {
        public uint dwVersion;
        public MSGBOXCALLBACK pfnNotifyCallback;
        public nint pContext;
        public uint dwNotificationStatus;
        public ENUM_SERVICE_STATUS_PROCESSA ServiceStatus;
        public uint dwNotificationTriggered;
        public string pszServiceNames;
    }



}