namespace WindowAPI.winsvc.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SERVICE_TRIGGER_INFO
    {
        public uint cTriggers;
        public SERVICE_TRIGGER pTriggers;
        public byte pReserved;
    }



}