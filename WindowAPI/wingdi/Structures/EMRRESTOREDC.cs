namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRRESTOREDC
    {
        public EMR emr;
        public int iRelative;
    }



}