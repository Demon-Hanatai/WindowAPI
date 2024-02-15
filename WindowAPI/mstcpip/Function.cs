namespace WindowAPI.mstcpip
{
    public static class Functions
    {

        /// <summary>
        ///exp
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void ASSERT(dynamic exp);

        /// <summary>
        ///Determines whether two IPv4 addresses are equal.
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN4_ADDR_EQUAL(IN_ADDR a, IN_ADDR b);

        /// <summary>
        ///i
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void IN4_CLASSA(dynamic i);

        /// <summary>
        ///i
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void IN4_CLASSB(dynamic i);

        /// <summary>
        ///i
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void IN4_CLASSC(dynamic i);

        /// <summary>
        ///i
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void IN4_CLASSD(dynamic i);

        /// <summary>
        ///a
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN4_IS_ADDR_6TO4ELIGIBLE(IN_ADDR a);

        /// <summary>
        ///a
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN4_IS_ADDR_BROADCAST(IN_ADDR a);

        /// <summary>
        ///Determines whether the address argument is an IPv4 link-local address.
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN4_IS_ADDR_LINKLOCAL(IN_ADDR a);

        /// <summary>
        ///Determines whether the address argument is an IPv4 loopback address.
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN4_IS_ADDR_LOOPBACK(IN_ADDR a);

        /// <summary>
        ///a
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN4_IS_ADDR_MC_ADMINLOCAL(IN_ADDR a);

        /// <summary>
        ///Determines whether the address argument is an IPv4 multicast link-local address.
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN4_IS_ADDR_MC_LINKLOCAL(IN_ADDR a);

        /// <summary>
        ///Determines whether the address argument is an IPv4 multicast site-local address.
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN4_IS_ADDR_MC_SITELOCAL(IN_ADDR a);

        /// <summary>
        ///Determines whether the address argument is an IPv4 multicast address.
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN4_IS_ADDR_MULTICAST(IN_ADDR a);

        /// <summary>
        ///a
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN4_IS_ADDR_RFC1918(IN_ADDR a);

        /// <summary>
        ///Determines whether the address argument is an IPv4 site-local address.
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN4_IS_ADDR_SITELOCAL(IN_ADDR a);

        /// <summary>
        ///Determines whether the address argument is the unspecified IPv4 address (inaddr_any).
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN4_IS_ADDR_UNSPECIFIED(IN_ADDR a);

        /// <summary>
        ///a
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN4_IS_UNALIGNED_ADDR_6TO4ELIGIBLE(IN_ADDR a);

        /// <summary>
        ///a
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN4_IS_UNALIGNED_ADDR_BROADCAST(IN_ADDR a);

        /// <summary>
        ///Determines whether the address argument (which is permitted to be unaligned) is an IPv4 link-local address.
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN4_IS_UNALIGNED_ADDR_LINKLOCAL(IN_ADDR a);

        /// <summary>
        ///Determines whether the address argument (which is permitted to be unaligned) is an IPv4 loopback address.
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN4_IS_UNALIGNED_ADDR_LOOPBACK(IN_ADDR a);

        /// <summary>
        ///Determines whether the address argument (which is permitted to be unaligned) is an IPv4 multicast address.
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN4_IS_UNALIGNED_ADDR_MULTICAST(IN_ADDR a);

        /// <summary>
        ///a
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN4_IS_UNALIGNED_ADDR_RFC1918(IN_ADDR a);

        /// <summary>
        ///Determines whether the address argument (which is permitted to be unaligned) is the unspecified IPv4 address (inaddr_any).
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN4_IS_UNALIGNED_ADDR_UNSPECIFIED(IN_ADDR a);

        /// <summary>
        ///i
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void IN4_MULTICAST(dynamic i);

        /// <summary>
        ///Determines whether two IPv4 addresses are equal (where the pointer arguments are permitted to be unaligned).
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN4_UNALIGNED_ADDR_EQUAL(IN_ADDR a, IN_ADDR b);

        /// <summary>
        ///Address
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void IN4_UNCANONICALIZE_SCOPE_ID(IN_ADDR Address, nint ScopeId);

        /// <summary>
        ///a
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN4ADDR_ISANY(SOCKADDR_IRDA a);

        /// <summary>
        ///Determines whether two IPv4 addresses are equal.
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN4ADDR_ISEQUAL(SOCKADDR_IRDA a, SOCKADDR_IRDA b);

        /// <summary>
        ///Determines whether the address argument is an IPv4 loopback address.
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN4ADDR_ISLOOPBACK(SOCKADDR_IRDA a);

        /// <summary>
        ///Determines whether the address argument is the unspecified IPv4 address (inaddr_any).
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN4ADDR_ISUNSPECIFIED(SOCKADDR_IRDA a);

        /// <summary>
        ///a
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint IN4ADDR_SCOPE_ID(SOCKADDR_IRDA a);

        /// <summary>
        ///a
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void IN4ADDR_SETANY(SOCKADDR_IRDA a);

        /// <summary>
        ///a
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void IN4ADDR_SETLOOPBACK(SOCKADDR_IRDA a);

        /// <summary>
        ///a
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void IN4ADDR_SETSOCKADDR(SOCKADDR_IRDA a, IN_ADDR addr, ushort port);

        /// <summary>
        ///Ipv6Address
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern char IN6_EXTRACT_V4ADDR_FROM_6TO4(IN_ADDR Ipv6Address);

        /// <summary>
        ///Ipv6Address
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern char IN6_EXTRACT_V4ADDR_FROM_ISATAP(IN_ADDR Ipv6Address);

        /// <summary>
        ///Ipv6Address
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern char IN6_GET_ADDR_V4COMPAT(IN_ADDR Ipv6Address);

        /// <summary>
        ///Ipv6Address
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern char IN6_GET_ADDR_V4MAPPED(IN_ADDR Ipv6Address);

        /// <summary>
        ///a
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN6_IS_ADDR_6TO4(IN_ADDR a);

        /// <summary>
        ///a
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN6_IS_ADDR_ALLNODESONLINK(IN_ADDR a);

        /// <summary>
        ///a
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN6_IS_ADDR_ALLNODESONNODE(IN_ADDR a);

        /// <summary>
        ///a
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN6_IS_ADDR_ALLROUTERSONLINK(IN_ADDR a);

        /// <summary>
        ///a
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN6_IS_ADDR_ISATAP(IN_ADDR a);

        /// <summary>
        ///a
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN6_IS_ADDR_SOLICITEDNODE(IN_ADDR a);

        /// <summary>
        ///a
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN6_IS_ADDR_TEREDO(IN_ADDR a);

        /// <summary>
        ///Address
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern ACE_HEADER IN6_MULTICAST_SCOPE(char Address);

        /// <summary>
        ///a
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN6_PREFIX_EQUAL(IN_ADDR a, IN_ADDR b, uint len);

        /// <summary>
        ///Ipv6Address
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void IN6_SET_6TO4_PREFIX(IN_ADDR Ipv6Address, IN_ADDR Ipv4Address);

        /// <summary>
        ///Multicast
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void IN6_SET_ADDR_SOLICITEDNODE(IN_ADDR Multicast, IN_ADDR Unicast);

        /// <summary>
        ///a6
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void IN6_SET_ADDR_V4COMPAT(IN_ADDR a6, IN_ADDR a4);

        /// <summary>
        ///a6
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void IN6_SET_ADDR_V4MAPPED(IN_ADDR a6, IN_ADDR a4);

        /// <summary>
        ///Ipv6Address
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void IN6_SET_ISATAP_IDENTIFIER(IN_ADDR Ipv6Address, IN_ADDR Ipv4Address);

        /// <summary>
        ///Address
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void IN6_UNCANONICALIZE_SCOPE_ID(IN_ADDR Address, nint ScopeId);

        /// <summary>
        ///a
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN6ADDR_IS6TO4(SOCKADDR_IRDA a);

        /// <summary>
        ///a
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN6ADDR_ISISATAP(SOCKADDR_IRDA a);

        /// <summary>
        ///a
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN6ADDR_ISTEREDO(SOCKADDR_IRDA a);

        /// <summary>
        ///a
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IN6ADDR_ISV4MAPPED(SOCKADDR_IRDA a);

        /// <summary>
        ///a
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void IN6ADDR_SETSOCKADDR(SOCKADDR_IRDA a, IN_ADDR addr, nint scope, ushort port);

        /// <summary>
        ///a6
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void IN6ADDR_SETV4MAPPED(SOCKADDR_IRDA a6, IN_ADDR a4, nint scope, ushort port);


    }
}