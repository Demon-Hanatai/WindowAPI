namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRFILLPATH
    {
        public EMR emr;
        public RECTL rclBounds;
    }



}