namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TOUCHPREDICTIONPARAMETERS
    {
        public uint cbSize;
        public uint dwLatency;
        public uint dwSampleTime;
        public uint bUseHWTimeStamp;
    }



}