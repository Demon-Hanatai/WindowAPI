namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMREXCLUDECLIPRECT
    {
        public EMR emr;
        public RECTL rclClip;
    }



}