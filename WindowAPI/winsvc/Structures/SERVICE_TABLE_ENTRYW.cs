using static WindowAPI.winsvc.CallBacks.CallBacks;


namespace WindowAPI.winsvc.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SERVICE_TABLE_ENTRYW
    {
        public string lpServiceName;
        public LPSERVICEMAINFUNCTIONW lpServiceProc;
    }



}