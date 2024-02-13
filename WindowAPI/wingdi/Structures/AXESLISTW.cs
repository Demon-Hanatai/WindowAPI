namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct AXESLISTW
    {
        public uint axlReserved;
        public uint axlNumAxes;
        public AXISINFOW axlAxisInfo;
    }



}