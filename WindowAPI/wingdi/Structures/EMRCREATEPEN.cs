namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRCREATEPEN
    {
        public EMR emr;
        public uint ihPen;
        public LOGPEN lopn;
    }



}