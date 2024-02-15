namespace WindowAPI.winsvc.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SC_ACTION
    {
        public uint Type;
        public uint Delay;
    }



}