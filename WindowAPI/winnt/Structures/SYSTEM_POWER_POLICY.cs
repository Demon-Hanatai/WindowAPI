namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SYSTEM_POWER_POLICY
    {
        public uint Revision;
        public POWER_ACTION_POLICY PowerButton;
        public POWER_ACTION_POLICY SleepButton;
        public POWER_ACTION_POLICY LidClose;
        public int LidOpenWake;
        public uint Reserved;
        public POWER_ACTION_POLICY Idle;
        public uint IdleTimeout;
        public byte IdleSensitivity;
        public byte DynamicThrottle;
        public byte Spare2;
        public int MinSleep;
        public int MaxSleep;
        public int ReducedLatencySleep;
        public uint WinLogonFlags;
        public uint Spare3;
        public uint DozeS4Timeout;
        public uint BroadcastCapacityResolution;
        public uint VideoTimeout;
        public bool VideoDimDisplay;
        public uint SpindownTimeout;
        public bool OptimizeForPower;
        public byte FanThrottleTolerance;
        public byte ForcedThrottle;
        public byte MinThrottle;
        public POWER_ACTION_POLICY OverThrottled;
    }



}