namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRARC
    {
        public EMR emr;
        public RECTL rclBox;
        public POINTL ptlStart;
        public POINTL ptlEnd;
    }



}