namespace WindowAPI.winsvc.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SERVICE_TRIGGER
    {
        public uint dwTriggerType;
        public uint dwAction;
        public uint cDataItems;
        public SERVICE_DIRECTORY_TYPE pDataItems;
    }



}