namespace WindowAPI.mstcpip.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ASSOCIATE_NAMERES_CONTEXT_INPUT
    {
        public COMPARTMENT_ID TransportSettingId;
        public uint Handle;
    }



}