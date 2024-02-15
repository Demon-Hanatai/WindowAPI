namespace WindowAPI.winsvc.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SERVICE_FAILURE_ACTIONS_FLAG
    {
        public bool fFailureActionsOnNonCrashFailures;
    }



}