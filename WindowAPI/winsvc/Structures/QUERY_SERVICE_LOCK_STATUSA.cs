namespace WindowAPI.winsvc.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct QUERY_SERVICE_LOCK_STATUSA
    {
        public uint fIsLocked;
        public string lpLockOwner;
        public uint dwLockDuration;
    }



}