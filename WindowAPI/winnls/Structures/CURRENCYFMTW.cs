namespace WindowAPI.winnls.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CURRENCYFMTW
    {
        public uint NumDigits;
        public uint LeadingZero;
        public uint Grouping;
        public string lpDecimalSep;
        public string lpThousandSep;
        public uint NegativeOrder;
        public uint PositiveOrder;
        public string lpCurrencySymbol;
    }



}