
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct POINTER_INFO
    {
        public IntPtr pointerType;
        public IntPtr pointerId;
        public IntPtr frameId;
        public IntPtr pointerFlags;
        public IntPtr sourceDevice;
        public IntPtr hwndTarget;
        public IntPtr ptPixelLocation;
        public IntPtr ptHimetricLocation;
        public IntPtr ptPixelLocationRaw;
        public IntPtr ptHimetricLocationRaw;
        public uint dwTime;
        public IntPtr historyCount;
        public IntPtr InputData;
        public uint dwKeyStates;
        public IntPtr PerformanceCount;
        public IntPtr ButtonChangeType;
    }



}