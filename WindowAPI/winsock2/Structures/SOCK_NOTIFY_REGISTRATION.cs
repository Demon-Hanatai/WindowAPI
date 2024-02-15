namespace WindowAPI.winsock2.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SOCK_NOTIFY_REGISTRATION
    {
        public short socket;
        public nint completionKey;
        public uint eventFilter;
        public uint operation;
        public uint triggerFlags;
        public uint registrationResult;
    }



}