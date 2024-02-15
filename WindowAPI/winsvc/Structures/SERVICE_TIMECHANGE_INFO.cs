namespace WindowAPI.winsvc.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SERVICE_TIMECHANGE_INFO
    {
        public ACE_HEADER liNewTime;
        public ACE_HEADER liOldTime;
    }



}