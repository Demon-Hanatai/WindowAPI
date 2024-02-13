namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EXCEPTION_RECORD64
    {
        public uint ExceptionCode;
        public uint ExceptionFlags;
        public uint ExceptionRecord;
        public uint ExceptionAddress;
        public uint NumberParameters;
        public uint __unusedAlignment;
        public uint ExceptionInformation;
    }



}