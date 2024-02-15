namespace WindowAPI.winsvc.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SERVICE_TRIGGER_SPECIFIC_DATA_ITEM
    {
        public uint dwDataType;
        public uint cbData;
        public byte pData;
    }



}