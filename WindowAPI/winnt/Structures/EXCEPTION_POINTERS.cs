namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EXCEPTION_POINTERS
    {
        public int ExceptionRecord;
        public int ContextRecord;
    }



}