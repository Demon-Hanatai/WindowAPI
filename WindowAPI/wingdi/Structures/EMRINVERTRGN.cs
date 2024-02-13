namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRINVERTRGN
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint cbRgnData;
        public byte RgnData;
    }



}