namespace WindowAPI.winsock2.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct WSANSCLASSINFOA
    {
        public string lpszName;
        public uint dwNameSpace;
        public uint dwValueType;
        public uint dwValueSize;
        public nint lpValue;
    }



}