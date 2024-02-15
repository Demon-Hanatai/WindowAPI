namespace WindowAPI.mstcpip.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TCP_INFO_v1
    {
        public _TCPSTATE State;
        public uint Mss;
        public uint ConnectionTimeMs;
        public bool TimestampsEnabled;
        public uint RttUs;
        public uint MinRttUs;
        public uint BytesInFlight;
        public uint Cwnd;
        public uint SndWnd;
        public uint RcvWnd;
        public uint RcvBuf;
        public uint BytesOut;
        public uint BytesIn;
        public uint BytesReordered;
        public uint BytesRetrans;
        public uint FastRetrans;
        public uint DupAcksIn;
        public uint TimeoutEpisodes;
        public char SynRetrans;
        public uint SndLimTransRwin;
        public uint SndLimTimeRwin;
        public uint SndLimBytesRwin;
        public uint SndLimTransCwnd;
        public uint SndLimTimeCwnd;
        public uint SndLimBytesCwnd;
        public uint SndLimTransSnd;
        public uint SndLimTimeSnd;
        public uint SndLimBytesSnd;
    }



}