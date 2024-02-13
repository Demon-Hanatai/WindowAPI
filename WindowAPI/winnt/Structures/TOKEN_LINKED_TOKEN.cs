namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TOKEN_LINKED_TOKEN
    {
        public nint LinkedToken;
    }



}