namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SECURITY_QUALITY_OF_SERVICE
    {
        public uint Length;
        public int ImpersonationLevel;
        public int ContextTrackingMode;
        public bool EffectiveOnly;
    }



}