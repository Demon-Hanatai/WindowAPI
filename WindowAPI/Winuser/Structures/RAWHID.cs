namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct RAWHID
    {
        public uint dwSizeHid;
        public uint dwCount;
        public byte bRawData;
    }



}