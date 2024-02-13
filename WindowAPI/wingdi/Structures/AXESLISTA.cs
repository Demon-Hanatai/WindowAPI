namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct AXESLISTA
    {
        public uint axlReserved;
        public uint axlNumAxes;
        public AXISINFOA axlAxisInfo;
    }



}