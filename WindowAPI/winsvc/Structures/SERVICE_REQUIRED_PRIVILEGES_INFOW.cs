namespace WindowAPI.winsvc.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SERVICE_REQUIRED_PRIVILEGES_INFOW
    {
        public string pmszRequiredPrivileges;
    }



}