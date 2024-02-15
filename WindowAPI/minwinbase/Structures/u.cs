using WindowAPI.winnls.Structures;


namespace WindowAPI.minwinbase.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct u
    {
        public uint dwDebugEventCode;
        public uint dwProcessId;
        public uint dwThreadId;
        public EXCEPTION_RECORD Exception;
        public CREATE_THREAD_DEBUG_INFO CreateThread;
        public CREATE_PROCESS_DEBUG_INFO CreateProcessInfo;
        public CREATE_THREAD_DEBUG_INFO ExitThread;
        public CREATE_PROCESS_DEBUG_INFO ExitProcess;
        public FILE_FULL_DIR_INFO LoadDll;
        public FILE_FULL_DIR_INFO UnloadDll;
        public FILE_STREAM_INFO DebugString;
        public CPINFO RipInfo;
    }



}