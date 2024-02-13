namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DESIGNVECTOR
    {
        public uint dvReserved;
        public uint dvNumAxes;
        public int dvValues;
    }



}