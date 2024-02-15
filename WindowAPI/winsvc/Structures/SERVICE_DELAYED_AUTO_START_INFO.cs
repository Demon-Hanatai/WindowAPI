namespace WindowAPI.winsvc.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SERVICE_DELAYED_AUTO_START_INFO
    {
        public bool fDelayedAutostart;
    }



}