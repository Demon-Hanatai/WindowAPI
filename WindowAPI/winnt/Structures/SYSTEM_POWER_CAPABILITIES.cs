namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SYSTEM_POWER_CAPABILITIES
    {
        public bool PowerButtonPresent;
        public bool SleepButtonPresent;
        public bool LidPresent;
        public bool SystemS1;
        public bool SystemS2;
        public bool SystemS3;
        public bool SystemS4;
        public bool SystemS5;
        public bool HiberFilePresent;
        public bool FullWake;
        public bool VideoDimPresent;
        public bool ApmPresent;
        public bool UpsPresent;
        public bool ThermalControl;
        public bool ProcessorThrottle;
        public byte ProcessorMinThrottle;
        public byte ProcessorThrottleScale;
        public byte spare2;
        public byte ProcessorMaxThrottle;
        public bool FastSystemS4;
        public bool Hiberboot;
        public bool WakeAlarmPresent;
        public bool AoAc;
        public bool DiskSpinDown;
        public byte HiberFileType;
        public bool AoAcConnectivitySupported;
        public bool SystemBatteriesPresent;
        public bool BatteriesAreShortTerm;
        public int AcOnLineWake;
        public int SoftLidWake;
        public int RtcWake;
        public int MinDeviceWakeState;
        public int DefaultLowLatencyWake;
    }



}