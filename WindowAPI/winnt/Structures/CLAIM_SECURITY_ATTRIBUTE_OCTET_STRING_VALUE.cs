namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE
    {
        public IntPtr pValue;
        public uint ValueLength;
    }



}