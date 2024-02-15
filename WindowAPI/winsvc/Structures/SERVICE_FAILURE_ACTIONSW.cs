namespace WindowAPI.winsvc.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SERVICE_FAILURE_ACTIONSW
    {
        public uint dwResetPeriod;
        public string lpRebootMsg;
        public string lpCommand;
        public uint cActions;
    }



}