namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct PSINJECTDATA
    {
        public uint DataBytes;
        public short InjectionPoint;
        public short PageNumber;
    }



}