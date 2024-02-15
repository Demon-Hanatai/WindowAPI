namespace WindowAPI.winsock2.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct QOS
    {
        public LOGPEN SendingFlowspec;
        public LOGPEN ReceivingFlowspec;
        public nint ProviderSpecific;
    }



}