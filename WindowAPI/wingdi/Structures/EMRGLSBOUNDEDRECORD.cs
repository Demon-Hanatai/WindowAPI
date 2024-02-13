namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRGLSBOUNDEDRECORD
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint cbData;
        public byte Data;
    }



}