namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct AXISINFOA
    {
        public int axMinValue;
        public int axMaxValue;
        public byte axAxisName;
    }



}