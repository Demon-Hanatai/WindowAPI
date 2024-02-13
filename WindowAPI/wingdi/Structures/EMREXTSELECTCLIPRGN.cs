namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMREXTSELECTCLIPRGN
    {
        public EMR emr;
        public uint cbRgnData;
        public uint iMode;
        public byte RgnData;
    }



}