namespace WindowAPI.winsock2.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct LINGER
    {
        public ushort l_onoff;
        public ushort l_linger;
    }



}