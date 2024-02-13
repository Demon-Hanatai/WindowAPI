namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct INPUT_MESSAGE_SOURCE
    {
        public INPUT_MESSAGE_DEVICE_TYPE deviceType;
        public INPUT_MESSAGE_ORIGIN_ID originId;
    }



}