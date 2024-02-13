namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRGLSRECORD
    {
        public EMR emr;
        public uint cbData;
        public byte Data;
    }



}