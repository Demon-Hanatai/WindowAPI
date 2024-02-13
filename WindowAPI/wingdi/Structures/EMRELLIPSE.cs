namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRELLIPSE
    {
        public EMR emr;
        public RECTL rclBox;
    }



}