namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRSCALEVIEWPORTEXTEX
    {
        public EMR emr;
        public int xNum;
        public int xDenom;
        public int yNum;
        public int yDenom;
    }



}