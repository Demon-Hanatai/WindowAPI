namespace WindowAPI.Winbase.h
{
    public static class Functions
    {

        /// <summary>
        ///The _lclose function closes the specified file so that it is no longer available for reading or writing. This function is provided for compatibility with 16-bit versions of Windows. Win32-based applications should use the CloseHandle function.
        /// </summary>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr _lclose();

        /// <summary>
        ///[This function is provided for compatibility with 16-bit versions of Windows. New applications should use the CreateFile function.]
        /// </summary>
        /// <remarks>
        /// To get extended error information, use the GetLastError function.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr _lcreat();

        /// <summary>
        ///[This function is provided for compatibility with 16-bit versions of Windows. New applications should use the SetFilePointer function.]
        /// </summary>
        /// <remarks>
        /// To get extended error information, use the GetLastError function.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int _llseek();

        /// <summary>
        ///The _lopen function opens an existing file and sets the file pointer to the beginning of the file. This function is provided for compatibility with 16-bit versions of Windows. Win32-based applications should use the CreateFile function.
        /// </summary>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr _lopen();

        /// <summary>
        ///The _lread function reads data from the specified file. This function is provided for compatibility with 16-bit versions of Windows. Win32-based applications should use the ReadFile function.
        /// </summary>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int _lread();

        /// <summary>
        ///[This function is provided for compatibility with 16-bit versions of Windows. New applications should use the WriteFile function.]
        /// </summary>
        /// <remarks>
        /// To get extended error information, use the GetLastError function.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int _lwrite();

        /// <summary>
        ///The AccessCheckAndAuditAlarm function determines whether a security descriptor grants a specified set of access rights to the client being impersonated by the calling thread. If the security descriptor has a SACL with ACEs that apply to the client, the function generates any necessary audit messages in the security event log.
        /// </summary>
        /// <param name="SubsystemName">A pointer to a null-terminated string specifying the name of the subsystem calling the function. This string appears in any audit message that the function generates.</param>
        /// <param name="ObjectTypeName">A pointer to a null-terminated string specifying the type of object being created or accessed. This string appears in any audit message that the function generates.</param>
        /// <param name="SecurityDescriptor">A pointer to the SECURITY_DESCRIPTOR structure against which access is checked.</param>
        /// <param name="DesiredAccess">Access mask that specifies the access rights to check. This mask must have been mapped by the MapGenericMask function to contain no generic access rights.If this parameter is MAXIMUM_ALLOWED, the function sets the GrantedAccess access mask to indicate the maximum access rights the security descriptor allows the client.</param>
        /// <param name="GenericMapping">A pointer to the GENERIC_MAPPING structure associated with the object for which access is being checked.</param>
        /// <param name="ObjectCreation">Specifies a flag that determines whether the calling application will create a new object when access is granted. A value of TRUE indicates the application will create a new object. A value of FALSE indicates the application will open an existing object.</param>
        /// <param name="GrantedAccess"></param>
        /// <param name="AccessStatus"></param>
        /// <param name="pfGenerateOnClose"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool AccessCheckAndAuditAlarmA(string SubsystemName, string ObjectTypeName, int SecurityDescriptor, uint DesiredAccess, int GenericMapping, bool ObjectCreation, out uint GrantedAccess, out bool AccessStatus, out bool pfGenerateOnClose);

        /// <summary>
        ///The AccessCheckByTypeAndAuditAlarm function determines whether a security descriptor grants a specified set of access rights to the client being impersonated by the calling thread. The function can check the client's access to a hierarchy of objects, such as an object, its property sets, and properties. The function grants or denies access to the hierarchy as a whole. If the security descriptor has a system access control list (SACL) with access control entries (ACEs) that apply to the client, the function generates any necessary audit messages in the security event log.
        /// </summary>
        /// <param name="SubsystemName">A pointer to a null-terminated string that specifies the name of the subsystem calling the function. This string appears in any audit message that the function generates.</param>
        /// <param name="HandleId">A pointer to a unique value that represents the client's handle to the object. If the access is denied, the system ignores this value.</param>
        /// <param name="ObjectTypeName">A pointer to a null-terminated string that specifies the type of object being created or accessed. This string appears in any audit message that the function generates.</param>
        /// <param name="SecurityDescriptor">A pointer to a SECURITY_DESCRIPTOR structure against which access is checked.</param>
        /// <param name="DesiredAccess">An access mask that specifies the access rights to check. This mask must have been mapped by the MapGenericMask function to contain no generic access rights.If this parameter is MAXIMUM_ALLOWED, the function sets the GrantedAccess access mask to indicate the maximum access rights the security descriptor allows the client.</param>
        /// <param name="AuditType">The type of audit to be generated. This can be one of the values from the AUDIT_EVENT_TYPE enumeration type.</param>
        /// <param name="Flags">A flag that controls the function's behavior if the calling process does not have the SE_AUDIT_NAME privilege enabled. If the AUDIT_ALLOW_NO_PRIVILEGE flag is set, the function performs the access check without generating audit messages when the privilege is not enabled. If this parameter is zero, the function fails if the privilege is not enabled.</param>
        /// <param name="ObjectTypeListLength">The number of elements in the ObjectTypeList array.</param>
        /// <param name="GenericMapping">A pointer to the GENERIC_MAPPING structure associated with the object for which access is being checked.</param>
        /// <param name="ObjectCreation">A flag that determines whether the calling application will create a new object when access is granted. A value of TRUE indicates the application will create a new object. A value of FALSE indicates the application will open an existing object.</param>
        /// <param name="GrantedAccess"></param>
        /// <param name="AccessStatus"></param>
        /// <param name="pfGenerateOnClose"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool AccessCheckByTypeAndAuditAlarmA(string SubsystemName, IntPtr HandleId, string ObjectTypeName, int SecurityDescriptor, uint DesiredAccess, int AuditType, uint Flags, uint ObjectTypeListLength, int GenericMapping, bool ObjectCreation, out uint GrantedAccess, out bool AccessStatus, out bool pfGenerateOnClose);

        /// <summary>
        ///The AccessCheckByTypeResultListAndAuditAlarm function determines whether a security descriptor grants a specified set of access rights to the client being impersonated by the calling thread. The function can check access to a hierarchy of objects, such as an object, its property sets, and properties. The function reports the access rights granted or denied to each object type in the hierarchy. If the security descriptor has a system access control list (SACL) with access control entries (ACEs) that apply to the client, the function generates any necessary audit messages in the security event log. Alarms are not currently supported.
        /// </summary>
        /// <param name="SubsystemName">A pointer to a null-terminated string that specifies the name of the subsystem calling the function. This string appears in any audit message that the function generates.</param>
        /// <param name="HandleId">A pointer to a unique value that represents the client's handle to the object. If the access is denied, the system ignores this value.</param>
        /// <param name="ObjectTypeName">A pointer to a null-terminated string that specifies the type of object being created or accessed. This string appears in any audit message that the function generates.</param>
        /// <param name="SecurityDescriptor">A pointer to a SECURITY_DESCRIPTOR structure against which access is checked.</param>
        /// <param name="DesiredAccess">An access mask that specifies the access rights to check. This mask must have been mapped by the MapGenericMask function so that it contains no generic access rights.If this parameter is MAXIMUM_ALLOWED, the function sets the access mask in GrantedAccess to indicate the maximum access rights the security descriptor allows the client.</param>
        /// <param name="AuditType">The type of audit to be generated. This can be one of the values from the AUDIT_EVENT_TYPE enumeration type.</param>
        /// <param name="Flags">A flag that controls the function's behavior if the calling process does not have the SE_AUDIT_NAME privilege enabled. If the AUDIT_ALLOW_NO_PRIVILEGE flag is set, the function performs the access check without generating audit messages when the privilege is not enabled. If this parameter is zero, the function fails if the privilege is not enabled.</param>
        /// <param name="ObjectTypeListLength">The number of elements in the ObjectTypeList array.</param>
        /// <param name="GenericMapping">A pointer to the GENERIC_MAPPING structure associated with the object for which access is being checked.</param>
        /// <param name="ObjectCreation">A flag that determines whether the calling application will create a new object when access is granted. A value of TRUE indicates the application will create a new object. A value of FALSE indicates the application will open an existing object.</param>
        /// <param name="GrantedAccess"></param>
        /// <param name="AccessStatusList"></param>
        /// <param name="pfGenerateOnClose"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool AccessCheckByTypeResultListAndAuditAlarmA(string SubsystemName, IntPtr HandleId, string ObjectTypeName, int SecurityDescriptor, uint DesiredAccess, int AuditType, uint Flags, uint ObjectTypeListLength, int GenericMapping, bool ObjectCreation, out uint GrantedAccess, out uint AccessStatusList, out bool pfGenerateOnClose);

        /// <summary>
        ///The AccessCheckByTypeResultListAndAuditAlarmByHandle function determines whether a security descriptor grants a specified set of access rights to the client that the calling thread is impersonating. The difference between this function and AccessCheckByTypeResultListAndAuditAlarm is that this function allows the calling thread to perform the access check before impersonating the client.
        /// </summary>
        /// <param name="SubsystemName">A pointer to a null-terminated string that specifies the name of the subsystem calling the function. This string appears in any audit message that the function generates.</param>
        /// <param name="HandleId">A pointer to a unique value that represents the client's handle to the object. If the access is denied, the system ignores this value.</param>
        /// <param name="ClientToken">A handle to a token object that represents the client that requested the operation. This handle must be obtained through a communication session layer, such as a local named pipe, to prevent possible security policy violations. The caller must have TOKEN_QUERY access for the specified token.</param>
        /// <param name="ObjectTypeName">A pointer to a null-terminated string that specifies the type of object being created or accessed. This string appears in any audit message that the function generates.</param>
        /// <param name="SecurityDescriptor">A pointer to a SECURITY_DESCRIPTOR structure against which access is checked.</param>
        /// <param name="DesiredAccess">An access mask that specifies the access rights to check. This mask must have been mapped by the MapGenericMask function so that it contains no generic access rights.If this parameter is MAXIMUM_ALLOWED, the function sets the access mask in GrantedAccess to indicate the maximum access rights the security descriptor allows the client.</param>
        /// <param name="AuditType">The type of audit to be generated. This can be one of the values from the AUDIT_EVENT_TYPE enumeration type.</param>
        /// <param name="Flags">A flag that controls the function's behavior if the calling process does not have the SE_AUDIT_NAME privilege enabled. If the AUDIT_ALLOW_NO_PRIVILEGE flag is set, the function performs the access check without generating audit messages when the privilege is not enabled. If this parameter is zero, the function fails if the privilege is not enabled.</param>
        /// <param name="ObjectTypeListLength">The number of elements in the ObjectTypeList array.</param>
        /// <param name="GenericMapping">A pointer to the GENERIC_MAPPING structure associated with the object for which access is being checked.</param>
        /// <param name="ObjectCreation">A flag that determines whether the calling application will create a new object when access is granted. A value of TRUE indicates the application will create a new object. A value of FALSE indicates the application will open an existing object.</param>
        /// <param name="GrantedAccess"></param>
        /// <param name="AccessStatusList"></param>
        /// <param name="pfGenerateOnClose"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool AccessCheckByTypeResultListAndAuditAlarmByHandleA(string SubsystemName, IntPtr HandleId, IntPtr ClientToken, string ObjectTypeName, int SecurityDescriptor, uint DesiredAccess, int AuditType, uint Flags, uint ObjectTypeListLength, int GenericMapping, bool ObjectCreation, out uint GrantedAccess, out uint AccessStatusList, out bool pfGenerateOnClose);

        /// <summary>
        ///The ActivateActCtx function activates the specified activation context. It does this by pushing the specified activation context to the top of the activation stack. The specified activation context is thus associated with the current thread and any appropriate side-by-side API functions.
        /// </summary>
        /// <param name="hActCtx">Handle to an ACTCTX structure that contains information on the activation context that is to be made active.</param>
        /// <param name="lpCookie"></param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ActivateActCtx(IntPtr hActCtx, out int lpCookie);

        /// <summary>
        ///Adds a character string to the local atom table and returns a unique value (an atom) identifying the string.
        /// </summary>
        /// <param name="lpString">Type: LPCTSTRThe null-terminated string to be added. The string can have a maximum size of 255 bytes. Strings differing only in case are considered identical. The case of the first string added is preserved and returned by the GetAtomName function.Alternatively, you can use an integer atom that has been converted using the MAKEINTATOM macro. See the Remarks for more information.Type: ATOMIf the function succeeds, the return value is the newly created atom.If the function fails, the return value is zero. To get extended error information, call GetLastError.The AddAtom function stores no more than one copy of a given string in the atom table. If the string is already in the table, the function returns the existing atom and, in the case of a string atom, increments the string's reference count.If lpString has the form "#1234", AddAtom returns an integer atom whose value is the 16-bit representation of the decimal number specified in the string (0x04D2, in this example). If the decimal value specified is 0x0000 or is greater than or equal to 0xC000, the return value is zero, indicating an error. If lpString was created by the MAKEINTATOM macro, the low-order word must be in the range 0x0001 through 0xBFFF. If the low-order word is not in this range, the function fails.If lpString has any other form, AddAtom returns a string atom.DeleteAtomFindAtomGetAtomNameGlobalAddAtomGlobalDeleteAtomGlobalFindAtomGlobalGetAtomNameMAKEINTATOMReference</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int AddAtomA(string lpString);

        /// <summary>
        ///Adds a character string to the local atom table and returns a unique value (an atom) identifying the string.
        /// </summary>
        /// <param name="lpString">Type: LPCTSTRThe null-terminated string to be added. The string can have a maximum size of 255 bytes. Strings differing only in case are considered identical. The case of the first string added is preserved and returned by the GetAtomName function.Alternatively, you can use an integer atom that has been converted using the MAKEINTATOM macro. See the Remarks for more information.Type: ATOMIf the function succeeds, the return value is the newly created atom.If the function fails, the return value is zero. To get extended error information, call GetLastError.The AddAtom function stores no more than one copy of a given string in the atom table. If the string is already in the table, the function returns the existing atom and, in the case of a string atom, increments the string's reference count.If lpString has the form "#1234", AddAtom returns an integer atom whose value is the 16-bit representation of the decimal number specified in the string (0x04D2, in this example). If the decimal value specified is 0x0000 or is greater than or equal to 0xC000, the return value is zero, indicating an error. If lpString was created by the MAKEINTATOM macro, the low-order word must be in the range 0x0001 through 0xBFFF. If the low-order word is not in this range, the function fails.If lpString has any other form, AddAtom returns a string atom.DeleteAtomFindAtomGetAtomNameGlobalAddAtomGlobalDeleteAtomGlobalFindAtomGlobalGetAtomNameMAKEINTATOMReference</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int AddAtomW(string lpString);

        /// <summary>
        ///The AddConditionalAce function adds a conditional access control entry (ACE) to the specified access control list (ACL). A conditional ACE specifies a logical condition that is evaluated during access checks.
        /// </summary>
        /// <param name="dwAceRevision">Specifies the revision level of the ACL being modified. This value can be ACL_REVISION or ACL_REVISION_DS. Use ACL_REVISION_DS if the ACL contains object-specific ACEs.</param>
        /// <param name="AceFlags">A set of bit flags that control ACE inheritance. The function sets these flags in the AceFlags member of the ACE_HEADER structure of the new ACE. This parameter can be a combination of the following values.</param>
        /// <param name="AceType">The type of the ACE.This can be one of the following values.</param>
        /// <param name="AccessMask">Specifies the mask of access rights to be granted to the specified SID.</param>
        /// <param name="pSid">A pointer to the SID that represents a user, group, or logon account being granted access.</param>
        /// <param name="ConditionStr">A string that specifies the conditional statement to be evaluated for the ACE.</param>
        /// <param name="ReturnLength"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool AddConditionalAce(uint dwAceRevision, uint AceFlags, char AceType, uint AccessMask, int pSid, char ConditionStr, out uint ReturnLength);

        /// <summary>
        ///Adds a new required security identifier (SID) to the specified boundary descriptor.
        /// </summary>
        /// <param name="IntegrityLabel">A pointer to a SID structure that represents the mandatory integrity level for the namespace. Use one of the following RID values to create the SID:SECURITY_MANDATORY_UNTRUSTED_RID SECURITY_MANDATORY_LOW_RID SECURITY_MANDATORY_MEDIUM_RID SECURITY_MANDATORY_SYSTEM_RID SECURITY_MANDATORY_PROTECTED_PROCESS_RID For more information, see Well-Known SIDs.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.A process can create a private namespace only with an integrity level that is equal to or lower than the current integrity level of the process. Therefore, a high integrity-level process can create a high, medium or low integrity-level namespace. A medium integrity-level process can create only a medium or low integrity-level namespace.A process would usually specify a namespace at the same integrity level as the process for protection against squatting attacks by lower integrity-level processes.The security descriptor that the creator places on the namespace determines who can open the namespace. So a low or medium integrity-level process could be given permission to open a high integrity level namespace if the security descriptor of the namespace permits it.To compile an application that uses this function, define _WIN32_WINNT as 0x0601 or later.CreateBoundaryDescriptor</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool AddIntegrityLabelToBoundaryDescriptor(int IntegrityLabel);

        /// <summary>
        ///The AddRefActCtx function increments the reference count of the specified activation context.
        /// </summary>
        /// <param name="hActCtx">Handle to an ACTCTX structure that contains information on the activation context for which the reference count is to be incremented.NoneThis function is provided so that multiple clients can access a single activation context.ACTCTX</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void AddRefActCtx(IntPtr hActCtx);

        /// <summary>
        ///Registers a callback function to be called when a secured memory range is freed or its protections are changed.
        /// </summary>
        /// <param name="pfnCallBack">A pointer to the application-defined SecureMemoryCacheCallback function to register.If the function succeeds, it registers the callback function and returns TRUE.If the function fails, it returns FALSE. To get extended error information, call the GetLastError function.An application that performs I/O directly to a high-performance device typically caches a virtual-to-physical memory mapping for the buffer it uses for the I/O. The device's driver typically secures this memory address range by calling the MmSecureVirtualMemory routine, which prevents the memory range from being freed or its protections changed until the driver unsecures the memory.An application can use AddSecureMemoryCacheCallback to register a callback function that will be called when the memory is freed or its protections are changed, so the application can invalidate its cached memory mapping. For more information, see SecureMemoryCacheCallback.To compile an application that uses this function, define _WIN32_WINNT as 0x0600 or later. For more information, see Using the Windows Headers.RemoveSecureMemoryCacheCallbackSecureMemoryCacheCallback</param>
        /// <remarks>
        /// To get extended error information, call the GetLastError function.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool AddSecureMemoryCacheCallback(IntPtr pfnCallBack);

        /// <summary>
        ///Indicates that the calling application has completed its data recovery.
        /// </summary>
        /// <param name="bSuccess">Specify TRUE to indicate that the data was successfully recovered; otherwise, FALSE.NoneThis should be the last call that you make in your callback because your application terminates as soon as this function is called.ApplicationRecoveryInProgressRegisterApplicationRecoveryCallback</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void ApplicationRecoveryFinished(bool bSuccess);

        /// <summary>
        ///Indicates that the calling application is continuing to recover data.
        /// </summary>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr ApplicationRecoveryInProgress(out bool pbCancelled);

        /// <summary>
        ///Saves the specified event log to a backup file. The function does not clear the event log.
        /// </summary>
        /// <param name="hEventLog">A handle to the open event log. The OpenEventLog function returns this handle.</param>
        /// <param name="lpBackupFileName">The absolute or relative path of the backup file.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The BackupEventLog function fails with the ERROR_PRIVILEGE_NOT_HELD error if the user does not have the SE_BACKUP_NAME privilege.OpenBackupEventLogOpenEventLog</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool BackupEventLogA(IntPtr hEventLog, string lpBackupFileName);

        /// <summary>
        ///Saves the specified event log to a backup file. The function does not clear the event log.
        /// </summary>
        /// <param name="hEventLog">A handle to the open event log. The OpenEventLog function returns this handle.</param>
        /// <param name="lpBackupFileName">The absolute or relative path of the backup file.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The BackupEventLog function fails with the ERROR_PRIVILEGE_NOT_HELD error if the user does not have the SE_BACKUP_NAME privilege.OpenBackupEventLogOpenEventLog</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool BackupEventLogW(IntPtr hEventLog, string lpBackupFileName);

        /// <summary>
        ///The BackupRead function can be used to back up a file or directory, including the security information. The function reads data associated with a specified file or directory into a buffer, which can then be written to the backup medium using the WriteFile function.
        /// </summary>
        /// <param name="hFile">Handle to the file or directory to be backed up. To obtain the handle, call the CreateFile function. The SACLs are not read unless the file handle was created with the ACCESS_SYSTEM_SECURITY access right. For more information, see File security and access rights.The handle must be synchronous (nonoverlapped). This means that the FILE_FLAG_OVERLAPPED flag must not be set when CreateFile is called. This function does not validate that the handle it receives is synchronous, so it does not return an error code for a synchronous handle, but calling it with an asynchronous (overlapped) handle can result in subtle errors that are very difficult to debug.The BackupRead function may fail if CreateFile was called with the flag FILE_FLAG_NO_BUFFERING. In this case, the GetLastError function returns the value ERROR_INVALID_PARAMETER.</param>
        /// <param name="lpBuffer"></param>
        /// <param name="nNumberOfBytesToRead">Length of the buffer, in bytes. The buffer size must be greater than the size of a WIN32_STREAM_ID structure.</param>
        /// <param name="lpNumberOfBytesRead"></param>
        /// <param name="bAbort">Indicates whether you have finished using BackupRead on the handle. While you are backing up the file, specify this parameter as FALSE. Once you are done using BackupRead, you must call BackupRead one more time specifying TRUE for this parameter and passing the appropriate lpContext. lpContext must be passed when bAbort is TRUE; all other parameters are ignored.</param>
        /// <param name="bProcessSecurity">Indicates whether the function will restore the access-control list (ACL) data for the file or directory.If bProcessSecurity is TRUE, the ACL data will be backed up.</param>
        /// <param name="lpContext"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool BackupRead(IntPtr hFile, out int lpBuffer, uint nNumberOfBytesToRead, out uint lpNumberOfBytesRead, bool bAbort, bool bProcessSecurity, out IntPtr lpContext);

        /// <summary>
        ///The BackupSeek function seeks forward in a data stream initially accessed by using the BackupRead or BackupWrite function.
        /// </summary>
        /// <param name="hFile">Handle to the file or directory. This handle is created by using the CreateFile function.The handle must be synchronous (nonoverlapped). This means that the FILE_FLAG_OVERLAPPED flag must not be set when CreateFile is called. This function does not validate that the handle it receives is synchronous, so it does not return an error code for a synchronous handle, but calling it with an asynchronous (overlapped) handle can result in subtle errors that are very difficult to debug.</param>
        /// <param name="dwLowBytesToSeek">Low-order part of the number of bytes to seek.</param>
        /// <param name="dwHighBytesToSeek">High-order part of the number of bytes to seek.</param>
        /// <param name="lpdwLowByteSeeked"></param>
        /// <param name="lpdwHighByteSeeked"></param>
        /// <param name="lpContext">Pointer to an internal data structure used by the function. This structure must be the same structure that was initialized by the BackupRead or BackupWrite function. An application must not touch the contents of this structure.If the function could seek the requested amount, the function returns a nonzero value.If the function could not seek the requested amount, the function returns zero. To get extended error information, call GetLastError.Applications use the BackupSeek function to skip portions of a data stream that cause errors. This function does not seek across stream headers. For example, this function cannot be used to skip the stream name. If an application attempts to seek past the end of a substream, the function fails, the lpdwLowByteSeeked and lpdwHighByteSeeked parameters indicate the actual number of bytes the function seeks, and the file position is placed at the start of the next stream header.BackupReadBackupWriteCreateFile</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool BackupSeek(IntPtr hFile, uint dwLowBytesToSeek, uint dwHighBytesToSeek, out uint lpdwLowByteSeeked, out uint lpdwHighByteSeeked, IntPtr lpContext);

        /// <summary>
        ///The BackupWrite function can be used to restore a file or directory that was backed up using BackupRead. Use the ReadFile function to get a stream of data from the backup medium, then use BackupWrite to write the data to the specified file or directory.
        /// </summary>
        /// <param name="hFile">Handle to the file or directory to be restored. To obtain the handle, call the CreateFile function. The SACLs are not restored unless the file handle was created with the ACCESS_SYSTEM_SECURITY access right. To ensure that the integrity ACEs are restored correctly, the file handle must also have been created with the WRITE_OWNER access right. For more information, see File security and access rights.The handle must be synchronous (nonoverlapped). This means that the FILE_FLAG_OVERLAPPED flag must not be set when CreateFile is called. This function does not validate that the handle it receives is synchronous, so it does not return an error code for a synchronous handle, but calling it with an asynchronous (overlapped) handle can result in subtle errors that are very difficult to debug.The BackupWrite function may fail if CreateFile was called with the flag FILE_FLAG_NO_BUFFERING. In this case, the GetLastError function returns the value ERROR_INVALID_PARAMETER.</param>
        /// <param name="lpBuffer">Pointer to a buffer that the function writes data from.</param>
        /// <param name="nNumberOfBytesToWrite">Size of the buffer, in bytes. The buffer size must be greater than the size of a WIN32_STREAM_ID structure.</param>
        /// <param name="lpNumberOfBytesWritten"></param>
        /// <param name="bAbort">Indicates whether you have finished using BackupWrite on the handle. While you are restoring the file, specify this parameter as FALSE. After you are done using BackupWrite, you must call BackupWrite one more time specifying TRUE for this parameter and passing the appropriate lpContext. lpContext must be passed when bAbort is TRUE; all other parameters are ignored.</param>
        /// <param name="bProcessSecurity">Specifies whether the function will restore the access-control list (ACL) data for the file or directory.If bProcessSecurity is TRUE, you need to specify WRITE_OWNER and WRITE_DAC access when opening the file or directory handle. If the handle does not have those access rights, the operating system denies access to the ACL data, and ACL data restoration will not occur.</param>
        /// <param name="lpContext"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool BackupWrite(IntPtr hFile, int lpBuffer, uint nNumberOfBytesToWrite, out uint lpNumberOfBytesWritten, bool bAbort, bool bProcessSecurity, out IntPtr lpContext);

        /// <summary>
        ///Retrieves a handle that can be used by the UpdateResource function to add, delete, or replace resources in a binary module.
        /// </summary>
        /// <param name="pFileName">Type: LPCTSTRThe binary file in which to update resources. An application must be able to obtain write-access to this file; the file referenced by pFileName cannot be currently executing. If pFileName does not specify a full path, the system searches for the file in the current directory.</param>
        /// <param name="bDeleteExistingResources">Type: BOOLIndicates whether to delete the pFileName parameter's existing resources. If this parameter is TRUE, existing resources are deleted and the updated file includes only resources added with the UpdateResource function. If this parameter is FALSE, the updated file includes existing resources unless they are explicitly deleted or replaced by using UpdateResource.Type: HANDLEIf the function succeeds, the return value is a handle that can be used by the UpdateResource and EndUpdateResource functions. The return value is NULL if the specified file is not a PE, the file does not exist, or the file cannot be opened for writing. To get extended error information, call GetLastError.It is recommended that the resource file is not loaded before this function is called. However, if that file is already loaded, it will not cause an error to be returned.There are some restrictions on resource updates in files that contain Resource Configuration(RC Config) data: LN files and the associated .mui files. Details on which types of resources are allowed to be updated in these files are in the Remarks section for the UpdateResource function.This function can update resources within modules that contain both code and resources. As noted above, there are restrictions on resource updates in LN files and .mui files, both of which contain RC Config data; details of the restrictions are in the reference for the UpdateResource function.For an example see, Updating Resources.ConceptualEndUpdateResourceReferenceResourcesUpdateResource</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr BeginUpdateResourceA(string pFileName, bool bDeleteExistingResources);

        /// <summary>
        ///Retrieves a handle that can be used by the UpdateResource function to add, delete, or replace resources in a binary module.
        /// </summary>
        /// <param name="pFileName">Type: LPCTSTRThe binary file in which to update resources. An application must be able to obtain write-access to this file; the file referenced by pFileName cannot be currently executing. If pFileName does not specify a full path, the system searches for the file in the current directory.</param>
        /// <param name="bDeleteExistingResources">Type: BOOLIndicates whether to delete the pFileName parameter's existing resources. If this parameter is TRUE, existing resources are deleted and the updated file includes only resources added with the UpdateResource function. If this parameter is FALSE, the updated file includes existing resources unless they are explicitly deleted or replaced by using UpdateResource.Type: HANDLEIf the function succeeds, the return value is a handle that can be used by the UpdateResource and EndUpdateResource functions. The return value is NULL if the specified file is not a PE, the file does not exist, or the file cannot be opened for writing. To get extended error information, call GetLastError.It is recommended that the resource file is not loaded before this function is called. However, if that file is already loaded, it will not cause an error to be returned.There are some restrictions on resource updates in files that contain Resource Configuration(RC Config) data: LN files and the associated .mui files. Details on which types of resources are allowed to be updated in these files are in the Remarks section for the UpdateResource function.This function can update resources within modules that contain both code and resources. As noted above, there are restrictions on resource updates in LN files and .mui files, both of which contain RC Config data; details of the restrictions are in the reference for the UpdateResource function.For an example see, Updating Resources.ConceptualEndUpdateResourceReferenceResourcesUpdateResource</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr BeginUpdateResourceW(string pFileName, bool bDeleteExistingResources);

        /// <summary>
        ///Associates the I/O completion port owned by the thread pool with the specified file handle. On completion of an I/O request involving this file, a non-I/O worker thread will execute the specified callback function.
        /// </summary>
        /// <param name="FileHandle">A handle to the file opened for overlapped I/O completion. This handle is returned by the CreateFile function, with the FILE_FLAG_OVERLAPPED flag.</param>
        /// <param name="Function">A pointer to the callback function to be executed in a non-I/O worker thread when the I/O operation is complete. This callback function must not call the TerminateThread function.For more information about the completion routine, see FileIOCompletionRoutine.</param>
        /// <param name="Flags">This parameter must be zero.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call the GetLastError function.The callback function might not be executed if the process issues an asynchronous request on the file specified by the FileHandle parameter but the request returns immediately with an error code other than ERROR_IO_PENDING.Be sure that the thread that initiates the asynchronous I/O request does not terminate before the request is completed. Also, if a function in a DLL is queued to a worker thread, be sure that the function in the DLL has completed execution before the DLL is unloaded.The thread pool maintains an I/O completion port. When you call BindIoCompletionCallback, it associates the specified file with the thread pool's I/O completion port. Asynchronous requests on that file object will complete by posting to the completion port, where they will be picked up by thread pool worker threads. For callbacks that must issue an I/O request that completes as an asynchronous procedure call, the thread pool provides an I/O worker pool. The I/O worker threads do not wait on the completion port; they sleep in an alertable wait state so that I/O request packets that complete can wake them up. Both types of worker threads check whether there is I/O pending on them and if there is, they do not exit. For more information, see Asynchronous Procedure Calls.To compile an application that uses this function, define _WIN32_WINNT as 0x0500 or later. For more information, see Using the Windows Headers.FileIOCompletionRoutineProcess and Thread FunctionsThread Pooling</param>
        /// <remarks>
        /// To get extended error information, call the GetLastError function.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool BindIoCompletionCallback(IntPtr FileHandle, int Function, int Flags);

        /// <summary>
        ///Fills a specified DCB structure with values specified in a device-control string. The device-control string uses the syntax of the mode command.
        /// </summary>
        /// <param name="lpDef">The device-control information. The function takes this string, parses it, and then sets appropriate values in the DCB structure pointed to by lpDCB.The string must have the same form as the mode command's command-line arguments:COMx[:][baud=b][parity=p][data=d][stop=s][to={on|off}][xon={on|off}][odsr={on|off}][octs={on|off}][dtr={on|off|hs}][rts={on|off|hs|tg}][idsr={on|off}]The device name is optional, but it must specify a valid device if used.For example, the following string specifies a baud rate of 1200, no parity, 8 data bits, and 1 stop bit:baud=1200 parity=N data=8 stop=1</param>
        /// <param name="lpDCB"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool BuildCommDCBA(string lpDef, out int lpDCB);

        /// <summary>
        ///Translates a device-definition string into appropriate device-control block codes and places them into a device control block. The function can also set up time-out values, including the possibility of no time-outs, for a device; the function's behavior in this regard depends on the contents of the device-definition string.
        /// </summary>
        /// <param name="lpDef">The device-control information. The function takes this string, parses it, and then sets appropriate values in the DCB structure pointed to by lpDCB.The string must have the same form as the mode command's command-line arguments:COMx[:][baud={11|110|15|150|30|300|60|600|12|1200|24|2400|48|4800|96|9600|19|19200}][parity={n|e|o|m|s}][data={5|6|7|8}][stop={1|1.5|2}][to={on|off}][xon={on|off}][odsr={on|off}][octs={on|off}][dtr={on|off|hs}][rts={on|off|hs|tg}][idsr={on|off}]The "baud" substring can be any of the values listed, which are in pairs. The two-digit values are the first two digits of the associated values that they represent. For example, 11 represents 110 baud, 19 represents 19,200 baud.The "parity" substring indicates how the parity bit is used to detect transmission errors. The values represent "none", "even", "odd", "mark", and "space".For more information, see the Mode command reference in TechNet.For example, the following string specifies a baud rate of 1200, no parity, 8 data bits, and 1 stop bit:baud=1200 parity=N data=8 stop=1</param>
        /// <param name="lpDCB"></param>
        /// <param name="lpCommTimeouts"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool BuildCommDCBAndTimeoutsA(string lpDef, out int lpDCB, out int lpCommTimeouts);

        /// <summary>
        ///Translates a device-definition string into appropriate device-control block codes and places them into a device control block. The function can also set up time-out values, including the possibility of no time-outs, for a device; the function's behavior in this regard depends on the contents of the device-definition string.
        /// </summary>
        /// <param name="lpDef">The device-control information. The function takes this string, parses it, and then sets appropriate values in the DCB structure pointed to by lpDCB.The string must have the same form as the mode command's command-line arguments:COMx[:][baud={11|110|15|150|30|300|60|600|12|1200|24|2400|48|4800|96|9600|19|19200}][parity={n|e|o|m|s}][data={5|6|7|8}][stop={1|1.5|2}][to={on|off}][xon={on|off}][odsr={on|off}][octs={on|off}][dtr={on|off|hs}][rts={on|off|hs|tg}][idsr={on|off}]The "baud" substring can be any of the values listed, which are in pairs. The two-digit values are the first two digits of the associated values that they represent. For example, 11 represents 110 baud, 19 represents 19,200 baud.The "parity" substring indicates how the parity bit is used to detect transmission errors. The values represent "none", "even", "odd", "mark", and "space".For more information, see the Mode command reference in TechNet.For example, the following string specifies a baud rate of 1200, no parity, 8 data bits, and 1 stop bit:baud=1200 parity=N data=8 stop=1</param>
        /// <param name="lpDCB"></param>
        /// <param name="lpCommTimeouts"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool BuildCommDCBAndTimeoutsW(string lpDef, out int lpDCB, out int lpCommTimeouts);

        /// <summary>
        ///Fills a specified DCB structure with values specified in a device-control string. The device-control string uses the syntax of the mode command.
        /// </summary>
        /// <param name="lpDef">The device-control information. The function takes this string, parses it, and then sets appropriate values in the DCB structure pointed to by lpDCB.The string must have the same form as the mode command's command-line arguments:COMx[:][baud=b][parity=p][data=d][stop=s][to={on|off}][xon={on|off}][odsr={on|off}][octs={on|off}][dtr={on|off|hs}][rts={on|off|hs|tg}][idsr={on|off}]The device name is optional, but it must specify a valid device if used.For example, the following string specifies a baud rate of 1200, no parity, 8 data bits, and 1 stop bit:baud=1200 parity=N data=8 stop=1</param>
        /// <param name="lpDCB"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool BuildCommDCBW(string lpDef, out int lpDCB);

        /// <summary>
        ///Connects to a message-type pipe (and waits if an instance of the pipe is not available), writes to and reads from the pipe, and then closes the pipe.
        /// </summary>
        /// <param name="lpNamedPipeName">The pipe name.</param>
        /// <param name="lpInBuffer">The data to be written to the pipe.</param>
        /// <param name="nInBufferSize">The size of the write buffer, in bytes.</param>
        /// <param name="lpOutBuffer"></param>
        /// <param name="nOutBufferSize">The size of the read buffer, in bytes.</param>
        /// <param name="lpBytesRead"></param>
        /// <param name="nTimeOut">The number of milliseconds to wait for the named pipe to be available. In addition to numeric values, the following special values can be specified.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.If the message written to the pipe by the server process is longer than nOutBufferSize, CallNamedPipe returns FALSE, and GetLastError returns ERROR_MORE_DATA. The remainder of the message is discarded, because CallNamedPipe closes the handle to the pipe before returning.Calling CallNamedPipe is equivalent to calling the CreateFile (or WaitNamedPipe, if CreateFile cannot open the pipe immediately), TransactNamedPipe, and CloseHandle functions. CreateFile is called with an access flag of GENERIC_READ | GENERIC_WRITE, and an inherit handle flag of FALSE.CallNamedPipe fails if the pipe is a byte-type pipe.Windows 10, version 1709:  Pipes are only supported within an app-container; ie, from one UWP process to another UWP process that's part of the same app. Also, named pipes must use the syntax \\.\pipe\LOCAL\ for the pipe name.For an example, see Transactions on Named Pipes.CloseHandleCreateFileCreateNamedPipePipe FunctionsPipes OverviewTransactNamedPipeWaitNamedPipe</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CallNamedPipeA(string lpNamedPipeName, IntPtr lpInBuffer, uint nInBufferSize, out IntPtr lpOutBuffer, uint nOutBufferSize, out uint lpBytesRead, uint nTimeOut);

        /// <summary>
        ///Determines whether the specified name can be used to create a file on a FAT file system.
        /// </summary>
        /// <param name="lpName">The file name, in 8.3 format.</param>
        /// <param name="OemNameSize">The size of the lpOemName buffer, in characters. If lpOemName is NULL, this parameter must be 0 (zero).</param>
        /// <param name="pbNameLegal"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CheckNameLegalDOS8Dot3A(string lpName, uint OemNameSize, out bool pbNameLegal);

        /// <summary>
        ///Determines whether the specified name can be used to create a file on a FAT file system.
        /// </summary>
        /// <param name="lpName">The file name, in 8.3 format.</param>
        /// <param name="OemNameSize">The size of the lpOemName buffer, in characters. If lpOemName is NULL, this parameter must be 0 (zero).</param>
        /// <param name="pbNameLegal"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CheckNameLegalDOS8Dot3W(string lpName, uint OemNameSize, out bool pbNameLegal);

        /// <summary>
        ///Restores character transmission for a specified communications device and places the transmission line in a nonbreak state.
        /// </summary>
        /// <param name="hFile">A handle to the communications device. The CreateFile function returns this handle.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.A communications device is placed in a break state by the SetCommBreak or EscapeCommFunction function. Character transmission is then suspended until the break state is cleared by calling ClearCommBreak.ClearCommErrorCommunications FunctionsCommunications ResourcesCreateFileEscapeCommFunctionSetCommBreak</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ClearCommBreak(IntPtr hFile);

        /// <summary>
        ///Retrieves information about a communications error and reports the current status of a communications device. The function is called when a communications error occurs, and it clears the device's error flag to enable additional input and output (I/O) operations.
        /// </summary>
        /// <param name="hFile">A handle to the communications device. The CreateFile function returns this handle.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ClearCommError(IntPtr hFile);

        /// <summary>
        ///Clears the specified event log, and optionally saves the current copy of the log to a backup file.
        /// </summary>
        /// <param name="hEventLog">A handle to the event log to be cleared. The OpenEventLog function returns this handle.</param>
        /// <param name="lpBackupFileName">The absolute or relative path of the backup file. If this file already exists, the function fails.If the lpBackupFileName parameter is NULL, the event log is not backed up.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError. The ClearEventLog function can fail if the event log is empty or the backup file already exists.After this function returns, any handles that reference the cleared event log cannot be used to read the log.Event Logging FunctionsOpenEventLog</param>
        /// <remarks>
        /// To get extended error information, call GetLastError. The ClearEventLog function can fail if the event log is empty or the backup file already exists.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ClearEventLogA(IntPtr hEventLog, string lpBackupFileName);

        /// <summary>
        ///Clears the specified event log, and optionally saves the current copy of the log to a backup file.
        /// </summary>
        /// <param name="hEventLog">A handle to the event log to be cleared. The OpenEventLog function returns this handle.</param>
        /// <param name="lpBackupFileName">The absolute or relative path of the backup file. If this file already exists, the function fails.If the lpBackupFileName parameter is NULL, the event log is not backed up.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError. The ClearEventLog function can fail if the event log is empty or the backup file already exists.After this function returns, any handles that reference the cleared event log cannot be used to read the log.Event Logging FunctionsOpenEventLog</param>
        /// <remarks>
        /// To get extended error information, call GetLastError. The ClearEventLog function can fail if the event log is empty or the backup file already exists.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ClearEventLogW(IntPtr hEventLog, string lpBackupFileName);

        /// <summary>
        ///Closes an encrypted file after a backup or restore operation, and frees associated system resources. This is one of a group of Encrypted File System (EFS) functions that is intended to implement backup and restore functionality, while maintaining files in their encrypted state.
        /// </summary>
        /// <param name="pvContext">A pointer to a system-defined context block. The OpenEncryptedFileRaw function returns the context block.NoneThe CloseEncryptedFileRaw function frees allocated system resources such as the system-defined context block and closes the file.The BackupRead and BackupWrite functions handle backup and restore of unencrypted files.In Windows 8, Windows Server 2012, and later, this function is supported by the following technologies.Note that SMB 3.0 does not support EFS on shares with continuous availability capability.BackupReadBackupWriteFile EncryptionFile Management FunctionsOpenEncryptedFileRawReadEncryptedFileRawWriteEncryptedFileRaw</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void CloseEncryptedFileRaw(IntPtr pvContext);

        /// <summary>
        ///Closes the specified event log.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CloseEventLog();

        /// <summary>
        ///Displays a driver-supplied configuration dialog box.
        /// </summary>
        /// <param name="lpszName">The name of the device for which a dialog box should be displayed. For example, COM1 through COM9 are serial ports and LPT1 through LPT9 are parallel ports.</param>
        /// <param name="hWnd">A handle to the window that owns the dialog box. This parameter can be any valid window handle, or it should be NULL if the dialog box is to have no owner.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CommConfigDialogA(string lpszName, IntPtr hWnd);

        /// <summary>
        ///Displays a driver-supplied configuration dialog box.
        /// </summary>
        /// <param name="lpszName">The name of the device for which a dialog box should be displayed. For example, COM1 through COM9 are serial ports and LPT1 through LPT9 are parallel ports.</param>
        /// <param name="hWnd">A handle to the window that owns the dialog box. This parameter can be any valid window handle, or it should be NULL if the dialog box is to have no owner.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CommConfigDialogW(string lpszName, IntPtr hWnd);

        /// <summary>
        ///Converts the current fiber into a thread.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ConvertFiberToThread();

        /// <summary>
        ///Converts the current thread into a fiber. You must convert a thread into a fiber before you can schedule other fibers.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void ConvertThreadToFiber();

        /// <summary>
        ///Converts the current thread into a fiber. You must convert a thread into a fiber before you can schedule other fibers.
        /// </summary>
        /// <param name="dwFlags">If this parameter is zero, the floating-point state on x86 systems is not switched and data can be corrupted if a fiber uses floating-point arithmetic. If this parameter is FIBER_FLAG_FLOAT_SWITCH, the floating-point state is switched for the fiber.If the function succeeds, the return value is the address of the fiber.If the function fails, the return value is NULL. To get extended error information, call GetLastError.Only fibers can execute other fibers. If a thread needs to execute a fiber, it must call ConvertTheadToFiber or ConvertThreadToFiberEx to create an area in which to save fiber state information. The thread is now the current fiber. The state information for this fiber includes the fiber data specified by lpParameter.To compile an application that uses this function, define _WIN32_WINNT as 0x0400 or later. For more information, see Using the Windows Headers.ConvertFiberToThreadFibersGetFiberDataProcess and Thread Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void ConvertThreadToFiberEx(uint dwFlags);

        /// <summary>
        ///Copies a source context structure (including any XState) onto an initialized destination context structure.
        /// </summary>
        /// <param name="ContextFlags">Flags specifying the pieces of the Source CONTEXT structure that will be copied into the destination. This must be a subset of the ContextFlags specified when calling InitializeContext on the Destination CONTEXT.</param>
        /// <param name="Source">A pointer to a CONTEXT structure from which to copy processor context data.This function returns TRUE if the context was copied successfully, otherwise FALSE. To get extended error information, call GetLastError.The function copies data from the Source CONTEXT over the corresponding data in the Destination CONTEXT, including extended context if any is present. The Destination CONTEXT must have been initialized with InitializeContext to ensure proper alignment and initialization. If any data is present in the Destination CONTEXT and the corresponding flag is not set in the Source CONTEXT or in the ContextFlags parameter, the data remains valid in the Destination.Windows 7 with SP1 and Windows Server 2008 R2 with SP1:  The AVX API is first implemented on Windows 7 with SP1 and Windows Server 2008 R2 with SP1 . Since there is no SDK for SP1, that means there are no available headers and library files to work with. In this situation, a caller must declare the needed functions from this documentation and get pointers to them using GetModuleHandle on "Kernel32.dll", followed by calls to GetProcAddress. See Working with XState Context for details.CONTEXTInitializeContextIntel AVXWorking with XState Context</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CopyContext(uint ContextFlags, int Source);

        /// <summary>
        ///Copies an existing file to a new file.
        /// </summary>
        /// <param name="lpExistingFileName">The name of an existing file.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.If lpExistingFileName does not exist, CopyFile fails, and GetLastError returns ERROR_FILE_NOT_FOUND.</param>
        /// <param name="lpNewFileName">The name of the new file.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="bFailIfExists">If this parameter is TRUE and the new file specified by lpNewFileName already exists, the function fails. If this parameter is FALSE and the new file already exists, the function overwrites the existing file and succeeds.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The security resource properties (ATTRIBUTE_SECURITY_INFORMATION) for the existing file are copied to the new file.Windows 7, Windows Server 2008 R2, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:  Security resource properties for the existing file are not copied to the new file until Windows 8 and Windows Server 2012.File attributes for the existing file are copied to the new file. For example, if an existing file has the FILE_ATTRIBUTE_READONLY file attribute, a copy created through a call to CopyFile will also have the FILE_ATTRIBUTE_READONLY file attribute. For more information, see Retrieving and Changing File Attributes.This function fails with ERROR_ACCESS_DENIED if the destination file already exists and has the FILE_ATTRIBUTE_HIDDEN or FILE_ATTRIBUTE_READONLY attribute set.When CopyFile is used to copy an encrypted file, it attempts to encrypt the destination file with the keys used in the encryption of the source file. If this cannot be done, this function attempts to encrypt the destination file with default keys. If neither of these methods can be done, CopyFile fails with an ERROR_ENCRYPTION_FAILED error code.Symbolic link behavior—If the source file is a symbolic link, the actual file copied is the target of the symbolic link.If the destination file already exists and is a symbolic link, the target of the symbolic link is overwritten by the source file.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.For an example, see Retrieving and Changing File Attributes.CopyFileExCopyFileTransactedCreateFileFile Attribute ConstantsFile Management FunctionsMoveFileSymbolic Links</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CopyFile(string lpExistingFileName, string lpNewFileName, bool bFailIfExists);

        /// <summary>
        ///Copies an existing file to a new file, notifying the application of its progress through a callback function.
        /// </summary>
        /// <param name="pwszExistingFileName">The name of an existing file.To extend this limit to 32,767 wide characters, prepend "\?" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="pwszNewFileName">The name of the new file.To extend this limit to 32,767 wide characters, prepend "\?" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr CopyFile2(string pwszExistingFileName, string pwszNewFileName);

        /// <summary>
        ///Copies an existing file to a new file.
        /// </summary>
        /// <param name="lpExistingFileName">The name of an existing file.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.If lpExistingFileName does not exist, CopyFile fails, and GetLastError returns ERROR_FILE_NOT_FOUND.</param>
        /// <param name="lpNewFileName">The name of the new file.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="bFailIfExists">If this parameter is TRUE and the new file specified by lpNewFileName already exists, the function fails. If this parameter is FALSE and the new file already exists, the function overwrites the existing file and succeeds.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The security resource properties (ATTRIBUTE_SECURITY_INFORMATION) for the existing file are copied to the new file.Windows 7, Windows Server 2008 R2, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:  Security resource properties for the existing file are not copied to the new file until Windows 8 and Windows Server 2012.File attributes for the existing file are copied to the new file. For example, if an existing file has the FILE_ATTRIBUTE_READONLY file attribute, a copy created through a call to CopyFile will also have the FILE_ATTRIBUTE_READONLY file attribute. For more information, see Retrieving and Changing File Attributes.This function fails with ERROR_ACCESS_DENIED if the destination file already exists and has the FILE_ATTRIBUTE_HIDDEN or FILE_ATTRIBUTE_READONLY attribute set.When CopyFile is used to copy an encrypted file, it attempts to encrypt the destination file with the keys used in the encryption of the source file. If this cannot be done, this function attempts to encrypt the destination file with default keys. If neither of these methods can be done, CopyFile fails with an ERROR_ENCRYPTION_FAILED error code.Symbolic link behavior—If the source file is a symbolic link, the actual file copied is the target of the symbolic link.If the destination file already exists and is a symbolic link, the target of the symbolic link is overwritten by the source file.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.For an example, see Retrieving and Changing File Attributes.CopyFileExCopyFileTransactedCreateFileFile Attribute ConstantsFile Management FunctionsMoveFileSymbolic Links</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CopyFileA(string lpExistingFileName, string lpNewFileName, bool bFailIfExists);

        /// <summary>
        ///Copies an existing file to a new file, notifying the application of its progress through a callback function.
        /// </summary>
        /// <param name="lpExistingFileName">The name of an existing file.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.If lpExistingFileName does not exist, the CopyFileEx function fails, and the GetLastError function returns ERROR_FILE_NOT_FOUND.</param>
        /// <param name="lpNewFileName">The name of the new file.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="dwCopyFlags">Flags that specify how the file is to be copied. This parameter can be a combination of the following values.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information call GetLastError.If lpProgressRoutine returns PROGRESS_CANCEL due to the user canceling the operation, CopyFileEx will return zero and GetLastError will return ERROR_REQUEST_ABORTED. In this case, the partially copied destination file is deleted.If lpProgressRoutine returns PROGRESS_STOP due to the user stopping the operation, CopyFileEx will return zero and GetLastError will return ERROR_REQUEST_ABORTED. In this case, the partially copied destination file is left intact.This function preserves extended attributes, OLE structured storage, NTFS file system alternate data streams, security resource attributes, and file attributes.Windows 7, Windows Server 2008 R2, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:  Security resource attributes (ATTRIBUTE_SECURITY_INFORMATION) for the existing file are not copied to the new file until Windows 8 and Windows Server 2012.The security resource properties (ATTRIBUTE_SECURITY_INFORMATION) for the existing file are copied to the new file.Windows 7, Windows Server 2008 R2, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:  Security resource properties for the existing file are not copied to the new file until Windows 8 and Windows Server 2012.This function fails with ERROR_ACCESS_DENIED if the destination file already exists and has the FILE_ATTRIBUTE_HIDDEN or FILE_ATTRIBUTE_READONLY attribute set.When encrypted files are copied using CopyFileEx, the function attempts to encrypt the destination file with the keys used in the encryption of the source file. If this cannot be done, this function attempts to encrypt the destination file with default keys. If both of these methods cannot be done, CopyFileEx fails with an ERROR_ENCRYPTION_FAILED error code. If you want CopyFileEx to complete the copy operation even if the destination file cannot be encrypted, include the COPY_FILE_ALLOW_DECRYPTED_DESTINATION as the value of the dwCopyFlags parameter in your call to CopyFileEx.If COPY_FILE_COPY_SYMLINK is specified, the following rules apply:Windows 7, Windows Server 2008 R2, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:  If you are writing an application that is optimizing file copy operations across a LAN, consider using the TransmitFile function from Windows Sockets (Winsock). TransmitFile supports high-performance network transfers and provides a simple interface to send the contents of a file to a remote computer. To use TransmitFile, you must write a Winsock client application that sends the file from the source computer as well as a Winsock server application that uses other Winsock functions to receive the file on the remote computer.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.CopyFileCopyFileTransactedCopyProgressRoutineCreateFileFile Attribute ConstantsFile Management FunctionsMoveFileMoveFileWithProgressSymbolic LinksTransmitFile</param>
        /// <remarks>
        /// To get extended error information call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CopyFileExA(string lpExistingFileName, string lpNewFileName, uint dwCopyFlags);

        /// <summary>
        ///Copies an existing file to a new file, notifying the application of its progress through a callback function.
        /// </summary>
        /// <param name="lpExistingFileName">The name of an existing file.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.If lpExistingFileName does not exist, the CopyFileEx function fails, and the GetLastError function returns ERROR_FILE_NOT_FOUND.</param>
        /// <param name="lpNewFileName">The name of the new file.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="dwCopyFlags">Flags that specify how the file is to be copied. This parameter can be a combination of the following values.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information call GetLastError.If lpProgressRoutine returns PROGRESS_CANCEL due to the user canceling the operation, CopyFileEx will return zero and GetLastError will return ERROR_REQUEST_ABORTED. In this case, the partially copied destination file is deleted.If lpProgressRoutine returns PROGRESS_STOP due to the user stopping the operation, CopyFileEx will return zero and GetLastError will return ERROR_REQUEST_ABORTED. In this case, the partially copied destination file is left intact.This function preserves extended attributes, OLE structured storage, NTFS file system alternate data streams, security resource attributes, and file attributes.Windows 7, Windows Server 2008 R2, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:  Security resource attributes (ATTRIBUTE_SECURITY_INFORMATION) for the existing file are not copied to the new file until Windows 8 and Windows Server 2012.The security resource properties (ATTRIBUTE_SECURITY_INFORMATION) for the existing file are copied to the new file.Windows 7, Windows Server 2008 R2, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:  Security resource properties for the existing file are not copied to the new file until Windows 8 and Windows Server 2012.This function fails with ERROR_ACCESS_DENIED if the destination file already exists and has the FILE_ATTRIBUTE_HIDDEN or FILE_ATTRIBUTE_READONLY attribute set.When encrypted files are copied using CopyFileEx, the function attempts to encrypt the destination file with the keys used in the encryption of the source file. If this cannot be done, this function attempts to encrypt the destination file with default keys. If both of these methods cannot be done, CopyFileEx fails with an ERROR_ENCRYPTION_FAILED error code. If you want CopyFileEx to complete the copy operation even if the destination file cannot be encrypted, include the COPY_FILE_ALLOW_DECRYPTED_DESTINATION as the value of the dwCopyFlags parameter in your call to CopyFileEx.If COPY_FILE_COPY_SYMLINK is specified, the following rules apply:Windows 7, Windows Server 2008 R2, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:  If you are writing an application that is optimizing file copy operations across a LAN, consider using the TransmitFile function from Windows Sockets (Winsock). TransmitFile supports high-performance network transfers and provides a simple interface to send the contents of a file to a remote computer. To use TransmitFile, you must write a Winsock client application that sends the file from the source computer as well as a Winsock server application that uses other Winsock functions to receive the file on the remote computer.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.CopyFileCopyFileTransactedCopyProgressRoutineCreateFileFile Attribute ConstantsFile Management FunctionsMoveFileMoveFileWithProgressSymbolic LinksTransmitFile</param>
        /// <remarks>
        /// To get extended error information call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CopyFileExW(string lpExistingFileName, string lpNewFileName, uint dwCopyFlags);

        /// <summary>
        ///[Microsoft strongly recommends developers utilize alternative means to achieve your application’s needs. Many scenarios that TxF was developed for can be achieved through simpler and more readily available techniques. Furthermore, TxF may not be available in future versions of Microsoft Windows. For more information, and alternatives to TxF, please see Alternatives to using Transactional NTFS.]
        /// </summary>
        /// <param name="lpExistingFileName">The name of an existing file.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.If lpExistingFileName does not exist, the CopyFileTransacted function fails, and the GetLastError function returns ERROR_FILE_NOT_FOUND.The file must reside on the local computer; otherwise, the function fails and the last error code is set to ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE.</param>
        /// <param name="lpNewFileName">The name of the new file.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="dwCopyFlags">Flags that specify how the file is to be copied. This parameter can be a combination of the following values.</param>
        /// <param name="hTransaction">A handle to the transaction. This handle is returned by the CreateTransaction function.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information call GetLastError.If lpProgressRoutine returns PROGRESS_CANCEL due to the user canceling the operation, CopyFileTransacted will return zero and GetLastError will return ERROR_REQUEST_ABORTED. In this case, the partially copied destination file is deleted.If lpProgressRoutine returns PROGRESS_STOP due to the user stopping the operation, CopyFileTransacted will return zero and GetLastError will return ERROR_REQUEST_ABORTED. In this case, the partially copied destination file is left intact.If you attempt to call this function with a handle to a transaction that has already been rolled back, CopyFileTransacted will return either ERROR_TRANSACTION_NOT_ACTIVE or ERROR_INVALID_TRANSACTION.This function preserves extended attributes, OLE structured storage, NTFS file system alternate data streams, security attributes, and file attributes.Windows 7, Windows Server 2008 R2, Windows Server 2008 and Windows Vista:  Security resource attributes (ATTRIBUTE_SECURITY_INFORMATION) for the existing file are not copied to the new file until Windows 8 and Windows Server 2012.This function fails with ERROR_ACCESS_DENIED if the destination file already exists and has the FILE_ATTRIBUTE_HIDDEN or FILE_ATTRIBUTE_READONLY attribute set.Encrypted files are not supported by TxF.If COPY_FILE_COPY_SYMLINK is specified, the following rules apply:Link tracking is not supported by TxF.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.Note that SMB 3.0 does not support TxF.CopyProgressRoutineCreateFileTransactedFile Attribute ConstantsFile Management FunctionsMoveFileTransactedSymbolic LinksTransactional NTFS</param>
        /// <remarks>
        /// To get extended error information call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CopyFileTransactedA(string lpExistingFileName, string lpNewFileName, uint dwCopyFlags, IntPtr hTransaction);

        /// <summary>
        ///[Microsoft strongly recommends developers utilize alternative means to achieve your application’s needs. Many scenarios that TxF was developed for can be achieved through simpler and more readily available techniques. Furthermore, TxF may not be available in future versions of Microsoft Windows. For more information, and alternatives to TxF, please see Alternatives to using Transactional NTFS.]
        /// </summary>
        /// <param name="lpExistingFileName">The name of an existing file.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.If lpExistingFileName does not exist, the CopyFileTransacted function fails, and the GetLastError function returns ERROR_FILE_NOT_FOUND.The file must reside on the local computer; otherwise, the function fails and the last error code is set to ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE.</param>
        /// <param name="lpNewFileName">The name of the new file.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="dwCopyFlags">Flags that specify how the file is to be copied. This parameter can be a combination of the following values.</param>
        /// <param name="hTransaction">A handle to the transaction. This handle is returned by the CreateTransaction function.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information call GetLastError.If lpProgressRoutine returns PROGRESS_CANCEL due to the user canceling the operation, CopyFileTransacted will return zero and GetLastError will return ERROR_REQUEST_ABORTED. In this case, the partially copied destination file is deleted.If lpProgressRoutine returns PROGRESS_STOP due to the user stopping the operation, CopyFileTransacted will return zero and GetLastError will return ERROR_REQUEST_ABORTED. In this case, the partially copied destination file is left intact.If you attempt to call this function with a handle to a transaction that has already been rolled back, CopyFileTransacted will return either ERROR_TRANSACTION_NOT_ACTIVE or ERROR_INVALID_TRANSACTION.This function preserves extended attributes, OLE structured storage, NTFS file system alternate data streams, security attributes, and file attributes.Windows 7, Windows Server 2008 R2, Windows Server 2008 and Windows Vista:  Security resource attributes (ATTRIBUTE_SECURITY_INFORMATION) for the existing file are not copied to the new file until Windows 8 and Windows Server 2012.This function fails with ERROR_ACCESS_DENIED if the destination file already exists and has the FILE_ATTRIBUTE_HIDDEN or FILE_ATTRIBUTE_READONLY attribute set.Encrypted files are not supported by TxF.If COPY_FILE_COPY_SYMLINK is specified, the following rules apply:Link tracking is not supported by TxF.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.Note that SMB 3.0 does not support TxF.CopyProgressRoutineCreateFileTransactedFile Attribute ConstantsFile Management FunctionsMoveFileTransactedSymbolic LinksTransactional NTFS</param>
        /// <remarks>
        /// To get extended error information call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CopyFileTransactedW(string lpExistingFileName, string lpNewFileName, uint dwCopyFlags, IntPtr hTransaction);

        /// <summary>
        ///Copies an existing file to a new file.
        /// </summary>
        /// <param name="lpExistingFileName">The name of an existing file.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.If lpExistingFileName does not exist, CopyFile fails, and GetLastError returns ERROR_FILE_NOT_FOUND.</param>
        /// <param name="lpNewFileName">The name of the new file.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="bFailIfExists">If this parameter is TRUE and the new file specified by lpNewFileName already exists, the function fails. If this parameter is FALSE and the new file already exists, the function overwrites the existing file and succeeds.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The security resource properties (ATTRIBUTE_SECURITY_INFORMATION) for the existing file are copied to the new file.Windows 7, Windows Server 2008 R2, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:  Security resource properties for the existing file are not copied to the new file until Windows 8 and Windows Server 2012.File attributes for the existing file are copied to the new file. For example, if an existing file has the FILE_ATTRIBUTE_READONLY file attribute, a copy created through a call to CopyFile will also have the FILE_ATTRIBUTE_READONLY file attribute. For more information, see Retrieving and Changing File Attributes.This function fails with ERROR_ACCESS_DENIED if the destination file already exists and has the FILE_ATTRIBUTE_HIDDEN or FILE_ATTRIBUTE_READONLY attribute set.When CopyFile is used to copy an encrypted file, it attempts to encrypt the destination file with the keys used in the encryption of the source file. If this cannot be done, this function attempts to encrypt the destination file with default keys. If neither of these methods can be done, CopyFile fails with an ERROR_ENCRYPTION_FAILED error code.Symbolic link behavior—If the source file is a symbolic link, the actual file copied is the target of the symbolic link.If the destination file already exists and is a symbolic link, the target of the symbolic link is overwritten by the source file.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.For an example, see Retrieving and Changing File Attributes.CopyFileExCopyFileTransactedCreateFileFile Attribute ConstantsFile Management FunctionsMoveFileSymbolic Links</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CopyFileW(string lpExistingFileName, string lpNewFileName, bool bFailIfExists);

        /// <summary>
        ///The CreateActCtx function creates an activation context.
        /// </summary>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateActCtxA();

        /// <summary>
        ///The CreateActCtx function creates an activation context.
        /// </summary>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateActCtxW();

        /// <summary>
        ///Creates a boundary descriptor.
        /// </summary>
        /// <param name="Name">The name of the boundary descriptor.</param>
        /// <param name="Flags">A combination of the following flags that are combined by using a bitwise OR operation.If the function succeeds, the return value is a handle to the boundary descriptor.If the function fails, the return value is NULL. To get extended error information, call GetLastError.A new boundary descriptor must have at least one security identifier (SID). To add a SID to a boundary descriptor, use the AddSIDToBoundaryDescriptor function.To compile an application that uses this function, define _WIN32_WINNT as 0x0600 or later.AddSIDToBoundaryDescriptorCreatePrivateNamespaceDeleteBoundaryDescriptorObject Namespaces</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateBoundaryDescriptorA(string Name, int Flags);

        /// <summary>
        ///Creates a new directory. If the underlying file system supports security on files and directories, the function applies a specified security descriptor to the new directory.
        /// </summary>
        /// <param name="lpPathName">The path of the directory to be created.For the ANSI version of this function, there is a default string size limit for paths of 248 characters (MAX_PATH - enough room for a 8.3 filename). To extend this limit to 32,767 wide characters, call the Unicode version of the function and prepend "\?" to the path. For more information, see Naming a File</param>
        /// <remarks>
        /// To get extended error information, call GetLastError. Possible errors include the following.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CreateDirectory(string lpPathName);

        /// <summary>
        ///Creates a new directory with the attributes of a specified template directory. If the underlying file system supports security on files and directories, the function applies a specified security descriptor to the new directory. The new directory retains the other attributes of the specified template directory.
        /// </summary>
        /// <param name="lpTemplateDirectory">The path of the directory to use as a template when creating the new directory.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="lpNewDirectory">The path of the directory to be created.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError. Possible errors include the following.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CreateDirectoryExA(string lpTemplateDirectory, string lpNewDirectory);

        /// <summary>
        ///Creates a new directory with the attributes of a specified template directory. If the underlying file system supports security on files and directories, the function applies a specified security descriptor to the new directory. The new directory retains the other attributes of the specified template directory.
        /// </summary>
        /// <param name="lpTemplateDirectory">The path of the directory to use as a template when creating the new directory.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="lpNewDirectory">The path of the directory to be created.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError. Possible errors include the following.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CreateDirectoryExW(string lpTemplateDirectory, string lpNewDirectory);

        /// <summary>
        ///[Microsoft strongly recommends developers utilize alternative means to achieve your application’s needs. Many scenarios that TxF was developed for can be achieved through simpler and more readily available techniques. Furthermore, TxF may not be available in future versions of Microsoft Windows. For more information, and alternatives to TxF, please see Alternatives to using Transactional NTFS.]
        /// </summary>
        /// <param name="lpNewDirectory">The path of the directory to be created.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="hTransaction">A handle to the transaction. This handle is returned by the CreateTransaction function.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero (0). To get extended error information, call GetLastError. Possible errors include the following.The CreateDirectoryTransacted function allows you to create directories that inherit stream information from other directories. This function is useful, for example, when you are using Macintosh directories, which have a resource stream that is needed to properly identify directory contents as an attribute.Some file systems, such as the NTFS file system, support compression or encryption for individual files and directories. On volumes formatted for such a file system, a new directory inherits the compression and encryption attributes of its parent directory.This function fails with ERROR_EFS_NOT_ALLOWED_IN_TRANSACTION if you try to create a child directory with a parent directory that has encryption disabled.You can obtain a handle to a directory by calling the CreateFileTransacted function with the FILE_FLAG_BACKUP_SEMANTICS flag set.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB 3.0 does not support TxF.CreateFileTransactedCreating and Deleting DirectoriesDirectory Management FunctionsRemoveDirectoryTransactedSECURITY_ATTRIBUTESTransactional NTFS</param>
        /// <remarks>
        /// To get extended error information, call GetLastError. Possible errors include the following.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CreateDirectoryTransactedA(string lpNewDirectory, IntPtr hTransaction);

        /// <summary>
        ///[Microsoft strongly recommends developers utilize alternative means to achieve your application’s needs. Many scenarios that TxF was developed for can be achieved through simpler and more readily available techniques. Furthermore, TxF may not be available in future versions of Microsoft Windows. For more information, and alternatives to TxF, please see Alternatives to using Transactional NTFS.]
        /// </summary>
        /// <param name="lpNewDirectory">The path of the directory to be created.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="hTransaction">A handle to the transaction. This handle is returned by the CreateTransaction function.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero (0). To get extended error information, call GetLastError. Possible errors include the following.The CreateDirectoryTransacted function allows you to create directories that inherit stream information from other directories. This function is useful, for example, when you are using Macintosh directories, which have a resource stream that is needed to properly identify directory contents as an attribute.Some file systems, such as the NTFS file system, support compression or encryption for individual files and directories. On volumes formatted for such a file system, a new directory inherits the compression and encryption attributes of its parent directory.This function fails with ERROR_EFS_NOT_ALLOWED_IN_TRANSACTION if you try to create a child directory with a parent directory that has encryption disabled.You can obtain a handle to a directory by calling the CreateFileTransacted function with the FILE_FLAG_BACKUP_SEMANTICS flag set.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB 3.0 does not support TxF.CreateFileTransactedCreating and Deleting DirectoriesDirectory Management FunctionsRemoveDirectoryTransactedSECURITY_ATTRIBUTESTransactional NTFS</param>
        /// <remarks>
        /// To get extended error information, call GetLastError. Possible errors include the following.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CreateDirectoryTransactedW(string lpNewDirectory, IntPtr hTransaction);

        /// <summary>
        ///Allocates a fiber object, assigns it a stack, and sets up execution to begin at the specified start address, typically the fiber function. This function does not schedule the fiber.
        /// </summary>
        /// <param name="dwStackSize">The initial committed size of the stack, in bytes. If this parameter is zero, the new fiber uses the default commit stack size for the executable. For more information, see Thread Stack Size.</param>
        /// <param name="lpStartAddress">A pointer to the application-defined function to be executed by the fiber and represents the starting address of the fiber. Execution of the newly created fiber does not begin until another fiber calls the SwitchToFiber function with this address. For more information of the fiber callback function, see FiberProc.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void CreateFiber(int dwStackSize, int lpStartAddress);

        /// <summary>
        ///Allocates a fiber object, assigns it a stack, and sets up execution to begin at the specified start address, typically the fiber function. This function does not schedule the fiber.
        /// </summary>
        /// <param name="dwStackCommitSize">The initial commit size of the stack, in bytes. If this parameter is zero, the new fiber uses the default commit stack size for the executable. For more information, see Thread Stack Size.</param>
        /// <param name="dwStackReserveSize">The initial reserve size of the stack, in bytes. If this parameter is zero, the new fiber uses the default reserved stack size for the executable. For more information, see Thread Stack Size.</param>
        /// <param name="dwFlags">If this parameter is zero, the floating-point state on x86 systems is not switched and data can be corrupted if a fiber uses floating-point arithmetic. If this parameter is FIBER_FLAG_FLOAT_SWITCH, the floating-point state is switched for the fiber.Windows XP:  The FIBER_FLAG_FLOAT_SWITCH flag is not supported.</param>
        /// <param name="lpStartAddress">A pointer to the application-defined function to be executed by the fiber and represents the starting address of the fiber. Execution of the newly created fiber does not begin until another fiber calls the SwitchToFiber function with this address. For more information on the fiber callback function, see FiberProc.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void CreateFiberEx(int dwStackCommitSize, int dwStackReserveSize, uint dwFlags, int lpStartAddress);

        /// <summary>
        ///Creates or opens a named or unnamed file mapping object for a specified file.
        /// </summary>
        /// <param name="hFile">A handle to the file from which to create a file mapping object.The file must be opened with access rights that are compatible with the protection flags that the flProtect parameter specifies. It is not required, but it is recommended that files you intend to map be opened for exclusive access. For more information, see File Security and Access Rights.If hFile is INVALID_HANDLE_VALUE, the calling process must also specify a size for the file mapping object in the dwMaximumSizeHigh and dwMaximumSizeLow parameters. In this scenario, CreateFileMapping creates a file mapping object of a specified size that is backed by the system paging file instead of by a file in the file system.</param>
        /// <param name="flProtect">Specifies the page protection of the file mapping object. All mapped views of the object must be compatible with this protection.This parameter can be one of the following values.An application can specify one or more of the following attributes for the file mapping object by combining them with one of the preceding page protection values.</param>
        /// <param name="dwMaximumSizeHigh">The high-order DWORD of the maximum size of the file mapping object.</param>
        /// <param name="dwMaximumSizeLow">The low-order DWORD of the maximum size of the file mapping object.If this parameter and dwMaximumSizeHigh are 0 (zero), the maximum size of the file mapping object is equal to the current size of the file that hFile identifies.An attempt to map a file with a length of 0 (zero) fails with an error code of ERROR_FILE_INVALID. Applications should test for files with a length of 0 (zero) and reject those files.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateFileMappingA(IntPtr hFile, uint flProtect, uint dwMaximumSizeHigh, uint dwMaximumSizeLow);

        /// <summary>
        ///Creates or opens a named or unnamed file mapping object for a specified file and specifies the NUMA node for the physical memory.
        /// </summary>
        /// <param name="hFile">A handle to the file from which to create a file mapping object.The file must be opened with access rights that are compatible with the protection flags that the flProtect parameter specifies. It is not required, but it is recommended that files you intend to map be opened for exclusive access. For more information, see File Security and Access Rights.If hFile is INVALID_HANDLE_VALUE, the calling process must also specify a size for the file mapping object in the dwMaximumSizeHigh and dwMaximumSizeLow parameters. In this scenario, CreateFileMappingNuma creates a file mapping object of a specified size that is backed by the system paging file instead of by a file in the file system.</param>
        /// <param name="flProtect">Specifies the page protection of the file mapping object. All mapped views of the object must be compatible with this protection.This parameter can be one of the following values.An application can specify one or more of the following attributes for the file mapping object by combining them with one of the preceding page protection values.</param>
        /// <param name="dwMaximumSizeHigh">The high-order DWORD of the maximum size of the file mapping object.</param>
        /// <param name="dwMaximumSizeLow">The low-order DWORD of the maximum size of the file mapping object.If this parameter and the dwMaximumSizeHigh parameter are 0 (zero), the maximum size of the file mapping object is equal to the current size of the file that the hFile parameter identifies.An attempt to map a file with a length of 0 (zero) fails with an error code of ERROR_FILE_INVALID. Applications should test for files with a length of 0 (zero) and reject those files.</param>
        /// <param name="nndPreferred">The NUMA node where the physical memory should reside.If the function succeeds, the return value is a handle to the file mapping object.If the object exists before the function call, the function returns a handle to the existing object (with its current size, not the specified size) and the GetLastError function returns ERROR_ALREADY_EXISTS.If the function fails, the return value is NULL. To get extended error information, call the GetLastError function.After a file mapping object is created, the size of the file must not exceed the size of the file mapping object; if it does, not all of the file contents are available for sharing.The file mapping object can be shared by duplication, inheritance, or by name. The initial contents of the pages in a file mapping object backed by the page file are 0 (zero).If an application specifies a size for the file mapping object that is larger than the size of the actual named file on disk and if the page protection allows write access (that is, the flProtect parameter specifies PAGE_READWRITE or PAGE_EXECUTE_READWRITE), then the file on disk is increased to match the specified size of the file mapping object. If the file is extended, the contents of the file between the old end of the file and the new end of the file are not guaranteed to be zero; the behavior is defined by the file system.If the file cannot be increased, the result is a failure to create the file mapping object and the GetLastError function returns ERROR_DISK_FULL.The handle that the CreateFileMappingNuma function returns has full access to a new file mapping object and can be used with any function that requires a handle to a file mapping object. A file mapping object can be shared through process creation, handle duplication, or by name. For more information, see the DuplicateHandle and OpenFileMapping functions.Creating a file mapping object creates the potential for mapping a view of the file but does not map the view. The MapViewOfFileExNuma function maps a view of a file into a process address space.With one important exception, file views derived from a single file mapping object are coherent or identical at a specific time. If multiple processes have handles of the same file mapping object, they see a coherent view of the data when they map a view of the file.The exception is related to remote files. Although the CreateFileMappingNuma function works with remote files, it does not keep them coherent. For example, if two computers both map a file as writable and both change the same page, each computer sees only its own writes to the page. When the data gets updated on the disk, the page is not merged.A mapped file and a file that is accessed by using the input and output (I/O) functions (ReadFile and WriteFile) are not necessarily coherent.To fully close a file mapping object, an application must unmap all mapped views of the file mapping object by calling the UnmapViewOfFile function and then close the file mapping object handle by calling the CloseHandle function.These functions can be called in any order. The call to the UnmapViewOfFile function is necessary, because mapped views of a file mapping object maintain internal open handles to the object, and a file mapping object does not close until all open handles to it are closed.When modifying a file through a mapped view, the last modification timestamp may not be updated automatically. If required, the caller should use SetFileTime to set the timestamp.Creating a file-mapping object from a session other than session zero requires the SeCreateGlobalPrivilege privilege. Note that this privilege check is limited to the creation of file mapping objects and does not apply to opening existing ones. For example, if a service or the system creates a file mapping object, any process running in any session can access that file mapping object provided that the caller has the required access rights.Use structured exception handling to protect any code that writes to or reads from a memory mapped view. For more information, see Reading and Writing From a File View.To have a mapping with executable permissions, an application must call the CreateFileMappingNuma function with either PAGE_EXECUTE_READWRITE or PAGE_EXECUTE_READ and then call the MapViewOfFileExNuma function with FILE_MAP_EXECUTE | FILE_MAP_WRITE or FILE_MAP_EXECUTE | FILE_MAP_READ.In Windows Server 2012, this function is supported by the following technologies.CloseHandleCreateFileMappingDuplicateHandleFile Mapping FunctionsMapViewOfFileExNumaNUMA SupportOpenFileMappingReadFileSECURITY_ATTRIBUTESUnmapViewOfFileVirtualAllocExNumaWriteFile</param>
        /// <remarks>
        /// To get extended error information, call the GetLastError function.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateFileMappingNumaA(IntPtr hFile, uint flProtect, uint dwMaximumSizeHigh, uint dwMaximumSizeLow, uint nndPreferred);

        /// <summary>
        ///[Microsoft strongly recommends developers utilize alternative means to achieve your application’s needs. Many scenarios that TxF was developed for can be achieved through simpler and more readily available techniques. Furthermore, TxF may not be available in future versions of Microsoft Windows. For more information, and alternatives to TxF, please see Alternatives to using Transactional NTFS.]
        /// </summary>
        /// <param name="lpFileName">The name of an object to be created or opened.The object must reside on the local computer; otherwise, the function fails and the last error code is set to ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.To create a file stream, specify the name of the file, a colon, and then the name of the stream. For more information, see File Streams.</param>
        /// <param name="dwDesiredAccess">The access to the object, which can be summarized as read, write, both or neither (zero). The most commonly used values are GENERIC_READ, GENERIC_WRITE, or both (GENERIC_READ | GENERIC_WRITE). For more information, see Generic Access Rights and File Security and Access Rights.If this parameter is zero, the application can query file, directory, or device attributes without accessing that file or device. For more information, see the Remarks section of this topic.You cannot request an access mode that conflicts with the sharing mode that is specified in an open request that has an open handle. For more information, see Creating and Opening Files.</param>
        /// <param name="dwShareMode">The sharing mode of an object, which can be read, write, both, delete, all of these, or none (refer to the following table).If this parameter is zero and CreateFileTransacted succeeds, the object cannot be shared and cannot be opened again until the handle is closed. For more information, see the Remarks section of this topic.You cannot request a sharing mode that conflicts with the access mode that is specified in an open request that has an open handle, because that would result in the following sharing violation: ERROR_SHARING_VIOLATION. For more information, see Creating and Opening Files.To enable a process to share an object while another process has the object open, use a combination of one or more of the following values to specify the access mode they can request to open the object.</param>
        /// <param name="dwCreationDisposition">An action to take on files that exist and do not exist.For more information, see the Remarks section of this topic.This parameter must be one of the following values, which cannot be combined.</param>
        /// <param name="dwFlagsAndAttributes">The file attributes and flags, FILE_ATTRIBUTE_NORMAL being the most common default value.This parameter can include any combination of the available file attributes (FILE_ATTRIBUTE_*). All other file attributes override FILE_ATTRIBUTE_NORMAL.This parameter can also contain combinations of flags (FILE_FLAG_) for control of buffering behavior, access modes, and other special-purpose flags. These combine with any FILE_ATTRIBUTE_ values.This parameter can also contain Security Quality of Service (SQOS) information by specifying the SECURITY_SQOS_PRESENT flag. Additional SQOS-related flags information is presented in the table following the attributes and flags tables.The dwFlagsAndAttributes parameter can also specify Security Quality of Service information. For more information, see Impersonation Levels. When the calling application specifies the SECURITY_SQOS_PRESENT flag as part of dwFlagsAndAttributes, it can also contain one or more of the following values.</param>
        /// <param name="hTransaction">A handle to the transaction. This handle is returned by the CreateTransaction function.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateFileTransactedA(string lpFileName, uint dwDesiredAccess, uint dwShareMode, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTransaction);

        /// <summary>
        ///[Microsoft strongly recommends developers utilize alternative means to achieve your application’s needs. Many scenarios that TxF was developed for can be achieved through simpler and more readily available techniques. Furthermore, TxF may not be available in future versions of Microsoft Windows. For more information, and alternatives to TxF, please see Alternatives to using Transactional NTFS.]
        /// </summary>
        /// <param name="lpFileName">The name of an object to be created or opened.The object must reside on the local computer; otherwise, the function fails and the last error code is set to ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.To create a file stream, specify the name of the file, a colon, and then the name of the stream. For more information, see File Streams.</param>
        /// <param name="dwDesiredAccess">The access to the object, which can be summarized as read, write, both or neither (zero). The most commonly used values are GENERIC_READ, GENERIC_WRITE, or both (GENERIC_READ | GENERIC_WRITE). For more information, see Generic Access Rights and File Security and Access Rights.If this parameter is zero, the application can query file, directory, or device attributes without accessing that file or device. For more information, see the Remarks section of this topic.You cannot request an access mode that conflicts with the sharing mode that is specified in an open request that has an open handle. For more information, see Creating and Opening Files.</param>
        /// <param name="dwShareMode">The sharing mode of an object, which can be read, write, both, delete, all of these, or none (refer to the following table).If this parameter is zero and CreateFileTransacted succeeds, the object cannot be shared and cannot be opened again until the handle is closed. For more information, see the Remarks section of this topic.You cannot request a sharing mode that conflicts with the access mode that is specified in an open request that has an open handle, because that would result in the following sharing violation: ERROR_SHARING_VIOLATION. For more information, see Creating and Opening Files.To enable a process to share an object while another process has the object open, use a combination of one or more of the following values to specify the access mode they can request to open the object.</param>
        /// <param name="dwCreationDisposition">An action to take on files that exist and do not exist.For more information, see the Remarks section of this topic.This parameter must be one of the following values, which cannot be combined.</param>
        /// <param name="dwFlagsAndAttributes">The file attributes and flags, FILE_ATTRIBUTE_NORMAL being the most common default value.This parameter can include any combination of the available file attributes (FILE_ATTRIBUTE_*). All other file attributes override FILE_ATTRIBUTE_NORMAL.This parameter can also contain combinations of flags (FILE_FLAG_) for control of buffering behavior, access modes, and other special-purpose flags. These combine with any FILE_ATTRIBUTE_ values.This parameter can also contain Security Quality of Service (SQOS) information by specifying the SECURITY_SQOS_PRESENT flag. Additional SQOS-related flags information is presented in the table following the attributes and flags tables.The dwFlagsAndAttributes parameter can also specify Security Quality of Service information. For more information, see Impersonation Levels. When the calling application specifies the SECURITY_SQOS_PRESENT flag as part of dwFlagsAndAttributes, it can also contain one or more of the following values.</param>
        /// <param name="hTransaction">A handle to the transaction. This handle is returned by the CreateTransaction function.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateFileTransactedW(string lpFileName, uint dwDesiredAccess, uint dwShareMode, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTransaction);

        /// <summary>
        ///Establishes a hard link between an existing file and a new file. This function is only supported on the NTFS file system, and only for files, not directories.
        /// </summary>
        /// <param name="lpFileName">The name of the new file.This parameter may include the path but cannot specify the name of a directory.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="lpExistingFileName">The name of the existing file.This parameter may include the path cannot specify the name of a directory.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.lpSecurityAttributesReserved; must be NULL.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero (0). To get extended error information, call GetLastError.The maximum number of hard links that can be created with this function is 1023 per file. If more than 1023 links are created for a file, an error results.If you pass a name longer than MAX_PATH characters to the lpFileName or lpExistingFileName parameter of the ANSI version of this function or to the Unicode version of this function without prepending "\\?\" to the path, the function returns ERROR_PATH_NOT_FOUND.Any directory entry for a file that is created with CreateFile or CreateHardLink is a hard link to an associated file. An additional hard link that is created with the CreateHardLink function allows you to have multiple directory entries for a file, that is, multiple hard links to the same file, which can be different names in the same directory, or the same or different names in different directories. However, all hard links to a file must be on the same volume.Because hard links are only directory entries for a file, many changes to that file are instantly visible to applications that access it through the hard links that reference it. However, the directory entry size and attribute information is updated only for the link through which the change was made.The security descriptor belongs to the file to which a hard link points. The link itself is only a directory entry, and does not have a security descriptor. Therefore, when you change the security descriptor of a hard link, you a change the security descriptor of the underlying file, and all hard links that point to the file allow the newly specified access. You cannot give a file different security descriptors on a per-hard-link basis.This function does not modify the security descriptor of the file to be linked to, even if security descriptor information is passed in the lpSecurityAttributes parameter.Use DeleteFile to delete hard links. You can delete them in any order regardless of the order in which they are created.Flags, attributes, access, and sharing that are specified in CreateFile operate on a per-file basis. That is, if you open a file that does not allow sharing, another application cannot share the file by creating a new hard link to the file.When you create a hard link on the NTFS file system, the file attribute information in the directory entry is refreshed only when the file is opened, or when GetFileInformationByHandle is called with the handle of a specific file.Symbolic link behavior—If the path points to a symbolic link, the function creates a hard link to the symbolic link.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.Note that SMB 3.0 does not support creation of hard links on shares with continuous availability capability.The following code snippet shows you how to call CreateHardLink so that it does not modify the security descriptor of a file. The pszExistingFileName parameter can be the original file name, or any existing link to a file. After this code is executed, pszNewLinkName refers to the file.CreateFileCreateHardLinkTransactedDeleteFileFile Management FunctionsHard Links and JunctionsSymbolic Links</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CreateHardLinkA(string lpFileName, string lpExistingFileName);

        /// <summary>
        ///[Microsoft strongly recommends developers utilize alternative means to achieve your application’s needs. Many scenarios that TxF was developed for can be achieved through simpler and more readily available techniques. Furthermore, TxF may not be available in future versions of Microsoft Windows. For more information, and alternatives to TxF, please see Alternatives to using Transactional NTFS.]
        /// </summary>
        /// <param name="lpFileName">The name of the new file.This parameter cannot specify the name of a directory.</param>
        /// <param name="lpExistingFileName">The name of the existing file.This parameter cannot specify the name of a directory.lpSecurityAttributesReserved; must be NULL.</param>
        /// <param name="hTransaction">A handle to the transaction. This handle is returned by the CreateTransaction function.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero (0). To get extended error information, call GetLastError.The maximum number of hard links that can be created with this function is 1023 per file. If more than 1023 links are created for a file, an error results.The files must reside on the local computer; otherwise, the function fails and the last error code is set to ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE.Any directory entry for a file that is created with CreateFileTransacted or CreateHardLinkTransacted is a hard link to an associated file. An additional hard link that is created with the CreateHardLinkTransacted function allows you to have multiple directory entries for a file, that is, multiple hard links to the same file, which can be different names in the same directory, or the same or different names in different directories. However, all hard links to a file must be on the same volume.Because hard links are only directory entries for a file, when an application modifies a file through any hard link, all applications that use any other hard link to the file see the changes. Also, all of the directory entries are updated if the file changes. For example, if a file size changes, all of the hard links to the file show the new file size.The security descriptor belongs to the file to which a hard link points. The link itself is only a directory entry, and does not have a security descriptor. Therefore, when you change the security descriptor of a hard link, you a change the security descriptor of the underlying file, and all hard links that point to the file allow the newly specified access. You cannot give a file different security descriptors on a per-hard-link basis.This function does not modify the security descriptor of the file to be linked to, even if security descriptor information is passed in the lpSecurityAttributes parameter.Use DeleteFileTransacted to delete hard links. You can delete them in any order regardless of the order in which they are created.Flags, attributes, access, and sharing that are specified in CreateFileTransacted operate on a per-file basis. That is, if you open a file that does not allow sharing, another application cannot share the file by creating a new hard link to the file.When you create a hard link on the NTFS file system, the file attribute information in the directory entry is refreshed only when the file is opened, or when GetFileInformationByHandle is called with the handle of a specific file.Symbolic links:  If the path points to a symbolic link, the function creates a hard link to the target.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.Note that SMB 3.0 does not support TxF.CreateFileTransactedDeleteFileTransactedFile Management FunctionsHard Links and JunctionsSymbolic LinksTransactional NTFS</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CreateHardLinkTransactedA(string lpFileName, string lpExistingFileName, IntPtr hTransaction);

        /// <summary>
        ///[Microsoft strongly recommends developers utilize alternative means to achieve your application’s needs. Many scenarios that TxF was developed for can be achieved through simpler and more readily available techniques. Furthermore, TxF may not be available in future versions of Microsoft Windows. For more information, and alternatives to TxF, please see Alternatives to using Transactional NTFS.]
        /// </summary>
        /// <param name="lpFileName">The name of the new file.This parameter cannot specify the name of a directory.</param>
        /// <param name="lpExistingFileName">The name of the existing file.This parameter cannot specify the name of a directory.lpSecurityAttributesReserved; must be NULL.</param>
        /// <param name="hTransaction">A handle to the transaction. This handle is returned by the CreateTransaction function.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero (0). To get extended error information, call GetLastError.The maximum number of hard links that can be created with this function is 1023 per file. If more than 1023 links are created for a file, an error results.The files must reside on the local computer; otherwise, the function fails and the last error code is set to ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE.Any directory entry for a file that is created with CreateFileTransacted or CreateHardLinkTransacted is a hard link to an associated file. An additional hard link that is created with the CreateHardLinkTransacted function allows you to have multiple directory entries for a file, that is, multiple hard links to the same file, which can be different names in the same directory, or the same or different names in different directories. However, all hard links to a file must be on the same volume.Because hard links are only directory entries for a file, when an application modifies a file through any hard link, all applications that use any other hard link to the file see the changes. Also, all of the directory entries are updated if the file changes. For example, if a file size changes, all of the hard links to the file show the new file size.The security descriptor belongs to the file to which a hard link points. The link itself is only a directory entry, and does not have a security descriptor. Therefore, when you change the security descriptor of a hard link, you a change the security descriptor of the underlying file, and all hard links that point to the file allow the newly specified access. You cannot give a file different security descriptors on a per-hard-link basis.This function does not modify the security descriptor of the file to be linked to, even if security descriptor information is passed in the lpSecurityAttributes parameter.Use DeleteFileTransacted to delete hard links. You can delete them in any order regardless of the order in which they are created.Flags, attributes, access, and sharing that are specified in CreateFileTransacted operate on a per-file basis. That is, if you open a file that does not allow sharing, another application cannot share the file by creating a new hard link to the file.When you create a hard link on the NTFS file system, the file attribute information in the directory entry is refreshed only when the file is opened, or when GetFileInformationByHandle is called with the handle of a specific file.Symbolic links:  If the path points to a symbolic link, the function creates a hard link to the target.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.Note that SMB 3.0 does not support TxF.CreateFileTransactedDeleteFileTransactedFile Management FunctionsHard Links and JunctionsSymbolic LinksTransactional NTFS</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CreateHardLinkTransactedW(string lpFileName, string lpExistingFileName, IntPtr hTransaction);

        /// <summary>
        ///Establishes a hard link between an existing file and a new file. This function is only supported on the NTFS file system, and only for files, not directories.
        /// </summary>
        /// <param name="lpFileName">The name of the new file.This parameter may include the path but cannot specify the name of a directory.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="lpExistingFileName">The name of the existing file.This parameter may include the path cannot specify the name of a directory.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.lpSecurityAttributesReserved; must be NULL.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero (0). To get extended error information, call GetLastError.The maximum number of hard links that can be created with this function is 1023 per file. If more than 1023 links are created for a file, an error results.If you pass a name longer than MAX_PATH characters to the lpFileName or lpExistingFileName parameter of the ANSI version of this function or to the Unicode version of this function without prepending "\\?\" to the path, the function returns ERROR_PATH_NOT_FOUND.Any directory entry for a file that is created with CreateFile or CreateHardLink is a hard link to an associated file. An additional hard link that is created with the CreateHardLink function allows you to have multiple directory entries for a file, that is, multiple hard links to the same file, which can be different names in the same directory, or the same or different names in different directories. However, all hard links to a file must be on the same volume.Because hard links are only directory entries for a file, many changes to that file are instantly visible to applications that access it through the hard links that reference it. However, the directory entry size and attribute information is updated only for the link through which the change was made.The security descriptor belongs to the file to which a hard link points. The link itself is only a directory entry, and does not have a security descriptor. Therefore, when you change the security descriptor of a hard link, you a change the security descriptor of the underlying file, and all hard links that point to the file allow the newly specified access. You cannot give a file different security descriptors on a per-hard-link basis.This function does not modify the security descriptor of the file to be linked to, even if security descriptor information is passed in the lpSecurityAttributes parameter.Use DeleteFile to delete hard links. You can delete them in any order regardless of the order in which they are created.Flags, attributes, access, and sharing that are specified in CreateFile operate on a per-file basis. That is, if you open a file that does not allow sharing, another application cannot share the file by creating a new hard link to the file.When you create a hard link on the NTFS file system, the file attribute information in the directory entry is refreshed only when the file is opened, or when GetFileInformationByHandle is called with the handle of a specific file.Symbolic link behavior—If the path points to a symbolic link, the function creates a hard link to the symbolic link.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.Note that SMB 3.0 does not support creation of hard links on shares with continuous availability capability.The following code snippet shows you how to call CreateHardLink so that it does not modify the security descriptor of a file. The pszExistingFileName parameter can be the original file name, or any existing link to a file. After this code is executed, pszNewLinkName refers to the file.CreateFileCreateHardLinkTransactedDeleteFileFile Management FunctionsHard Links and JunctionsSymbolic Links</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CreateHardLinkW(string lpFileName, string lpExistingFileName);

        /// <summary>
        ///Creates or opens a job object.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateJobObjectA();

        /// <summary>
        ///Creates a mailslot with the specified name and returns a handle that a mailslot server can use to perform operations on the mailslot. The mailslot is local to the computer that creates it. An error occurs if a mailslot with the specified name already exists.
        /// </summary>
        /// <param name="lpName">The name of the mailslot. This name must have the following form:\\.\mailslot\[path]nameThe name field must be unique. The name may include multiple levels of pseudo directories separated by backslashes. For example, both \\.\mailslot\example_mailslot_name and \\.\mailslot\abc\def\ghi are valid names.</param>
        /// <param name="nMaxMessageSize">The maximum size of a single message that can be written to the mailslot, in bytes. To specify that the message can be of any size, set this value to zero.</param>
        /// <param name="lReadTimeout">The time a read operation can wait for a message to be written to the mailslot before a time-out occurs, in milliseconds. The following values have special meanings.This time-out value applies to all subsequent read operations and all inherited mailslot handles.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateMailslotA(string lpName, uint nMaxMessageSize, uint lReadTimeout);

        /// <summary>
        ///Creates a mailslot with the specified name and returns a handle that a mailslot server can use to perform operations on the mailslot. The mailslot is local to the computer that creates it. An error occurs if a mailslot with the specified name already exists.
        /// </summary>
        /// <param name="lpName">The name of the mailslot. This name must have the following form:\\.\mailslot\[path]nameThe name field must be unique. The name may include multiple levels of pseudo directories separated by backslashes. For example, both \\.\mailslot\example_mailslot_name and \\.\mailslot\abc\def\ghi are valid names.</param>
        /// <param name="nMaxMessageSize">The maximum size of a single message that can be written to the mailslot, in bytes. To specify that the message can be of any size, set this value to zero.</param>
        /// <param name="lReadTimeout">The time a read operation can wait for a message to be written to the mailslot before a time-out occurs, in milliseconds. The following values have special meanings.This time-out value applies to all subsequent read operations and all inherited mailslot handles.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateMailslotW(string lpName, uint nMaxMessageSize, uint lReadTimeout);

        /// <summary>
        ///Creates an instance of a named pipe and returns a handle for subsequent pipe operations. A named pipe server process uses this function either to create the first instance of a specific named pipe and establish its basic attributes or to create a new instance of an existing named pipe.
        /// </summary>
        /// <param name="lpName">The unique pipe name. This string must have the following form:\\.\pipe\pipenameThe pipename part of the name can include any character other than a backslash, including numbers and special characters. The entire pipe name string can be up to 256 characters long. Pipe names are not case sensitive.</param>
        /// <param name="dwOpenMode">The open mode.The function fails if dwOpenMode specifies anything other than 0 or the flags listed in the following tables.This parameter must specify one of the following pipe access modes. The same mode must be specified for each instance of the pipe.This parameter can also include one or more of the following flags, which enable the write-through and overlapped modes. These modes can be different for different instances of the same pipe.This parameter can include any combination of the following security access modes. These modes can be different for different instances of the same pipe.</param>
        /// <param name="dwPipeMode">The pipe mode.The function fails if dwPipeMode specifies anything other than 0 or the flags listed in the following tables.One of the following type modes can be specified. The same type mode must be specified for each instance of the pipe.One of the following read modes can be specified. Different instances of the same pipe can specify different read modes.One of the following wait modes can be specified. Different instances of the same pipe can specify different wait modes.One of the following remote-client modes can be specified. Different instances of the same pipe can specify different remote-client modes.</param>
        /// <param name="nMaxInstances">The maximum number of instances that can be created for this pipe. The first instance of the pipe can specify this value; the same number must be specified for other instances of the pipe. Acceptable values are in the range 1 through PIPE_UNLIMITED_INSTANCES (255).If this parameter is PIPE_UNLIMITED_INSTANCES, the number of pipe instances that can be created is limited only by the availability of system resources. If nMaxInstances is greater than PIPE_UNLIMITED_INSTANCES, the return value is INVALID_HANDLE_VALUE and GetLastError returns ERROR_INVALID_PARAMETER.</param>
        /// <param name="nOutBufferSize">The number of bytes to reserve for the output buffer. For a discussion on sizing named pipe buffers, see the following Remarks section.</param>
        /// <param name="nInBufferSize">The number of bytes to reserve for the input buffer. For a discussion on sizing named pipe buffers, see the following Remarks section.</param>
        /// <param name="nDefaultTimeOut">The default time-out value, in milliseconds, if the WaitNamedPipe function specifies NMPWAIT_USE_DEFAULT_WAIT. Each instance of a named pipe must specify the same value.A value of zero will result in a default time-out of 50 milliseconds.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateNamedPipeA(string lpName, uint dwOpenMode, uint dwPipeMode, uint nMaxInstances, uint nOutBufferSize, uint nInBufferSize, uint nDefaultTimeOut);

        /// <summary>
        ///Creates a private namespace.
        /// </summary>
        /// <param name="lpBoundaryDescriptor">A descriptor that defines how the namespace is to be isolated. The caller must be within this boundary. The CreateBoundaryDescriptor function creates a boundary descriptor.</param>
        /// <param name="lpAliasPrefix">The prefix for the namespace. To create an object in this namespace, specify the object name as prefix\objectname.The system supports multiple private namespaces with the same name, as long as they define different boundaries.If the function succeeds, it returns a handle to the new namespace.If the function fails, the return value is NULL. To get extended error information, call GetLastError.Other applications can access the namespace using the OpenPrivateNamespace function.The application that created the namespace can use the ClosePrivateNamespace function to close the handle to the namespace. The handle is also closed when the creating process terminates. After the namespace handle is closed, subsequent calls to OpenPrivateNamespace fail, but all operations on objects in the namespace succeed.To compile an application that uses this function, define _WIN32_WINNT as 0x0600 or later.ClosePrivateNamespaceObject NamespacesOpenPrivateNamespace</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr CreatePrivateNamespaceA(IntPtr lpBoundaryDescriptor, string lpAliasPrefix);

        /// <summary>
        ///Creates a new process and its primary thread. Then the new process runs the specified executable file in the security context of the specified credentials (user, domain, and password). It can optionally load the user profile for a specified user.
        /// </summary>
        /// <param name="lpUsername">The name of the user. This is the name of the user account to log on to. If you use the UPN format, user@DNS_domain_name, the lpDomain parameter must be NULL.The user account must have the Log On Locally permission on the local computer. This permission is granted to all users on workstations and servers, but only to administrators on domain controllers.</param>
        /// <param name="lpPassword">The clear-text password for the lpUsername account.</param>
        /// <param name="dwLogonFlags">The logon option. This parameter can be 0 (zero) or one of the following values.</param>
        /// <param name="dwCreationFlags">The flags that control how the process is created. The CREATE_DEFAULT_ERROR_MODE, CREATE_NEW_CONSOLE, and CREATE_NEW_PROCESS_GROUP flags are enabled by default. For a list of values, see Process Creation Flags.This parameter also controls the new process's priority class, which is used to determine the scheduling priorities of the process's threads. For a list of values, see GetPriorityClass. If none of the priority class flags is specified, the priority class defaults to NORMAL_PRIORITY_CLASS unless the priority class of the creating process is IDLE_PRIORITY_CLASS or BELOW_NORMAL_PRIORITY_CLASS. In this case, the child process receives the default priority class of the calling process.If the dwCreationFlags parameter has a value of 0:</param>
        /// <param name="lpStartupInfo">A pointer to a STARTUPINFO structure.The application must add permission for the specified user account to the specified window station and desktop, even for WinSta0\Default.If the lpDesktop member is NULL or an empty string, the new process inherits the desktop and window station of its parent process. The application must add permission for the specified user account to the inherited window station and desktop.Windows XP:  CreateProcessWithLogonW adds permission for the specified user account to the inherited window station and desktop.Handles in STARTUPINFO must be closed with CloseHandle when they are no longer needed.</param>
        /// <param name="lpProcessInformation"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CreateProcessWithLogonW(string lpUsername, string lpPassword, uint dwLogonFlags, uint dwCreationFlags, int lpStartupInfo, out int lpProcessInformation);

        /// <summary>
        ///Creates a new process and its primary thread. The new process runs in the security context of the specified token. It can optionally load the user profile for the specified user.
        /// </summary>
        /// <param name="hToken">A handle to the primary token that represents a user. The handle must have the TOKEN_QUERY, TOKEN_DUPLICATE, and TOKEN_ASSIGN_PRIMARY access rights. For more information, see Access Rights for Access-Token Objects. The user represented by the token must have read and execute access to the application specified by the lpApplicationName or the lpCommandLine parameter.To get a primary token that represents the specified user, call the LogonUser function. Alternatively, you can call the DuplicateTokenEx function to convert an impersonation token into a primary token. This allows a server application that is impersonating a client to create a process that has the security context of the client.Terminal Services:  The caller's process always runs in the caller's session, not in the session specified in the token. To run a process in the session specified in the token, use the CreateProcessAsUser function.</param>
        /// <param name="dwLogonFlags">The logon option. This parameter can be zero or one of the following values.</param>
        /// <param name="dwCreationFlags">The flags that control how the process is created. The CREATE_DEFAULT_ERROR_MODE, CREATE_NEW_CONSOLE, and CREATE_NEW_PROCESS_GROUP flags are enabled by default. For a list of values, see Process Creation Flags.This parameter also controls the new process's priority class, which is used to determine the scheduling priorities of the process's threads. For a list of values, see GetPriorityClass. If none of the priority class flags is specified, the priority class defaults to NORMAL_PRIORITY_CLASS unless the priority class of the creating process is IDLE_PRIORITY_CLASS or BELOW_NORMAL_PRIORITY_CLASS. In this case, the child process receives the default priority class of the calling process.If the dwCreationFlags parameter has a value of 0:</param>
        /// <param name="lpStartupInfo">A pointer to a STARTUPINFO or STARTUPINFOEX structure.If the lpDesktop member is NULL or an empty string, the new process inherits the desktop and window station of its parent process. The function adds permission for the specified user account to the inherited window station and desktop. Otherwise, if this member specifies a desktop, it is the responsibility of the application to add permission for the specified user account to the specified window station and desktop, even for WinSta0\Default.Handles in STARTUPINFO or STARTUPINFOEX must be closed with CloseHandle when they are no longer needed.</param>
        /// <param name="lpProcessInformation"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CreateProcessWithTokenW(IntPtr hToken, uint dwLogonFlags, uint dwCreationFlags, int lpStartupInfo, out int lpProcessInformation);

        /// <summary>
        ///Creates or opens a named or unnamed semaphore object.
        /// </summary>
        /// <param name="lInitialCount">The initial count for the semaphore object. This value must be greater than or equal to zero and less than or equal to lMaximumCount. The state of a semaphore is signaled when its count is greater than zero and nonsignaled when it is zero. The count is decreased by one whenever a wait function releases a thread that was waiting for the semaphore. The count is increased by a specified amount by calling the ReleaseSemaphore function.</param>
        /// <param name="lMaximumCount">The maximum count for the semaphore object. This value must be greater than zero.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateSemaphoreA(int lInitialCount, int lMaximumCount);

        /// <summary>
        ///Creates or opens a named or unnamed semaphore object and returns a handle to the object.
        /// </summary>
        /// <param name="lInitialCount">The initial count for the semaphore object. This value must be greater than or equal to zero and less than or equal to lMaximumCount. The state of a semaphore is signaled when its count is greater than zero and nonsignaled when it is zero. The count is decreased by one whenever a wait function releases a thread that was waiting for the semaphore. The count is increased by a specified amount by calling the ReleaseSemaphore function.</param>
        /// <param name="lMaximumCount">The maximum count for the semaphore object. This value must be greater than zero.</param>
        /// <param name="dwDesiredAccess">The access mask for the semaphore object. For a list of access rights, see Synchronization Object Security and Access Rights.If the function succeeds, the return value is a handle to the semaphore object. If the named semaphore object existed before the function call, the function returns a handle to the existing object and GetLastError returns ERROR_ALREADY_EXISTS.If the function fails, the return value is NULL. To get extended error information, call GetLastError.The state of a semaphore object is signaled when its count is greater than zero, and nonsignaled when its count is equal to zero. The lInitialCount parameter specifies the initial count. The count can never be less than zero or greater than the value specified in the lMaximumCount parameter.Any thread of the calling process can specify the semaphore-object handle in a call to one of the wait functions. The single-object wait functions return when the state of the specified object is signaled. The multiple-object wait functions can be instructed to return either when any one or when all of the specified objects are signaled. When a wait function returns, the waiting thread is released to continue its execution. Each time a thread completes a wait for a semaphore object, the count of the semaphore object is decremented by one. When the thread has finished, it calls the ReleaseSemaphore function, which increments the count of the semaphore object.Multiple processes can have handles of the same semaphore object, enabling use of the object for interprocess synchronization. The following object-sharing mechanisms are available:CloseHandleSemaphore ObjectsSynchronization Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateSemaphoreExA(int lInitialCount, int lMaximumCount, uint dwDesiredAccess);

        /// <summary>
        ///Creates a symbolic link.
        /// </summary>
        /// <param name="lpSymlinkFileName">The symbolic link to be created.This parameter may include the path.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="lpTargetFileName">The name of the target for the symbolic link to be created.If lpTargetFileName has a device name associated with it, the link is treated as an absolute link; otherwise, the link is treated as a relative link.This parameter may include the path.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="dwFlags">Indicates whether the link target, lpTargetFileName, is a directory.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.Symbolic links can either be absolute or relative links. Absolute links are links that specify each portion of the path name; relative links are determined relative to where relative–link specifiers are in a specified path. Relative links are specified using the following conventions:In Windows 8 and Windows Server 2012, this function is supported by the following technologies.CsvFs does not support soft link or any other reparse points.CreateSymbolicLinkTransactedFile Management FunctionsSymbolic Links</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CreateSymbolicLinkA(string lpSymlinkFileName, string lpTargetFileName, uint dwFlags);

        /// <summary>
        ///[Microsoft strongly recommends developers utilize alternative means to achieve your application’s needs. Many scenarios that TxF was developed for can be achieved through simpler and more readily available techniques. Furthermore, TxF may not be available in future versions of Microsoft Windows. For more information, and alternatives to TxF, please see Alternatives to using Transactional NTFS.]
        /// </summary>
        /// <param name="lpSymlinkFileName">The symbolic link to be created.</param>
        /// <param name="lpTargetFileName">The name of the target for the symbolic link to be created.If lpTargetFileName has a device name associated with it, the link is treated as an absolute link; otherwise, the link is treated as a relative link.</param>
        /// <param name="dwFlags">Indicates whether the link target, lpTargetFileName, is a directory.</param>
        /// <param name="hTransaction">A handle to the transaction. This handle is returned by the CreateTransaction function.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.Symbolic links can either be absolute or relative links. Absolute links are links that specify each portion of the path name; relative links are determined relative to where relative–link specifiers are in a specified path. Relative links are specified using the following conventions:SMB 3.0 does not support TxF.File Management FunctionsSymbolic LinksTransactional NTFS</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CreateSymbolicLinkTransactedA(string lpSymlinkFileName, string lpTargetFileName, uint dwFlags, IntPtr hTransaction);

        /// <summary>
        ///[Microsoft strongly recommends developers utilize alternative means to achieve your application’s needs. Many scenarios that TxF was developed for can be achieved through simpler and more readily available techniques. Furthermore, TxF may not be available in future versions of Microsoft Windows. For more information, and alternatives to TxF, please see Alternatives to using Transactional NTFS.]
        /// </summary>
        /// <param name="lpSymlinkFileName">The symbolic link to be created.</param>
        /// <param name="lpTargetFileName">The name of the target for the symbolic link to be created.If lpTargetFileName has a device name associated with it, the link is treated as an absolute link; otherwise, the link is treated as a relative link.</param>
        /// <param name="dwFlags">Indicates whether the link target, lpTargetFileName, is a directory.</param>
        /// <param name="hTransaction">A handle to the transaction. This handle is returned by the CreateTransaction function.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.Symbolic links can either be absolute or relative links. Absolute links are links that specify each portion of the path name; relative links are determined relative to where relative–link specifiers are in a specified path. Relative links are specified using the following conventions:SMB 3.0 does not support TxF.File Management FunctionsSymbolic LinksTransactional NTFS</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CreateSymbolicLinkTransactedW(string lpSymlinkFileName, string lpTargetFileName, uint dwFlags, IntPtr hTransaction);

        /// <summary>
        ///Creates a symbolic link.
        /// </summary>
        /// <param name="lpSymlinkFileName">The symbolic link to be created.This parameter may include the path.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="lpTargetFileName">The name of the target for the symbolic link to be created.If lpTargetFileName has a device name associated with it, the link is treated as an absolute link; otherwise, the link is treated as a relative link.This parameter may include the path.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="dwFlags">Indicates whether the link target, lpTargetFileName, is a directory.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.Symbolic links can either be absolute or relative links. Absolute links are links that specify each portion of the path name; relative links are determined relative to where relative–link specifiers are in a specified path. Relative links are specified using the following conventions:In Windows 8 and Windows Server 2012, this function is supported by the following technologies.CsvFs does not support soft link or any other reparse points.CreateSymbolicLinkTransactedFile Management FunctionsSymbolic Links</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CreateSymbolicLinkW(string lpSymlinkFileName, string lpTargetFileName, uint dwFlags);

        /// <summary>
        ///The CreateTapePartition function reformats a tape.
        /// </summary>
        /// <param name="hDevice">Handle to the device where the new partition is to be created. This handle is created by using the CreateFile function.</param>
        /// <param name="dwPartitionMethod">Type of partition to create. To determine what type of partitions your device supports, see the documentation for your hardware. This parameter can have one of the following values.</param>
        /// <param name="dwCount">Number of partitions to create. The GetTapeParameters function provides the maximum number of partitions a tape can support.</param>
        /// <param name="dwSize">Size of each partition, in megabytes. This value is ignored if the dwPartitionMethod parameter is TAPE_SELECT_PARTITIONS.If the function succeeds, the return value is NO_ERROR.If the function fails, it can return one of the following error codes.Creating partitions reformats the tape. All previous information recorded on the tape is destroyed.CreateFileGetTapeParameters</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint CreateTapePartition(IntPtr hDevice, uint dwPartitionMethod, uint dwCount, uint dwSize);

        /// <summary>
        ///Creates a user-mode scheduling (UMS) completion list.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError. Possible error values include the following.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CreateUmsCompletionList(out int UmsCompletionList);

        /// <summary>
        ///Creates a user-mode scheduling (UMS) thread context to represent a UMS worker thread.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError. Possible error values include the following.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CreateUmsThreadContext(out int lpUmsThread);

        /// <summary>
        ///The DeactivateActCtx function deactivates the activation context corresponding to the specified cookie.
        /// </summary>
        /// <param name="dwFlags">Flags that indicate how the deactivation is to occur.</param>
        /// <param name="ulCookie">The ULONG_PTR that was passed into the call to ActivateActCtx. This value is used as a cookie to identify a specific activated activation context.If the function succeeds, it returns TRUE. Otherwise, it returns FALSE.This function sets errors that can be retrieved by calling GetLastError. For an example, see Retrieving the Last-Error Code. For a complete list of error codes, see System Error Codes.The deactivation of activation contexts must occur in the reverse order of activation. It can be understood as popping an activation context from a stack.ActivateActCtx</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool DeactivateActCtx(uint dwFlags, int ulCookie);

        /// <summary>
        ///Causes a breakpoint exception to occur in the specified process. This allows the calling thread to signal the debugger to handle the exception.
        /// </summary>
        /// <param name="Process">A handle to the process.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.If the process is not being debugged, the function uses the search logic of a standard exception handler. In most cases, this causes the process to terminate because of an unhandled breakpoint exception.Communicating with the DebuggerDebugBreakDebugging Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool DebugBreakProcess(IntPtr Process);

        /// <summary>
        ///Sets the action to be performed when the calling thread exits.
        /// </summary>
        /// <param name="KillOnExit">If this parameter is TRUE, the thread terminates all attached processes on exit (note that this is the default). Otherwise, the thread detaches from all processes being debugged on exit.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The calling thread must have established at least one debugging connection using the CreateProcess or DebugActiveProcess function before calling this function. DebugSetProcessKillOnExit affects all current and future debuggees connected to the calling thread. A thread can call this function multiple times to change the action as needed.DebugActiveProcessStopDebugging Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool DebugSetProcessKillOnExit(bool KillOnExit);

        /// <summary>
        ///Decrypts an encrypted file or directory.
        /// </summary>
        /// <param name="lpFileName">The name of the file or directory to be decrypted.The caller must have the FILE_READ_DATA, FILE_WRITE_DATA, FILE_READ_ATTRIBUTES, FILE_WRITE_ATTRIBUTES, and SYNCHRONIZE access rights. For more information, see File Security and Access Rights.dwReservedReserved; must be zero.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The DecryptFile function requires exclusive access to the file being decrypted, and will fail if another process is using the file. If the file is not encrypted, DecryptFile simply returns a nonzero value, which indicates success.If lpFileName specifies a read-only file, the function fails and GetLastError returns ERROR_FILE_READ_ONLY. If lpFileName specifies a directory that contains a read-only file, the functions succeeds but the directory is not decrypted.In Windows 8, Windows Server 2012, and later, this function is supported by the following technologies.SMB 3.0 does not support EFS on shares with continuous availability capability.CreateFileEncryptFileFile EncryptionFile Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool DecryptFileA(string lpFileName);

        /// <summary>
        ///Decrypts an encrypted file or directory.
        /// </summary>
        /// <param name="lpFileName">The name of the file or directory to be decrypted.The caller must have the FILE_READ_DATA, FILE_WRITE_DATA, FILE_READ_ATTRIBUTES, FILE_WRITE_ATTRIBUTES, and SYNCHRONIZE access rights. For more information, see File Security and Access Rights.dwReservedReserved; must be zero.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The DecryptFile function requires exclusive access to the file being decrypted, and will fail if another process is using the file. If the file is not encrypted, DecryptFile simply returns a nonzero value, which indicates success.If lpFileName specifies a read-only file, the function fails and GetLastError returns ERROR_FILE_READ_ONLY. If lpFileName specifies a directory that contains a read-only file, the functions succeeds but the directory is not decrypted.In Windows 8, Windows Server 2012, and later, this function is supported by the following technologies.SMB 3.0 does not support EFS on shares with continuous availability capability.CreateFileEncryptFileFile EncryptionFile Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool DecryptFileW(string lpFileName);

        /// <summary>
        ///Defines, redefines, or deletes MS-DOS device names.
        /// </summary>
        /// <param name="dwFlags">The controllable aspects of the DefineDosDevice function. This parameter can be one or more of the following values.</param>
        /// <param name="lpDeviceName">A pointer to an MS-DOS device name string specifying the device the function is defining, redefining, or deleting. The device name string must not have a colon as the last character, unless a drive letter is being defined, redefined, or deleted. For example, drive C would be the string "C:". In no case is a trailing backslash ("") allowed.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool DefineDosDeviceA(uint dwFlags, string lpDeviceName);

        /// <summary>
        ///Decrements the reference count of a local string atom. If the atom's reference count is reduced to zero, DeleteAtom removes the string associated with the atom from the local atom table.
        /// </summary>
        /// <param name="nAtom">Type: ATOMThe atom to be deleted.Type: ATOMIf the function succeeds, the return value is zero.If the function fails, the return value is the nAtom parameter. To get extended error information, call GetLastError.A string atom's reference count specifies the number of times the atom has been added to the atom table. The AddAtom function increments the count on each call. The DeleteAtom function decrements the count on each call but removes the string only if the atom's reference count is zero.Each call to AddAtom should have a corresponding call to DeleteAtom. Do not call DeleteAtom more times than you call AddAtom, or you may delete the atom while other clients are using it.The DeleteAtom function has no effect on an integer atom (an atom whose value is in the range 0x0001 to 0xBFFF). The function always returns zero for an integer atom.AddAtomFindAtomGlobalAddAtomGlobalDeleteAtomGlobalFindAtomMAKEINTATOMReference</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int DeleteAtom(int nAtom);

        /// <summary>
        ///Deletes an existing fiber.
        /// </summary>
        /// <param name="lpFiber">The address of the fiber to be deleted.NoneThe DeleteFiber function deletes all data associated with the fiber. This data includes the stack, a subset of the registers, and the fiber data.If the currently running fiber calls DeleteFiber, its thread calls ExitThread and terminates. However, if a currently running fiber is deleted by another fiber, the thread running the deleted fiber is likely to terminate abnormally because the fiber stack has been freed.To compile an application that uses this function, define _WIN32_WINNT as 0x0400 or later. For more information, see Using the Windows Headers.For an example, see Using Fibers.ExitThreadFibersProcess and Thread Functions</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void DeleteFiber(IntPtr lpFiber);

        /// <summary>
        ///Deletes an existing file.
        /// </summary>
        /// <param name="lpFileName">The name of the file to be deleted.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero (0). To get extended error information, call GetLastError.If an application attempts to delete a file that does not exist, the DeleteFile function fails with ERROR_FILE_NOT_FOUND. If the file is a read-only file, the function fails with ERROR_ACCESS_DENIED.The following list identifies some tips for deleting, removing, or closing files:If you request delete permission at the time you create a file, you can delete or rename the file with that handle, but not with any other handle. For more information, see File Security and Access Rights.The DeleteFile function fails if an application attempts to delete a file that has other handles open for normal I/O or as a memory-mapped file (FILE_SHARE_DELETE must have been specified when other handles were opened).The DeleteFile function marks a file for deletion on close. Therefore, the file deletion does not occur until the last handle to the file is closed. Subsequent calls to CreateFile to open the file fail with ERROR_ACCESS_DENIED.Symbolic link behavior—If the path points to a symbolic link, the symbolic link is deleted, not the target. To delete a target, you must call CreateFile and specify FILE_FLAG_DELETE_ON_CLOSE.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.For an example, see Locking and Unlocking Byte Ranges in Files.CloseHandleCreateFileDeleteFileTransactedFile Management FunctionsSymbolic Links</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool DeleteFile(string lpFileName);

        /// <summary>
        ///[Microsoft strongly recommends developers utilize alternative means to achieve your application’s needs. Many scenarios that TxF was developed for can be achieved through simpler and more readily available techniques. Furthermore, TxF may not be available in future versions of Microsoft Windows. For more information, and alternatives to TxF, please see Alternatives to using Transactional NTFS.]
        /// </summary>
        /// <param name="lpFileName">The name of the file to be deleted.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.The file must reside on the local computer; otherwise, the function fails and the last error code is set to ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE.</param>
        /// <param name="hTransaction">A handle to the transaction. This handle is returned by the CreateTransaction function.If the function succeeds, the return value is nonzero.If the function fails, the return value is 0 (zero). To get extended error information, call GetLastError.If an application attempts to delete a file that does not exist, the DeleteFileTransacted function fails with ERROR_FILE_NOT_FOUND. If the file is a read-only file, the function fails with ERROR_ACCESS_DENIED.The following list identifies some tips for deleting, removing, or closing files:If you request delete permission at the time you create a file, you can delete or rename the file with that handle, but not with any other handle. For more information, see File Security and Access Rights.The DeleteFileTransacted function fails if an application attempts to delete a file that has other handles open for normal I/O or as a memory-mapped file (FILE_SHARE_DELETE must have been specified when other handles were opened).The DeleteFileTransacted function marks a file for deletion on close. The file is deleted after the last transacted writer handle to the file is closed, provided that the transaction is still active. If a file has been marked for deletion and a transacted writer handle is still open after the transaction completes, the file will not be deleted.Symbolic links:  If the path points to a symbolic link, the symbolic link is deleted, not the target. To delete a target, you must call CreateFile and specify FILE_FLAG_DELETE_ON_CLOSE.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB 3.0 does not support TxF.CloseHandleCreateFileTransactedFile Management FunctionsSymbolic LinksTransactional NTFS</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool DeleteFileTransactedA(string lpFileName, IntPtr hTransaction);

        /// <summary>
        ///[Microsoft strongly recommends developers utilize alternative means to achieve your application’s needs. Many scenarios that TxF was developed for can be achieved through simpler and more readily available techniques. Furthermore, TxF may not be available in future versions of Microsoft Windows. For more information, and alternatives to TxF, please see Alternatives to using Transactional NTFS.]
        /// </summary>
        /// <param name="lpFileName">The name of the file to be deleted.The file must reside on the local computer; otherwise, the function fails and the last error code is set to ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="hTransaction">A handle to the transaction. This handle is returned by the CreateTransaction function.If the function succeeds, the return value is nonzero.If the function fails, the return value is 0 (zero). To get extended error information, call GetLastError.If an application attempts to delete a file that does not exist, the DeleteFileTransacted function fails with ERROR_FILE_NOT_FOUND. If the file is a read-only file, the function fails with ERROR_ACCESS_DENIED.The following list identifies some tips for deleting, removing, or closing files:If you request delete permission at the time you create a file, you can delete or rename the file with that handle, but not with any other handle. For more information, see File Security and Access Rights.The DeleteFileTransacted function fails if an application attempts to delete a file that has other handles open for normal I/O or as a memory-mapped file (FILE_SHARE_DELETE must have been specified when other handles were opened).The DeleteFileTransacted function marks a file for deletion on close. The file is deleted after the last transacted writer handle to the file is closed, provided that the transaction is still active. If a file has been marked for deletion and a transacted writer handle is still open after the transaction completes, the file will not be deleted.Symbolic links:  If the path points to a symbolic link, the symbolic link is deleted, not the target. To delete a target, you must call CreateFile and specify FILE_FLAG_DELETE_ON_CLOSE.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB 3.0 does not support TxF.CloseHandleCreateFileTransactedFile Management FunctionsSymbolic LinksTransactional NTFS</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool DeleteFileTransactedW(string lpFileName, IntPtr hTransaction);

        /// <summary>
        ///Deletes the specified user-mode scheduling (UMS) completion list. The list must be empty.
        /// </summary>
        /// <param name="UmsCompletionList">A pointer to the UMS completion list to be deleted. The CreateUmsCompletionList function provides this pointer.If the function succeeds, it returns a nonzero value.If the function fails, the return value is zero. To get extended error information, call GetLastError.If the completion list is shared, the caller is responsible for ensuring that no active UMS thread holds a reference to the list before deleting it.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool DeleteUmsCompletionList(int UmsCompletionList);

        /// <summary>
        ///Deletes the specified user-mode scheduling (UMS) thread context. The thread must be terminated.
        /// </summary>
        /// <param name="UmsThread">A pointer to the UMS thread context to be deleted. The CreateUmsThreadContext function provides this pointer.If the function succeeds, it returns a nonzero value.If the function fails, the return value is zero. To get extended error information, call GetLastError.A UMS thread context cannot be deleted until the associated thread has terminated.When a UMS worker thread finishes running (for example, by returning from its thread entry point function), the system terminates the thread, sets the termination status in the thread's UMS thread context, and queues the UMS thread context to the associated completion list.Any attempt to execute the UMS thread will fail because the thread is already terminated.To check the termination status of a thread, the application's scheduler should call QueryUmsThreadInformation with the UmsIsThreadTerminated information class.CreateUmsThreadContextQueryUmsThreadInformation</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool DeleteUmsThreadContext(int UmsThread);

        /// <summary>
        ///Deletes a drive letter or mounted folder.
        /// </summary>
        /// <param name="lpszVolumeMountPoint">The drive letter or mounted folder to be deleted. A trailing backslash is required, for example, "X:" or "Y:\MountX".If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.Deleting a mounted folder does not cause the underlying directory to be deleted.If the lpszVolumeMountPoint parameter is a directory that is not a mounted folder, the function does nothing. The directory is not deleted.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB does not support volume management functions. For CsvFs, a new mount point will not be replicated to the other nodes on the cluster.For an example, see Unmounting a Volume at a Mount Point.GetVolumeNameForVolumeMountPointGetVolumePathNameMounted FoldersSetVolumeMountPointVolume Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool DeleteVolumeMountPointA(string lpszVolumeMountPoint);

        /// <summary>
        ///Retrieves user-mode scheduling (UMS) worker threads from the specified UMS completion list.
        /// </summary>
        /// <param name="UmsCompletionList">A pointer to the completion list from which to retrieve worker threads.</param>
        /// <param name="WaitTimeOut">The time-out interval for the retrieval operation, in milliseconds. The function returns if the interval elapses, even if no worker threads are queued to the completion list.If the WaitTimeOut parameter is zero, the completion list is checked for available worker threads without waiting for worker threads to become available. If the WaitTimeOut parameter is INFINITE, the function's time-out interval never elapses. This is not recommended, however, because it causes the function to block until one or more worker threads become available.</param>
        /// <param name="UmsThreadList"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError. Possible error values include the following.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool DequeueUmsCompletionListItems(int UmsCompletionList, uint WaitTimeOut, out int UmsThreadList);

        /// <summary>
        ///Closes the specified event log.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool DeregisterEventSource();

        /// <summary>
        ///Disables thread profiling.
        /// </summary>
        /// <param name="PerformanceDataHandle">The handle that the EnableThreadProfiling function returned.</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint DisableThreadProfiling(IntPtr PerformanceDataHandle);

        /// <summary>
        ///Converts a DNS-style host name to a NetBIOS-style computer name.
        /// </summary>
        /// <param name="Hostname">The DNS name. If the DNS name is not a valid, translatable name, the function fails. For more information, see Computer Names.</param>
        /// <param name="ComputerName"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError. Possible values include the following.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool DnsHostnameToComputerNameA(string Hostname, out string ComputerName);

        /// <summary>
        ///Converts a DNS-style host name to a NetBIOS-style computer name.
        /// </summary>
        /// <param name="Hostname">The DNS name. If the DNS name is not a valid, translatable name, the function fails. For more information, see Computer Names.</param>
        /// <param name="ComputerName"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError. Possible values include the following.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool DnsHostnameToComputerNameW(string Hostname, out string ComputerName);

        /// <summary>
        ///Converts MS-DOS date and time values to a file time.
        /// </summary>
        /// <param name="wFatDate">The MS-DOS date. The date is a packed value with the following format.</param>
        /// <param name="wFatTime">The MS-DOS time. The time is a packed value with the following format.</param>
        /// <param name="lpFileTime"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool DosDateTimeToFileTime(uint wFatDate, uint wFatTime, out int lpFileTime);

        /// <summary>
        ///Enables thread profiling on the specified thread.
        /// </summary>
        /// <param name="ThreadHandle">The handle to the thread on which you want to enable profiling. This must be the current thread.</param>
        /// <param name="Flags">To receive thread profiling data such as context switch count, set this parameter to THREAD_PROFILING_FLAG_DISPATCH; otherwise, set to 0.</param>
        /// <param name="HardwareCounters">To receive hardware performance counter data, set this parameter to a bitmask that identifies the hardware counters to collect. You can specify up to 16 performance counters. Each bit relates directly to the zero-based hardware counter index for the hardware performance counters that you configured. Set to zero if you are not collecting hardware counter data. If you set a bit for a hardware counter that has not been configured, the counter value that is read for that counter is zero.</param>
        /// <param name="PerformanceDataHandle"></param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint EnableThreadProfiling(IntPtr ThreadHandle, uint Flags, uint HardwareCounters, out IntPtr PerformanceDataHandle);

        /// <summary>
        ///Encrypts a file or directory. All data streams in a file are encrypted. All new files created in an encrypted directory are encrypted.
        /// </summary>
        /// <param name="lpFileName">The name of the file or directory to be encrypted.The caller must have the FILE_READ_DATA, FILE_WRITE_DATA, FILE_READ_ATTRIBUTES, FILE_WRITE_ATTRIBUTES, and SYNCHRONIZE access rights. For more information, see File Security and Access Rights.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The EncryptFile function requires exclusive access to the file being encrypted, and will fail if another process is using the file.If the file is already encrypted, EncryptFile simply returns a nonzero value, which indicates success. If the file is compressed, EncryptFile will decompress the file before encrypting it.If lpFileName specifies a read-only file, the function fails and GetLastError returns ERROR_FILE_READ_ONLY. If lpFileName specifies a directory that contains a read-only file, the functions succeeds but the directory is not encrypted.To decrypt an encrypted file, use the DecryptFile function.In Windows 8, Windows Server 2012, and later, this function is supported by the following technologies.SMB 3.0 does not support EFS on shares with continuous availability capability.DecryptFileFile EncryptionFile Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EncryptFileA(string lpFileName);

        /// <summary>
        ///Encrypts a file or directory. All data streams in a file are encrypted. All new files created in an encrypted directory are encrypted.
        /// </summary>
        /// <param name="lpFileName">The name of the file or directory to be encrypted.The caller must have the FILE_READ_DATA, FILE_WRITE_DATA, FILE_READ_ATTRIBUTES, FILE_WRITE_ATTRIBUTES, and SYNCHRONIZE access rights. For more information, see File Security and Access Rights.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The EncryptFile function requires exclusive access to the file being encrypted, and will fail if another process is using the file.If the file is already encrypted, EncryptFile simply returns a nonzero value, which indicates success. If the file is compressed, EncryptFile will decompress the file before encrypting it.If lpFileName specifies a read-only file, the function fails and GetLastError returns ERROR_FILE_READ_ONLY. If lpFileName specifies a directory that contains a read-only file, the functions succeeds but the directory is not encrypted.To decrypt an encrypted file, use the DecryptFile function.In Windows 8, Windows Server 2012, and later, this function is supported by the following technologies.SMB 3.0 does not support EFS on shares with continuous availability capability.DecryptFileFile EncryptionFile Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EncryptFileW(string lpFileName);

        /// <summary>
        ///Commits or discards changes made prior to a call to UpdateResource.
        /// </summary>
        /// <param name="hUpdate">Type: HANDLEA module handle returned by the BeginUpdateResource function, and used by UpdateResource, referencing the file to be updated.</param>
        /// <param name="fDiscard">Type: BOOLIndicates whether to write the resource updates to the file. If this parameter is TRUE, no changes are made. If it is FALSE, the changes are made: the resource updates will take effect.Type: BOOL</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EndUpdateResourceA(IntPtr hUpdate, bool fDiscard);

        /// <summary>
        ///Commits or discards changes made prior to a call to UpdateResource.
        /// </summary>
        /// <param name="hUpdate">Type: HANDLEA module handle returned by the BeginUpdateResource function, and used by UpdateResource, referencing the file to be updated.</param>
        /// <param name="fDiscard">Type: BOOLIndicates whether to write the resource updates to the file. If this parameter is TRUE, no changes are made. If it is FALSE, the changes are made: the resource updates will take effect.Type: BOOL</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EndUpdateResourceW(IntPtr hUpdate, bool fDiscard);

        /// <summary>
        ///Converts the calling thread into a user-mode scheduling (UMS) scheduler thread.
        /// </summary>
        /// <param name="SchedulerStartupInfo">A pointer to a UMS_SCHEDULER_STARTUP_INFO structure that specifies UMS attributes for the thread, including a completion list and a UmsSchedulerProc entry point function.If the function succeeds, it returns a nonzero value.If the function fails, the return value is zero. To get extended error information, call GetLastError.An application's UMS scheduler creates one UMS scheduler thread for each processor that will be used to run UMS threads. The scheduler typically sets the affinity of the scheduler thread for a single processor, effectively reserving the processor for the use of that scheduler thread. For more information about thread affinity, see Multiple Processors.When a UMS scheduler thread is created, the system calls the UmsSchedulerProc entry point function specified with the EnterUmsSchedulingMode function call. The application's scheduler is responsible for finishing any application-specific initialization of the scheduler thread and selecting a UMS worker thread to run.The application's scheduler selects a UMS worker thread to run by calling ExecuteUmsThread with the worker thread's UMS thread context. The worker thread runs until it yields control by calling UmsThreadYield, blocks, or terminates. The scheduler thread is then available to run another worker thread.A scheduler thread should continue to run until all of its worker threads reach a natural stopping point: that is, all worker threads have yielded, blocked, or terminated.ExecuteUmsThreadMultiple ProcessorsUMS_SCHEDULER_STARTUP_INFOUmsSchedulerProcUser-Mode Scheduling</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EnterUmsSchedulingMode(IntPtr SchedulerStartupInfo);

        /// <summary>
        ///Enumerates language-specific resources, of the specified type and name, associated with a binary module.
        /// </summary>
        /// <param name="hModule">Type: HMODULEThe handle to a module to be searched. Starting with Windows Vista, if this is a language-neutral Portable Executable (LN file), then appropriate .mui files (if any exist) are included in the search. If this is a specific .mui file, only that file is searched for resources.If this parameter is NULL, that is equivalent to passing in a handle to the module used to create the current process.</param>
        /// <param name="lpType">Type: LPCTSTRThe type of resource for which the language is being enumerated. Alternately, rather than a pointer, this parameter can be MAKEINTRESOURCE(ID), where ID is an integer value representing a predefined resource type. For a list of predefined resource types, see Resource Types. For more information, see the Remarks section below.</param>
        /// <param name="lpName">Type: LPCTSTRThe name of the resource for which the language is being enumerated. Alternately, rather than a pointer, this parameter can be MAKEINTRESOURCE(ID), where ID is the integer identifier of the resource. For more information, see the Remarks section below.</param>
        /// <param name="lpEnumFunc">Type: ENUMRESLANGPROCA pointer to the callback function to be called for each enumerated resource language. For more information, see EnumResLangProcA.</param>
        /// <param name="lParam">Type: LONG_PTRAn application-defined value passed to the callback function. This parameter can be used in error checking.Type: BOOL</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EnumResourceLanguagesA(IntPtr hModule, string lpType, string lpName, int lpEnumFunc, int lParam);

        /// <summary>
        ///Enumerates language-specific resources, of the specified type and name, associated with a binary module.
        /// </summary>
        /// <param name="hModule">Type: HMODULEThe handle to a module to be searched. Starting with Windows Vista, if this is a language-neutral Portable Executable (LN file), then appropriate .mui files (if any exist) are included in the search. If this is a specific .mui file, only that file is searched for resources.If this parameter is NULL, that is equivalent to passing in a handle to the module used to create the current process.</param>
        /// <param name="lpType">Type: LPCTSTRThe type of resource for which the language is being enumerated. Alternately, rather than a pointer, this parameter can be MAKEINTRESOURCE(ID), where ID is an integer value representing a predefined resource type. For a list of predefined resource types, see Resource Types. For more information, see the Remarks section below.</param>
        /// <param name="lpName">Type: LPCTSTRThe name of the resource for which the language is being enumerated. Alternately, rather than a pointer, this parameter can be MAKEINTRESOURCE(ID), where ID is the integer identifier of the resource. For more information, see the Remarks section below.</param>
        /// <param name="lpEnumFunc">Type: ENUMRESLANGPROCA pointer to the callback function to be called for each enumerated resource language. For more information, see EnumResLangProcW.</param>
        /// <param name="lParam">Type: LONG_PTRAn application-defined value passed to the callback function. This parameter can be used in error checking.Type: BOOL</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EnumResourceLanguagesW(IntPtr hModule, string lpType, string lpName, int lpEnumFunc, int lParam);

        /// <summary>
        ///Enumerates resource types within a binary module. Starting with Windows Vista, this is typically a language-neutral Portable Executable (LN file), and the enumeration also includes resources from one of the corresponding language-specific resource files (.mui files)—if one exists—that contain localizable language resources. It is also possible to use hModule to specify a .mui file, in which case only that file is searched for resource types.
        /// </summary>
        /// <param name="lpEnumFunc">Type: ENUMRESTYPEPROCA pointer to the callback function to be called for each enumerated resource type. For more information, see the EnumResTypeProc function.</param>
        /// <param name="lParam">Type: LONG_PTRAn application-defined value passed to the callback function.Type: BOOL</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EnumResourceTypesA(int lpEnumFunc, int lParam);

        /// <summary>
        ///Enumerates resource types within a binary module. Starting with Windows Vista, this is typically a language-neutral Portable Executable (LN file), and the enumeration also includes resources from one of the corresponding language-specific resource files (.mui files)—if one exists—that contain localizable language resources. It is also possible to use hModule to specify a .mui file, in which case only that file is searched for resource types.
        /// </summary>
        /// <param name="lpEnumFunc">Type: ENUMRESTYPEPROCA pointer to the callback function to be called for each enumerated resource type. For more information, see the EnumResTypeProc function.</param>
        /// <param name="lParam">Type: LONG_PTRAn application-defined value passed to the callback function.Type: BOOL</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EnumResourceTypesW(int lpEnumFunc, int lParam);

        /// <summary>
        ///The EraseTape function erases all or part of a tape.
        /// </summary>
        /// <param name="hDevice">Handle to the device where the tape is to be erased. This handle is created by using the CreateFile function.</param>
        /// <param name="dwEraseType">Erasing technique. This parameter can be one of the following values.</param>
        /// <param name="bImmediate">If this parameter is TRUE, the function returns immediately; if it is FALSE, the function does not return until the erase operation has been completed.If the function succeeds, the return value is NO_ERROR.If the function fails, it can return one of the following error codes.Some tape devices do not support certain tape operations. To determine your tape device's capabilities, see your tape device documentation and use the GetTapeParameters function.CreateFileGetTapeParameters</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint EraseTape(IntPtr hDevice, uint dwEraseType, bool bImmediate);

        /// <summary>
        ///Directs the specified communications device to perform an extended function.
        /// </summary>
        /// <param name="hFile">A handle to the communications device. The CreateFile function returns this handle.</param>
        /// <param name="dwFunc">The extended function to be performed. This parameter can be one of the following values.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.ClearCommBreakCommunications FunctionsCommunications ResourcesCreateFileSetCommBreak</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EscapeCommFunction(IntPtr hFile, uint dwFunc);

        /// <summary>
        ///Runs the specified UMS worker thread.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError. Possible error codes include the following.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ExecuteUmsThread();

        /// <summary>
        ///Transfers execution control to the debugger. The behavior of the debugger thereafter is specific to the type of debugger used.
        /// </summary>
        /// <param name="ExitCode">The error code associated with the exit.This function does not return a value.An application should only use FatalExit for debugging purposes. It should not call the function in a retail version of the application because doing so will terminate the application.Communicating with the DebuggerDebugging FunctionsFatalAppExit</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int FatalExit(uint ExitCode);

        /// <summary>
        ///Retrieves the encryption status of the specified file.
        /// </summary>
        /// <param name="lpFileName">The name of the file.</param>
        /// <param name="lpStatus"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool FileEncryptionStatusA(string lpFileName, out uint lpStatus);

        /// <summary>
        ///Retrieves the encryption status of the specified file.
        /// </summary>
        /// <param name="lpFileName">The name of the file.</param>
        /// <param name="lpStatus"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool FileEncryptionStatusW(string lpFileName, out uint lpStatus);

        /// <summary>
        ///Converts a file time to MS-DOS date and time values.
        /// </summary>
        /// <param name="lpFileTime">A pointer to a FILETIME structure containing the file time to convert to MS-DOS date and time format.</param>
        /// <param name="lpFatDate"></param>
        /// <param name="lpFatTime"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool FileTimeToDosDateTime(int lpFileTime, out short lpFatDate, out short lpFatTime);

        /// <summary>
        ///The FindActCtxSectionGuid function retrieves information on a specific GUID in the current activation context and returns a ACTCTX_SECTION_KEYED_DATA structure.
        /// </summary>
        /// <param name="dwFlags">Flags that determine how this function is to operate. Only the following flag is currently defined.</param>
        /// <param name="lpExtensionGuid">Reserved; must be null.</param>
        /// <param name="ulSectionId">Identifier of the section of the activation context in which to search for the specified GUID.The following are valid GUID section identifiers:</param>
        /// <param name="lpGuidToFind">Pointer to a GUID to be used as the search criteria.</param>
        /// <param name="ReturnedData"></param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool FindActCtxSectionGuid(uint dwFlags, int lpExtensionGuid, int ulSectionId, int lpGuidToFind, out int ReturnedData);

        /// <summary>
        ///The FindActCtxSectionString function retrieves information on a specific string in the current activation context and returns a ACTCTX_SECTION_KEYED_DATA structure.
        /// </summary>
        /// <param name="dwFlags">Flags that determine how this function is to operate. Only the following flag is currently defined.</param>
        /// <param name="lpExtensionGuid">Reserved; must be null.</param>
        /// <param name="ulSectionId">Identifier of the string section of the activation context in which to search for the specific string.The following are valid string section identifiers:</param>
        /// <param name="lpStringToFind">Pointer to a null-terminated string to be used as the search criteria.</param>
        /// <param name="ReturnedData"></param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool FindActCtxSectionStringA(uint dwFlags, int lpExtensionGuid, int ulSectionId, string lpStringToFind, out int ReturnedData);

        /// <summary>
        ///The FindActCtxSectionString function retrieves information on a specific string in the current activation context and returns a ACTCTX_SECTION_KEYED_DATA structure.
        /// </summary>
        /// <param name="dwFlags">Flags that determine how this function is to operate. Only the following flag is currently defined.</param>
        /// <param name="lpExtensionGuid">Reserved; must be null.</param>
        /// <param name="ulSectionId">Identifier of the string section of the activation context in which to search for the specific string.The following are valid string section identifiers:</param>
        /// <param name="lpStringToFind">Pointer to a null-terminated string to be used as the search criteria.</param>
        /// <param name="ReturnedData"></param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool FindActCtxSectionStringW(uint dwFlags, int lpExtensionGuid, int ulSectionId, string lpStringToFind, out int ReturnedData);

        /// <summary>
        ///Searches the local atom table for the specified character string and retrieves the atom associated with that string.
        /// </summary>
        /// <param name="lpString">Type: LPCTSTRThe character string for which to search.Alternatively, you can use an integer atom that has been converted using the MAKEINTATOM macro. See Remarks for more information.Type: ATOMIf the function succeeds, the return value is the atom associated with the given string.If the function fails, the return value is zero. To get extended error information, call GetLastError.Even though the system preserves the case of a string in an atom table, the search performed by the FindAtom function is not case sensitive.If lpString was created by the MAKEINTATOM macro, the low-order word must be in the range 0x0001 through 0xBFFF. If the low-order word is not in this range, the function fails.AddAtomDeleteAtomGlobalAddAtomGlobalDeleteAtomGlobalFindAtomReference</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int FindAtomA(string lpString);

        /// <summary>
        ///Searches the local atom table for the specified character string and retrieves the atom associated with that string.
        /// </summary>
        /// <param name="lpString">Type: LPCTSTRThe character string for which to search.Alternatively, you can use an integer atom that has been converted using the MAKEINTATOM macro. See Remarks for more information.Type: ATOMIf the function succeeds, the return value is the atom associated with the given string.If the function fails, the return value is zero. To get extended error information, call GetLastError.Even though the system preserves the case of a string in an atom table, the search performed by the FindAtom function is not case sensitive.If lpString was created by the MAKEINTATOM macro, the low-order word must be in the range 0x0001 through 0xBFFF. If the low-order word is not in this range, the function fails.AddAtomDeleteAtomGlobalAddAtomGlobalDeleteAtomGlobalFindAtomReference</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int FindAtomW(string lpString);

        /// <summary>
        ///[Microsoft strongly recommends developers utilize alternative means to achieve your application’s needs. Many scenarios that TxF was developed for can be achieved through simpler and more readily available techniques. Furthermore, TxF may not be available in future versions of Microsoft Windows. For more information, and alternatives to TxF, please see Alternatives to using Transactional NTFS.]
        /// </summary>
        /// <param name="lpFileName">The name of the file.The file must reside on the local computer; otherwise, the function fails and the last error code is set to ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE (6805).</param>
        /// <param name="dwFlags">Reserved; specify zero (0).</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr FindFirstFileNameTransactedW(string lpFileName, uint dwFlags);

        /// <summary>
        ///[Microsoft strongly recommends developers utilize alternative means to achieve your application’s needs. Many scenarios that TxF was developed for can be achieved through simpler and more readily available techniques. Furthermore, TxF may not be available in future versions of Microsoft Windows. For more information, and alternatives to TxF, please see Alternatives to using Transactional NTFS.]
        /// </summary>
        /// <param name="lpFileName">The directory or path, and the file name. The file name can include wildcard characters, for example, an asterisk (*) or a question mark (?).This parameter should not be NULL, an invalid string (for example, an empty string or a string that is missing the terminating null character), or end in a trailing backslash (\).If the string ends with a wildcard, period (.), or directory name, the user must have access to the root and all subdirectories on the path.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.The file must reside on the local computer; otherwise, the function fails and the last error code is set to ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE.</param>
        /// <param name="fInfoLevelId">The information level of the returned data.This parameter is one of the FINDEX_INFO_LEVELS enumeration values.</param>
        /// <param name="lpFindFileData"></param>
        /// <param name="fSearchOp">The type of filtering to perform that is different from wildcard matching.This parameter is one of the FINDEX_SEARCH_OPS enumeration values.lpSearchFilterA pointer to the search criteria if the specified fSearchOp needs structured search information.At this time, none of the supported fSearchOp values require extended search information. Therefore, this pointer must be NULL.</param>
        /// <param name="dwAdditionalFlags">Specifies additional flags that control the search.</param>
        /// <param name="hTransaction">A handle to the transaction. This handle is returned by the CreateTransaction function.If the function succeeds, the return value is a search handle used in a subsequent call to FindNextFile or FindClose, and the lpFindFileData parameter contains information about the first file or directory found.If the function fails or fails to locate files from the search string in the lpFileName parameter, the return value is INVALID_HANDLE_VALUE and the contents of lpFindFileData are indeterminate. To get extended error information, call the GetLastError function.The FindFirstFileTransacted function opens a search handle and returns information about the first file that the file system finds with a name that matches the specified pattern. This may or may not be the first file or directory that appears in a directory-listing application (such as the dir command) when given the same file name string pattern. This is because FindFirstFileTransacted does no sorting of the search results. For additional information, see FindNextFile.The following list identifies some other search characteristics:After the search handle is established, use it in the FindNextFile function to search for other files that match the same pattern with the same filtering that is being performed. When the search handle is not needed, it should be closed by using the FindClose function.As stated previously, you cannot use a trailing backslash (\) in the lpFileName input string for FindFirstFileTransacted, therefore it may not be obvious how to search root directories. If you want to see files or get the attributes of a root directory, the following options would apply:On network shares, you can use an lpFileName in the form of the following: "\\server\service*". However, you cannot use an lpFileName that points to the share itself; for example, "\\server\service" is not valid.To examine a directory that is not a root directory, use the path to that directory, without a trailing backslash. For example, an argument of "C:\Windows" returns information about the directory "C:\Windows", not about a directory or file in "C:\Windows". To examine the files and directories in "C:\Windows", use an lpFileName of "C:\Windows\*".Be aware that some other thread or process could create or delete a file with this name between the time you query for the result and the time you act on the information. If this is a potential concern for your application, one possible solution is to use the CreateFile function with CREATE_NEW (which fails if the file exists) or OPEN_EXISTING (which fails if the file does not exist).If you are writing a 32-bit application to list all the files in a directory and the application may be run on a 64-bit computer, you should call Wow64DisableWow64FsRedirection before calling FindFirstFileTransacted and call Wow64RevertWow64FsRedirection after the last call to FindNextFile. For more information, see File System Redirector.If the path points to a symbolic link, the WIN32_FIND_DATA buffer contains information about the symbolic link, not the target.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB 3.0 does not support TxF.File Management FunctionsFindCloseFindNextFileGetFileAttributesSetFileAttributesSymbolic LinksTransactional NTFSWIN32_FIND_DATA</param>
        /// <remarks>
        /// To get extended error information, call the GetLastError function.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr FindFirstFileTransactedA(string lpFileName, int fInfoLevelId, out IntPtr lpFindFileData, IntPtr fSearchOp, uint dwAdditionalFlags, IntPtr hTransaction);

        /// <summary>
        ///[Microsoft strongly recommends developers utilize alternative means to achieve your application’s needs. Many scenarios that TxF was developed for can be achieved through simpler and more readily available techniques. Furthermore, TxF may not be available in future versions of Microsoft Windows. For more information, and alternatives to TxF, please see Alternatives to using Transactional NTFS.]
        /// </summary>
        /// <param name="lpFileName">The directory or path, and the file name. The file name can include wildcard characters, for example, an asterisk (*) or a question mark (?).This parameter should not be NULL, an invalid string (for example, an empty string or a string that is missing the terminating null character), or end in a trailing backslash (\).If the string ends with a wildcard, period (.), or directory name, the user must have access to the root and all subdirectories on the path.The file must reside on the local computer; otherwise, the function fails and the last error code is set to ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="fInfoLevelId">The information level of the returned data.This parameter is one of the FINDEX_INFO_LEVELS enumeration values.</param>
        /// <param name="lpFindFileData"></param>
        /// <param name="fSearchOp">The type of filtering to perform that is different from wildcard matching.This parameter is one of the FINDEX_SEARCH_OPS enumeration values.lpSearchFilterA pointer to the search criteria if the specified fSearchOp needs structured search information.At this time, none of the supported fSearchOp values require extended search information. Therefore, this pointer must be NULL.</param>
        /// <param name="dwAdditionalFlags">Specifies additional flags that control the search.</param>
        /// <param name="hTransaction">A handle to the transaction. This handle is returned by the CreateTransaction function.If the function succeeds, the return value is a search handle used in a subsequent call to FindNextFile or FindClose, and the lpFindFileData parameter contains information about the first file or directory found.If the function fails or fails to locate files from the search string in the lpFileName parameter, the return value is INVALID_HANDLE_VALUE and the contents of lpFindFileData are indeterminate. To get extended error information, call the GetLastError function.The FindFirstFileTransacted function opens a search handle and returns information about the first file that the file system finds with a name that matches the specified pattern. This may or may not be the first file or directory that appears in a directory-listing application (such as the dir command) when given the same file name string pattern. This is because FindFirstFileTransacted does no sorting of the search results. For additional information, see FindNextFile.The following list identifies some other search characteristics:After the search handle is established, use it in the FindNextFile function to search for other files that match the same pattern with the same filtering that is being performed. When the search handle is not needed, it should be closed by using the FindClose function.As stated previously, you cannot use a trailing backslash (\) in the lpFileName input string for FindFirstFileTransacted, therefore it may not be obvious how to search root directories. If you want to see files or get the attributes of a root directory, the following options would apply:On network shares, you can use an lpFileName in the form of the following: "\\server\service*". However, you cannot use an lpFileName that points to the share itself; for example, "\\server\service" is not valid.To examine a directory that is not a root directory, use the path to that directory, without a trailing backslash. For example, an argument of "C:\Windows" returns information about the directory "C:\Windows", not about a directory or file in "C:\Windows". To examine the files and directories in "C:\Windows", use an lpFileName of "C:\Windows\*".Be aware that some other thread or process could create or delete a file with this name between the time you query for the result and the time you act on the information. If this is a potential concern for your application, one possible solution is to use the CreateFile function with CREATE_NEW (which fails if the file exists) or OPEN_EXISTING (which fails if the file does not exist).If you are writing a 32-bit application to list all the files in a directory and the application may be run on a 64-bit computer, you should call Wow64DisableWow64FsRedirection before calling FindFirstFileTransacted and call Wow64RevertWow64FsRedirection after the last call to FindNextFile. For more information, see File System Redirector.If the path points to a symbolic link, the WIN32_FIND_DATA buffer contains information about the symbolic link, not the target.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB 3.0 does not support TxF.File Management FunctionsFindCloseFindNextFileGetFileAttributesSetFileAttributesSymbolic LinksTransactional NTFSWIN32_FIND_DATA</param>
        /// <remarks>
        /// To get extended error information, call the GetLastError function.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr FindFirstFileTransactedW(string lpFileName, int fInfoLevelId, out IntPtr lpFindFileData, IntPtr fSearchOp, uint dwAdditionalFlags, IntPtr hTransaction);

        /// <summary>
        ///[Microsoft strongly recommends developers utilize alternative means to achieve your application’s needs. Many scenarios that TxF was developed for can be achieved through simpler and more readily available techniques. Furthermore, TxF may not be available in future versions of Microsoft Windows. For more information, and alternatives to TxF, please see Alternatives to using Transactional NTFS.]
        /// </summary>
        /// <param name="lpFileName">The fully qualified file name.The file must reside on the local computer; otherwise, the function fails and the last error code is set to ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE (6805).</param>
        /// <param name="InfoLevel">The information level of the returned data. This parameter is one of the values in the STREAM_INFO_LEVELS enumeration type.</param>
        /// <param name="lpFindStreamData"></param>
        /// <param name="hTransaction">A handle to the transaction. This handle is returned by the CreateTransaction function.If the function succeeds, the return value is a search handle that can be used in subsequent calls to the FindNextStreamW function.If the function fails, the return value is INVALID_HANDLE_VALUE. To get extended error information, call GetLastError.All files contain a default data stream. On NTFS, files can also contain one or more named data streams. On FAT file systems, files cannot have more that the default data stream, and therefore, this function will not return valid results when used on FAT filesystem files. This function works on all file systems that supports hard links; otherwise, the function returns ERROR_STATUS_NOT_IMPLEMENTED (6805).The FindFirstStreamTransactedW function opens a search handle and returns information about the first stream in the specified file or directory. For files, this is always the default data stream, ::$DATA. After the search handle has been established, use it in the FindNextStreamW function to search for other streams in the specified file or directory. When the search handle is no longer needed, it should be closed using the FindClose function.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB 3.0 does not support TxF.File Management FunctionsFindCloseFindNextStreamWSTREAM_INFO_LEVELSTransactional NTFSWIN32_FIND_STREAM_DATA</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr FindFirstStreamTransactedW(string lpFileName, int InfoLevel, out IntPtr lpFindStreamData, IntPtr hTransaction);

        /// <summary>
        ///Retrieves the name of a volume on a computer. FindFirstVolume is used to begin scanning the volumes of a computer.
        /// </summary>
        /// <param name="lpszVolumeName"></param>
        /// <param name="cchBufferLength">The length of the buffer to receive the volume GUID path, in TCHARs.If the function succeeds, the return value is a search handle used in a subsequent call to the FindNextVolume and FindVolumeClose functions.If the function fails to find any volumes, the return value is the INVALID_HANDLE_VALUE error code. To get extended error information, call GetLastError.The FindFirstVolume function opens a volume search handle and returns information about the first volume found on a computer. After the search handle is established, you can use the FindNextVolume function to search for other volumes. When the search handle is no longer needed, close it by using the FindVolumeClose function.You should not assume any correlation between the order of the volumes that are returned by these functions and the order of the volumes that are on the computer. In particular, do not assume any correlation between volume order and drive letters as assigned by the BIOS (if any) or the Disk Administrator.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB does not support volume management functions.For an example, see Displaying Volume Paths.FindNextVolumeFindVolumeCloseMounted FoldersVolume Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr FindFirstVolumeA(out string lpszVolumeName, uint cchBufferLength);

        /// <summary>
        ///Retrieves the name of a mounted folder on the specified volume. FindFirstVolumeMountPoint is used to begin scanning the mounted folders on a volume.
        /// </summary>
        /// <param name="lpszRootPathName">A volume GUID path for the volume to scan for mounted folders. A trailing backslash is required.</param>
        /// <param name="lpszVolumeMountPoint"></param>
        /// <param name="cchBufferLength">The length of the buffer that receives the path to the mounted folder, in TCHARs.If the function succeeds, the return value is a search handle used in a subsequent call to the FindNextVolumeMountPoint and FindVolumeMountPointClose functions.If the function fails to find a mounted folder on the volume, the return value is the INVALID_HANDLE_VALUE error code. To get extended error information, call GetLastError.The FindFirstVolumeMountPoint function opens a mounted folder search handle and returns information about the first mounted folder that is found on the specified volume. After the search handle is established, you can use the FindNextVolumeMountPoint function to search for other mounted folders. When the search handle is no longer needed, close it with the FindVolumeMountPointClose function.The FindFirstVolumeMountPoint, FindNextVolumeMountPoint, and FindVolumeMountPointClose functions return paths to mounted folders for a specified volume. They do not return drive letters or volume GUID paths. For information about enumerating the volume GUID paths for a volume, see Enumerating Volume GUID Paths.You should not assume any correlation between the order of the mounted folders that are returned by these functions and the order of the mounted folders that are returned by other functions or tools.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB does not support volume management functions. CsvFS does not support adding mount point on a CSV volume. ReFS does not index mount points.FindNextVolumeMountPointFindVolumeMountPointCloseMounted FoldersVolume Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr FindFirstVolumeMountPointA(string lpszRootPathName, out string lpszVolumeMountPoint, uint cchBufferLength);

        /// <summary>
        ///Retrieves the name of a mounted folder on the specified volume. FindFirstVolumeMountPoint is used to begin scanning the mounted folders on a volume.
        /// </summary>
        /// <param name="lpszRootPathName">A volume GUID path for the volume to scan for mounted folders. A trailing backslash is required.</param>
        /// <param name="lpszVolumeMountPoint"></param>
        /// <param name="cchBufferLength">The length of the buffer that receives the path to the mounted folder, in TCHARs.If the function succeeds, the return value is a search handle used in a subsequent call to the FindNextVolumeMountPoint and FindVolumeMountPointClose functions.If the function fails to find a mounted folder on the volume, the return value is the INVALID_HANDLE_VALUE error code. To get extended error information, call GetLastError.The FindFirstVolumeMountPoint function opens a mounted folder search handle and returns information about the first mounted folder that is found on the specified volume. After the search handle is established, you can use the FindNextVolumeMountPoint function to search for other mounted folders. When the search handle is no longer needed, close it with the FindVolumeMountPointClose function.The FindFirstVolumeMountPoint, FindNextVolumeMountPoint, and FindVolumeMountPointClose functions return paths to mounted folders for a specified volume. They do not return drive letters or volume GUID paths. For information about enumerating the volume GUID paths for a volume, see Enumerating Volume GUID Paths.You should not assume any correlation between the order of the mounted folders that are returned by these functions and the order of the mounted folders that are returned by other functions or tools.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB does not support volume management functions. CsvFS does not support adding mount point on a CSV volume. ReFS does not index mount points.FindNextVolumeMountPointFindVolumeMountPointCloseMounted FoldersVolume Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr FindFirstVolumeMountPointW(string lpszRootPathName, out string lpszVolumeMountPoint, uint cchBufferLength);

        /// <summary>
        ///Continues a volume search started by a call to the FindFirstVolume function. FindNextVolume finds one volume per call.
        /// </summary>
        /// <param name="hFindVolume">The volume search handle returned by a previous call to the FindFirstVolume function.</param>
        /// <param name="lpszVolumeName"></param>
        /// <param name="cchBufferLength">The length of the buffer that receives the volume GUID path, in TCHARs.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError. If no matching files can be found, the GetLastError function returns the ERROR_NO_MORE_FILES error code. In that case, close the search with the FindVolumeClose function.After the search handle is established by calling FindFirstVolume, you can use the FindNextVolume function to search for other volumes.You should not assume any correlation between the order of the volumes that are returned by these functions and the order of the volumes that are on the computer. In particular, do not assume any correlation between volume order and drive letters as assigned by the BIOS (if any) or the Disk Administrator.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB does not support volume management functions.For an example, see Displaying Volume Paths.FindFirstVolumeFindVolumeCloseMounted FoldersVolume Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError. If no matching files can be found, the GetLastError function returns the ERROR_NO_MORE_FILES error code. In that case, close the search with the FindVolumeClose function.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool FindNextVolumeA(IntPtr hFindVolume, out string lpszVolumeName, uint cchBufferLength);

        /// <summary>
        ///Continues a mounted folder search started by a call to the FindFirstVolumeMountPoint function. FindNextVolumeMountPoint finds one mounted folder per call.
        /// </summary>
        /// <param name="hFindVolumeMountPoint">A mounted folder search handle returned by a previous call to the FindFirstVolumeMountPoint function.</param>
        /// <param name="lpszVolumeMountPoint"></param>
        /// <param name="cchBufferLength">The length of the buffer that receives the mounted folder name, in TCHARs.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError. If no more mounted folders can be found, the GetLastError function returns the ERROR_NO_MORE_FILES error code. In that case, close the search with the FindVolumeMountPointClose function.After the search handle is established by calling FindFirstVolumeMountPoint, you can use the FindNextVolumeMountPoint function to search for other mounted folders.The FindFirstVolumeMountPoint, FindNextVolumeMountPoint, and FindVolumeMountPointClose functions return paths to mounted folders for a specified volume. They do not return drive letters or volume GUID paths. For information about enumerating the volume GUID paths for a volume, see Enumerating Volume GUID Paths.You should not assume any correlation between the order of the mounted folders that are returned with these functions and the order of the mounted folders that are returned by other functions or tools.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB does not support volume management functions. CsvFS does not support adding mount point on a CSV volume. ReFS does not index mount points.FindFirstVolumeMountPointFindVolumeMountPointCloseMounted FoldersVolume Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError. If no more mounted folders can be found, the GetLastError function returns the ERROR_NO_MORE_FILES error code. In that case, close the search with the FindVolumeMountPointClose function.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool FindNextVolumeMountPointA(IntPtr hFindVolumeMountPoint, out string lpszVolumeMountPoint, uint cchBufferLength);

        /// <summary>
        ///Continues a mounted folder search started by a call to the FindFirstVolumeMountPoint function. FindNextVolumeMountPoint finds one mounted folder per call.
        /// </summary>
        /// <param name="hFindVolumeMountPoint">A mounted folder search handle returned by a previous call to the FindFirstVolumeMountPoint function.</param>
        /// <param name="lpszVolumeMountPoint"></param>
        /// <param name="cchBufferLength">The length of the buffer that receives the mounted folder name, in TCHARs.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError. If no more mounted folders can be found, the GetLastError function returns the ERROR_NO_MORE_FILES error code. In that case, close the search with the FindVolumeMountPointClose function.After the search handle is established by calling FindFirstVolumeMountPoint, you can use the FindNextVolumeMountPoint function to search for other mounted folders.The FindFirstVolumeMountPoint, FindNextVolumeMountPoint, and FindVolumeMountPointClose functions return paths to mounted folders for a specified volume. They do not return drive letters or volume GUID paths. For information about enumerating the volume GUID paths for a volume, see Enumerating Volume GUID Paths.You should not assume any correlation between the order of the mounted folders that are returned with these functions and the order of the mounted folders that are returned by other functions or tools.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB does not support volume management functions. CsvFS does not support adding mount point on a CSV volume. ReFS does not index mount points.FindFirstVolumeMountPointFindVolumeMountPointCloseMounted FoldersVolume Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError. If no more mounted folders can be found, the GetLastError function returns the ERROR_NO_MORE_FILES error code. In that case, close the search with the FindVolumeMountPointClose function.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool FindNextVolumeMountPointW(IntPtr hFindVolumeMountPoint, out string lpszVolumeMountPoint, uint cchBufferLength);

        /// <summary>
        ///Determines the location of a resource with the specified type and name in the specified module.
        /// </summary>
        /// <param name="lpName">Type: LPCTSTRThe name of the resource. Alternately, rather than a pointer, this parameter can be MAKEINTRESOURCE(ID), where ID is the integer identifier of the resource. For more information, see the Remarks section below.</param>
        /// <param name="lpType">Type: LPCTSTRThe resource type. Alternately, rather than a pointer, this parameter can be MAKEINTRESOURCE(ID), where ID is the integer identifier of the given resource type. For standard resource types, see Resource Types. For more information, see the Remarks section below.Type: HRSRCIf the function succeeds, the return value is a handle to the specified resource's information block. To obtain a handle to the resource, pass this handle to the LoadResource function.If the function fails, the return value is NULL. To get extended error information, call GetLastError.If IS_INTRESOURCE is TRUE for x = lpName or lpType, x specifies the integer identifier of the name or type of the given resource. Otherwise, those parameters are long pointers to null-terminated strings. If the first character of the string is a pound sign (#), the remaining characters represent a decimal number that specifies the integer identifier of the resource's name or type. For example, the string "#258" represents the integer identifier 258.To reduce the amount of memory required for a resource, an application should refer to it by integer identifier instead of by name.An application can use FindResource to find any type of resource, but this function should be used only if the application must access the binary resource data by making subsequent calls to LoadResource and then to LockResource.To use a resource immediately, an application should use one of the following resource-specific functions to find the resource and convert the data into a more usable form.For example, an application can use the LoadIcon function to load an icon for display on the screen. However, the application should use FindResource and LoadResource if it is loading the icon to copy its data to another application.String resources are stored in sections of up to 16 strings per section. The strings in each section are stored as a sequence of counted (not necessarily null-terminated) Unicode strings. The LoadString function will extract the string resource from its corresponding section.For an example, see Updating Resources.ConceptualFindResourceExFormatMessageIS_INTRESOURCELoadAcceleratorsLoadBitmapLoadCursorLoadIconLoadMenuLoadResourceLoadStringLockResourceOther ResourcesReferenceResourcesSizeofResource</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr FindResourceA(string lpName, string lpType);

        /// <summary>
        ///Determines the location of the resource with the specified type, name, and language in the specified module.
        /// </summary>
        /// <param name="lpType">Type: LPCTSTRThe resource type. Alternately, rather than a pointer, this parameter can be MAKEINTRESOURCE(ID), where ID is the integer identifier of the givenresource type. For standard resource types, see Resource Types. For more information, see the Remarks section below.</param>
        /// <param name="lpName">Type: LPCTSTRThe name of the resource. Alternately, rather than a pointer, this parameter can be MAKEINTRESOURCE(ID), where ID is the integer identifier of the resource. For more information, see the Remarks section below.</param>
        /// <param name="wLanguage">Type: WORDThe language of the resource. If this parameter is MAKELANGID(LANG_NEUTRAL, SUBLANG_NEUTRAL), the current language associated with the calling thread is used.To specify a language other than the current language, use the MAKELANGID macro to create this parameter. For more information, see MAKELANGID.Type: HRSRCIf the function succeeds, the return value is a handle to the specified resource's information block. To obtain a handle to the resource, pass this handle to the LoadResource function.If the function fails, the return value is NULL. To get extended error information, call GetLastError.If IS_INTRESOURCE is TRUE for x = lpType or lpName, x specifies the integer identifier of the type or name of the given resource. Otherwise, those parameters are long pointers to null-terminated strings. If the first character of the string is a pound sign (#), the remaining characters represent a decimal number that specifies the integer identifier of the resource's name or type. For example, the string "#258" represents the integer identifier 258.To reduce the amount of memory required for a resource, an application should refer to it by integer identifier instead of by name.An application can use FindResourceEx to find any type of resource, but this function should be used only if the application must access the binary resource data by making subsequent calls to LoadResource and then to LockResource.To use a resource immediately, an application should use one of the following resource-specific functions to find the resource and convert the data into a more usable form.For example, an application can use the LoadIcon function to load an icon for display on the screen. However, the application should use FindResourceEx and LoadResource if it is loading the icon to copy its data to another application.String resources are stored in sections of up to 16 strings per section. The strings in each section are stored as a sequence of counted (not necessarily null-terminated) Unicode strings. The LoadString function will extract the string resource from its corresponding section.For an example, see Creating a Resource List.ConceptualFindResourceFormatMessageIS_INTRESOURCELoadAcceleratorsLoadBitmapLoadCursorLoadIconLoadMenuLoadResourceLoadStringMAKELANGIDOther ResourcesReferenceResources</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr FindResourceExA(string lpType, string lpName, uint wLanguage);

        /// <summary>
        ///Closes the specified mounted folder search handle. The FindFirstVolumeMountPoint and FindNextVolumeMountPoint functions use this search handle to locate mounted folders on a specified volume.
        /// </summary>
        /// <param name="hFindVolumeMountPoint">The mounted folder search handle to be closed. This handle must have been previously opened by the FindFirstVolumeMountPoint function.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.After the FindVolumeMountPointClose function is called, the handle hFindVolumeMountPoint cannot be used in subsequent calls to either FindNextVolumeMountPoint or FindVolumeMountPointClose.The FindFirstVolumeMountPoint, FindNextVolumeMountPoint, and FindVolumeMountPointClose functions return paths to mounted folders for a specified volume. They do not return drive letters or volume GUID paths. For information about enumerating the volume GUID paths for a volume, see Enumerating Volume GUID Paths.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB does not support volume management functions. CsvFS does not support adding mount point on a CSV volume.FindFirstVolumeMountPointFindNextVolumeMountPointMounted FoldersVolume Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool FindVolumeMountPointClose(IntPtr hFindVolumeMountPoint);

        /// <summary>
        ///Formats a message string. The function requires a message definition as input. The message definition can come from a buffer passed into the function. It can come from a message table resource in an already-loaded module. Or the caller can ask the function to search the system's message table resource(s) for the message definition. The function finds the message definition in a message table resource based on a message identifier and a language identifier. The function copies the formatted message text to an output buffer, processing any embedded insert sequences if requested.
        /// </summary>
        /// <param name="dwFlags">The formatting options, and how to interpret the lpSource parameter. The low-order byte of dwFlags specifies how the function handles line breaks in the output buffer. The low-order byte can also specify the maximum width of a formatted output line.This parameter can be one or more of the following values.The low-order byte of dwFlags can specify the maximum width of a formatted output line. The following are possible values of the low-order byte.If the low-order byte is a nonzero value other than FORMAT_MESSAGE_MAX_WIDTH_MASK, it specifies the maximum number of characters in an output line. The function ignores regular line breaks in the message definition text. The function never splits a string delimited by white space across a line break. The function stores hard-coded line breaks in the message definition text into the output buffer. Hard-coded line breaks are coded with the %n escape sequence.</param>
        /// <param name="dwMessageId">The message identifier for the requested message. This parameter is ignored if dwFlags includes FORMAT_MESSAGE_FROM_STRING.</param>
        /// <param name="dwLanguageId">The language identifier for the requested message. This parameter is ignored if dwFlags includes FORMAT_MESSAGE_FROM_STRING.If you pass a specific LANGID in this parameter, FormatMessage will return a message for that LANGID only. If the function cannot find a message for that LANGID, it sets Last-Error to ERROR_RESOURCE_LANG_NOT_FOUND. If you pass in zero, FormatMessage looks for a message for LANGIDs in the following order:</param>
        /// <param name="lpBuffer"></param>
        /// <param name="nSize">If the FORMAT_MESSAGE_ALLOCATE_BUFFER flag is not set, this parameter specifies the size of the output buffer, in TCHARs. If FORMAT_MESSAGE_ALLOCATE_BUFFER is set, this parameter specifies the minimum number of TCHARs to allocate for an output buffer.The output buffer cannot be larger than 64K bytes.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint FormatMessage(uint dwFlags, uint dwMessageId, uint dwLanguageId, out int lpBuffer, uint nSize);

        /// <summary>
        ///Formats a message string. The function requires a message definition as input. The message definition can come from a buffer passed into the function. It can come from a message table resource in an already-loaded module. Or the caller can ask the function to search the system's message table resource(s) for the message definition. The function finds the message definition in a message table resource based on a message identifier and a language identifier. The function copies the formatted message text to an output buffer, processing any embedded insert sequences if requested.
        /// </summary>
        /// <param name="dwFlags">The formatting options, and how to interpret the lpSource parameter. The low-order byte of dwFlags specifies how the function handles line breaks in the output buffer. The low-order byte can also specify the maximum width of a formatted output line.This parameter can be one or more of the following values.The low-order byte of dwFlags can specify the maximum width of a formatted output line. The following are possible values of the low-order byte.If the low-order byte is a nonzero value other than FORMAT_MESSAGE_MAX_WIDTH_MASK, it specifies the maximum number of characters in an output line. The function ignores regular line breaks in the message definition text. The function never splits a string delimited by white space across a line break. The function stores hard-coded line breaks in the message definition text into the output buffer. Hard-coded line breaks are coded with the %n escape sequence.</param>
        /// <param name="dwMessageId">The message identifier for the requested message. This parameter is ignored if dwFlags includes FORMAT_MESSAGE_FROM_STRING.</param>
        /// <param name="dwLanguageId">The language identifier for the requested message. This parameter is ignored if dwFlags includes FORMAT_MESSAGE_FROM_STRING.If you pass a specific LANGID in this parameter, FormatMessage will return a message for that LANGID only. If the function cannot find a message for that LANGID, it sets Last-Error to ERROR_RESOURCE_LANG_NOT_FOUND. If you pass in zero, FormatMessage looks for a message for LANGIDs in the following order:</param>
        /// <param name="lpBuffer"></param>
        /// <param name="nSize">If the FORMAT_MESSAGE_ALLOCATE_BUFFER flag is not set, this parameter specifies the size of the output buffer, in TCHARs. If FORMAT_MESSAGE_ALLOCATE_BUFFER is set, this parameter specifies the minimum number of TCHARs to allocate for an output buffer.The output buffer cannot be larger than 64K bytes.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint FormatMessageA(uint dwFlags, uint dwMessageId, uint dwLanguageId, out string lpBuffer, uint nSize);

        /// <summary>
        ///Formats a message string. The function requires a message definition as input. The message definition can come from a buffer passed into the function. It can come from a message table resource in an already-loaded module. Or the caller can ask the function to search the system's message table resource(s) for the message definition. The function finds the message definition in a message table resource based on a message identifier and a language identifier. The function copies the formatted message text to an output buffer, processing any embedded insert sequences if requested.
        /// </summary>
        /// <param name="dwFlags">The formatting options, and how to interpret the lpSource parameter. The low-order byte of dwFlags specifies how the function handles line breaks in the output buffer. The low-order byte can also specify the maximum width of a formatted output line.This parameter can be one or more of the following values.The low-order byte of dwFlags can specify the maximum width of a formatted output line. The following are possible values of the low-order byte.If the low-order byte is a nonzero value other than FORMAT_MESSAGE_MAX_WIDTH_MASK, it specifies the maximum number of characters in an output line. The function ignores regular line breaks in the message definition text. The function never splits a string delimited by white space across a line break. The function stores hard-coded line breaks in the message definition text into the output buffer. Hard-coded line breaks are coded with the %n escape sequence.</param>
        /// <param name="dwMessageId">The message identifier for the requested message. This parameter is ignored if dwFlags includes FORMAT_MESSAGE_FROM_STRING.</param>
        /// <param name="dwLanguageId">The language identifier for the requested message. This parameter is ignored if dwFlags includes FORMAT_MESSAGE_FROM_STRING.If you pass a specific LANGID in this parameter, FormatMessage will return a message for that LANGID only. If the function cannot find a message for that LANGID, it sets Last-Error to ERROR_RESOURCE_LANG_NOT_FOUND. If you pass in zero, FormatMessage looks for a message for LANGIDs in the following order:</param>
        /// <param name="lpBuffer"></param>
        /// <param name="nSize">If the FORMAT_MESSAGE_ALLOCATE_BUFFER flag is not set, this parameter specifies the size of the output buffer, in TCHARs. If FORMAT_MESSAGE_ALLOCATE_BUFFER is set, this parameter specifies the minimum number of TCHARs to allocate for an output buffer.The output buffer cannot be larger than 64K bytes.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint FormatMessageW(uint dwFlags, uint dwMessageId, uint dwLanguageId, out string lpBuffer, uint nSize);

        /// <summary>
        ///Returns the number of active processors in a processor group or in the system.
        /// </summary>
        /// <param name="GroupNumber">The processor group number. If this parameter is ALL_PROCESSOR_GROUPS, the function returns the number of active processors in the system.If the function succeeds, the return value is the number of active processors in the specified group.If the function fails, the return value is zero. To get extended error information, use GetLastError.To compile an application that uses this function, set _WIN32_WINNT >= 0x0601. For more information, see Using the Windows Headers.</param>
        /// <remarks>
        /// To get extended error information, use GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetActiveProcessorCount(uint GroupNumber);

        /// <summary>
        ///Returns the number of active processor groups in the system.
        /// </summary>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetActiveProcessorGroupCount();

        /// <summary>
        ///Retrieves a pointer to the callback routine registered for the specified process. The address returned is in the virtual address space of the process.
        /// </summary>
        /// <param name="hProcess">A handle to the process. This handle must have the PROCESS_VM_READ access right.</param>
        /// <param name="pRecoveryCallback"></param>
        /// <param name="ppvParameter"></param>
        /// <param name="pdwPingInterval"></param>
        /// <param name="pdwFlags"></param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr GetApplicationRecoveryCallback(IntPtr hProcess, out int pRecoveryCallback, out IntPtr ppvParameter, out uint pdwPingInterval, out uint pdwFlags);

        /// <summary>
        ///Retrieves the restart information registered for the specified process.
        /// </summary>
        /// <param name="hProcess">A handle to the process. This handle must have the PROCESS_VM_READ access right.</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr GetApplicationRestartSettings(IntPtr hProcess);

        /// <summary>
        ///Retrieves a copy of the character string associated with the specified local atom.
        /// </summary>
        /// <param name="nAtom">Type: ATOMThe local atom that identifies the character string to be retrieved.</param>
        /// <param name="lpBuffer"></param>
        /// <param name="nSize">Type: intThe size, in characters, of the buffer.Type: UINTIf the function succeeds, the return value is the length of the string copied to the buffer, in characters, not including the terminating null character.If the function fails, the return value is zero. To get extended error information, call GetLastError.The string returned for an integer atom (an atom whose value is in the range 0x0001 to 0xBFFF) is a null-terminated string in which the first character is a pound sign (#) and the remaining characters represent the unsigned integer atom value.AddAtomDeleteAtomFindAtomGlobalAddAtomGlobalDeleteAtomGlobalFindAtomGlobalGetAtomNameMAKEINTATOMReference</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetAtomNameA(int nAtom, out string lpBuffer, uint nSize);

        /// <summary>
        ///Retrieves a copy of the character string associated with the specified local atom.
        /// </summary>
        /// <param name="nAtom">Type: ATOMThe local atom that identifies the character string to be retrieved.</param>
        /// <param name="lpBuffer"></param>
        /// <param name="nSize">Type: intThe size, in characters, of the buffer.Type: UINTIf the function succeeds, the return value is the length of the string copied to the buffer, in characters, not including the terminating null character.If the function fails, the return value is zero. To get extended error information, call GetLastError.The string returned for an integer atom (an atom whose value is in the range 0x0001 to 0xBFFF) is a null-terminated string in which the first character is a pound sign (#) and the remaining characters represent the unsigned integer atom value.AddAtomDeleteAtomFindAtomGlobalAddAtomGlobalDeleteAtomGlobalFindAtomGlobalGetAtomNameMAKEINTATOMReference</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetAtomNameW(int nAtom, out string lpBuffer, uint nSize);

        /// <summary>
        ///Determines whether a file is an executable (.exe) file, and if so, which subsystem runs the executable file.
        /// </summary>
        /// <param name="lpApplicationName">The full path of the file whose executable type is to be determined.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="lpBinaryType"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError. If the file is a DLL, the last error code is ERROR_BAD_EXE_FORMAT.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetBinaryTypeA(string lpApplicationName, out uint lpBinaryType);

        /// <summary>
        ///Determines whether a file is an executable (.exe) file, and if so, which subsystem runs the executable file.
        /// </summary>
        /// <param name="lpApplicationName">The full path of the file whose executable type is to be determined.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="lpBinaryType"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError. If the file is a DLL, the last error code is ERROR_BAD_EXE_FORMAT.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetBinaryTypeW(string lpApplicationName, out uint lpBinaryType);

        /// <summary>
        ///Retrieves the current configuration of a communications device.
        /// </summary>
        /// <param name="hCommDev">A handle to the open communications device. The CreateFile function returns this handle.</param>
        /// <param name="lpCC"></param>
        /// <remarks>
        /// To get extended error information, use the GetLastError function.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetCommConfig(IntPtr hCommDev, out int lpCC);

        /// <summary>
        ///Retrieves the value of the event mask for a specified communications device.
        /// </summary>
        /// <param name="hFile">A handle to the communications device. The CreateFile function returns this handle.</param>
        /// <param name="lpEvtMask"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetCommMask(IntPtr hFile, out uint lpEvtMask);

        /// <summary>
        ///Retrieves the modem control-register values.
        /// </summary>
        /// <param name="hFile">A handle to the communications device. The CreateFile function returns this handle.</param>
        /// <param name="lpModemStat"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetCommModemStatus(IntPtr hFile, out uint lpModemStat);

        /// <summary>
        ///Gets an array that contains the well-formed COM ports.
        /// </summary>
        /// <param name="lpPortNumbers"></param>
        /// <param name="uPortNumbersCount">The length of the array in the lpPortNumbers parameter.</param>
        /// <param name="puPortNumbersFound"></param>

        [DllImport("KernelBase.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetCommPorts(out int lpPortNumbers, int uPortNumbersCount, out int puPortNumbersFound);

        /// <summary>
        ///Retrieves information about the communications properties for a specified communications device.
        /// </summary>
        /// <param name="hFile">A handle to the communications device. The CreateFile function returns this handle.</param>
        /// <param name="lpCommProp"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetCommProperties(IntPtr hFile, out int lpCommProp);

        /// <summary>
        ///Retrieves the current control settings for a specified communications device.
        /// </summary>
        /// <param name="hFile">A handle to the communications device. The CreateFile function returns this handle.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetCommState(IntPtr hFile);

        /// <summary>
        ///Retrieves the time-out parameters for all read and write operations on a specified communications device.
        /// </summary>
        /// <param name="hFile">A handle to the communications device. The CreateFile function returns this handle.</param>
        /// <param name="lpCommTimeouts"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetCommTimeouts(IntPtr hFile, out int lpCommTimeouts);

        /// <summary>
        ///[Microsoft strongly recommends developers utilize alternative means to achieve your application’s needs. Many scenarios that TxF was developed for can be achieved through simpler and more readily available techniques. Furthermore, TxF may not be available in future versions of Microsoft Windows. For more information, and alternatives to TxF, please see Alternatives to using Transactional NTFS.]
        /// </summary>
        /// <param name="lpFileName">The name of the file.Do not specify the name of a file on a nonseeking device, such as a pipe or a communications device, as its file size has no meaning.The file must reside on the local computer; otherwise, the function fails and the last error code is set to ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE.</param>
        /// <param name="hTransaction">A handle to the transaction. This handle is returned by the CreateTransaction function.If the function succeeds, the return value is the low-order DWORD of the actual number of bytes of disk storage used to store the specified file, and if lpFileSizeHigh is non-NULL, the function puts the high-order DWORD of that actual value into the DWORD pointed to by that parameter. This is the compressed file size for compressed files, the actual file size for noncompressed files.If the function fails, and lpFileSizeHigh is NULL, the return value is INVALID_FILE_SIZE. To get extended error information, call GetLastError.If the return value is INVALID_FILE_SIZE and lpFileSizeHigh is non-NULL, an application must call GetLastError to determine whether the function has succeeded (value is NO_ERROR) or failed (value is other than NO_ERROR).An application can determine whether a volume is compressed by calling GetVolumeInformation, then checking the status of the FS_VOL_IS_COMPRESSED flag in the DWORD value pointed to by that function's lpFileSystemFlags parameter.If the file is not located on a volume that supports compression or sparse files, or if the file is not compressed or a sparse file, the value obtained is the actual file size, the same as the value returned by a call to GetFileSize.Symbolic links:  If the path points to a symbolic link, the function returns the file size of the target.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB 3.0 does not support TxF.File Compression and DecompressionFile Management FunctionsGetFileSizeGetVolumeInformationSymbolic LinksTransaction Management</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetCompressedFileSizeTransactedA(string lpFileName, IntPtr hTransaction);

        /// <summary>
        ///[Microsoft strongly recommends developers utilize alternative means to achieve your application’s needs. Many scenarios that TxF was developed for can be achieved through simpler and more readily available techniques. Furthermore, TxF may not be available in future versions of Microsoft Windows. For more information, and alternatives to TxF, please see Alternatives to using Transactional NTFS.]
        /// </summary>
        /// <param name="lpFileName">The name of the file.Do not specify the name of a file on a nonseeking device, such as a pipe or a communications device, as its file size has no meaning.The file must reside on the local computer; otherwise, the function fails and the last error code is set to ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE.</param>
        /// <param name="hTransaction">A handle to the transaction. This handle is returned by the CreateTransaction function.If the function succeeds, the return value is the low-order DWORD of the actual number of bytes of disk storage used to store the specified file, and if lpFileSizeHigh is non-NULL, the function puts the high-order DWORD of that actual value into the DWORD pointed to by that parameter. This is the compressed file size for compressed files, the actual file size for noncompressed files.If the function fails, and lpFileSizeHigh is NULL, the return value is INVALID_FILE_SIZE. To get extended error information, call GetLastError.If the return value is INVALID_FILE_SIZE and lpFileSizeHigh is non-NULL, an application must call GetLastError to determine whether the function has succeeded (value is NO_ERROR) or failed (value is other than NO_ERROR).An application can determine whether a volume is compressed by calling GetVolumeInformation, then checking the status of the FS_VOL_IS_COMPRESSED flag in the DWORD value pointed to by that function's lpFileSystemFlags parameter.If the file is not located on a volume that supports compression or sparse files, or if the file is not compressed or a sparse file, the value obtained is the actual file size, the same as the value returned by a call to GetFileSize.Symbolic links:  If the path points to a symbolic link, the function returns the file size of the target.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB 3.0 does not support TxF.File Compression and DecompressionFile Management FunctionsGetFileSizeGetVolumeInformationSymbolic LinksTransaction Management</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetCompressedFileSizeTransactedW(string lpFileName, IntPtr hTransaction);

        /// <summary>
        ///Retrieves the NetBIOS name of the local computer. This name is established at system startup, when the system reads it from the registry.
        /// </summary>
        /// <param name="lpBuffer"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetComputerNameA(out string lpBuffer);

        /// <summary>
        ///Retrieves the NetBIOS name of the local computer. This name is established at system startup, when the system reads it from the registry.
        /// </summary>
        /// <param name="lpBuffer"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetComputerNameW(out string lpBuffer);

        /// <summary>
        ///The GetCurrentActCtx function returns the handle to the active activation context of the calling thread.
        /// </summary>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetCurrentActCtx(out IntPtr lphActCtx);

        /// <summary>
        ///Retrieves the current directory for the current process.
        /// </summary>
        /// <param name="nBufferLength">The length of the buffer for the current directory string, in TCHARs. The buffer length must include room for a terminating null character.</param>
        /// <param name="lpBuffer"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetCurrentDirectory(uint nBufferLength, out int lpBuffer);

        /// <summary>
        ///Retrieves information about the current hardware profile for the local computer.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetCurrentHwProfileA(out IntPtr lpHwProfileInfo);

        /// <summary>
        ///Retrieves information about the current hardware profile for the local computer.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetCurrentHwProfileW(out IntPtr lpHwProfileInfo);

        /// <summary>
        ///Returns the user-mode scheduling (UMS) thread context of the calling UMS thread.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetCurrentUmsThread();

        /// <summary>
        ///Retrieves the default configuration for the specified communications device.
        /// </summary>
        /// <param name="lpszName">The name of the device. For example, COM1 through COM9 are serial ports and LPT1 through LPT9 are parallel ports.</param>
        /// <param name="lpCC"></param>
        /// <remarks>
        /// To get extended error information, use the GetLastError function.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetDefaultCommConfigA(string lpszName, out int lpCC);

        /// <summary>
        ///Retrieves the default configuration for the specified communications device.
        /// </summary>
        /// <param name="lpszName">The name of the device. For example, COM1 through COM9 are serial ports and LPT1 through LPT9 are parallel ports.</param>
        /// <param name="lpCC"></param>
        /// <remarks>
        /// To get extended error information, use the GetLastError function.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetDefaultCommConfigW(string lpszName, out int lpCC);

        /// <summary>
        ///Retrieves the current power state of the specified device. This function cannot be used to query the power state of a display device.
        /// </summary>
        /// <param name="hDevice">A handle to an object on the device, such as a file or socket, or a handle to the device itself.</param>
        /// <param name="pfOn"></param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetDevicePowerState(IntPtr hDevice, out bool pfOn);

        /// <summary>
        ///Retrieves the application-specific portion of the search path used to locate DLLs for the application.
        /// </summary>
        /// <param name="nBufferLength">The size of the output buffer, in characters.</param>
        /// <param name="lpBuffer"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetDllDirectoryA(uint nBufferLength, out string lpBuffer);

        /// <summary>
        ///Retrieves the application-specific portion of the search path used to locate DLLs for the application.
        /// </summary>
        /// <param name="nBufferLength">The size of the output buffer, in characters.</param>
        /// <param name="lpBuffer"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetDllDirectoryW(uint nBufferLength, out string lpBuffer);

        /// <summary>
        ///Gets a mask of enabled XState features on x86 or x64 processors.
        /// </summary>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetEnabledXStateFeatures();

        /// <summary>
        ///Retrieves the contents of the specified variable from the environment block of the calling process.
        /// </summary>
        /// <param name="nSize">The size of the buffer pointed to by the lpBuffer parameter, including the null-terminating character, in characters.If the function succeeds, the return value is the number of characters stored in the buffer pointed to by lpBuffer, not including the terminating null character.If lpBuffer is not large enough to hold the data, the return value is the buffer size, in characters, required to hold the string and its terminating null character and the contents of lpBuffer are undefined.If the function fails, the return value is zero. If the specified environment variable was not found in the environment block, GetLastError returns ERROR_ENVVAR_NOT_FOUND.This function can retrieve either a system environment variable or a user environment variable.For an example, see Changing Environment Variables.Environment VariablesGetEnvironmentStringsSetEnvironmentVariable</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetEnvironmentVariable(uint nSize);

        /// <summary>
        ///Retrieves information about the specified event log.
        /// </summary>
        /// <param name="hEventLog">A handle to the event log. The OpenEventLog or RegisterEventSource function returns this handle.</param>
        /// <param name="dwInfoLevel">The level of event log information to return.This parameter can be the following value.</param>
        /// <param name="lpBuffer"></param>
        /// <param name="cbBufSize">The size of the lpBuffer buffer, in bytes.</param>
        /// <param name="pcbBytesNeeded"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetEventLogInformation(IntPtr hEventLog, uint dwInfoLevel, out IntPtr lpBuffer, uint cbBufSize, out uint pcbBytesNeeded);

        /// <summary>
        ///[Microsoft strongly recommends developers utilize alternative means to achieve your application’s needs. Many scenarios that TxF was developed for can be achieved through simpler and more readily available techniques. Furthermore, TxF may not be available in future versions of Microsoft Windows. For more information, and alternatives to TxF, please see Alternatives to using Transactional NTFS.]
        /// </summary>
        /// <param name="lpFileName">The name of the file or directory.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.The file or directory must reside on the local computer; otherwise, the function fails and the last error code is set to ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE.</param>
        /// <param name="fInfoLevelId">The level of attribute information to retrieve.This parameter can be the following value from the GET_FILEEX_INFO_LEVELS enumeration.</param>
        /// <param name="lpFileInformation"></param>
        /// <param name="hTransaction">A handle to the transaction. This handle is returned by the CreateTransaction function.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero (0). To get extended error information, call GetLastError.When GetFileAttributesTransacted is called on a directory that is a mounted folder, it returns the attributes of the directory, not those of the root directory in the volume that the mounted folder associates with the directory. To obtain the file attributes of the associated volume, call GetVolumeNameForVolumeMountPoint to obtain the name of the associated volume. Then use the resulting name in a call to GetFileAttributesTransacted. The results are the attributes of the root directory on the associated volume.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB 3.0 does not support TxF.Symbolic links:  If the path points to a symbolic link, the function returns attributes for the symbolic link.DeviceIoControlFile Attribute ConstantsFile Management FunctionsFindFirstFileTransactedFindNextFileGET_FILEEX_INFO_LEVELSSetFileAttributesTransactedSymbolic LinksTransactional NTFS</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetFileAttributesTransactedA(string lpFileName, int fInfoLevelId, out IntPtr lpFileInformation, IntPtr hTransaction);

        /// <summary>
        ///[Microsoft strongly recommends developers utilize alternative means to achieve your application’s needs. Many scenarios that TxF was developed for can be achieved through simpler and more readily available techniques. Furthermore, TxF may not be available in future versions of Microsoft Windows. For more information, and alternatives to TxF, please see Alternatives to using Transactional NTFS.]
        /// </summary>
        /// <param name="lpFileName">The name of the file or directory.The file or directory must reside on the local computer; otherwise, the function fails and the last error code is set to ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="fInfoLevelId">The level of attribute information to retrieve.This parameter can be the following value from the GET_FILEEX_INFO_LEVELS enumeration.</param>
        /// <param name="lpFileInformation"></param>
        /// <param name="hTransaction">A handle to the transaction. This handle is returned by the CreateTransaction function.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero (0). To get extended error information, call GetLastError.When GetFileAttributesTransacted is called on a directory that is a mounted folder, it returns the attributes of the directory, not those of the root directory in the volume that the mounted folder associates with the directory. To obtain the file attributes of the associated volume, call GetVolumeNameForVolumeMountPoint to obtain the name of the associated volume. Then use the resulting name in a call to GetFileAttributesTransacted. The results are the attributes of the root directory on the associated volume.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB 3.0 does not support TxF.Symbolic links:  If the path points to a symbolic link, the function returns attributes for the symbolic link.DeviceIoControlFile Attribute ConstantsFile Management FunctionsFindFirstFileTransactedFindNextFileGET_FILEEX_INFO_LEVELSSetFileAttributesTransactedSymbolic LinksTransactional NTFS</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetFileAttributesTransactedW(string lpFileName, int fInfoLevelId, out IntPtr lpFileInformation, IntPtr hTransaction);

        /// <summary>
        ///Retrieves the bandwidth reservation properties of the volume on which the specified file resides.
        /// </summary>
        /// <param name="hFile">A handle to the file.</param>
        /// <param name="lpPeriodMilliseconds"></param>
        /// <param name="lpBytesPerPeriod"></param>
        /// <param name="pDiscardable"></param>
        /// <param name="lpTransferSize"></param>
        /// <param name="lpNumOutstandingRequests"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetFileBandwidthReservation(IntPtr hFile, out uint lpPeriodMilliseconds, out uint lpBytesPerPeriod, out bool pDiscardable, out uint lpTransferSize, out uint lpNumOutstandingRequests);

        /// <summary>
        ///Retrieves file information for the specified file.
        /// </summary>
        /// <param name="hFile">A handle to the file that contains the information to be retrieved.This handle should not be a pipe handle.</param>
        /// <param name="FileInformationClass">A FILE_INFO_BY_HANDLE_CLASS enumeration value that specifies the type of information to be retrieved.For a table of valid values, see the Remarks section.</param>
        /// <param name="lpFileInformation"></param>
        /// <param name="dwBufferSize">The size of the lpFileInformation buffer, in bytes.If the function succeeds, the return value is nonzero and file information data is contained in the buffer pointed to by the lpFileInformation parameter.If the function fails, the return value is zero. To get extended error information, call GetLastError.If FileInformationClass is FileStreamInfo and the calls succeed but no streams are returned, the error that is returned by GetLastError is ERROR_HANDLE_EOF.Certain file information classes behave slightly differently on different operating system releases. These classes are supported by the underlying drivers, and any information they return is subject to change between operating system releases.The following table shows the valid file information class types and their corresponding data structure types for use with this function.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.FILE_INFO_BY_HANDLE_CLASSFile Management FunctionsSetFileInformationByHandle</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetFileInformationByHandleEx(IntPtr hFile, IntPtr FileInformationClass, out IntPtr lpFileInformation, uint dwBufferSize);

        /// <summary>
        ///Queries information about a file or directory, given the path to the file.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetFileInformationByName();

        /// <summary>
        ///The GetFileSecurity function obtains specified information about the security of a file or directory. The information obtained is constrained by the caller's access rights and privileges.
        /// </summary>
        /// <param name="lpFileName">A pointer to a null-terminated string that specifies the file or directory for which security information is retrieved.</param>
        /// <param name="RequestedInformation">A SECURITY_INFORMATION value that identifies the security information being requested.</param>
        /// <param name="nLength">Specifies the size, in bytes, of the buffer pointed to by the pSecurityDescriptor parameter.</param>
        /// <param name="lpnLengthNeeded"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetFileSecurityA(string lpFileName, int RequestedInformation, uint nLength, out uint lpnLengthNeeded);

        /// <summary>
        ///Retrieves the value of the specified firmware environment variable.
        /// </summary>
        /// <param name="lpName">The name of the firmware environment variable. The pointer must not be NULL.</param>
        /// <param name="lpGuid">The GUID that represents the namespace of the firmware environment variable. The GUID must be a string in the format "{xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}" where 'x' represents a hexadecimal value.</param>
        /// <param name="pBuffer"></param>
        /// <param name="nSize">The size of the pBuffer buffer, in bytes.If the function succeeds, the return value is the number of bytes stored in the pBuffer buffer.If the function fails, the return value is zero. To get extended error information, call GetLastError. Possible error codes include ERROR_INVALID_FUNCTION.Starting with Windows 10, version 1803, Universal Windows apps can read and write Unified Extensible Firmware Interface (UEFI) firmware variables. See Access UEFI firmware variables from a Universal Windows App for details.To read a firmware environment variable, the user account that the app is running under must have the SE_SYSTEM_ENVIRONMENT_NAME privilege. A Universal Windows app must be run from an administrator account and follow the requirements outlined in Access UEFI firmware variables from a Universal Windows App.Starting with Windows 10, version 1803, reading Unified Extensible Firmware Interface (UEFI) variables is also supported from User-Mode Driver Framework (UMDF) drivers. Writing UEFI variables from UMDF drivers is not supported.The exact set of firmware environment variables is determined by the boot firmware. The location of these environment variables is also specified by the firmware. For example, on a UEFI-based system, NVRAM contains firmware environment variables that specify system boot settings. For information about specific variables used, see the UEFI specification. For more information about UEFI and Windows, see UEFI and Windows.Firmware variables are not supported on a legacy BIOS-based system. The GetFirmwareEnvironmentVariable function will always fail on a legacy BIOS-based system, or if Windows was installed using legacy BIOS on a system that supports both legacy BIOS and UEFI. To identify these conditions, call the function with a dummy firmware environment name such as an empty string ("") for the lpName parameter and a dummy GUID such as "{00000000-0000-0000-0000-000000000000}" for the lpGuid parameter. On a legacy BIOS-based system, or on a system that supports both legacy BIOS and UEFI where Windows was installed using legacy BIOS, the function will fail with ERROR_INVALID_FUNCTION. On a UEFI-based system, the function will fail with an error specific to the firmware, such as ERROR_NOACCESS, to indicate that the dummy GUID namespace does not exist.If you are creating a backup application, you can use this function to save all the boot settings for the system so they can be restored using the SetFirmwareEnvironmentVariable function if needed.GetFirmwareEnvironmentVariable is the user-mode equivalent of the ExGetFirmwareEnvironmentVariable kernel-mode routine.Access UEFI firmware variables from a Universal Windows AppGetFirmwareEnvironmentVariableExSetFirmwareEnvironmentVariableSystem Information Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError. Possible error codes include ERROR_INVALID_FUNCTION.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetFirmwareEnvironmentVariableA(string lpName, string lpGuid, out IntPtr pBuffer, uint nSize);

        /// <summary>
        ///Retrieves the value of the specified firmware environment variable and its attributes.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError. Possible error codes include ERROR_INVALID_FUNCTION.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetFirmwareEnvironmentVariableExA();

        /// <summary>
        ///Retrieves the value of the specified firmware environment variable and its attributes.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError. Possible error codes include ERROR_INVALID_FUNCTION.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetFirmwareEnvironmentVariableExW();

        /// <summary>
        ///Retrieves the value of the specified firmware environment variable.
        /// </summary>
        /// <param name="lpName">The name of the firmware environment variable. The pointer must not be NULL.</param>
        /// <param name="lpGuid">The GUID that represents the namespace of the firmware environment variable. The GUID must be a string in the format "{xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}" where 'x' represents a hexadecimal value.</param>
        /// <param name="pBuffer"></param>
        /// <param name="nSize">The size of the pBuffer buffer, in bytes.If the function succeeds, the return value is the number of bytes stored in the pBuffer buffer.If the function fails, the return value is zero. To get extended error information, call GetLastError. Possible error codes include ERROR_INVALID_FUNCTION.Starting with Windows 10, version 1803, Universal Windows apps can read and write Unified Extensible Firmware Interface (UEFI) firmware variables. See Access UEFI firmware variables from a Universal Windows App for details.To read a firmware environment variable, the user account that the app is running under must have the SE_SYSTEM_ENVIRONMENT_NAME privilege. A Universal Windows app must be run from an administrator account and follow the requirements outlined in Access UEFI firmware variables from a Universal Windows App.Starting with Windows 10, version 1803, reading Unified Extensible Firmware Interface (UEFI) variables is also supported from User-Mode Driver Framework (UMDF) drivers. Writing UEFI variables from UMDF drivers is not supported.The exact set of firmware environment variables is determined by the boot firmware. The location of these environment variables is also specified by the firmware. For example, on a UEFI-based system, NVRAM contains firmware environment variables that specify system boot settings. For information about specific variables used, see the UEFI specification. For more information about UEFI and Windows, see UEFI and Windows.Firmware variables are not supported on a legacy BIOS-based system. The GetFirmwareEnvironmentVariable function will always fail on a legacy BIOS-based system, or if Windows was installed using legacy BIOS on a system that supports both legacy BIOS and UEFI. To identify these conditions, call the function with a dummy firmware environment name such as an empty string ("") for the lpName parameter and a dummy GUID such as "{00000000-0000-0000-0000-000000000000}" for the lpGuid parameter. On a legacy BIOS-based system, or on a system that supports both legacy BIOS and UEFI where Windows was installed using legacy BIOS, the function will fail with ERROR_INVALID_FUNCTION. On a UEFI-based system, the function will fail with an error specific to the firmware, such as ERROR_NOACCESS, to indicate that the dummy GUID namespace does not exist.If you are creating a backup application, you can use this function to save all the boot settings for the system so they can be restored using the SetFirmwareEnvironmentVariable function if needed.GetFirmwareEnvironmentVariable is the user-mode equivalent of the ExGetFirmwareEnvironmentVariable kernel-mode routine.Access UEFI firmware variables from a Universal Windows AppGetFirmwareEnvironmentVariableExSetFirmwareEnvironmentVariableSystem Information Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError. Possible error codes include ERROR_INVALID_FUNCTION.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetFirmwareEnvironmentVariableW(string lpName, string lpGuid, out IntPtr pBuffer, uint nSize);

        /// <summary>
        ///Retrieves the firmware type of the local computer.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call the GetLastError function.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetFirmwareType();

        /// <summary>
        ///[Microsoft strongly recommends developers utilize alternative means to achieve your application’s needs. Many scenarios that TxF was developed for can be achieved through simpler and more readily available techniques. Furthermore, TxF may not be available in future versions of Microsoft Windows. For more information, and alternatives to TxF, please see Alternatives to using Transactional NTFS.]
        /// </summary>
        /// <param name="lpFileName">The name of the file.This string can use short (the 8.3 form) or long file names. This string can be a share or volume name.The file must reside on the local computer; otherwise, the function fails and the last error code is set to ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE.</param>
        /// <param name="nBufferLength">The size of the buffer to receive the null-terminated string for the drive and path, in TCHARs.</param>
        /// <param name="lpBuffer"></param>
        /// <param name="lpFilePart"></param>
        /// <param name="hTransaction">A handle to the transaction. This handle is returned by the CreateTransaction function.If the function succeeds, the return value is the length, in TCHARs, of the string copied to lpBuffer, not including the terminating null character.If the lpBuffer buffer is too small to contain the path, the return value is the size, in TCHARs, of the buffer that is required to hold the path and the terminating null character.If the function fails for any other reason, the return value is zero. To get extended error information, call GetLastError.GetFullPathNameTransacted merges the name of the current drive and directory with a specified file name to determine the full path and file name of a specified file. It also calculates the address of the file name portion of the full path and file name. This function does not verify that the resulting path and file name are valid, or that they see an existing file on the associated volume.Share and volume names are valid input for lpFileName. For example, the following list identities the returned path and file names if test-2 is a remote computer and U: is a network mapped drive:If the return value is greater than the value specified in nBufferLength, you can call the function again with a buffer that is large enough to hold the path. For an example of this case as well as using zero length buffer for dynamic allocation, see the Example Code section.SMB 3.0 does not support TxF.File Management FunctionsGetFullPathNameGetLongPathNameTransactedGetShortPathNameGetTempPathSearchPathTransactional NTFS</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetFullPathNameTransactedA(string lpFileName, uint nBufferLength, out string lpBuffer, out string lpFilePart, IntPtr hTransaction);

        /// <summary>
        ///[Microsoft strongly recommends developers utilize alternative means to achieve your application’s needs. Many scenarios that TxF was developed for can be achieved through simpler and more readily available techniques. Furthermore, TxF may not be available in future versions of Microsoft Windows. For more information, and alternatives to TxF, please see Alternatives to using Transactional NTFS.]
        /// </summary>
        /// <param name="lpFileName">The name of the file.This string can use short (the 8.3 form) or long file names. This string can be a share or volume name.The file must reside on the local computer; otherwise, the function fails and the last error code is set to ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE.</param>
        /// <param name="nBufferLength">The size of the buffer to receive the null-terminated string for the drive and path, in TCHARs.</param>
        /// <param name="lpBuffer"></param>
        /// <param name="lpFilePart"></param>
        /// <param name="hTransaction">A handle to the transaction. This handle is returned by the CreateTransaction function.If the function succeeds, the return value is the length, in TCHARs, of the string copied to lpBuffer, not including the terminating null character.If the lpBuffer buffer is too small to contain the path, the return value is the size, in TCHARs, of the buffer that is required to hold the path and the terminating null character.If the function fails for any other reason, the return value is zero. To get extended error information, call GetLastError.GetFullPathNameTransacted merges the name of the current drive and directory with a specified file name to determine the full path and file name of a specified file. It also calculates the address of the file name portion of the full path and file name. This function does not verify that the resulting path and file name are valid, or that they see an existing file on the associated volume.Share and volume names are valid input for lpFileName. For example, the following list identities the returned path and file names if test-2 is a remote computer and U: is a network mapped drive:If the return value is greater than the value specified in nBufferLength, you can call the function again with a buffer that is large enough to hold the path. For an example of this case as well as using zero length buffer for dynamic allocation, see the Example Code section.SMB 3.0 does not support TxF.File Management FunctionsGetFullPathNameGetLongPathNameTransactedGetShortPathNameGetTempPathSearchPathTransactional NTFS</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetFullPathNameTransactedW(string lpFileName, uint nBufferLength, out string lpBuffer, out string lpFilePart, IntPtr hTransaction);

        /// <summary>
        ///Fills a buffer with strings that specify valid drives in the system.
        /// </summary>
        /// <param name="nBufferLength">The maximum size of the buffer pointed to by lpBuffer, in TCHARs. This size does not include the terminating null character. If this parameter is zero, lpBuffer is not used.</param>
        /// <param name="lpBuffer"></param>
        /// <remarks>
        /// To get extended error information, use the GetLastError function.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetLogicalDriveStringsA(uint nBufferLength, out string lpBuffer);

        /// <summary>
        ///[Microsoft strongly recommends developers utilize alternative means to achieve your application’s needs. Many scenarios that TxF was developed for can be achieved through simpler and more readily available techniques. Furthermore, TxF may not be available in future versions of Microsoft Windows. For more information, and alternatives to TxF, please see Alternatives to using Transactional NTFS.]
        /// </summary>
        /// <param name="lpszShortPath">The path to be converted.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.The path must reside on the local computer; otherwise, the function fails and the last error code is set to ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE.</param>
        /// <param name="lpszLongPath"></param>
        /// <param name="cchBuffer">The size of the buffer lpszLongPath points to, in TCHARs.</param>
        /// <param name="hTransaction">A handle to the transaction. This handle is returned by the CreateTransaction function.If the function succeeds, the return value is the length, in TCHARs, of the string copied to lpszLongPath, not including the terminating null character.If the lpBuffer buffer is too small to contain the path, the return value is the size, in TCHARs, of the buffer that is required to hold the path and the terminating null character.If the function fails for any other reason, such as if the file does not exist, the return value is zero. To get extended error information, call GetLastError.On many file systems, a short file name contains a tilde (~) character. However, not all file systems follow this convention. Therefore, do not assume that you can skip calling GetLongPathNameTransacted if the path does not contain a tilde (~) character.If a long path is not found, this function returns the name specified in the lpszShortPath parameter in the lpszLongPath parameter.If the return value is greater than the value specified in cchBuffer, you can call the function again with a buffer that is large enough to hold the path. For an example of this case, see the Example Code section for GetFullPathName.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB 3.0 does not support TxF.File Management FunctionsGetFullPathNameTransactedGetShortPathNameNaming Files, Paths, and NamespacesTransactional NTFS</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetLongPathNameTransactedA(string lpszShortPath, out string lpszLongPath, uint cchBuffer, IntPtr hTransaction);

        /// <summary>
        ///[Microsoft strongly recommends developers utilize alternative means to achieve your application’s needs. Many scenarios that TxF was developed for can be achieved through simpler and more readily available techniques. Furthermore, TxF may not be available in future versions of Microsoft Windows. For more information, and alternatives to TxF, please see Alternatives to using Transactional NTFS.]
        /// </summary>
        /// <param name="lpszShortPath">The path to be converted.The path must reside on the local computer; otherwise, the function fails and the last error code is set to ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="lpszLongPath"></param>
        /// <param name="cchBuffer">The size of the buffer lpszLongPath points to, in TCHARs.</param>
        /// <param name="hTransaction">A handle to the transaction. This handle is returned by the CreateTransaction function.If the function succeeds, the return value is the length, in TCHARs, of the string copied to lpszLongPath, not including the terminating null character.If the lpBuffer buffer is too small to contain the path, the return value is the size, in TCHARs, of the buffer that is required to hold the path and the terminating null character.If the function fails for any other reason, such as if the file does not exist, the return value is zero. To get extended error information, call GetLastError.On many file systems, a short file name contains a tilde (~) character. However, not all file systems follow this convention. Therefore, do not assume that you can skip calling GetLongPathNameTransacted if the path does not contain a tilde (~) character.If a long path is not found, this function returns the name specified in the lpszShortPath parameter in the lpszLongPath parameter.If the return value is greater than the value specified in cchBuffer, you can call the function again with a buffer that is large enough to hold the path. For an example of this case, see the Example Code section for GetFullPathName.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB 3.0 does not support TxF.File Management FunctionsGetFullPathNameTransactedGetShortPathNameNaming Files, Paths, and NamespacesTransactional NTFS</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetLongPathNameTransactedW(string lpszShortPath, out string lpszLongPath, uint cchBuffer, IntPtr hTransaction);

        /// <summary>
        ///Retrieves information about the specified mailslot.
        /// </summary>
        /// <param name="hMailslot">A handle to a mailslot. The CreateMailslot function must create this handle.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetMailslotInfo(IntPtr hMailslot);

        /// <summary>
        ///Returns the maximum number of logical processors that a processor group or the system can have.
        /// </summary>
        /// <param name="GroupNumber">The processor group number. If this parameter is ALL_PROCESSOR_GROUPS, the function returns the maximum number of processors that the system can have.If the function succeeds, the return value is the maximum number of processors that the specified group can have.If the function fails, the return value is zero. To get extended error information, use GetLastError.To compile an application that uses this function, set _WIN32_WINNT >= 0x0601. For more information, see Using the Windows Headers.</param>
        /// <remarks>
        /// To get extended error information, use GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetMaximumProcessorCount(uint GroupNumber);

        /// <summary>
        ///Returns the maximum number of processor groups that the system can have.
        /// </summary>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetMaximumProcessorGroupCount();

        /// <summary>
        ///Retrieves the client computer name for the specified named pipe.
        /// </summary>
        /// <param name="Pipe">A handle to an instance of a named pipe. This handle must be created by the CreateNamedPipe function.</param>
        /// <param name="ClientComputerName"></param>
        /// <param name="ClientComputerNameLength">The size of the ClientComputerName buffer, in bytes.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call the GetLastError function.Windows 10, version 1709:  Pipes are only supported within an app-container; ie, from one UWP process to another UWP process that's part of the same app. Also, named pipes must use the syntax \\.\pipe\LOCAL\ for the pipe name.CreateNamedPipePipe FunctionsPipes Overview</param>
        /// <remarks>
        /// To get extended error information, call the GetLastError function.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetNamedPipeClientComputerNameA(IntPtr Pipe, out string ClientComputerName, int ClientComputerNameLength);

        /// <summary>
        ///Retrieves the client process identifier for the specified named pipe.
        /// </summary>
        /// <param name="Pipe">A handle to an instance of a named pipe. This handle must be created by the CreateNamedPipe function.</param>
        /// <param name="ClientProcessId"></param>
        /// <remarks>
        /// To get extended error information, call the GetLastError function.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetNamedPipeClientProcessId(IntPtr Pipe, out int ClientProcessId);

        /// <summary>
        ///Retrieves the client session identifier for the specified named pipe.
        /// </summary>
        /// <param name="Pipe">A handle to an instance of a named pipe. This handle must be created by the CreateNamedPipe function.</param>
        /// <param name="ClientSessionId"></param>
        /// <remarks>
        /// To get extended error information, call the GetLastError function.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetNamedPipeClientSessionId(IntPtr Pipe, out int ClientSessionId);

        /// <summary>
        ///Retrieves information about a specified named pipe. The information returned can vary during the lifetime of an instance of the named pipe.
        /// </summary>
        /// <param name="hNamedPipe">A handle to the named pipe for which information is wanted. The handle must have GENERIC_READ access for a read-only or read/write pipe, or it must have GENERIC_WRITE and FILE_READ_ATTRIBUTES access for a write-only pipe.This parameter can also be a handle to an anonymous pipe, as returned by the CreatePipe function.</param>
        /// <param name="nMaxUserNameSize">The size of the buffer specified by the lpUserName parameter, in TCHARs. This parameter is ignored if lpUserName is NULL.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The GetNamedPipeHandleState function returns successfully even if all of the pointers passed to it are NULL.To set the pipe handle state, use the SetNamedPipeHandleState function.Windows 10, version 1709:  Pipes are only supported within an app-container; ie, from one UWP process to another UWP process that's part of the same app. Also, named pipes must use the syntax \\.\pipe\LOCAL\ for the pipe name.Pipe FunctionsPipes OverviewSetNamedPipeHandleState</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetNamedPipeHandleStateA(IntPtr hNamedPipe, uint nMaxUserNameSize);

        /// <summary>
        ///Retrieves the server process identifier for the specified named pipe.
        /// </summary>
        /// <param name="Pipe">A handle to an instance of a named pipe. This handle must be created by the CreateNamedPipe function.</param>
        /// <param name="ServerProcessId"></param>
        /// <remarks>
        /// To get extended error information, call the GetLastError function.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetNamedPipeServerProcessId(IntPtr Pipe, out int ServerProcessId);

        /// <summary>
        ///Retrieves the server session identifier for the specified named pipe.
        /// </summary>
        /// <param name="Pipe">A handle to an instance of a named pipe. This handle must be created by the CreateNamedPipe function.</param>
        /// <param name="ServerSessionId"></param>
        /// <remarks>
        /// To get extended error information, call the GetLastError function.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetNamedPipeServerSessionId(IntPtr Pipe, out int ServerSessionId);

        /// <summary>
        ///Returns the next user-mode scheduling (UMS) thread context in a list of thread contexts.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetNextUmsListItem();

        /// <summary>
        ///Retrieves the amount of memory available in the specified node.
        /// </summary>
        /// <param name="Node">The number of the node.</param>
        /// <param name="AvailableBytes"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetNumaAvailableMemoryNode(char Node, out int AvailableBytes);

        /// <summary>
        ///Retrieves the amount of memory that is available in a node specified as a USHORT value.
        /// </summary>
        /// <param name="Node">The number of the node.</param>
        /// <param name="AvailableBytes"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetNumaAvailableMemoryNodeEx(short Node, out int AvailableBytes);

        /// <summary>
        ///Retrieves the NUMA node associated with the file or I/O device represented by the specified file handle.
        /// </summary>
        /// <param name="hFile">A handle to a file or I/O device. Examples of I/O devices include files, file streams, volumes, physical disks, and sockets. For more information, see the CreateFile function.</param>
        /// <param name="NodeNumber"></param>
        /// <remarks>
        /// To get extended error information, use GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetNumaNodeNumberFromHandle(IntPtr hFile, out short NodeNumber);

        /// <summary>
        ///Retrieves the processor mask for the specified node.
        /// </summary>
        /// <param name="Node">The number of the node.</param>
        /// <param name="ProcessorMask"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetNumaNodeProcessorMask(char Node, out int ProcessorMask);

        /// <summary>
        ///Retrieves the node number for the specified processor.
        /// </summary>
        /// <param name="Processor">The processor number.On a system with more than 64 logical processors, the processor number is relative to the processor group that contains the processor on which the calling thread is running.</param>
        /// <param name="NodeNumber"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetNumaProcessorNode(char Processor, out char NodeNumber);

        /// <summary>
        ///Retrieves the node number as a USHORT value for the specified logical processor.
        /// </summary>
        /// <param name="Processor">A pointer to a PROCESSOR_NUMBER structure that represents the logical processor and the processor group to which it is assigned.</param>
        /// <param name="NodeNumber"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetNumaProcessorNodeEx(int Processor, out short NodeNumber);

        /// <summary>
        ///Retrieves the NUMA node number that corresponds to the specified proximity domain identifier.
        /// </summary>
        /// <param name="ProximityId">The proximity domain identifier of the node.</param>
        /// <param name="NodeNumber"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetNumaProximityNode(int ProximityId, out char NodeNumber);

        /// <summary>
        ///Retrieves the number of records in the specified event log.
        /// </summary>
        /// <param name="hEventLog">A handle to the open event log. The OpenEventLog or OpenBackupEventLog function returns this handle.</param>
        /// <param name="NumberOfRecords"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetNumberOfEventLogRecords(IntPtr hEventLog, out uint NumberOfRecords);

        /// <summary>
        ///Retrieves the absolute record number of the oldest record in the specified event log.
        /// </summary>
        /// <param name="hEventLog">A handle to the open event log. The OpenEventLog or OpenBackupEventLog function returns this handle.</param>
        /// <param name="OldestRecord"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetOldestEventLogRecord(IntPtr hEventLog, out uint OldestRecord);

        /// <summary>
        ///Retrieves an integer associated with a key in the specified section of an initialization file.
        /// </summary>
        /// <param name="lpAppName">The name of the section in the initialization file.</param>
        /// <param name="lpKeyName">The name of the key whose value is to be retrieved. This value is in the form of a string; the GetPrivateProfileInt function converts the string into an integer and returns the integer.</param>
        /// <param name="nDefault">The default value to return if the key name cannot be found in the initialization file.</param>
        /// <param name="lpFileName">The name of the initialization file. If this parameter does not contain a full path to the file, the system searches for the file in the Windows directory.The return value is the integer equivalent of the string following the specified key name in the specified initialization file. If the key is not found, the return value is the specified default value.The function searches the file for a key that matches the name specified by the lpKeyName parameter under the section name specified by the lpAppName parameter. A section in the initialization file must have the following form:The GetPrivateProfileInt function is not case-sensitive; the strings in lpAppName and lpKeyName can be a combination of uppercase and lowercase letters.An application can use the GetProfileInt function to retrieve an integer value from the Win.ini file.The system maps most .ini file references to the registry, using the mapping defined under the following registry key:HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\IniFileMappingThis mapping is likely if an application modifies system-component initialization files, such as Control.ini, System.ini, and Winfile.ini. In these cases, the function retrieves information from the registry, not from the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:GetProfileIntWritePrivateProfileString</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetPrivateProfileInt(string lpAppName, string lpKeyName, uint nDefault, string lpFileName);

        /// <summary>
        ///Retrieves an integer associated with a key in the specified section of an initialization file.
        /// </summary>
        /// <param name="lpAppName">The name of the section in the initialization file.</param>
        /// <param name="lpKeyName">The name of the key whose value is to be retrieved. This value is in the form of a string; the GetPrivateProfileInt function converts the string into an integer and returns the integer.</param>
        /// <param name="nDefault">The default value to return if the key name cannot be found in the initialization file.</param>
        /// <param name="lpFileName">The name of the initialization file. If this parameter does not contain a full path to the file, the system searches for the file in the Windows directory.The return value is the integer equivalent of the string following the specified key name in the specified initialization file. If the key is not found, the return value is the specified default value.The function searches the file for a key that matches the name specified by the lpKeyName parameter under the section name specified by the lpAppName parameter. A section in the initialization file must have the following form:The GetPrivateProfileInt function is not case-sensitive; the strings in lpAppName and lpKeyName can be a combination of uppercase and lowercase letters.An application can use the GetProfileInt function to retrieve an integer value from the Win.ini file.The system maps most .ini file references to the registry, using the mapping defined under the following registry key:HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\IniFileMappingThis mapping is likely if an application modifies system-component initialization files, such as Control.ini, System.ini, and Winfile.ini. In these cases, the function retrieves information from the registry, not from the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:GetProfileIntWritePrivateProfileString</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetPrivateProfileIntA(string lpAppName, string lpKeyName, uint nDefault, string lpFileName);

        /// <summary>
        ///Retrieves an integer associated with a key in the specified section of an initialization file.
        /// </summary>
        /// <param name="lpAppName">The name of the section in the initialization file.</param>
        /// <param name="lpKeyName">The name of the key whose value is to be retrieved. This value is in the form of a string; the GetPrivateProfileInt function converts the string into an integer and returns the integer.</param>
        /// <param name="nDefault">The default value to return if the key name cannot be found in the initialization file.</param>
        /// <param name="lpFileName">The name of the initialization file. If this parameter does not contain a full path to the file, the system searches for the file in the Windows directory.The return value is the integer equivalent of the string following the specified key name in the specified initialization file. If the key is not found, the return value is the specified default value.The function searches the file for a key that matches the name specified by the lpKeyName parameter under the section name specified by the lpAppName parameter. A section in the initialization file must have the following form:The GetPrivateProfileInt function is not case-sensitive; the strings in lpAppName and lpKeyName can be a combination of uppercase and lowercase letters.An application can use the GetProfileInt function to retrieve an integer value from the Win.ini file.The system maps most .ini file references to the registry, using the mapping defined under the following registry key:HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\IniFileMappingThis mapping is likely if an application modifies system-component initialization files, such as Control.ini, System.ini, and Winfile.ini. In these cases, the function retrieves information from the registry, not from the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:GetProfileIntWritePrivateProfileString</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetPrivateProfileIntW(string lpAppName, string lpKeyName, uint nDefault, string lpFileName);

        /// <summary>
        ///Retrieves all the keys and values for the specified section of an initialization file.
        /// </summary>
        /// <param name="lpAppName">The name of the section in the initialization file.</param>
        /// <param name="lpReturnedString"></param>
        /// <param name="nSize">The size of the buffer pointed to by the lpReturnedString parameter, in characters.The maximum profile section size is 32,767 characters.</param>
        /// <param name="lpFileName">The name of the initialization file. If this parameter does not contain a full path to the file, the system searches for the file in the Windows directory.The return value specifies the number of characters copied to the buffer, not including the terminating null character. If the buffer is not large enough to contain all the key name and value pairs associated with the named section, the return value is equal to nSize minus two.The data in the buffer pointed to by the lpReturnedString parameter consists of one or more null-terminated strings, followed by a final null character. Each string has the following format:key=stringThe GetPrivateProfileSection function is not case-sensitive; the string pointed to by the lpAppName parameter can be a combination of uppercase and lowercase letters.This operation is atomic; no updates to the specified initialization file are allowed while the key name and value pairs for the section are being copied to the buffer pointed to by the lpReturnedString parameter.The system maps most .ini file references to the registry, using the mapping defined under the following registry key:HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\IniFileMappingThis mapping is likely if an application modifies system-component initialization files, such as Control.ini, System.ini, and Winfile.ini. In these cases, the function retrieves information from the registry, not from the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:GetPrivateProfileSectionNamesGetProfileSectionWritePrivateProfileSection</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetPrivateProfileSection(string lpAppName, out int lpReturnedString, uint nSize, string lpFileName);

        /// <summary>
        ///Retrieves all the keys and values for the specified section of an initialization file.
        /// </summary>
        /// <param name="lpAppName">The name of the section in the initialization file.</param>
        /// <param name="lpReturnedString"></param>
        /// <param name="nSize">The size of the buffer pointed to by the lpReturnedString parameter, in characters.The maximum profile section size is 32,767 characters.</param>
        /// <param name="lpFileName">The name of the initialization file. If this parameter does not contain a full path to the file, the system searches for the file in the Windows directory.The return value specifies the number of characters copied to the buffer, not including the terminating null character. If the buffer is not large enough to contain all the key name and value pairs associated with the named section, the return value is equal to nSize minus two.The data in the buffer pointed to by the lpReturnedString parameter consists of one or more null-terminated strings, followed by a final null character. Each string has the following format:key=stringThe GetPrivateProfileSection function is not case-sensitive; the string pointed to by the lpAppName parameter can be a combination of uppercase and lowercase letters.This operation is atomic; no updates to the specified initialization file are allowed while the key name and value pairs for the section are being copied to the buffer pointed to by the lpReturnedString parameter.The system maps most .ini file references to the registry, using the mapping defined under the following registry key:HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\IniFileMappingThis mapping is likely if an application modifies system-component initialization files, such as Control.ini, System.ini, and Winfile.ini. In these cases, the function retrieves information from the registry, not from the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:GetPrivateProfileSectionNamesGetProfileSectionWritePrivateProfileSection</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetPrivateProfileSectionA(string lpAppName, out string lpReturnedString, uint nSize, string lpFileName);

        /// <summary>
        ///Retrieves the names of all sections in an initialization file.
        /// </summary>
        /// <param name="lpszReturnBuffer"></param>
        /// <param name="nSize">The size of the buffer pointed to by the lpszReturnBuffer parameter, in characters.</param>
        /// <param name="lpFileName">The name of the initialization file. If this parameter is NULL, the function searches the Win.ini file. If this parameter does not contain a full path to the file, the system searches for the file in the Windows directory.The return value specifies the number of characters copied to the specified buffer, not including the terminating null character. If the buffer is not large enough to contain all the section names associated with the specified initialization file, the return value is equal to the size specified by nSize minus two.This operation is atomic; no updates to the initialization file are allowed while the section names are being copied to the buffer.The system maps most .ini file references to the registry, using the mapping defined under the following registry key:HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\IniFileMappingThis mapping is likely if an application modifies system-component initialization files, such as Control.ini, System.ini, and Winfile.ini. In these cases, the function retrieves information from the registry, not from the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:GetPrivateProfileSectionWritePrivateProfileSection</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetPrivateProfileSectionNames(out int lpszReturnBuffer, uint nSize, string lpFileName);

        /// <summary>
        ///Retrieves the names of all sections in an initialization file.
        /// </summary>
        /// <param name="lpszReturnBuffer"></param>
        /// <param name="nSize">The size of the buffer pointed to by the lpszReturnBuffer parameter, in characters.</param>
        /// <param name="lpFileName">The name of the initialization file. If this parameter is NULL, the function searches the Win.ini file. If this parameter does not contain a full path to the file, the system searches for the file in the Windows directory.The return value specifies the number of characters copied to the specified buffer, not including the terminating null character. If the buffer is not large enough to contain all the section names associated with the specified initialization file, the return value is equal to the size specified by nSize minus two.This operation is atomic; no updates to the initialization file are allowed while the section names are being copied to the buffer.The system maps most .ini file references to the registry, using the mapping defined under the following registry key:HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\IniFileMappingThis mapping is likely if an application modifies system-component initialization files, such as Control.ini, System.ini, and Winfile.ini. In these cases, the function retrieves information from the registry, not from the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:GetPrivateProfileSectionWritePrivateProfileSection</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetPrivateProfileSectionNamesA(out string lpszReturnBuffer, uint nSize, string lpFileName);

        /// <summary>
        ///Retrieves the names of all sections in an initialization file.
        /// </summary>
        /// <param name="lpszReturnBuffer"></param>
        /// <param name="nSize">The size of the buffer pointed to by the lpszReturnBuffer parameter, in characters.</param>
        /// <param name="lpFileName">The name of the initialization file. If this parameter is NULL, the function searches the Win.ini file. If this parameter does not contain a full path to the file, the system searches for the file in the Windows directory.The return value specifies the number of characters copied to the specified buffer, not including the terminating null character. If the buffer is not large enough to contain all the section names associated with the specified initialization file, the return value is equal to the size specified by nSize minus two.This operation is atomic; no updates to the initialization file are allowed while the section names are being copied to the buffer.The system maps most .ini file references to the registry, using the mapping defined under the following registry key:HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\IniFileMappingThis mapping is likely if an application modifies system-component initialization files, such as Control.ini, System.ini, and Winfile.ini. In these cases, the function retrieves information from the registry, not from the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:GetPrivateProfileSectionWritePrivateProfileSection</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetPrivateProfileSectionNamesW(out string lpszReturnBuffer, uint nSize, string lpFileName);

        /// <summary>
        ///Retrieves all the keys and values for the specified section of an initialization file.
        /// </summary>
        /// <param name="lpAppName">The name of the section in the initialization file.</param>
        /// <param name="lpReturnedString"></param>
        /// <param name="nSize">The size of the buffer pointed to by the lpReturnedString parameter, in characters.The maximum profile section size is 32,767 characters.</param>
        /// <param name="lpFileName">The name of the initialization file. If this parameter does not contain a full path to the file, the system searches for the file in the Windows directory.The return value specifies the number of characters copied to the buffer, not including the terminating null character. If the buffer is not large enough to contain all the key name and value pairs associated with the named section, the return value is equal to nSize minus two.The data in the buffer pointed to by the lpReturnedString parameter consists of one or more null-terminated strings, followed by a final null character. Each string has the following format:key=stringThe GetPrivateProfileSection function is not case-sensitive; the string pointed to by the lpAppName parameter can be a combination of uppercase and lowercase letters.This operation is atomic; no updates to the specified initialization file are allowed while the key name and value pairs for the section are being copied to the buffer pointed to by the lpReturnedString parameter.The system maps most .ini file references to the registry, using the mapping defined under the following registry key:HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\IniFileMappingThis mapping is likely if an application modifies system-component initialization files, such as Control.ini, System.ini, and Winfile.ini. In these cases, the function retrieves information from the registry, not from the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:GetPrivateProfileSectionNamesGetProfileSectionWritePrivateProfileSection</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetPrivateProfileSectionW(string lpAppName, out string lpReturnedString, uint nSize, string lpFileName);

        /// <summary>
        ///Retrieves a string from the specified section in an initialization file.
        /// </summary>
        /// <param name="lpAppName">The name of the section containing the key name. If this parameter is NULL, the GetPrivateProfileString function copies all section names in the file to the supplied buffer.</param>
        /// <param name="lpKeyName">The name of the key whose associated string is to be retrieved. If this parameter is NULL, all key names in the section specified by the lpAppName parameter are copied to the buffer specified by the lpReturnedString parameter.</param>
        /// <param name="lpDefault">A default string. If the lpKeyName key cannot be found in the initialization file, GetPrivateProfileString copies the default string to the lpReturnedString buffer.If this parameter is NULL, the default is an empty string, "".Avoid specifying a default string with trailing blank characters. The function inserts a null character in the lpReturnedString buffer to strip any trailing blanks.</param>
        /// <param name="lpReturnedString"></param>
        /// <param name="nSize">The size of the buffer pointed to by the lpReturnedString parameter, in characters.</param>
        /// <param name="lpFileName">The name of the initialization file. If this parameter does not contain a full path to the file, the system searches for the file in the Windows directory.The return value is the number of characters copied to the buffer, not including the terminating null character.If neither lpAppName nor lpKeyName is NULL and the supplied destination buffer is too small to hold the requested string, the string is truncated and followed by a null character, and the return value is equal to nSize minus one.If either lpAppName or lpKeyName is NULL and the supplied destination buffer is too small to hold all the strings, the last string is truncated and followed by two null characters. In this case, the return value is equal to nSize minus two.In the event the initialization file specified by lpFileName is not found, or contains invalid values, calling GetLastError will return '0x2' (File Not Found). To retrieve extended error information, call GetLastError.The GetPrivateProfileString function searches the specified initialization file for a key that matches the name specified by the lpKeyName parameter under the section heading specified by the lpAppName parameter. If it finds the key, the function copies the corresponding string to the buffer. If the key does not exist, the function copies the default character string specified by the lpDefault parameter. A section in the initialization file must have the following form:If lpAppName is NULL, GetPrivateProfileString copies all section names in the specified file to the supplied buffer. If lpKeyName is NULL, the function copies all key names in the specified section to the supplied buffer. An application can use this method to enumerate all of the sections and keys in a file. In either case, each string is followed by a null character and the final string is followed by a second null character. If the supplied destination buffer is too small to hold all the strings, the last string is truncated and followed by two null characters.If the string associated with lpKeyName is enclosed in single or double quotation marks, the marks are discarded when the GetPrivateProfileString function retrieves the string.The GetPrivateProfileString function is not case-sensitive; the strings can be a combination of uppercase and lowercase letters.To retrieve a string from the Win.ini file, use the GetProfileString function.The system maps most .ini file references to the registry, using the mapping defined under the following registry key:HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\IniFileMappingThis mapping is likely if an application modifies system-component initialization files, such as Control.ini, System.ini, and Winfile.ini. In these cases, the function retrieves information from the registry, not from the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:The following example demonstrates the use of GetPrivateProfileString.GetProfileStringWritePrivateProfileString</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, out int lpReturnedString, uint nSize, string lpFileName);

        /// <summary>
        ///Retrieves a string from the specified section in an initialization file.
        /// </summary>
        /// <param name="lpAppName">The name of the section containing the key name. If this parameter is NULL, the GetPrivateProfileString function copies all section names in the file to the supplied buffer.</param>
        /// <param name="lpKeyName">The name of the key whose associated string is to be retrieved. If this parameter is NULL, all key names in the section specified by the lpAppName parameter are copied to the buffer specified by the lpReturnedString parameter.</param>
        /// <param name="lpDefault">A default string. If the lpKeyName key cannot be found in the initialization file, GetPrivateProfileString copies the default string to the lpReturnedString buffer.If this parameter is NULL, the default is an empty string, "".Avoid specifying a default string with trailing blank characters. The function inserts a null character in the lpReturnedString buffer to strip any trailing blanks.</param>
        /// <param name="lpReturnedString"></param>
        /// <param name="nSize">The size of the buffer pointed to by the lpReturnedString parameter, in characters.</param>
        /// <param name="lpFileName">The name of the initialization file. If this parameter does not contain a full path to the file, the system searches for the file in the Windows directory.The return value is the number of characters copied to the buffer, not including the terminating null character.If neither lpAppName nor lpKeyName is NULL and the supplied destination buffer is too small to hold the requested string, the string is truncated and followed by a null character, and the return value is equal to nSize minus one.If either lpAppName or lpKeyName is NULL and the supplied destination buffer is too small to hold all the strings, the last string is truncated and followed by two null characters. In this case, the return value is equal to nSize minus two.In the event the initialization file specified by lpFileName is not found, or contains invalid values, this function will set errorno with a value of '0x2' (File Not Found). To retrieve extended error information, call GetLastError.The GetPrivateProfileString function searches the specified initialization file for a key that matches the name specified by the lpKeyName parameter under the section heading specified by the lpAppName parameter. If it finds the key, the function copies the corresponding string to the buffer. If the key does not exist, the function copies the default character string specified by the lpDefault parameter. A section in the initialization file must have the following form:If lpAppName is NULL, GetPrivateProfileString copies all section names in the specified file to the supplied buffer. If lpKeyName is NULL, the function copies all key names in the specified section to the supplied buffer. An application can use this method to enumerate all of the sections and keys in a file. In either case, each string is followed by a null character and the final string is followed by a second null character. If the supplied destination buffer is too small to hold all the strings, the last string is truncated and followed by two null characters.If the string associated with lpKeyName is enclosed in single or double quotation marks, the marks are discarded when the GetPrivateProfileString function retrieves the string.The GetPrivateProfileString function is not case-sensitive; the strings can be a combination of uppercase and lowercase letters.To retrieve a string from the Win.ini file, use the GetProfileString function.The system maps most .ini file references to the registry, using the mapping defined under the following registry key:HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\IniFileMappingThis mapping is likely if an application modifies system-component initialization files, such as Control.ini, System.ini, and Winfile.ini. In these cases, the function retrieves information from the registry, not from the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:The following example demonstrates the use of GetPrivateProfileString.GetProfileStringWritePrivateProfileString</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetPrivateProfileStringA(string lpAppName, string lpKeyName, string lpDefault, out string lpReturnedString, uint nSize, string lpFileName);

        /// <summary>
        ///Retrieves a string from the specified section in an initialization file.
        /// </summary>
        /// <param name="lpAppName">The name of the section containing the key name. If this parameter is NULL, the GetPrivateProfileString function copies all section names in the file to the supplied buffer.</param>
        /// <param name="lpKeyName">The name of the key whose associated string is to be retrieved. If this parameter is NULL, all key names in the section specified by the lpAppName parameter are copied to the buffer specified by the lpReturnedString parameter.</param>
        /// <param name="lpDefault">A default string. If the lpKeyName key cannot be found in the initialization file, GetPrivateProfileString copies the default string to the lpReturnedString buffer.If this parameter is NULL, the default is an empty string, "".Avoid specifying a default string with trailing blank characters. The function inserts a null character in the lpReturnedString buffer to strip any trailing blanks.</param>
        /// <param name="lpReturnedString"></param>
        /// <param name="nSize">The size of the buffer pointed to by the lpReturnedString parameter, in characters.</param>
        /// <param name="lpFileName">The name of the initialization file. If this parameter does not contain a full path to the file, the system searches for the file in the Windows directory.The return value is the number of characters copied to the buffer, not including the terminating null character.If neither lpAppName nor lpKeyName is NULL and the supplied destination buffer is too small to hold the requested string, the string is truncated and followed by a null character, and the return value is equal to nSize minus one.If either lpAppName or lpKeyName is NULL and the supplied destination buffer is too small to hold all the strings, the last string is truncated and followed by two null characters. In this case, the return value is equal to nSize minus two.In the event the initialization file specified by lpFileName is not found, or contains invalid values, this function will set errorno with a value of '0x2' (File Not Found). To retrieve extended error information, call GetLastError.The GetPrivateProfileString function searches the specified initialization file for a key that matches the name specified by the lpKeyName parameter under the section heading specified by the lpAppName parameter. If it finds the key, the function copies the corresponding string to the buffer. If the key does not exist, the function copies the default character string specified by the lpDefault parameter. A section in the initialization file must have the following form:If lpAppName is NULL, GetPrivateProfileString copies all section names in the specified file to the supplied buffer. If lpKeyName is NULL, the function copies all key names in the specified section to the supplied buffer. An application can use this method to enumerate all of the sections and keys in a file. In either case, each string is followed by a null character and the final string is followed by a second null character. If the supplied destination buffer is too small to hold all the strings, the last string is truncated and followed by two null characters.If the string associated with lpKeyName is enclosed in single or double quotation marks, the marks are discarded when the GetPrivateProfileString function retrieves the string.The GetPrivateProfileString function is not case-sensitive; the strings can be a combination of uppercase and lowercase letters.To retrieve a string from the Win.ini file, use the GetProfileString function.The system maps most .ini file references to the registry, using the mapping defined under the following registry key:HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\IniFileMappingThis mapping is likely if an application modifies system-component initialization files, such as Control.ini, System.ini, and Winfile.ini. In these cases, the function retrieves information from the registry, not from the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:The following example demonstrates the use of GetPrivateProfileString.GetProfileStringWritePrivateProfileString</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetPrivateProfileStringW(string lpAppName, string lpKeyName, string lpDefault, out string lpReturnedString, uint nSize, string lpFileName);

        /// <summary>
        ///Retrieves the data associated with a key in the specified section of an initialization file. As it retrieves the data, the function calculates a checksum and compares it with the checksum calculated by the WritePrivateProfileStruct function when the data was added to the file.
        /// </summary>
        /// <param name="lpszSection">The name of the section in the initialization file.</param>
        /// <param name="lpszKey">The name of the key whose data is to be retrieved.</param>
        /// <param name="lpStruct"></param>
        /// <param name="uSizeStruct">The size of the buffer pointed to by the lpStruct parameter, in bytes.</param>
        /// <param name="szFile">The name of the initialization file. If this parameter does not contain a full path to the file, the system searches for the file in the Windows directory.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.A section in the initialization file must have the following form:The system maps most .ini file references to the registry, using the mapping defined under the following registry key:HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\IniFileMappingThis mapping is likely if an application modifies system-component initialization files, such as Control.ini, System.ini, and Winfile.ini. In these cases, the function retrieves information from the registry, not from the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:WritePrivateProfileStruct</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetPrivateProfileStruct(string lpszSection, string lpszKey, out IntPtr lpStruct, int uSizeStruct, string szFile);

        /// <summary>
        ///Retrieves the data associated with a key in the specified section of an initialization file. As it retrieves the data, the function calculates a checksum and compares it with the checksum calculated by the WritePrivateProfileStruct function when the data was added to the file.
        /// </summary>
        /// <param name="lpszSection">The name of the section in the initialization file.</param>
        /// <param name="lpszKey">The name of the key whose data is to be retrieved.</param>
        /// <param name="lpStruct"></param>
        /// <param name="uSizeStruct">The size of the buffer pointed to by the lpStruct parameter, in bytes.</param>
        /// <param name="szFile">The name of the initialization file. If this parameter does not contain a full path to the file, the system searches for the file in the Windows directory.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.A section in the initialization file must have the following form:The system maps most .ini file references to the registry, using the mapping defined under the following registry key:HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\IniFileMappingThis mapping is likely if an application modifies system-component initialization files, such as Control.ini, System.ini, and Winfile.ini. In these cases, the function retrieves information from the registry, not from the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:WritePrivateProfileStruct</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetPrivateProfileStructA(string lpszSection, string lpszKey, out IntPtr lpStruct, int uSizeStruct, string szFile);

        /// <summary>
        ///Retrieves the data associated with a key in the specified section of an initialization file. As it retrieves the data, the function calculates a checksum and compares it with the checksum calculated by the WritePrivateProfileStruct function when the data was added to the file.
        /// </summary>
        /// <param name="lpszSection">The name of the section in the initialization file.</param>
        /// <param name="lpszKey">The name of the key whose data is to be retrieved.</param>
        /// <param name="lpStruct"></param>
        /// <param name="uSizeStruct">The size of the buffer pointed to by the lpStruct parameter, in bytes.</param>
        /// <param name="szFile">The name of the initialization file. If this parameter does not contain a full path to the file, the system searches for the file in the Windows directory.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.A section in the initialization file must have the following form:The system maps most .ini file references to the registry, using the mapping defined under the following registry key:HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\IniFileMappingThis mapping is likely if an application modifies system-component initialization files, such as Control.ini, System.ini, and Winfile.ini. In these cases, the function retrieves information from the registry, not from the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:WritePrivateProfileStruct</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetPrivateProfileStructW(string lpszSection, string lpszKey, out IntPtr lpStruct, int uSizeStruct, string szFile);

        /// <summary>
        ///Retrieves the process affinity mask for the specified process and the system affinity mask for the system.
        /// </summary>
        /// <param name="hProcess">A handle to the process whose affinity mask is desired.This handle must have the PROCESS_QUERY_INFORMATION or PROCESS_QUERY_LIMITED_INFORMATION access right. For more information, see Process Security and Access Rights.Windows Server 2003 and Windows XP:  The handle must have the PROCESS_QUERY_INFORMATION access right.</param>
        /// <param name="lpProcessAffinityMask"></param>
        /// <param name="lpSystemAffinityMask"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetProcessAffinityMask(IntPtr hProcess, out uint lpProcessAffinityMask, out uint lpSystemAffinityMask);

        /// <summary>
        ///Gets the data execution prevention (DEP) and DEP-ATL thunk emulation settings for the specified 32-bit process.Windows XP with SP3:  Gets the DEP and DEP-ATL thunk emulation settings for the current process.
        /// </summary>
        /// <param name="hProcess">A handle to the process. PROCESS_QUERY_INFORMATION privilege is required to get the DEP policy of a process.Windows XP with SP3:  The hProcess parameter is ignored.</param>
        /// <param name="lpFlags"></param>
        /// <param name="lpPermanent"></param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetProcessDEPPolicy(IntPtr hProcess, out uint lpFlags, out bool lpPermanent);

        /// <summary>
        ///Retrieves accounting information for all I/O operations performed by the specified process.
        /// </summary>
        /// <param name="hProcess">A handle to the process. The handle must have the PROCESS_QUERY_INFORMATION or PROCESS_QUERY_LIMITED_INFORMATION access right. For more information, see Process Security and Access Rights.Windows Server 2003 and Windows XP:  The handle must have the PROCESS_QUERY_INFORMATION access right.</param>
        /// <param name="lpIoCounters"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetProcessIoCounters(IntPtr hProcess, out int lpIoCounters);

        /// <summary>
        ///Retrieves an integer from a key in the specified section of the Win.ini file.
        /// </summary>
        /// <param name="lpAppName">The name of the section containing the key name.</param>
        /// <param name="lpKeyName">The name of the key whose value is to be retrieved. This value is in the form of a string; the GetProfileInt function converts the string into an integer and returns the integer.</param>
        /// <param name="nDefault">The default value to return if the key name cannot be found in the initialization file.The return value is the integer equivalent of the string following the key name in Win.ini. If the function cannot find the key, the return value is the default value. If the value of the key is less than zero, the return value is zero.If the key name consists of digits followed by characters that are not numeric, the function returns only the value of the digits. For example, the function returns 102 for the following line: KeyName=102abc.Windows Server 2003 and Windows XP/2000:  Calls to profile functions may be mapped to the registry instead of to the initialization files. This mapping occurs when the initialization file and section are specified in the registry under the following key:HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion\IniFileMappingWhen the operation has been mapped, the GetProfileInt function retrieves information from the registry, not from the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:GetPrivateProfileIntWriteProfileString</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetProfileIntA(string lpAppName, string lpKeyName, uint nDefault);

        /// <summary>
        ///Retrieves an integer from a key in the specified section of the Win.ini file.
        /// </summary>
        /// <param name="lpAppName">The name of the section containing the key name.</param>
        /// <param name="lpKeyName">The name of the key whose value is to be retrieved. This value is in the form of a string; the GetProfileInt function converts the string into an integer and returns the integer.</param>
        /// <param name="nDefault">The default value to return if the key name cannot be found in the initialization file.The return value is the integer equivalent of the string following the key name in Win.ini. If the function cannot find the key, the return value is the default value. If the value of the key is less than zero, the return value is zero.If the key name consists of digits followed by characters that are not numeric, the function returns only the value of the digits. For example, the function returns 102 for the following line: KeyName=102abc.Windows Server 2003 and Windows XP/2000:  Calls to profile functions may be mapped to the registry instead of to the initialization files. This mapping occurs when the initialization file and section are specified in the registry under the following key:HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion\IniFileMappingWhen the operation has been mapped, the GetProfileInt function retrieves information from the registry, not from the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:GetPrivateProfileIntWriteProfileString</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetProfileIntW(string lpAppName, string lpKeyName, uint nDefault);

        /// <summary>
        ///Retrieves all the keys and values for the specified section of the Win.ini file.
        /// </summary>
        /// <param name="lpAppName">The name of the section in the Win.ini file.</param>
        /// <param name="lpReturnedString"></param>
        /// <param name="nSize">The size of the buffer pointed to by the lpReturnedString parameter, in characters.The maximum profile section size is 32,767 characters.The return value specifies the number of characters copied to the specified buffer, not including the terminating null character. If the buffer is not large enough to contain all the keys and values associated with the named section, the return value is equal to the size specified by nSize minus two.The format of the returned keys and values is one or more null-terminated strings, followed by a final null character. Each string has the following form: key=stringThe GetProfileSection function is not case-sensitive; the strings can be a combination of uppercase and lowercase letters.This operation is atomic; no updates to the Win.ini file are allowed while the keys and values for the section are being copied to the buffer.Windows Server 2003 and Windows XP/2000:  Calls to profile functions may be mapped to the registry instead of to the initialization files. This mapping occurs when the initialization file and section are specified in the registry under the following key: HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion\IniFileMapping.When the operation has been mapped, the GetProfileSection function retrieves information from the registry, not from the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:GetPrivateProfileSectionWriteProfileSection</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetProfileSectionA(string lpAppName, out string lpReturnedString, uint nSize);

        /// <summary>
        ///Retrieves all the keys and values for the specified section of the Win.ini file.
        /// </summary>
        /// <param name="lpAppName">The name of the section in the Win.ini file.</param>
        /// <param name="lpReturnedString"></param>
        /// <param name="nSize">The size of the buffer pointed to by the lpReturnedString parameter, in characters.The maximum profile section size is 32,767 characters.The return value specifies the number of characters copied to the specified buffer, not including the terminating null character. If the buffer is not large enough to contain all the keys and values associated with the named section, the return value is equal to the size specified by nSize minus two.The format of the returned keys and values is one or more null-terminated strings, followed by a final null character. Each string has the following form: key=stringThe GetProfileSection function is not case-sensitive; the strings can be a combination of uppercase and lowercase letters.This operation is atomic; no updates to the Win.ini file are allowed while the keys and values for the section are being copied to the buffer.Windows Server 2003 and Windows XP/2000:  Calls to profile functions may be mapped to the registry instead of to the initialization files. This mapping occurs when the initialization file and section are specified in the registry under the following key: HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion\IniFileMapping.When the operation has been mapped, the GetProfileSection function retrieves information from the registry, not from the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:GetPrivateProfileSectionWriteProfileSection</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetProfileSectionW(string lpAppName, out string lpReturnedString, uint nSize);

        /// <summary>
        ///Retrieves the string associated with a key in the specified section of the Win.ini file.
        /// </summary>
        /// <param name="lpAppName">The name of the section containing the key. If this parameter is NULL, the function copies all section names in the file to the supplied buffer.</param>
        /// <param name="lpKeyName">The name of the key whose associated string is to be retrieved. If this parameter is NULL, the function copies all keys in the given section to the supplied buffer. Each string is followed by a null character, and the final string is followed by a second null character.</param>
        /// <param name="lpDefault">A default string. If the lpKeyName key cannot be found in the initialization file, GetProfileString copies the default string to the lpReturnedString buffer. If this parameter is NULL, the default is an empty string, "".Avoid specifying a default string with trailing blank characters. The function inserts a null character in the lpReturnedString buffer to strip any trailing blanks.</param>
        /// <param name="lpReturnedString"></param>
        /// <param name="nSize">The size of the buffer pointed to by the lpReturnedString parameter, in characters.The return value is the number of characters copied to the buffer, not including the null-terminating character.If neither lpAppName nor lpKeyName is NULL and the supplied destination buffer is too small to hold the requested string, the string is truncated and followed by a null character, and the return value is equal to nSize minus one.If either lpAppName or lpKeyName is NULL and the supplied destination buffer is too small to hold all the strings, the last string is truncated and followed by two null characters. In this case, the return value is equal to nSize minus two.If the string associated with the lpKeyName parameter is enclosed in single or double quotation marks, the marks are discarded when the GetProfileString function returns the string.The GetProfileString function is not case-sensitive; the strings can contain a combination of uppercase and lowercase letters.A section in the Win.ini file must have the following form:An application can use the GetPrivateProfileString function to retrieve a string from a specified initialization file.The lpDefault parameter must point to a valid string, even if the string is empty (that is, even if its first character is a null character).Windows Server 2003 and Windows XP/2000:  Calls to profile functions may be mapped to the registry instead of to the initialization files. This mapping occurs when the initialization file and section are specified in the registry under the following keys:HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion\IniFileMappingWhen the operation has been mapped, the GetProfileString function retrieves information from the registry, not from the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:GetPrivateProfileStringWriteProfileString</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetProfileStringA(string lpAppName, string lpKeyName, string lpDefault, out string lpReturnedString, uint nSize);

        /// <summary>
        ///Retrieves the string associated with a key in the specified section of the Win.ini file.
        /// </summary>
        /// <param name="lpAppName">The name of the section containing the key. If this parameter is NULL, the function copies all section names in the file to the supplied buffer.</param>
        /// <param name="lpKeyName">The name of the key whose associated string is to be retrieved. If this parameter is NULL, the function copies all keys in the given section to the supplied buffer. Each string is followed by a null character, and the final string is followed by a second null character.</param>
        /// <param name="lpDefault">A default string. If the lpKeyName key cannot be found in the initialization file, GetProfileString copies the default string to the lpReturnedString buffer. If this parameter is NULL, the default is an empty string, "".Avoid specifying a default string with trailing blank characters. The function inserts a null character in the lpReturnedString buffer to strip any trailing blanks.</param>
        /// <param name="lpReturnedString"></param>
        /// <param name="nSize">The size of the buffer pointed to by the lpReturnedString parameter, in characters.The return value is the number of characters copied to the buffer, not including the null-terminating character.If neither lpAppName nor lpKeyName is NULL and the supplied destination buffer is too small to hold the requested string, the string is truncated and followed by a null character, and the return value is equal to nSize minus one.If either lpAppName or lpKeyName is NULL and the supplied destination buffer is too small to hold all the strings, the last string is truncated and followed by two null characters. In this case, the return value is equal to nSize minus two.If the string associated with the lpKeyName parameter is enclosed in single or double quotation marks, the marks are discarded when the GetProfileString function returns the string.The GetProfileString function is not case-sensitive; the strings can contain a combination of uppercase and lowercase letters.A section in the Win.ini file must have the following form:An application can use the GetPrivateProfileString function to retrieve a string from a specified initialization file.The lpDefault parameter must point to a valid string, even if the string is empty (that is, even if its first character is a null character).Windows Server 2003 and Windows XP/2000:  Calls to profile functions may be mapped to the registry instead of to the initialization files. This mapping occurs when the initialization file and section are specified in the registry under the following keys:HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion\IniFileMappingWhen the operation has been mapped, the GetProfileString function retrieves information from the registry, not from the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:GetPrivateProfileStringWriteProfileString</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetProfileStringW(string lpAppName, string lpKeyName, string lpDefault, out string lpReturnedString, uint nSize);

        /// <summary>
        ///Retrieves the short path form of the specified path.
        /// </summary>
        /// <param name="lpszLongPath">The path string.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="lpszShortPath"></param>
        /// <param name="cchBuffer">The size of the buffer that lpszShortPath points to, in TCHARs.Set this parameter to zero if lpszShortPath is set to NULL.If the function succeeds, the return value is the length, in TCHARs, of the string that is copied to lpszShortPath, not including the terminating null character.If the lpszShortPath buffer is too small to contain the path, the return value is the size of the buffer, in TCHARs, that is required to hold the path and the terminating null character.If the function fails for any other reason, the return value is zero. To get extended error information, call GetLastError.The path that the lpszLongPath parameter specifies does not have to be a full or long path. The short form can be longer than the specified path.If the return value is greater than the value specified in the cchBuffer parameter, you can call the function again with a buffer that is large enough to hold the path. For an example of this case in addition to using zero-length buffer for dynamic allocation, see the Example Code section.You can set the lpszShortPath parameter to the same value as the lpszLongPath parameter; in other words, you can set the output buffer for the short path to the address of the input path string. Always ensure that the cchBuffer parameter accurately represents the total size, in TCHARs, of this buffer.You can obtain the long name of a file from the short name by calling the GetLongPathName function. Alternatively, where GetLongPathName is not available, you can call FindFirstFile on each component of the path to get the corresponding long name.It is possible to have access to a file or directory but not have access to some of the parent directories of that file or directory. As a result, GetShortPathName may fail when it is unable to query the parent directory of a path component to determine the short name for that component. This check can be skipped for directory components that already meet the requirements of a short name. For more information, see the Short vs. Long Names section of Naming Files, Paths, and Namespaces.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB 3.0 does not support short names on shares with continuous availability capability.Resilient File System (ReFS) doesn't support short names. If you call GetShortPathName on a path that doesn't have any short names on-disk, the call will succeed, but will return the long-name path instead. This outcome is also possible with NTFS volumes because there's no guarantee that a short name will exist for a given long name.For an example that uses GetShortPathName, see the Example Code section for GetFullPathName.File Management FunctionsFindFirstFileGetFullPathNameGetLongPathNameNaming Files, Paths, and NamespacesSetFileShortName</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetShortPathNameA(string lpszLongPath, out string lpszShortPath, uint cchBuffer);

        /// <summary>
        ///Gets the data execution prevention (DEP) policy setting for the system.
        /// </summary>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetSystemDEPPolicy();

        /// <summary>
        ///Retrieves the power status of the system. The status indicates whether the system is running on AC or DC power, whether the battery is currently charging, how much battery life remains, and if battery saver is on or off.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetSystemPowerStatus(out int lpSystemPowerStatus);

        /// <summary>
        ///Retrieves the current size of the registry and the maximum size that the registry is allowed to attain on the system.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetSystemRegistryQuota();

        /// <summary>
        ///The GetTapeParameters function retrieves information that describes the tape or the tape drive.
        /// </summary>
        /// <param name="hDevice">Handle to the device about which information is sought. This handle is created by using the CreateFile function.</param>
        /// <param name="dwOperation">Type of information requested. This parameter must be one of the following values.</param>
        /// <param name="lpdwSize"></param>
        /// <param name="lpTapeInformation"></param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetTapeParameters(IntPtr hDevice, uint dwOperation, out uint lpdwSize, out IntPtr lpTapeInformation);

        /// <summary>
        ///The GetTapePosition function retrieves the current address of the tape, in logical or absolute blocks.
        /// </summary>
        /// <param name="hDevice">Handle to the device on which to get the tape position. This handle is created by using CreateFile.</param>
        /// <param name="dwPositionType">Type of address to obtain. This parameter can be one of the following values.</param>
        /// <param name="lpdwPartition"></param>
        /// <param name="lpdwOffsetLow"></param>
        /// <param name="lpdwOffsetHigh"></param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetTapePosition(IntPtr hDevice, uint dwPositionType, out uint lpdwPartition, out uint lpdwOffsetLow, out uint lpdwOffsetHigh);

        /// <summary>
        ///The GetTapeStatus function determines whether the tape device is ready to process tape commands.
        /// </summary>
        /// <param name="hDevice">Handle to the device for which to get the device status. This handle is created by using the CreateFile function.If the tape device is ready to accept appropriate tape-access commands without returning errors, the return value is NO_ERROR.If the function fails, it can return one of the following error codes.CreateFile</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetTapeStatus(IntPtr hDevice);

        /// <summary>
        ///Creates a name for a temporary file. If a unique file name is generated, an empty file is created and the handle to it is released; otherwise, only a file name is generated.
        /// </summary>
        /// <param name="lpPathName">The directory path for the file name. Applications typically specify a period (.) for the current directory or the result of the GetTempPath function. The string cannot be longer than MAX_PATH–14 characters or GetTempFileName will fail. If this parameter is NULL, the function fails.</param>
        /// <param name="lpPrefixString">The null-terminated prefix string. The function uses up to the first three characters of this string as the prefix of the file name. This string must consist of characters in the OEM-defined character set.</param>
        /// <param name="uUnique">An unsigned integer to be used in creating the temporary file name. For more information, see Remarks.If uUnique is zero, the function attempts to form a unique file name using the current system time. If the file already exists, the number is increased by one and the functions tests if this file already exists. This continues until a unique filename is found; the function creates a file by that name and closes it. Note that the function does not attempt to verify the uniqueness of the file name when uUnique is nonzero.</param>
        /// <param name="lpTempFileName"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetTempFileName(string lpPathName, string lpPrefixString, int uUnique, out int lpTempFileName);

        /// <summary>
        ///Retrieves a descriptor table entry for the specified selector and thread.
        /// </summary>
        /// <param name="hThread">A handle to the thread containing the specified selector. The handle must have THREAD_QUERY_INFORMATION access. For more information, see Thread Security and Access Rights.</param>
        /// <param name="dwSelector">The global or local selector value to look up in the thread's descriptor tables.</param>
        /// <param name="lpSelectorEntry"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetThreadSelectorEntry(IntPtr hThread, uint dwSelector, out int lpSelectorEntry);

        /// <summary>
        ///Retrieves a handle to the event associated with the specified user-mode scheduling (UMS) completion list.
        /// </summary>
        /// <param name="UmsCompletionList">A pointer to a UMS completion list. The CreateUmsCompletionList function provides this pointer.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetUmsCompletionListEvent(int UmsCompletionList);

        /// <summary>
        ///Queries whether the specified thread is a UMS scheduler thread, a UMS worker thread, or a non-UMS thread.
        /// </summary>
        /// <param name="ThreadHandle">A handle to a thread. The thread handle must have the THREAD_QUERY_INFORMATION access right. For more information, see Thread Security and Access Rights.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetUmsSystemThreadInformation(IntPtr ThreadHandle);

        /// <summary>
        ///Retrieves the name of the user associated with the current thread.
        /// </summary>
        /// <param name="pcbBuffer">On input, this variable specifies the size of the lpBuffer buffer, in TCHARs. On output, the variable receives the number of TCHARs copied to the buffer, including the terminating null character.If lpBuffer is too small, the function fails and GetLastError returns ERROR_INSUFFICIENT_BUFFER. This parameter receives the required buffer size, including the terminating null character.If the function succeeds, the return value is a nonzero value, and the variable pointed to by lpnSize contains the number of TCHARs copied to the buffer specified by lpBuffer, including the terminating null character.If the function fails, the return value is zero. To get extended error information, call GetLastError.If the current thread is impersonating another client, the GetUserName function returns the user name of the client that the thread is impersonating.If GetUserName is called from a process that is running under the "NETWORK SERVICE" account, the string returned in lpBuffer may be different depending on the version of Windows. On Windows XP, the "NETWORK SERVICE" string is returned. On Windows Vista, the “<HOSTNAME>$” string is returned.For an example, see Getting System Information.GetUserNameExLookupAccountNameSystem Information Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetUserNameA(out string lpBuffer);

        /// <summary>
        ///Retrieves the name of the user associated with the current thread.
        /// </summary>
        /// <param name="pcbBuffer">On input, this variable specifies the size of the lpBuffer buffer, in TCHARs. On output, the variable receives the number of TCHARs copied to the buffer, including the terminating null character.If lpBuffer is too small, the function fails and GetLastError returns ERROR_INSUFFICIENT_BUFFER. This parameter receives the required buffer size, including the terminating null character.If the function succeeds, the return value is a nonzero value, and the variable pointed to by lpnSize contains the number of TCHARs copied to the buffer specified by lpBuffer, including the terminating null character.If the function fails, the return value is zero. To get extended error information, call GetLastError.If the current thread is impersonating another client, the GetUserName function returns the user name of the client that the thread is impersonating.If GetUserName is called from a process that is running under the "NETWORK SERVICE" account, the string returned in lpBuffer may be different depending on the version of Windows. On Windows XP, the "NETWORK SERVICE" string is returned. On Windows Vista, the “<HOSTNAME>$” string is returned.For an example, see Getting System Information.GetUserNameExLookupAccountNameSystem Information Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetUserNameW(out string lpBuffer);

        /// <summary>
        ///Retrieves a volume GUID path for the volume that is associated with the specified volume mount point ( drive letter, volume GUID path, or mounted folder).
        /// </summary>
        /// <param name="lpszVolumeMountPoint">A pointer to a string that contains the path of a mounted folder (for example, "Y:\MountX") or a drive letter (for example, "X:\"). The string must end with a trailing backslash ('').</param>
        /// <param name="lpszVolumeName"></param>
        /// <param name="cchBufferLength">The length of the output buffer, in TCHARs. A reasonable size for the buffer to accommodate the largest possible volume GUID path is 50 characters.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.Use GetVolumeNameForVolumeMountPoint to obtain a volume GUID path for use with functions such as SetVolumeMountPoint and FindFirstVolumeMountPoint that require a volume GUID path as an input parameter. For more information about volume GUID paths, see Naming A Volume.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB does not support volume management functions.Mount points aren't supported by ReFS volumes.DeleteVolumeMountPointGetVolumePathNameMounted FoldersSetVolumeMountPointVolume Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetVolumeNameForVolumeMountPointA(string lpszVolumeMountPoint, out string lpszVolumeName, uint cchBufferLength);

        /// <summary>
        ///Retrieves the volume mount point where the specified path is mounted.
        /// </summary>
        /// <param name="lpszFileName">A pointer to the input path string. Both absolute and relative file and directory names, for example "..", are acceptable in this path.If you specify a relative directory or file name without a volume qualifier, GetVolumePathName returns the drive letter of the boot volume.If this parameter is an empty string, "", the function fails but the last error is set to ERROR_SUCCESS.</param>
        /// <param name="cchBufferLength">The length of the output buffer, in TCHARs.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.If a specified path is passed, GetVolumePathName returns the path to the volume mount point, which means that it returns the root of the volume where the end point of the specified path is located.For example, assume that you have volume D mounted at C:\Mnt\Ddrive and volume E mounted at "C:\Mnt\Ddrive\Mnt\Edrive". Also assume that you have a file with the path "E:\Dir\Subdir\MyFile". If you pass "C:\Mnt\Ddrive\Mnt\Edrive\Dir\Subdir\MyFile" to GetVolumePathName, it returns the path "C:\Mnt\Ddrive\Mnt\Edrive".If either a relative directory or a file is passed without a volume qualifier, the function returns the drive letter of the boot volume. The drive letter of the boot volume is also returned if an invalid file or directory name is specified without a valid volume qualifier. If a valid volume specifier is given, and the volume exists, but an invalid file or directory name is specified, the function will succeed and that volume name will be returned. For examples, see the Examples section of this topic.You must specify a valid Win32 namespace path. If you specify an NT namespace path, for example, "\DosDevices\H:" or "\Device\HardDiskVolume6", the function returns the drive letter of the boot volume, not the drive letter of that NT namespace path.For more information about path names and namespaces, see Naming Files, Paths, and Namespaces.You can specify both local and remote paths. If you specify a local path, GetVolumePathName returns a full path whose prefix is the longest prefix that represents a volume.If a network share is specified, GetVolumePathName returns the shortest path for which GetDriveType returns DRIVE_REMOTE, which means that the path is validated as a remote drive that exists, which the current user can access.There are certain special cases that do not return a trailing backslash. These occur when the output buffer length is one character too short. For example, if lpszFileName is C: and lpszVolumePathName is 4 characters long, the value returned is "C:"; however, if lpszVolumePathName is 3 characters long, the value returned is "C:". A safer but slower way to set the size of the return buffer is to call the GetFullPathName function, and then make sure that the buffer size is at least the same size as the full path that GetFullPathName returns. If the output buffer is more than one character too short, the function will fail and return an error.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB does not support volume management functions.If a remote path to a mounted folder or junction point is specified, the path is parsed as a remote path, and the mounted folder or junction point are ignored. For example if C:\Dir_C is linked to D:\Dir_D and C: is mapped to X: on a remote computer, calling GetVolumePathName and specifying X:\Dir_C on the remote computer returns X:</code>.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetVolumePathNameA(string lpszFileName, out string lpszVolumePathName, uint cchBufferLength);

        /// <summary>
        ///Retrieves a list of drive letters and mounted folder paths for the specified volume.
        /// </summary>
        /// <param name="lpszVolumeName">A volume GUID path for the volume. A volume GUID path is of the form "\?\Volume{xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}".</param>
        /// <param name="lpszVolumePathNames"></param>
        /// <param name="cchBufferLength">The length of the lpszVolumePathNames buffer, in TCHARs, including all NULL characters.</param>
        /// <param name="lpcchReturnLength"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError. If the buffer is not large enough to hold the complete list, the error code is ERROR_MORE_DATA and the lpcchReturnLength parameter receives the required buffer size.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetVolumePathNamesForVolumeNameA(string lpszVolumeName, out IntPtr lpszVolumePathNames, uint cchBufferLength, out uint lpcchReturnLength);

        /// <summary>
        ///Returns the mask of XState features set within a CONTEXT structure.
        /// </summary>
        /// <param name="Context">A pointer to a CONTEXT structure that has been initialized with InitializeContext.</param>
        /// <param name="FeatureMask"></param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetXStateFeaturesMask(int Context, out uint FeatureMask);

        /// <summary>
        ///Adds a character string to the global atom table and returns a unique value (an atom) identifying the string.
        /// </summary>
        /// <param name="lpString">Type: LPCTSTRThe null-terminated string to be added. The string can have a maximum size of 255 bytes. Strings that differ only in case are considered identical. The case of the first string of this name added to the table is preserved and returned by the GlobalGetAtomName function.Alternatively, you can use an integer atom that has been converted using the MAKEINTATOM macro. See the Remarks for more information.Type: ATOMIf the function succeeds, the return value is the newly created atom.If the function fails, the return value is zero. To get extended error information, call GetLastError.If the string already exists in the global atom table, the atom for the existing string is returned and the atom's reference count is incremented.The string associated with the atom is not deleted from memory until its reference count is zero. For more information, see the GlobalDeleteAtom function.Global atoms are not deleted automatically when the application terminates. For every call to the GlobalAddAtom function, there must be a corresponding call to the GlobalDeleteAtom function.If the lpString parameter has the form "#1234", GlobalAddAtom returns an integer atom whose value is the 16-bit representation of the decimal number specified in the string (0x04D2, in this example). If the decimal value specified is 0x0000 or is greater than or equal to 0xC000, the return value is zero, indicating an error. If lpString was created by the MAKEINTATOM macro, the low-order word must be in the range 0x0001 through 0xBFFF. If the low-order word is not in this range, the function fails.If lpString has any other form, GlobalAddAtom returns a string atom.AddAtomDeleteAtomFindAtomGetAtomNameGlobalDeleteAtomGlobalFindAtomGlobalGetAtomNameMAKEINTATOMReference</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GlobalAddAtomA(string lpString);

        /// <summary>
        ///Adds a character string to the global atom table and returns a unique value (an atom) identifying the string.
        /// </summary>
        /// <param name="Flags">If the function succeeds, the return value is the newly created atom.If the function fails, the return value is zero. To get extended error information, call GetLastError.GlobalAddAtom</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GlobalAddAtomExA(uint Flags);

        /// <summary>
        ///Adds a character string to the global atom table and returns a unique value (an atom) identifying the string.
        /// </summary>
        /// <param name="Flags">If the function succeeds, the return value is the newly created atom.If the function fails, the return value is zero. To get extended error information, call GetLastError.GlobalAddAtom</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GlobalAddAtomExW(uint Flags);

        /// <summary>
        ///Adds a character string to the global atom table and returns a unique value (an atom) identifying the string.
        /// </summary>
        /// <param name="lpString">Type: LPCTSTRThe null-terminated string to be added. The string can have a maximum size of 255 bytes. Strings that differ only in case are considered identical. The case of the first string of this name added to the table is preserved and returned by the GlobalGetAtomName function.Alternatively, you can use an integer atom that has been converted using the MAKEINTATOM macro. See the Remarks for more information.Type: ATOMIf the function succeeds, the return value is the newly created atom.If the function fails, the return value is zero. To get extended error information, call GetLastError.If the string already exists in the global atom table, the atom for the existing string is returned and the atom's reference count is incremented.The string associated with the atom is not deleted from memory until its reference count is zero. For more information, see the GlobalDeleteAtom function.Global atoms are not deleted automatically when the application terminates. For every call to the GlobalAddAtom function, there must be a corresponding call to the GlobalDeleteAtom function.If the lpString parameter has the form "#1234", GlobalAddAtom returns an integer atom whose value is the 16-bit representation of the decimal number specified in the string (0x04D2, in this example). If the decimal value specified is 0x0000 or is greater than or equal to 0xC000, the return value is zero, indicating an error. If lpString was created by the MAKEINTATOM macro, the low-order word must be in the range 0x0001 through 0xBFFF. If the low-order word is not in this range, the function fails.If lpString has any other form, GlobalAddAtom returns a string atom.AddAtomDeleteAtomFindAtomGetAtomNameGlobalDeleteAtomGlobalFindAtomGlobalGetAtomNameMAKEINTATOMReference</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GlobalAddAtomW(string lpString);

        /// <summary>
        ///Allocates the specified number of bytes from the heap.
        /// </summary>
        /// <param name="uFlags">The memory allocation attributes. If zero is specified, the default is GMEM_FIXED. This parameter can be one or more of the following values, except for the incompatible combinations that are specifically noted.The following values are obsolete, but are provided for compatibility with 16-bit Windows. They are ignored.</param>
        /// <param name="dwBytes">The number of bytes to allocate. If this parameter is zero and the uFlags parameter specifies GMEM_MOVEABLE, the function returns a handle to a memory object that is marked as discarded.If the function succeeds, the return value is a handle to the newly allocated memory object.If the function fails, the return value is NULL. To get extended error information, call GetLastError.Windows memory management does not provide a separate local heap and global heap. Therefore, the GlobalAlloc and LocalAlloc functions are essentially the same.The movable-memory flags GHND and GMEM_MOVABLE add unnecessary overhead and require locking to be used safely. They should be avoided unless documentation specifically states that they should be used.New applications should use the heap functions to allocate and manage memory unless the documentation specifically states that a global function should be used. For example, the global functions are still used with Dynamic Data Exchange (DDE), the clipboard functions, and OLE data objects.If the GlobalAlloc function succeeds, it allocates at least the amount of memory requested. If the actual amount allocated is greater than the amount requested, the process can use the entire amount. To determine the actual number of bytes allocated, use the GlobalSize function.If the heap does not contain sufficient free space to satisfy the request, GlobalAlloc returns NULL. Because NULL is used to indicate an error, virtual address zero is never allocated. It is, therefore, easy to detect the use of a NULL pointer.Memory allocated with this function is guaranteed to be aligned on an 8-byte boundary. To execute dynamically generated code, use the VirtualAlloc function to allocate memory and the VirtualProtect function to grant PAGE_EXECUTE access.To free the memory, use the GlobalFree function. It is not safe to free memory allocated with GlobalAlloc using LocalFree.The following code shows a simple use of GlobalAlloc and GlobalFree.Global and Local FunctionsGlobalDiscardGlobalFreeGlobalLockGlobalSizeHeap FunctionsMemory Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GlobalAlloc(int uFlags, int dwBytes);

        /// <summary>
        ///Decrements the reference count of a global string atom. If the atom's reference count reaches zero, GlobalDeleteAtom removes the string associated with the atom from the global atom table.
        /// </summary>
        /// <param name="nAtom">Type: ATOMThe atom and character string to be deleted.Type: ATOMThe function always returns (ATOM) 0.To determine whether the function has failed, call SetLastError with ERROR_SUCCESS before calling GlobalDeleteAtom, then call GetLastError. If the last error code is still ERROR_SUCCESS, GlobalDeleteAtom has succeeded.A string atom's reference count specifies the number of times the string has been added to the atom table. The GlobalAddAtom function increments the reference count of a string that already exists in the global atom table each time it is called.Each call to GlobalAddAtom should have a corresponding call to GlobalDeleteAtom. Do not call GlobalDeleteAtom more times than you call GlobalAddAtom, or you may delete the atom while other clients are using it. Applications using Dynamic Data Exchange (DDE) should follow the rules on global atom management to prevent leaks and premature deletion.GlobalDeleteAtom has no effect on an integer atom (an atom whose value is in the range 0x0001 to 0xBFFF). The function always returns zero for an integer atom.For an example, see Initiating a Conversation.AddAtomDeleteAtomFindAtomGlobalAddAtomGlobalFindAtomMAKEINTATOMReference</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GlobalDeleteAtom(int nAtom);

        /// <summary>
        ///Searches the global atom table for the specified character string and retrieves the global atom associated with that string.
        /// </summary>
        /// <param name="lpString">Type: LPCTSTRThe null-terminated character string for which to search.Alternatively, you can use an integer atom that has been converted using the MAKEINTATOM macro. See the Remarks for more information.Type: ATOMIf the function succeeds, the return value is the global atom associated with the given string.If the function fails, the return value is zero. To get extended error information, call GetLastError.Even though the system preserves the case of a string in an atom table as it was originally entered, the search performed by GlobalFindAtom is not case sensitive.If lpString was created by the MAKEINTATOM macro, the low-order word must be in the range 0x0001 through 0xBFFF. If the low-order word is not in this range, the function fails.AddAtomDeleteAtomFindAtomGetAtomNameGlobalAddAtomGlobalDeleteAtomGlobalGetAtomNameReference</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GlobalFindAtomA(string lpString);

        /// <summary>
        ///Searches the global atom table for the specified character string and retrieves the global atom associated with that string.
        /// </summary>
        /// <param name="lpString">Type: LPCTSTRThe null-terminated character string for which to search.Alternatively, you can use an integer atom that has been converted using the MAKEINTATOM macro. See the Remarks for more information.Type: ATOMIf the function succeeds, the return value is the global atom associated with the given string.If the function fails, the return value is zero. To get extended error information, call GetLastError.Even though the system preserves the case of a string in an atom table as it was originally entered, the search performed by GlobalFindAtom is not case sensitive.If lpString was created by the MAKEINTATOM macro, the low-order word must be in the range 0x0001 through 0xBFFF. If the low-order word is not in this range, the function fails.AddAtomDeleteAtomFindAtomGetAtomNameGlobalAddAtomGlobalDeleteAtomGlobalGetAtomNameReference</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GlobalFindAtomW(string lpString);

        /// <summary>
        ///Retrieves information about the specified global memory object.
        /// </summary>
        /// <param name="hMem">A handle to the global memory object. This handle is returned by either the GlobalAlloc or GlobalReAlloc function.If the function succeeds, the return value specifies the allocation values and the lock count for the memory object.If the function fails, the return value is GMEM_INVALID_HANDLE, indicating that the global handle is not valid. To get extended error information, call GetLastError.The low-order byte of the low-order word of the return value contains the lock count of the object. To retrieve the lock count from the return value, use the GMEM_LOCKCOUNT mask with the bitwise AND (&) operator. The lock count of memory objects allocated with GMEM_FIXED is always zero.The high-order byte of the low-order word of the return value indicates the allocation values of the memory object. It can be zero or GMEM_DISCARDED.The global functions have greater overhead and provide fewer features than other memory management functions. New applications should use the heap functions unless documentation states that a global function should be used. For more information, see Global and Local Functions.Global and Local FunctionsGlobalAllocGlobalDiscardGlobalReAllocMemory Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GlobalFlags(IntPtr hMem);

        /// <summary>
        ///Frees the specified global memory object and invalidates its handle.
        /// </summary>
        /// <param name="hMem">A handle to the global memory object. This handle is returned by either the GlobalAlloc or GlobalReAlloc function. It is not safe to free memory allocated with LocalAlloc.If the function succeeds, the return value is NULL.If the function fails, the return value is equal to a handle to the global memory object. To get extended error information, call GetLastError.If the process examines or modifies the memory after it has been freed, heap corruption may occur or an access violation exception (EXCEPTION_ACCESS_VIOLATION) may be generated.The GlobalFree function will free a locked memory object. A locked memory object has a lock count greater than zero. The GlobalLock function locks a global memory object and increments the lock count by one. The GlobalUnlock function unlocks it and decrements the lock count by one. To get the lock count of a global memory object, use the GlobalFlags function.If an application is running under a debug version of the system, GlobalFree will issue a message that tells you that a locked object is being freed. If you are debugging the application, GlobalFree will enter a breakpoint just before freeing a locked object. This allows you to verify the intended behavior, then continue execution.For an example, see GlobalAlloc.Global and Local FunctionsGlobalAllocGlobalFlagsGlobalLockGlobalReAllocGlobalUnlockMemory Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr GlobalFree(int hMem);

        /// <summary>
        ///Retrieves a copy of the character string associated with the specified global atom.
        /// </summary>
        /// <param name="nAtom">Type: ATOMThe global atom associated with the character string to be retrieved.</param>
        /// <param name="lpBuffer"></param>
        /// <param name="nSize">Type: intThe size, in characters, of the buffer.Type: UINTIf the function succeeds, the return value is the length of the string copied to the buffer, in characters, not including the terminating null character.If the function fails, the return value is zero. To get extended error information, call GetLastError.The string returned for an integer atom (an atom whose value is in the range 0x0001 to 0xBFFF) is a null-terminated string in which the first character is a pound sign (#) and the remaining characters represent the unsigned integer atom value.AddAtomDeleteAtomFindAtomGlobalAddAtomGlobalDeleteAtomGlobalFindAtomMAKEINTATOMReference</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GlobalGetAtomNameA(int nAtom, out string lpBuffer, uint nSize);

        /// <summary>
        ///Retrieves a copy of the character string associated with the specified global atom.
        /// </summary>
        /// <param name="nAtom">Type: ATOMThe global atom associated with the character string to be retrieved.</param>
        /// <param name="lpBuffer"></param>
        /// <param name="nSize">Type: intThe size, in characters, of the buffer.Type: UINTIf the function succeeds, the return value is the length of the string copied to the buffer, in characters, not including the terminating null character.If the function fails, the return value is zero. To get extended error information, call GetLastError.The string returned for an integer atom (an atom whose value is in the range 0x0001 to 0xBFFF) is a null-terminated string in which the first character is a pound sign (#) and the remaining characters represent the unsigned integer atom value.AddAtomDeleteAtomFindAtomGlobalAddAtomGlobalDeleteAtomGlobalFindAtomMAKEINTATOMReference</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GlobalGetAtomNameW(int nAtom, out string lpBuffer, uint nSize);

        /// <summary>
        ///Retrieves the handle associated with the specified pointer to a global memory block.
        /// </summary>
        /// <param name="pMem">A pointer to the first byte of the global memory block. This pointer is returned by the GlobalLock function.If the function succeeds, the return value is a handle to the specified global memory object.If the function fails, the return value is NULL. To get extended error information, call GetLastError.When the GlobalAlloc function allocates a memory object with GMEM_MOVEABLE, it returns a handle to the object. The GlobalLock function converts this handle into a pointer to the memory block, and GlobalHandle converts the pointer back into a handle.Global and Local FunctionsGlobalAllocGlobalLockMemory Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr GlobalHandle(IntPtr pMem);

        /// <summary>
        ///Locks a global memory object and returns a pointer to the first byte of the object's memory block.
        /// </summary>
        /// <param name="hMem">A handle to the global memory object. This handle is returned by either the GlobalAlloc or GlobalReAlloc function.If the function succeeds, the return value is a pointer to the first byte of the memory block.If the function fails, the return value is NULL. To get extended error information, call GetLastError.The internal data structures for each memory object include a lock count that is initially zero. For movable memory objects, GlobalLock increments the count by one, and the GlobalUnlock function decrements the count by one. Each successful call that a process makes to GlobalLock for an object must be matched by a corresponding call to GlobalUnlock. Locked memory will not be moved or discarded, unless the memory object is reallocated by using the GlobalReAlloc function. The memory block of a locked memory object remains locked until its lock count is decremented to zero, at which time it can be moved or discarded.Memory objects allocated with GMEM_FIXED always have a lock count of zero. For these objects, the value of the returned pointer is equal to the value of the specified handle.If the specified memory block has been discarded or if the memory block has a zero-byte size, this function returns NULL.Discarded objects always have a lock count of zero.Global and Local FunctionsGlobalAllocGlobalReAllocGlobalUnlockMemory Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void GlobalLock(IntPtr hMem);

        /// <summary>
        ///[GlobalMemoryStatus can return incorrect information. Use the GlobalMemoryStatusEx function instead.]
        /// </summary>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void GlobalMemoryStatus(out int lpBuffer);

        /// <summary>
        ///Changes the size or attributes of a specified global memory object. The size can increase or decrease.
        /// </summary>
        /// <param name="hMem">A handle to the global memory object to be reallocated. This handle is returned by either the GlobalAlloc or GlobalReAlloc function.</param>
        /// <param name="dwBytes">The new size of the memory block, in bytes. If uFlags specifies GMEM_MODIFY, this parameter is ignored.</param>
        /// <param name="uFlags">The reallocation options. If GMEM_MODIFY is specified, the function modifies the attributes of the memory object only (the dwBytes parameter is ignored.) Otherwise, the function reallocates the memory object.You can optionally combine GMEM_MODIFY with the following value.If this parameter does not specify GMEM_MODIFY, you can use the following value.If the function succeeds, the return value is a handle to the reallocated memory object.If the function fails, the return value is NULL. To get extended error information, call GetLastError.If GlobalReAlloc reallocates a movable object, the return value is a handle to the memory object. To convert the handle to a pointer, use the GlobalLock function.If GlobalReAlloc reallocates a fixed object, the value of the handle returned is the address of the first byte of the memory block. To access the memory, a process can simply cast the return value to a pointer.If GlobalReAlloc fails, the original memory is not freed, and the original handle and pointer are still valid.Global and Local FunctionsGlobalAllocGlobalDiscardGlobalLockMemory Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GlobalReAlloc(int hMem, int dwBytes, int uFlags);

        /// <summary>
        ///Retrieves the current size of the specified global memory object, in bytes.
        /// </summary>
        /// <param name="hMem">A handle to the global memory object. This handle is returned by either the GlobalAlloc or GlobalReAlloc function.If the function succeeds, the return value is the size of the specified global memory object, in bytes.If the specified handle is not valid or if the object has been discarded, the return value is zero. To get extended error information, call GetLastError.The size of a memory block may be larger than the size requested when the memory was allocated.To verify that the specified object's memory block has not been discarded, use the GlobalFlags function before calling GlobalSize.Global and Local FunctionsGlobalAllocGlobalFlagsGlobalReAllocMemory Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GlobalSize(IntPtr hMem);

        /// <summary>
        ///Decrements the lock count associated with a memory object that was allocated with GMEM_MOVEABLE. This function has no effect on memory objects allocated with GMEM_FIXED.
        /// </summary>
        /// <param name="hMem">A handle to the global memory object. This handle is returned by either the GlobalAlloc or GlobalReAlloc function.If the memory object is still locked after decrementing the lock count, the return value is a nonzero value. If the memory object is unlocked after decrementing the lock count, the function returns zero and GetLastError returns NO_ERROR.If the function fails, the return value is zero and GetLastError returns a value other than NO_ERROR.The internal data structures for each memory object include a lock count that is initially zero. For movable memory objects, the GlobalLock function increments the count by one, and GlobalUnlock decrements the count by one. For each call that a process makes to GlobalLock for an object, it must eventually call GlobalUnlock. Locked memory will not be moved or discarded, unless the memory object is reallocated by using the GlobalReAlloc function. The memory block of a locked memory object remains locked until its lock count is decremented to zero, at which time it can be moved or discarded.Memory objects allocated with GMEM_FIXED always have a lock count of zero. If the specified memory block is fixed memory, this function returns TRUE.If the memory object is already unlocked, GlobalUnlock returns FALSE and GetLastError reports ERROR_NOT_LOCKED.A process should not rely on the return value to determine the number of times it must subsequently call GlobalUnlock for a memory object.Global and Local FunctionsGlobalAllocGlobalLockGlobalReAllocMemory Management Functions</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GlobalUnlock(IntPtr hMem);

        /// <summary>
        ///Initializes the local atom table and sets the number of hash buckets to the specified size.
        /// </summary>
        /// <param name="nSize">Type: DWORDThe number of hash buckets to use for the atom table. If this parameter is zero, the default number of hash buckets are created.To achieve better performance, specify a prime number in nSize.Type: BOOLIf the function succeeds, the return value is nonzero.If the function fails, the return value is zero.An application need not use this function to use a local atom table. The default number of hash buckets used is 37. If an application does use InitAtomTable, however, it should call the function before any other atom-management function.If an application uses a large number of local atoms, it can reduce the time required to add an atom to the local atom table or to find an atom in the table by increasing the size of the table. However, this increases the amount of memory required to maintain the table.The number of buckets in the global atom table cannot be changed. If the atom table has already been initialized, either explicitly by a prior call to InitAtomTable, or implicitly by the use of any atom-management function, InitAtomTable returns success without changing the number of hash buckets.AddAtomDeleteAtomFindAtomGetAtomNameGlobalAddAtomGlobalDeleteAtomGlobalFindAtomGlobalGetAtomNameReference</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool InitAtomTable(uint nSize);

        /// <summary>
        ///Initializes a CONTEXT structure inside a buffer with the necessary size and alignment.
        /// </summary>
        /// <param name="ContextFlags">A value indicating which portions of the Context structure should be initialized. This parameter influences the size of the initialized Context structure.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool InitializeContext(uint ContextFlags);

        /// <summary>
        ///Determines whether the calling process has read access to the memory at the specified address.
        /// </summary>
        /// <param name="lpfn">A pointer to a memory address.If the calling process has read access to the specified memory, the return value is zero.If the calling process does not have read access to the specified memory, the return value is nonzero. To get extended error information, call GetLastError.If the application is compiled as a debugging version, and the process does not have read access to the specified memory location, the function causes an assertion and breaks into the debugger. Leaving the debugger, the function continues as usual, and returns a nonzero value. This behavior is by design, as a debugging aid.In a preemptive multitasking environment, it is possible for some other thread to change the process's access to the memory being tested. Even when the function indicates that the process has read access to the specified memory, you should use structured exception handling when attempting to access the memory. Use of structured exception handling enables the system to notify the process if an access violation exception occurs, giving the process an opportunity to handle the exception.IsBadReadPtrIsBadStringPtrIsBadWritePtr</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IsBadCodePtr(int lpfn);

        /// <summary>
        ///Verifies that the calling process has read access to the specified range of memory.
        /// </summary>
        /// <param name="lp">A pointer to the first byte of the memory block.</param>
        /// <param name="ucb">The size of the memory block, in bytes. If this parameter is zero, the return value is zero.If the calling process has read access to all bytes in the specified memory range, the return value is zero.If the calling process does not have read access to all bytes in the specified memory range, the return value is nonzero.If the application is compiled as a debugging version, and the process does not have read access to all bytes in the specified memory range, the function causes an assertion and breaks into the debugger. Leaving the debugger, the function continues as usual, and returns a nonzero value. This behavior is by design, as a debugging aid.This function is typically used when working with pointers returned from third-party libraries, where you cannot determine the memory management behavior in the third-party DLL.Threads in a process are expected to cooperate in such a way that one will not free memory that the other needs. Use of this function does not negate the need to do this. If this is not done, the application may fail in an unpredictable manner.Dereferencing potentially invalid pointers can disable stack expansion in other threads. A thread exhausting its stack, when stack expansion has been disabled, results in the immediate termination of the parent process, with no pop-up error window or diagnostic information.If the calling process has read access to some, but not all, of the bytes in the specified memory range, the return value is nonzero.In a preemptive multitasking environment, it is possible for some other thread to change the process's access to the memory being tested. Even when the function indicates that the process has read access to the specified memory, you should use structured exception handling when attempting to access the memory. Use of structured exception handling enables the system to notify the process if an access violation exception occurs, giving the process an opportunity to handle the exception.IsBadCodePtrIsBadStringPtrIsBadWritePtr</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IsBadReadPtr(IntPtr lp, int ucb);

        /// <summary>
        ///Verifies that the calling process has read access to the specified range of memory.
        /// </summary>
        /// <param name="lpsz">A pointer to a null-terminated string, either Unicode or ASCII.</param>
        /// <param name="ucchMax">The maximum size of the string, in TCHARs. The function checks for read access in all characters up to the string's terminating null character or up to the number of characters specified by this parameter, whichever is smaller. If this parameter is zero, the return value is zero.If the calling process has read access to all characters up to the string's terminating null character or up to the number of characters specified by ucchMax, the return value is zero.If the calling process does not have read access to all characters up to the string's terminating null character or up to the number of characters specified by ucchMax, the return value is nonzero.If the application is compiled as a debugging version, and the process does not have read access to the entire memory range specified, the function causes an assertion and breaks into the debugger. Leaving the debugger, the function continues as usual, and returns a nonzero value This behavior is by design, as a debugging aid.This function is typically used when working with pointers returned from third-party libraries, where you cannot determine the memory management behavior in the third-party DLL.Threads in a process are expected to cooperate in such a way that one will not free memory that the other needs. Use of this function does not negate the need to do this. If this is not done, the application may fail in an unpredictable manner.Dereferencing potentially invalid pointers can disable stack expansion in other threads. A thread exhausting its stack, when stack expansion has been disabled, results in the immediate termination of the parent process, with no pop-up error window or diagnostic information.If the calling process has read access to some, but not all, of the specified memory range, the return value is nonzero.In a preemptive multitasking environment, it is possible for some other thread to change the process's access to the memory being tested. Even when the function indicates that the process has read access to the specified memory, you should use structured exception handling when attempting to access the memory. Use of structured exception handling enables the system to notify the process if an access violation exception occurs, giving the process an opportunity to handle the exception.IsBadCodePtrIsBadReadPtrIsBadWritePtr</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IsBadStringPtrA(string lpsz, int ucchMax);

        /// <summary>
        ///Verifies that the calling process has read access to the specified range of memory.
        /// </summary>
        /// <param name="lpsz">A pointer to a null-terminated string, either Unicode or ASCII.</param>
        /// <param name="ucchMax">The maximum size of the string, in TCHARs. The function checks for read access in all characters up to the string's terminating null character or up to the number of characters specified by this parameter, whichever is smaller. If this parameter is zero, the return value is zero.If the calling process has read access to all characters up to the string's terminating null character or up to the number of characters specified by ucchMax, the return value is zero.If the calling process does not have read access to all characters up to the string's terminating null character or up to the number of characters specified by ucchMax, the return value is nonzero.If the application is compiled as a debugging version, and the process does not have read access to the entire memory range specified, the function causes an assertion and breaks into the debugger. Leaving the debugger, the function continues as usual, and returns a nonzero value This behavior is by design, as a debugging aid.This function is typically used when working with pointers returned from third-party libraries, where you cannot determine the memory management behavior in the third-party DLL.Threads in a process are expected to cooperate in such a way that one will not free memory that the other needs. Use of this function does not negate the need to do this. If this is not done, the application may fail in an unpredictable manner.Dereferencing potentially invalid pointers can disable stack expansion in other threads. A thread exhausting its stack, when stack expansion has been disabled, results in the immediate termination of the parent process, with no pop-up error window or diagnostic information.If the calling process has read access to some, but not all, of the specified memory range, the return value is nonzero.In a preemptive multitasking environment, it is possible for some other thread to change the process's access to the memory being tested. Even when the function indicates that the process has read access to the specified memory, you should use structured exception handling when attempting to access the memory. Use of structured exception handling enables the system to notify the process if an access violation exception occurs, giving the process an opportunity to handle the exception.IsBadCodePtrIsBadReadPtrIsBadWritePtr</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IsBadStringPtrW(string lpsz, int ucchMax);

        /// <summary>
        ///Verifies that the calling process has write access to the specified range of memory.
        /// </summary>
        /// <param name="lp">A pointer to the first byte of the memory block.</param>
        /// <param name="ucb">The size of the memory block, in bytes. If this parameter is zero, the return value is zero.If the calling process has write access to all bytes in the specified memory range, the return value is zero.If the calling process does not have write access to all bytes in the specified memory range, the return value is nonzero.If the application is run under a debugger and the process does not have write access to all bytes in the specified memory range, the function causes a first chance STATUS_ACCESS_VIOLATION exception. The debugger can be configured to break for this condition. After resuming process execution in the debugger, the function continues as usual and returns a nonzero value This behavior is by design and serves as a debugging aid.This function is typically used when working with pointers returned from third-party libraries, where you cannot determine the memory management behavior in the third-party DLL.Threads in a process are expected to cooperate in such a way that one will not free memory that the other needs. Use of this function does not negate the need to do this. If this is not done, the application may fail in an unpredictable manner.Dereferencing potentially invalid pointers can disable stack expansion in other threads. A thread exhausting its stack, when stack expansion has been disabled, results in the immediate termination of the parent process, with no pop-up error window or diagnostic information.If the calling process has write access to some, but not all, of the bytes in the specified memory range, the return value is nonzero.In a preemptive multitasking environment, it is possible for some other thread to change the process's access to the memory being tested. Even when the function indicates that the process has write access to the specified memory, you should use structured exception handling when attempting to access the memory. Use of structured exception handling enables the system to notify the process if an access violation exception occurs, giving the process an opportunity to handle the exception.IsBadWritePtr is not multithread safe. To use it properly on a pointer shared by multiple threads, call it inside a critical region of code that allows only one thread to access the memory being checked. Use operating system–level objects such as critical sections or mutexes or the interlocked functions to create the critical region of code.IsBadCodePtrIsBadReadPtrIsBadStringPtr</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IsBadWritePtr(IntPtr lp, int ucb);

        /// <summary>
        ///Indicates if the OS was booted from a VHD container.
        /// </summary>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IsNativeVhdBoot(out bool NativeVhdBoot);

        /// <summary>
        ///Determines the current state of the computer.
        /// </summary>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IsSystemResumeAutomatic();

        /// <summary>
        ///Determines if a buffer is likely to contain a form of Unicode text.
        /// </summary>
        /// <param name="lpv">Pointer to the input buffer to examine.</param>
        /// <param name="iSize">Size, in bytes, of the input buffer indicated by lpv.</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IsTextUnicode(IntPtr lpv, uint iSize);

        /// <summary>
        ///Loads and executes an application or creates a new instance of an existing application.
        /// </summary>
        /// <param name="lpModuleName">The file name of the application to be run. When specifying a path, be sure to use backslashes (\), not forward slashes (/). If the lpModuleName parameter does not contain a directory path, the system searches for the executable file in this order:</param>
        /// <param name="lpParameterBlock">A pointer to an application-defined LOADPARMS32 structure that defines the new application's parameter block.Set all unused members to NULL, except for lpCmdLine, which must point to a null-terminated string if it is not used. For more information, see Remarks.If the function succeeds, the return value is greater than 31.If the function fails, the return value is an error value, which may be one of the following values.The LOADPARMS32 structure has the following form:Applications should use the CreateProcess function instead of LoadModule. The LoadModule function calls CreateProcess by forming the parameters as follows.CreateProcessDynamic-Link Library FunctionsGetSystemDirectoryGetWindowsDirectory</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint LoadModule(string lpModuleName, IntPtr lpParameterBlock);

        /// <summary>
        ///Loads the specified packaged module and its dependencies into the address space of the calling process.
        /// </summary>
        /// <param name="lpwLibFileName">The file name of the packaged module to load. The module can be a library module (a .dll file) or an executable module (an .exe file).If this parameter specifies a module name without a path and the file name extension is omitted, the function appends the default library extension .dll to the module name. To prevent the function from appending .dll to the module name, include a trailing point character (.) in the module name string.If this parameter specifies a path, the function searches that path for the module. The path cannot be an absolute path or a relative path that contains ".." in the path. When specifying a path, be sure to use backslashes (\), not forward slashes (/). For more information about paths, see Naming Files, Paths, and Namespaces.If the specified module is already loaded in the process, the function returns a handle to the loaded module. The module must have been originally loaded from the package dependency graph of the process.If loading the specified module causes the system to load other associated modules, the function first searches loaded modules, then it searches the package dependency graph of the process. For more information, see Remarks.ReservedThis parameter is reserved. It must be 0.If the function succeeds, the return value is a handle to the loaded module.If the function fails, the return value is NULL. To get extended error information, call GetLastError.The LoadPackagedLibrary function is a simplified version of LoadLibraryEx. Packaged apps can use LoadPackagedLibrary to load packaged modules. Unpackaged applications cannot use LoadPackagedLibrary; if a unpackaged application calls this function it fails with APPMODEL_ERROR_NO_PACKAGE.LoadPackagedLibrary returns a handle to the specified module and increments its reference count. If the module is already loaded, the function returns a handle to the loaded module. The calling process can use the handle returned by LoadPackagedLibrary to identify the module in calls to the GetProcAddress function. Use the FreeLibrary function to free a loaded module and decrement its reference count.If the function must search for the specified module or its dependencies, it searches only the package dependency graph of the process. This is the application's package plus any dependencies specified as <PackageDependency> in the <Dependencies> section of the application's package manifest. Dependencies are searched in the order they appear in the manifest. The package dependency graph is specified in the <Dependencies> section of the application's package manifest. Dependencies are searched in the order they appear in the manifest. The search proceeds as follows:On Windows Phone, LoadPackagedLibrary must be called from PhoneAppModelHost.dll. Using Kernel32.dll is not supported.Dynamic-Link Library Search Order</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr LoadPackagedLibrary(string lpwLibFileName);

        /// <summary>
        ///Allocates the specified number of bytes from the heap.
        /// </summary>
        /// <param name="uFlags">The memory allocation attributes. The default is the LMEM_FIXED value. This parameter can be one or more of the following values, except for the incompatible combinations that are specifically noted.The following values are obsolete, but are provided for compatibility with 16-bit Windows. They are ignored.</param>
        /// <param name="uBytes">The number of bytes to allocate. If this parameter is zero and the uFlags parameter specifies LMEM_MOVEABLE, the function returns a handle to a memory object that is marked as discarded.If the function succeeds, the return value is a handle to the newly allocated memory object.If the function fails, the return value is NULL. To get extended error information, call GetLastError.Windows memory management does not provide a separate local heap and global heap. Therefore, the LocalAlloc and GlobalAlloc functions are essentially the same.The movable-memory flags LHND, LMEM_MOVABLE, and NONZEROLHND add unnecessary overhead and require locking to be used safely. They should be avoided unless documentation specifically states that they should be used.New applications should use the heap functions unless the documentation specifically states that a local function should be used. For example, some Windows functions allocate memory that must be freed with LocalFree.If the heap does not contain sufficient free space to satisfy the request, LocalAlloc returns NULL. Because NULL is used to indicate an error, virtual address zero is never allocated. It is, therefore, easy to detect the use of a NULL pointer.If the LocalAlloc function succeeds, it allocates at least the amount requested. If the amount allocated is greater than the amount requested, the process can use the entire amount. To determine the actual number of bytes allocated, use the LocalSize function.To free the memory, use the LocalFree function. It is not safe to free memory allocated with LocalAlloc using GlobalFree.The following code shows a simple use of LocalAlloc and LocalFree.Global and Local FunctionsHeap FunctionsLocalFreeLocalLockLocalReAllocLocalSizeMemory Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr LocalAlloc(int uFlags, int uBytes);

        /// <summary>
        ///Retrieves information about the specified local memory object.
        /// </summary>
        /// <param name="hMem">A handle to the local memory object. This handle is returned by either the LocalAlloc or LocalReAlloc function.If the function succeeds, the return value specifies the allocation values and the lock count for the memory object.If the function fails, the return value is LMEM_INVALID_HANDLE, indicating that the local handle is not valid. To get extended error information, call GetLastError.The low-order byte of the low-order word of the return value contains the lock count of the object. To retrieve the lock count from the return value, use the LMEM_LOCKCOUNT mask with the bitwise AND (&) operator. The lock count of memory objects allocated with LMEM_FIXED is always zero.The high-order byte of the low-order word of the return value indicates the allocation values of the memory object. It can be zero or LMEM_DISCARDABLE.The local functions have greater overhead and provide fewer features than other memory management functions. New applications should use the heap functions unless documentation states that a local function should be used. For more information, see Global and Local Functions.Global and Local FunctionsGlobalFlagsLocalAllocLocalDiscardLocalLockLocalReAllocLocalUnlockMemory Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr LocalFlags(IntPtr hMem);

        /// <summary>
        ///Frees the specified local memory object and invalidates its handle.
        /// </summary>
        /// <param name="hMem">A handle to the local memory object. This handle is returned by either the LocalAlloc or LocalReAlloc function. It is not safe to free memory allocated with GlobalAlloc.If the function succeeds, the return value is NULL.If the function fails, the return value is equal to a handle to the local memory object. To get extended error information, call GetLastError.If the process tries to examine or modify the memory after it has been freed, heap corruption may occur or an access violation exception (EXCEPTION_ACCESS_VIOLATION) may be generated.If the hMem parameter is NULL, LocalFree ignores the parameter and returns NULL.The LocalFree function will free a locked memory object. A locked memory object has a lock count greater than zero. The LocalLock function locks a local memory object and increments the lock count by one. The LocalUnlock function unlocks it and decrements the lock count by one. To get the lock count of a local memory object, use the LocalFlags function.If an application is running under a debug version of the system, LocalFree will issue a message that tells you that a locked object is being freed. If you are debugging the application, LocalFree will enter a breakpoint just before freeing a locked object. This allows you to verify the intended behavior, then continue execution.For an example, see LocalAlloc.Global and Local FunctionsGlobalFreeLocalAllocLocalFlagsLocalLockLocalReAllocLocalUnlockMemory Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr LocalFree(IntPtr hMem);

        /// <summary>
        ///Retrieves the handle associated with the specified pointer to a local memory object.
        /// </summary>
        /// <param name="pMem">A pointer to the first byte of the local memory object. This pointer is returned by the LocalLock function.If the function succeeds, the return value is a handle to the specified local memory object.If the function fails, the return value is NULL. To get extended error information, call GetLastError.When the LocalAlloc function allocates a local memory object with LMEM_MOVEABLE, it returns a handle to the object. The LocalLock function converts this handle into a pointer to the object's memory block, and LocalHandle converts the pointer back into a handle.Global and Local FunctionsLocalAllocLocalLockMemory Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr LocalHandle(IntPtr pMem);

        /// <summary>
        ///Locks a local memory object and returns a pointer to the first byte of the object's memory block.
        /// </summary>
        /// <param name="hMem">A handle to the local memory object. This handle is returned by either the LocalAlloc or LocalReAlloc function.If the function succeeds, the return value is a pointer to the first byte of the memory block.If the function fails, the return value is NULL. To get extended error information, call GetLastError.The internal data structures for each memory object include a lock count that is initially zero. For movable memory objects, LocalLock increments the count by one, and the LocalUnlock function decrements the count by one. Each successful call that a process makes to LocalLock for an object must be matched by a corresponding call to LocalUnlock. Locked memory will not be moved or discarded unless the memory object is reallocated by using the LocalReAlloc function. The memory block of a locked memory object remains locked in memory until its lock count is decremented to zero, at which time it can be moved or discarded.Memory objects allocated with LMEM_FIXED always have a lock count of zero. For these objects, the value of the returned pointer is equal to the value of the specified handle.If the specified memory block has been discarded or if the memory block has a zero-byte size, this function returns NULL.Discarded objects always have a lock count of zero.Global and Local FunctionsLocalAllocLocalFlagsLocalReAllocLocalUnlockMemory Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void LocalLock(IntPtr hMem);

        /// <summary>
        ///Changes the size or the attributes of a specified local memory object. The size can increase or decrease.
        /// </summary>
        /// <param name="hMem">A handle to the local memory object to be reallocated. This handle is returned by either the LocalAlloc or LocalReAlloc function.</param>
        /// <param name="uBytes">The new size of the memory block, in bytes. If uFlags specifies LMEM_MODIFY, this parameter is ignored.</param>
        /// <param name="uFlags">The reallocation options. If LMEM_MODIFY is specified, the function modifies the attributes of the memory object only (the uBytes parameter is ignored.) Otherwise, the function reallocates the memory object.You can optionally combine LMEM_MODIFY with the following value.If this parameter does not specify LMEM_MODIFY, you can use the following value.If the function succeeds, the return value is a handle to the reallocated memory object.If the function fails, the return value is NULL. To get extended error information, call GetLastError.If LocalReAlloc fails, the original memory is not freed, and the original handle and pointer are still valid.If LocalReAlloc reallocates a fixed object, the value of the handle returned is the address of the first byte of the memory block. To access the memory, a process can simply cast the return value to a pointer.Global and Local FunctionsLocalAllocLocalFreeLocalLockMemory Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr LocalReAlloc(int hMem, int uBytes, int uFlags);

        /// <summary>
        ///Retrieves the current size of the specified local memory object, in bytes.
        /// </summary>
        /// <param name="hMem">A handle to the local memory object. This handle is returned by the LocalAlloc, LocalReAlloc, or LocalHandle function.If the function succeeds, the return value is the size of the specified local memory object, in bytes. If the specified handle is not valid or if the object has been discarded, the return value is zero. To get extended error information, call GetLastError.The size of a memory block may be larger than the size requested when the memory was allocated.To verify that the specified object's memory block has not been discarded, call the LocalFlags function before calling LocalSize.Global and Local FunctionsLocalAllocLocalFlagsLocalHandleLocalReAllocMemory Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr LocalSize(IntPtr hMem);

        /// <summary>
        ///Decrements the lock count associated with a memory object that was allocated with LMEM_MOVEABLE. This function has no effect on memory objects allocated with LMEM_FIXED.
        /// </summary>
        /// <param name="hMem">A handle to the local memory object. This handle is returned by either the LocalAlloc or LocalReAlloc function.If the memory object is still locked after decrementing the lock count, the return value is nonzero. If the memory object is unlocked after decrementing the lock count, the function returns zero and GetLastError returns NO_ERROR.If the function fails, the return value is zero and GetLastError returns a value other than NO_ERROR.The internal data structures for each memory object include a lock count that is initially zero. For movable memory objects, the LocalLock function increments the count by one, and LocalUnlock decrements the count by one. For each call that a process makes to LocalLock for an object, it must eventually call LocalUnlock. Locked memory will not be moved or discarded unless the memory object is reallocated by using the LocalReAlloc function. The memory block of a locked memory object remains locked until its lock count is decremented to zero, at which time it can be moved or discarded.If the memory object is already unlocked, LocalUnlock returns FALSE and GetLastError reports ERROR_NOT_LOCKED. Memory objects allocated with LMEM_FIXED always have a lock count of zero and cause the ERROR_NOT_LOCKED error.A process should not rely on the return value to determine the number of times it must subsequently call LocalUnlock for the memory block.Global and Local FunctionsLocalAllocLocalFlagsLocalLockLocalReAllocMemory Management Functions</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool LocalUnlock(IntPtr hMem);

        /// <summary>
        ///Retrieves a pointer to the processor state for an XState feature within a CONTEXT structure.
        /// </summary>
        /// <param name="Context">A pointer to a CONTEXT structure containing the state to retrieve or set. This CONTEXT should have been initialized with InitializeContext with the CONTEXT_XSTATE flag set in the ContextFlags parameter.</param>
        /// <param name="FeatureId">The number of the feature to locate within the CONTEXT structure.</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void LocateXStateFeature(int Context, uint FeatureId);

        /// <summary>
        ///The LogonUser function attempts to log a user on to the local computer. The local computer is the computer from which LogonUser was called. You cannot use LogonUser to log on to a remote computer. You specify the user with a user name and domain and authenticate the user with a plaintext password. If the function succeeds, you receive a handle to a token that represents the logged-on user. You can then use this token handle to impersonate the specified user or, in most cases, to create a process that runs in the context of the specified user.
        /// </summary>
        /// <param name="lpszUsername">A pointer to a null-terminated string that specifies the name of the user. This is the name of the user account to log on to. If you use the user principal name (UPN) format, User@DNSDomainName, the lpszDomain parameter must be NULL.</param>
        /// <param name="dwLogonType">The type of logon operation to perform. This parameter can be one of the following values, defined in Winbase.h.</param>
        /// <param name="dwLogonProvider">Specifies the logon provider. This parameter can be one of the following values.</param>
        /// <param name="phToken"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool LogonUserA(string lpszUsername, uint dwLogonType, uint dwLogonProvider, out IntPtr phToken);

        /// <summary>
        ///The LogonUserEx function attempts to log a user on to the local computer. The local computer is the computer from which LogonUserEx was called. You cannot use LogonUserEx to log on to a remote computer. You specify the user with a user name and domain and authenticate the user with a plaintext password. If the function succeeds, you receive a handle to a token that represents the logged-on user. You can then use this token handle to impersonate the specified user or, in most cases, to create a process that runs in the context of the specified user.
        /// </summary>
        /// <param name="lpszUsername">A pointer to a null-terminated string that specifies the name of the user. This is the name of the user account to log on to. If you use the user principal name (UPN) format, user@DNS_domain_name, the lpszDomain parameter must be NULL.</param>
        /// <param name="dwLogonType">The type of logon operation to perform. This parameter can be one of the following values.</param>
        /// <param name="dwLogonProvider">The logon provider. This parameter can be one of the following values.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool LogonUserExA(string lpszUsername, uint dwLogonType, uint dwLogonProvider);

        /// <summary>
        ///The LogonUserEx function attempts to log a user on to the local computer. The local computer is the computer from which LogonUserEx was called. You cannot use LogonUserEx to log on to a remote computer. You specify the user with a user name and domain and authenticate the user with a plaintext password. If the function succeeds, you receive a handle to a token that represents the logged-on user. You can then use this token handle to impersonate the specified user or, in most cases, to create a process that runs in the context of the specified user.
        /// </summary>
        /// <param name="lpszUsername">A pointer to a null-terminated string that specifies the name of the user. This is the name of the user account to log on to. If you use the user principal name (UPN) format, user@DNS_domain_name, the lpszDomain parameter must be NULL.</param>
        /// <param name="dwLogonType">The type of logon operation to perform. This parameter can be one of the following values.</param>
        /// <param name="dwLogonProvider">The logon provider. This parameter can be one of the following values.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool LogonUserExW(string lpszUsername, uint dwLogonType, uint dwLogonProvider);

        /// <summary>
        ///The LogonUser function attempts to log a user on to the local computer. The local computer is the computer from which LogonUser was called. You cannot use LogonUser to log on to a remote computer. You specify the user with a user name and domain and authenticate the user with a plaintext password. If the function succeeds, you receive a handle to a token that represents the logged-on user. You can then use this token handle to impersonate the specified user or, in most cases, to create a process that runs in the context of the specified user.
        /// </summary>
        /// <param name="lpszUsername">A pointer to a null-terminated string that specifies the name of the user. This is the name of the user account to log on to. If you use the user principal name (UPN) format, User@DNSDomainName, the lpszDomain parameter must be NULL.</param>
        /// <param name="dwLogonType">The type of logon operation to perform. This parameter can be one of the following values, defined in Winbase.h.</param>
        /// <param name="dwLogonProvider">Specifies the logon provider. This parameter can be one of the following values.</param>
        /// <param name="phToken"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool LogonUserW(string lpszUsername, uint dwLogonType, uint dwLogonProvider, out IntPtr phToken);

        /// <summary>
        ///The LookupAccountName function accepts the name of a system and an account as input. It retrieves a security identifier (SID) for the account and the name of the domain on which the account was found.
        /// </summary>
        /// <param name="lpAccountName">A pointer to a null-terminated string that specifies the account name.Use a fully qualified string in the domain_name\user_name format to ensure that LookupAccountName finds the account in the desired domain.</param>
        /// <param name="peUse"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool LookupAccountNameA(string lpAccountName, out int peUse);

        /// <summary>
        ///The LookupAccountName function accepts the name of a system and an account as input. It retrieves a security identifier (SID) for the account and the name of the domain on which the account was found.
        /// </summary>
        /// <param name="lpAccountName">A pointer to a null-terminated string that specifies the account name.Use a fully qualified string in the domain_name\user_name format to ensure that LookupAccountName finds the account in the desired domain.</param>
        /// <param name="peUse"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool LookupAccountNameW(string lpAccountName, out int peUse);

        /// <summary>
        ///The LookupAccountSid function accepts a security identifier (SID) as input. It retrieves the name of the account for this SID and the name of the first domain on which this SID is found.
        /// </summary>
        /// <param name="Sid">A pointer to the SID to look up.</param>
        /// <param name="peUse"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool LookupAccountSidA(int Sid, out int peUse);

        /// <summary>
        ///The LookupAccountSid function accepts a security identifier (SID) as input. It retrieves the name of the account for this SID and the name of the first domain on which this SID is found.
        /// </summary>
        /// <param name="Sid">A pointer to the SID to look up.</param>
        /// <param name="peUse"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool LookupAccountSidW(int Sid, out int peUse);

        /// <summary>
        ///The LookupPrivilegeDisplayName function retrieves the display name that represents a specified privilege.
        /// </summary>
        /// <param name="lpName">A pointer to a null-terminated string that specifies the name of the privilege, as defined in Winnt.h. For example, this parameter could specify the constant, SE_REMOTE_SHUTDOWN_NAME, or its corresponding string, "SeRemoteShutdownPrivilege". For a list of values, see Privilege Constants.</param>
        /// <param name="lpLanguageId"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool LookupPrivilegeDisplayNameA(string lpName, out uint lpLanguageId);

        /// <summary>
        ///The LookupPrivilegeDisplayName function retrieves the display name that represents a specified privilege.
        /// </summary>
        /// <param name="lpName">A pointer to a null-terminated string that specifies the name of the privilege, as defined in Winnt.h. For example, this parameter could specify the constant, SE_REMOTE_SHUTDOWN_NAME, or its corresponding string, "SeRemoteShutdownPrivilege". For a list of values, see Privilege Constants.</param>
        /// <param name="lpLanguageId"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool LookupPrivilegeDisplayNameW(string lpName, out uint lpLanguageId);

        /// <summary>
        ///The LookupPrivilegeName function retrieves the name that corresponds to the privilege represented on a specific system by a specified locally unique identifier (LUID).
        /// </summary>
        /// <param name="lpLuid">A pointer to the LUID by which the privilege is known on the target system.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool LookupPrivilegeNameA(int lpLuid);

        /// <summary>
        ///The LookupPrivilegeName function retrieves the name that corresponds to the privilege represented on a specific system by a specified locally unique identifier (LUID).
        /// </summary>
        /// <param name="lpLuid">A pointer to the LUID by which the privilege is known on the target system.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool LookupPrivilegeNameW(int lpLuid);

        /// <summary>
        ///The LookupPrivilegeValue function retrieves the locally unique identifier (LUID) used on a specified system to locally represent the specified privilege name.
        /// </summary>
        /// <param name="lpName">A pointer to a null-terminated string that specifies the name of the privilege, as defined in the Winnt.h header file. For example, this parameter could specify the constant, SE_SECURITY_NAME, or its corresponding string, "SeSecurityPrivilege".</param>
        /// <param name="lpLuid"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool LookupPrivilegeValueA(string lpName, out int lpLuid);

        /// <summary>
        ///The LookupPrivilegeValue function retrieves the locally unique identifier (LUID) used on a specified system to locally represent the specified privilege name.
        /// </summary>
        /// <param name="lpName">A pointer to a null-terminated string that specifies the name of the privilege, as defined in the Winnt.h header file. For example, this parameter could specify the constant, SE_SECURITY_NAME, or its corresponding string, "SeSecurityPrivilege".</param>
        /// <param name="lpLuid"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool LookupPrivilegeValueW(string lpName, out int lpLuid);

        /// <summary>
        ///Appends one string to another.
        /// </summary>
        /// <param name="lpString2">Type: LPTSTRThe null-terminated string to be appended to the string specified in the lpString1 parameter.Type: LPTSTRIf the function succeeds, the return value is a pointer to the buffer.If the function fails, the return value is NULL and lpString1 may not be null-terminated.ConceptualReferenceStringCbCatStringCbCatExStringCbCatNStringCbCatNExStringCchCatStringCchCatExStringCchCatNStringCchCatNExStringslstrcmplstrcmpilstrlen</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern string lstrcatA(string lpString2);

        /// <summary>
        ///Appends one string to another.
        /// </summary>
        /// <param name="lpString2">Type: LPTSTRThe null-terminated string to be appended to the string specified in the lpString1 parameter.Type: LPTSTRIf the function succeeds, the return value is a pointer to the buffer.If the function fails, the return value is NULL and lpString1 may not be null-terminated.ConceptualReferenceStringCbCatStringCbCatExStringCbCatNStringCbCatNExStringCchCatStringCchCatExStringCchCatNStringCchCatNExStringslstrcmplstrcmpilstrlen</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern string lstrcatW(string lpString2);

        /// <summary>
        ///Compares two character strings. The comparison is case-sensitive.
        /// </summary>
        /// <param name="lpString1">Type: LPCTSTRThe first null-terminated string to be compared.</param>
        /// <param name="lpString2">Type: LPCTSTRThe second null-terminated string to be compared.Type: intIf the string pointed to by lpString1 is less than the string pointed to by lpString2, the return value is negative. If the string pointed to by lpString1 is greater than the string pointed to by lpString2, the return value is positive. If the strings are equal, the return value is zero.The lstrcmp function compares two strings by checking the first characters against each other, the second characters against each other, and so on until it finds an inequality or reaches the ends of the strings.Note that the lpString1 and lpString2 parameters must be null-terminated, otherwise the string comparison can be incorrect.The function calls CompareStringEx, using the current thread locale, and subtracts 2 from the result, to maintain the C run-time conventions for comparing strings.The language (user locale) selected by the user at setup time, or through Control Panel, determines which string is greater (or whether the strings are the same). If no language (user locale) is selected, the system performs the comparison by using default values.With a double-byte character set (DBCS) version of the system, this function can compare two DBCS strings.The lstrcmp function uses a word sort, rather than a string sort. A word sort treats hyphens and apostrophes differently than it treats other symbols that are not alphanumeric, in order to ensure that words such as "coop" and "co-op" stay together within a sorted list. For a detailed discussion of word sorts and string sorts, see Handling Sorting in Your Applications.CompareStringCompareStringExCompareStringOrdinalConceptualOther ResourcesReferenceStringslstrcatlstrcmpilstrcpylstrlen</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint lstrcmpA(string lpString1, string lpString2);

        /// <summary>
        ///Compares two character strings. The comparison is not case-sensitive.
        /// </summary>
        /// <param name="lpString1">Type: LPCTSTRThe first null-terminated string to be compared.</param>
        /// <param name="lpString2">Type: LPCTSTRThe second null-terminated string to be compared.Type: intIf the string pointed to by lpString1 is less than the string pointed to by lpString2, the return value is negative. If the string pointed to by lpString1 is greater than the string pointed to by lpString2, the return value is positive. If the strings are equal, the return value is zero.The lstrcmpi function compares two strings by checking the first characters against each other, the second characters against each other, and so on until it finds an inequality or reaches the ends of the strings.Note that the lpString1 and lpString2 parameters must be null-terminated, otherwise the string comparison can be incorrect.The function calls CompareStringEx, using the current thread locale, and subtracts 2 from the result, to maintain the C run-time conventions for comparing strings.For some locales, the lstrcmpi function may be insufficient. If this occurs, use CompareStringEx to ensure proper comparison. For example, in Japan call with the NORM_IGNORECASE, NORM_IGNOREKANATYPE, and NORM_IGNOREWIDTH values to achieve the most appropriate non-exact string comparison. The NORM_IGNOREKANATYPE and NORM_IGNOREWIDTH values are ignored in non-Asian locales, so you can set these values for all locales and be guaranteed to have a culturally correct "insensitive" sorting regardless of the locale. Note that specifying these values slows performance, so use them only when necessary.With a double-byte character set (DBCS) version of the system, this function can compare two DBCS strings.The lstrcmpi function uses a word sort, rather than a string sort. A word sort treats hyphens and apostrophes differently than it treats other symbols that are not alphanumeric, in order to ensure that words such as "coop" and "co-op" stay together within a sorted list. For a detailed discussion of word sorts and string sorts, see Handling Sorting in Your Applications.CompareStringCompareStringExCompareStringOrdinalConceptualOther ResourcesReferenceStringslstrcatlstrcmplstrcpylstrlen</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint lstrcmpiA(string lpString1, string lpString2);

        /// <summary>
        ///Compares two character strings. The comparison is not case-sensitive.
        /// </summary>
        /// <param name="lpString1">Type: LPCWSTRThe first null-terminated string to be compared.</param>
        /// <param name="lpString2">Type: LPCWSTRThe second null-terminated string to be compared.Type: intIf the string pointed to by lpString1 is less than the string pointed to by lpString2, the return value is negative. If the string pointed to by lpString1 is greater than the string pointed to by lpString2, the return value is positive. If the strings are equal, the return value is zero.The lstrcmpi function compares two strings by checking the first characters against each other, the second characters against each other, and so on until it finds an inequality or reaches the ends of the strings.Note that the lpString1 and lpString2 parameters must be null-terminated, otherwise the string comparison can be incorrect.The function calls CompareStringEx, using the current thread locale, and subtracts 2 from the result, to maintain the C run-time conventions for comparing strings.For some locales, the lstrcmpi function may be insufficient. If this occurs, use CompareStringEx to ensure proper comparison. For example, in Japan call with the NORM_IGNORECASE, NORM_IGNOREKANATYPE, and NORM_IGNOREWIDTH values to achieve the most appropriate non-exact string comparison. The NORM_IGNOREKANATYPE and NORM_IGNOREWIDTH values are ignored in non-Asian locales, so you can set these values for all locales and be guaranteed to have a culturally correct "insensitive" sorting regardless of the locale. Note that specifying these values slows performance, so use them only when necessary.With a double-byte character set (DBCS) version of the system, this function can compare two DBCS strings.The lstrcmpi function uses a word sort, rather than a string sort. A word sort treats hyphens and apostrophes differently than it treats other symbols that are not alphanumeric, in order to ensure that words such as "coop" and "co-op" stay together within a sorted list. For a detailed discussion of word sorts and string sorts, see Handling Sorting in Your Applications.CompareStringCompareStringExCompareStringOrdinalConceptualOther ResourcesReferenceStringslstrcatlstrcmplstrcpylstrlen</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint lstrcmpiW(string lpString1, string lpString2);

        /// <summary>
        ///Compares two character strings. The comparison is case-sensitive.
        /// </summary>
        /// <param name="lpString1">Type: LPCTSTRThe first null-terminated string to be compared.</param>
        /// <param name="lpString2">Type: LPCTSTRThe second null-terminated string to be compared.Type: intIf the string pointed to by lpString1 is less than the string pointed to by lpString2, the return value is negative. If the string pointed to by lpString1 is greater than the string pointed to by lpString2, the return value is positive. If the strings are equal, the return value is zero.The lstrcmp function compares two strings by checking the first characters against each other, the second characters against each other, and so on until it finds an inequality or reaches the ends of the strings.Note that the lpString1 and lpString2 parameters must be null-terminated, otherwise the string comparison can be incorrect.The function calls CompareStringEx, using the current thread locale, and subtracts 2 from the result, to maintain the C run-time conventions for comparing strings.The language (user locale) selected by the user at setup time, or through Control Panel, determines which string is greater (or whether the strings are the same). If no language (user locale) is selected, the system performs the comparison by using default values.With a double-byte character set (DBCS) version of the system, this function can compare two DBCS strings.The lstrcmp function uses a word sort, rather than a string sort. A word sort treats hyphens and apostrophes differently than it treats other symbols that are not alphanumeric, in order to ensure that words such as "coop" and "co-op" stay together within a sorted list. For a detailed discussion of word sorts and string sorts, see Handling Sorting in Your Applications.CompareStringCompareStringExCompareStringOrdinalConceptualOther ResourcesReferenceStringslstrcatlstrcmpilstrcpylstrlen</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint lstrcmpW(string lpString1, string lpString2);

        /// <summary>
        ///Copies a string to a buffer.
        /// </summary>
        /// <param name="lpString1"></param>
        /// <param name="lpString2">Type: LPTSTRThe null-terminated string to be copied.Type: LPTSTRIf the function succeeds, the return value is a pointer to the buffer.If the function fails, the return value is NULL and lpString1 may not be null-terminated.With a double-byte character set (DBCS) version of the system, this function can be used to copy a DBCS string.The lstrcpy function has an undefined behavior if source and destination buffers overlap.lpString1 must be large enough to hold lpString2 and the closing '\0', otherwise a buffer overrun may occur.Buffer overflow situations are the cause of many security problems in applications and can cause a denial of service attack against the application if an access violation occurs. In the worst case, a buffer overrun may allow an attacker to inject executable code into your process, especially if lpString1 is a stack-based buffer.Consider using StringCchCopy instead; use either StringCchCopy(buffer, sizeof(buffer)/sizeof(buffer[0]), src);, being aware that buffer must not be a pointer or use StringCchCopy(buffer, ARRAYSIZE(buffer), src);, being aware that, when copying to a pointer, the caller is responsible for passing in the size of the pointed-to memory in characters.ConceptualReferenceStringCbCopyStringCbCopyExStringCbCopyNStringCbCopyNExStringCchCopyStringCchCopyExStringCchCopyNStringCchCopyNExStringslstrcmplstrcmpilstrlen</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern string lstrcpyA(out string lpString1, string lpString2);

        /// <summary>
        ///Copies a specified number of characters from a source string into a buffer.
        /// </summary>
        /// <param name="lpString1"></param>
        /// <param name="lpString2">Type: LPCTSTRThe source string from which the function is to copy characters.</param>
        /// <param name="iMaxLength">Type: intThe number of TCHAR values to be copied from the string pointed to by lpString2 into the buffer pointed to by lpString1, including a terminating null character.Type: LPTSTRIf the function succeeds, the return value is a pointer to the buffer. The function can succeed even if the source string is greater than iMaxLength characters.If the function fails, the return value is NULL and lpString1 may not be null-terminated.The buffer pointed to by lpString1 must be large enough to include a terminating null character, and the string length value specified by iMaxLength includes room for a terminating null character.The lstrcpyn function has an undefined behavior if source and destination buffers overlap.If the buffer pointed to by lpString1 is not large enough to contain the copied string, a buffer overrun can occur. When copying an entire string, note that sizeof returns the number of bytes. For example, if lpString1 points to a buffer szString1 which is declared as TCHAR szString[100], then sizeof(szString1) gives the size of the buffer in bytes rather than WCHAR, which could lead to a buffer overflow for the Unicode version of the function.Buffer overflow situations are the cause of many security problems in applications and can cause a denial of service attack against the application if an access violation occurs. In the worst case, a buffer overrun may allow an attacker to inject executable code into your process, especially if lpString1 is a stack-based buffer.Using sizeof(szString1)/sizeof(szString1[0]) gives the proper size of the buffer.Consider using StringCchCopy instead; use either StringCchCopy(buffer, sizeof(buffer)/sizeof(buffer[0]), src);, being aware that buffer must not be a pointer or use StringCchCopy(buffer, ARRAYSIZE(buffer), src);, being aware that, when copying to a pointer, the caller is responsible for passing in the size of the pointed-to memory in characters.Review Security Considerations: Windows User Interface before continuing.ConceptualReferenceStringCbCopyStringCbCopyExStringCbCopyNStringCbCopyNExStringCbLengthStringCchCopyStringCchCopyExStringCchCopyNStringCchCopyNExStringCchLengthStringslstrcmplstrcmpilstrlen</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern string lstrcpynA(out string lpString1, string lpString2, uint iMaxLength);

        /// <summary>
        ///Copies a specified number of characters from a source string into a buffer.
        /// </summary>
        /// <param name="lpString1"></param>
        /// <param name="lpString2">Type: LPCTSTRThe source string from which the function is to copy characters.</param>
        /// <param name="iMaxLength">Type: intThe number of TCHAR values to be copied from the string pointed to by lpString2 into the buffer pointed to by lpString1, including a terminating null character.Type: LPTSTRIf the function succeeds, the return value is a pointer to the buffer. The function can succeed even if the source string is greater than iMaxLength characters.If the function fails, the return value is NULL and lpString1 may not be null-terminated.The buffer pointed to by lpString1 must be large enough to include a terminating null character, and the string length value specified by iMaxLength includes room for a terminating null character.The lstrcpyn function has an undefined behavior if source and destination buffers overlap.If the buffer pointed to by lpString1 is not large enough to contain the copied string, a buffer overrun can occur. When copying an entire string, note that sizeof returns the number of bytes. For example, if lpString1 points to a buffer szString1 which is declared as TCHAR szString[100], then sizeof(szString1) gives the size of the buffer in bytes rather than WCHAR, which could lead to a buffer overflow for the Unicode version of the function.Buffer overflow situations are the cause of many security problems in applications and can cause a denial of service attack against the application if an access violation occurs. In the worst case, a buffer overrun may allow an attacker to inject executable code into your process, especially if lpString1 is a stack-based buffer.Using sizeof(szString1)/sizeof(szString1[0]) gives the proper size of the buffer.Consider using StringCchCopy instead; use either StringCchCopy(buffer, sizeof(buffer)/sizeof(buffer[0]), src);, being aware that buffer must not be a pointer or use StringCchCopy(buffer, ARRAYSIZE(buffer), src);, being aware that, when copying to a pointer, the caller is responsible for passing in the size of the pointed-to memory in characters.Review Security Considerations: Windows User Interface before continuing.ConceptualReferenceStringCbCopyStringCbCopyExStringCbCopyNStringCbCopyNExStringCbLengthStringCchCopyStringCchCopyExStringCchCopyNStringCchCopyNExStringCchLengthStringslstrcmplstrcmpilstrlen</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern string lstrcpynW(out string lpString1, string lpString2, uint iMaxLength);

        /// <summary>
        ///Copies a string to a buffer.
        /// </summary>
        /// <param name="lpString1"></param>
        /// <param name="lpString2">Type: LPTSTRThe null-terminated string to be copied.Type: LPTSTRIf the function succeeds, the return value is a pointer to the buffer.If the function fails, the return value is NULL and lpString1 may not be null-terminated.With a double-byte character set (DBCS) version of the system, this function can be used to copy a DBCS string.The lstrcpy function has an undefined behavior if source and destination buffers overlap.lpString1 must be large enough to hold lpString2 and the closing '\0', otherwise a buffer overrun may occur.Buffer overflow situations are the cause of many security problems in applications and can cause a denial of service attack against the application if an access violation occurs. In the worst case, a buffer overrun may allow an attacker to inject executable code into your process, especially if lpString1 is a stack-based buffer.Consider using StringCchCopy instead; use either StringCchCopy(buffer, sizeof(buffer)/sizeof(buffer[0]), src);, being aware that buffer must not be a pointer or use StringCchCopy(buffer, ARRAYSIZE(buffer), src);, being aware that, when copying to a pointer, the caller is responsible for passing in the size of the pointed-to memory in characters.ConceptualReferenceStringCbCopyStringCbCopyExStringCbCopyNStringCbCopyNExStringCchCopyStringCchCopyExStringCchCopyNStringCchCopyNExStringslstrcmplstrcmpilstrlen</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern string lstrcpyW(out string lpString1, string lpString2);

        /// <summary>
        ///Determines the length of the specified string (not including the terminating null character).
        /// </summary>
        /// <param name="lpString">Type: LPCTSTRThe null-terminated string to be checked.Type: intThe function returns the length of the string, in characters. If lpString is NULL, the function returns 0.ConceptualReferenceStringCbLengthStringCchLengthStringslstrcatlstrcmplstrcmpilstrcpy</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint lstrlenA(string lpString);

        /// <summary>
        ///Determines the length of the specified string (not including the terminating null character).
        /// </summary>
        /// <param name="lpString">Type: LPCTSTRThe null-terminated string to be checked.Type: intThe function returns the length of the string, in characters. If lpString is NULL, the function returns 0.ConceptualReferenceStringCbLengthStringCchLengthStringslstrcatlstrcmplstrcmpilstrcpy</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint lstrlenW(string lpString);

        /// <summary>
        ///Maps previously allocated physical memory pages at a specified address in an Address Windowing Extensions (AWE) region.
        /// </summary>
        /// <param name="VirtualAddresses">A pointer to an array of starting addresses of the regions of memory to remap.Each entry in VirtualAddresses must be within the address range that the VirtualAlloc function returns when the Address Windowing Extensions (AWE) region is allocated. The value in NumberOfPages indicates the size of the array. Entries can be from multiple Address Windowing Extensions (AWE) regions.</param>
        /// <param name="NumberOfPages">The size of the physical memory and virtual address space for which to establish translations, in pages.The array at VirtualAddresses specifies the virtual address range.</param>
        /// <param name="PageArray">A pointer to an array of values that indicates how each corresponding page in VirtualAddresses should be treated.A 0 (zero) indicates that the corresponding entry in VirtualAddresses should be unmapped, and any nonzero value that it has should be mapped.If this parameter is NULL, then every address in the VirtualAddresses array is unmapped.The value in NumberOfPages indicates the size of the array.If the function succeeds, the return value is TRUE.If the function fails, the return value is FALSE, and the function does not map or unmap—partial or otherwise. To get extended error information, call GetLastError.The physical pages may be unmapped, but they are not freed. You must call FreeUserPhysicalPages to free the physical pages.You can specify any number of physical memory pages, but the memory cannot extend outside the virtual address space that is allocated by VirtualAlloc. Any existing address maps are automatically overwritten with the new translations, and the old translations are unmapped.You cannot map physical memory pages outside the range that is specified in AllocateUserPhysicalPages. You can map multiple regions simultaneously, but they cannot overlap.Physical pages can be located at any physical address, but do not make assumptions about the contiguity of the physical pages.In a multiprocessor environment, this function maintains hardware translation buffer coherence. On return from this function, all threads on all processors are guaranteed to see the correct mapping.To compile an application that uses this function, define the _WIN32_WINNT macro as 0x0500 or later. For more information, see Using the Windows Headers.Address Windowing ExtensionsAllocateUserPhysicalPagesFreeUserPhysicalPagesMapUserPhysicalPagesMemory Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool MapUserPhysicalPagesScatter(IntPtr VirtualAddresses, int NumberOfPages, int PageArray);

        /// <summary>
        ///Maps a view of a file mapping into the address space of a calling process and specifies the NUMA node for the physical memory.
        /// </summary>
        /// <param name="hFileMappingObject">A handle to a file mapping object. The CreateFileMappingNuma and OpenFileMapping functions return this handle.</param>
        /// <param name="dwDesiredAccess">The type of access to a file mapping object, which determines the page protection of the pages. This parameter can be one of the following values, or a bitwise OR combination of multiple values where appropriate.Using bitwise OR, you can combine the values above with these values.For file-mapping objects created with the SEC_IMAGE attribute, the dwDesiredAccess parameter has no effect, and should be set to any valid value such as FILE_MAP_READ.For more information about access to file mapping objects, see File Mapping Security and Access Rights.</param>
        /// <param name="dwFileOffsetHigh">The high-order DWORD of the file offset where the view is to begin.</param>
        /// <param name="dwFileOffsetLow">The low-order DWORD of the file offset where the view is to begin. The combination of the high and low offsets must specify an offset within the file mapping. They must also match the memory allocation granularity of the system. That is, the offset must be a multiple of the allocation granularity. To obtain the memory allocation granularity of the system, use the GetSystemInfo function, which fills in the members of a SYSTEM_INFO structure.</param>
        /// <param name="dwNumberOfBytesToMap">The number of bytes of a file mapping to map to a view. All bytes must be within the maximum size specified by CreateFileMapping. If this parameter is 0 (zero), the mapping extends from the specified offset to the end of the file mapping.</param>
        /// <param name="nndPreferred">The NUMA node where the physical memory should reside.If the function succeeds, the return value is the starting address of the mapped view.If the function fails, the return value is NULL. To get extended error information, call the GetLastError function.Mapping a file makes the specified portion of the file visible in the address space of the calling process.For files that are larger than the address space, you can map only a small portion of the file data at one time. When the first view is complete, then you unmap it and map a new view.To obtain the size of a view, use the VirtualQueryEx function.The initial contents of the pages in a file mapping object backed by the page file are 0 (zero).If a suggested mapping address is supplied, the file is mapped at the specified address (rounded down to the nearest 64-KB boundary) if there is enough address space at the specified address. If there is not enough address space, the function fails.Typically, the suggested address is used to specify that a file should be mapped at the same address in multiple processes. This requires the region of address space to be available in all involved processes. No other memory allocation can take place in the region that is used for mapping, including the use of the VirtualAllocExNuma function to reserve memory.If the lpBaseAddress parameter specifies a base offset, the function succeeds if the specified memory region is not already in use by the calling process. The system does not ensure that the same memory region is available for the memory mapped file in other 32-bit processes.Multiple views of a file (or a file mapping object and its mapped file) are coherent if they contain identical data at a specified time. This occurs if the file views are derived from the same file mapping object. A process can duplicate a file mapping object handle into another process by using the DuplicateHandle function, or another process can open a file mapping object by name by using the OpenFileMapping function.With one important exception, file views derived from any file mapping object that is backed by the same file are coherent or identical at a specific time. Coherency is guaranteed for views within a process and for views that are mapped by different processes.The exception is related to remote files. Although MapViewOfFileExNuma works with remote files, it does not keep them coherent. For example, if two computers both map a file as writable, and both change the same page, each computer only sees its own writes to the page. When the data gets updated on the disk, it is not merged.A mapped view of a file is not guaranteed to be coherent with a file being accessed by the ReadFile or WriteFile function.To guard against EXCEPTION_IN_PAGE_ERROR exceptions, use structured exception handling to protect any code that writes to or reads from a memory mapped view of a file other than the page file. For more information, see Reading and Writing From a File View.When modifying a file through a mapped view, the last modification timestamp may not be updated automatically. If required, the caller should use SetFileTime to set the timestamp.To have a file with executable permissions, an application must call the CreateFileMappingNuma function with either PAGE_EXECUTE_READWRITE or PAGE_EXECUTE_READ and then call the MapViewOfFileExNuma function with FILE_MAP_EXECUTE | FILE_MAP_WRITE or FILE_MAP_EXECUTE | FILE_MAP_READ.In Windows Server 2012, this function is supported by the following technologies.CreateFileMappingNumaDuplicateHandleFile Mapping FunctionsGetSystemInfoMapViewOfFileExNUMA SupportOpenFileMappingReadFileSYSTEM_INFOUnmapViewOfFileVirtualAllocWriteFile</param>
        /// <remarks>
        /// To get extended error information, call the GetLastError function.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void MapViewOfFileExNuma(IntPtr hFileMappingObject, uint dwDesiredAccess, uint dwFileOffsetHigh, uint dwFileOffsetLow, int dwNumberOfBytesToMap, uint nndPreferred);

        /// <summary>
        ///Moves an existing file or a directory, including its children.
        /// </summary>
        /// <param name="lpExistingFileName">The current name of the file or directory on the local computer.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="lpNewFileName">The new name for the file or directory. The new name must not already exist. A new file may be on a different file system or drive. A new directory must be on the same drive.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The MoveFile function will move (rename) either a file or a directory (including its children) either in the same directory or across directories. The one caveat is that the MoveFile function will fail on directory moves when the destination is on a different volume.If a file is moved across volumes, MoveFile does not move the security descriptor with the file. The file will be assigned the default security descriptor in the destination directory.The MoveFile function coordinates its operation with the link tracking service, so link sources can be tracked as they are moved.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB 3.0 does not support rename of alternate data streams on file shares with continuous availability capability.CopyFileFile Management FunctionsMoveFileExMoveFileTransactedMoveFileWithProgress</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool MoveFile(string lpExistingFileName, string lpNewFileName);

        /// <summary>
        ///Moves an existing file or a directory, including its children.
        /// </summary>
        /// <param name="lpExistingFileName">The current name of the file or directory on the local computer.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="lpNewFileName">The new name for the file or directory. The new name must not already exist. A new file may be on a different file system or drive. A new directory must be on the same drive.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The MoveFile function will move (rename) either a file or a directory (including its children) either in the same directory or across directories. The one caveat is that the MoveFile function will fail on directory moves when the destination is on a different volume.If a file is moved across volumes, MoveFile does not move the security descriptor with the file. The file will be assigned the default security descriptor in the destination directory.The MoveFile function coordinates its operation with the link tracking service, so link sources can be tracked as they are moved.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB 3.0 does not support rename of alternate data streams on file shares with continuous availability capability.CopyFileFile Management FunctionsMoveFileExMoveFileTransactedMoveFileWithProgress</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool MoveFileA(string lpExistingFileName, string lpNewFileName);

        /// <summary>
        ///Moves an existing file or directory, including its children, with various move options.
        /// </summary>
        /// <param name="lpExistingFileName">The current name of the file or directory on the local computer.If dwFlags specifies MOVEFILE_DELAY_UNTIL_REBOOT, the file cannot exist on a remote share, because delayed operations are performed before the network is available.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="dwFlags">This parameter can be one or more of the following values.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero (0). To get extended error information, call GetLastError.If the dwFlags parameter specifies MOVEFILE_DELAY_UNTIL_REBOOT, MoveFileEx fails if it cannot access the registry. The function stores the locations of the files to be renamed at restart in the following registry value: HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\PendingFileRenameOperationsThis registry value is of type REG_MULTI_SZ. Each rename operation stores one of the following NULL-terminated strings, depending on whether the rename is a delete or not:Because the actual move and deletion operations specified with the MOVEFILE_DELAY_UNTIL_REBOOT flag take place after the calling application has ceased running, the return value cannot reflect success or failure in moving or deleting the file. Rather, it reflects success or failure in placing the appropriate entries into the registry.The system deletes a directory that is tagged for deletion with the MOVEFILE_DELAY_UNTIL_REBOOT flag only if it is empty. To ensure deletion of directories, move or delete all files from the directory before attempting to delete it. Files may be in the directory at boot time, but they must be deleted or moved before the system can delete the directory.The move and deletion operations are carried out at boot time in the same order that they are specified in the calling application. To delete a directory that has files in it at boot time, first delete the files.If a file is moved across volumes, MoveFileEx does not move the security descriptor with the file. The file is assigned the default security descriptor in the destination directory.The MoveFileEx function coordinates its operation with the link tracking service, so link sources can be tracked as they are moved.To delete or rename a file, you must have either delete permission on the file or delete child permission in the parent directory. If you set up a directory with all access except delete and delete child and the ACLs of new files are inherited, then you should be able to create a file without being able to delete it. However, you can then create a file, and get all the access you request on the handle that is returned to you at the time that you create the file. If you request delete permission at the time you create the file, you can delete or rename the file with that handle but not with any other handle. For more information, see File Security and Access Rights.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.For an example, see Creating and Using a Temporary File.CopyFileDeleteFileFile Management FunctionsFile Security and Access RightsGetWindowsDirectoryMoveFileTransactedMoveFileWithProgressWritePrivateProfileString</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool MoveFileExA(string lpExistingFileName, uint dwFlags);

        /// <summary>
        ///Moves an existing file or directory, including its children, with various move options.
        /// </summary>
        /// <param name="lpExistingFileName">The current name of the file or directory on the local computer.If dwFlags specifies MOVEFILE_DELAY_UNTIL_REBOOT, the file cannot exist on a remote share, because delayed operations are performed before the network is available.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="dwFlags">This parameter can be one or more of the following values.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero (0). To get extended error information, call GetLastError.If the dwFlags parameter specifies MOVEFILE_DELAY_UNTIL_REBOOT, MoveFileEx fails if it cannot access the registry. The function stores the locations of the files to be renamed at restart in the following registry value: HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\PendingFileRenameOperationsThis registry value is of type REG_MULTI_SZ. Each rename operation stores one of the following NULL-terminated strings, depending on whether the rename is a delete or not:Because the actual move and deletion operations specified with the MOVEFILE_DELAY_UNTIL_REBOOT flag take place after the calling application has ceased running, the return value cannot reflect success or failure in moving or deleting the file. Rather, it reflects success or failure in placing the appropriate entries into the registry.The system deletes a directory that is tagged for deletion with the MOVEFILE_DELAY_UNTIL_REBOOT flag only if it is empty. To ensure deletion of directories, move or delete all files from the directory before attempting to delete it. Files may be in the directory at boot time, but they must be deleted or moved before the system can delete the directory.The move and deletion operations are carried out at boot time in the same order that they are specified in the calling application. To delete a directory that has files in it at boot time, first delete the files.If a file is moved across volumes, MoveFileEx does not move the security descriptor with the file. The file is assigned the default security descriptor in the destination directory.The MoveFileEx function coordinates its operation with the link tracking service, so link sources can be tracked as they are moved.To delete or rename a file, you must have either delete permission on the file or delete child permission in the parent directory. If you set up a directory with all access except delete and delete child and the ACLs of new files are inherited, then you should be able to create a file without being able to delete it. However, you can then create a file, and get all the access you request on the handle that is returned to you at the time that you create the file. If you request delete permission at the time you create the file, you can delete or rename the file with that handle but not with any other handle. For more information, see File Security and Access Rights.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.For an example, see Creating and Using a Temporary File.CopyFileDeleteFileFile Management FunctionsFile Security and Access RightsGetWindowsDirectoryMoveFileTransactedMoveFileWithProgressWritePrivateProfileString</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool MoveFileExW(string lpExistingFileName, uint dwFlags);

        /// <summary>
        ///[Microsoft strongly recommends developers utilize alternative means to achieve your application’s needs. Many scenarios that TxF was developed for can be achieved through simpler and more readily available techniques. Furthermore, TxF may not be available in future versions of Microsoft Windows. For more information, and alternatives to TxF, please see Alternatives to using Transactional NTFS.]
        /// </summary>
        /// <param name="lpExistingFileName">The current name of the existing file or directory on the local computer.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="dwFlags">The move options. This parameter can be one or more of the following values.</param>
        /// <param name="hTransaction">A handle to the transaction. This handle is returned by the CreateTransaction function.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.When moving a file across volumes, if lpProgressRoutine returns PROGRESS_CANCEL due to the user canceling the operation, MoveFileTransacted will return zero and GetLastError will return ERROR_REQUEST_ABORTED. The existing file is left intact.When moving a file across volumes, if lpProgressRoutine returns PROGRESS_STOP due to the user stopping the operation, MoveFileTransacted will return zero and GetLastError will return ERROR_REQUEST_ABORTED. The existing file is left intact.If the dwFlags parameter specifies MOVEFILE_DELAY_UNTIL_REBOOT, MoveFileTransacted fails if it cannot access the registry. The function transactionally stores the locations of the files to be renamed at restart in the following registry value: HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\PendingFileRenameOperationsThis registry value is of type REG_MULTI_SZ. Each rename operation stores one of the following NULL-terminated strings, depending on whether the rename is a delete or not:szDstFile\0\0szSrcFile\0szDstFile\0The string szDstFile\0\0 indicates that the file szDstFile is to be deleted on reboot.The string szSrcFile\0szDstFile\0 indicates that szSrcFile is to be renamed szDstFile on reboot.If a file is moved across volumes, MoveFileTransacted does not move the security descriptor with the file. The file is assigned the default security descriptor in the destination directory.This function always fails if you specify the MOVEFILE_FAIL_IF_NOT_TRACKABLE flag; tracking is not supported by TxF.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB 3.0 does not support TxF.CopyFileTransactedFile Management FunctionsMoveFileWithProgressTransactional NTFS</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool MoveFileTransactedA(string lpExistingFileName, uint dwFlags, IntPtr hTransaction);

        /// <summary>
        ///[Microsoft strongly recommends developers utilize alternative means to achieve your application’s needs. Many scenarios that TxF was developed for can be achieved through simpler and more readily available techniques. Furthermore, TxF may not be available in future versions of Microsoft Windows. For more information, and alternatives to TxF, please see Alternatives to using Transactional NTFS.]
        /// </summary>
        /// <param name="lpExistingFileName">The current name of the existing file or directory on the local computer.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="dwFlags">The move options. This parameter can be one or more of the following values.</param>
        /// <param name="hTransaction">A handle to the transaction. This handle is returned by the CreateTransaction function.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.When moving a file across volumes, if lpProgressRoutine returns PROGRESS_CANCEL due to the user canceling the operation, MoveFileTransacted will return zero and GetLastError will return ERROR_REQUEST_ABORTED. The existing file is left intact.When moving a file across volumes, if lpProgressRoutine returns PROGRESS_STOP due to the user stopping the operation, MoveFileTransacted will return zero and GetLastError will return ERROR_REQUEST_ABORTED. The existing file is left intact.If the dwFlags parameter specifies MOVEFILE_DELAY_UNTIL_REBOOT, MoveFileTransacted fails if it cannot access the registry. The function transactionally stores the locations of the files to be renamed at restart in the following registry value: HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\PendingFileRenameOperationsThis registry value is of type REG_MULTI_SZ. Each rename operation stores one of the following NULL-terminated strings, depending on whether the rename is a delete or not:szDstFile\0\0szSrcFile\0szDstFile\0The string szDstFile\0\0 indicates that the file szDstFile is to be deleted on reboot.The string szSrcFile\0szDstFile\0 indicates that szSrcFile is to be renamed szDstFile on reboot.If a file is moved across volumes, MoveFileTransacted does not move the security descriptor with the file. The file is assigned the default security descriptor in the destination directory.This function always fails if you specify the MOVEFILE_FAIL_IF_NOT_TRACKABLE flag; tracking is not supported by TxF.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB 3.0 does not support TxF.CopyFileTransactedFile Management FunctionsMoveFileWithProgressTransactional NTFS</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool MoveFileTransactedW(string lpExistingFileName, uint dwFlags, IntPtr hTransaction);

        /// <summary>
        ///Moves an existing file or a directory, including its children.
        /// </summary>
        /// <param name="lpExistingFileName">The current name of the file or directory on the local computer.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="lpNewFileName">The new name for the file or directory. The new name must not already exist. A new file may be on a different file system or drive. A new directory must be on the same drive.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The MoveFile function will move (rename) either a file or a directory (including its children) either in the same directory or across directories. The one caveat is that the MoveFile function will fail on directory moves when the destination is on a different volume.If a file is moved across volumes, MoveFile does not move the security descriptor with the file. The file will be assigned the default security descriptor in the destination directory.The MoveFile function coordinates its operation with the link tracking service, so link sources can be tracked as they are moved.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB 3.0 does not support rename of alternate data streams on file shares with continuous availability capability.CopyFileFile Management FunctionsMoveFileExMoveFileTransactedMoveFileWithProgress</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool MoveFileW(string lpExistingFileName, string lpNewFileName);

        /// <summary>
        ///Moves a file or directory, including its children. You can provide a callback function that receives progress notifications.
        /// </summary>
        /// <param name="lpExistingFileName">The name of the existing file or directory on the local computer.If dwFlags specifies MOVEFILE_DELAY_UNTIL_REBOOT, the file cannot exist on a remote share because delayed operations are performed before the network is available.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="dwFlags">The move options. This parameter can be one or more of the following values.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.When moving a file across volumes, if lpProgressRoutine returns PROGRESS_CANCEL due to the user canceling the operation, MoveFileWithProgress will return zero and GetLastError will return ERROR_REQUEST_ABORTED. The existing file is left intact.When moving a file across volumes, if lpProgressRoutine returns PROGRESS_STOP due to the user stopping the operation, MoveFileWithProgress will return zero and GetLastError will return ERROR_REQUEST_ABORTED. The existing file is left intact.The MoveFileWithProgress function coordinates its operation with the link tracking service, so link sources can be tracked as they are moved.To delete or rename a file, you must have either delete permission on the file or delete child permission in the parent directory. If you set up a directory with all access except delete and delete child and the ACLs of new files are inherited, then you should be able to create a file without being able to delete it. However, you can then create a file, and you will get all the access you request on the handle returned to you at the time you create the file. If you requested delete permission at the time you created the file, you could delete or rename the file with that handle but not with any other.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.CsvFs will do redirected IO for compressed files.CopyFileExCopyProgressRoutineFile Management FunctionsMoveFileExMoveFileTransacted</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool MoveFileWithProgressA(string lpExistingFileName, uint dwFlags);

        /// <summary>
        ///Moves a file or directory, including its children. You can provide a callback function that receives progress notifications.
        /// </summary>
        /// <param name="lpExistingFileName">The name of the existing file or directory on the local computer.If dwFlags specifies MOVEFILE_DELAY_UNTIL_REBOOT, the file cannot exist on a remote share because delayed operations are performed before the network is available.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="dwFlags">The move options. This parameter can be one or more of the following values.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.When moving a file across volumes, if lpProgressRoutine returns PROGRESS_CANCEL due to the user canceling the operation, MoveFileWithProgress will return zero and GetLastError will return ERROR_REQUEST_ABORTED. The existing file is left intact.When moving a file across volumes, if lpProgressRoutine returns PROGRESS_STOP due to the user stopping the operation, MoveFileWithProgress will return zero and GetLastError will return ERROR_REQUEST_ABORTED. The existing file is left intact.The MoveFileWithProgress function coordinates its operation with the link tracking service, so link sources can be tracked as they are moved.To delete or rename a file, you must have either delete permission on the file or delete child permission in the parent directory. If you set up a directory with all access except delete and delete child and the ACLs of new files are inherited, then you should be able to create a file without being able to delete it. However, you can then create a file, and you will get all the access you request on the handle returned to you at the time you create the file. If you requested delete permission at the time you created the file, you could delete or rename the file with that handle but not with any other.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.CsvFs will do redirected IO for compressed files.CopyFileExCopyProgressRoutineFile Management FunctionsMoveFileExMoveFileTransacted</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool MoveFileWithProgressW(string lpExistingFileName, uint dwFlags);

        /// <summary>
        ///Multiplies two 32-bit values and then divides the 64-bit result by a third 32-bit value. The final result is rounded to the nearest integer.
        /// </summary>
        /// <param name="nNumber">The multiplicand.</param>
        /// <param name="nNumerator">The multiplier.</param>
        /// <param name="nDenominator">The number by which the result of the multiplication operation is to be divided.If the function succeeds, the return value is the result of the multiplication and division, rounded to the nearest integer. If the result is a positive half integer (ends in .5), it is rounded up. If the result is a negative half integer, it is rounded down.If either an overflow occurred or nDenominator was 0, the return value is -1.Int32x32To64Large IntegersUInt32x32To64</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint MulDiv(uint nNumber, uint nNumerator, uint nDenominator);

        /// <summary>
        ///Enables an application to receive notification when an event is written to the specified event log. When the event is written to the log, the specified event object is set to the signaled state.
        /// </summary>
        /// <param name="hEventLog">A handle to an event log. The OpenEventLog function returns this handle.</param>
        /// <param name="hEvent">A handle to a manual-reset or auto-reset event object. Use the CreateEvent function to create the event object.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The NotifyChangeEventLog function does not work with remote handles. If the hEventLog parameter is the handle to an event log on a remote computer, NotifyChangeEventLog returns zero, and GetLastError returns ERROR_INVALID_HANDLE.If the thread is not waiting on the event when the system calls PulseEvent, the thread will not receive the notification. Therefore, you should create a separate thread to wait for notifications.The system will continue to notify you of changes until you close the handle to the event log. To close the event log, use the CloseEventLog or DeregisterEventSource function.For an example, see Receiving Event Notification.CloseEventLogCreateEventDeregisterEventSourceEvent Logging FunctionsOpenEventLog</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool NotifyChangeEventLog(IntPtr hEventLog, IntPtr hEvent);

        /// <summary>
        ///The ObjectCloseAuditAlarm function generates an audit message in the security event log when a handle to a private object is deleted. Alarms are not currently supported.
        /// </summary>
        /// <param name="SubsystemName">A pointer to a null-terminated string specifying the name of the subsystem calling the function. This string appears in any audit message that the function generates.</param>
        /// <param name="HandleId">A unique value representing the client's handle to the object. This should be the same value that was passed to the AccessCheckAndAuditAlarm or ObjectOpenAuditAlarm function.</param>
        /// <param name="GenerateOnClose">Specifies a flag set by a call to the AccessCheckAndAuditAlarm or ObjectCloseAuditAlarm function when the object handle is created. If this flag is TRUE, the function generates an audit message. If it is FALSE, the function does not generate an audit message.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The ObjectCloseAuditAlarm function requires the calling application to have the SE_AUDIT_NAME privilege enabled. The test for this privilege is always performed against the primary token of the calling process, allowing the calling process to impersonate a client.AccessCheckAndAuditAlarmClient/Server Access Control FunctionsClient/Server Access Control OverviewObjectDeleteAuditAlarmObjectOpenAuditAlarmObjectPrivilegeAuditAlarm</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ObjectCloseAuditAlarmA(string SubsystemName, IntPtr HandleId, bool GenerateOnClose);

        /// <summary>
        ///The ObjectDeleteAuditAlarm function generates audit messages when an object is deleted. Alarms are not currently supported.
        /// </summary>
        /// <param name="SubsystemName">A pointer to a null-terminated string specifying the name of the subsystem calling the function. This string appears in any audit message that the function generates.</param>
        /// <param name="HandleId">Specifies a unique value representing the client's handle to the object. This must be the same value that was passed to the AccessCheckAndAuditAlarm or ObjectOpenAuditAlarm function.</param>
        /// <param name="GenerateOnClose">Specifies a flag set by a call to the AccessCheckAndAuditAlarm or ObjectOpenAuditAlarm function when the object handle is created.If the function succeeds, the return value is a nonzero value.If the function fails, the return value is zero. To get extended error information, call GetLastError.The ObjectDeleteAuditAlarm function requires the calling application to have the SE_AUDIT_NAME privilege enabled. The test for this privilege is always performed against the primary token of the calling process, allowing the calling process to impersonate a client.AccessCheckAccessCheckAndAuditAlarmAreAllAccessesGrantedAreAnyAccessesGrantedClient/Server Access ControlClient/Server Access Control FunctionsMapGenericMaskObjectCloseAuditAlarmObjectOpenAuditAlarmObjectPrivilegeAuditAlarmPrivilegeCheckPrivilegedServiceAuditAlarm</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ObjectDeleteAuditAlarmA(string SubsystemName, IntPtr HandleId, bool GenerateOnClose);

        /// <summary>
        ///The ObjectOpenAuditAlarm function generates audit messages when a client application attempts to gain access to an object or to create a new one. Alarms are not currently supported.
        /// </summary>
        /// <param name="SubsystemName">A pointer to a null-terminated string specifying the name of the subsystem calling the function. This string appears in any audit message that the function generates.</param>
        /// <param name="HandleId">A pointer to a unique value representing the client's handle to the object. If the access is denied, this parameter is ignored.For cross-platform compatibility, the value addressed by this pointer must be sizeof(LPVOID) bytes long.</param>
        /// <param name="ObjectTypeName">A pointer to a null-terminated string specifying the type of object to which the client is requesting access. This string appears in any audit message that the function generates.</param>
        /// <param name="pSecurityDescriptor">A pointer to the SECURITY_DESCRIPTOR structure for the object being accessed.</param>
        /// <param name="ClientToken">Identifies an access token representing the client requesting the operation. This handle must be obtained by opening the token of a thread impersonating the client. The token must be open for TOKEN_QUERY access.</param>
        /// <param name="DesiredAccess">Specifies the desired access mask. This mask must have been previously mapped by the MapGenericMask function to contain no generic access rights.</param>
        /// <param name="GrantedAccess">Specifies an access mask indicating which access rights are granted. This access mask is intended to be the same value set by one of the access-checking functions in its GrantedAccess parameter. Examples of access-checking functions include AccessCheckAndAuditAlarm and AccessCheck.</param>
        /// <param name="ObjectCreation">Specifies a flag that determines whether the application creates a new object when access is granted. When this value is TRUE, the application creates a new object; when it is FALSE, the application opens an existing object.</param>
        /// <param name="AccessGranted">Specifies a flag indicating whether access was granted or denied in a previous call to an access-checking function, such as AccessCheck. If access was granted, this value is TRUE. If not, it is FALSE.</param>
        /// <param name="GenerateOnClose"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ObjectOpenAuditAlarmA(string SubsystemName, IntPtr HandleId, string ObjectTypeName, int pSecurityDescriptor, IntPtr ClientToken, uint DesiredAccess, uint GrantedAccess, bool ObjectCreation, bool AccessGranted, out bool GenerateOnClose);

        /// <summary>
        ///The ObjectPrivilegeAuditAlarm function generates an audit message in the security event log. A protected server can use this function to log attempts by a client to use a specified set of privileges with an open handle to a private object. Alarms are not currently supported.
        /// </summary>
        /// <param name="SubsystemName">A pointer to a null-terminated string specifying the name of the subsystem calling the function. This string appears in the audit message.</param>
        /// <param name="HandleId">A pointer to a unique value representing the client's handle to the object.</param>
        /// <param name="ClientToken">Identifies an access token representing the client that requested the operation. This handle must have been obtained by opening the token of a thread impersonating the client. The token must be open for TOKEN_QUERY access. The function uses this token to get the identity of the client for the audit message.</param>
        /// <param name="DesiredAccess">Specifies an access mask indicating the privileged access types being used or whose use is being attempted. The access mask can be mapped by the MapGenericMask function so it does not contain any generic access types.</param>
        /// <param name="Privileges">A pointer to a PRIVILEGE_SET structure containing the privileges that the client attempted to use. The names of the privileges appear in the audit message.</param>
        /// <param name="AccessGranted">Indicates whether the client's attempt to use the privileges was successful. If this value is TRUE, the audit message indicates success. If this value is FALSE, the audit message indicates failure.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The ObjectPrivilegeAuditAlarm function does not check the client's access to the object or check the client's access token to determine whether the privileges are held or enabled. Typically, you call the PrivilegeCheck function to determine whether the specified privileges are enabled in the access token, call the AccessCheck function to check the client's access to the object, and then call ObjectPrivilegeAuditAlarm to log the results.The ObjectPrivilegeAuditAlarm function requires the calling process to have SE_AUDIT_NAME privilege enabled. The test for this privilege is always performed against the primary token of the calling process, not the impersonation token of the thread. This allows the calling process to impersonate a client during the call.AccessCheckAccessCheckAndAuditAlarmClient/Server Access Control FunctionsClient/Server Access Control OverviewMapGenericMaskObjectCloseAuditAlarmObjectOpenAuditAlarmPRIVILEGE_SETPrivilegeCheckPrivilegedServiceAuditAlarm</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ObjectPrivilegeAuditAlarmA(string SubsystemName, IntPtr HandleId, IntPtr ClientToken, uint DesiredAccess, int Privileges, bool AccessGranted);

        /// <summary>
        ///Opens a handle to a backup event log created by the BackupEventLog function.
        /// </summary>
        /// <param name="lpUNCServerName">The Universal Naming Convention (UNC) name of the remote server on which this operation is to be performed. If this parameter is NULL, the local computer is used.</param>
        /// <param name="lpFileName">The full path of the backup file.If the function succeeds, the return value is a handle to the backup event log.If the function fails, the return value is NULL. To get extended error information, call GetLastError.If the backup filename specifies a remote server, the lpUNCServerName parameter must be NULL.When this function is used on Windows Vista and later computers, only backup event logs that were saved with the BackupEventLog function on Windows Vista and later computers can be opened.BackupEventLogEvent Logging Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr OpenBackupEventLogA(string lpUNCServerName, string lpFileName);

        /// <summary>
        ///Opens a handle to a backup event log created by the BackupEventLog function.
        /// </summary>
        /// <param name="lpUNCServerName">The Universal Naming Convention (UNC) name of the remote server on which this operation is to be performed. If this parameter is NULL, the local computer is used.</param>
        /// <param name="lpFileName">The full path of the backup file.If the function succeeds, the return value is a handle to the backup event log.If the function fails, the return value is NULL. To get extended error information, call GetLastError.If the backup filename specifies a remote server, the lpUNCServerName parameter must be NULL.When this function is used on Windows Vista and later computers, only backup event logs that were saved with the BackupEventLog function on Windows Vista and later computers can be opened.BackupEventLogEvent Logging Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr OpenBackupEventLogW(string lpUNCServerName, string lpFileName);

        /// <summary>
        ///Attempts to open a communication device.
        /// </summary>
        /// <param name="uPortNumber">A one-based port number for the communication device to open.</param>
        /// <param name="dwDesiredAccess">The requested access to the device.For more information about requested access, see CreateFile and Creating and Opening Files.</param>
        /// <param name="dwFlagsAndAttributes">The requested flags and attributes to the device.If the function succeeds, the function returns a valid HANDLE. Use CloseHandle to close that handle.If an error occurs, the function returns INVALID_HANDLE_VALUE.The uPortNumber parameter accepts one-based values. A value of 1 for uPortNumber causes this function to attempt to open COM1.To support UWP, link against WindowsApp.lib.CloseHandleCreateFileCreating and Opening Files</param>

        [DllImport("KernelBase.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr OpenCommPort(int uPortNumber, uint dwDesiredAccess, uint dwFlagsAndAttributes);

        /// <summary>
        ///Opens an encrypted file in order to backup (export) or restore (import) the file. This is one of a group of Encrypted File System (EFS) functions that is intended to implement backup and restore functionality, while maintaining files in their encrypted state.
        /// </summary>
        /// <param name="lpFileName">The name of the file to be opened. The string must consist of characters from the Windows character set.</param>
        /// <param name="ulFlags">The operation to be performed. This parameter may be one of the following values.</param>
        /// <param name="pvContext"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint OpenEncryptedFileRawA(string lpFileName, int ulFlags, out IntPtr pvContext);

        /// <summary>
        ///Opens an encrypted file in order to backup (export) or restore (import) the file. This is one of a group of Encrypted File System (EFS) functions that is intended to implement backup and restore functionality, while maintaining files in their encrypted state.
        /// </summary>
        /// <param name="lpFileName">The name of the file to be opened. The string must consist of characters from the Windows character set.</param>
        /// <param name="ulFlags">The operation to be performed. This parameter may be one of the following values.</param>
        /// <param name="pvContext"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint OpenEncryptedFileRawW(string lpFileName, int ulFlags, out IntPtr pvContext);

        /// <summary>
        ///Opens a handle to the specified event log.
        /// </summary>
        /// <param name="lpUNCServerName">The Universal Naming Convention (UNC) name of the remote server on which the event log is to be opened. If this parameter is NULL, the local computer is used.</param>
        /// <param name="lpSourceName">The name of the log.If you specify a custom log and it cannot be found, the event logging service opens the Application log; however, there will be no associated message or category string file.If the function succeeds, the return value is the handle to an event log.If the function fails, the return value is NULL. To get extended error information, call GetLastError.To close the handle to the event log, use the CloseEventLog function.For an example, see Querying for Event Information.ClearEventLogCloseEventLogEvent Logging FunctionsEventlog KeyReadEventLogReportEvent</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr OpenEventLogA(string lpUNCServerName, string lpSourceName);

        /// <summary>
        ///Opens a handle to the specified event log.
        /// </summary>
        /// <param name="lpUNCServerName">The Universal Naming Convention (UNC) name of the remote server on which the event log is to be opened. If this parameter is NULL, the local computer is used.</param>
        /// <param name="lpSourceName">The name of the log.If you specify a custom log and it cannot be found, the event logging service opens the Application log; however, there will be no associated message or category string file.If the function succeeds, the return value is the handle to an event log.If the function fails, the return value is NULL. To get extended error information, call GetLastError.To close the handle to the event log, use the CloseEventLog function.For an example, see Querying for Event Information.ClearEventLogCloseEventLogEvent Logging FunctionsEventlog KeyReadEventLogReportEvent</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr OpenEventLogW(string lpUNCServerName, string lpSourceName);

        /// <summary>
        ///Creates, opens, reopens, or deletes a file.
        /// </summary>
        /// <param name="lpFileName">The name of the file.The string must consist of characters from the 8-bit Windows character set. The OpenFile function does not support Unicode file names or opening named pipes.</param>
        /// <param name="lpReOpenBuff"></param>
        /// <param name="uStyle">The action to be taken.This parameter can be one or more of the following values.If the function succeeds, the return value specifies a file handle to use when performing file I/O. To close the file, call the CloseHandle function using this handle.If the function fails, the return value is HFILE_ERROR. To get extended error information, call GetLastError.If the lpFileName parameter specifies a file name and extension only, this function searches for a matching file in the following directories and the order shown:The OpenFile function does not support the OF_SEARCH flag that the 16-bit Windows OpenFile function supports. The OF_SEARCH flag directs the system to search for a matching file even when a file name includes a full path. Use the SearchPath function to search for a file.A sharing violation occurs if an attempt is made to open a file or directory for deletion on a remote machine when the value of the uStyle parameter is the OF_DELETE access flag OR'ed with any other access flag, and the remote file or directory has not been opened with FILE_SHARE_DELETE share access. To avoid the sharing violation in this scenario, open the remote file or directory with OF_DELETE access only, or call DeleteFile without first opening the file or directory for deletion.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.CsvFs will do redirected IO for compressed files.CreateFileFile Management FunctionsGetSystemDirectoryGetWindowsDirectoryOFSTRUCTSearchPath</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr OpenFile(string lpFileName, out int lpReOpenBuff, int uStyle);

        /// <summary>
        ///Opens the file that matches the specified identifier.
        /// </summary>
        /// <param name="hVolumeHint">A handle to any file on a volume or share on which the file to be opened is stored.</param>
        /// <param name="lpFileId">A pointer to a FILE_ID_DESCRIPTOR that identifies the file to open.</param>
        /// <param name="dwDesiredAccess">The access to the object. Access can be read, write, or both.For more information, see File Security and Access Rights. You cannot request an access mode that conflicts with the sharing mode that is specified in an open request that has an open handle.If this parameter is zero (0), the application can query file and device attributes without accessing a device. This is useful for an application to determine the size of a floppy disk drive and the formats it supports without requiring a floppy in a drive. It can also be used to test for the existence of a file or directory without opening them for read or write access.</param>
        /// <param name="dwShareMode">The sharing mode of an object, which can be read, write, both, or none.You cannot request a sharing mode that conflicts with the access mode that is specified in an open request that has an open handle, because that would result in the following sharing violation: (ERROR_SHARING_VIOLATION). For more information, see Creating and Opening Files.If this parameter is zero (0) and OpenFileById succeeds, the object cannot be shared and cannot be opened again until the handle is closed. For more information, see the Remarks section of this topic.The sharing options remain in effect until you close the handle to an object.To enable a processes to share an object while another process has the object open, use a combination of one or more of the following values to specify the access mode they can request to open the object.</param>
        /// <param name="dwFlagsAndAttributes">The file flags.When OpenFileById opens a file, it combines the file flags with existing file attributes, and ignores any supplied file attributes. This parameter can include any combination of the following flags.If the function succeeds, the return value is an open handle to a specified file.If the function fails, the return value is INVALID_HANDLE_VALUE. To get extended error information, call GetLastError.Use the CloseHandle function to close an object handle that OpenFileById returns.If you call OpenFileById on a file that is pending deletion as a result of a previous call to DeleteFile, the function fails. The operating system delays file deletion until all handles to the file are closed. GetLastError returns ERROR_ACCESS_DENIED.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.ACCESS_MASKCloseHandleCreateFileDeleteFileFILE_ID_DESCRIPTORFile Management FunctionsGetFileInformationByHandleExGetOverlappedResultOVERLAPPEDOpenFileReadFileWriteFile</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr OpenFileById(IntPtr hVolumeHint, int lpFileId, uint dwDesiredAccess, uint dwShareMode, uint dwFlagsAndAttributes);

        /// <summary>
        ///Opens a named file mapping object.
        /// </summary>
        /// <param name="dwDesiredAccess">The access to the file mapping object. This access is checked against any security descriptor on the target file mapping object. For a list of values, see File Mapping Security and Access Rights.</param>
        /// <param name="bInheritHandle">If this parameter is TRUE, a process created by the CreateProcess function can inherit the handle; otherwise, the handle cannot be inherited.</param>
        /// <param name="lpName">The name of the file mapping object to be opened. If there is an open handle to a file mapping object by this name and the security descriptor on the mapping object does not conflict with the dwDesiredAccess parameter, the open operation succeeds. The name can have a "Global\" or "Local\" prefix to explicitly open an object in the global or session namespace. The remainder of the name can contain any character except the backslash character (\). For more information, see Kernel Object Namespaces. Fast user switching is implemented using Terminal Services sessions. The first user to log on uses session 0, the next user to log on uses session 1, and so on. Kernel object names must follow the guidelines outlined for Terminal Services so that applications can support multiple users.If the function succeeds, the return value is an open handle to the specified file mapping object.If the function fails, the return value is NULL. To get extended error information, call GetLastError.The handle that OpenFileMapping returns can be used with any function that requires a handle to a file mapping object.When modifying a file through a mapped view, the last modification timestamp may not be updated automatically. If required, the caller should use SetFileTime to set the timestamp.When it is no longer needed, the caller should call release the handle returned by OpenFileMapping with a call to CloseHandle.In Windows Server 2012, this function is supported by the following technologies.For an example, see Creating Named Shared Memory.CreateFileMappingFile Mapping FunctionsMemory Management FunctionsSharing Files and Memory</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr OpenFileMappingA(uint dwDesiredAccess, bool bInheritHandle, string lpName);

        /// <summary>
        ///Opens an existing job object.
        /// </summary>
        /// <param name="dwDesiredAccess">The access to the job object. This parameter can be one or more of the job object access rights. This access right is checked against any security descriptor for the object.</param>
        /// <param name="bInheritHandle">If this value is TRUE, processes created by this process will inherit the handle. Otherwise, the processes do not inherit this handle.</param>
        /// <param name="lpName">The name of the job to be opened. Name comparisons are case sensitive.This function can open objects in a private namespace. For more information, see Object Namespaces.Terminal Services:  The name can have a "Global" or "Local" prefix to explicitly open the object in the global or session namespace. The remainder of the name can contain any character except the backslash character (\). For more information, see Kernel Object Namespaces.If the function succeeds, the return value is a handle to the job. The handle provides the requested access to the job.If the function fails, the return value is NULL. To get extended error information, call GetLastError.An error of ERROR_FILE_NOT_FOUND indicates that the job specified in lpName does not exist.To associate a process with a job, use the AssignProcessToJobObject function.To compile an application that uses this function, define _WIN32_WINNT as 0x0500 or later. For more information, see Using the Windows Headers.AssignProcessToJobObjectJob ObjectsProcess and Thread Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr OpenJobObjectA(uint dwDesiredAccess, bool bInheritHandle, string lpName);

        /// <summary>
        ///Opens a private namespace.
        /// </summary>
        /// <param name="lpBoundaryDescriptor">A descriptor that defines how the namespace is to be isolated. The CreateBoundaryDescriptor function creates a boundary descriptor.</param>
        /// <param name="lpAliasPrefix">The prefix for the namespace. To create an object in this namespace, specify the object name as prefix\objectname.The function returns the handle to the existing namespace.To compile an application that uses this function, define _WIN32_WINNT as 0x0600 or later.ClosePrivateNamespaceCreateBoundaryDescriptorCreatePrivateNamespaceObject Namespaces</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr OpenPrivateNamespaceA(IntPtr lpBoundaryDescriptor, string lpAliasPrefix);

        /// <summary>
        ///Notifies the system that the application is about to end an operation
        /// </summary>
        /// <param name="OperationEndParams">An _OPERATION_END_PARAMETERS structure that specifies VERSION, OPERATION_ID and FLAGS.TRUE for all valid parameters and FALSE otherwise. To get extended error information, call GetLastError.The version of the _OPERATION_END_PARAMETERS structure is defined as OPERATION_API_VERSION in the Windows SDK.The OperationEnd function is safe to call on any thread.OPERATION_IDOperation RecorderOperationStart_OPERATION_END_PARAMETERS_OPERATION_START_PARAMETERS</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool OperationEnd(int OperationEndParams);

        /// <summary>
        ///Notifies the system that the application is about to start an operation.
        /// </summary>
        /// <param name="OperationStartParams">An _OPERATION_START_PARAMETERS structure that specifies VERSION, OPERATION_ID and FLAGS.TRUE for all valid parameters and FALSE otherwise. To get extended error information, call GetLastError.The version of the _OPERATION_START_PARAMETERS structure is defined as OPERATION_API_VERSION in the Windows SDK.Because the OperationStart function is synchronous, it can take several seconds to return. This should be avoided in UI threads for the best responsiveness.There is a single instance of the operation recorder in a process. Although the operation recorder APIs can be called from multiple threads within the process, all calls act on the single instance.Application launch tracing lasts for the first 10 second of the process lifetime. OperationStart should be called after the end of application launch tracing by the system.Every call to OperationStart must be followed by a call to OperationEnd. Otherwise, the operation trace will be discarded after about 10s.The maximum number of operations that can be recorded on a given system is configurable. If this maximum is exceeded, the least recently used prefetch files are replaced.On Windows 8, this functionality requires the Superfetch service to be enabled. Windows 8 will have the service enabled by default. For Windows Server 2012, this prefetching functionality needs to be enabled and disabled as required. This can be done using CIM based PowerShell cmdlets. The prefetcher functionality can be exposed using the CIM class of the CIM_PrefetcherService.OPERATION_IDOperation RecorderOperationEnd_OPERATION_END_PARAMETERS_OPERATION_START_PARAMETERS</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool OperationStart(int OperationStartParams);

        /// <summary>
        ///Decrements the count of power requests of the specified type for a power request object.
        /// </summary>
        /// <param name="PowerRequest">A handle to a power request object.</param>
        /// <param name="RequestType">The power request type to be decremented. This parameter can be one of the following values.If the function succeeds, it returns a nonzero value.If the function fails, it returns zero. To get extended error information, call GetLastError.PowerCreateRequestPowerSetRequest</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool PowerClearRequest(IntPtr PowerRequest, int RequestType);

        /// <summary>
        ///Creates a new power request object.
        /// </summary>
        /// <param name="Context">Points to a REASON_CONTEXT structure that contains information about the power request.If the function succeeds, the return value is a handle to the power request object.If the function fails, the return value is INVALID_HANDLE_VALUE. To get extended error information, call GetLastError.When the power request object is no longer needed, use the CloseHandle function to free the handle and clean up the object.PowerClearRequestPowerSetRequest</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr PowerCreateRequest(int Context);

        /// <summary>
        ///Increments the count of power requests of the specified type for a power request object.
        /// </summary>
        /// <param name="PowerRequest">A handle to a power request object.</param>
        /// <param name="RequestType">The power request type to be incremented. This parameter can be one of the following values.If the function succeeds, it returns a nonzero value.If the function fails, it returns zero. To get extended error information, call GetLastError.On Modern Standby systems on DC power, system and execution required power requests are terminated 5 minutes after the system sleep timeout has expired.Except for PowerRequestAwayModeRequired on Traditional Sleep (S3) systems, power requests are terminated upon user-initiated system sleep entry (power button, lid close or selecting Sleep from the Start menu).To conserve power and provide the best user experience, applications that use power requests should follow these best practices:PowerClearRequestPowerCreateRequest</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool PowerSetRequest(IntPtr PowerRequest, int RequestType);

        /// <summary>
        ///The PrepareTape function prepares the tape to be accessed or removed.
        /// </summary>
        /// <param name="hDevice">Handle to the device preparing the tape. This handle is created by using the CreateFile function.</param>
        /// <param name="dwOperation">Tape device preparation. This parameter can be one of the following values.</param>
        /// <param name="bImmediate">If this parameter is TRUE, the function returns immediately. If it is FALSE, the function does not return until the operation has been completed.If the function succeeds, the return value is NO_ERROR.If the function fails, it can return one of the following error codes.Some tape devices do not support certain tape operations. See your tape device documentation and use the GetTapeParameters function to determine your tape device's capabilities.CreateFileGetTapeParameters</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint PrepareTape(IntPtr hDevice, uint dwOperation, bool bImmediate);

        /// <summary>
        ///The PrivilegedServiceAuditAlarm function generates an audit message in the security event log. A protected server can use this function to log attempts by a client to use a specified set of privileges.
        /// </summary>
        /// <param name="SubsystemName">A pointer to a null-terminated string specifying the name of the subsystem calling the function. This information appears in the security event log record.</param>
        /// <param name="ServiceName">A pointer to a null-terminated string specifying the name of the privileged subsystem service. This information appears in the security event log record.</param>
        /// <param name="ClientToken">Identifies an access token representing the client that requested the operation. This handle must have been obtained by opening the token of a thread impersonating the client. The token must be open for TOKEN_QUERY access. The function uses this token to get the identity of the client for the security event log record.</param>
        /// <param name="Privileges">A pointer to a PRIVILEGE_SET structure containing the privileges that the client attempted to use. The names of the privileges appear in the security event log record.</param>
        /// <param name="AccessGranted">Indicates whether the client's attempt to use the privileges was successful. If this value is TRUE, the security event log record indicates success. If this value is FALSE, the security event log record indicates failure.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The PrivilegedServiceAuditAlarm function does not check the client's access token to determine whether the privileges are held or enabled. Typically, you first call the PrivilegeCheck function to determine whether the specified privileges are enabled in the access token, and then call PrivilegedServiceAuditAlarm to log the results.The PrivilegedServiceAuditAlarm function requires the calling process to have SE_AUDIT_NAME privilege enabled. The test for this privilege is always performed against the primary token of the calling process. This allows the calling process to impersonate a client during the call.Client/Server Access Control FunctionsClient/Server Access Control OverviewObjectPrivilegeAuditAlarmPRIVILEGE_SETPrivilegeCheck</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool PrivilegedServiceAuditAlarmA(string SubsystemName, string ServiceName, IntPtr ClientToken, int Privileges, bool AccessGranted);

        /// <summary>
        ///Sets the specified event object to the signaled state and then resets it to the nonsignaled state after releasing the appropriate number of waiting threads.
        /// </summary>
        /// <param name="hEvent">A handle to the event object. The CreateEvent or OpenEvent function returns this handle.The handle must have the EVENT_MODIFY_STATE access right. For more information, see Synchronization Object Security and Access Rights.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.A thread waiting on a synchronization object can be momentarily removed from the wait state by a kernel-mode APC, and then returned to the wait state after the APC is complete. If the call to PulseEvent occurs during the time when the thread has been removed from the wait state, the thread will not be released because PulseEvent releases only those threads that are waiting at the moment it is called. Therefore, PulseEvent is unreliable and should not be used by new applications. Instead, use condition variables.For a manual-reset event object, all waiting threads that can be released immediately are released. The function then resets the event object's state to nonsignaled and returns.For an auto-reset event object, the function resets the state to nonsignaled and returns after releasing a single waiting thread, even if multiple threads are waiting.If no threads are waiting, or if no thread can be released immediately, PulseEvent simply sets the event object's state to nonsignaled and returns.Note that for a thread using the multiple-object wait functions to wait for all specified objects to be signaled, PulseEvent can set the event object's state to signaled and reset it to nonsignaled without causing the wait function to return. This happens if not all of the specified objects are simultaneously signaled.Use extreme caution when using SignalObjectAndWait and PulseEvent with Windows 7, since using these APIs among multiple threads can cause an application to deadlock. Threads that are signaled by SignalObjectAndWait call PulseEvent to signal the waiting object of the SignalObjectAndWait call. In some circumstances, the caller of SignalObjectAndWait can't receive signal state of the waiting object in time, causing a deadlock.CreateEventEvent ObjectsOpenEventResetEventSetEventSynchronization Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool PulseEvent(IntPtr hEvent);

        /// <summary>
        ///Discards all characters from the output or input buffer of a specified communications resource. It can also terminate pending read or write operations on the resource.
        /// </summary>
        /// <param name="hFile">A handle to the communications resource. The CreateFile function returns this handle.</param>
        /// <param name="dwFlags">This parameter can be one or more of the following values.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.If a thread uses PurgeComm to flush an output buffer, the deleted characters are not transmitted. To empty the output buffer while ensuring that the contents are transmitted, call the FlushFileBuffers function (a synchronous operation). Note, however, that FlushFileBuffers is subject to flow control but not to write time-outs, and it will not return until all pending write operations have been transmitted.Communications FunctionsCommunications ResourcesCreateFile</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool PurgeComm(IntPtr hFile, uint dwFlags);

        /// <summary>
        ///The QueryActCtxSettingsW function specifies the activation context, and the namespace and name of the attribute that is to be queried.
        /// </summary>
        /// <param name="settingName">The name of the attribute to be queried.</param>
        /// <param name="pvBuffer"></param>
        /// <param name="dwBuffer">The size of the buffer in characters that receives the query result.</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool QueryActCtxSettingsW(string settingName, out string pvBuffer, int dwBuffer);

        /// <summary>
        ///The QueryActCtxW function queries the activation context.
        /// </summary>
        /// <param name="dwFlags">This parameter should be set to one of the following flag bits.</param>
        /// <param name="hActCtx">Handle to the activation context that is being queried.</param>
        /// <param name="ulInfoClass">This parameter can have only the values shown in the following table.</param>
        /// <param name="pvBuffer"></param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool QueryActCtxW(uint dwFlags, IntPtr hActCtx, int ulInfoClass, out IntPtr pvBuffer);

        /// <summary>
        ///Retrieves information about MS-DOS device names. The function can obtain the current mapping for a particular MS-DOS device name. The function can also obtain a list of all existing MS-DOS device names.
        /// </summary>
        /// <param name="lpTargetPath"></param>
        /// <param name="ucchMax">The maximum number of TCHARs that can be stored into the buffer pointed to by lpTargetPath.If the function succeeds, the return value is the number of TCHARs stored into the buffer pointed to by lpTargetPath.If the function fails, the return value is zero. To get extended error information, call GetLastError.If the buffer is too small, the function fails and the last error code is ERROR_INSUFFICIENT_BUFFER.The DefineDosDevice function enables an application to create and modify the junctions used to implement the MS-DOS device namespace.Windows Server 2003 and Windows XP:  QueryDosDevice first searches the Local MS-DOS Device namespace for the specified device name. If the device name is not found, the function will then search the Global MS-DOS Device namespace.When all existing MS-DOS device names are queried, the list of device names that are returned is dependent on whether it is running in the "LocalSystem" context. If so, only the device names included in the Global MS-DOS Device namespace will be returned. If not, a concatenation of the device names in the Global and Local MS-DOS Device namespaces will be returned. If a device name exists in both namespaces, QueryDosDevice will return the entry in the Local MS-DOS Device namespace.For more information on the Global and Local MS-DOS Device namespaces and changes to the accessibility of MS-DOS device names, see Defining an MS DOS Device Name.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB does not support volume management functions.For an example, see Obtaining a File Name From a File Handle or Displaying Volume Paths.DefineDosDeviceVolume Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint QueryDosDeviceA(out string lpTargetPath, uint ucchMax);

        /// <summary>
        ///Retrieves the full name of the executable image for the specified process.
        /// </summary>
        /// <param name="hProcess">A handle to the process. This handle must be created with the PROCESS_QUERY_INFORMATION or PROCESS_QUERY_LIMITED_INFORMATION access right. For more information, see Process Security and Access Rights.</param>
        /// <param name="dwFlags">This parameter can be one of the following values.</param>
        /// <param name="lpExeName"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool QueryFullProcessImageNameA(IntPtr hProcess, uint dwFlags, out string lpExeName);

        /// <summary>
        ///Retrieves the full name of the executable image for the specified process.
        /// </summary>
        /// <param name="hProcess">A handle to the process. This handle must be created with the PROCESS_QUERY_INFORMATION or PROCESS_QUERY_LIMITED_INFORMATION access right. For more information, see Process Security and Access Rights.</param>
        /// <param name="dwFlags">This parameter can be one of the following values.</param>
        /// <param name="lpExeName"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool QueryFullProcessImageNameW(IntPtr hProcess, uint dwFlags, out string lpExeName);

        /// <summary>
        ///Determines whether thread profiling is enabled for the specified thread.
        /// </summary>
        /// <param name="ThreadHandle">The handle to the thread of interest.</param>
        /// <param name="Enabled"></param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint QueryThreadProfiling(IntPtr ThreadHandle, out bool Enabled);

        /// <summary>
        ///Retrieves information about the specified user-mode scheduling (UMS) worker thread.
        /// </summary>
        /// <param name="UmsThread">A pointer to a UMS thread context.</param>
        /// <param name="UmsThreadInfoClass">A UMS_THREAD_INFO_CLASS value that specifies the kind of information to retrieve.</param>
        /// <param name="UmsThreadInformation"></param>
        /// <param name="UmsThreadInformationLength">The size of the UmsThreadInformation buffer, in bytes.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError. Possible error values include the following.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool QueryUmsThreadInformation(int UmsThread, IntPtr UmsThreadInfoClass, out IntPtr UmsThreadInformation, int UmsThreadInformationLength);

        /// <summary>
        ///Retrieves information that describes the changes within the specified directory, which can include extended information if that information type is specified. The function does not report changes to the specified directory itself.
        /// </summary>
        /// <param name="hDirectory">A handle to the directory to be monitored. This directory must be opened with the FILE_LIST_DIRECTORY access right, or an access right such as GENERIC_READ that includes the FILE_LIST_DIRECTORY access right.</param>
        /// <param name="lpBuffer"></param>
        /// <param name="nBufferLength">The size of the buffer to which the lpBuffer parameter points, in bytes.</param>
        /// <param name="bWatchSubtree">If this parameter is TRUE, the function monitors the directory tree rooted at the specified directory. If this parameter is FALSE, the function monitors only the directory specified by the hDirectory parameter.</param>
        /// <param name="dwNotifyFilter">The filter criteria that the function checks to determine if the wait operation has completed. This parameter can be one or more of the following values.</param>
        /// <param name="ReadDirectoryNotifyInformationClass">The type of information that ReadDirectoryChangesExW should write to the buffer to which the lpBuffer parameter points. Specify ReadDirectoryNotifyInformation to indicate that the information should consist of FILE_NOTIFY_INFORMATION structures, or ReadDirectoryNotifyExtendedInformation to indicate that the information should consist of FILE_NOTIFY_EXTENDED_INFORMATION structures.If the function succeeds, the return value is nonzero. For synchronous calls, this means that the operation succeeded. For asynchronous calls, this indicates that the operation was successfully queued.If the function fails, the return value is zero. To get extended error information, call GetLastError.If the network redirector or the target file system does not support this operation, the function fails with ERROR_INVALID_FUNCTION.To obtain a handle to a directory, use the CreateFile function with the FILE_FLAG_BACKUP_SEMANTICS flag.A call to ReadDirectoryChangesExW can be completed synchronously or asynchronously. To specify asynchronous completion, open the directory with CreateFile as shown above, but additionally specify the FILE_FLAG_OVERLAPPED attribute in the dwFlagsAndAttributes parameter. Then specify an OVERLAPPED structure when you call ReadDirectoryChangesExW.When you first call ReadDirectoryChangesExW, the system allocates a buffer to store change information. This buffer is associated with the directory handle until it is closed and its size does not change during its lifetime. Directory changes that occur between calls to this function are added to the buffer and then returned with the next call. If the buffer overflows, ReadDirectoryChangesExW will still return true, but the entire contents of the buffer are discarded and the lpBytesReturned parameter will be zero, which indicates that your buffer was too small to hold all of the changes that occurred.Upon successful synchronous completion, the lpBuffer parameter is a formatted buffer and the number of bytes written to the buffer is available in lpBytesReturned. If the number of bytes transferred is zero, the buffer was either too large for the system to allocate or too small to provide detailed information on all the changes that occurred in the directory or subtree. In this case, you should compute the changes by enumerating the directory or subtree.For asynchronous completion, you can receive notification in one of three ways:ReadDirectoryChangesExW fails with ERROR_INVALID_PARAMETER when the buffer length is greater than 64 KB and the application is monitoring a directory over the network. This is due to a packet size limitation with the underlying file sharing protocols.ReadDirectoryChangesExW fails with ERROR_NOACCESS when the buffer is not aligned on a DWORD boundary.ReadDirectoryChangesExW fails with ERROR_NOTIFY_ENUM_DIR when the system was unable to record all the changes to the directory. In this case, you should compute the changes by enumerating the directory or subtree.If you opened the file using the short name, you can receive change notifications for the short name.ReadDirectoryChangesExW is currently supported only for the NTFS file system.CreateFileCreateIoCompletionPortDirectory Management FunctionsFILE_NOTIFY_EXTENDED_INFORMATIONFILE_NOTIFY_INFORMATIONFileIOCompletionRoutineGetOverlappedResultGetQueuedCompletionStatusOVERLAPPEDREAD_DIRECTORY_NOTIFY_INFORMATION_CLASS</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ReadDirectoryChangesExW(IntPtr hDirectory, out IntPtr lpBuffer, uint nBufferLength, bool bWatchSubtree, uint dwNotifyFilter, int ReadDirectoryNotifyInformationClass);

        /// <summary>
        ///Retrieves information that describes the changes within the specified directory. The function does not report changes to the specified directory itself.
        /// </summary>
        /// <param name="hDirectory">A handle to the directory to be monitored. This directory must be opened with the FILE_LIST_DIRECTORY access right, or an access right such as GENERIC_READ that includes the FILE_LIST_DIRECTORY access right.</param>
        /// <param name="lpBuffer"></param>
        /// <param name="nBufferLength">The size of the buffer that is pointed to by the lpBuffer parameter, in bytes.</param>
        /// <param name="bWatchSubtree">If this parameter is TRUE, the function monitors the directory tree rooted at the specified directory. If this parameter is FALSE, the function monitors only the directory specified by the hDirectory parameter.</param>
        /// <param name="dwNotifyFilter">The filter criteria that the function checks to determine if the wait operation has completed. This parameter can be one or more of the following values.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ReadDirectoryChangesW(IntPtr hDirectory, out IntPtr lpBuffer, uint nBufferLength, bool bWatchSubtree, uint dwNotifyFilter);

        /// <summary>
        ///Backs up (export) encrypted files. This is one of a group of Encrypted File System (EFS) functions that is intended to implement backup and restore functionality, while maintaining files in their encrypted state.
        /// </summary>
        /// <param name="pfExportCallback">A pointer to the export callback function. The system calls the callback function multiple times, each time passing a block of the file's data to the callback function until the entire file has been read. For more information, see ExportCallback.</param>
        /// <param name="pvContext">A pointer to a system-defined context block. The context block is returned by the OpenEncryptedFileRaw function. Do not modify it.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, it returns a nonzero error code defined in WinError.h. You can use FormatMessage with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic text description of the error.The file being backed up is not decrypted; it is backed up in its encrypted state.To back up an encrypted file, call OpenEncryptedFileRaw to open the file. Then call ReadEncryptedFileRaw, passing it the address of an application-defined export callback function. The system calls this callback function multiple times until the entire file's contents have been read and backed up. When the backup is complete, call CloseEncryptedFileRaw to free resources and close the file. See ExportCallback for details about how to declare the export callback function.To restore an encrypted file, call OpenEncryptedFileRaw, specifying CREATE_FOR_IMPORT in the ulFlags parameter. Then call WriteEncryptedFileRaw, passing it the address of an application-defined import callback function. The system calls this callback function multiple times until the entire file's contents have been read and restored. When the restore is complete, call CloseEncryptedFileRaw to free resources and close the file. See ImportCallback for details about how to declare the import callback function.This function is intended for the backup of only encrypted files; see BackupRead for backup of unencrypted files.In Windows 8, Windows Server 2012, and later, this function is supported by the following technologies.SMB 3.0 does not support EFS on shares with continuous availability capability.BackupReadCloseEncryptedFileRawFile EncryptionFile Management FunctionsOpenEncryptedFileRawWriteEncryptedFileRaw</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint ReadEncryptedFileRaw(int pfExportCallback, IntPtr pvContext);

        /// <summary>
        ///Reads the specified number of entries from the specified event log. The function can be used to read log entries in chronological or reverse chronological order.
        /// </summary>
        /// <param name="hEventLog">A handle to the event log to be read. The OpenEventLog function returns this handle.</param>
        /// <param name="dwReadFlags">Use the following flag values to indicate how to read the log file. This parameter must include one of the following values (the flags are mutually exclusive).You must specify one of the following flags to indicate the direction for successive read operations (the flags are mutually exclusive).</param>
        /// <param name="dwRecordOffset">The record number of the log-entry at which the read operation should start. This parameter is ignored unless dwReadFlags includes the EVENTLOG_SEEK_READ flag.</param>
        /// <param name="lpBuffer"></param>
        /// <param name="nNumberOfBytesToRead">The size of the lpBuffer buffer, in bytes. This function will read as many log entries as will fit in the buffer; the function will not return partial entries.</param>
        /// <param name="pnBytesRead"></param>
        /// <param name="pnMinNumberOfBytesNeeded"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ReadEventLogA(IntPtr hEventLog, uint dwReadFlags, uint dwRecordOffset, out IntPtr lpBuffer, uint nNumberOfBytesToRead, out uint pnBytesRead, out uint pnMinNumberOfBytesNeeded);

        /// <summary>
        ///Reads the specified number of entries from the specified event log. The function can be used to read log entries in chronological or reverse chronological order.
        /// </summary>
        /// <param name="hEventLog">A handle to the event log to be read. The OpenEventLog function returns this handle.</param>
        /// <param name="dwReadFlags">Use the following flag values to indicate how to read the log file. This parameter must include one of the following values (the flags are mutually exclusive).You must specify one of the following flags to indicate the direction for successive read operations (the flags are mutually exclusive).</param>
        /// <param name="dwRecordOffset">The record number of the log-entry at which the read operation should start. This parameter is ignored unless dwReadFlags includes the EVENTLOG_SEEK_READ flag.</param>
        /// <param name="lpBuffer"></param>
        /// <param name="nNumberOfBytesToRead">The size of the lpBuffer buffer, in bytes. This function will read as many log entries as will fit in the buffer; the function will not return partial entries.</param>
        /// <param name="pnBytesRead"></param>
        /// <param name="pnMinNumberOfBytesNeeded"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ReadEventLogW(IntPtr hEventLog, uint dwReadFlags, uint dwRecordOffset, out IntPtr lpBuffer, uint nNumberOfBytesToRead, out uint pnBytesRead, out uint pnMinNumberOfBytesNeeded);

        /// <summary>
        ///Reads the specified profiling data associated with the thread.
        /// </summary>
        /// <param name="PerformanceDataHandle">The handle that the EnableThreadProfiling function returned.</param>
        /// <param name="Flags">One or more of the following flags that specify the counter data to read. The flags must have been set when you called the EnableThreadProfiling function.</param>
        /// <param name="PerformanceData"></param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint ReadThreadProfilingData(IntPtr PerformanceDataHandle, uint Flags, out int PerformanceData);

        /// <summary>
        ///Registers the active instance of an application for recovery.
        /// </summary>
        /// <param name="pRecoveyCallback">A pointer to the recovery callback function. For more information, see ApplicationRecoveryCallback.</param>
        /// <param name="dwPingInterval">The recovery ping interval, in milliseconds. By default, the interval is 5 seconds (RECOVERY_DEFAULT_PING_INTERVAL). The maximum interval is 5 minutes. If you specify zero, the default interval is used.You must call the ApplicationRecoveryInProgress function within the specified interval to indicate to ARR that you are still actively recovering; otherwise, WER terminates recovery. Typically, you perform recovery in a loop with each iteration lasting no longer than the ping interval. Each iteration performs a block of recovery work followed by a call to ApplicationRecoveryInProgress. Since you also use ApplicationRecoveryInProgress to determine if the user wants to cancel recovery, you should consider a smaller interval, so you do not perform a lot of work unnecessarily.</param>
        /// <param name="dwFlags">Reserved for future use. Set to zero.This function returns S_OK on success or one of the following error codes.If the application encounters an unhandled exception or becomes unresponsive, Windows Error Reporting (WER) calls the specified recovery callback. You should use the callback to save data and state information. You can use the information if you also call the RegisterApplicationRestart function to request that WER restart the application.WER will not call your recovery callback if an installer wants to update a component of your application. To save data and state information in the update case, you should handle the WM_QUERYENDSESSION and WM_ENDSESSION messages. For details, see each message. The timeout for responding to these messages is five seconds. Most of the available recovery time is in the WM_CLOSE message for which you have 30 seconds.A console application that can be updated uses the CTRL_C_EVENT notification to initiate recovery (for details, see the HandlerRoutine callback function). The timeout for the handler to complete is 30 seconds.Applications should consider saving data and state information on a periodic bases to shorten the amount of time required for recovery.ApplicationRecoveryCallbackApplicationRecoveryInProgressRegisterApplicationRestartUnregisterApplicationRecoveryCallback</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr RegisterApplicationRecoveryCallback(int pRecoveyCallback, uint dwPingInterval, uint dwFlags);

        /// <summary>
        ///Registers the active instance of an application for restart.
        /// </summary>
        /// <param name="dwFlags">This parameter can be 0 or one or more of the following values.This function returns S_OK on success or one of the following error codes.Your initial registration for restart must occur before the application encounters an unhandled exception or becomes unresponsive. You could then call this function from inside your recovery callback to update the command line.For a Windows application that is being updated, the last opportunity to call this function is while processing the WM_QUERYENDSESSION message. For a console application that is being updated, the registration must occur before the installer tries to shutdown the application (you need to keep the registration current; you cannot call this function when handling the CTRL_C_EVENT notification).If you register for restart and the application encounters an unhandled exception or is not responsive, the user is offered the opportunity to restart the application; the application is not automatically restarted without the user's consent. However, if the application is being updated and requires a restart, the application is restarted automatically.To prevent cyclical restarts, the system will only restart the application if it has been running for a minimum of 60 seconds.Note that for an application to be restarted when the update requires a computer restart, the installer must call the ExitWindowsEx function with the EWX_RESTARTAPPS flag set or the InitiateShutdown function with the SHUTDOWN_RESTARTAPPS flag set.UnregisterApplicationRestart</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr RegisterApplicationRestart(uint dwFlags);

        /// <summary>
        ///Retrieves a registered handle to the specified event log.
        /// </summary>
        /// <param name="lpUNCServerName">The Universal Naming Convention (UNC) name of the remote server on which this operation is to be performed. If this parameter is NULL, the local computer is used.</param>
        /// <param name="lpSourceName">The name of the event source whose handle is to be retrieved. The source name must be a subkey of a log under the Eventlog registry key. Note that the Security log is for system use only.If the function succeeds, the return value is a handle to the event log.If the function fails, the return value is NULL. To get extended error information, call GetLastError.The function returns ERROR_ACCESS_DENIED if lpSourceName specifies the Security event log.If the source name cannot be found, the event logging service uses the Application log. Although events will be reported , the events will not include descriptions because there are no message and category message files for looking up descriptions related to the event identifiers.To close the handle to the event log, use the DeregisterEventSource function.For an example, see Reporting an Event.DeregisterEventSourceEvent Logging FunctionsEvent SourcesReportEvent</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr RegisterEventSourceA(string lpUNCServerName, string lpSourceName);

        /// <summary>
        ///Retrieves a registered handle to the specified event log.
        /// </summary>
        /// <param name="lpUNCServerName">The Universal Naming Convention (UNC) name of the remote server on which this operation is to be performed. If this parameter is NULL, the local computer is used.</param>
        /// <param name="lpSourceName">The name of the event source whose handle is to be retrieved. The source name must be a subkey of a log under the Eventlog registry key. Note that the Security log is for system use only.If the function succeeds, the return value is a handle to the event log.If the function fails, the return value is NULL. To get extended error information, call GetLastError.The function returns ERROR_ACCESS_DENIED if lpSourceName specifies the Security event log.If the source name cannot be found, the event logging service uses the Application log. Although events will be reported , the events will not include descriptions because there are no message and category message files for looking up descriptions related to the event identifiers.To close the handle to the event log, use the DeregisterEventSource function.For an example, see Reporting an Event.DeregisterEventSourceEvent Logging FunctionsEvent SourcesReportEvent</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr RegisterEventSourceW(string lpUNCServerName, string lpSourceName);

        /// <summary>
        ///Directs a wait thread in the thread pool to wait on the object. The wait thread queues the specified callback function to the thread pool when one of the following occurs:
        /// </summary>
        /// <param name="hObject">A handle to the object. For a list of the object types whose handles can be specified, see the following Remarks section.If this handle is closed while the wait is still pending, the function's behavior is undefined.The handles must have the SYNCHRONIZE access right. For more information, see Standard Access Rights.</param>
        /// <param name="Callback">A pointer to the application-defined function of type WAITORTIMERCALLBACK to be executed when hObject is in the signaled state, or dwMilliseconds elapses. For more information, see WaitOrTimerCallback.</param>
        /// <param name="dwMilliseconds">The time-out interval, in milliseconds. The function returns if the interval elapses, even if the object's state is nonsignaled. If dwMilliseconds is zero, the function tests the object's state and returns immediately. If dwMilliseconds is INFINITE, the function's time-out interval never elapses.</param>
        /// <param name="dwFlags">This parameter can be one or more of the following values.For information about using these values with objects that remain signaled, see the Remarks section.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.New wait threads are created automatically when required. The wait operation is performed by a wait thread from the thread pool. The callback routine is executed by a worker thread when the object's state becomes signaled or the time-out interval elapses. If dwFlags is not WT_EXECUTEONLYONCE, the timer is reset every time the event is signaled or the time-out interval elapses.When the wait is completed, you must call the UnregisterWait or UnregisterWaitEx function to cancel the wait operation. (Even wait operations that use WT_EXECUTEONLYONCE must be canceled.) Do not make a blocking call to either of these functions from within the callback function.Note that you should not pulse an event object passed to RegisterWaitForSingleObject, because the wait thread might not detect that the event is signaled before it is reset. You should not register an object that remains signaled (such as a manual reset event or terminated process) unless you set the WT_EXECUTEONLYONCE or WT_EXECUTEINWAITTHREAD flag. For other flags, the callback function might be called too many times before the event is reset.The function modifies the state of some types of synchronization objects. Modification occurs only for the object whose signaled state caused the wait condition to be satisfied. For example, the count of a semaphore object is decreased by one.The RegisterWaitForSingleObject function can wait for the following objects:By default, the thread pool has a maximum of 500 threads. To raise this limit, use the WT_SET_MAX_THREADPOOL_THREAD macro defined in WinNT.h.Use this macro when specifying the dwFlags parameter. The macro parameters are the desired flags and the new limit (up to (2<<16)-1 threads). However, note that your application can improve its performance by keeping the number of worker threads low.The work item and all functions it calls must be thread-pool safe. Therefore, you cannot call an asynchronous call that requires a persistent thread, such as the RegNotifyChangeKeyValue function, from the default callback environment. Instead, set the thread pool maximum equal to the thread pool minimum using the SetThreadpoolThreadMaximum and SetThreadpoolThreadMinimum functions, or create your own thread using the CreateThread function. (For the original thread pool API, specify WT_EXECUTEINPERSISTENTTHREAD using the QueueUserWorkItem function.)To compile an application that uses this function, define _WIN32_WINNT as 0x0500 or later. For more information, see Using the Windows Headers.Synchronization FunctionsThread PoolingUnregisterWaitUnregisterWaitExWait FunctionsWaitOrTimerCallback</param>
        /// <remarks>
        /// To get extended error information, call
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool RegisterWaitForSingleObject(out IntPtr phNewWaitObject, IntPtr hObject, int Callback, int dwMilliseconds, int dwFlags);

        /// <summary>
        ///The ReleaseActCtx function decrements the reference count of the specified activation context.
        /// </summary>
        /// <param name="hActCtx">Handle to the ACTCTX structure that contains information on the activation context for which the reference count is to be decremented.This function does not return a value. On successful completion, the activation context reference count is decremented. The recipient of the reference-counted object must decrement the reference count when the object is no longer required.When the reference count of an activation context becomes zero, the activation context structure is deallocated. Activation contexts have not been implemented as kernel objects, therefore, kernel handler functions cannot be used for activation contexts.If the value of the hActCtx parameter is a null handle, this function does nothing and no error condition occurs.ACTCTXAddRefActCtx</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void ReleaseActCtx(IntPtr hActCtx);

        /// <summary>
        ///[Microsoft strongly recommends developers utilize alternative means to achieve your application’s needs. Many scenarios that TxF was developed for can be achieved through simpler and more readily available techniques. Furthermore, TxF may not be available in future versions of Microsoft Windows. For more information, and alternatives to TxF, please see Alternatives to using Transactional NTFS.]
        /// </summary>
        /// <param name="lpPathName">The path of the directory to be removed. The path must specify an empty directory, and the calling process must have delete access to the directory.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.The directory must reside on the local computer; otherwise, the function fails and the last error code is set to ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE.</param>
        /// <param name="hTransaction">A handle to the transaction. This handle is returned by the CreateTransaction function.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The RemoveDirectoryTransacted function marks a directory for deletion on close. Therefore, the directory is not removed until the last handle to the directory is closed.RemoveDirectory removes a directory junction, even if the contents of the target are not empty; the function removes directory junctions regardless of the state of the target object.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB 3.0 does not support TxF .CreateDirectoryTransactedCreating and Deleting DirectoriesDirectory Management FunctionsTransactional NTFS</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool RemoveDirectoryTransactedA(string lpPathName, IntPtr hTransaction);

        /// <summary>
        ///[Microsoft strongly recommends developers utilize alternative means to achieve your application’s needs. Many scenarios that TxF was developed for can be achieved through simpler and more readily available techniques. Furthermore, TxF may not be available in future versions of Microsoft Windows. For more information, and alternatives to TxF, please see Alternatives to using Transactional NTFS.]
        /// </summary>
        /// <param name="lpPathName">The path of the directory to be removed. The path must specify an empty directory, and the calling process must have delete access to the directory.The directory must reside on the local computer; otherwise, the function fails and the last error code is set to ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="hTransaction">A handle to the transaction. This handle is returned by the CreateTransaction function.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The RemoveDirectoryTransacted function marks a directory for deletion on close. Therefore, the directory is not removed until the last handle to the directory is closed.RemoveDirectory removes a directory junction, even if the contents of the target are not empty; the function removes directory junctions regardless of the state of the target object.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB 3.0 does not support TxF .CreateDirectoryTransactedCreating and Deleting DirectoriesDirectory Management FunctionsTransactional NTFS</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool RemoveDirectoryTransactedW(string lpPathName, IntPtr hTransaction);

        /// <summary>
        ///Unregisters a callback function that was previously registered with the AddSecureMemoryCacheCallback function.
        /// </summary>
        /// <param name="pfnCallBack">A pointer to the application-defined SecureMemoryCacheCallback function to remove.If the function succeeds, it returns TRUE.If the function fails, it returns FALSE.To compile an application that uses this function, define _WIN32_WINNT as 0x0600 or later. For more information, see Using the Windows Headers.AddSecureMemoryCacheCallbackSecureMemoryCacheCallback</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool RemoveSecureMemoryCacheCallback(IntPtr pfnCallBack);

        /// <summary>
        ///Reopens the specified file system object with different access rights, sharing mode, and flags.
        /// </summary>
        /// <param name="hOriginalFile">A handle to the object to be reopened. The object must have been created by the CreateFile function.</param>
        /// <param name="dwDesiredAccess">The required access to the object. For a list of values, see File Security and Access Rights. You cannot request an access mode that conflicts with the sharing mode specified in a previous open request whose handle is still open.If this parameter is zero (0), the application can query device attributes without accessing the device. This is useful if an application wants to determine the size of a floppy disk drive and the formats it supports without requiring a floppy in the drive.</param>
        /// <param name="dwShareMode">The sharing mode of the object. You cannot request a sharing mode that conflicts with the access mode specified in a previous open request whose handle is still open.If this parameter is zero (0) and CreateFile succeeds, the object cannot be shared and cannot be opened again until the handle is closed.To enable other processes to share the object while your process has it open, use a combination of one or more of the following values to specify the type of access they can request when they open the object. These sharing options remain in effect until you close the handle to the object.</param>
        /// <param name="dwFlagsAndAttributes">The file flags. This parameter can be one or more of the following values.If the handle represents the client side of a named pipe, the dwFlags parameter can also contain Security Quality of Service information. For more information, see Impersonation Levels. When the calling application specifies the SECURITY_SQOS_PRESENT flag, the dwFlags parameter can contain one or more of the following values.If the function succeeds, the return value is an open handle to the specified file.If the function fails, the return value is INVALID_HANDLE_VALUE. To get extended error information, call GetLastError.The dwFlags parameter cannot contain any of the file attribute flags (FILE_ATTRIBUTE_*). These can only be specified when the file is created.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.CreateFileFile Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr ReOpenFile(IntPtr hOriginalFile, uint dwDesiredAccess, uint dwShareMode, uint dwFlagsAndAttributes);

        /// <summary>
        ///Replaces one file with another file, with the option of creating a backup copy of the original file. The replacement file assumes the name of the replaced file and its identity.
        /// </summary>
        /// <param name="lpReplacedFileName">The name of the file to be replaced.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.This file is opened with the GENERIC_READ, DELETE, and SYNCHRONIZE access rights. The sharing mode is FILE_SHARE_READ | FILE_SHARE_WRITE | FILE_SHARE_DELETE.The caller must have write access to the file to be replaced. For more information, see File Security and Access Rights.</param>
        /// <param name="lpReplacementFileName">The name of the file that will replace the lpReplacedFileName file.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.The function attempts to open this file with the SYNCHRONIZE, GENERIC_READ, GENERIC_WRITE, DELETE, and WRITE_DAC access rights so that it can preserve all attributes and ACLs. If this fails, the function attempts to open the file with the SYNCHRONIZE, GENERIC_READ, DELETE, and WRITE_DAC access rights. No sharing mode is specified.</param>
        /// <param name="dwReplaceFlags">The replacement options. This parameter can be one or more of the following values.lpExcludeReserved for future use.lpReservedReserved for future use.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError. The following are possible error codes for this function.If any other error is returned, such as ERROR_INVALID_PARAMETER, the replaced and replacement files will retain their original file names. In this scenario, a backup file does not exist and it is not guaranteed that the replacement file will have inherited all of the attributes and streams of the replaced file.Windows 7, Windows Server 2008 R2, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:  Security resource attributes (ATTRIBUTE_SECURITY_INFORMATION) for the original file are not preserved until Windows 8 and Windows Server 2012.The backup file, replaced file, and replacement file must all reside on the same volume.To delete or rename a file, you must have either delete permission on the file or delete child permission in the parent directory. If you set up a directory with all access except delete and delete child and the DACLs of new files are inherited, then you should be able to create a file without being able to delete it. However, you can then create a file, and you will get all the access you request on the handle returned to you at the time you create the file. If you requested delete permission at the time you created the file, you could delete or rename the file with that handle but not with any other.CopyFileCopyFileExFile Management FunctionsMoveFileMoveFileExMoveFileWithProgress</param>
        /// <remarks>
        /// To get extended error information, call GetLastError. The following are possible error codes for this function.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ReplaceFileA(string lpReplacedFileName, string lpReplacementFileName, uint dwReplaceFlags);

        /// <summary>
        ///Replaces one file with another file, with the option of creating a backup copy of the original file. The replacement file assumes the name of the replaced file and its identity.
        /// </summary>
        /// <param name="lpReplacedFileName">The name of the file to be replaced.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.This file is opened with the GENERIC_READ, DELETE, and SYNCHRONIZE access rights. The sharing mode is FILE_SHARE_READ | FILE_SHARE_WRITE | FILE_SHARE_DELETE.The caller must have write access to the file to be replaced. For more information, see File Security and Access Rights.</param>
        /// <param name="lpReplacementFileName">The name of the file that will replace the lpReplacedFileName file.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.The function attempts to open this file with the SYNCHRONIZE, GENERIC_READ, GENERIC_WRITE, DELETE, and WRITE_DAC access rights so that it can preserve all attributes and ACLs. If this fails, the function attempts to open the file with the SYNCHRONIZE, GENERIC_READ, DELETE, and WRITE_DAC access rights. No sharing mode is specified.</param>
        /// <param name="dwReplaceFlags">The replacement options. This parameter can be one or more of the following values.lpExcludeReserved for future use.lpReservedReserved for future use.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError. The following are possible error codes for this function.If any other error is returned, such as ERROR_INVALID_PARAMETER, the replaced and replacement files will retain their original file names. In this scenario, a backup file does not exist and it is not guaranteed that the replacement file will have inherited all of the attributes and streams of the replaced file.Windows 7, Windows Server 2008 R2, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:  Security resource attributes (ATTRIBUTE_SECURITY_INFORMATION) for the original file are not preserved until Windows 8 and Windows Server 2012.The backup file, replaced file, and replacement file must all reside on the same volume.To delete or rename a file, you must have either delete permission on the file or delete child permission in the parent directory. If you set up a directory with all access except delete and delete child and the DACLs of new files are inherited, then you should be able to create a file without being able to delete it. However, you can then create a file, and you will get all the access you request on the handle returned to you at the time you create the file. If you requested delete permission at the time you created the file, you could delete or rename the file with that handle but not with any other.CopyFileCopyFileExFile Management FunctionsMoveFileMoveFileExMoveFileWithProgress</param>
        /// <remarks>
        /// To get extended error information, call GetLastError. The following are possible error codes for this function.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ReplaceFileW(string lpReplacedFileName, string lpReplacementFileName, uint dwReplaceFlags);

        /// <summary>
        ///Writes an entry at the end of the specified event log.
        /// </summary>
        /// <param name="hEventLog">A handle to the event log. The RegisterEventSource function returns this handle.As of Windows XP with SP2, this parameter cannot be a handle to the Security log. To write an event to the Security log, use the AuthzReportSecurityEvent function.</param>
        /// <param name="wType">The type of event to be logged. This parameter can be one of the following values.For more information about event types, see Event Types.</param>
        /// <param name="wCategory">The event category. This is source-specific information; the category can have any value. For more information, see Event Categories.</param>
        /// <param name="dwEventID">The event identifier. The event identifier specifies the entry in the message file associated with the event source. For more information, see Event Identifiers.</param>
        /// <param name="lpUserSid">A pointer to the current user's security identifier. This parameter can be NULL if the security identifier is not required.</param>
        /// <param name="wNumStrings">The number of insert strings in the array pointed to by the lpStrings parameter. A value of zero indicates that no strings are present.</param>
        /// <param name="dwDataSize">The number of bytes of event-specific raw (binary) data to write to the log. If this parameter is zero, no event-specific data is present.</param>
        /// <param name="lpStrings">A pointer to a buffer containing an array of null-terminated strings that are merged into the message before Event Viewer displays the string to the user. This parameter must be a valid pointer (or NULL), even if wNumStrings is zero. Each string is limited to 31,839 characters.Prior to Windows Vista:  Each string is limited to 32K characters.</param>
        /// <param name="lpRawData">A pointer to the buffer containing the binary data. This parameter must be a valid pointer (or NULL), even if the dwDataSize parameter is zero.If the function succeeds, the return value is nonzero, indicating that the entry was written to the log.If the function fails, the return value is zero. To get extended error information, call GetLastError, which returns one of the following extended error codes.This function is used to log an event. The entry is written to the end of the configured log for the source identified by the hEventLog parameter. The ReportEvent function adds the time, the entry's length, and the offsets before storing the entry in the log. To enable the function to add the user name, you must supply the user's SID in the lpUserSid parameter.There are different size limits on the size of the message data that can be logged depending on the version of Windows used by both the client where the application is run and the server where the message is logged. The server is determined by the lpUNCServerName parameter passed to the RegisterEventSource function. Different errors are returned when the size limit is exceeded that depend on the version of Windows.If the string that you log contains %n, where n is an integer value (for example, %1), the event viewer treats it as an insertion string. Because an IPv6 address can contain this character sequence, you must provide a format specifier (!S!) to log an event message that contains an IPv6 address. This specifier tells the formatting code to use the string literally and not perform any further expansions (for example, "my IPv6 address is: %1!S!").For an example, see Reporting an Event.ClearEventLogCloseEventLogEvent Log File FormatEvent Logging FunctionsOpenEventLogReadEventLogRegisterEventSource</param>
        /// <remarks>
        /// To get extended error information, call GetLastError, which returns one of the following extended error codes.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ReportEventA(IntPtr hEventLog, uint wType, uint wCategory, uint dwEventID, int lpUserSid, uint wNumStrings, uint dwDataSize, string lpStrings, IntPtr lpRawData);

        /// <summary>
        ///Writes an entry at the end of the specified event log.
        /// </summary>
        /// <param name="hEventLog">A handle to the event log. The RegisterEventSource function returns this handle.As of Windows XP with SP2, this parameter cannot be a handle to the Security log. To write an event to the Security log, use the AuthzReportSecurityEvent function.</param>
        /// <param name="wType">The type of event to be logged. This parameter can be one of the following values.For more information about event types, see Event Types.</param>
        /// <param name="wCategory">The event category. This is source-specific information; the category can have any value. For more information, see Event Categories.</param>
        /// <param name="dwEventID">The event identifier. The event identifier specifies the entry in the message file associated with the event source. For more information, see Event Identifiers.</param>
        /// <param name="lpUserSid">A pointer to the current user's security identifier. This parameter can be NULL if the security identifier is not required.</param>
        /// <param name="wNumStrings">The number of insert strings in the array pointed to by the lpStrings parameter. A value of zero indicates that no strings are present.</param>
        /// <param name="dwDataSize">The number of bytes of event-specific raw (binary) data to write to the log. If this parameter is zero, no event-specific data is present.</param>
        /// <param name="lpStrings">A pointer to a buffer containing an array of null-terminated strings that are merged into the message before Event Viewer displays the string to the user. This parameter must be a valid pointer (or NULL), even if wNumStrings is zero. Each string is limited to 31,839 characters.Prior to Windows Vista:  Each string is limited to 32K characters.</param>
        /// <param name="lpRawData">A pointer to the buffer containing the binary data. This parameter must be a valid pointer (or NULL), even if the dwDataSize parameter is zero.If the function succeeds, the return value is nonzero, indicating that the entry was written to the log.If the function fails, the return value is zero. To get extended error information, call GetLastError, which returns one of the following extended error codes.This function is used to log an event. The entry is written to the end of the configured log for the source identified by the hEventLog parameter. The ReportEvent function adds the time, the entry's length, and the offsets before storing the entry in the log. To enable the function to add the user name, you must supply the user's SID in the lpUserSid parameter.There are different size limits on the size of the message data that can be logged depending on the version of Windows used by both the client where the application is run and the server where the message is logged. The server is determined by the lpUNCServerName parameter passed to the RegisterEventSource function. Different errors are returned when the size limit is exceeded that depend on the version of Windows.If the string that you log contains %n, where n is an integer value (for example, %1), the event viewer treats it as an insertion string. Because an IPv6 address can contain this character sequence, you must provide a format specifier (!S!) to log an event message that contains an IPv6 address. This specifier tells the formatting code to use the string literally and not perform any further expansions (for example, "my IPv6 address is: %1!S!").For an example, see Reporting an Event.ClearEventLogCloseEventLogEvent Log File FormatEvent Logging FunctionsOpenEventLogReadEventLogRegisterEventSource</param>
        /// <remarks>
        /// To get extended error information, call GetLastError, which returns one of the following extended error codes.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ReportEventW(IntPtr hEventLog, uint wType, uint wCategory, uint dwEventID, int lpUserSid, uint wNumStrings, uint dwDataSize, string lpStrings, IntPtr lpRawData);

        /// <summary>
        ///[RequestWakeupLatency is available for use in the operating systems specified in the Requirements section. It may be altered or unavailable in subsequent versions.]
        /// </summary>
        /// <param name="latency">The latency requirement for the time is takes to wake the computer. This parameter can be one of the following values.The return value is nonzero.The system uses the wake-up latency requirement when choosing a sleeping state. The latency is not guaranteed because wake-up time is determined by the hardware design of the particular computer.To cancel a latency request, call RequestWakeupLatency with LT_DONT_CARE.Power Management Functions</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool RequestWakeupLatency(int latency);

        /// <summary>
        ///Suspends character transmission for a specified communications device and places the transmission line in a break state until the ClearCommBreak function is called.
        /// </summary>
        /// <param name="hFile">A handle to the communications device. The CreateFile function returns this handle.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.ClearCommBreakCommunications FunctionsCommunications ResourcesCreateFile</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetCommBreak(IntPtr hFile);

        /// <summary>
        ///Sets the current configuration of a communications device.
        /// </summary>
        /// <param name="hCommDev">A handle to the open communications device. The CreateFile function returns this handle.</param>
        /// <param name="lpCC">A pointer to a COMMCONFIG structure.</param>
        /// <param name="dwSize">The size of the structure pointed to by lpCC, in bytes.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.COMMCONFIGCommunications FunctionsCommunications ResourcesCreateFileGetCommConfig</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetCommConfig(IntPtr hCommDev, int lpCC, uint dwSize);

        /// <summary>
        ///Specifies a set of events to be monitored for a communications device.
        /// </summary>
        /// <param name="hFile">A handle to the communications device. The CreateFile function returns this handle.</param>
        /// <param name="dwEvtMask">The events to be enabled. A value of zero disables all events. This parameter can be one or more of the following values.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The SetCommMask function specifies the set of events that can be monitored for a particular communications resource. A handle to the communications resource can be specified in a call to the WaitCommEvent function, which waits for one of the events to occur. To get the current event mask of a communications resource, use the GetCommMask function.For an example, see Monitoring Communications Events.Communications FunctionsCommunications ResourcesCreateFileDCBGetCommMaskSetCommStateWaitCommEvent</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetCommMask(IntPtr hFile, uint dwEvtMask);

        /// <summary>
        ///Configures a communications device according to the specifications in a device-control block (a DCB structure). The function reinitializes all hardware and control settings, but it does not empty output or input queues.
        /// </summary>
        /// <param name="hFile">A handle to the communications device. The CreateFile function returns this handle.</param>
        /// <param name="lpDCB">A pointer to a DCB structure that contains the configuration information for the specified communications device.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The SetCommState function uses a DCB structure to specify the desired configuration. The GetCommState function returns the current configuration.To set only a few members of the DCB structure, you should modify a DCB structure that has been filled in by a call to GetCommState. This ensures that the other members of the DCB structure have appropriate values.The SetCommState function fails if the XonChar member of the DCB structure is equal to the XoffChar member.When SetCommState is used to configure the 8250, the following restrictions apply to the values for the DCB structure's ByteSize and StopBits members:The number of data bits must be 5 to 8 bits.For an example, see Configuring a Communications Resource.BuildCommDCBCommunications FunctionsCommunications ResourcesCreateFileDCBGetCommState</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetCommState(IntPtr hFile, int lpDCB);

        /// <summary>
        ///Sets the time-out parameters for all read and write operations on a specified communications device.
        /// </summary>
        /// <param name="hFile">A handle to the communications device. The CreateFile function returns this handle.</param>
        /// <param name="lpCommTimeouts">A pointer to a COMMTIMEOUTS structure that contains the new time-out values.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.COMMTIMEOUTSCommunications FunctionsCommunications ResourcesGetCommTimeoutsReadFileReadFileExWriteFileWriteFileEx</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetCommTimeouts(IntPtr hFile, int lpCommTimeouts);

        /// <summary>
        ///Changes the current directory for the current process.
        /// </summary>
        /// <param name="lpPathName">The path to the new current directory. This parameter may specify a relative path or a full path. In either case, the full path of the specified directory is calculated and stored as the current directory.For more info, see Naming files, paths, and namespaces.By default, the name is limited to MAX_PATH characters.The final character before the null character must be a backslash ('\'). If you don't specify the backslash, then it will be added for you. Therefore, specify >MAX_PATH-2 characters for the path unless you include the trailing backslash; in which case, specify MAX_PATH-1 characters for the path.If the function succeeds, then the return value is non-zero.If the function fails, then the return value is zero. To get extended error information, call GetLastError.Each process has a single current directory made up of two parts:The current directory is shared by all threads of the process: If one thread changes the current directory, it affects all threads in the process.Multithreaded applications and shared library code should avoid calling the SetCurrentDirectory function due to the risk of affecting relative path calculations being performed by other threads. Conversely,multithreaded applications and shared library code should avoid using relative paths so that they are unaffected by changes to the current directory performed by other threads.The current directory for a process is locked while the process is executing. That prevents the directory from being deleted, moved, or renamed.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.For an example, see Changing the current directory.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetCurrentDirectory(string lpPathName);

        /// <summary>
        ///Sets the default configuration for a communications device.
        /// </summary>
        /// <param name="lpszName">The name of the device. For example, COM1 through COM9 are serial ports and LPT1 through LPT9 are parallel ports.</param>
        /// <param name="lpCC">A pointer to a COMMCONFIG structure.</param>
        /// <param name="dwSize">The size of the structure pointed to by lpCC, in bytes.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.COMMCONFIGCommunications FunctionsCommunications ResourcesGetDefaultCommConfig</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetDefaultCommConfigA(string lpszName, int lpCC, uint dwSize);

        /// <summary>
        ///Sets the default configuration for a communications device.
        /// </summary>
        /// <param name="lpszName">The name of the device. For example, COM1 through COM9 are serial ports and LPT1 through LPT9 are parallel ports.</param>
        /// <param name="lpCC">A pointer to a COMMCONFIG structure.</param>
        /// <param name="dwSize">The size of the structure pointed to by lpCC, in bytes.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.COMMCONFIGCommunications FunctionsCommunications ResourcesGetDefaultCommConfig</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetDefaultCommConfigW(string lpszName, int lpCC, uint dwSize);

        /// <summary>
        ///Adds a directory to the search path used to locate DLLs for the application.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetDllDirectoryA();

        /// <summary>
        ///Adds a directory to the search path used to locate DLLs for the application.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetDllDirectoryW();

        /// <summary>
        ///Sets the contents of the specified environment variable for the current process.
        /// </summary>
        /// <param name="lpName">The name of the environment variable. The operating system creates the environment variable if it does not exist and lpValue is not NULL.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetEnvironmentVariable(string lpName);

        /// <summary>
        ///[Microsoft strongly recommends developers utilize alternative means to achieve your application’s needs. Many scenarios that TxF was developed for can be achieved through simpler and more readily available techniques. Furthermore, TxF may not be available in future versions of Microsoft Windows. For more information, and alternatives to TxF, please see Alternatives to using Transactional NTFS.]
        /// </summary>
        /// <param name="lpFileName">The name of the file whose attributes are to be set.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.The file must reside on the local computer; otherwise, the function fails and the last error code is set to ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE.</param>
        /// <param name="dwFileAttributes">The file attributes to set for the file.For a list of file attribute value and their descriptions, see File Attribute Constants. This parameter can be one or more values, combined using the bitwise-OR operator. However, all other values override FILE_ATTRIBUTE_NORMAL.Not all attributes are supported by this function. For more information, see the Remarks section.The following is a list of supported attribute values.</param>
        /// <param name="hTransaction">A handle to the transaction. This handle is returned by the CreateTransaction function.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The following table describes how to set the attributes that cannot be set using SetFileAttributesTransacted. Note that these are not transacted operations.If a file is open for modification in a transaction, no other thread can successfully open the file for modification until the transaction is committed. If a transacted thread opens the file first, any subsequent threads that attempt to open the file for modification before the transaction is committed will receive a sharing violation. If a non-transacted thread opens the file for modification before the transacted thread does, and it is still open when the transacted thread attempts to open it, the transaction will receive the ERROR_TRANSACTIONAL_CONFLICT error.For more information on transactions, see Transactional NTFS.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB 3.0 does not support TxF.File Attribute ConstantsFile Management FunctionsGetFileAttributesTransactedSymbolic LinksTransactional NTFS</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetFileAttributesTransactedA(string lpFileName, uint dwFileAttributes, IntPtr hTransaction);

        /// <summary>
        ///[Microsoft strongly recommends developers utilize alternative means to achieve your application’s needs. Many scenarios that TxF was developed for can be achieved through simpler and more readily available techniques. Furthermore, TxF may not be available in future versions of Microsoft Windows. For more information, and alternatives to TxF, please see Alternatives to using Transactional NTFS.]
        /// </summary>
        /// <param name="lpFileName">The name of the file whose attributes are to be set.The file must reside on the local computer; otherwise, the function fails and the last error code is set to ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE.By default, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.</param>
        /// <param name="dwFileAttributes">The file attributes to set for the file.For a list of file attribute value and their descriptions, see File Attribute Constants. This parameter can be one or more values, combined using the bitwise-OR operator. However, all other values override FILE_ATTRIBUTE_NORMAL.Not all attributes are supported by this function. For more information, see the Remarks section.The following is a list of supported attribute values.</param>
        /// <param name="hTransaction">A handle to the transaction. This handle is returned by the CreateTransaction function.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The following table describes how to set the attributes that cannot be set using SetFileAttributesTransacted. Note that these are not transacted operations.If a file is open for modification in a transaction, no other thread can successfully open the file for modification until the transaction is committed. If a transacted thread opens the file first, any subsequent threads that attempt to open the file for modification before the transaction is committed will receive a sharing violation. If a non-transacted thread opens the file for modification before the transacted thread does, and it is still open when the transacted thread attempts to open it, the transaction will receive the ERROR_TRANSACTIONAL_CONFLICT error.For more information on transactions, see Transactional NTFS.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB 3.0 does not support TxF.File Attribute ConstantsFile Management FunctionsGetFileAttributesTransactedSymbolic LinksTransactional NTFS</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetFileAttributesTransactedW(string lpFileName, uint dwFileAttributes, IntPtr hTransaction);

        /// <summary>
        ///Requests that bandwidth for the specified file stream be reserved. The reservation is specified as a number of bytes in a period of milliseconds for I/O requests on the specified file handle.
        /// </summary>
        /// <param name="hFile">A handle to the file.</param>
        /// <param name="nPeriodMilliseconds">The period of the reservation, in milliseconds. The period is the time from which the I/O is issued to the kernel until the time the I/O should be completed. The minimum supported value for the file stream can be determined by looking at the value returned through the lpPeriodMilliseconds parameter to the GetFileBandwidthReservation function, on a handle that has not had a bandwidth reservation set.</param>
        /// <param name="nBytesPerPeriod">The bandwidth to reserve, in bytes per period. The maximum supported value for the file stream can be determined by looking at the value returned through the lpBytesPerPeriod parameter to the GetFileBandwidthReservation function, on a handle that has not had a bandwidth reservation set.</param>
        /// <param name="bDiscardable">Indicates whether I/O should be completed with an error if a driver is unable to satisfy an I/O operation before the period expires. If one of the drivers for the specified file stream does not support this functionality, this function may return success and ignore the flag. To verify whether the setting will be honored, call the GetFileBandwidthReservation function using the same hFile handle and examine the *pDiscardable return value.</param>
        /// <param name="lpTransferSize"></param>
        /// <param name="lpNumOutstandingRequests"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetFileBandwidthReservation(IntPtr hFile, uint nPeriodMilliseconds, uint nBytesPerPeriod, bool bDiscardable, out uint lpTransferSize, out uint lpNumOutstandingRequests);

        /// <summary>
        ///Sets the notification modes for a file handle, allowing you to specify how completion notifications work for the specified file.
        /// </summary>
        /// <param name="FileHandle">A handle to the file.</param>
        /// <param name="Flags">The modes to be set. One or more modes can be set at the same time; however, after a mode has been set for a file handle, it cannot be removed.</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetFileCompletionNotificationModes(IntPtr FileHandle, char Flags);

        /// <summary>
        ///The SetFileSecurity function sets the security of a file or directory object.
        /// </summary>
        /// <param name="lpFileName">A pointer to a null-terminated string that specifies the file or directory for which security is set. Note that security applied to a directory is not inherited by its children.</param>
        /// <param name="SecurityInformation">Specifies a SECURITY_INFORMATION structure that identifies the contents of the security descriptor pointed to by the pSecurityDescriptor parameter.</param>
        /// <param name="pSecurityDescriptor">A pointer to a SECURITY_DESCRIPTOR structure.If the function succeeds, the function returns nonzero.If the function fails, it returns zero. To get extended error information, call GetLastError.The SetFileSecurity function is successful only if the following conditions are met:GetFileSecurityLow-level Access ControlLow-level Access Control FunctionsSECURITY_DESCRIPTORSECURITY_INFORMATIONSetKernelObjectSecuritySetNamedSecurityInfoSetPrivateObjectSecuritySetUserObjectSecurity</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetFileSecurityA(string lpFileName, int SecurityInformation, int pSecurityDescriptor);

        /// <summary>
        ///Sets the short name for the specified file. The file must be on an NTFS file system volume.
        /// </summary>
        /// <param name="hFile">A handle to the file. The file must be opened with either the GENERIC_ALL access right or GENERIC_WRITE|DELETE, and with the FILE_FLAG_BACKUP_SEMANTICS file attribute.</param>
        /// <param name="lpShortName">A pointer to a string that specifies the short name for the file.Specifying an empty (zero-length) string will remove the short file name, if it exists for the file specified by the hFile parameter. If a short file name does not exist, the function will do nothing and return success.Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:  This behavior is not supported. The parameter must contain a valid string of one or more characters.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError. GetLastError may return one of the following error codes that are specific to this function.The caller of this function must have the SE_RESTORE_NAME privilege. For more information, see Running with Special Privileges.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB 3.0 does not support short names on shares with continuous availability capability . Short names are not recommended on CsvFs.File Management FunctionsGetShortPathName</param>
        /// <remarks>
        /// To get extended error information, call GetLastError. GetLastError may return one of the following error codes that are specific to this function.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetFileShortNameA(IntPtr hFile, string lpShortName);

        /// <summary>
        ///Sets the short name for the specified file. The file must be on an NTFS file system volume.
        /// </summary>
        /// <param name="hFile">A handle to the file. The file must be opened with either the GENERIC_ALL access right or GENERIC_WRITE|DELETE, and with the FILE_FLAG_BACKUP_SEMANTICS file attribute.</param>
        /// <param name="lpShortName">A pointer to a string that specifies the short name for the file.Specifying an empty (zero-length) string will remove the short file name, if it exists for the file specified by the hFile parameter. If a short file name does not exist, the function will do nothing and return success.Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:  This behavior is not supported. The parameter must contain a valid string of one or more characters.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError. GetLastError may return one of the following error codes that are specific to this function.The caller of this function must have the SE_RESTORE_NAME privilege. For more information, see Running with Special Privileges.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB 3.0 does not support short names on shares with continuous availability capability . Short names are not recommended on CsvFs.File Management FunctionsGetShortPathName</param>
        /// <remarks>
        /// To get extended error information, call GetLastError. GetLastError may return one of the following error codes that are specific to this function.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetFileShortNameW(IntPtr hFile, string lpShortName);

        /// <summary>
        ///Sets the value of the specified firmware environment variable.
        /// </summary>
        /// <param name="lpName">The name of the firmware environment variable. The pointer must not be NULL.</param>
        /// <param name="lpGuid">The GUID that represents the namespace of the firmware environment variable. The GUID must be a string in the format "{xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}". If the system does not support GUID-based namespaces, this parameter is ignored.</param>
        /// <param name="pValue">A pointer to the new value for the firmware environment variable.</param>
        /// <param name="nSize">The size of the pBuffer buffer, in bytes. If this parameter is zero, the firmware environment variable is deleted.If the function succeeds, the return value is a nonzero value.If the function fails, the return value is zero. To get extended error information, call GetLastError. Possible error codes include ERROR_INVALID_FUNCTION.Starting with Windows 10, version 1803, Universal Windows apps can read and write UEFI firmware variables. See Access UEFI firmware variables from a Universal Windows App for details.Starting with Windows 10, version 1803, reading UEFI firmware variables is also supported from User-Mode Driver Framework (UMDF) drivers. Writing UEFI firmware variables from UMDF drivers is not supported.To write a firmware environment variable, the user account that the app is running under must have the SE_SYSTEM_ENVIRONMENT_NAME privilege. A Universal Windows app must be run from an administrator account and follow the requirements outlined in Access UEFI firmware variables from a Universal Windows App.The exact set of firmware environment variables is determined by the boot firmware. The location of these environment variables is also specified by the firmware. For example, on a UEFI-based system, NVRAM contains firmware environment variables that specify system boot settings. For information about specific variables used, see the UEFI specification. For more information about UEFI and Windows, see UEFI and Windows.Firmware variables are not supported on a legacy BIOS-based system. The SetFirmwareEnvironmentVariable function will always fail on a legacy BIOS-based system, or if Windows was installed using legacy BIOS on a system that supports both legacy BIOS and UEFI. To identify these conditions, call the function with a dummy firmware environment name such as an empty string ("") for the lpName parameter and a dummy GUID such as "{00000000-0000-0000-0000-000000000000}" for the lpGuid parameter. On a legacy BIOS-based system, or on a system that supports both legacy BIOS and UEFI where Windows was installed using legacy BIOS, the function will fail with ERROR_INVALID_FUNCTION. On a UEFI-based system, the function will fail with an error specific to the firmware, such as ERROR_NOACCESS, to indicate that the dummy GUID namespace does not exist.SetFirmwareEnvironmentVariable is the user-mode equivalent of the ExSetFirmwareEnvironmentVariable kernel-mode routine.Access UEFI firmware variables from a Universal Windows AppGetFirmwareEnvironmentVariableSetFirmwareEnvironmentVariableExSystem Information Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError. Possible error codes include ERROR_INVALID_FUNCTION.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetFirmwareEnvironmentVariableA(string lpName, string lpGuid, IntPtr pValue, uint nSize);

        /// <summary>
        ///Sets the value of the specified firmware environment variable as the attributes that indicate how this variable is stored and maintained.
        /// </summary>
        /// <param name="lpName">The name of the firmware environment variable. The pointer must not be NULL.</param>
        /// <param name="lpGuid">The GUID that represents the namespace of the firmware environment variable. The GUID must be a string in the format "{xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}". If the system does not support GUID-based namespaces, this parameter is ignored. The pointer must not be NULL.</param>
        /// <param name="pValue">A pointer to the new value for the firmware environment variable.</param>
        /// <param name="nSize">The size of the pValue buffer, in bytes. Unless the VARIABLE_ATTRIBUTE_APPEND_WRITE, VARIABLE_ATTRIBUTE_AUTHENTICATED_WRITE_ACCESS, or VARIABLE_ATTRIBUTE_TIME_BASED_AUTHENTICATED_WRITE_ACCESS variable attribute is set via dwAttributes, setting this value to zero will result in the deletion of this variable.</param>
        /// <param name="dwAttributes">Bitmask to set UEFI variable attributes associated with the variable. See also UEFI Spec 2.3.1, Section 7.2.If the function succeeds, the return value is a nonzero value.If the function fails, the return value is zero. To get extended error information, call GetLastError. Possible error codes include ERROR_INVALID_FUNCTION.Starting with Windows 10, version 1803, Universal Windows apps can read and write UEFI firmware variables. See Access UEFI firmware variables from a Universal Windows App for details.Starting with Windows 10, version 1803, reading UEFI firmware variables is also supported from User-Mode Driver Framework (UMDF) drivers. Writing UEFI firmware variables from UMDF drivers is not supported.To write a firmware environment variable, the user account that the app is running under must have the SE_SYSTEM_ENVIRONMENT_NAME privilege. A Universal Windows app must be run from an administrator account and follow the requirements outlined in Access UEFI firmware variables from a Universal Windows App.The correct method of changing the attributes of a variable is to delete the variable and recreate it with different attributes.The exact set of firmware environment variables is determined by the boot firmware. The location of these environment variables is also specified by the firmware. For example, on a UEFI-based system, NVRAM contains firmware environment variables that specify system boot settings. For information about specific variables used, see the UEFI specification. For more information about UEFI and Windows, see UEFI and Windows.Firmware variables are not supported on a legacy BIOS-based system. The SetFirmwareEnvironmentVariableEx function will always fail on a legacy BIOS-based system, or if Windows was installed using legacy BIOS on a system that supports both legacy BIOS and UEFI. To identify these conditions, call the function with a dummy firmware environment name such as an empty string ("") for the lpName parameter and a dummy GUID such as "{00000000-0000-0000-0000-000000000000}" for the lpGuid parameter. On a legacy BIOS-based system, or on a system that supports both legacy BIOS and UEFI where Windows was installed using legacy BIOS, the function will fail with ERROR_INVALID_FUNCTION. On a UEFI-based system, the function will fail with an error specific to the firmware, such as ERROR_NOACCESS, to indicate that the dummy GUID namespace does not exist.Access UEFI firmware variables from a Universal Windows AppGetFirmwareEnvironmentVariableExSetFirmwareEnvironmentVariable</param>
        /// <remarks>
        /// To get extended error information, call GetLastError. Possible error codes include ERROR_INVALID_FUNCTION.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetFirmwareEnvironmentVariableExA(string lpName, string lpGuid, IntPtr pValue, uint nSize, uint dwAttributes);

        /// <summary>
        ///Sets the value of the specified firmware environment variable and the attributes that indicate how this variable is stored and maintained.
        /// </summary>
        /// <param name="lpName">The name of the firmware environment variable. The pointer must not be NULL.</param>
        /// <param name="lpGuid">The GUID that represents the namespace of the firmware environment variable. The GUID must be a string in the format "{xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}". If the system does not support GUID-based namespaces, this parameter is ignored. The pointer must not be NULL.</param>
        /// <param name="pValue">A pointer to the new value for the firmware environment variable.</param>
        /// <param name="nSize">The size of the pValue buffer, in bytes. Unless the VARIABLE_ATTRIBUTE_APPEND_WRITE, VARIABLE_ATTRIBUTE_AUTHENTICATED_WRITE_ACCESS, or VARIABLE_ATTRIBUTE_TIME_BASED_AUTHENTICATED_WRITE_ACCESS variable attribute is set via dwAttributes, setting this value to zero will result in the deletion of this variable.</param>
        /// <param name="dwAttributes">Bitmask to set UEFI variable attributes associated with the variable. See also UEFI Spec 2.3.1, Section 7.2.If the function succeeds, the return value is a nonzero value.If the function fails, the return value is zero. To get extended error information, call GetLastError. Possible error codes include ERROR_INVALID_FUNCTION.Starting with Windows 10, version 1803, Universal Windows apps can read and write UEFI firmware variables. See Access UEFI firmware variables from a Universal Windows App for details.Starting with Windows 10, version 1803, reading UEFI firmware variables is also supported from User-Mode Driver Framework (UMDF) drivers. Writing UEFI firmware variables from UMDF drivers is not supported.To write a firmware environment variable, the user account that the app is running under must have the SE_SYSTEM_ENVIRONMENT_NAME privilege. A Universal Windows app must be run from an administrator account and follow the requirements outlined in Access UEFI firmware variables from a Universal Windows App.The correct method of changing the attributes of a variable is to delete the variable and recreate it with different attributes.The exact set of firmware environment variables is determined by the boot firmware. The location of these environment variables is also specified by the firmware. For example, on a UEFI-based system, NVRAM contains firmware environment variables that specify system boot settings. For information about specific variables used, see the UEFI specification. For more information about UEFI and Windows, see UEFI and Windows.Firmware variables are not supported on a legacy BIOS-based system. The SetFirmwareEnvironmentVariableEx function will always fail on a legacy BIOS-based system, or if Windows was installed using legacy BIOS on a system that supports both legacy BIOS and UEFI. To identify these conditions, call the function with a dummy firmware environment name such as an empty string ("") for the lpName parameter and a dummy GUID such as "{00000000-0000-0000-0000-000000000000}" for the lpGuid parameter. On a legacy BIOS-based system, or on a system that supports both legacy BIOS and UEFI where Windows was installed using legacy BIOS, the function will fail with ERROR_INVALID_FUNCTION. On a UEFI-based system, the function will fail with an error specific to the firmware, such as ERROR_NOACCESS, to indicate that the dummy GUID namespace does not exist.Access UEFI firmware variables from a Universal Windows AppGetFirmwareEnvironmentVariableExSetFirmwareEnvironmentVariable</param>
        /// <remarks>
        /// To get extended error information, call GetLastError. Possible error codes include ERROR_INVALID_FUNCTION.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetFirmwareEnvironmentVariableExW(string lpName, string lpGuid, IntPtr pValue, uint nSize, uint dwAttributes);

        /// <summary>
        ///Sets the value of the specified firmware environment variable.
        /// </summary>
        /// <param name="lpName">The name of the firmware environment variable. The pointer must not be NULL.</param>
        /// <param name="lpGuid">The GUID that represents the namespace of the firmware environment variable. The GUID must be a string in the format "{xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}". If the system does not support GUID-based namespaces, this parameter is ignored.</param>
        /// <param name="pValue">A pointer to the new value for the firmware environment variable.</param>
        /// <param name="nSize">The size of the pBuffer buffer, in bytes. If this parameter is zero, the firmware environment variable is deleted.If the function succeeds, the return value is a nonzero value.If the function fails, the return value is zero. To get extended error information, call GetLastError. Possible error codes include ERROR_INVALID_FUNCTION.Starting with Windows 10, version 1803, Universal Windows apps can read and write UEFI firmware variables. See Access UEFI firmware variables from a Universal Windows App for details.Starting with Windows 10, version 1803, reading UEFI firmware variables is also supported from User-Mode Driver Framework (UMDF) drivers. Writing UEFI firmware variables from UMDF drivers is not supported.To write a firmware environment variable, the user account that the app is running under must have the SE_SYSTEM_ENVIRONMENT_NAME privilege. A Universal Windows app must be run from an administrator account and follow the requirements outlined in Access UEFI firmware variables from a Universal Windows App.The exact set of firmware environment variables is determined by the boot firmware. The location of these environment variables is also specified by the firmware. For example, on a UEFI-based system, NVRAM contains firmware environment variables that specify system boot settings. For information about specific variables used, see the UEFI specification. For more information about UEFI and Windows, see UEFI and Windows.Firmware variables are not supported on a legacy BIOS-based system. The SetFirmwareEnvironmentVariable function will always fail on a legacy BIOS-based system, or if Windows was installed using legacy BIOS on a system that supports both legacy BIOS and UEFI. To identify these conditions, call the function with a dummy firmware environment name such as an empty string ("") for the lpName parameter and a dummy GUID such as "{00000000-0000-0000-0000-000000000000}" for the lpGuid parameter. On a legacy BIOS-based system, or on a system that supports both legacy BIOS and UEFI where Windows was installed using legacy BIOS, the function will fail with ERROR_INVALID_FUNCTION. On a UEFI-based system, the function will fail with an error specific to the firmware, such as ERROR_NOACCESS, to indicate that the dummy GUID namespace does not exist.SetFirmwareEnvironmentVariable is the user-mode equivalent of the ExSetFirmwareEnvironmentVariable kernel-mode routine.Access UEFI firmware variables from a Universal Windows AppGetFirmwareEnvironmentVariableSetFirmwareEnvironmentVariableExSystem Information Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError. Possible error codes include ERROR_INVALID_FUNCTION.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetFirmwareEnvironmentVariableW(string lpName, string lpGuid, IntPtr pValue, uint nSize);

        /// <summary>
        ///Changes the number of file handles available to a process. For DOS-based Win32, the default maximum number of file handles available to a process is 20. For Windows Win32 systems, this API has no effect.
        /// </summary>

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int SetHandleCount();

        /// <summary>
        ///Sets the time-out value used by the specified mailslot for a read operation.
        /// </summary>
        /// <param name="hMailslot">A handle to a mailslot. The CreateMailslot function must create this handle.</param>
        /// <param name="lReadTimeout">The time a read operation can wait for a message to be written to the mailslot before a time-out occurs, in milliseconds. The following values have special meanings.This time-out value applies to all subsequent read operations and to all inherited mailslot handles.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The initial time-out value used by a mailslot for a read operation is typically set by CreateMailslot when the mailslot is created.CreateMailslotGetMailslotInfoMailslot FunctionsMailslots Overview</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetMailslotInfo(IntPtr hMailslot, uint lReadTimeout);

        /// <summary>
        ///Sets a processor affinity mask for the threads of the specified process.
        /// </summary>
        /// <param name="hProcess">A handle to the process whose affinity mask is to be set. This handle must have the PROCESS_SET_INFORMATION access right. For more information, see Process Security and Access Rights.</param>
        /// <param name="dwProcessAffinityMask">The affinity mask for the threads of the process.On a system with more than 64 processors, the affinity mask must specify processors in a single processor group.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.If the process affinity mask requests a processor that is not configured in the system, the last error code is ERROR_INVALID_PARAMETER.On a system with more than 64 processors, if the calling process contains threads in more than one processor group, the last error code is ERROR_INVALID_PARAMETER.A process affinity mask is a bit vector in which each bit represents a logical processor on which the threads of the process are allowed to run. The value of the process affinity mask must be a subset of the system affinity mask values obtained by the GetProcessAffinityMask function. A process is only allowed to run on the processors configured into a system. Therefore, the process affinity mask cannot specify a 1 bit for a processor when the system affinity mask specifies a 0 bit for that processor.Process affinity is inherited by any child process or newly instantiated local process.Do not call SetProcessAffinityMask in a DLL that may be called by processes other than your own.On a system with more than 64 processors, the SetProcessAffinityMask function can be used to set the process affinity mask only for processes with threads in a single processor group. Use the SetThreadAffinityMask function to set the affinity mask for individual threads in multiple groups. This effectively changes the group assignment of the process.Starting with Windows 11 and Windows Server 2022, on a system with more than 64 processors, process and thread affinities span all processors in the system, across all processor groups, by default. Instead of always failing in case the calling process contains threads in more than one processor group, the SetProcessAffinityMask function fails (returning zero with ERROR_INVALID_PARAMETER last error code) if the process had explicitly set the affinity of one or more of its threads outside of the process' primary group.CreateProcessGetProcessAffinityMaskMultiple ProcessorsProcess and Thread FunctionsProcessesProcessor GroupsSetThreadAffinityMask</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetProcessAffinityMask(IntPtr hProcess, uint dwProcessAffinityMask);

        /// <summary>
        ///Changes data execution prevention (DEP) and DEP-ATL thunk emulation settings for a 32-bit process.
        /// </summary>
        /// <param name="dwFlags">A DWORD that can be one or more of the following values.If the function succeeds, it returns TRUE.If the function fails, it returns FALSE. To retrieve error values defined for this function, call GetLastError.The SetProcessDEPPolicy function overrides the system DEP policy for the current process unless its DEP policy was specified at process creation. The system DEP policy setting must be OptIn or OptOut. If the system DEP policy is AlwaysOff or AlwaysOn, SetProcessDEPPolicy returns an error. After DEP is enabled for a process, subsequent calls to SetProcessDEPPolicy are ignored.DEP policy specified at process creation with the PROC_THREAD_ATTRIBUTE_MITIGATION_POLICY attribute cannot be changed for the life of the process. In this case, calls to SetProcessDEPPolicy fail with ERROR_ACCESS_DENIED.SetProcessDEPPolicy is supported for 32-bit processes only. If this function is called on a 64-bit process, it fails with ERROR_NOT_SUPPORTED.Applications written to ATL 7.1 and earlier can attempt to execute code on pages marked as non-executable, which triggers an NX fault and terminates the application. DEP-ATL thunk emulation allows an application that would otherwise trigger an NX fault to run with DEP enabled. For information about ATL versions, see ATL and MFC Version Numbers.If DEP-ATL thunk emulation is enabled, the system intercepts NX faults, emulates the instructions, and handles the exceptions so the application can continue to run. If DEP-ATL thunk emulation is disabled by setting PROCESS_DEP_DISABLE_ATL_THUNK_EMULATION for the process, NX faults are not intercepted, which is useful when testing applications for compatibility with DEP.The following table summarizes the interactions between system DEP policy, DEP-ATL thunk emulation, and SetProcessDEPPolicy. To get the system DEP policy setting, use the GetSystemDEPPolicy function.To compile an application that calls this function, define _WIN32_WINNT as 0x0600 or later. For more information, see Using the Windows Headers.Data Execution PreventionGetProcessDEPPolicyGetSystemDEPPolicy</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetProcessDEPPolicy(uint dwFlags);

        /// <summary>
        ///Sets the per-process mode that the SearchPath function uses when locating files.
        /// </summary>
        /// <param name="Flags">The search mode to use.If the operation completes successfully, the SetSearchPathMode function returns a nonzero value.If the operation fails, the SetSearchPathMode function returns zero. To get extended error information, call the GetLastError function.If the SetSearchPathMode function fails because a parameter value is not valid, the value returned by the GetLastError function will be ERROR_INVALID_PARAMETER.If the SetSearchPathMode function fails because the combination of current state and parameter value is not valid, the value returned by the GetLastError function will be ERROR_ACCESS_DENIED. For more information, see the Remarks section.If the SetSearchPathMode function has not been successfully called for the current process, the search mode used by the SearchPath function is obtained from the system registry. For more information, see SearchPath.After the SetSearchPathMode function has been successfully called for the current process, the setting in the system registry is ignored in favor of the mode most recently set successfully.If the SetSearchPathMode function has been successfully called for the current process with Flags set to (BASE_SEARCH_PATH_ENABLE_SAFE_SEARCHMODE | BASE_SEARCH_PATH_PERMANENT), safe mode is set permanently for the calling process. Any subsequent calls to the SetSearchPathMode function from within that process that attempt to change the search mode will fail with ERROR_ACCESS_DENIED from the GetLastError function.This function does not modify the system registry.In Windows 8 and Windows Server 2012, this function is supported by the following technologies.File Management FunctionsSearchPath</param>
        /// <remarks>
        /// To get extended error information, call the GetLastError function.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetSearchPathMode(uint Flags);

        /// <summary>
        ///[SetSystemPowerState is available for use in the operating systems specified in the Requirements section. It may be altered or unavailable in subsequent versions. Applications written for Windows Vista and later should use SetSuspendState instead.]
        /// </summary>
        /// <param name="fSuspend">If this parameter is TRUE, the system is suspended. If the parameter is FALSE, the system hibernates.</param>
        /// <param name="fForce">This parameter has no effect.If power has been suspended and subsequently restored, the return value is nonzero.If the system was not suspended, the return value is zero. To get extended error information, call GetLastError.The calling process must have the SE_SHUTDOWN_NAME privilege. To enable the SE_SHUTDOWN_NAME privilege, use the AdjustTokenPrivileges function. For more information, see Changing Privileges in a Token.If any application or driver denies permission to suspend operation, the function broadcasts a PBT_APMQUERYSUSPENDFAILED event to each application and driver. If power is suspended, this function returns only after system operation is resumed and related WM_POWERBROADCAST messages have been broadcast to all applications and drivers.This function is similar to the SetSuspendState function.To compile an application that uses this function, define the _WIN32_WINNT macro as 0x0400 or later. For more information, see Using the Windows Headers.PBT_APMQUERYSUSPENDPBT_APMQUERYSUSPENDFAILEDPBT_APMSUSPENDPower Management FunctionsSetSuspendStateWM_POWERBROADCAST</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetSystemPowerState(bool fSuspend, bool fForce);

        /// <summary>
        ///The SetTapeParameters function either specifies the block size of a tape or configures the tape device.
        /// </summary>
        /// <param name="hDevice">Handle to the device for which to set configuration information. This handle is created by using the CreateFile function.</param>
        /// <param name="dwOperation">Type of information to set. This parameter must be one of the following values.</param>
        /// <param name="lpTapeInformation">Pointer to a structure that contains the information to set. If the dwOperation parameter is SET_TAPE_MEDIA_INFORMATION, lpTapeInformation points to a TAPE_SET_MEDIA_PARAMETERS structure.If dwOperation is SET_TAPE_DRIVE_INFORMATION, lpTapeInformation points to a TAPE_SET_DRIVE_PARAMETERS structure.If the function succeeds, the return value is NO_ERROR.If the function fails, it can return one of the following error codes.GetTapeParametersTAPE_SET_DRIVE_PARAMETERSTAPE_SET_MEDIA_PARAMETERS</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint SetTapeParameters(IntPtr hDevice, uint dwOperation, IntPtr lpTapeInformation);

        /// <summary>
        ///The SetTapePosition function sets the tape position on the specified device.
        /// </summary>
        /// <param name="hDevice">Handle to the device on which to set the tape position. This handle is created by using the CreateFile function.</param>
        /// <param name="dwPositionMethod">Type of positioning to perform. This parameter must be one of the following values.</param>
        /// <param name="dwPartition">Partition to position within. If dwPartition is zero, the current partition is used. Partitions are numbered logically from 1 through n, where 1 is the first partition on the tape and n is the last.</param>
        /// <param name="dwOffsetLow">Low-order bits of the block address or count for the position operation specified by the dwPositionMethod parameter.</param>
        /// <param name="dwOffsetHigh">High-order bits of the block address or count for the position operation specified by the dwPositionMethod parameter. If the high-order bits are not required, this parameter should be zero.</param>
        /// <param name="bImmediate">Indicates whether to return as soon as the move operation begins. If this parameter is TRUE, the function returns immediately; if FALSE, the function does not return until the move operation has been completed.If the function succeeds, the return value is NO_ERROR.If the function fails, it can return one of the following error codes.If the offset specified by dwOffsetLow and dwOffsetHigh specifies the number of blocks, filemarks, or setmarks to move, a positive offset moves the tape forward to the end of the last block, filemark, or setmark. A negative offset moves the tape backward to the beginning of the last block, filemark, or setmark. If the offset is zero, the tape does not move.To obtain information about the status, capabilities, and capacities of tape drives and media, call the GetTapeParameters function.CreateFileGetTapeParametersGetTapePosition</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint SetTapePosition(IntPtr hDevice, uint dwPositionMethod, uint dwPartition, uint dwOffsetLow, uint dwOffsetHigh, bool bImmediate);

        /// <summary>
        ///Sets a processor affinity mask for the specified thread.
        /// </summary>
        /// <param name="hThread">A handle to the thread whose affinity mask is to be set.This handle must have the THREAD_SET_INFORMATION or THREAD_SET_LIMITED_INFORMATION access right and the THREAD_QUERY_INFORMATION or THREAD_QUERY_LIMITED_INFORMATION access right. For more information, see Thread Security and Access Rights.Windows Server 2003 and Windows XP:  The handle must have the THREAD_SET_INFORMATION and THREAD_QUERY_INFORMATION access rights.</param>
        /// <param name="dwThreadAffinityMask">The affinity mask for the thread.On a system with more than 64 processors, the affinity mask must specify processors in the thread's current processor group.If the function succeeds, the return value is the thread's previous affinity mask.If the function fails, the return value is zero. To get extended error information, call GetLastError.If the thread affinity mask requests a processor that is not selected for the process affinity mask, the last error code is ERROR_INVALID_PARAMETER.A thread affinity mask is a bit vector in which each bit represents a logical processor that a thread is allowed to run on. A thread affinity mask must be a subset of the process affinity mask for the containing process of a thread. A thread can only run on the processors its process can run on. Therefore, the thread affinity mask cannot specify a 1 bit for a processor when the process affinity mask specifies a 0 bit for that processor.Setting an affinity mask for a process or thread can result in threads receiving less processor time, as the system is restricted from running the threads on certain processors. In most cases, it is better to let the system select an available processor.If the new thread affinity mask does not specify the processor that is currently running the thread, the thread is rescheduled on one of the allowable processors.Starting with Windows 11 and Windows Server 2022, on a system with more than 64 processors, process and thread affinities span all processors in the system, across all processor groups, by default. The dwThreadAffinityMask must specify processors in the thread's current primary group.GetProcessAffinityMaskMultiple ProcessorsOpenThreadProcess and Thread FunctionsProcessor GroupsSetProcessAffinityMaskSetThreadIdealProcessorThreads</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint SetThreadAffinityMask(IntPtr hThread, uint dwThreadAffinityMask);

        /// <summary>
        ///Enables an application to inform the system that it is in use, thereby preventing the system from entering sleep or turning off the display while the application is running.
        /// </summary>
        /// <param name="esFlags">The thread's execution requirements. This parameter can be one or more of the following values.If the function succeeds, the return value is the previous thread execution state.If the function fails, the return value is NULL.The system automatically detects activities such as local keyboard or mouse input, server activity, and changing window focus. Activities that are not automatically detected include disk or CPU activity and video display.Calling SetThreadExecutionState without ES_CONTINUOUS simply resets the idle timer; to keep the display or system in the working state, the thread must call SetThreadExecutionState periodically.To run properly on a power-managed computer, applications such as fax servers, answering machines, backup agents, and network management applications must use both ES_SYSTEM_REQUIRED and ES_CONTINUOUS when they process events. Multimedia applications, such as video players and presentation applications, must use ES_DISPLAY_REQUIRED when they display video for long periods of time without user input. Applications such as word processors, spreadsheets, browsers, and games do not need to call SetThreadExecutionState.The ES_AWAYMODE_REQUIRED value should be used only when absolutely necessary by media applications that require the system to perform background tasks such as recording television content or streaming media to other devices while the system appears to be sleeping. Applications that do not require critical background processing or that run on portable computers should not enable away mode because it prevents the system from conserving power by entering true sleep.To enable away mode, an application uses both ES_AWAYMODE_REQUIRED and ES_CONTINUOUS; to disable away mode, an application calls SetThreadExecutionState with ES_CONTINUOUS and clears ES_AWAYMODE_REQUIRED. When away mode is enabled, any operation that would put the computer to sleep puts it in away mode instead. The computer appears to be sleeping while the system continues to perform tasks that do not require user input. Away mode does not affect the sleep idle timer; to prevent the system from entering sleep when the timer expires, an application must also set the ES_SYSTEM_REQUIRED value.The SetThreadExecutionState function cannot be used to prevent the user from putting the computer to sleep. Applications should respect that the user expects a certain behavior when they close the lid on their laptop or press the power button.This function does not stop the screen saver from executing.Power Management FunctionsSetSuspendStateSetSystemPowerStateWM_POWERBROADCAST</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int SetThreadExecutionState(int esFlags);

        /// <summary>
        ///Sets application-specific context information for the specified user-mode scheduling (UMS) worker thread.
        /// </summary>
        /// <param name="UmsThread">A pointer to a UMS thread context.</param>
        /// <param name="UmsThreadInfoClass">A UMS_THREAD_INFO_CLASS value that specifies the kind of information to set. This parameter must be UmsThreadUserContext.</param>
        /// <param name="UmsThreadInformation">A pointer to a buffer that contains the information to set.</param>
        /// <param name="UmsThreadInformationLength">The size of the UmsThreadInformation buffer, in bytes.If the function succeeds, it returns a nonzero value.If the function fails, the return value is zero. To get extended error information, call GetLastError. Possible error values include the following.The SetUmsThreadInformation function can be used to set an application-defined context for the specified UMS worker thread. The context information can consist of anything the application might find useful to track, such as per-scheduler or per-worker thread state. The underlying structures for UMS worker threads are managed by the system and should not be modified directly.The QueryUmsThreadInformation function can be used to retrieve other exposed information about the specified thread, such as its thread execution block (TEB) and whether the thread is suspended or terminated. Information that is not exposed through QueryUmsThreadInformation should be considered reserved.QueryUmsThreadInformation</param>
        /// <remarks>
        /// To get extended error information, call GetLastError. Possible error values include the following.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetUmsThreadInformation(int UmsThread, IntPtr UmsThreadInfoClass, IntPtr UmsThreadInformation, int UmsThreadInformationLength);

        /// <summary>
        ///Initializes the communications parameters for a specified communications device.
        /// </summary>
        /// <param name="hFile">A handle to the communications device. The CreateFile function returns this handle.</param>
        /// <param name="dwInQueue">The recommended size of the device's internal input buffer, in bytes.</param>
        /// <param name="dwOutQueue">The recommended size of the device's internal output buffer, in bytes.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.After a process uses the CreateFile function to open a handle to a communications device, but before doing any I/O with the device, it can call SetupComm to set the communications parameters for the device. If it does not set them, the device uses the default parameters when the first call to another communications function occurs.The dwInQueue and dwOutQueue parameters specify the recommended sizes for the internal buffers used by the driver for the specified device. For example, YMODEM protocol packets are slightly larger than 1024 bytes. Therefore, a recommended buffer size might be 1200 bytes for YMODEM communications. For Ethernet-based communications, a recommended buffer size might be 1600 bytes, which is slightly larger than a single Ethernet frame.The device driver receives the recommended buffer sizes, but is free to use any input and output (I/O) buffering scheme, as long as it provides reasonable performance and data is not lost due to overrun (except under extreme circumstances). For example, the function can succeed even though the driver does not allocate a buffer, as long as some other portion of the system provides equivalent functionality.Communications FunctionsCommunications ResourcesCreateFileSetCommState</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetupComm(IntPtr hFile, uint dwInQueue, uint dwOutQueue);

        /// <summary>
        ///Sets the label of a file system volume.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetVolumeLabelA();

        /// <summary>
        ///Sets the label of a file system volume.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetVolumeLabelW();

        /// <summary>
        ///Associates a volume with a drive letter or a directory on another volume.
        /// </summary>
        /// <param name="lpszVolumeMountPoint">The user-mode path to be associated with the volume. This may be a drive letter (for example, "X:\") or a directory on another volume (for example, "Y:\MountX"). The string must end with a trailing backslash ('').</param>
        /// <param name="lpszVolumeName">A volume GUID path for the volume. This string must be of the form "\\?\Volume{GUID}" where GUID is a GUID that identifies the volume. The "\\?" turns off path parsing and is ignored as part of the path, as discussed in Naming a Volume.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.If the lpszVolumeMountPoint parameter contains a path to a mounted folder, GetLastError returns ERROR_DIR_NOT_EMPTY, even if the directory is empty.When this function is used to associate a volume with a directory on another volume, the associated directory is called a mounted folder.It is an error to associate a volume with a directory that has any files or subdirectories in it. This error occurs for system and hidden directories as well as other directories, and it occurs for system and hidden files.When mounted folders are created on a volume on a clustered disk, they may be deleted unexpectedly under certain circumstances. For information on how to create and configure mounted folders to ensure that this does not happen, see Cluster Disk and Drive Connection Problems.IIn Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB does not support volume management functions. For CsvFS a new mount point will not be replicated to the other nodes on the cluster.For an example, see Creating a Mounted Folder.DeleteVolumeMountPointGetVolumeNameForVolumeMountPointGetVolumePathNameMounted FoldersVolume Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetVolumeMountPointA(string lpszVolumeMountPoint, string lpszVolumeName);

        /// <summary>
        ///Associates a volume with a drive letter or a directory on another volume.
        /// </summary>
        /// <param name="lpszVolumeMountPoint">The user-mode path to be associated with the volume. This may be a drive letter (for example, "X:\") or a directory on another volume (for example, "Y:\MountX"). The string must end with a trailing backslash ('').</param>
        /// <param name="lpszVolumeName">A volume GUID path for the volume. This string must be of the form "\\?\Volume{GUID}\" where GUID is a GUID that identifies the volume. The "\\?\" turns off path parsing and is ignored as part of the path, as discussed in Naming a Volume.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.If the lpszVolumeMountPoint parameter contains a path to a mounted folder, GetLastError returns ERROR_DIR_NOT_EMPTY, even if the directory is empty.When this function is used to associate a volume with a directory on another volume, the associated directory is called a mounted folder.It is an error to associate a volume with a directory that has any files or subdirectories in it. This error occurs for system and hidden directories as well as other directories, and it occurs for system and hidden files.When mounted folders are created on a volume on a clustered disk, they may be deleted unexpectedly under certain circumstances. For information on how to create and configure mounted folders to ensure that this does not happen, see Cluster Disk and Drive Connection Problems.IIn Windows 8 and Windows Server 2012, this function is supported by the following technologies.SMB does not support volume management functions. For CsvFS a new mount point will not be replicated to the other nodes on the cluster.For an example, see Creating a Mounted Folder.DeleteVolumeMountPointGetVolumeNameForVolumeMountPointGetVolumePathNameMounted FoldersVolume Management Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetVolumeMountPointW(string lpszVolumeMountPoint, string lpszVolumeName);

        /// <summary>
        ///Sets the mask of XState features set within a CONTEXT structure.
        /// </summary>
        /// <param name="FeatureMask">A mask of XState features to set in the specified CONTEXT structure.This function returns TRUE if successful, otherwise FALSE.The SetXStateFeaturesMask function sets the mask of valid features in the specified context. Before calling GetThreadContext, Wow64GetThreadContext, SetThreadContext, or Wow64SetThreadContext the application must call SetXStateFeaturesMask to specify which set of features to retrieve or set. The system silently ignores any feature specified in the FeatureMask which is not enabled on the processor.Windows 7 with SP1 and Windows Server 2008 R2 with SP1:  The AVX API is first implemented on Windows 7 with SP1 and Windows Server 2008 R2 with SP1 . Since there is no SDK for SP1, that means there are no available headers and library files to work with. In this situation, a caller must declare the needed functions from this documentation and get pointers to them using GetModuleHandle on "Kernel32.dll", followed by calls to GetProcAddress. See Working with XState Context for details.CONTEXTGetThreadContextIntel AVXSetThreadContextWorking with XState ContextWow64GetThreadContextWow64SetThreadContext</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetXStateFeaturesMask(uint FeatureMask);

        /// <summary>
        ///Schedules a fiber. The function must be called on a fiber.
        /// </summary>
        /// <param name="lpFiber">The address of the fiber to be scheduled.NoneYou create fibers with the CreateFiber function. Before you can schedule fibers associated with a thread, you must call ConvertThreadToFiber to set up an area in which to save the fiber state information. The thread is now the currently executing fiber.The SwitchToFiber function saves the state information of the current fiber and restores the state of the specified fiber. You can call SwitchToFiber with the address of a fiber created by a different thread. To do this, you must have the address returned to the other thread when it called CreateFiber and you must use proper synchronization.Avoid making the following call:This call can cause unpredictable problems.To compile an application that uses this function, define _WIN32_WINNT as 0x0400 or later. For more information, see Using the Windows Headers.ConvertThreadToFiberCreateFiberFibersProcess and Thread Functions</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void SwitchToFiber(IntPtr lpFiber);

        /// <summary>
        ///Transmits a specified character ahead of any pending data in the output buffer of the specified communications device.
        /// </summary>
        /// <param name="hFile">A handle to the communications device. The CreateFile function returns this handle.</param>
        /// <param name="cChar">The character to be transmitted.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The TransmitCommChar function is useful for sending an interrupt character (such as a CTRL+C) to a host system.If the device is not transmitting, TransmitCommChar cannot be called repeatedly. Once TransmitCommChar places a character in the output buffer, the character must be transmitted before the function can be called again. If the previous character has not yet been sent, TransmitCommChar returns an error.Communications FunctionsCommunications ResourcesCreateFileWaitCommEvent</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool TransmitCommChar(IntPtr hFile, char cChar);

        /// <summary>
        ///Yields control to the user-mode scheduling (UMS) scheduler thread on which the calling UMS worker thread is running.
        /// </summary>
        /// <param name="SchedulerParam">A parameter to pass to the scheduler thread's UmsSchedulerProc function.If the function succeeds, it returns a nonzero value.If the function fails, the return value is zero. To get extended error information, call GetLastError.A UMS worker thread calls the UmsThreadYield function to cooperatively yield control to the UMS scheduler thread on which the worker thread is running. If a UMS worker thread never calls UmsThreadYield, the worker thread runs until it either blocks or is terminated.When control switches to the UMS scheduler thread, the system calls the associated scheduler entry point function with the reason UmsSchedulerThreadYield and the ScheduleParam parameter specified by the worker thread in the UmsThreadYield call.The application's scheduler is responsible for rescheduling the worker thread.UmsSchedulerProc</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool UmsThreadYield(IntPtr SchedulerParam);

        /// <summary>
        ///Removes the active instance of an application from the recovery list.
        /// </summary>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr UnregisterApplicationRecoveryCallback();

        /// <summary>
        ///Removes the active instance of an application from the restart list.
        /// </summary>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr UnregisterApplicationRestart();

        /// <summary>
        ///Cancels a registered wait operation issued by the RegisterWaitForSingleObject function.
        /// </summary>
        /// <param name="WaitHandle">The wait handle. This handle is returned by the RegisterWaitForSingleObject function.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.If any callback functions associated with the timer have not completed when UnregisterWait is called, UnregisterWait unregisters the wait on the callback functions and fails with the ERROR_IO_PENDING error code. The error code does not indicate that the function has failed, and the function does not need to be called again. If your code requires an error code to set only when the unregister operation has failed, call UnregisterWaitEx instead.To compile an application that uses this function, define _WIN32_WINNT as 0x0500 or later. For more information, see Using the Windows Headers.RegisterWaitForSingleObjectSynchronization FunctionsThread PoolingUnregisterWaitEx</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool UnregisterWait(IntPtr WaitHandle);

        /// <summary>
        ///Adds, deletes, or replaces a resource in a portable executable (PE) file. There are some restrictions on resource updates in files that contain Resource Configuration (RC Config) data: language-neutral (LN) files and language-specific resource (.mui) files.
        /// </summary>
        /// <param name="hUpdate">Type: HANDLEA module handle returned by the BeginUpdateResource function, referencing the file to be updated.</param>
        /// <param name="lpType">Type: LPCTSTRThe resource type to be updated. Alternatively, rather than a pointer, this parameter can be MAKEINTRESOURCE(ID), where ID is an integer value representing a predefined resource type. If the first character of the string is a pound sign (#), then the remaining characters represent a decimal number that specifies the integer identifier of the resource type. For example, the string "#258" represents the identifier 258.For a list of predefined resource types, see Resource Types.</param>
        /// <param name="lpName">Type: LPCTSTRThe name of the resource to be updated. Alternatively, rather than a pointer, this parameter can be MAKEINTRESOURCE(ID), where ID is a resource ID. When creating a new resource do not use a string that begins with a '#' character for this parameter.</param>
        /// <param name="wLanguage">Type: WORDThe language identifier of the resource to be updated. For a list of the primary language identifiers and sublanguage identifiers that make up a language identifier, see the MAKELANGID macro.</param>
        /// <param name="cb">Type: DWORDThe size, in bytes, of the resource data at lpData.Type: BOOL</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool UpdateResourceA(IntPtr hUpdate, string lpType, string lpName, uint wLanguage, uint cb);

        /// <summary>
        ///Adds, deletes, or replaces a resource in a portable executable (PE) file. There are some restrictions on resource updates in files that contain Resource Configuration (RC Config) data: language-neutral (LN) files and language-specific resource (.mui) files.
        /// </summary>
        /// <param name="hUpdate">Type: HANDLEA module handle returned by the BeginUpdateResource function, referencing the file to be updated.</param>
        /// <param name="lpType">Type: LPCTSTRThe resource type to be updated. Alternatively, rather than a pointer, this parameter can be MAKEINTRESOURCE(ID), where ID is an integer value representing a predefined resource type. If the first character of the string is a pound sign (#), then the remaining characters represent a decimal number that specifies the integer identifier of the resource type. For example, the string "#258" represents the identifier 258.For a list of predefined resource types, see Resource Types.</param>
        /// <param name="lpName">Type: LPCTSTRThe name of the resource to be updated. Alternatively, rather than a pointer, this parameter can be MAKEINTRESOURCE(ID), where ID is a resource ID. When creating a new resource do not use a string that begins with a '#' character for this parameter.</param>
        /// <param name="wLanguage">Type: WORDThe language identifier of the resource to be updated. For a list of the primary language identifiers and sublanguage identifiers that make up a language identifier, see the MAKELANGID macro.</param>
        /// <param name="cb">Type: DWORDThe size, in bytes, of the resource data at lpData.Type: BOOL</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool UpdateResourceW(IntPtr hUpdate, string lpType, string lpName, uint wLanguage, uint cb);

        /// <summary>
        ///Compares a set of operating system version requirements to the corresponding values for the currently running version of the system.This function is subject to manifest-based behavior. For more information, see the Remarks section.
        /// </summary>
        /// <param name="lpVersionInformation">A pointer to an OSVERSIONINFOEX structure containing the operating system version requirements to compare. The dwTypeMask parameter indicates the members of this structure that contain information to compare.You must set the dwOSVersionInfoSize member of this structure to sizeof(OSVERSIONINFOEX). You must also specify valid data for the members indicated by dwTypeMask. The function ignores structure members for which the corresponding dwTypeMask bit is not set.</param>
        /// <param name="dwTypeMask">A mask that indicates the members of the OSVERSIONINFOEX structure to be tested. This parameter can be one or more of the following values.</param>
        /// <param name="dwlConditionMask">The type of comparison to be used for each lpVersionInfo member being compared. To build this value, call the VerSetConditionMask function or the VER_SET_CONDITION macro once for each OSVERSIONINFOEX member being compared.If the currently running operating system satisfies the specified requirements, the return value is a nonzero value.If the current system does not satisfy the requirements, the return value is zero and GetLastError returns ERROR_OLD_WIN_VERSION.If the function fails, the return value is zero and GetLastError returns an error code other than ERROR_OLD_WIN_VERSION.The VerifyVersionInfo function retrieves version information about the currently running operating system and compares it to the valid members of the lpVersionInfo structure. This enables you to easily determine the presence of a required set of operating system version conditions. It is preferable to use VerifyVersionInfo rather than calling the GetVersionEx function to perform your own comparisons.Typically, VerifyVersionInfo returns a nonzero value only if all specified tests succeed. However, major, minor, and service pack versions are tested in a hierarchical manner because the operating system version is a combination of these values. If a condition exists for the major version, it supersedes the conditions specified for minor version and service pack version. (You cannot test for major version greater than 5 and minor version less than or equal to 1. If you specify such a test, the function will change the request to test for a minor version greater than 1 because it is performing a greater than operation on the major version.)The function tests these values in this order: major version, minor version, and service pack version. The function continues testing values while they are equal, and stops when one of the values does not meet the specified condition. For example, if you test for a system greater than or equal to version 5.1 service pack 1, the test succeeds if the current version is 6.0. (The major version is greater than the specified version, so the testing stops.) In the same way, if you test for a system greater than or equal to version 5.1 service pack 1, the test succeeds if the current version is 5.2. (The minor version is greater than the specified versions, so the testing stops.) However, if you test for a system greater than or equal to version 5.1 service pack 1, the test fails if the current version is 5.0 service pack 2. (The minor version is not greater than the specified version, so the testing stops.)To verify a range of system versions, you must call VerifyVersionInfo twice. For example, to verify that the system version is greater than 5.0 but less than or equal to 5.1, first call VerifyVersionInfo to test that the major version is 5 and the minor version is greater than 0, then call VerifyVersionInfo again to test that the major version is 5 and the minor version is less than or equal to 1.Identifying the current operating system is usually not the best way to determine whether a particular operating system feature is present. This is because the operating system may have had new features added in a redistributable DLL. Rather than using GetVersionEx to determine the operating system platform or version number, test for the presence of the feature itself. For more information, see Operating System Version.To verify whether the current operating system is either the Media Center or Tablet PC version of Windows, call GetSystemMetrics.Windows 10:  VerifyVersionInfo returns false when called by applications that do not have a compatibility manifest for Windows 8.1 or Windows 10 if the lpVersionInfo parameter is set so that it specifies Windows 8.1 or Windows 10, even when the current operating system version is Windows 8.1 or Windows 10. Specifically, VerifyVersionInfo has the following behavior:To manifest your applications for Windows 8.1 or Windows 10, see Targeting your application for Windows.For an example, see Verifying the System Version.GetVersionExOSVERSIONINFOEXOperating System VersionSystem Information FunctionsVER_SET_CONDITIONVerSetConditionMask</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool VerifyVersionInfoA(int lpVersionInformation, uint dwTypeMask, uint dwlConditionMask);

        /// <summary>
        ///Compares a set of operating system version requirements to the corresponding values for the currently running version of the system.This function is subject to manifest-based behavior. For more information, see the Remarks section.
        /// </summary>
        /// <param name="lpVersionInformation">A pointer to an OSVERSIONINFOEX structure containing the operating system version requirements to compare. The dwTypeMask parameter indicates the members of this structure that contain information to compare.You must set the dwOSVersionInfoSize member of this structure to sizeof(OSVERSIONINFOEX). You must also specify valid data for the members indicated by dwTypeMask. The function ignores structure members for which the corresponding dwTypeMask bit is not set.</param>
        /// <param name="dwTypeMask">A mask that indicates the members of the OSVERSIONINFOEX structure to be tested. This parameter can be one or more of the following values.</param>
        /// <param name="dwlConditionMask">The type of comparison to be used for each lpVersionInfo member being compared. To build this value, call the VerSetConditionMask function or the VER_SET_CONDITION macro once for each OSVERSIONINFOEX member being compared.If the currently running operating system satisfies the specified requirements, the return value is a nonzero value.If the current system does not satisfy the requirements, the return value is zero and GetLastError returns ERROR_OLD_WIN_VERSION.If the function fails, the return value is zero and GetLastError returns an error code other than ERROR_OLD_WIN_VERSION.The VerifyVersionInfo function retrieves version information about the currently running operating system and compares it to the valid members of the lpVersionInfo structure. This enables you to easily determine the presence of a required set of operating system version conditions. It is preferable to use VerifyVersionInfo rather than calling the GetVersionEx function to perform your own comparisons.Typically, VerifyVersionInfo returns a nonzero value only if all specified tests succeed. However, major, minor, and service pack versions are tested in a hierarchical manner because the operating system version is a combination of these values. If a condition exists for the major version, it supersedes the conditions specified for minor version and service pack version. (You cannot test for major version greater than 5 and minor version less than or equal to 1. If you specify such a test, the function will change the request to test for a minor version greater than 1 because it is performing a greater than operation on the major version.)The function tests these values in this order: major version, minor version, and service pack version. The function continues testing values while they are equal, and stops when one of the values does not meet the specified condition. For example, if you test for a system greater than or equal to version 5.1 service pack 1, the test succeeds if the current version is 6.0. (The major version is greater than the specified version, so the testing stops.) In the same way, if you test for a system greater than or equal to version 5.1 service pack 1, the test succeeds if the current version is 5.2. (The minor version is greater than the specified versions, so the testing stops.) However, if you test for a system greater than or equal to version 5.1 service pack 1, the test fails if the current version is 5.0 service pack 2. (The minor version is not greater than the specified version, so the testing stops.)To verify a range of system versions, you must call VerifyVersionInfo twice. For example, to verify that the system version is greater than 5.0 but less than or equal to 5.1, first call VerifyVersionInfo to test that the major version is 5 and the minor version is greater than 0, then call VerifyVersionInfo again to test that the major version is 5 and the minor version is less than or equal to 1.Identifying the current operating system is usually not the best way to determine whether a particular operating system feature is present. This is because the operating system may have had new features added in a redistributable DLL. Rather than using GetVersionEx to determine the operating system platform or version number, test for the presence of the feature itself. For more information, see Operating System Version.To verify whether the current operating system is either the Media Center or Tablet PC version of Windows, call GetSystemMetrics.Windows 10:  VerifyVersionInfo returns false when called by applications that do not have a compatibility manifest for Windows 8.1 or Windows 10 if the lpVersionInfo parameter is set so that it specifies Windows 8.1 or Windows 10, even when the current operating system version is Windows 8.1 or Windows 10. Specifically, VerifyVersionInfo has the following behavior:To manifest your applications for Windows 8.1 or Windows 10, see Targeting your application for Windows.For an example, see Verifying the System Version.GetVersionExOSVERSIONINFOEXOperating System VersionSystem Information FunctionsVER_SET_CONDITIONVerSetConditionMask</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool VerifyVersionInfoW(int lpVersionInformation, uint dwTypeMask, uint dwlConditionMask);

        /// <summary>
        ///Waits for an event to occur for a specified communications device. The set of events that are monitored by this function is contained in the event mask associated with the device handle.
        /// </summary>
        /// <param name="hFile">A handle to the communications device. The CreateFile function returns this handle.</param>
        /// <param name="lpEvtMask"></param>
        /// <param name="lpOverlapped">A pointer to an OVERLAPPED structure. This structure is required if hFile was opened with FILE_FLAG_OVERLAPPED.If hFile was opened with FILE_FLAG_OVERLAPPED, the lpOverlapped parameter must not be NULL. It must point to a valid OVERLAPPED structure. If hFile was opened with FILE_FLAG_OVERLAPPED and lpOverlapped is NULL, the function can incorrectly report that the operation is complete.If hFile was opened with FILE_FLAG_OVERLAPPED and lpOverlapped is not NULL, WaitCommEvent is performed as an overlapped operation. In this case, the OVERLAPPED structure must contain a handle to a manual-reset event object (created by using the CreateEvent function).If hFile was not opened with FILE_FLAG_OVERLAPPED, WaitCommEvent does not return until one of the specified events or an error occurs.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The WaitCommEvent function monitors a set of events for a specified communications resource. To set and query the current event mask of a communications resource, use the SetCommMask and GetCommMask functions.If the overlapped operation cannot be completed immediately, the function returns FALSE and the GetLastError function returns ERROR_IO_PENDING, indicating that the operation is executing in the background. When this happens, the system sets the hEvent member of the OVERLAPPED structure to the not-signaled state before WaitCommEvent returns, and then it sets it to the signaled state when one of the specified events or an error occurs. The calling process can use one of the wait functions to determine the event object's state and then use the GetOverlappedResult function to determine the results of the WaitCommEvent operation. GetOverlappedResult reports the success or failure of the operation, and the variable pointed to by the lpEvtMask parameter is set to indicate the event that occurred.If a process attempts to change the device handle's event mask by using the SetCommMask function while an overlapped WaitCommEvent operation is in progress, WaitCommEvent returns immediately. The variable pointed to by the lpEvtMask parameter is set to zero.For an example, see Monitoring Communications Events.Communications FunctionsCommunications ResourcesCreateFileDCBGetCommMaskGetOverlappedResultOVERLAPPEDSetCommMaskSetCommState</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool WaitCommEvent(IntPtr hFile, out uint lpEvtMask, int lpOverlapped);

        /// <summary>
        ///Waits until either a time-out interval elapses or an instance of the specified named pipe is available for connection (that is, the pipe's server process has a pending ConnectNamedPipe operation on the pipe).
        /// </summary>
        /// <param name="lpNamedPipeName">The name of the named pipe. The string must include the name of the computer on which the server process is executing. A period may be used for the servername if the pipe is local. The following pipe name format is used:\\servername\pipe\pipename</param>
        /// <param name="nTimeOut">The number of milliseconds that the function will wait for an instance of the named pipe to be available. You can used one of the following values instead of specifying a number of milliseconds.If an instance of the pipe is available before the time-out interval elapses, the return value is nonzero.If an instance of the pipe is not available before the time-out interval elapses, the return value is zero. To get extended error information, call GetLastError.If no instances of the specified named pipe exist, the WaitNamedPipe function returns immediately, regardless of the time-out value.If the time-out interval expires, the WaitNamedPipe function will fail with the error ERROR_SEM_TIMEOUT.If the function succeeds, the process should use the CreateFile function to open a handle to the named pipe. A return value of TRUE indicates that there is at least one instance of the pipe available. A subsequent CreateFile call to the pipe can fail, because the instance was closed by the server or opened by another client.Windows 10, version 1709:  Pipes are only supported within an app-container; ie, from one UWP process to another UWP process that's part of the same app. Also, named pipes must use the syntax \\.\pipe\LOCAL\ for the pipe name.For an example, see Named Pipe Client.CallNamedPipeConnectNamedPipeCreateFileCreateNamedPipePipe FunctionsPipes Overview</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool WaitNamedPipeA(string lpNamedPipeName, uint nTimeOut);

        /// <summary>
        ///Runs the specified application.
        /// </summary>
        /// <param name="lpCmdLine">The command line (file name plus optional parameters) for the application to be executed. If the name of the executable file in the lpCmdLine parameter does not contain a directory path, the system searches for the executable file in this sequence:</param>
        /// <param name="uCmdShow">The display options. For a list of the acceptable values, see the description of the nCmdShow parameter of the ShowWindow function.If the function succeeds, the return value is greater than 31.If the function fails, the return value is one of the following error values.The WinExec function returns when the started process calls the GetMessage function or a time-out limit is reached. To avoid waiting for the time out delay, call the GetMessage function as soon as possible in any process started by a call to WinExec.If a malicious user were to create an application called "Program.exe" on a system, any program that incorrectly calls WinExec using the Program Files directory will run this application instead of the intended application.To avoid this problem, use CreateProcess rather than WinExec. However, if you must use WinExec for legacy reasons, make sure the application name is enclosed in quotation marks as shown in the example below.CreateProcess</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int WinExec(string lpCmdLine, int uCmdShow);

        /// <summary>
        ///Retrieves a descriptor table entry for the specified selector and WOW64 thread.
        /// </summary>
        /// <param name="hThread">A handle to the thread containing the specified selector. The handle must have been created with THREAD_QUERY_INFORMATION access to the thread. For more information, see Thread Security and Access Rights.</param>
        /// <param name="dwSelector">The global or local selector value to look up in the thread's descriptor tables.</param>
        /// <param name="lpSelectorEntry"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool Wow64GetThreadSelectorEntry(IntPtr hThread, uint dwSelector, out int lpSelectorEntry);

        /// <summary>
        ///Restores (import) encrypted files. This is one of a group of Encrypted File System (EFS) functions that is intended to implement backup and restore functionality, while maintaining files in their encrypted state.
        /// </summary>
        /// <param name="pfImportCallback">A pointer to the import callback function. The system calls the callback function multiple times, each time passing a buffer that will be filled by the callback function with a portion of backed-up file's data. When the callback function signals that the entire file has been processed, it tells the system that the restore operation is finished. For more information, see ImportCallback.</param>
        /// <param name="pvContext">A pointer to a system-defined context block. The context block is returned by the OpenEncryptedFileRaw function. Do not modify it.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, it returns a nonzero error code defined in WinError.h. You can use FormatMessage with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic text description of the error.The file being restored is not decrypted; it is restored in its encrypted state.To back up an encrypted file, call OpenEncryptedFileRaw to open the file. Then call ReadEncryptedFileRaw, passing it the address of an application-defined export callback function. The system calls this callback function multiple times until the entire file's contents have been read and backed up. When the backup is complete, call CloseEncryptedFileRaw to free resources and close the file. See ExportCallback for details about how to declare the export callback function.To restore an encrypted file, call OpenEncryptedFileRaw, specifying CREATE_FOR_IMPORT in the ulFlags parameter. Then call WriteEncryptedFileRaw, passing it the address of an application-defined import callback function. The system calls this callback function multiple times until the entire file's contents have been read and restored. When the restore is complete, call CloseEncryptedFileRaw to free resources and close the file. See ImportCallback for details about how to declare the export callback function.If the file is a sparse file that was backed up from a volume with a smaller sparse allocation unit size than the volume it is being restored to, the sparse blocks in the middle of the file may not properly align with the larger blocks and the function call would fail and set an ERROR_INVALID_PARAMETER last error code. The sparse allocation unit size is either 16 clusters or 64 KB, whichever is smaller.This function is intended for restoring only encrypted files; see BackupWrite for restoring unencrypted files.In Windows 8, Windows Server 2012, and later, this function is supported by the following technologies.SMB 3.0 does not support EFS on shares with continuous availability capability.BackupWriteCloseEncryptedFileRawFile EncryptionFile Management FunctionsImportCallbackOpenEncryptedFileRawReadEncryptedFileRaw</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint WriteEncryptedFileRaw(int pfImportCallback, IntPtr pvContext);

        /// <summary>
        ///Replaces the keys and values for the specified section in an initialization file.
        /// </summary>
        /// <param name="lpAppName">The name of the section in which data is written. This section name is typically the name of the calling application.</param>
        /// <param name="lpString">The new key names and associated values that are to be written to the named section. This string is limited to 65,535 bytes.</param>
        /// <param name="lpFileName">The name of the initialization file. If this parameter does not contain a full path for the file, the function searches the Windows directory for the file. If the file does not exist and lpFileName does not contain a full path, the function creates the file in the Windows directory.If the file exists and was created using Unicode characters, the function writes Unicode characters to the file. Otherwise, the function creates a file using ANSI characters.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The data in the buffer pointed to by the lpString parameter consists of one or more null-terminated strings, followed by a final null character. Each string has the following form:key=stringThe WritePrivateProfileSection function is not case-sensitive; the string pointed to by the lpAppName parameter can be a combination of uppercase and lowercase letters.If no section name matches the string pointed to by the lpAppName parameter, WritePrivateProfileSection creates the section at the end of the specified initialization file and initializes the new section with the specified key name and value pairs.WritePrivateProfileSection deletes the existing keys and values for the named section and inserts the key names and values in the buffer pointed to by the lpString parameter. The function does not attempt to correlate old and new key names; if the new names appear in a different order from the old names, any comments associated with preexisting keys and values in the initialization file will probably be associated with incorrect keys and values.This operation is atomic; no operations that read from or write to the specified initialization file are allowed while the information is being written.The system keeps a cached version of the most recent registry file mapping to improve performance. If all parameters are NULL, the function flushes the cache. While the system is editing the cached version of the file, processes that edit the file itself will use the original file until the cache has been cleared.The system maps most .ini file references to the registry, using the mapping defined under the following registry key:This mapping is likely if an application modifies system-component initialization files, such as Control.ini, System.ini, and Winfile.ini. In this case, the function writes information to the registry, not to the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:GetPrivateProfileSectionRegCreateKeyExRegSetValueExWriteProfileSection</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool WritePrivateProfileSectionA(string lpAppName, string lpString, string lpFileName);

        /// <summary>
        ///Replaces the keys and values for the specified section in an initialization file.
        /// </summary>
        /// <param name="lpAppName">The name of the section in which data is written. This section name is typically the name of the calling application.</param>
        /// <param name="lpString">The new key names and associated values that are to be written to the named section. This string is limited to 65,535 bytes.</param>
        /// <param name="lpFileName">The name of the initialization file. If this parameter does not contain a full path for the file, the function searches the Windows directory for the file. If the file does not exist and lpFileName does not contain a full path, the function creates the file in the Windows directory.If the file exists and was created using Unicode characters, the function writes Unicode characters to the file. Otherwise, the function creates a file using ANSI characters.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.The data in the buffer pointed to by the lpString parameter consists of one or more null-terminated strings, followed by a final null character. Each string has the following form:key=stringThe WritePrivateProfileSection function is not case-sensitive; the string pointed to by the lpAppName parameter can be a combination of uppercase and lowercase letters.If no section name matches the string pointed to by the lpAppName parameter, WritePrivateProfileSection creates the section at the end of the specified initialization file and initializes the new section with the specified key name and value pairs.WritePrivateProfileSection deletes the existing keys and values for the named section and inserts the key names and values in the buffer pointed to by the lpString parameter. The function does not attempt to correlate old and new key names; if the new names appear in a different order from the old names, any comments associated with preexisting keys and values in the initialization file will probably be associated with incorrect keys and values.This operation is atomic; no operations that read from or write to the specified initialization file are allowed while the information is being written.The system keeps a cached version of the most recent registry file mapping to improve performance. If all parameters are NULL, the function flushes the cache. While the system is editing the cached version of the file, processes that edit the file itself will use the original file until the cache has been cleared.The system maps most .ini file references to the registry, using the mapping defined under the following registry key:This mapping is likely if an application modifies system-component initialization files, such as Control.ini, System.ini, and Winfile.ini. In this case, the function writes information to the registry, not to the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:GetPrivateProfileSectionRegCreateKeyExRegSetValueExWriteProfileSection</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool WritePrivateProfileSectionW(string lpAppName, string lpString, string lpFileName);

        /// <summary>
        ///Copies a string into the specified section of an initialization file.
        /// </summary>
        /// <param name="lpAppName">The name of the section to which the string will be copied. If the section does not exist, it is created. The name of the section is case-independent; the string can be any combination of uppercase and lowercase letters.</param>
        /// <param name="lpKeyName">The name of the key to be associated with a string. If the key does not exist in the specified section, it is created. If this parameter is NULL, the entire section, including all entries within the section, is deleted.</param>
        /// <param name="lpString">A null-terminated string to be written to the file. If this parameter is NULL, the key pointed to by the lpKeyName parameter is deleted.</param>
        /// <param name="lpFileName">The name of the initialization file.If the file was created using Unicode characters, the function writes Unicode characters to the file. Otherwise, the function writes ANSI characters.If the function successfully copies the string to the initialization file, the return value is nonzero.If the function fails, or if it flushes the cached version of the most recently accessed initialization file, the return value is zero. To get extended error information, call GetLastError.A section in the initialization file must have the following form:If the lpFileName parameter does not contain a full path and file name for the file, WritePrivateProfileString searches the Windows directory for the file. If the file does not exist, this function creates the file in the Windows directory.If lpFileName contains a full path and file name and the file does not exist, WritePrivateProfileString creates the file. The specified directory must already exist.The system keeps a cached version of the most recent registry file mapping to improve performance. If all parameters are NULL, the function flushes the cache. While the system is editing the cached version of the file, processes that edit the file itself will use the original file until the cache has been cleared.The system maps most .ini file references to the registry, using the mapping defined under the following registry key:This mapping is likely if an application modifies system-component initialization files, such as Control.ini, System.ini, and Winfile.ini. In this case, the function writes information to the registry, not to the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:The following sample code illustrates the preceding guidelines and is based on several assumptions:GetPrivateProfileStringWriteProfileString</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool WritePrivateProfileStringA(string lpAppName, string lpKeyName, string lpString, string lpFileName);

        /// <summary>
        ///Copies a string into the specified section of an initialization file.
        /// </summary>
        /// <param name="lpAppName">The name of the section to which the string will be copied. If the section does not exist, it is created. The name of the section is case-independent; the string can be any combination of uppercase and lowercase letters.</param>
        /// <param name="lpKeyName">The name of the key to be associated with a string. If the key does not exist in the specified section, it is created. If this parameter is NULL, the entire section, including all entries within the section, is deleted.</param>
        /// <param name="lpString">A null-terminated string to be written to the file. If this parameter is NULL, the key pointed to by the lpKeyName parameter is deleted.</param>
        /// <param name="lpFileName">The name of the initialization file.If the file was created using Unicode characters, the function writes Unicode characters to the file. Otherwise, the function writes ANSI characters.If the function successfully copies the string to the initialization file, the return value is nonzero.If the function fails, or if it flushes the cached version of the most recently accessed initialization file, the return value is zero. To get extended error information, call GetLastError.A section in the initialization file must have the following form:If the lpFileName parameter does not contain a full path and file name for the file, WritePrivateProfileString searches the Windows directory for the file. If the file does not exist, this function creates the file in the Windows directory.If lpFileName contains a full path and file name and the file does not exist, WritePrivateProfileString creates the file. The specified directory must already exist.The system keeps a cached version of the most recent registry file mapping to improve performance. If all parameters are NULL, the function flushes the cache. While the system is editing the cached version of the file, processes that edit the file itself will use the original file until the cache has been cleared.The system maps most .ini file references to the registry, using the mapping defined under the following registry key:This mapping is likely if an application modifies system-component initialization files, such as Control.ini, System.ini, and Winfile.ini. In this case, the function writes information to the registry, not to the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:The following sample code illustrates the preceding guidelines and is based on several assumptions:GetPrivateProfileStringWriteProfileString</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool WritePrivateProfileStringW(string lpAppName, string lpKeyName, string lpString, string lpFileName);

        /// <summary>
        ///Copies data into a key in the specified section of an initialization file. As it copies the data, the function calculates a checksum and appends it to the end of the data. The GetPrivateProfileStruct function uses the checksum to ensure the integrity of the data.
        /// </summary>
        /// <param name="lpszSection">The name of the section to which the string will be copied. If the section does not exist, it is created. The name of the section is case independent, the string can be any combination of uppercase and lowercase letters.</param>
        /// <param name="lpszKey">The name of the key to be associated with a string. If the key does not exist in the specified section, it is created. If this parameter is NULL, the entire section, including all keys and entries within the section, is deleted.</param>
        /// <param name="lpStruct">The data to be copied. If this parameter is NULL, the key is deleted.</param>
        /// <param name="uSizeStruct">The size of the buffer pointed to by the lpStruct parameter, in bytes.</param>
        /// <param name="szFile">The name of the initialization file. If this parameter is NULL, the information is copied into the Win.ini file.If the file was created using Unicode characters, the function writes Unicode characters to the file. Otherwise, the function writes ANSI characters.If the function successfully copies the string to the initialization file, the return value is nonzero.If the function fails, or if it flushes the cached version of the most recently accessed initialization file, the return value is zero. To get extended error information, call GetLastError.A section in the initialization file must have the following form:If the szFile parameter does not contain a full path and file name for the file, WritePrivateProfileString searches the Windows directory for the file. If the file does not exist, this function creates the file in the Windows directory.If szFile contains a full path and file name and the file does not exist, WriteProfileString creates the file. The specified directory must already exist.The system keeps a cached version of the most recent registry file mapping to improve performance. If all parameters are NULL, the function flushes the cache. While the system is editing the cached version of the file, processes that edit the file itself will use the original file until the cache has been cleared.The system maps most .ini file references to the registry, using the mapping defined under the following registry key:This mapping is likely if an application modifies system-component initialization files, such as Control.ini, System.ini, and Winfile.ini. In this case, the function writes information to the registry, not to the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:GetPrivateProfileStringWriteProfileString</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool WritePrivateProfileStructA(string lpszSection, string lpszKey, IntPtr lpStruct, int uSizeStruct, string szFile);

        /// <summary>
        ///Copies data into a key in the specified section of an initialization file. As it copies the data, the function calculates a checksum and appends it to the end of the data. The GetPrivateProfileStruct function uses the checksum to ensure the integrity of the data.
        /// </summary>
        /// <param name="lpszSection">The name of the section to which the struct data will be copied. If the section does not exist, it is created. The name of the section is case independent.</param>
        /// <param name="lpszKey">The name of the key to be associated with a struct. If the key does not exist in the specified section, it is created. If this parameter is NULL, the entire section, including all keys and entries within the section, is deleted.</param>
        /// <param name="lpStruct">The data to be copied. If this parameter is NULL, the key is deleted.</param>
        /// <param name="uSizeStruct">The size of the buffer pointed to by the lpStruct parameter, in bytes.</param>
        /// <param name="szFile">The name of the initialization file. If this parameter is NULL, the information is copied into the Win.ini file.If the file was created using Unicode characters, the function writes Unicode characters to the file. Otherwise, the function writes ANSI characters.If the function successfully copies the struct to the initialization file, the return value is nonzero.If the function fails, or if it flushes the cached version of the most recently accessed initialization file, the return value is zero. To get extended error information, call GetLastError.A section in the initialization file must have the following form:If the szFile parameter does not contain a full path and file name for the file, WritePrivateProfileString searches the Windows directory for the file. If the file does not exist, this function creates the file in the Windows directory.If szFile contains a full path and file name and the file does not exist, WriteProfileString creates the file. The specified directory must already exist.The system keeps a cached version of the most recent registry file mapping to improve performance. If all parameters are NULL, the function flushes the cache. While the system is editing the cached version of the file, processes that edit the file itself will use the original file until the cache has been cleared.The system maps most .ini file references to the registry, using the mapping defined under the following registry key:This mapping is likely if an application modifies system-component initialization files, such as Control.ini, System.ini, and Winfile.ini. In this case, the function writes information to the registry, not to the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:GetPrivateProfileStringWriteProfileString</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool WritePrivateProfileStructW(string lpszSection, string lpszKey, IntPtr lpStruct, int uSizeStruct, string szFile);

        /// <summary>
        ///Replaces the contents of the specified section in the Win.ini file with specified keys and values. If Win.ini uses Unicode characters, the function writes Unicode characters to the file. Otherwise, the function writes ANSI characters.
        /// </summary>
        /// <param name="lpAppName">The name of the section. This section name is typically the name of the calling application.</param>
        /// <param name="lpString">The new key names and associated values that are to be written to the named section. This string is limited to 65,535 bytes.If the file exists and was created using Unicode characters, the function writes Unicode characters to the file. Otherwise, the function creates a file using ANSI characters.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.Keys and values in the lpString buffer consist of one or more null-terminated strings, followed by a final null character. Each string has the following form: key=string.The WriteProfileSection function is not case-sensitive; the strings can be a combination of uppercase and lowercase letters.WriteProfileSection deletes the existing keys and values for the named section and inserts the key names and values in the buffer pointed to by lpString. The function does not attempt to correlate old and new key names; if the new names appear in a different order from the old names, any comments associated with preexisting keys and values in the initialization file will probably be associated with incorrect keys and values.This operation is atomic; no other operations that read from or write to the initialization file are allowed while the information is being written.The system keeps a cached version of the most recent registry file mapping to improve performance. If all parameters are NULL, the function flushes the cache. While the system is editing the cached version of the file, processes that edit the file itself will use the original file until the cache has been cleared.The system maps most .ini file references to the registry, using the mapping defined under the following registry key:When the operation has been mapped, the WriteProfileSection function writes information to the registry, not to the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:GetProfileSectionWritePrivateProfileSection</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool WriteProfileSectionA(string lpAppName, string lpString);

        /// <summary>
        ///Replaces the contents of the specified section in the Win.ini file with specified keys and values. If Win.ini uses Unicode characters, the function writes Unicode characters to the file. Otherwise, the function writes ANSI characters.
        /// </summary>
        /// <param name="lpAppName">The name of the section. This section name is typically the name of the calling application.</param>
        /// <param name="lpString">The new key names and associated values that are to be written to the named section. This string is limited to 65,535 bytes.If the file exists and was created using Unicode characters, the function writes Unicode characters to the file. Otherwise, the function creates a file using ANSI characters.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.Keys and values in the lpString buffer consist of one or more null-terminated strings, followed by a final null character. Each string has the following form: key=string.The WriteProfileSection function is not case-sensitive; the strings can be a combination of uppercase and lowercase letters.WriteProfileSection deletes the existing keys and values for the named section and inserts the key names and values in the buffer pointed to by lpString. The function does not attempt to correlate old and new key names; if the new names appear in a different order from the old names, any comments associated with preexisting keys and values in the initialization file will probably be associated with incorrect keys and values.This operation is atomic; no other operations that read from or write to the initialization file are allowed while the information is being written.The system keeps a cached version of the most recent registry file mapping to improve performance. If all parameters are NULL, the function flushes the cache. While the system is editing the cached version of the file, processes that edit the file itself will use the original file until the cache has been cleared.The system maps most .ini file references to the registry, using the mapping defined under the following registry key:When the operation has been mapped, the WriteProfileSection function writes information to the registry, not to the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:GetProfileSectionWritePrivateProfileSection</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool WriteProfileSectionW(string lpAppName, string lpString);

        /// <summary>
        ///Copies a string into the specified section of the Win.ini file. If Win.ini uses Unicode characters, the function writes Unicode characters to the file. Otherwise, the function writes ANSI characters.
        /// </summary>
        /// <param name="lpAppName">The section to which the string is to be copied. If the section does not exist, it is created. The name of the section is not case-sensitive; the string can be any combination of uppercase and lowercase letters.</param>
        /// <param name="lpKeyName">The key to be associated with the string. If the key does not exist in the specified section, it is created. If this parameter is NULL, the entire section, including all entries in the section, is deleted.</param>
        /// <param name="lpString">A null-terminated string to be written to the file. If this parameter is NULL, the key pointed to by the lpKeyName parameter is deleted.If the function successfully copies the string to the Win.ini file, the return value is nonzero.If the function fails, or if it flushes the cached version of Win.ini, the return value is zero. To get extended error information, call GetLastError.A section in the Win.ini file must have the following form: key=string.The system keeps a cached version of the most recent registry file mapping to improve performance. If all parameters are NULL, the function flushes the cache. While the system is editing the cached version of the file, processes that edit the file itself will use the original file until the cache has been cleared.The system maps most .ini file references to the registry, using the mapping defined under the following registry key:When the operation has been mapped, the WriteProfileString function writes information to the registry, not to the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:GetProfileStringWritePrivateProfileString</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool WriteProfileStringA(string lpAppName, string lpKeyName, string lpString);

        /// <summary>
        ///Copies a string into the specified section of the Win.ini file. If Win.ini uses Unicode characters, the function writes Unicode characters to the file. Otherwise, the function writes ANSI characters.
        /// </summary>
        /// <param name="lpAppName">The section to which the string is to be copied. If the section does not exist, it is created. The name of the section is not case-sensitive; the string can be any combination of uppercase and lowercase letters.</param>
        /// <param name="lpKeyName">The key to be associated with the string. If the key does not exist in the specified section, it is created. If this parameter is NULL, the entire section, including all entries in the section, is deleted.</param>
        /// <param name="lpString">A null-terminated string to be written to the file. If this parameter is NULL, the key pointed to by the lpKeyName parameter is deleted.If the function successfully copies the string to the Win.ini file, the return value is nonzero.If the function fails, or if it flushes the cached version of Win.ini, the return value is zero. To get extended error information, call GetLastError.A section in the Win.ini file must have the following form: key=string.The system keeps a cached version of the most recent registry file mapping to improve performance. If all parameters are NULL, the function flushes the cache. While the system is editing the cached version of the file, processes that edit the file itself will use the original file until the cache has been cleared.The system maps most .ini file references to the registry, using the mapping defined under the following registry key:When the operation has been mapped, the WriteProfileString function writes information to the registry, not to the initialization file; the change in the storage location has no effect on the function's behavior.The profile functions use the following steps to locate initialization information:GetProfileStringWritePrivateProfileString</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool WriteProfileStringW(string lpAppName, string lpKeyName, string lpString);

        /// <summary>
        ///The WriteTapemark function writes a specified number of filemarks, setmarks, short filemarks, or long filemarks to a tape device. These tapemarks divide a tape partition into smaller areas.
        /// </summary>
        /// <param name="hDevice">Handle to the device on which to write tapemarks. This handle is created by using the CreateFile function.</param>
        /// <param name="dwTapemarkType">Type of tapemarks to write. This parameter can be one of the following values.</param>
        /// <param name="dwTapemarkCount">Number of tapemarks to write.</param>
        /// <param name="bImmediate">If this parameter is TRUE, the function returns immediately; if it is FALSE, the function does not return until the operation has been completed.If the function succeeds, the return value is NO_ERROR.If the function fails, it can return one of the following error codes.Filemarks, setmarks, short filemarks, and long filemarks are special recorded elements that denote the linear organization of the tape. None of these marks contain user data. Filemarks are the most general marks; setmarks provide a hierarchy not available with filemarks.A short filemark contains a short erase gap that cannot be overwritten unless the write operation is performed from the beginning of the partition or from an earlier long filemark.A long filemark contains a long erase gap that allows an application to position the tape at the beginning of the filemark and to overwrite the filemark and the erase gap.CreateFile</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint WriteTapemark(IntPtr hDevice, uint dwTapemarkType, uint dwTapemarkCount, bool bImmediate);

        /// <summary>
        ///Retrieves the session identifier of the console session. The console session is the session that is currently attached to the physical console. Note that it is not necessary that Remote Desktop Services be running for this function to succeed.
        /// </summary>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint WTSGetActiveConsoleSessionId();

        /// <summary>
        ///The ZombifyActCtx function deactivates the specified activation context, but does not deallocate it.
        /// </summary>
        /// <param name="hActCtx">Handle to the activation context that is to be deactivated.If the function succeeds, it returns TRUE. If a null handle is passed in the hActCtx parameter, NULL_INVALID_PARAMETER will be returned. Otherwise, it returns FALSE.This function sets errors that can be retrieved by calling GetLastError. For an example, see Retrieving the Last-Error Code. For a complete list of error codes, see System Error Codes.This function is intended for use in debugging threads using activation contexts. If the activation context deactivated by this function is subsequently accessed, the access fails and an assertion failure is shown in the debugger.ACTCTX</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ZombifyActCtx(IntPtr hActCtx);


    }
}