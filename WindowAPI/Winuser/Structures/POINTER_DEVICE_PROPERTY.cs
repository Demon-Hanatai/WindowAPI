namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct POINTER_DEVICE_PROPERTY
    {
        public int logicalMin;
        public int logicalMax;
        public int physicalMin;
        public int physicalMax;
        public int unit;
        public int unitExponent;
        public ushort usagePageId;
        public ushort usageId;
    }



}