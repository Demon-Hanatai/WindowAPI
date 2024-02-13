namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ACTIVATION_CONTEXT_RUN_LEVEL_INFORMATION
    {
        public uint ulFlags;
        public ACTCTX_REQUESTED_RUN_LEVEL RunLevel;
        public uint UiAccess;
    }



}