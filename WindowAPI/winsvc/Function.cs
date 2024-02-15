using WindowAPI.minwinbase.Structures;
using WindowAPI.winsvc.Structures;
using static WindowAPI.winsvc.CallBacks.CallBacks;
namespace WindowAPI.winsvc
{
    public static class Functions
    {

        /// <summary>
        ///Changes the optional configuration parameters of a service.
        /// </summary>
        /// <param name="hService">A handle to the service. This handle is returned by the OpenService or CreateService function and must have the SERVICE_CHANGE_CONFIG access right. For more information, see Service Security and Access Rights.If the service controller handles the SC_ACTION_RESTART action, hService must have the SERVICE_START access right.</param>
        /// <param name="dwInfoLevel">The configuration information to be changed. This parameter can be one of the following values.</param>
        /// <param name="lpInfo"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ChangeServiceConfig2A(nint hService, uint dwInfoLevel, nint lpInfo);

        /// <summary>
        ///Changes the optional configuration parameters of a service.
        /// </summary>
        /// <param name="hService">A handle to the service. This handle is returned by the OpenServiceW or CreateServiceW function and must have the SERVICE_CHANGE_CONFIG access right. For more information, see Service Security and Access Rights.If the service controller handles the SC_ACTION_RESTART action, hService must have the SERVICE_START access right.</param>
        /// <param name="dwInfoLevel">The configuration information to be changed. This parameter can be one of the following values.</param>
        /// <param name="lpInfo"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ChangeServiceConfig2W(nint hService, uint dwInfoLevel, nint lpInfo);

        /// <summary>
        ///Changes the configuration parameters of a service.
        /// </summary>
        /// <param name="hService">A handle to the service. This handle is returned by the OpenService or CreateService function and must have the SERVICE_CHANGE_CONFIG access right. For more information, see Service Security and Access Rights.</param>
        /// <param name="dwServiceType">The type of service. Specify SERVICE_NO_CHANGE if you are not changing the existing service type; otherwise, specify one of the following service types.If you specify either SERVICE_WIN32_OWN_PROCESS or SERVICE_WIN32_SHARE_PROCESS, and the service is running in the context of the LocalSystem account, you can also specify the following type.</param>
        /// <param name="dwStartType">The service start options. Specify SERVICE_NO_CHANGE if you are not changing the existing start type; otherwise, specify one of the following values.</param>
        /// <param name="dwErrorControl">The severity of the error, and action taken, if this service fails to start. Specify SERVICE_NO_CHANGE if you are not changing the existing error control; otherwise, specify one of the following values.</param>
        /// <param name="lpBinaryPathName"></param>
        /// <param name="lpLoadOrderGroup"></param>
        /// <param name="lpdwTagId"></param>
        /// <param name="lpDependencies"></param>
        /// <param name="lpServiceStartName"></param>
        /// <param name="lpPassword"></param>
        /// <param name="lpDisplayName"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ChangeServiceConfigA(nint hService, uint dwServiceType, uint dwStartType, uint dwErrorControl, string lpBinaryPathName, string lpLoadOrderGroup, out uint lpdwTagId, string lpDependencies, string lpServiceStartName, string lpPassword, string lpDisplayName);

        /// <summary>
        ///Changes the configuration parameters of a service.
        /// </summary>
        /// <param name="hService">A handle to the service. This handle is returned by the OpenService or CreateService function and must have the SERVICE_CHANGE_CONFIG access right. For more information, see Service Security and Access Rights.</param>
        /// <param name="dwServiceType">The type of service. Specify SERVICE_NO_CHANGE if you are not changing the existing service type; otherwise, specify one of the following service types.If you specify either SERVICE_WIN32_OWN_PROCESS or SERVICE_WIN32_SHARE_PROCESS, and the service is running in the context of the LocalSystem account, you can also specify the following type.</param>
        /// <param name="dwStartType">The service start options. Specify SERVICE_NO_CHANGE if you are not changing the existing start type; otherwise, specify one of the following values.</param>
        /// <param name="dwErrorControl">The severity of the error, and action taken, if this service fails to start. Specify SERVICE_NO_CHANGE if you are not changing the existing error control; otherwise, specify one of the following values.</param>
        /// <param name="lpBinaryPathName"></param>
        /// <param name="lpLoadOrderGroup"></param>
        /// <param name="lpdwTagId"></param>
        /// <param name="lpDependencies"></param>
        /// <param name="lpServiceStartName"></param>
        /// <param name="lpPassword"></param>
        /// <param name="lpDisplayName"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ChangeServiceConfigW(nint hService, uint dwServiceType, uint dwStartType, uint dwErrorControl, string lpBinaryPathName, string lpLoadOrderGroup, out uint lpdwTagId, string lpDependencies, string lpServiceStartName, string lpPassword, string lpDisplayName);

        /// <summary>
        ///Closes a handle to a service control manager or service object.
        /// </summary>
        /// <param name="hSCObject">A handle to the service control manager object or the service object to close. Handles to service control manager objects are returned by the OpenSCManager function, and handles to service objects are returned by either the OpenService or CreateService function.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The following error code can be set by the service control manager. Other error codes can be set by registry functions that are called by the service control manager.The CloseServiceHandle function does not destroy the service control manager object referred to by the handle. A service control manager object cannot be destroyed. A service object can be destroyed by calling the DeleteService function.For an example, see Deleting a Service.CreateServiceDeleteServiceOpenSCManagerOpenServiceSCM HandlesService Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CloseServiceHandle(nint hSCObject);

        /// <summary>
        ///Sends a control code to a service.
        /// </summary>
        /// <param name="hService">A handle to the service. This handle is returned by the OpenService or CreateService function. The access rights required for this handle depend on the dwControl code requested.</param>
        /// <param name="dwControl">This parameter can be one of the following control codes.This value can also be a user-defined control code, as described in the following table.</param>
        /// <param name="lpServiceStatus"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("AdvApi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ControlService(nint hService, uint dwControl, out SERVICE_STATUS lpServiceStatus);

        /// <summary>
        ///Sends a control code to a service.
        /// </summary>
        /// <param name="hService">A handle to the service. This handle is returned by the OpenService or CreateService function. The access rights required for this handle depend on the dwControl code requested.</param>
        /// <param name="dwControl">This parameter can be one of the following control codes.This parameter can also be a user-defined control code, as described in the following table.</param>
        /// <param name="dwInfoLevel">The information level for the service control parameters. This parameter must be set to SERVICE_CONTROL_STATUS_REASON_INFO (1).</param>
        /// <param name="pControlParams">A pointer to the service control parameters. If dwInfoLevel is SERVICE_CONTROL_STATUS_REASON_INFO, this member is a pointer to a SERVICE_CONTROL_STATUS_REASON_PARAMS structure.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The following error codes can be set by the service control manager. Other error codes can be set by the registry functions that are called by the service control manager.The ControlServiceEx function asks the Service Control Manager (SCM) to send the requested control code to the service. The SCM sends the code if the service has specified that it will accept the code, and is in a state in which a control code can be sent to it.The SCM processes service control notifications in a serial fashion — it waits for one service to complete processing a service control notification before sending the next one. Because of this, a call to ControlServiceEx blocks for 30 seconds if any service is busy handling a control code. If the busy service still has not returned from its handler function when the timeout expires, ControlServiceEx fails with ERROR_SERVICE_REQUEST_TIMEOUT.To stop and start a service requires a security descriptor that allows you to do so. The default security descriptor allows the LocalSystem account, and members of the Administrators and Power Users groups to stop and start services. To change the security descriptor of a service, see Modifying the DACL for a Service.The QueryServiceStatusEx function returns a SERVICE_STATUS_PROCESS structure whose dwCurrentState and dwControlsAccepted members indicate the current state and controls accepted by a running service. All running services accept the SERVICE_CONTROL_INTERROGATE control code by default. Drivers do not accept control codes other than SERVICE_CONTROL_STOP and SERVICE_CONTROL_INTERROGATE. Each service specifies the other control codes that it accepts when it calls the SetServiceStatus function to report its status. A service should always accept these codes when it is running, no matter what it is doing.The following table shows the action of the SCM in each of the possible service states.CreateServiceOpenServiceQueryServiceStatusExSERVICE_CONTROL_STATUS_REASON_PARAMSSERVICE_STATUSService Control RequestsService FunctionsSetServiceObjectSecuritySetServiceStatus</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ControlServiceExA(nint hService, uint dwControl, uint dwInfoLevel, out nint pControlParams);

        /// <summary>
        ///Sends a control code to a service.
        /// </summary>
        /// <param name="hService">A handle to the service. This handle is returned by the OpenService or CreateService function. The access rights required for this handle depend on the dwControl code requested.</param>
        /// <param name="dwControl">This parameter can be one of the following control codes.This parameter can also be a user-defined control code, as described in the following table.</param>
        /// <param name="dwInfoLevel">The information level for the service control parameters. This parameter must be set to SERVICE_CONTROL_STATUS_REASON_INFO (1).</param>
        /// <param name="pControlParams">A pointer to the service control parameters. If dwInfoLevel is SERVICE_CONTROL_STATUS_REASON_INFO, this member is a pointer to a SERVICE_CONTROL_STATUS_REASON_PARAMS structure.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The following error codes can be set by the service control manager. Other error codes can be set by the registry functions that are called by the service control manager.The ControlServiceEx function asks the Service Control Manager (SCM) to send the requested control code to the service. The SCM sends the code if the service has specified that it will accept the code, and is in a state in which a control code can be sent to it.The SCM processes service control notifications in a serial fashion — it waits for one service to complete processing a service control notification before sending the next one. Because of this, a call to ControlServiceEx blocks for 30 seconds if any service is busy handling a control code. If the busy service still has not returned from its handler function when the timeout expires, ControlServiceEx fails with ERROR_SERVICE_REQUEST_TIMEOUT.To stop and start a service requires a security descriptor that allows you to do so. The default security descriptor allows the LocalSystem account, and members of the Administrators and Power Users groups to stop and start services. To change the security descriptor of a service, see Modifying the DACL for a Service.The QueryServiceStatusEx function returns a SERVICE_STATUS_PROCESS structure whose dwCurrentState and dwControlsAccepted members indicate the current state and controls accepted by a running service. All running services accept the SERVICE_CONTROL_INTERROGATE control code by default. Drivers do not accept control codes other than SERVICE_CONTROL_STOP and SERVICE_CONTROL_INTERROGATE. Each service specifies the other control codes that it accepts when it calls the SetServiceStatus function to report its status. A service should always accept these codes when it is running, no matter what it is doing.The following table shows the action of the SCM in each of the possible service states.CreateServiceOpenServiceQueryServiceStatusExSERVICE_CONTROL_STATUS_REASON_PARAMSSERVICE_STATUSService Control RequestsService FunctionsSetServiceObjectSecuritySetServiceStatus</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ControlServiceExW(nint hService, uint dwControl, uint dwInfoLevel, out nint pControlParams);

        /// <summary>
        ///Creates a service object and adds it to the specified service control manager database.
        /// </summary>
        /// <param name="hSCManager">A handle to the service control manager database. This handle is returned by the OpenSCManager function and must have the SC_MANAGER_CREATE_SERVICE access right. For more information, see Service Security and Access Rights.</param>
        /// <param name="lpServiceName">The name of the service to install. The maximum string length is 256 characters. The service control manager database preserves the case of the characters, but service name comparisons are always case insensitive. Forward-slash (/) and backslash (\) are not valid service name characters.</param>
        /// <param name="lpDisplayName"></param>
        /// <param name="dwDesiredAccess">The access to the service. Before granting the requested access, the system checks the access token of the calling process. For a list of values, see Service Security and Access Rights.</param>
        /// <param name="dwServiceType">The service type. This parameter can be one of the following values.If you specify either SERVICE_WIN32_OWN_PROCESS or SERVICE_WIN32_SHARE_PROCESS, and the service is running in the context of the LocalSystem account, you can also specify the following value.</param>
        /// <param name="dwStartType">The service start options. This parameter can be one of the following values.</param>
        /// <param name="dwErrorControl">The severity of the error, and action taken, if this service fails to start. This parameter can be one of the following values.</param>
        /// <param name="lpBinaryPathName"></param>
        /// <param name="lpLoadOrderGroup"></param>
        /// <param name="lpdwTagId"></param>
        /// <param name="lpDependencies"></param>
        /// <param name="lpServiceStartName"></param>
        /// <param name="lpPassword"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateServiceA(nint hSCManager, string lpServiceName, string lpDisplayName, uint dwDesiredAccess, uint dwServiceType, uint dwStartType, uint dwErrorControl, string lpBinaryPathName, string lpLoadOrderGroup, out uint lpdwTagId, string lpDependencies, string lpServiceStartName, string lpPassword);

        /// <summary>
        ///Creates a service object and adds it to the specified service control manager database.
        /// </summary>
        /// <param name="hSCManager">A handle to the service control manager database. This handle is returned by the OpenSCManager function and must have the SC_MANAGER_CREATE_SERVICE access right. For more information, see Service Security and Access Rights.</param>
        /// <param name="lpServiceName">The name of the service to install. The maximum string length is 256 characters. The service control manager database preserves the case of the characters, but service name comparisons are always case insensitive. Forward-slash (/) and backslash (\) are not valid service name characters.</param>
        /// <param name="lpDisplayName"></param>
        /// <param name="dwDesiredAccess">The access to the service. Before granting the requested access, the system checks the access token of the calling process. For a list of values, see Service Security and Access Rights.</param>
        /// <param name="dwServiceType">The service type. This parameter can be one of the following values.If you specify either SERVICE_WIN32_OWN_PROCESS or SERVICE_WIN32_SHARE_PROCESS, and the service is running in the context of the LocalSystem account, you can also specify the following value.</param>
        /// <param name="dwStartType">The service start options. This parameter can be one of the following values.</param>
        /// <param name="dwErrorControl">The severity of the error, and action taken, if this service fails to start. This parameter can be one of the following values.</param>
        /// <param name="lpBinaryPathName"></param>
        /// <param name="lpLoadOrderGroup"></param>
        /// <param name="lpdwTagId"></param>
        /// <param name="lpDependencies"></param>
        /// <param name="lpServiceStartName"></param>
        /// <param name="lpPassword"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateServiceW(nint hSCManager, string lpServiceName, string lpDisplayName, uint dwDesiredAccess, uint dwServiceType, uint dwStartType, uint dwErrorControl, string lpBinaryPathName, string lpLoadOrderGroup, out uint lpdwTagId, string lpDependencies, string lpServiceStartName, string lpPassword);

        /// <summary>
        ///Marks the specified service for deletion from the service control manager database.
        /// </summary>
        /// <param name="hService">A handle to the service. This handle is returned by the OpenService or CreateService function, and it must have the DELETE access right. For more information, see Service Security and Access Rights.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The following error codes may be set by the service control manager. Others may be set by the registry functions that are called by the service control manager.The DeleteService function marks a service for deletion from the service control manager database. The database entry is not removed until all open handles to the service have been closed by calls to the CloseServiceHandle function, and the service is not running. A running service is stopped by a call to the ControlService function with the SERVICE_CONTROL_STOP control code. If the service cannot be stopped, the database entry is removed when the system is restarted.The service control manager deletes the service by deleting the service key and its subkeys from the registry.For an example, see Deleting a Service.CloseServiceHandleControlServiceCreateServiceOpenServiceService FunctionsService Installation, Removal, and Enumeration</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool DeleteService(nint hService);

        /// <summary>
        ///Retrieves the name and status of each service that depends on the specified service; that is, the specified service must be running before the dependent services can run.
        /// </summary>
        /// <param name="hService">A handle to the service. This handle is returned by the OpenService or CreateService function, and it must have the SERVICE_ENUMERATE_DEPENDENTS access right. For more information, see Service Security and Access Rights.</param>
        /// <param name="dwServiceState">The state of the services to be enumerated. This parameter can be one of the following values.</param>
        /// <param name="lpServices"></param>
        /// <param name="cbBufSize">The size of the buffer pointed to by the lpServices parameter, in bytes.</param>
        /// <param name="pcbBytesNeeded"></param>
        /// <param name="lpServicesReturned"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EnumDependentServicesA(nint hService, uint dwServiceState, out ENUM_SERVICE_STATUSA lpServices, uint cbBufSize, out uint pcbBytesNeeded, out uint lpServicesReturned);

        /// <summary>
        ///Retrieves the name and status of each service that depends on the specified service; that is, the specified service must be running before the dependent services can run.
        /// </summary>
        /// <param name="hService">A handle to the service. This handle is returned by the OpenService or CreateService function, and it must have the SERVICE_ENUMERATE_DEPENDENTS access right. For more information, see Service Security and Access Rights.</param>
        /// <param name="dwServiceState">The state of the services to be enumerated. This parameter can be one of the following values.</param>
        /// <param name="lpServices"></param>
        /// <param name="cbBufSize">The size of the buffer pointed to by the lpServices parameter, in bytes.</param>
        /// <param name="pcbBytesNeeded"></param>
        /// <param name="lpServicesReturned"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EnumDependentServicesW(nint hService, uint dwServiceState, out ENUM_SERVICE_STATUSW lpServices, uint cbBufSize, out uint pcbBytesNeeded, out uint lpServicesReturned);

        /// <summary>
        ///Enumerates services in the specified service control manager database. The name and status of each service are provided.
        /// </summary>
        /// <param name="hSCManager">A handle to the service control manager database. This handle is returned by the OpenSCManager function, and must have the SC_MANAGER_ENUMERATE_SERVICE access right. For more information, see Service Security and Access Rights.</param>
        /// <param name="dwServiceType">The type of services to be enumerated. This parameter can be one or more of the following values.</param>
        /// <param name="dwServiceState">The state of the services to be enumerated. This parameter can be one of the following values.</param>
        /// <param name="lpServices"></param>
        /// <param name="cbBufSize">The size of the buffer pointed to by the lpServices parameter, in bytes.</param>
        /// <param name="pcbBytesNeeded"></param>
        /// <param name="lpServicesReturned"></param>
        /// <param name="lpResumeHandle"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EnumServicesStatusA(nint hSCManager, uint dwServiceType, uint dwServiceState, out ENUM_SERVICE_STATUSA lpServices, uint cbBufSize, out uint pcbBytesNeeded, out uint lpServicesReturned, out uint lpResumeHandle);

        /// <summary>
        ///Enumerates services in the specified service control manager database. The name and status of each service are provided, along with additional data based on the specified information level.
        /// </summary>
        /// <param name="hSCManager">A handle to the service control manager database. This handle is returned by the OpenSCManager function, and must have the SC_MANAGER_ENUMERATE_SERVICE access right. For more information, see Service Security and Access Rights.</param>
        /// <param name="InfoLevel">The service attributes that are to be returned. Use SC_ENUM_PROCESS_INFO to retrieve the name and service status information for each service in the database. The lpServices parameter is a pointer to a buffer that receives an array of ENUM_SERVICE_STATUS_PROCESS structures. The buffer must be large enough to hold the structures as well as the strings to which their members point.Currently, no other information levels are defined.</param>
        /// <param name="dwServiceType">The type of services to be enumerated. This parameter can be one or more of the following values.</param>
        /// <param name="dwServiceState">The state of the services to be enumerated. This parameter can be one of the following values.</param>
        /// <param name="lpServices"></param>
        /// <param name="cbBufSize">The size of the buffer pointed to by the lpServices parameter, in bytes.</param>
        /// <param name="pcbBytesNeeded"></param>
        /// <param name="lpServicesReturned"></param>
        /// <param name="lpResumeHandle"></param>
        /// <param name="pszGroupName"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError. The following errors may be returned.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EnumServicesStatusExA(nint hSCManager, _TOKEN_TYPE InfoLevel, uint dwServiceType, uint dwServiceState, out byte lpServices, uint cbBufSize, out uint pcbBytesNeeded, out uint lpServicesReturned, out uint lpResumeHandle, string pszGroupName);

        /// <summary>
        ///Enumerates services in the specified service control manager database. The name and status of each service are provided, along with additional data based on the specified information level.
        /// </summary>
        /// <param name="hSCManager">A handle to the service control manager database. This handle is returned by the OpenSCManager function, and must have the SC_MANAGER_ENUMERATE_SERVICE access right. For more information, see Service Security and Access Rights.</param>
        /// <param name="InfoLevel">The service attributes that are to be returned. Use SC_ENUM_PROCESS_INFO to retrieve the name and service status information for each service in the database. The lpServices parameter is a pointer to a buffer that receives an array of ENUM_SERVICE_STATUS_PROCESS structures. The buffer must be large enough to hold the structures as well as the strings to which their members point.Currently, no other information levels are defined.</param>
        /// <param name="dwServiceType">The type of services to be enumerated. This parameter can be one or more of the following values.</param>
        /// <param name="dwServiceState">The state of the services to be enumerated. This parameter can be one of the following values.</param>
        /// <param name="lpServices"></param>
        /// <param name="cbBufSize">The size of the buffer pointed to by the lpServices parameter, in bytes.</param>
        /// <param name="pcbBytesNeeded"></param>
        /// <param name="lpServicesReturned"></param>
        /// <param name="lpResumeHandle"></param>
        /// <param name="pszGroupName"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError. The following errors may be returned.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EnumServicesStatusExW(nint hSCManager, _TOKEN_TYPE InfoLevel, uint dwServiceType, uint dwServiceState, out byte lpServices, uint cbBufSize, out uint pcbBytesNeeded, out uint lpServicesReturned, out uint lpResumeHandle, string pszGroupName);

        /// <summary>
        ///Enumerates services in the specified service control manager database. The name and status of each service are provided.
        /// </summary>
        /// <param name="hSCManager">A handle to the service control manager database. This handle is returned by the OpenSCManager function, and must have the SC_MANAGER_ENUMERATE_SERVICE access right. For more information, see Service Security and Access Rights.</param>
        /// <param name="dwServiceType">The type of services to be enumerated. This parameter can be one or more of the following values.</param>
        /// <param name="dwServiceState">The state of the services to be enumerated. This parameter can be one of the following values.</param>
        /// <param name="lpServices"></param>
        /// <param name="cbBufSize">The size of the buffer pointed to by the lpServices parameter, in bytes.</param>
        /// <param name="pcbBytesNeeded"></param>
        /// <param name="lpServicesReturned"></param>
        /// <param name="lpResumeHandle"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EnumServicesStatusW(nint hSCManager, uint dwServiceType, uint dwServiceState, out ENUM_SERVICE_STATUSW lpServices, uint cbBufSize, out uint pcbBytesNeeded, out uint lpServicesReturned, out uint lpResumeHandle);

        /// <summary>
        ///Returns a path for a per-service filesystem location for a service to read and/or write state to.
        /// </summary>

        [DllImport("sechost.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetServiceDirectory();

        /// <summary>
        ///Retrieves the display name of the specified service.
        /// </summary>
        /// <param name="hSCManager">A handle to the service control manager database, as returned by the OpenSCManager function.</param>
        /// <param name="lpServiceName">The service name. This name is the same as the service's registry key name. It is best to choose a name that is less than 256 characters.</param>
        /// <param name="lpDisplayName"></param>
        /// <param name="lpcchBuffer">A pointer to a variable that specifies the size of the buffer pointed to by lpDisplayName, in TCHARs.On output, this variable receives the size of the service's display name, in characters, excluding the null-terminating character.If the buffer pointed to by lpDisplayName is too small to contain the display name, the function does not store it. When the function returns, lpcchBuffer contains the size of the service's display name, excluding the null-terminating character.If the functions succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.There are two names for a service: the service name and the display name. The service name is the name of the service's key in the registry. The display name is a user-friendly name that appears in the Services control panel application, and is used with the NET START command. To map the service name to the display name, use the GetServiceDisplayName function. To map the display name to the service name, use the GetServiceKeyName function.GetServiceKeyName OpenSCManager Service Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetServiceDisplayNameA(nint hSCManager, string lpServiceName, out string lpDisplayName, out uint lpcchBuffer);

        /// <summary>
        ///Retrieves the display name of the specified service.
        /// </summary>
        /// <param name="hSCManager">A handle to the service control manager database, as returned by the OpenSCManager function.</param>
        /// <param name="lpServiceName">The service name. This name is the same as the service's registry key name. It is best to choose a name that is less than 256 characters.</param>
        /// <param name="lpDisplayName"></param>
        /// <param name="lpcchBuffer">A pointer to a variable that specifies the size of the buffer pointed to by lpDisplayName, in TCHARs.On output, this variable receives the size of the service's display name, in characters, excluding the null-terminating character.If the buffer pointed to by lpDisplayName is too small to contain the display name, the function does not store it. When the function returns, lpcchBuffer contains the size of the service's display name, excluding the null-terminating character.If the functions succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.There are two names for a service: the service name and the display name. The service name is the name of the service's key in the registry. The display name is a user-friendly name that appears in the Services control panel application, and is used with the NET START command. To map the service name to the display name, use the GetServiceDisplayName function. To map the display name to the service name, use the GetServiceKeyName function.GetServiceKeyNameOpenSCManagerService Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetServiceDisplayNameW(nint hSCManager, string lpServiceName, out string lpDisplayName, out uint lpcchBuffer);

        /// <summary>
        ///Retrieves the service name of the specified service.
        /// </summary>
        /// <param name="hSCManager">A handle to the computer's service control manager database, as returned by OpenSCManager.</param>
        /// <param name="lpDisplayName">The service display name. This string has a maximum length of 256 characters.</param>
        /// <param name="lpServiceName"></param>
        /// <param name="lpcchBuffer">A pointer to variable that specifies the size of the buffer pointed to by the lpServiceName parameter, in TCHARs. When the function returns, this parameter contains the size of the service name, in TCHARs, excluding the null-terminating character.If the buffer pointed to by lpServiceName is too small to contain the service name, the function stores no data in it. When the function returns, lpcchBuffer contains the size of the service name, excluding the NULL terminator.If the functions succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.There are two names for a service: the service name and the display name. The service name is the name of the service's key in the registry. The display name is a user-friendly name that appears in the Services control panel application, and is used with the NET START command. Both names are specified with the CreateService function and can be modified with the ChangeServiceConfig function. Information specified for a service is stored in a key with the same name as the service name under the HKEY_LOCAL_MACHINE\System\CurrentControlSet\Services\ServiceName registry key.To map the service name to the display name, use the GetServiceDisplayName function. To map the display name to the service name, use the GetServiceKeyName function.GetServiceDisplayNameOpenSCManagerService Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetServiceKeyNameA(nint hSCManager, string lpDisplayName, out string lpServiceName, out uint lpcchBuffer);

        /// <summary>
        ///Retrieves the service name of the specified service.
        /// </summary>
        /// <param name="hSCManager">A handle to the computer's service control manager database, as returned by OpenSCManager.</param>
        /// <param name="lpDisplayName">The service display name. This string has a maximum length of 256 characters.</param>
        /// <param name="lpServiceName"></param>
        /// <param name="lpcchBuffer">A pointer to variable that specifies the size of the buffer pointed to by the lpServiceName parameter, in TCHARs. When the function returns, this parameter contains the size of the service name, in TCHARs, excluding the null-terminating character.If the buffer pointed to by lpServiceName is too small to contain the service name, the function stores no data in it. When the function returns, lpcchBuffer contains the size of the service name, excluding the NULL terminator.If the functions succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.There are two names for a service: the service name and the display name. The service name is the name of the service's key in the registry. The display name is a user-friendly name that appears in the Services control panel application, and is used with the NET START command. Both names are specified with the CreateService function and can be modified with the ChangeServiceConfig function. Information specified for a service is stored in a key with the same name as the service name under the HKEY_LOCAL_MACHINE\System\CurrentControlSet\Services\ServiceName registry key.To map the service name to the display name, use the GetServiceDisplayName function. To map the display name to the service name, use the GetServiceKeyName function.GetServiceDisplayNameOpenSCManagerService Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetServiceKeyNameW(nint hSCManager, string lpDisplayName, out string lpServiceName, out uint lpcchBuffer);

        /// <summary>
        ///Returns a handle for a registry key for a service to read and/or write state to.
        /// </summary>

        [DllImport("sechost.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetServiceRegistryStateKey();

        /// <summary>
        ///Returns a path for a per-service filesystem location for a service and associated programs to read and/or write state to.
        /// </summary>

        [DllImport("sechost.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetSharedServiceDirectory();

        /// <summary>
        ///Returns a handle for a registry key for a service and associated programs to read and/or write state to.
        /// </summary>

        [DllImport("sechost.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetSharedServiceRegistryStateKey();

        /// <summary>
        ///[As of Windows Vista, this function is provided for application compatibility and has no effect on the database.]
        /// </summary>
        /// <param name="hSCManager">A handle to the SCM database. This handle is returned by the OpenSCManager function, and must have the SC_MANAGER_LOCK access right. For more information, see Service Security and Access Rights.If the function succeeds, the return value is a lock to the specified SCM database.If the function fails, the return value is NULL. To get extended error information, call GetLastError.The following error codes can be set by the SCM. Other error codes can be set by registry functions that are called by the SCM.A lock is a protocol used by setup and configuration programs and the SCM to serialize access to the service tree in the registry. The only time the SCM requests ownership of the lock is when it is starting a service.A program that acquires the SCM database lock and fails to release it prevents the SCM from starting other services. Because of the severity of this issue, processes are no longer allowed to lock the database. For compatibility with older applications, the LockServiceDatabase function returns a lock but has no other effect.Windows Server 2003 and Windows XP:  Acquiring the SCM database lock prevents the SCM from starting a service until the lock is released. For example, a program that must configure several related services before any of them starts could call LockServiceDatabase before configuring the first service. Alternatively, it could ensure that none of the services are started until the configuration has been completed.A call to the StartService function to start a service in a locked database fails. No other SCM functions are affected by a lock.The lock is held until the SC_LOCK handle is specified in a subsequent call to the UnlockServiceDatabase function. If a process that owns a lock terminates, the SCM automatically cleans up and releases ownership of the lock.Failing to release the lock can cause system problems. A process that acquires the lock should release it as soon as possible.ChangeServiceConfigOpenSCManagerQueryServiceLockStatusService ConfigurationService FunctionsSetServiceObjectSecurityStartServiceUnlockServiceDatabase</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern Block LockServiceDatabase(nint hSCManager);

        /// <summary>
        ///Reports the boot status to the service control manager. It is used by boot verification programs. This function can be called only by a process running in the LocalSystem or Administrator's account.
        /// </summary>
        /// <param name="BootAcceptable">If the value is TRUE, the system saves the configuration as the last-known good configuration. If the value is FALSE, the system immediately reboots, using the previously saved last-known good configuration.If the BootAcceptable parameter is FALSE, the function does not return.If the last-known good configuration was successfully saved, the return value is nonzero.If an error occurs, the return value is zero. To get extended error information, call GetLastError.The following error codes may be set by the service control manager. Other error codes may be set by the registry functions that are called by the service control manager to set parameters in the configuration registry.Saving the configuration of a running system with this function is an acceptable method for saving the last-known good configuration. If the boot configuration is unacceptable, use this function to reboot the system using the existing last-known good configuration.This function call requires the caller's token to have permission to acquire the SC_MANAGER_MODIFY_BOOT_CONFIG access right. For more information, see Service Security and Access Rights.Automatically Starting ServicesService Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool NotifyBootConfigStatus(bool BootAcceptable);

        /// <summary>
        ///Enables an application to receive notification when the specified service is created or deleted or when its status changes.
        /// </summary>
        /// <param name="hService">A handle to the service or the service control manager. Handles to services are returned by the OpenService or CreateService function and must have the SERVICE_QUERY_STATUS access right. Handles to the service control manager are returned by the OpenSCManager function and must have the SC_MANAGER_ENUMERATE_SERVICE access right. For more information, see Service Security and Access Rights.There can only be one outstanding notification request per service.</param>
        /// <param name="dwNotifyMask">The type of status changes that should be reported. This parameter can be one or more of the following values.</param>
        /// <param name="pNotifyBuffer">A pointer to a SERVICE_NOTIFY structure that contains notification information, such as a pointer to the callback function. This structure must remain valid until the callback function is invoked or the calling thread cancels the notification request.Do not make multiple calls to NotifyServiceStatusChange with the same buffer parameter until the callback function from the first call has finished with the buffer or the first notification request has been canceled. Otherwise, there is no guarantee which version of the buffer the callback function will receive.Windows Vista:  The address of the callback function must be within the address range of a loaded module. Therefore, the callback function cannot be code that is generated at run time (such as managed code generated by the JIT compiler) or native code that is decompressed at run time. This restriction was removed in Windows Server 2008 and Windows Vista with SP1.If the function succeeds, the return value is ERROR_SUCCESS. If the service has been marked for deletion, the return value is ERROR_SERVICE_MARKED_FOR_DELETE and the handle to the service must be closed. If service notification is lagging too far behind the system state, the function returns ERROR_SERVICE_NOTIFY_CLIENT_LAGGING. In this case, the client should close the handle to the SCM, open a new handle, and call this function again.If the function fails, the return value is one of the system error codes.The NotifyServiceStatusChange function can be used to receive notifications about service applications. It cannot be used to receive notifications about driver services.When the service status changes, the system invokes the specified callback function as an asynchronous procedure call (APC) queued to the calling thread. The calling thread must enter an alertable wait (for example, by calling the SleepEx function) to receive notification. For more information, see Asynchronous Procedure Calls.If the service is already in any of the requested states when NotifyServiceStatusChange is called, the callback function is queued immediately. If the service state has not changed by the next time the function is called with the same service and state, the callback function is not queued immediately; the callback function is queued the next time the service enters the requested state.The NotifyServiceStatusChange function calls the OpenThread function on the calling thread with the THREAD_SET_CONTEXT access right. If the calling thread does not have this access right, NotifyServiceStatusChange fails. If the calling thread is impersonating another user, it may not have sufficient permission to set context.It is more efficient to call NotifyServiceStatusChange from a thread that performs a wait than to create an additional thread.After the callback function is invoked, the caller must call NotifyServiceStatusChange to receive additional notifications. Note that certain functions in the Windows API, including NotifyServiceStatusChange and other SCM functions, use remote procedure calls (RPC); these functions might perform an alertable wait operation, so they are not safe to call from within the callback function. Instead, the callback function should save the notification parameters and perform any additional work outside the callback.To cancel outstanding notifications, close the service handle using the CloseServiceHandle function. After CloseServiceHandle succeeds, no more notification APCs will be queued. If the calling thread exits without closing the service handle or waiting until the APC is generated, a memory leak can occur.SERVICE_NOTIFYSubscribeServiceChangeNotificationsService Functions</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint NotifyServiceStatusChangeA(nint hService, uint dwNotifyMask, SERVICE_NOTIFY_2A pNotifyBuffer);

        /// <summary>
        ///Enables an application to receive notification when the specified service is created or deleted or when its status changes.
        /// </summary>
        /// <param name="hService">A handle to the service or the service control manager. Handles to services are returned by the OpenService or CreateService function and must have the SERVICE_QUERY_STATUS access right. Handles to the service control manager are returned by the OpenSCManager function and must have the SC_MANAGER_ENUMERATE_SERVICE access right. For more information, see Service Security and Access Rights.There can only be one outstanding notification request per service.</param>
        /// <param name="dwNotifyMask">The type of status changes that should be reported. This parameter can be one or more of the following values.</param>
        /// <param name="pNotifyBuffer">A pointer to a SERVICE_NOTIFY structure that contains notification information, such as a pointer to the callback function. This structure must remain valid until the callback function is invoked or the calling thread cancels the notification request.Do not make multiple calls to NotifyServiceStatusChange with the same buffer parameter until the callback function from the first call has finished with the buffer or the first notification request has been canceled. Otherwise, there is no guarantee which version of the buffer the callback function will receive.Windows Vista:  The address of the callback function must be within the address range of a loaded module. Therefore, the callback function cannot be code that is generated at run time (such as managed code generated by the JIT compiler) or native code that is decompressed at run time. This restriction was removed in Windows Server 2008 and Windows Vista with SP1.If the function succeeds, the return value is ERROR_SUCCESS. If the service has been marked for deletion, the return value is ERROR_SERVICE_MARKED_FOR_DELETE and the handle to the service must be closed. If service notification is lagging too far behind the system state, the function returns ERROR_SERVICE_NOTIFY_CLIENT_LAGGING. In this case, the client should close the handle to the SCM, open a new handle, and call this function again.If the function fails, the return value is one of the system error codes.The NotifyServiceStatusChange function can be used to receive notifications about service applications. It cannot be used to receive notifications about driver services.When the service status changes, the system invokes the specified callback function as an asynchronous procedure call (APC) queued to the calling thread. The calling thread must enter an alertable wait (for example, by calling the SleepEx function) to receive notification. For more information, see Asynchronous Procedure Calls.If the service is already in any of the requested states when NotifyServiceStatusChange is called, the callback function is queued immediately. If the service state has not changed by the next time the function is called with the same service and state, the callback function is not queued immediately; the callback function is queued the next time the service enters the requested state.The NotifyServiceStatusChange function calls the OpenThread function on the calling thread with the THREAD_SET_CONTEXT access right. If the calling thread does not have this access right, NotifyServiceStatusChange fails. If the calling thread is impersonating another user, it may not have sufficient permission to set context.It is more efficient to call NotifyServiceStatusChange from a thread that performs a wait than to create an additional thread.After the callback function is invoked, the caller must call NotifyServiceStatusChange to receive additional notifications. Note that certain functions in the Windows API, including NotifyServiceStatusChange and other SCM functions, use remote procedure calls (RPC); these functions might perform an alertable wait operation, so they are not safe to call from within the callback function. Instead, the callback function should save the notification parameters and perform any additional work outside the callback.To cancel outstanding notifications, close the service handle using the CloseServiceHandle function. After CloseServiceHandle succeeds, no more notification APCs will be queued. If the calling thread exits without closing the service handle or waiting until the APC is generated, a memory leak can occur.SERVICE_NOTIFYSubscribeServiceChangeNotificationsService Functions</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint NotifyServiceStatusChangeW(nint hService, uint dwNotifyMask, SERVICE_NOTIFY_2W pNotifyBuffer);

        /// <summary>
        ///Establishes a connection to the service control manager on the specified computer and opens the specified service control manager database.
        /// </summary>
        /// <param name="lpMachineName"></param>
        /// <param name="lpDatabaseName"></param>
        /// <param name="dwDesiredAccess">The access to the service control manager. For a list of access rights, see Service Security and Access Rights.Before granting the requested access rights, the system checks the access token of the calling process against the discretionary access-control list of the security descriptor associated with the service control manager.The SC_MANAGER_CONNECT access right is implicitly specified by calling this function.If the function succeeds, the return value is a handle to the specified service control manager database.If the function fails, the return value is NULL. To get extended error information, call GetLastError.The following error codes can be set by the SCM. Other error codes can be set by the registry functions that are called by the SCM.When a process uses the OpenSCManager function to open a handle to a service control manager database, the system performs a security check before granting the requested access. For more information, see Service Security and Access Rights.If the current user does not have proper access when connecting to a service on another computer, the OpenSCManager function call fails. To connect to a service remotely, call the LogonUser function with LOGON32_LOGON_NEW_CREDENTIALS and then call ImpersonateLoggedOnUser before calling OpenSCManager. For more information about connecting to services remotely, see Services and RPC/TCP.Only processes with Administrator privileges are able to open a database handle that can be used by the CreateService function.The returned handle is only valid for the process that called the OpenSCManager function. It can be closed by calling the CloseServiceHandle function.For an example, see Changing a Service's Configuration.CloseServiceHandleCreateServiceEnumServicesStatusExOpenServiceSCM HandlesService Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint OpenSCManagerA(string lpMachineName, string lpDatabaseName, uint dwDesiredAccess);

        /// <summary>
        ///Establishes a connection to the service control manager on the specified computer and opens the specified service control manager database.
        /// </summary>
        /// <param name="lpMachineName"></param>
        /// <param name="lpDatabaseName"></param>
        /// <param name="dwDesiredAccess">The access to the service control manager. For a list of access rights, see Service Security and Access Rights.Before granting the requested access rights, the system checks the access token of the calling process against the discretionary access-control list of the security descriptor associated with the service control manager.The SC_MANAGER_CONNECT access right is implicitly specified by calling this function.If the function succeeds, the return value is a handle to the specified service control manager database.If the function fails, the return value is NULL. To get extended error information, call GetLastError.The following error codes can be set by the SCM. Other error codes can be set by the registry functions that are called by the SCM.When a process uses the OpenSCManager function to open a handle to a service control manager database, the system performs a security check before granting the requested access. For more information, see Service Security and Access Rights.If the current user does not have proper access when connecting to a service on another computer, the OpenSCManager function call fails. To connect to a service remotely, call the LogonUser function with LOGON32_LOGON_NEW_CREDENTIALS and then call ImpersonateLoggedOnUser before calling OpenSCManager. For more information about connecting to services remotely, see Services and RPC/TCP.Only processes with Administrator privileges are able to open a database handle that can be used by the CreateService function.The returned handle is only valid for the process that called the OpenSCManager function. It can be closed by calling the CloseServiceHandle function.For an example, see Changing a Service's Configuration.CloseServiceHandleCreateServiceEnumServicesStatusExOpenServiceSCM HandlesService Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint OpenSCManagerW(string lpMachineName, string lpDatabaseName, uint dwDesiredAccess);

        /// <summary>
        ///Opens an existing service.
        /// </summary>
        /// <param name="hSCManager">A handle to the service control manager database. The OpenSCManager function returns this handle. For more information, see Service Security and Access Rights.</param>
        /// <param name="lpServiceName">The name of the service to be opened. This is the name specified by the lpServiceName parameter of the CreateService function when the service object was created, not the service display name that is shown by user interface applications to identify the service.The maximum string length is 256 characters. The service control manager database preserves the case of the characters, but service name comparisons are always case insensitive. Forward-slash (/) and backslash (\) are invalid service name characters.</param>
        /// <param name="dwDesiredAccess">The access to the service. For a list of access rights, see Service Security and Access Rights.Before granting the requested access, the system checks the access token of the calling process against the discretionary access-control list of the security descriptor associated with the service object.If the function succeeds, the return value is a handle to the service.If the function fails, the return value is NULL. To get extended error information, call GetLastError.The following error codes can be set by the service control manager. Others can be set by the registry functions that are called by the service control manager.The returned handle is only valid for the process that called OpenService. It can be closed by calling the CloseServiceHandle function.To use OpenService, no privileges are required aside from SC_MANAGER_CONNECT.For an example, see Starting a Service.ChangeServiceConfigCloseServiceHandleControlServiceCreateServiceDeleteServiceEnumDependentServicesOpenSCManagerQueryServiceConfigQueryServiceDynamicInformationQueryServiceObjectSecurityQueryServiceStatusExSCM HandlesService FunctionsSetServiceObjectSecurityStartService</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint OpenServiceA(nint hSCManager, string lpServiceName, uint dwDesiredAccess);

        /// <summary>
        ///Opens an existing service.
        /// </summary>
        /// <param name="hSCManager">A handle to the service control manager database. The OpenSCManager function returns this handle. For more information, see Service Security and Access Rights.</param>
        /// <param name="lpServiceName">The name of the service to be opened. This is the name specified by the lpServiceName parameter of the CreateService function when the service object was created, not the service display name that is shown by user interface applications to identify the service.The maximum string length is 256 characters. The service control manager database preserves the case of the characters, but service name comparisons are always case insensitive. Forward-slash (/) and backslash (\) are invalid service name characters.</param>
        /// <param name="dwDesiredAccess">The access to the service. For a list of access rights, see Service Security and Access Rights.Before granting the requested access, the system checks the access token of the calling process against the discretionary access-control list of the security descriptor associated with the service object.If the function succeeds, the return value is a handle to the service.If the function fails, the return value is NULL. To get extended error information, call GetLastError.The following error codes can be set by the service control manager. Others can be set by the registry functions that are called by the service control manager.The returned handle is only valid for the process that called OpenService. It can be closed by calling the CloseServiceHandle function.To use OpenService, no privileges are required aside from SC_MANAGER_CONNECT.For an example, see Starting a Service.ChangeServiceConfigCloseServiceHandleControlServiceCreateServiceDeleteServiceEnumDependentServicesOpenSCManagerQueryServiceConfigQueryServiceDynamicInformationQueryServiceObjectSecurityQueryServiceStatusExSCM HandlesService FunctionsSetServiceObjectSecurityStartService</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint OpenServiceW(nint hSCManager, string lpServiceName, uint dwDesiredAccess);

        /// <summary>
        ///Retrieves the optional configuration parameters of the specified service.
        /// </summary>
        /// <param name="hService">A handle to the service. This handle is returned by the OpenService or CreateService function and must have the SERVICE_QUERY_CONFIG access right. For more information, see Service Security and Access Rights.</param>
        /// <param name="dwInfoLevel">The configuration information to be queried. This parameter can be one of the following values.</param>
        /// <param name="lpBuffer"></param>
        /// <param name="cbBufSize">The size of the structure pointed to by the lpBuffer parameter, in bytes.</param>
        /// <param name="pcbBytesNeeded"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool QueryServiceConfig2A(nint hService, uint dwInfoLevel, out byte lpBuffer, uint cbBufSize, out uint pcbBytesNeeded);

        /// <summary>
        ///Retrieves the optional configuration parameters of the specified service.
        /// </summary>
        /// <param name="hService">A handle to the service. This handle is returned by the OpenService or CreateService function and must have the SERVICE_QUERY_CONFIG access right. For more information, see Service Security and Access Rights.</param>
        /// <param name="dwInfoLevel">The configuration information to be queried. This parameter can be one of the following values.</param>
        /// <param name="lpBuffer"></param>
        /// <param name="cbBufSize">The size of the structure pointed to by the lpBuffer parameter, in bytes.</param>
        /// <param name="pcbBytesNeeded"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool QueryServiceConfig2W(nint hService, uint dwInfoLevel, out byte lpBuffer, uint cbBufSize, out uint pcbBytesNeeded);

        /// <summary>
        ///Retrieves the configuration parameters of the specified service. Optional configuration parameters are available using the QueryServiceConfig2 function.
        /// </summary>
        /// <param name="hService">A handle to the service. This handle is returned by the OpenService or CreateService function, and it must have the SERVICE_QUERY_CONFIG access right. For more information, see Service Security and Access Rights.</param>
        /// <param name="lpServiceConfig"></param>
        /// <param name="cbBufSize">The size of the buffer pointed to by the lpServiceConfig parameter, in bytes.</param>
        /// <param name="pcbBytesNeeded"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool QueryServiceConfigA(nint hService, out QUERY_SERVICE_CONFIGA lpServiceConfig, uint cbBufSize, out uint pcbBytesNeeded);

        /// <summary>
        ///Retrieves the configuration parameters of the specified service. Optional configuration parameters are available using the QueryServiceConfig2 function.
        /// </summary>
        /// <param name="hService">A handle to the service. This handle is returned by the OpenService or CreateService function, and it must have the SERVICE_QUERY_CONFIG access right. For more information, see Service Security and Access Rights.</param>
        /// <param name="lpServiceConfig"></param>
        /// <param name="cbBufSize">The size of the buffer pointed to by the lpServiceConfig parameter, in bytes.</param>
        /// <param name="pcbBytesNeeded"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool QueryServiceConfigW(nint hService, out QUERY_SERVICE_CONFIGW lpServiceConfig, uint cbBufSize, out uint pcbBytesNeeded);

        /// <summary>
        ///Retrieves dynamic information related to the current service start.
        /// </summary>
        /// <param name="hServiceStatus">A service status handle provided by RegisterServiceCtrlHandlerEx</param>
        /// <param name="dwInfoLevel">Indicates the information level.ppDynamicInfoA dynamic information buffer. If this parameter is valid, the callback function must free the buffer after use with the LocalFree function.If the function succeeds, the return value is TRUE.If the function fails, the return value is FALSE. When this happens the GetLastError function should be called to retrieve the error code.ChangeServiceConfigChangeServiceConfig2CreateServiceOpenServiceQueryServiceConfigQueryServiceConfig2QueryServiceObjectSecurityService ConfigurationService Functions</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool QueryServiceDynamicInformation(SERVICE_STATUS hServiceStatus, uint dwInfoLevel);

        /// <summary>
        ///[This function has no effect as of Windows Vista.]
        /// </summary>
        /// <param name="hSCManager">A handle to the service control manager database. The OpenSCManager function returns this handle, which must have the SC_MANAGER_QUERY_LOCK_STATUS access right. For more information, see Service Security and Access Rights.</param>
        /// <param name="lpLockStatus"></param>
        /// <param name="cbBufSize">The size of the buffer pointed to by the lpLockStatus parameter, in bytes.</param>
        /// <param name="pcbBytesNeeded"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool QueryServiceLockStatusA(nint hSCManager, out QUERY_SERVICE_LOCK_STATUSA lpLockStatus, uint cbBufSize, out uint pcbBytesNeeded);

        /// <summary>
        ///[This function has no effect as of Windows Vista.]
        /// </summary>
        /// <param name="hSCManager">A handle to the service control manager database. The OpenSCManager function returns this handle, which must have the SC_MANAGER_QUERY_LOCK_STATUS access right. For more information, see Service Security and Access Rights.</param>
        /// <param name="lpLockStatus"></param>
        /// <param name="cbBufSize">The size of the buffer pointed to by the lpLockStatus parameter, in bytes.</param>
        /// <param name="pcbBytesNeeded"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool QueryServiceLockStatusW(nint hSCManager, out QUERY_SERVICE_LOCK_STATUSW lpLockStatus, uint cbBufSize, out uint pcbBytesNeeded);

        /// <summary>
        ///The QueryServiceObjectSecurity function retrieves a copy of the security descriptor associated with a service object. You can also use the GetNamedSecurityInfo function to retrieve a security descriptor.
        /// </summary>
        /// <param name="hService">A handle to the service control manager or the service. Handles to the service control manager are returned by the OpenSCManager function, and handles to a service are returned by either the OpenService or CreateService function. The handle must have the READ_CONTROL access right.</param>
        /// <param name="dwSecurityInformation">A set of bit flags that indicate the type of security information to retrieve. This parameter can be a combination of the SECURITY_INFORMATION bit flags, with the exception that this function does not support the LABEL_SECURITY_INFORMATION value.</param>
        /// <param name="lpSecurityDescriptor"></param>
        /// <param name="cbBufSize">The size of the buffer pointed to by the lpSecurityDescriptor parameter, in bytes. The largest size allowed is 8 kilobytes.</param>
        /// <param name="pcbBytesNeeded"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool QueryServiceObjectSecurity(nint hService, ACL_SIZE_INFORMATION dwSecurityInformation, out SECURITY_DESCRIPTOR lpSecurityDescriptor, uint cbBufSize, out uint pcbBytesNeeded);

        /// <summary>
        ///Retrieves the current status of the specified service.
        /// </summary>
        /// <param name="hService">A handle to the service. This handle is returned by the OpenService or the CreateService function, and it must have the SERVICE_QUERY_STATUS access right. For more information, see Service Security and Access Rights.</param>
        /// <param name="lpServiceStatus"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool QueryServiceStatus(nint hService, out SERVICE_STATUS lpServiceStatus);

        /// <summary>
        ///Retrieves the current status of the specified service based on the specified information level.
        /// </summary>
        /// <param name="hService">A handle to the service. This handle is returned by the CreateService or OpenService function, and it must have the SERVICE_QUERY_STATUS access right. For more information, see Service Security and Access Rights.</param>
        /// <param name="InfoLevel">The service attributes to be returned. Use SC_STATUS_PROCESS_INFO to retrieve the service status information. The lpBuffer parameter is a pointer to a SERVICE_STATUS_PROCESS structure.Currently, no other information levels are defined.</param>
        /// <param name="lpBuffer"></param>
        /// <param name="cbBufSize">The size of the buffer pointed to by the lpBuffer parameter, in bytes.</param>
        /// <param name="pcbBytesNeeded"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError. The following errors can be returned.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool QueryServiceStatusEx(nint hService, _TOKEN_TYPE InfoLevel, out byte lpBuffer, uint cbBufSize, out uint pcbBytesNeeded);

        /// <summary>
        ///Registers a function to handle service control requests.
        /// </summary>
        /// <param name="lpServiceName">The name of the service run by the calling thread. This is the service name that the service control program specified in the CreateService function when creating the service.If the service type is SERVICE_WIN32_OWN_PROCESS, the function does not verify that the specified name is valid, because there is only one registered service in the process.</param>
        /// <param name="lpHandlerProc">A pointer to the handler function to be registered. For more information, see Handler.If the function succeeds, the return value is a service status handle.If the function fails, the return value is zero. To get extended error information, call GetLastError.The following error codes can be set by the service control manager.The ServiceMain function of a new service should immediately call the RegisterServiceCtrlHandler function to register a control handler function with the control dispatcher. This enables the control dispatcher to invoke the specified function when it receives control requests for this service. For a list of possible control codes, see Handler. The threads of the calling process can use the service status handle returned by this function to identify the service in subsequent calls to the SetServiceStatus function.The RegisterServiceCtrlHandler function must be called before the first SetServiceStatus call because RegisterServiceCtrlHandler returns a service status handle for the caller to use so that no other service can inadvertently set this service status. In addition, the control handler must be in place to receive control requests by the time the service specifies the controls it accepts through the SetServiceStatus function.When the control handler function is invoked with a control request, the service must call SetServiceStatus to report status to the service control manager only if the service status has changed, such as when the service is processing stop or shutdown controls. If the service status has not changed, the service should not report status to the service control manager.The service status handle does not have to be closed.For an example, see Writing a ServiceMain Function.CreateServiceHandlerRegisterServiceCtrlHandlerExService Control Handler FunctionService FunctionsServiceMainSetServiceStatus</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern SERVICE_STATUS RegisterServiceCtrlHandlerA(string lpServiceName, LPHANDLERFUNCTION lpHandlerProc);

        /// <summary>
        ///Registers a function to handle extended service control requests.
        /// </summary>
        /// <param name="lpServiceName">The name of the service run by the calling thread. This is the service name that the service control program specified in the CreateService function when creating the service.</param>
        /// <param name="lpHandlerProc">A pointer to the handler function to be registered. For more information, see HandlerEx.</param>
        /// <param name="lpContext"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern SERVICE_STATUS RegisterServiceCtrlHandlerExA(string lpServiceName, LPHANDLERFUNCTIONEX lpHandlerProc, nint lpContext);

        /// <summary>
        ///Registers a function to handle extended service control requests.
        /// </summary>
        /// <param name="lpServiceName">The name of the service run by the calling thread. This is the service name that the service control program specified in the CreateService function when creating the service.</param>
        /// <param name="lpHandlerProc">A pointer to the handler function to be registered. For more information, see HandlerEx.</param>
        /// <param name="lpContext"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern SERVICE_STATUS RegisterServiceCtrlHandlerExW(string lpServiceName, LPHANDLERFUNCTIONEX lpHandlerProc, nint lpContext);

        /// <summary>
        ///Registers a function to handle service control requests.
        /// </summary>
        /// <param name="lpServiceName">The name of the service run by the calling thread. This is the service name that the service control program specified in the CreateService function when creating the service.If the service type is SERVICE_WIN32_OWN_PROCESS, the function does not verify that the specified name is valid, because there is only one registered service in the process.</param>
        /// <param name="lpHandlerProc">A pointer to the handler function to be registered. For more information, see Handler.If the function succeeds, the return value is a service status handle.If the function fails, the return value is zero. To get extended error information, call GetLastError.The following error codes can be set by the service control manager.The ServiceMain function of a new service should immediately call the RegisterServiceCtrlHandler function to register a control handler function with the control dispatcher. This enables the control dispatcher to invoke the specified function when it receives control requests for this service. For a list of possible control codes, see Handler. The threads of the calling process can use the service status handle returned by this function to identify the service in subsequent calls to the SetServiceStatus function.The RegisterServiceCtrlHandler function must be called before the first SetServiceStatus call because RegisterServiceCtrlHandler returns a service status handle for the caller to use so that no other service can inadvertently set this service status. In addition, the control handler must be in place to receive control requests by the time the service specifies the controls it accepts through the SetServiceStatus function.When the control handler function is invoked with a control request, the service must call SetServiceStatus to report status to the service control manager only if the service status has changed, such as when the service is processing stop or shutdown controls. If the service status has not changed, the service should not report status to the service control manager.The service status handle does not have to be closed.For an example, see Writing a ServiceMain Function.CreateServiceHandlerRegisterServiceCtrlHandlerExService Control Handler FunctionService FunctionsServiceMainSetServiceStatus</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern SERVICE_STATUS RegisterServiceCtrlHandlerW(string lpServiceName, LPHANDLERFUNCTION lpHandlerProc);

        /// <summary>
        ///[SetServiceObjectSecurity is available for use in the operating systems specified in the Requirements section. It may be altered or unavailable in subsequent versions. Instead, use the SetNamedSecurityInfo function.]
        /// </summary>
        /// <param name="hService">A handle to the service. This handle is returned by the OpenService or CreateService function. The access required for this handle depends on the security information specified in the dwSecurityInformation parameter.</param>
        /// <param name="dwSecurityInformation">Specifies the components of the security descriptor to set. This parameter can be a combination of the following values. Note that flags not handled by SetServiceObjectSecurity will be silently ignored.</param>
        /// <param name="lpSecurityDescriptor">A pointer to a SECURITY_DESCRIPTOR structure that contains the new security information.If the function succeeds, the function returns nonzero.If the function fails, it returns zero. To get extended error information, call GetLastError.The following error codes can be set by the service control manager. Other error codes can be set by the registry functions that are called by the service control manager.The SetServiceObjectSecurity function sets the specified portions of the security descriptor of the service object based on the information specified in the lpSecurityDescriptor buffer. This function replaces any or all of the security information associated with the service object, according to the flags set in the dwSecurityInformation parameter and subject to the access rights of the calling process.When a service is created, the service control manager assigns a default security descriptor to the service object. To retrieve a copy of the security descriptor for a service object, call the QueryServiceObjectSecurity function. For a description of the default security descriptor for a service object, see Service Security and Access Rights.Note that granting certain access to untrusted users (such as SERVICE_CHANGE_CONFIG or SERVICE_STOP) can allow them to interfere with the execution of your service and possibly allow them to run applications under the LocalSystem account.CreateServiceLow-level Access ControlLow-level Access Control FunctionsOpenServiceQueryServiceObjectSecuritySECURITY_DESCRIPTOR</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetServiceObjectSecurity(nint hService, ACL_SIZE_INFORMATION dwSecurityInformation, SECURITY_DESCRIPTOR lpSecurityDescriptor);

        /// <summary>
        ///Updates the service control manager's status information for the calling service.
        /// </summary>
        /// <param name="hServiceStatus">A handle to the status information structure for the current service. This handle is returned by the RegisterServiceCtrlHandlerEx function.</param>
        /// <param name="lpServiceStatus">A pointer to the SERVICE_STATUS structure the contains the latest status information for the calling service.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The following error codes can be set by the service control manager. Other error codes can be set by the registry functions that are called by the service control manager.A ServiceMain function first calls the RegisterServiceCtrlHandlerEx function to get the service's SERVICE_STATUS_HANDLE. Then it immediately calls the SetServiceStatus function to notify the service control manager that its status is SERVICE_START_PENDING. During initialization, the service can provide updated status to indicate that it is making progress but it needs more time. A common bug is for the service to have the main thread perform the initialization while a separate thread continues to call SetServiceStatus to prevent the service control manager from marking it as hung. However, if the main thread hangs, then the service start ends up in an infinite loop because the worker thread continues to report that the main thread is making progress.After processing a control request, the service's Handler function must call SetServiceStatus if the service status changes to report its new status to the service control manager. It is only necessary to do so when the service is changing state, such as when it is processing stop or shutdown controls. A service can also use this function at any time from any thread of the service to notify the service control manager of state changes, such as when the service must stop due to a recoverable error.A service can call this function only after it has called RegisterServiceCtrlHandlerEx to get a service status handle.If a service calls SetServiceStatus with the dwCurrentState member set to SERVICE_STOPPED and the dwWin32ExitCode member set to a nonzero value, the following entry is written into the System event log:The following are best practices when calling this function:For an example, see Writing a ServiceMain Function.HandlerExRegisterServiceCtrlHandlerExSERVICE_STATUSService FunctionsServiceMainSetServiceBits</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetServiceStatus(SERVICE_STATUS hServiceStatus, SERVICE_STATUS lpServiceStatus);

        /// <summary>
        ///Starts a service.
        /// </summary>
        /// <param name="hService">A handle to the service. This handle is returned by the OpenService or CreateService function, and it must have the SERVICE_START access right. For more information, see Service Security and Access Rights.</param>
        /// <param name="dwNumServiceArgs">The number of strings in the lpServiceArgVectors array. If lpServiceArgVectors is NULL, this parameter can be zero.</param>
        /// <param name="lpServiceArgVectors"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool StartServiceA(nint hService, uint dwNumServiceArgs, string lpServiceArgVectors);

        /// <summary>
        ///Connects the main thread of a service process to the service control manager, which causes the thread to be the service control dispatcher thread for the calling process.
        /// </summary>
        /// <param name="lpServiceStartTable">A pointer to an array of SERVICE_TABLE_ENTRY structures containing one entry for each service that can execute in the calling process. The members of the last entry in the table must have NULL values to designate the end of the table.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The following error code can be set by the service control manager. Other error codes can be set by the registry functions that are called by the service control manager.When the service control manager starts a service process, it waits for the process to call the StartServiceCtrlDispatcher function. The main thread of a service process should make this call as soon as possible after it starts up (within 30 seconds). If StartServiceCtrlDispatcher succeeds, it connects the calling thread to the service control manager and does not return until all running services in the process have entered the SERVICE_STOPPED state. The service control manager uses this connection to send control and service start requests to the main thread of the service process. The main thread acts as a dispatcher by invoking the appropriate HandlerEx function to handle control requests, or by creating a new thread to execute the appropriate ServiceMain function when a new service is started.The lpServiceTable parameter contains an entry for each service that can run in the calling process. Each entry specifies the ServiceMain function for that service. For SERVICE_WIN32_SHARE_PROCESS services, each entry must contain the name of a service. This name is the service name that was specified by the CreateService function when the service was installed. For SERVICE_WIN32_OWN_PROCESS services, the service name in the table entry is ignored.If a service runs in its own process, the main thread of the service process should immediately call StartServiceCtrlDispatcher. All initialization tasks are done in the service's ServiceMain function when the service is started.If multiple services share a process and some common process-wide initialization needs to be done before any ServiceMain function is called, the main thread can do the work before calling StartServiceCtrlDispatcher, as long as it takes less than 30 seconds. Otherwise, another thread must be created to do the process-wide initialization, while the main thread calls StartServiceCtrlDispatcher and becomes the service control dispatcher. Any service-specific initialization should still be done in the individual service main functions.Services should not attempt to display a user interface directly. For more information, see Interactive Services.For an example, see Writing a Service Program's Main Function.ControlServiceHandlerExSERVICE_TABLE_ENTRYService Entry PointService FunctionsServiceMain</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool StartServiceCtrlDispatcherA(SERVICE_TABLE_ENTRYA lpServiceStartTable);

        /// <summary>
        ///Connects the main thread of a service process to the service control manager, which causes the thread to be the service control dispatcher thread for the calling process.
        /// </summary>
        /// <param name="lpServiceStartTable">A pointer to an array of SERVICE_TABLE_ENTRY structures containing one entry for each service that can execute in the calling process. The members of the last entry in the table must have NULL values to designate the end of the table.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The following error code can be set by the service control manager. Other error codes can be set by the registry functions that are called by the service control manager.When the service control manager starts a service process, it waits for the process to call the StartServiceCtrlDispatcher function. The main thread of a service process should make this call as soon as possible after it starts up (within 30 seconds). If StartServiceCtrlDispatcher succeeds, it connects the calling thread to the service control manager and does not return until all running services in the process have entered the SERVICE_STOPPED state. The service control manager uses this connection to send control and service start requests to the main thread of the service process. The main thread acts as a dispatcher by invoking the appropriate HandlerEx function to handle control requests, or by creating a new thread to execute the appropriate ServiceMain function when a new service is started.The lpServiceTable parameter contains an entry for each service that can run in the calling process. Each entry specifies the ServiceMain function for that service. For SERVICE_WIN32_SHARE_PROCESS services, each entry must contain the name of a service. This name is the service name that was specified by the CreateService function when the service was installed. For SERVICE_WIN32_OWN_PROCESS services, the service name in the table entry is ignored.If a service runs in its own process, the main thread of the service process should immediately call StartServiceCtrlDispatcher. All initialization tasks are done in the service's ServiceMain function when the service is started.If multiple services share a process and some common process-wide initialization needs to be done before any ServiceMain function is called, the main thread can do the work before calling StartServiceCtrlDispatcher, as long as it takes less than 30 seconds. Otherwise, another thread must be created to do the process-wide initialization, while the main thread calls StartServiceCtrlDispatcher and becomes the service control dispatcher. Any service-specific initialization should still be done in the individual service main functions.Services should not attempt to display a user interface directly. For more information, see Interactive Services.For an example, see Writing a Service Program's Main Function.ControlServiceHandlerExSERVICE_TABLE_ENTRYService Entry PointService FunctionsServiceMain</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool StartServiceCtrlDispatcherW(SERVICE_TABLE_ENTRYW lpServiceStartTable);

        /// <summary>
        ///Starts a service.
        /// </summary>
        /// <param name="hService">A handle to the service. This handle is returned by the OpenService or CreateService function, and it must have the SERVICE_START access right. For more information, see Service Security and Access Rights.</param>
        /// <param name="dwNumServiceArgs">The number of strings in the lpServiceArgVectors array. If lpServiceArgVectors is NULL, this parameter can be zero.</param>
        /// <param name="lpServiceArgVectors"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool StartServiceW(nint hService, uint dwNumServiceArgs, string lpServiceArgVectors);

        /// <summary>
        ///[This function has no effect as of Windows Vista.]
        /// </summary>
        /// <param name="ScLock">The lock, which is obtained from a previous call to the LockServiceDatabase function.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The following error codes can be set by the service control manager. Other error codes can be set by the registry functions that are called by the service control manager.LockServiceDatabaseQueryServiceLockStatusService ConfigurationService Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool UnlockServiceDatabase(Block ScLock);


    }
}