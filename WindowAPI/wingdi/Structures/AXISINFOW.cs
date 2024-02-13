namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct AXISINFOW
    {
        public int axMinValue;
        public int axMaxValue;
        public StringBuilder axAxisName;
    }



}