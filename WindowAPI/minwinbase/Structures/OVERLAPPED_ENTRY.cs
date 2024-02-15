namespace WindowAPI.minwinbase.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct OVERLAPPED_ENTRY
    {
        public uint lpCompletionKey;
        public nint lpOverlapped;
        public uint Internal;
        public uint dwNumberOfBytesTransferred;
    }



}