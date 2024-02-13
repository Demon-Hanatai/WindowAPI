namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRROUNDRECT
    {
        public EMR emr;
        public RECTL rclBox;
        public int szlCorner;
    }



}