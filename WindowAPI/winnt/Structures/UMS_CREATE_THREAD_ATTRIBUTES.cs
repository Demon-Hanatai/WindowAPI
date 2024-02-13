namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct UMS_CREATE_THREAD_ATTRIBUTES
    {
        public uint UmsVersion;
        public IntPtr UmsContext;
        public IntPtr UmsCompletionList;
    }



}