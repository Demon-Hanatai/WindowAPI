namespace WindowAPI.minwinbase.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CREATE_THREAD_DEBUG_INFO
    {
        public nint hThread;
        public nint lpThreadLocalBase;
        public PFIBERSTARTROUTINE lpStartAddress;
    }



}