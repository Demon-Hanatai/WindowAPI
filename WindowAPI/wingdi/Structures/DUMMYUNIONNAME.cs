

namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DUMMYUNIONNAME
    {
        public DISPLAYCONFIG_MODE_INFO_TYPE infoType;
        public int id;
        public int adapterId;
        public int targetMode;
        public int sourceMode;
        public DISPLAYCONFIG_DESKTOP_IMAGE_INFO desktopImageInfo;
    }



}