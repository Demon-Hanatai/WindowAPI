namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ENHMETAHEADER
    {
        public uint iType;
        public uint nSize;
        public RECTL rclBounds;
        public RECTL rclFrame;
        public uint dSignature;
        public uint nVersion;
        public uint nBytes;
        public uint nRecords;
        public short nHandles;
        public short sReserved;
        public uint nDescription;
        public uint offDescription;
        public uint nPalEntries;
        public int szlDevice;
        public int szlMillimeters;
        public uint cbPixelFormat;
        public uint offPixelFormat;
        public uint bOpenGL;
        public int szlMicrometers;
    }



}