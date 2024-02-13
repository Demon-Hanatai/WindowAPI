namespace WindowAPI.Winbase.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct OPERATION_END_PARAMETERS
    {
        public int Version;
        public int OperationId;
        public int Flags;
    }



}