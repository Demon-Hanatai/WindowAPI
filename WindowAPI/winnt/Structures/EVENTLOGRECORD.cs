namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EVENTLOGRECORD
    {
        public uint Length;
        public uint Reserved;
        public uint RecordNumber;
        public uint TimeGenerated;
        public uint TimeWritten;
        public uint EventID;
        public short EventType;
        public short NumStrings;
        public short EventCategory;
        public short ReservedFlags;
        public uint ClosingRecordNumber;
        public uint StringOffset;
        public uint UserSidLength;
        public uint UserSidOffset;
        public uint DataLength;
        public uint DataOffset;
    }



}