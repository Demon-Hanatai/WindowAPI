using System.Runtime.InteropServices;


namespace WindowAPI.Winbase.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct FILE_ID_INFO
    {
        public int VolumeSerialNumber;
        public int FileId;
    }



}