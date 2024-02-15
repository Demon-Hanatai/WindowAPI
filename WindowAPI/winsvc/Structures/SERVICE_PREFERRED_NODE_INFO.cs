namespace WindowAPI.winsvc.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SERVICE_PREFERRED_NODE_INFO
    {
        public ushort usPreferredNode;
        public bool fDelete;
    }



}