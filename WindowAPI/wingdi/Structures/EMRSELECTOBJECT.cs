namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRSELECTOBJECT
    {
        public EMR emr;
        public uint ihObject;
    }



}