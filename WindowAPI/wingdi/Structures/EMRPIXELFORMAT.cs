namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EMRPIXELFORMAT
    {
        public EMR emr;
        public PIXELFORMATDESCRIPTOR pfd;
    }



}