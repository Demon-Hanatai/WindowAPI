namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct RID_DEVICE_INFO_MOUSE
    {
        public uint dwId;
        public uint dwNumberOfButtons;
        public uint dwSampleRate;
        public bool fHasHorizontalWheel;
    }



}