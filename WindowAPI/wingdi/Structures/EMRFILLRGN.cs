namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRFILLRGN
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint cbRgnData;
        public uint ihBrush;
        public byte RgnData;
    }



}