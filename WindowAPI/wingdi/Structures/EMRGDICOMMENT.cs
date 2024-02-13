namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRGDICOMMENT
    {
        public EMR emr;
        public uint cbData;
        public byte Data;
    }



}