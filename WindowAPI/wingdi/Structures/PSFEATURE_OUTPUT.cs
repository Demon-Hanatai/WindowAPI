namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct PSFEATURE_OUTPUT
    {
        public bool bPageIndependent;
        public bool bSetPageDevice;
    }



}