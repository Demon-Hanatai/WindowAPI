namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct METAHEADER
    {
        public short mtType;
        public short mtHeaderSize;
        public short mtVersion;
        public uint mtSize;
        public short mtNoObjects;
        public uint mtMaxRecord;
        public short mtNoParameters;
    }



}