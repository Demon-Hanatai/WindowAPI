namespace WindowAPI.winsvc.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SERVICE_CONTROL_STATUS_REASON_PARAMSA
    {
        public uint dwReason;
        public string pszComment;
        public ENUM_SERVICE_STATUS_PROCESSA ServiceStatus;
    }



}