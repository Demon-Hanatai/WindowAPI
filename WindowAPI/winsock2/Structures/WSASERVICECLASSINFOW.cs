namespace WindowAPI.winsock2.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct WSASERVICECLASSINFOW
    {
        public nint lpServiceClassId;
        public string lpszServiceClassName;
        public uint dwCount;
        public WSANSCLASSINFOW lpClassInfos;
    }



}