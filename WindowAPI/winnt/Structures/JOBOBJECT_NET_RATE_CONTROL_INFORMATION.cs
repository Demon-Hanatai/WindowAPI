

namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct JOBOBJECT_NET_RATE_CONTROL_INFORMATION
    {
        public uint MaxBandwidth;
        public JOB_OBJECT_NET_RATE_CONTROL_FLAGS ControlFlags;
        public byte DscpTag;
    }



}