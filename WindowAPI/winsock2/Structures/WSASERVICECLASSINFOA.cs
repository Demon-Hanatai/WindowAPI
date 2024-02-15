namespace WindowAPI.winsock2.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct WSASERVICECLASSINFOA
    {
        public nint lpServiceClassId;
        public string lpszServiceClassName;
        public uint dwCount;
        public WSANSCLASSINFOA lpClassInfos;
    }



}