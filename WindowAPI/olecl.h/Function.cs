using System.Runtime.InteropServices;
namespace WindowAPI.Prnasnot.h
{
    public static class Functions
    {

        /// <summary>
        ///Instructs an in-process server to create its registry entries for all classes supported in this server module.
        /// </summary>

        [DllImport("Ole32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr /*UKNOW:NEED_FIX*/ DllRegisterServer();

        /// <summary>
        ///Instructs an in-process server to remove only those entries created through DllRegisterServer.
        /// </summary>

        [DllImport("Ole32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr /*UKNOW:NEED_FIX*/ DllUnregisterServer();

        /// <summary>
        ///Creates and initializes a standard font object using an initial description of the font's properties in a FONTDESC structure. The function returns an interface pointer to the new font object specified by caller in the riid parameter. A QueryInterface call is part of this call. The caller is responsible for calling Release through the interface pointer returned.
        /// </summary>
        /// <param name="lpFontDesc">Address of a caller-allocated, FONTDESC structure containing the initial state of the font. This value must not be NULL.</param>
        /// <param name="riid">Reference to the identifier of the interface describing the type of interface pointer to return in lplpvObj.</param>

        [DllImport("OleAut32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr /*UKNOW:NEED_FIX*/ OleCreateFontIndirect(IntPtr /*UKNOW:NEED_FIX*/ lpFontDesc, IntPtr /*UKNOW:NEED_FIX*/ riid, out IntPtr lplpvObj);

        /// <summary>
        ///Creates a new picture object initialized according to a PICTDESC structure.
        /// </summary>
        /// <param name="lpPictDesc">Pointer to a caller-allocated structure containing the initial state of the picture. The specified structure can be NULL to create an uninitialized object, in the event the picture needs to initialize via IPersistStream::Load.</param>
        /// <param name="riid">Reference to the identifier of the interface describing the type of interface pointer to return in lplpvObj.</param>
        /// <param name="fOwn">If TRUE, the picture object is to destroy its picture when the object is destroyed. If FALSE, the caller is responsible for destroying the picture.</param>

        [DllImport("OleAut32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr /*UKNOW:NEED_FIX*/ OleCreatePictureIndirect(IntPtr /*UKNOW:NEED_FIX*/ lpPictDesc, IntPtr /*UKNOW:NEED_FIX*/ riid, bool fOwn, out IntPtr lplpvObj);

        /// <summary>
        ///Invokes a new property frame, that is, a property sheet dialog box, whose parent is hwndOwner, where the dialog is positioned at the point (x,y) in the parent window and has the caption lpszCaption.
        /// </summary>
        /// <param name="hwndOwner">Handle to the parent window of the resulting property sheet dialog box.</param>
        /// <param name="x">Reserved. Horizontal position for the dialog box relative to hwndOwner.</param>
        /// <param name="y">Reserved. Vertical position for the dialog box relative to hwndOwner.</param>
        /// <param name="lpszCaption">Pointer to the string used for the caption of the dialog box.</param>
        /// <param name="cObjects">Number of object pointers passed in ppUnk.</param>
        /// <param name="ppUnk">An array of IUnknown pointers on the objects for which this property sheet is being invoked. The number of elements in the array is specified by cObjects. These pointers are passed to each property page through IPropertyPage::SetObjects.</param>
        /// <param name="cPages">Number of property pages specified in pPageCIsID.</param>
        /// <param name="pPageClsID">Array of size cPages containing the CLSIDs of each property page to display in the property sheet.</param>
        /// <param name="lcid">Locale identifier to use for the property sheet. Property pages can retrieve this identifier through IPropertyPageSite::GetLocaleID.</param>
        /// <param name="dwReserved">Reserved for future use; must be zero.</param>
        /// <param name="pvReserved">Reserved for future use; must be NULL.This function supports the standard return values E_INVALIDARG, E_OUTOFMEMORY, and E_UNEXPECTED, as well as the following:The property pages to be displayed are identified with pPageClsID, which is an array of cPages CLSID values. The objects that are affected by this property sheet are identified in ppUnk, an array of size cObjects containing IUnknown pointers.This function always creates a modal dialog box and does not return until the dialog box is closed.IPropertyPage::SetObjectsIPropertyPageSite::GetLocaleID</param>

        [DllImport("OleAut32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr /*UKNOW:NEED_FIX*/ OleCreatePropertyFrame(IntPtr hwndOwner, uint x, uint y, IntPtr /*UKNOW:NEED_FIX*/ lpszCaption, uint cObjects, IntPtr /*UKNOW:NEED_FIX*/ ppUnk, uint cPages, IntPtr /*UKNOW:NEED_FIX*/ pPageClsID, IntPtr /*UKNOW:NEED_FIX*/ lcid, uint dwReserved, IntPtr pvReserved);

        /// <summary>
        ///Creates a property frame, that is, a property sheet dialog box, based on a structure (OCPFIPARAMS) that contains the parameters, rather than specifying separate parameters as when calling OleCreatePropertyFrame.
        /// </summary>
        /// <param name="lpParams">Pointer to the caller-allocated structure containing the creation parameters for the dialog box.This function supports the standard return values E_INVALIDARG, E_OUTOFMEMORY, and E_UNEXPECTED, as well as the following:Besides cbStructSize (the size of the structure) and dispIDInitialProperty, all of the members of the OCPFIPARAMS structure have the same semantics as the parameters for OleCreatePropertyFrame. When dispIDInitialProperty is DISPID_UNKNOWN, the behavior of the two functions is identical.Working in conjunction with IPerPropertyBrowsing and IPropertyPage2, dispIDInitialProperty allows the caller to specify which single property should be highlighted when the dialog box is made visible. This feature is not available when using OleCreatePropertyFrame. To determine the page and property to show initially, the property frame will do the following:OCPFIPARAMSOleCreatePropertyFrame</param>

        [DllImport("OleAut32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr /*UKNOW:NEED_FIX*/ OleCreatePropertyFrameIndirect(IntPtr /*UKNOW:NEED_FIX*/ lpParams);

        /// <summary>
        ///Converts an icon to a cursor.
        /// </summary>
        /// <param name="hinstExe">This parameter is ignored.</param>
        /// <param name="hIcon">A handle to the icon to be converted.The function returns a handle to the new cursor object. The caller is responsible for deleting this cursor with the DestroyCursor function. If the conversion could not be completed, the return value is NULL.This function calls the CopyCursor function.</param>

        [DllImport("Oleaut32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void OleIconToCursor(IntPtr hinstExe, IntPtr hIcon);

        /// <summary>
        ///Creates a new picture object and initializes it from the contents of a stream. This is equivalent to calling OleCreatePictureIndirect with NULL as the first parameter, followed by a call to IPersistStream::Load.
        /// </summary>
        /// <param name="lpstream">Pointer to the stream that contains the picture's data.</param>
        /// <param name="lSize">The number of bytes that should be read from the stream, or zero if the entire stream should be read.</param>
        /// <param name="fRunmode">The opposite of the initial value of the KeepOriginalFormat property. If TRUE, KeepOriginalFormat is set to FALSE and vice-versa.</param>
        /// <param name="riid">Reference to the identifier of the interface describing the type of interface pointer to return in ppvObj.</param>

        [DllImport("OleAut32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr /*UKNOW:NEED_FIX*/ OleLoadPicture(IntPtr /*UKNOW:NEED_FIX*/ lpstream, int lSize, bool fRunmode, IntPtr /*UKNOW:NEED_FIX*/ riid, out IntPtr lplpvObj);

        /// <summary>
        ///Creates a new picture object and initializes it from the contents of a stream. This is equivalent to calling OleCreatePictureIndirect with NULL as the first parameter, followed by a call to IPersistStream::Load.
        /// </summary>
        /// <param name="lpstream">Pointer to the stream that contains the picture's data.</param>
        /// <param name="lSize">The number of bytes that should be read from the stream, or zero if the entire stream should be read.</param>
        /// <param name="fRunmode">The opposite of the initial value of the KeepOriginalFormat property. If TRUE, KeepOriginalFormat is set to FALSE and vice versa.</param>
        /// <param name="riid">Reference to the identifier of the interface describing the type of interface pointer to return in ppvObj.</param>
        /// <param name="xSizeDesired">Desired width of icon or cursor. Valid values are 16, 32, and 48. Pass LP_DEFAULT to both size parameters to use system default size.</param>
        /// <param name="ySizeDesired">Desired height of icon or cursor. Valid values are 16, 32, and 48. Pass LP_DEFAULT to both size parameters to use system default size.</param>
        /// <param name="dwFlags">Desired color depth for icon or cursor. Values are LP_MONOCHROME (monochrome), LP_VGACOLOR (16 colors), LP_COLOR (256 colors), or LP_DEFAULT (selects best depth for current display).</param>

        [DllImport("OleAut32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr /*UKNOW:NEED_FIX*/ OleLoadPictureEx(IntPtr /*UKNOW:NEED_FIX*/ lpstream, int lSize, bool fRunmode, IntPtr /*UKNOW:NEED_FIX*/ riid, uint xSizeDesired, uint ySizeDesired, uint dwFlags, out IntPtr lplpvObj);

        /// <summary>
        ///Creates an IPictureDisp object from a picture file on disk.
        /// </summary>
        /// <param name="varFileName">The path and name of the picture file to load.</param>

        [DllImport("OleAut32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr /*UKNOW:NEED_FIX*/ OleLoadPictureFile(object varFileName, out IntPtr lplpdispPicture);

        /// <summary>
        ///Loads a picture from a file.
        /// </summary>
        /// <param name="varFileName">The path and name of the picture file to load.</param>
        /// <param name="xSizeDesired">The desired length for the picture to be displayed.</param>
        /// <param name="ySizeDesired">The desired height for the picture to be displayed.</param>
        /// <param name="dwFlags">The desired color depth for the icon or cursor. Together with the desired size it is used to select the best matching image.</param>

        [DllImport("OleAut32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr /*UKNOW:NEED_FIX*/ OleLoadPictureFileEx(object varFileName, uint xSizeDesired, uint ySizeDesired, uint dwFlags, out IntPtr lplpdispPicture);

        /// <summary>
        ///Creates a new picture object and initializes it from the contents of a stream. This is equivalent to calling OleCreatePictureIndirect(NULL, ...) followed by IPersistStream::Load.
        /// </summary>
        /// <param name="szURLorPath">The path or URL to the file you want to open.</param>
        /// <param name="punkCaller">Points to IUnknown for COM aggregation.</param>
        /// <param name="dwReserved">Reserved.</param>
        /// <param name="clrReserved">The color you want to reserve to be transparent.</param>
        /// <param name="riid">Reference to the identifier of the interface describing the type of interface pointer to return in ppvRet.</param>

        [DllImport("OleAut32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr /*UKNOW:NEED_FIX*/ OleLoadPicturePath(IntPtr /*UKNOW:NEED_FIX*/ szURLorPath, IntPtr /*UKNOW:NEED_FIX*/ punkCaller, uint dwReserved, IntPtr /*UKNOW:NEED_FIX*/ clrReserved, IntPtr /*UKNOW:NEED_FIX*/ riid, out IntPtr ppvRet);

        /// <summary>
        ///Saves a picture to a file.
        /// </summary>
        /// <param name="lpdispPicture">Points to the IPictureDisp picture object.</param>
        /// <param name="bstrFileName">The name of the file to save the picture to.This method returns standard COM error codes in addition to the following values.</param>

        [DllImport("OleAut32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr /*UKNOW:NEED_FIX*/ OleSavePictureFile(IntPtr lpdispPicture, IntPtr /*UKNOW:NEED_FIX*/ bstrFileName);

        /// <summary>
        ///Converts an OLE_COLOR type to a COLORREF.
        /// </summary>
        /// <param name="clr">The OLE color to be converted into a COLORREF.</param>
        /// <param name="hpal">Palette used as a basis for the conversion.</param>

        [DllImport("OleAut32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr /*UKNOW:NEED_FIX*/ OleTranslateColor(IntPtr /*UKNOW:NEED_FIX*/ clr, IntPtr /*UKNOW:NEED_FIX*/ hpal, out IntPtr /*UKNOW:NEED_FIX*/ lpcolorref);


    }
}