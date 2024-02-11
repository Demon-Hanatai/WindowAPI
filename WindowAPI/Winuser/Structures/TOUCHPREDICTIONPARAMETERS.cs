
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TOUCHPREDICTIONPARAMETERS
    {
        public IntPtr cbSize;
        public IntPtr dwLatency;
        public IntPtr dwSampleTime;
        public IntPtr bUseHWTimeStamp;
    }



}