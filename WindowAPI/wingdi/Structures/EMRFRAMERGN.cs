namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRFRAMERGN
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint cbRgnData;
        public uint ihBrush;
        public int szlStroke;
        public byte RgnData;
    }



}