using System.Runtime.InteropServices;


namespace WindowAPI.Winbase.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct UMS_SCHEDULER_STARTUP_INFO
    {
        public int UmsVersion;
        public int CompletionList;
        public IntPtr SchedulerProc;
        public IntPtr SchedulerParam;
    }



}