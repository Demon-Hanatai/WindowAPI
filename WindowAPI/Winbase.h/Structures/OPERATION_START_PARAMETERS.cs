namespace WindowAPI.Winbase.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct OPERATION_START_PARAMETERS
    {
        public int Version;
        public int OperationId;
        public int Flags;
    }



}