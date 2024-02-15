namespace WindowAPI.mstcpip.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct REAL_TIME_NOTIFICATION_SETTING_INPUT
    {
        public COMPARTMENT_ID TransportSettingId;
        public LUID BrokerEventGuid;
    }



}