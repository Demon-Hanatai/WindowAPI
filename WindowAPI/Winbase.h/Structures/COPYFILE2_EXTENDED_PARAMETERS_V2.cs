using System.Runtime.InteropServices;


namespace WindowAPI.Winbase.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct COPYFILE2_EXTENDED_PARAMETERS_V2
    {
        public uint dwSize;
        public uint dwCopyFlags;
        public int pProgressRoutine;
        public IntPtr pvCallbackContext;
        public uint dwCopyFlagsV2;
        public int ioDesiredSize;
        public int ioDesiredRate;
        public int pProgressRoutineOld;
        public int SourceOplockKeys;
    }



}