namespace WindowAPI.Af_irda.h.Structures
{
    public class SOCKADDR_IRDA
    {
        public ushort irdaAddressFamily;
        public required byte[] irdaDeviceID;
        [MarshalAs(UnmanagedType.LPTStr, SizeConst = 25)]
        public required string irdaServiceName;
    }
}
