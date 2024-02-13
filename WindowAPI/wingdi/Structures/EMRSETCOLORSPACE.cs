namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRSETCOLORSPACE
    {
        public EMR emr;
        public uint ihCS;
    }



}