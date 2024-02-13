namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ACTIVATION_CONTEXT_COMPATIBILITY_INFORMATION
    {
        public uint ElementCount;
        public int Elements;
    }



}