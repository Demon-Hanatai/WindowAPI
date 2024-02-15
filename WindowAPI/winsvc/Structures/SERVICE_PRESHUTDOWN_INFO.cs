namespace WindowAPI.winsvc.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SERVICE_PRESHUTDOWN_INFO
    {
        public uint dwPreshutdownTimeout;
    }



}