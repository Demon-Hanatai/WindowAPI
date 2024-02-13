namespace WindowAPI.wingdi
{
    public static class Functions
    {

        /// <summary>
        ///The AbortDoc function stops the current print job and erases everything drawn since the last call to the StartDoc function.
        /// </summary>
        /// <param name="hdc">Handle to the device context for the print job.If the function succeeds, the return value is greater than zero.If the function fails, the return value is SP_ERROR.If Print Manager was used to start the print job, calling AbortDoc erases the entire spool job, so that the printer receives nothing. If Print Manager was not used to start the print job, the data may already have been sent to the printer. In this case, the printer driver resets the printer (when possible) and ends the print job.EndDocPrint Spooler API FunctionsPrintingSetAbortProcStartDoc</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int AbortDoc(nint hdc);

        /// <summary>
        ///The AbortPath function closes and discards any paths in the specified device context.
        /// </summary>
        /// <param name="hdc">Handle to the device context from which a path will be discarded.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.If there is an open path bracket in the given device context, the path bracket is closed and the path is discarded. If there is a closed path in the device context, the path is discarded.BeginPathEndPathPath FunctionsPaths Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool AbortPath(nint hdc);

        /// <summary>
        ///The AddFontMemResourceEx function adds the font resource from a memory image to the system.
        /// </summary>
        /// <param name="pFileView">A pointer to a font resource.</param>
        /// <param name="cjSize">The number of bytes in the font resource that is pointed to by pbFont.</param>
        /// <param name="pvResrved">Reserved. Must be 0.</param>
        /// <param name="pNumFonts">A pointer to a variable that specifies the number of fonts installed.If the function succeeds, the return value specifies the handle to the font added. This handle uniquely identifies the fonts that were installed on the system. If the function fails, the return value is zero. No extended error information is available.This function allows an application to get a font that is embedded in a document or a webpage. A font that is added by AddFontMemResourceEx is always private to the process that made the call and is not enumerable.A memory image can contain more than one font. When this function succeeds, pcFonts is a pointer to a DWORD whose value is the number of fonts added to the system as a result of this call. For example, this number could be 2 for the vertical and horizontal faces of an Asian font.When the function succeeds, the caller of this function can free the memory pointed to by pbFont because the system has made its own copy of the memory. To remove the fonts that were installed, call RemoveFontMemResourceEx. However, when the process goes away, the system will unload the fonts even if the process did not call RemoveFontMemResource.DESIGNVECTORFont and Text FunctionsFonts and Text OverviewRemoveFontMemResourceExSendMessage</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint AddFontMemResourceEx(nint pFileView, uint cjSize, nint pvResrved, uint pNumFonts);

        /// <summary>
        ///The AddFontResource function adds the font resource from the specified file to the system font table. The font can subsequently be used for text output by any application.
        /// </summary>
        /// <param name="unnamedParam1">A pointer to a null-terminated character string that contains a valid font file name. This parameter can specify any of the following files.To add a font whose information comes from several resource files, have lpszFileName point to a string with the file names separated by a "|" --for example, abcxxxxx.pfm | abcxxxxx.pfb.If the function succeeds, the return value specifies the number of fonts added.If the function fails, the return value is zero. No extended error information is available.Any application that adds or removes fonts from the system font table should notify other windows of the change by sending a WM_FONTCHANGE message to all top-level windows in the operating system. The application should send this message by calling the SendMessage function and setting the hwnd parameter to HWND_BROADCAST.When an application no longer needs a font resource that it loaded by calling the AddFontResource function, it must remove that resource by calling the RemoveFontResource function.This function installs the font only for the current session. When the system restarts, the font will not be present. To have the font installed even after restarting the system, the font must be listed in the registry.A font listed in the registry and installed to a location other than the %windir%\fonts\ folder cannot be modified, deleted, or replaced as long as it is loaded in any session. In order to change one of these fonts, it must first be removed by calling RemoveFontResource, removed from the font registry (HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts), and the system restarted. After restarting the system, the font will no longer be loaded and can be changed.AddFontResourceExFont and Text FunctionsFonts and Text OverviewRemoveFontResourceSendMessage</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int AddFontResourceA(string unnamedParam1);

        /// <summary>
        ///The AddFontResourceEx function adds the font resource from the specified file to the system. Fonts added with the AddFontResourceEx function can be marked as private and not enumerable.
        /// </summary>
        /// <param name="name">A pointer to a null-terminated character string that contains a valid font file name. This parameter can specify any of the following files.To add a font whose information comes from several resource files, point lpszFileName to a string with the file names separated by a | --for example, abcxxxxx.pfm | abcxxxxx.pfb.</param>
        /// <param name="fl">The characteristics of the font to be added to the system. This parameter can be one of the following values.</param>
        /// <param name="res">Reserved. Must be zero.If the function succeeds, the return value specifies the number of fonts added.If the function fails, the return value is zero. No extended error information is available.This function allows a process to use fonts without allowing other processes access to the fonts.When an application no longer needs a font resource it loaded by calling the AddFontResourceEx function, it must remove the resource by calling the RemoveFontResourceEx function.This function installs the font only for the current session. When the system restarts, the font will not be present. To have the font installed even after restarting the system, the font must be listed in the registry.A font listed in the registry and installed to a location other than the %windir%\fonts\ folder cannot be modified, deleted, or replaced as long as it is loaded in any session. In order to change one of these fonts, it must first be removed by calling RemoveFontResource, removed from the font registry (HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts), and the system restarted. After restarting the system, the font will no longer be loaded and can be changed.Font and Text FunctionsFonts and Text OverviewRemoveFontResourceExSendMessage</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int AddFontResourceExA(string name, uint fl, nint res);

        /// <summary>
        ///The AddFontResourceEx function adds the font resource from the specified file to the system. Fonts added with the AddFontResourceEx function can be marked as private and not enumerable.
        /// </summary>
        /// <param name="name">A pointer to a null-terminated character string that contains a valid font file name. This parameter can specify any of the following files.To add a font whose information comes from several resource files, point lpszFileName to a string with the file names separated by a | --for example, abcxxxxx.pfm | abcxxxxx.pfb.</param>
        /// <param name="fl">The characteristics of the font to be added to the system. This parameter can be one of the following values.</param>
        /// <param name="res">Reserved. Must be zero.If the function succeeds, the return value specifies the number of fonts added.If the function fails, the return value is zero. No extended error information is available.This function allows a process to use fonts without allowing other processes access to the fonts.When an application no longer needs a font resource it loaded by calling the AddFontResourceEx function, it must remove the resource by calling the RemoveFontResourceEx function.This function installs the font only for the current session. When the system restarts, the font will not be present. To have the font installed even after restarting the system, the font must be listed in the registry.A font listed in the registry and installed to a location other than the %windir%\fonts\ folder cannot be modified, deleted, or replaced as long as it is loaded in any session. In order to change one of these fonts, it must first be removed by calling RemoveFontResource, removed from the font registry (HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts), and the system restarted. After restarting the system, the font will no longer be loaded and can be changed.Font and Text FunctionsFonts and Text OverviewRemoveFontResourceExSendMessage</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int AddFontResourceExW(string name, uint fl, nint res);

        /// <summary>
        ///The AddFontResource function adds the font resource from the specified file to the system font table. The font can subsequently be used for text output by any application.
        /// </summary>
        /// <param name="unnamedParam1">A pointer to a null-terminated character string that contains a valid font file name. This parameter can specify any of the following files.To add a font whose information comes from several resource files, have lpszFileName point to a string with the file names separated by a "|" --for example, abcxxxxx.pfm | abcxxxxx.pfb.If the function succeeds, the return value specifies the number of fonts added.If the function fails, the return value is zero. No extended error information is available.Any application that adds or removes fonts from the system font table should notify other windows of the change by sending a WM_FONTCHANGE message to all top-level windows in the operating system. The application should send this message by calling the SendMessage function and setting the hwnd parameter to HWND_BROADCAST.When an application no longer needs a font resource that it loaded by calling the AddFontResource function, it must remove that resource by calling the RemoveFontResource function.This function installs the font only for the current session. When the system restarts, the font will not be present. To have the font installed even after restarting the system, the font must be listed in the registry.A font listed in the registry and installed to a location other than the %windir%\fonts\ folder cannot be modified, deleted, or replaced as long as it is loaded in any session. In order to change one of these fonts, it must first be removed by calling RemoveFontResource, removed from the font registry (HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts), and the system restarted. After restarting the system, the font will no longer be loaded and can be changed.AddFontResourceExFont and Text FunctionsFonts and Text OverviewRemoveFontResourceSendMessage</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int AddFontResourceW(string unnamedParam1);

        /// <summary>
        ///The AlphaBlend function displays bitmaps that have transparent or semitransparent pixels.
        /// </summary>
        /// <param name="hdcDest">A handle to the destination device context.</param>
        /// <param name="xoriginDest">The x-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
        /// <param name="yoriginDest">The y-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
        /// <param name="wDest">The width, in logical units, of the destination rectangle.</param>
        /// <param name="hDest">The height, in logical units, of the destination rectangle.</param>
        /// <param name="hdcSrc">A handle to the source device context.</param>
        /// <param name="xoriginSrc">The x-coordinate, in logical units, of the upper-left corner of the source rectangle.</param>
        /// <param name="yoriginSrc">The y-coordinate, in logical units, of the upper-left corner of the source rectangle.</param>
        /// <param name="wSrc">The width, in logical units, of the source rectangle.</param>
        /// <param name="hSrc">The height, in logical units, of the source rectangle.</param>
        /// <param name="ftn">The alpha-blending function for source and destination bitmaps, a global alpha value to be applied to the entire source bitmap, and format information for the source bitmap. The source and destination blend functions are currently limited to AC_SRC_OVER. See the BLENDFUNCTION and EMRALPHABLEND structures.If the function succeeds, the return value is TRUE.If the function fails, the return value is FALSE.If the source rectangle and destination rectangle are not the same size, the source bitmap is stretched to match the destination rectangle. If the SetStretchBltMode function is used, the iStretchMode value is automatically converted to COLORONCOLOR for this function (that is, BLACKONWHITE, WHITEONBLACK, and HALFTONE are changed to COLORONCOLOR).The destination coordinates are transformed by using the transformation currently specified for the destination device context. The source coordinates are transformed by using the transformation currently specified for the source device context.An error occurs (and the function returns FALSE) if the source device context identifies an enhanced metafile device context.If destination and source bitmaps do not have the same color format, AlphaBlend converts the source bitmap to match the destination bitmap.AlphaBlend does not support mirroring. If either the width or height of the source or destination is negative, this call will fail.When rendering to a printer, first call GetDeviceCaps with SHADEBLENDCAPS to determine if the printer supports blending with AlphaBlend. Note that, for a display DC, all blending operations are supported and these flags represent whether the operations are accelerated.If the source and destination are the same surface, that is, they are both the screen or the same memory bitmap and the source and destination rectangles overlap, an error occurs and the function returns FALSE.The source rectangle must lie completely within the source surface, otherwise an error occurs and the function returns FALSE.AlphaBlend fails if the width or height of the source or destination is negative.The SourceConstantAlpha member of BLENDFUNCTION specifies an alpha transparency value to be used on the entire source bitmap. The SourceConstantAlpha value is combined with any per-pixel alpha values. If SourceConstantAlpha is 0, it is assumed that the image is transparent. Set the SourceConstantAlpha value to 255 (which indicates that the image is opaque) when you only want to use per-pixel alpha values.BLENDFUNCTIONBitmap FunctionsBitmaps OverviewEMRALPHABLENDGetDeviceCapsSetStretchBltMode</param>

        [DllImport("Msimg32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool AlphaBlend(nint hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest, nint hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc, BLENDFUNCTION ftn);

        /// <summary>
        ///The AngleArc function draws a line segment and an arc. The line segment is drawn from the current position to the beginning of the arc. The arc is drawn along the perimeter of a circle with the given radius and center. The length of the arc is defined by the given start and sweep angles.
        /// </summary>
        /// <param name="hdc">Handle to a device context.</param>
        /// <param name="x">Specifies the x-coordinate, in logical units, of the center of the circle.</param>
        /// <param name="y">Specifies the y-coordinate, in logical units, of the center of the circle.</param>
        /// <param name="r">Specifies the radius, in logical units, of the circle. This value must be positive.</param>
        /// <param name="StartAngle">Specifies the start angle, in degrees, relative to the x-axis.</param>
        /// <param name="SweepAngle">Specifies the sweep angle, in degrees, relative to the starting angle.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The AngleArc function moves the current position to the ending point of the arc.The arc drawn by this function may appear to be elliptical, depending on the current transformation and mapping mode. Before drawing the arc, AngleArc draws the line segment from the current position to the beginning of the arc.The arc is drawn by constructing an imaginary circle around the specified center point with the specified radius. The starting point of the arc is determined by measuring counterclockwise from the x-axis of the circle by the number of degrees in the start angle. The ending point is similarly located by measuring counterclockwise from the starting point by the number of degrees in the sweep angle.If the sweep angle is greater than 360 degrees, the arc is swept multiple times.This function draws lines by using the current pen. The figure is not filled.For an example, see Drawing a Pie Chart.ArcArcToLine and Curve FunctionsLines and Curves OverviewMoveToEx</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool AngleArc(nint hdc, int x, int y, uint r, float StartAngle, float SweepAngle);

        /// <summary>
        ///The AnimatePalette function replaces entries in the specified logical palette.
        /// </summary>
        /// <param name="hPal">A handle to the logical palette.</param>
        /// <param name="iStartIndex">The first logical palette entry to be replaced.</param>
        /// <param name="cEntries">The number of entries to be replaced.</param>
        /// <param name="ppe">A pointer to the first member in an array of PALETTEENTRY structures used to replace the current entries.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.An application can determine whether a device supports palette operations by calling the GetDeviceCaps function and specifying the RASTERCAPS constant.The AnimatePalette function only changes entries with the PC_RESERVED flag set in the corresponding palPalEntry member of the LOGPALETTE structure.If the given palette is associated with the active window, the colors in the palette are replaced immediately.Color FunctionsColors OverviewCreatePaletteGetDeviceCapsLOGPALETTEPALETTEENTRY</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool AnimatePalette(nint hPal, uint iStartIndex, uint cEntries, PALETTEENTRY ppe);

        /// <summary>
        ///The Arc function draws an elliptical arc.
        /// </summary>
        /// <param name="hdc">A handle to the device context where drawing takes place.</param>
        /// <param name="x1">The x-coordinate, in logical units, of the upper-left corner of the bounding rectangle.</param>
        /// <param name="y1">The y-coordinate, in logical units, of the upper-left corner of the bounding rectangle.</param>
        /// <param name="x2">The x-coordinate, in logical units, of the lower-right corner of the bounding rectangle.</param>
        /// <param name="y2">The y-coordinate, in logical units, of the lower-right corner of the bounding rectangle.</param>
        /// <param name="x3">The x-coordinate, in logical units, of the ending point of the radial line defining the starting point of the arc.</param>
        /// <param name="y3">The y-coordinate, in logical units, of the ending point of the radial line defining the starting point of the arc.</param>
        /// <param name="x4">The x-coordinate, in logical units, of the ending point of the radial line defining the ending point of the arc.</param>
        /// <param name="y4">The y-coordinate, in logical units, of the ending point of the radial line defining the ending point of the arc.If the arc is drawn, the return value is nonzero.If the arc is not drawn, the return value is zero.The points (nLeftRect, nTopRect) and (nRightRect, nBottomRect) specify the bounding rectangle. An ellipse formed by the specified bounding rectangle defines the curve of the arc. The arc extends in the current drawing direction from the point where it intersects the radial from the center of the bounding rectangle to the (nXStartArc, nYStartArc) point. The arc ends where it intersects the radial from the center of the bounding rectangle to the (nXEndArc, nYEndArc) point. If the starting point and ending point are the same, a complete ellipse is drawn.The arc is drawn using the current pen; it is not filled.The current position is neither used nor updated by Arc.Use the GetArcDirection and SetArcDirection functions to get and set the current drawing direction for a device context. The default drawing direction is counterclockwise.AngleArcArcToChordEllipseGetArcDirectionLine and Curve FunctionsLines and Curves OverviewPieSetArcDirection</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool Arc(nint hdc, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4);

        /// <summary>
        ///The ArcTo function draws an elliptical arc.
        /// </summary>
        /// <param name="hdc">A handle to the device context where drawing takes place.</param>
        /// <param name="left">The x-coordinate, in logical units, of the upper-left corner of the bounding rectangle.</param>
        /// <param name="top">The y-coordinate, in logical units, of the upper-left corner of the bounding rectangle.</param>
        /// <param name="right">The x-coordinate, in logical units, of the lower-right corner of the bounding rectangle.</param>
        /// <param name="bottom">The y-coordinate, in logical units, of the lower-right corner of the bounding rectangle.</param>
        /// <param name="xr1">The x-coordinate, in logical units, of the endpoint of the radial defining the starting point of the arc.</param>
        /// <param name="yr1">The y-coordinate, in logical units, of the endpoint of the radial defining the starting point of the arc.</param>
        /// <param name="xr2">The x-coordinate, in logical units, of the endpoint of the radial defining the ending point of the arc.</param>
        /// <param name="yr2">The y-coordinate, in logical units, of the endpoint of the radial defining the ending point of the arc.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.ArcTo is similar to the Arc function, except that the current position is updated.The points (nLeftRect, nTopRect) and (nRightRect, nBottomRect) specify the bounding rectangle. An ellipse formed by the specified bounding rectangle defines the curve of the arc. The arc extends counterclockwise from the point where it intersects the radial line from the center of the bounding rectangle to the (nXRadial1, nYRadial1) point. The arc ends where it intersects the radial line from the center of the bounding rectangle to the (nXRadial2, nYRadial2) point. If the starting point and ending point are the same, a complete ellipse is drawn.A line is drawn from the current position to the starting point of the arc. If no error occurs, the current position is set to the ending point of the arc.The arc is drawn using the current pen; it is not filled.AngleArcArcLine and Curve FunctionsLines and Curves OverviewSetArcDirection</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ArcTo(nint hdc, int left, int top, int right, int bottom, int xr1, int yr1, int xr2, int yr2);

        /// <summary>
        ///The BeginPath function opens a path bracket in the specified device context.
        /// </summary>
        /// <param name="hdc">A handle to the device context.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.After a path bracket is open, an application can begin calling GDI drawing functions to define the points that lie in the path. An application can close an open path bracket by calling the EndPath function.When an application calls BeginPath for a device context, any previous paths are discarded from that device context. The following list shows which drawing functions can be used.For an example, see Using Paths.EndPathFillPathPath FunctionsPathToRegionPaths OverviewSelectClipPathStrokeAndFillPathStrokePathWidenPath</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool BeginPath(nint hdc);

        /// <summary>
        ///The BitBlt function performs a bit-block transfer of the color data corresponding to a rectangle of pixels from the specified source device context into a destination device context.
        /// </summary>
        /// <param name="hdc">A handle to the destination device context.</param>
        /// <param name="x">The x-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
        /// <param name="y">The y-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
        /// <param name="cx">The width, in logical units, of the source and destination rectangles.</param>
        /// <param name="cy">The height, in logical units, of the source and the destination rectangles.</param>
        /// <param name="hdcSrc">A handle to the source device context.</param>
        /// <param name="x1">The x-coordinate, in logical units, of the upper-left corner of the source rectangle.</param>
        /// <param name="y1">The y-coordinate, in logical units, of the upper-left corner of the source rectangle.</param>
        /// <param name="rop">A raster-operation code. These codes define how the color data for the source rectangle is to be combined with the color data for the destination rectangle to achieve the final color.The following list shows some common raster operation codes.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.BitBlt only does clipping on the destination DC.If a rotation or shear transformation is in effect in the source device context, BitBlt returns an error. If other transformations exist in the source device context (and a matching transformation is not in effect in the destination device context), the rectangle in the destination device context is stretched, compressed, or rotated, as necessary.If the color formats of the source and destination device contexts do not match, the BitBlt function converts the source color format to match the destination format.When an enhanced metafile is being recorded, an error occurs if the source device context identifies an enhanced-metafile device context.Not all devices support the BitBlt function. For more information, see the RC_BITBLT raster capability entry in the GetDeviceCaps function as well as the following functions: MaskBlt, PlgBlt, and StretchBlt.BitBlt returns an error if the source and destination device contexts represent different devices. To transfer data between DCs for different devices, convert the memory bitmap to a DIB by calling GetDIBits. To display the DIB to the second device, call SetDIBits or StretchDIBits.ICM: No color management is performed when blits occur.The following code example demonstrates the use of BitBlt.To see this example in context, see Capturing an Image.Bitmap FunctionsBitmaps OverviewGetDIBitsGetDeviceCapsMaskBltPlgBltSetDIBitsStretchBltStretchDIBits</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool BitBlt(nint hdc, int x, int y, int cx, int cy, nint hdcSrc, int x1, int y1, uint rop);

        /// <summary>
        ///The CancelDC function cancels any pending operation on the specified device context (DC).
        /// </summary>
        /// <param name="hdc">A handle to the DC.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The CancelDC function is used by multithreaded applications to cancel lengthy drawing operations. If thread A initiates a lengthy drawing operation, thread B may cancel that operation by calling this function.If an operation is canceled, the affected thread returns an error and the result of its drawing operation is undefined. The results are also undefined if no drawing operation was in progress when the function was called.CreateThreadDevice Context FunctionsDevice Contexts OverviewGetCurrentThread</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CancelDC(nint hdc);

        /// <summary>
        ///The CheckColorsInGamut function determines whether a specified set of RGB triples lies in the output gamut of a specified device. The RGB triples are interpreted in the input logical color space.
        /// </summary>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CheckColorsInGamut(nint hdc, int lpRGBTriple, nint dlpBuffer, uint nCount);

        /// <summary>
        ///The ChoosePixelFormat function attempts to match an appropriate pixel format supported by a device context to a given pixel format specification.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int ChoosePixelFormat(nint hdc, PIXELFORMATDESCRIPTOR ppfd);

        /// <summary>
        ///The Chord function draws a chord (a region bounded by the intersection of an ellipse and a line segment, called a secant). The chord is outlined by using the current pen and filled by using the current brush.
        /// </summary>
        /// <param name="hdc">A handle to the device context in which the chord appears.</param>
        /// <param name="x1">The x-coordinate, in logical coordinates, of the upper-left corner of the bounding rectangle.</param>
        /// <param name="y1">The y-coordinate, in logical coordinates, of the upper-left corner of the bounding rectangle.</param>
        /// <param name="x2">The x-coordinate, in logical coordinates, of the lower-right corner of the bounding rectangle.</param>
        /// <param name="y2">The y-coordinate, in logical coordinates, of the lower-right corner of the bounding rectangle.</param>
        /// <param name="x3">The x-coordinate, in logical coordinates, of the endpoint of the radial defining the beginning of the chord.</param>
        /// <param name="y3">The y-coordinate, in logical coordinates, of the endpoint of the radial defining the beginning of the chord.</param>
        /// <param name="x4">The x-coordinate, in logical coordinates, of the endpoint of the radial defining the end of the chord.</param>
        /// <param name="y4">The y-coordinate, in logical coordinates, of the endpoint of the radial defining the end of the chord.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The curve of the chord is defined by an ellipse that fits the specified bounding rectangle. The curve begins at the point where the ellipse intersects the first radial and extends counterclockwise to the point where the ellipse intersects the second radial. The chord is closed by drawing a line from the intersection of the first radial and the curve to the intersection of the second radial and the curve.If the starting point and ending point of the curve are the same, a complete ellipse is drawn.The current position is neither used nor updated by Chord.AngleArcArcArcToFilled Shape FunctionsFilled Shapes OverviewPie</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool Chord(nint hdc, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4);

        /// <summary>
        ///The CloseEnhMetaFile function closes an enhanced-metafile device context and returns a handle that identifies an enhanced-format metafile.
        /// </summary>
        /// <param name="hdc">Handle to an enhanced-metafile device context.If the function succeeds, the return value is a handle to an enhanced metafile.If the function fails, the return value is NULL.An application can use the enhanced-metafile handle returned by the CloseEnhMetaFile function to perform the following tasks:CopyEnhMetaFileCreateEnhMetaFileDeleteEnhMetaFileEnumEnhMetaFileGetEnhMetaFileBitsGetWinMetaFileBitsMetafile FunctionsMetafiles OverviewPlayEnhMetaFile</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CloseEnhMetaFile(nint hdc);

        /// <summary>
        ///The CloseFigure function closes an open figure in a path.
        /// </summary>
        /// <param name="hdc">Handle to the device context in which the figure will be closed.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The CloseFigure function closes the figure by drawing a line from the current position to the first point of the figure (usually, the point specified by the most recent call to the MoveToEx function) and then connects the lines by using the line join style. If a figure is closed by using the LineTo function instead of CloseFigure, end caps are used to create the corner instead of a join.The CloseFigure function should only be called if there is an open path bracket in the specified device context.A figure in a path is open unless it is explicitly closed by using this function. (A figure can be open even if the current point and the starting point of the figure are the same.)After a call to CloseFigure, adding a line or curve to the path starts a new figure.BeginPathEndPathExtCreatePenLineToMoveToExPath FunctionsPaths Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CloseFigure(nint hdc);

        /// <summary>
        ///The CloseMetaFile function closes a metafile device context and returns a handle that identifies a Windows-format metafile.
        /// </summary>
        /// <param name="hdc">Handle to a metafile device context used to create a Windows-format metafile.If the function succeeds, the return value is a handle to a Windows-format metafile.If the function fails, the return value is NULL.To convert a Windows-format metafile into a new enhanced-format metafile, use the SetWinMetaFileBits function.When an application no longer needs the Windows-format metafile handle, it should delete the handle by calling the DeleteMetaFile function.CloseEnhMetaFileCopyMetaFileCreateMetaFileDeleteMetaFileEnumMetaFileGetMetaFileBitsExMetafile FunctionsMetafiles OverviewPlayMetaFileSetWinMetaFileBits</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CloseMetaFile(nint hdc);

        /// <summary>
        ///The ColorCorrectPalette function corrects the entries of a palette using the WCS 1.0 parameters in the specified device context.
        /// </summary>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ColorCorrectPalette(nint hdc, nint hPal, uint deFirst, uint num);

        /// <summary>
        ///The ColorMatchToTarget function enables you to preview colors as they would appear on the target device.
        /// </summary>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ColorMatchToTarget(nint hdc, nint hdcTarget, uint action);

        /// <summary>
        ///The CombineRgn function combines two regions and stores the result in a third region. The two regions are combined according to the specified mode.
        /// </summary>
        /// <param name="hrgnDst">A handle to a new region with dimensions defined by combining two other regions. (This region must exist before CombineRgn is called.)</param>
        /// <param name="hrgnSrc1">A handle to the first of two regions to be combined.</param>
        /// <param name="hrgnSrc2">A handle to the second of two regions to be combined.</param>
        /// <param name="iMode">A mode indicating how the two regions will be combined. This parameter can be one of the following values.The return value specifies the type of the resulting region. It can be one of the following values.The three regions need not be distinct. For example, the hrgnSrc1 parameter can equal the hrgnDest parameter.CreateEllipticRgnCreateEllipticRgnIndirectCreatePolyPolygonRgnCreatePolygonRgnCreateRectRgnCreateRectRgnIndirectCreateRoundRectRgnRegion FunctionsRegions Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int CombineRgn(nint hrgnDst, nint hrgnSrc1, nint hrgnSrc2, int iMode);

        /// <summary>
        ///The CombineTransform function concatenates two world-space to page-space transformations.
        /// </summary>
        /// <param name="lpxfOut"></param>
        /// <param name="lpxf1">A pointer to an XFORM structure that specifies the first transformation.</param>
        /// <param name="lpxf2">A pointer to an XFORM structure that specifies the second transformation.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.Applying the combined transformation has the same effect as applying the first transformation and then applying the second transformation.The three transformations need not be distinct. For example, lpxform1 can point to the same XFORM structure as lpxformResult.Coordinate Space and Transformation FunctionsCoordinate Spaces and Transformations OverviewGetWorldTransformModifyWorldTransformSetWorldTransformXFORM</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CombineTransform(out int lpxfOut, XFORM lpxf1, XFORM lpxf2);

        /// <summary>
        ///The CopyEnhMetaFile function copies the contents of an enhanced-format metafile to a specified file.
        /// </summary>
        /// <param name="hEnh">A handle to the enhanced metafile to be copied.</param>
        /// <param name="lpFileName">A pointer to the name of the destination file. If this parameter is NULL, the source metafile is copied to memory.If the function succeeds, the return value is a handle to the copy of the enhanced metafile.If the function fails, the return value is NULL.Where text arguments must use Unicode characters, use the CopyEnhMetaFile function as a wide-character function. Where text arguments must use characters from the Windows character set, use this function as an ANSI function.Applications can use metafiles stored in memory for temporary operations.When the application no longer needs the enhanced-metafile handle, it should delete the handle by calling the DeleteEnhMetaFile function.DeleteEnhMetaFileMetafile FunctionsMetafiles Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CopyEnhMetaFileA(nint hEnh, string lpFileName);

        /// <summary>
        ///The CopyEnhMetaFile function copies the contents of an enhanced-format metafile to a specified file.
        /// </summary>
        /// <param name="hEnh">A handle to the enhanced metafile to be copied.</param>
        /// <param name="lpFileName">A pointer to the name of the destination file. If this parameter is NULL, the source metafile is copied to memory.If the function succeeds, the return value is a handle to the copy of the enhanced metafile.If the function fails, the return value is NULL.Where text arguments must use Unicode characters, use the CopyEnhMetaFile function as a wide-character function. Where text arguments must use characters from the Windows character set, use this function as an ANSI function.Applications can use metafiles stored in memory for temporary operations.When the application no longer needs the enhanced-metafile handle, it should delete the handle by calling the DeleteEnhMetaFile function.DeleteEnhMetaFileMetafile FunctionsMetafiles Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CopyEnhMetaFileW(nint hEnh, string lpFileName);

        /// <summary>
        ///The CopyMetaFile function copies the content of a Windows-format metafile to the specified file.
        /// </summary>
        /// <param name="unnamedParam1">A handle to the source Windows-format metafile.</param>
        /// <param name="unnamedParam2">A pointer to the name of the destination file. If this parameter is NULL, the source metafile is copied to memory.If the function succeeds, the return value is a handle to the copy of the Windows-format metafile.If the function fails, the return value is NULL.Where text arguments must use Unicode characters, use this function as a wide-character function. Where text arguments must use characters from the Windows character set, use this function as an ANSI function.When the application no longer needs the Windows-format metafile handle, it should delete the handle by calling the DeleteMetaFile function.DeleteMetaFileMetafile FunctionsMetafiles Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CopyMetaFileA(nint unnamedParam1, string unnamedParam2);

        /// <summary>
        ///The CopyMetaFile function copies the content of a Windows-format metafile to the specified file.
        /// </summary>
        /// <param name="unnamedParam1">A handle to the source Windows-format metafile.</param>
        /// <param name="unnamedParam2">A pointer to the name of the destination file. If this parameter is NULL, the source metafile is copied to memory.If the function succeeds, the return value is a handle to the copy of the Windows-format metafile.If the function fails, the return value is NULL.Where text arguments must use Unicode characters, use this function as a wide-character function. Where text arguments must use characters from the Windows character set, use this function as an ANSI function.When the application no longer needs the Windows-format metafile handle, it should delete the handle by calling the DeleteMetaFile function.DeleteMetaFileMetafile FunctionsMetafiles Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CopyMetaFileW(nint unnamedParam1, string unnamedParam2);

        /// <summary>
        ///The CreateBitmap function creates a bitmap with the specified width, height, and color format (color planes and bits-per-pixel).
        /// </summary>
        /// <param name="nWidth">The bitmap width, in pixels.</param>
        /// <param name="nHeight">The bitmap height, in pixels.</param>
        /// <param name="nPlanes">The number of color planes used by the device.</param>
        /// <param name="nBitCount">The number of bits required to identify the color of a single pixel.</param>
        /// <param name="lpBits">A pointer to an array of color data used to set the colors in a rectangle of pixels. Each scan line in the rectangle must be word aligned (scan lines that are not word aligned must be padded with zeros). The buffer size expected, cj, can be calculated using the formula:If this parameter is NULL, then the contents of the new bitmap are undefined.If the function succeeds, the return value is a handle to a bitmap.If the function fails, the return value is NULL.This function can return the following value.The CreateBitmap function creates a device-dependent bitmap.After a bitmap is created, it can be selected into a device context by calling the SelectObject function. However, the bitmap can only be selected into a device context if the bitmap and the DC have the same format.The CreateBitmap function can be used to create color bitmaps. However, for performance reasons applications should use CreateBitmap to create monochrome bitmaps and CreateCompatibleBitmap to create color bitmaps. Whenever a color bitmap returned from CreateBitmap is selected into a device context, the system checks that the bitmap matches the format of the device context it is being selected into. Because CreateCompatibleBitmap takes a device context, it returns a bitmap that has the same format as the specified device context. Thus, subsequent calls to SelectObject are faster with a color bitmap from CreateCompatibleBitmap than with a color bitmap returned from CreateBitmap.If the bitmap is monochrome, zeros represent the foreground color and ones represent the background color for the destination device context.If an application sets the nWidth or nHeight parameters to zero, CreateBitmap returns the handle to a 1-by-1 pixel, monochrome bitmap.When you no longer need the bitmap, call the DeleteObject function to delete it.Bitmap FunctionsBitmaps OverviewCreateBitmapIndirectCreateCompatibleBitmapCreateDIBitmapDeleteObjectGetBitmapBitsSelectObjectSetBitmapBits</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateBitmap(int nWidth, int nHeight, uint nPlanes, uint nBitCount, nint lpBits);

        /// <summary>
        ///The CreateBitmapIndirect function creates a bitmap with the specified width, height, and color format (color planes and bits-per-pixel).
        /// </summary>
        /// <param name="pbm">A pointer to a BITMAP structure that contains information about the bitmap. If an application sets the bmWidth or bmHeight members to zero, CreateBitmapIndirect returns the handle to a 1-by-1 pixel, monochrome bitmap.If the function succeeds, the return value is a handle to the bitmap.If the function fails, the return value is NULL.This function can return the following values.The CreateBitmapIndirect function creates a device-dependent bitmap.After a bitmap is created, it can be selected into a device context by calling the SelectObject function. However, the bitmap can only be selected into a device context if the bitmap and the DC have the same format.While the CreateBitmapIndirect function can be used to create color bitmaps, for performance reasons applications should use CreateBitmapIndirect to create monochrome bitmaps and CreateCompatibleBitmap to create color bitmaps. Whenever a color bitmap from CreateBitmapIndirect is selected into a device context, the system must ensure that the bitmap matches the format of the device context it is being selected into. Because CreateCompatibleBitmap takes a device context, it returns a bitmap that has the same format as the specified device context. Thus, subsequent calls to SelectObject are faster with a color bitmap from CreateCompatibleBitmap than with a color bitmap returned from CreateBitmapIndirect.If the bitmap is monochrome, zeros represent the foreground color and ones represent the background color for the destination device context.When you no longer need the bitmap, call the DeleteObject function to delete it.BITMAPBitBltBitmap FunctionsBitmaps OverviewCreateBitmapCreateCompatibleBitmapCreateDIBitmapDeleteObjectSelectObject</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateBitmapIndirect(BITMAP pbm);

        /// <summary>
        ///The CreateBrushIndirect function creates a logical brush that has the specified style, color, and pattern.
        /// </summary>
        /// <param name="plbrush">A pointer to a LOGBRUSH structure that contains information about the brush.If the function succeeds, the return value identifies a logical brush.If the function fails, the return value is NULL.A brush is a bitmap that the system uses to paint the interiors of filled shapes.After an application creates a brush by calling CreateBrushIndirect, it can select it into any device context by calling the SelectObject function.A brush created by using a monochrome bitmap (one color plane, one bit per pixel) is drawn using the current text and background colors. Pixels represented by a bit set to 0 are drawn with the current text color; pixels represented by a bit set to 1 are drawn with the current background color.When you no longer need the brush, call the DeleteObject function to delete it.ICM: No color is done at brush creation. However, color management is performed when the brush is selected into an ICM-enabled device context.Brush FunctionsBrushes OverviewDeleteObjectGetBrushOrgExLOGBRUSHSelectObjectSetBrushOrgEx</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateBrushIndirect(LOGBRUSH plbrush);

        /// <summary>
        ///The CreateColorSpace function creates a logical color space.
        /// </summary>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateColorSpaceA(int lplcs);

        /// <summary>
        ///The CreateColorSpace function creates a logical color space.
        /// </summary>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateColorSpaceW(int lplcs);

        /// <summary>
        ///The CreateCompatibleBitmap function creates a bitmap compatible with the device that is associated with the specified device context.
        /// </summary>
        /// <param name="hdc">A handle to a device context.</param>
        /// <param name="cx">The bitmap width, in pixels.</param>
        /// <param name="cy">The bitmap height, in pixels.If the function succeeds, the return value is a handle to the compatible bitmap (DDB).If the function fails, the return value is NULL.The color format of the bitmap created by the CreateCompatibleBitmap function matches the color format of the device identified by the hdc parameter. This bitmap can be selected into any memory device context that is compatible with the original device.Because memory device contexts allow both color and monochrome bitmaps, the format of the bitmap returned by the CreateCompatibleBitmap function differs when the specified device context is a memory device context. However, a compatible bitmap that was created for a nonmemory device context always possesses the same color format and uses the same color palette as the specified device context.Note: When a memory device context is created, it initially has a 1-by-1 monochrome bitmap selected into it. If this memory device context is used in CreateCompatibleBitmap, the bitmap that is created is a monochrome bitmap. To create a color bitmap, use the HDC that was used to create the memory device context, as shown in the following code:If an application sets the nWidth or nHeight parameters to zero, CreateCompatibleBitmap returns the handle to a 1-by-1 pixel, monochrome bitmap.If a DIB section, which is a bitmap created by the CreateDIBSection function, is selected into the device context identified by the hdc parameter, CreateCompatibleBitmap creates a DIB section.When you no longer need the bitmap, call the DeleteObject function to delete it.For an example, see Scaling an Image.Bitmap FunctionsBitmaps OverviewCreateDIBSectionDeleteObjectSelectObject</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateCompatibleBitmap(nint hdc, int cx, int cy);

        /// <summary>
        ///The CreateCompatibleDC function creates a memory device context (DC) compatible with the specified device.
        /// </summary>
        /// <param name="hdc">A handle to an existing DC. If this handle is NULL, the function creates a memory DC compatible with the application's current screen.If the function succeeds, the return value is the handle to a memory DC.If the function fails, the return value is NULL.A memory DC exists only in memory. When the memory DC is created, its display surface is exactly one monochrome pixel wide and one monochrome pixel high. Before an application can use a memory DC for drawing operations, it must select a bitmap of the correct width and height into the DC. To select a bitmap into a DC, use the CreateCompatibleBitmap function, specifying the height, width, and color organization required.When a memory DC is created, all attributes are set to normal default values. The memory DC can be used as a normal DC. You can set the attributes; obtain the current settings of its attributes; and select pens, brushes, and regions.The CreateCompatibleDC function can only be used with devices that support raster operations. An application can determine whether a device supports these operations by calling the GetDeviceCaps function.When you no longer need the memory DC, call the DeleteDC function. We recommend that you call DeleteDC to delete the DC. However, you can also call DeleteObject with the HDC to delete the DC.If hdc is NULL, the thread that calls CreateCompatibleDC owns the HDC that is created. When this thread is destroyed, the HDC is no longer valid. Thus, if you create the HDC and pass it to another thread, then exit the first thread, the second thread will not be able to use the HDC.ICM: If the DC that is passed to this function is enabled for Image Color Management (ICM), the DC created by the function is ICM-enabled. The source and destination color spaces are specified in the DC.For an example, see Capturing an Image.CreateCompatibleBitmapDeleteDCDevice Context FunctionsDevice Contexts OverviewGetDeviceCaps</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateCompatibleDC(nint hdc);

        /// <summary>
        ///The CreateDC function creates a device context (DC) for a device using the specified name.
        /// </summary>
        /// <param name="pwszDriver"></param>
        /// <param name="pwszDevice">A pointer to a null-terminated character string that specifies the name of the specific output device being used, as shown by the Print Manager (for example, Epson FX-80). It is not the printer model name. The lpszDevice parameter must be used.To obtain valid names for displays, call EnumDisplayDevices.If lpszDriver is DISPLAY or the device name of a specific display device, then lpszDevice must be NULL or that same device name. If lpszDevice is NULL, then a DC is created for the primary display device.If there are multiple monitors on the system, calling CreateDC(TEXT("DISPLAY"),NULL,NULL,NULL) will create a DC covering all the monitors.pszPortThis parameter is ignored and should be set to NULL. It is provided only for compatibility with 16-bit Windows.</param>
        /// <param name="pszPort"></param>
        /// <param name="pdm">A pointer to a DEVMODE structure containing device-specific initialization data for the device driver. The DocumentProperties function retrieves this structure filled in for a specified device. The pdm parameter must be NULL if the device driver is to use the default initialization (if any) specified by the user.If lpszDriver is DISPLAY, pdm must be NULL; GDI then uses the display device's current DEVMODE.If the function succeeds, the return value is the handle to a DC for the specified device.If the function fails, the return value is NULL.Note that the handle to the DC can only be used by a single thread at any one time.For parameters lpszDriver and lpszDevice, call EnumDisplayDevices to obtain valid names for displays.When you no longer need the DC, call the DeleteDC function.If lpszDriver or lpszDevice is DISPLAY, the thread that calls CreateDC owns the HDC that is created. When this thread is destroyed, the HDC is no longer valid. Thus, if you create the HDC and pass it to another thread, then exit the first thread, the second thread will not be able to use the HDC.When you call CreateDC to create the HDC for a display device, you must pass to pdm either NULL or a pointer to DEVMODE that matches the current DEVMODE of the display device that lpszDevice specifies. We recommend to pass NULL and not to try to exactly match the DEVMODE for the current display device.When you call CreateDC to create the HDC for a printer device, the printer driver validates the DEVMODE. If the printer driver determines that the DEVMODE is invalid (that is, printer driver can’t convert or consume the DEVMODE), the printer driver provides a default DEVMODE to create the HDC for the printer device.ICM: To enable ICM, set the dmICMMethod member of the DEVMODE structure (pointed to by the pInitData parameter) to the appropriate value.For an example, see Capturing an Image.DEVMODEDOCINFODeleteDCDevice Context FunctionsDevice Contexts OverviewDocumentPropertiesEnumDisplayDevicesMultiple Display MonitorsStartDoc</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateDCA(string pwszDriver, string pwszDevice, string pszPort, int pdm);

        /// <summary>
        ///The CreateDC function creates a device context (DC) for a device using the specified name.
        /// </summary>
        /// <param name="pwszDriver"></param>
        /// <param name="pwszDevice">A pointer to a null-terminated character string that specifies the name of the specific output device being used, as shown by the Print Manager (for example, Epson FX-80). It is not the printer model name. The lpszDevice parameter must be used.To obtain valid names for displays, call EnumDisplayDevices.If lpszDriver is DISPLAY or the device name of a specific display device, then lpszDevice must be NULL or that same device name. If lpszDevice is NULL, then a DC is created for the primary display device.If there are multiple monitors on the system, calling CreateDC(TEXT("DISPLAY"),NULL,NULL,NULL) will create a DC covering all the monitors.pszPortThis parameter is ignored and should be set to NULL. It is provided only for compatibility with 16-bit Windows.</param>
        /// <param name="pszPort"></param>
        /// <param name="pdm">A pointer to a DEVMODE structure containing device-specific initialization data for the device driver. The DocumentProperties function retrieves this structure filled in for a specified device. The pdm parameter must be NULL if the device driver is to use the default initialization (if any) specified by the user.If lpszDriver is DISPLAY, pdm must be NULL; GDI then uses the display device's current DEVMODE.If the function succeeds, the return value is the handle to a DC for the specified device.If the function fails, the return value is NULL.Note that the handle to the DC can only be used by a single thread at any one time.For parameters lpszDriver and lpszDevice, call EnumDisplayDevices to obtain valid names for displays.When you no longer need the DC, call the DeleteDC function.If lpszDriver or lpszDevice is DISPLAY, the thread that calls CreateDC owns the HDC that is created. When this thread is destroyed, the HDC is no longer valid. Thus, if you create the HDC and pass it to another thread, then exit the first thread, the second thread will not be able to use the HDC.When you call CreateDC to create the HDC for a display device, you must pass to pdm either NULL or a pointer to DEVMODE that matches the current DEVMODE of the display device that lpszDevice specifies. We recommend to pass NULL and not to try to exactly match the DEVMODE for the current display device.When you call CreateDC to create the HDC for a printer device, the printer driver validates the DEVMODE. If the printer driver determines that the DEVMODE is invalid (that is, printer driver can’t convert or consume the DEVMODE), the printer driver provides a default DEVMODE to create the HDC for the printer device.ICM: To enable ICM, set the dmICMMethod member of the DEVMODE structure (pointed to by the pInitData parameter) to the appropriate value.For an example, see Capturing an Image.DEVMODEDOCINFODeleteDCDevice Context FunctionsDevice Contexts OverviewDocumentPropertiesEnumDisplayDevicesMultiple Display MonitorsStartDoc</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateDCW(string pwszDriver, string pwszDevice, string pszPort, int pdm);

        /// <summary>
        ///The CreateDIBitmap function creates a compatible bitmap (DDB) from a DIB and, optionally, sets the bitmap bits.
        /// </summary>
        /// <param name="hdc">A handle to a device context.</param>
        /// <param name="pbmih">A pointer to a bitmap information header structure, BITMAPV5HEADER.If fdwInit is CBM_INIT, the function uses the bitmap information header structure to obtain the desired width and height of the bitmap as well as other information. Note that a positive value for the height indicates a bottom-up DIB while a negative value for the height indicates a top-down DIB. Calling CreateDIBitmap with fdwInit as CBM_INIT is equivalent to calling the CreateCompatibleBitmap function to create a DDB in the format of the device and then calling the SetDIBits function to translate the DIB bits to the DDB.</param>
        /// <param name="flInit">Specifies how the system initializes the bitmap bits. The following value is defined.If fdwInit is zero, the system does not initialize the bitmap bits.</param>
        /// <param name="pjBits">A pointer to an array of bytes containing the initial bitmap data. The format of the data depends on the biBitCount member of the BITMAPINFO structure to which the lpbmi parameter points.</param>
        /// <param name="pbmi">A pointer to a BITMAPINFO structure that describes the dimensions and color format of the array pointed to by the lpbInit parameter.</param>
        /// <param name="iUsage">Specifies whether the bmiColors member of the BITMAPINFO structure was initialized and, if so, whether bmiColors contains explicit red, green, blue (RGB) values or palette indexes. The fuUsage parameter must be one of the following values.If the function succeeds, the return value is a handle to the compatible bitmap.If the function fails, the return value is NULL.The DDB that is created will be whatever bit depth your reference DC is. To create a bitmap that is of different bit depth, use CreateDIBSection.For a device to reach optimal bitmap-drawing speed, specify fdwInit as CBM_INIT. Then, use the same color depth DIB as the video mode. When the video is running 4- or 8-bpp, use DIB_PAL_COLORS.The CBM_CREATDIB flag for the fdwInit parameter is no longer supported.When you no longer need the bitmap, call the DeleteObject function to delete it.ICM: No color management is performed. The contents of the resulting bitmap are not color matched after the bitmap has been created.BITMAPINFOBITMAPINFOHEADERBitmap FunctionsBitmaps OverviewCreateCompatibleBitmapCreateDIBSectionDeleteObjectGetDeviceCapsGetSystemPaletteEntriesSelectObjectSetDIBits</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateDIBitmap(nint hdc, BITMAPINFOHEADER pbmih, uint flInit, nint pjBits, BITMAPINFO pbmi, uint iUsage);

        /// <summary>
        ///The CreateDIBPatternBrush function creates a logical brush that has the pattern specified by the specified device-independent bitmap (DIB). The brush can subsequently be selected into any device context that is associated with a device that supports raster operations.
        /// </summary>
        /// <param name="h">A handle to a global memory object containing a packed DIB, which consists of a BITMAPINFO structure immediately followed by an array of bytes defining the pixels of the bitmap.</param>
        /// <param name="iUsage">Specifies whether the bmiColors member of the BITMAPINFO structure is initialized and, if so, whether this member contains explicit red, green, blue (RGB) values or indexes into a logical palette. The fuColorSpec parameter must be one of the following values.If the function succeeds, the return value identifies a logical brush.If the function fails, the return value is NULL.When an application selects a two-color DIB pattern brush into a monochrome device context, the system does not acknowledge the colors specified in the DIB; instead, it displays the pattern brush using the current background and foreground colors of the device context. Pixels mapped to the first color of the DIB (offset 0 in the DIB color table) are displayed using the foreground color; pixels mapped to the second color (offset 1 in the color table) are displayed using the background color.When you no longer need the brush, call the DeleteObject function to delete it.ICM: No color is done at brush creation. However, color management is performed when the brush is selected into an ICM-enabled device context.BITMAPINFOBrush FunctionsBrushes OverviewCreateDIBPatternBrushPtCreateHatchBrushCreatePatternBrushCreateSolidBrushDeleteObjectSetBkColorSetTextColor</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateDIBPatternBrush(nint h, uint iUsage);

        /// <summary>
        ///The CreateDIBPatternBrushPt function creates a logical brush that has the pattern specified by the device-independent bitmap (DIB).
        /// </summary>
        /// <param name="lpPackedDIB">A pointer to a packed DIB consisting of a BITMAPINFO structure immediately followed by an array of bytes defining the pixels of the bitmap.</param>
        /// <param name="iUsage">Specifies whether the bmiColors member of the BITMAPINFO structure contains a valid color table and, if so, whether the entries in this color table contain explicit red, green, blue (RGB) values or palette indexes. The iUsage parameter must be one of the following values.If the function succeeds, the return value identifies a logical brush.If the function fails, the return value is NULL.A brush is a bitmap that the system uses to paint the interiors of filled shapes.After an application creates a brush by calling CreateDIBPatternBrushPt, it can select that brush into any device context by calling the SelectObject function.When you no longer need the brush, call the DeleteObject function to delete it.ICM: No color is done at brush creation. However, color management is performed when the brush is selected into an ICM-enabled device context.BITMAPINFOBrush FunctionsBrushes OverviewCreateDIBPatternBrushCreateHatchBrushCreatePatternBrushCreateSolidBrushDeleteObjectGetBrushOrgExSelectObjectSetBrushOrgEx</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateDIBPatternBrushPt(nint lpPackedDIB, uint iUsage);

        /// <summary>
        ///The CreateDIBSection function creates a DIB that applications can write to directly. The function gives you a pointer to the location of the bitmap bit values. You can supply a handle to a file-mapping object that the function will use to create the bitmap, or you can let the system allocate the memory for the bitmap.
        /// </summary>
        /// <param name="hdc">A handle to a device context. If the value of iUsage is DIB_PAL_COLORS, the function uses this device context's logical palette to initialize the DIB colors.</param>
        /// <param name="pbmi">A pointer to a BITMAPINFO structure that specifies various attributes of the DIB, including the bitmap dimensions and colors.</param>
        /// <param name="usage">The type of data contained in the bmiColors array member of the BITMAPINFO structure pointed to by pbmi (either logical palette indexes or literal RGB values). The following values are defined.</param>
        /// <param name="ppvBits"></param>
        /// <param name="hSection">A handle to a file-mapping object that the function will use to create the DIB. This parameter can be NULL.If hSection is not NULL, it must be a handle to a file-mapping object created by calling the CreateFileMapping function with the PAGE_READWRITE or PAGE_WRITECOPY flag. Read-only DIB sections are not supported. Handles created by other means will cause CreateDIBSection to fail.If hSection is not NULL, the CreateDIBSection function locates the bitmap bit values at offset dwOffset in the file-mapping object referred to by hSection. An application can later retrieve the hSection handle by calling the GetObject function with the HBITMAP returned by CreateDIBSection.If hSection is NULL, the system allocates memory for the DIB. In this case, the CreateDIBSection function ignores the dwOffset parameter. An application cannot later obtain a handle to this memory. The dshSection member of the DIBSECTION structure filled in by calling the GetObject function will be NULL.</param>
        /// <param name="offset">The offset from the beginning of the file-mapping object referenced by hSection where storage for the bitmap bit values is to begin. This value is ignored if hSection is NULL. The bitmap bit values are aligned on doubleword boundaries, so dwOffset must be a multiple of the size of a DWORD.If the function succeeds, the return value is a handle to the newly created DIB, and *ppvBits points to the bitmap bit values.If the function fails, the return value is NULL, and *ppvBits is NULL. To get extended error information, call GetLastError.GetLastError can return the following value:As noted above, if hSection is NULL, the system allocates memory for the DIB. The system closes the handle to that memory when you later delete the DIB by calling the DeleteObject function. If hSection is not NULL, you must close the hSection memory handle yourself after calling DeleteObject to delete the bitmap.You cannot paste a DIB section from one application into another application.CreateDIBSection does not use the BITMAPINFOHEADER parameters biXPelsPerMeter or biYPelsPerMeter and will not provide resolution information in the BITMAPINFO structure.You need to guarantee that the GDI subsystem has completed any drawing to a bitmap created by CreateDIBSection before you draw to the bitmap yourself. Access to the bitmap must be synchronized. Do this by calling the GdiFlush function. This applies to any use of the pointer to the bitmap bit values, including passing the pointer in calls to functions such as SetDIBits.ICM: No color management is done.BITMAPINFOBitmap FunctionsBitmaps OverviewCreateFileMappingDIBSECTIONDeleteObjectGdiFlushGetDIBColorTableGetObjectSetDIBColorTableSetDIBits</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateDIBSection(nint hdc, BITMAPINFO pbmi, uint usage, out nint ppvBits, nint hSection, uint offset);

        /// <summary>
        ///The CreateDiscardableBitmap function creates a discardable bitmap that is compatible with the specified device. The bitmap has the same bits-per-pixel format and the same color palette as the device. An application can select this bitmap as the current bitmap for a memory device that is compatible with the specified device.
        /// </summary>
        /// <param name="hdc">A handle to a device context.</param>
        /// <param name="cx">The width, in pixels, of the bitmap.</param>
        /// <param name="cy">The height, in pixels, of the bitmap.If the function succeeds, the return value is a handle to the compatible bitmap (DDB).If the function fails, the return value is NULL.When you no longer need the bitmap, call the DeleteObject function to delete it.Bitmap FunctionsBitmaps OverviewCreateCompatibleBitmapDeleteObject</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateDiscardableBitmap(nint hdc, int cx, int cy);

        /// <summary>
        ///The CreateEllipticRgn function creates an elliptical region.
        /// </summary>
        /// <param name="x1">Specifies the x-coordinate in logical units, of the upper-left corner of the bounding rectangle of the ellipse.</param>
        /// <param name="y1">Specifies the y-coordinate in logical units, of the upper-left corner of the bounding rectangle of the ellipse.</param>
        /// <param name="x2">Specifies the x-coordinate in logical units, of the lower-right corner of the bounding rectangle of the ellipse.</param>
        /// <param name="y2">Specifies the y-coordinate in logical units, of the lower-right corner of the bounding rectangle of the ellipse.If the function succeeds, the return value is the handle to the region.If the function fails, the return value is NULL.When you no longer need the HRGN object, call the DeleteObject function to delete it.A bounding rectangle defines the size, shape, and orientation of the region: The long sides of the rectangle define the length of the ellipse's major axis; the short sides define the length of the ellipse's minor axis; and the center of the rectangle defines the intersection of the major and minor axes.CreateEllipticRegnIndirectDeleteObjectRegion FunctionsRegions OverviewSelectObject</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateEllipticRgn(int x1, int y1, int x2, int y2);

        /// <summary>
        ///The CreateEllipticRgnIndirect function creates an elliptical region.
        /// </summary>
        /// <param name="lprect">Pointer to a RECT structure that contains the coordinates of the upper-left and lower-right corners of the bounding rectangle of the ellipse in logical units.If the function succeeds, the return value is the handle to the region.If the function fails, the return value is NULL.When you no longer need the HRGN object, call the DeleteObject function to delete it.A bounding rectangle defines the size, shape, and orientation of the region: The long sides of the rectangle define the length of the ellipse's major axis; the short sides define the length of the ellipse's minor axis; and the center of the rectangle defines the intersection of the major and minor axes.CreateEllipticRegnDeleteObjectRECTRegion FunctionsRegions OverviewSelectObject</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateEllipticRgnIndirect(RECT lprect);

        /// <summary>
        ///The CreateEnhMetaFile function creates a device context for an enhanced-format metafile. This device context can be used to store a device-independent picture.
        /// </summary>
        /// <param name="hdc">A handle to a reference device for the enhanced metafile. This parameter can be NULL; for more information, see Remarks.</param>
        /// <param name="lpFilename">A pointer to the file name for the enhanced metafile to be created. If this parameter is NULL, the enhanced metafile is memory based and its contents are lost when it is deleted by using the DeleteEnhMetaFile function.</param>
        /// <param name="lprc">A pointer to a RECT structure that specifies the dimensions (in .01-millimeter units) of the picture to be stored in the enhanced metafile.</param>
        /// <param name="lpDesc">A pointer to a string that specifies the name of the application that created the picture, as well as the picture's title. This parameter can be NULL; for more information, see Remarks.If the function succeeds, the return value is a handle to the device context for the enhanced metafile.If the function fails, the return value is NULL.Where text arguments must use Unicode characters, use the CreateEnhMetaFile function as a wide-character function. Where text arguments must use characters from the Windows character set, use this function as an ANSI function.The system uses the reference device identified by the hdcRef parameter to record the resolution and units of the device on which a picture originally appeared. If the hdcRef parameter is NULL, it uses the current display device for reference.The left and top members of the RECT structure pointed to by the lpRect parameter must be less than the right and bottom members, respectively. Points along the edges of the rectangle are included in the picture. If lpRect is NULL, the graphics device interface (GDI) computes the dimensions of the smallest rectangle that surrounds the picture drawn by the application. The lpRect parameter should be provided where possible.The string pointed to by the lpDescription parameter must contain a null character between the application name and the picture name and must terminate with two null characters, for example, "XYZ Graphics Editor\0Bald Eagle\0\0", where \0 represents the null character. If lpDescription is NULL, there is no corresponding entry in the enhanced-metafile header.Applications use the device context created by this function to store a graphics picture in an enhanced metafile. The handle identifying this device context can be passed to any GDI function.After an application stores a picture in an enhanced metafile, it can display the picture on any output device by calling the PlayEnhMetaFile function. When displaying the picture, the system uses the rectangle pointed to by the lpRect parameter and the resolution data from the reference device to position and scale the picture.The device context returned by this function contains the same default attributes associated with any new device context.Applications must use the GetWinMetaFileBits function to convert an enhanced metafile to the older Windows metafile format.The file name for the enhanced metafile should use the .emf extension.For an example, see Creating an Enhanced Metafile.CloseEnhMetaFileDeleteEnhMetaFileGetEnhMetaFileDescriptionGetEnhMetaFileHeaderGetWinMetaFileBitsMetafile FunctionsMetafiles OverviewPlayEnhMetaFileRECT</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateEnhMetaFileA(nint hdc, string lpFilename, RECT lprc, string lpDesc);

        /// <summary>
        ///The CreateEnhMetaFile function creates a device context for an enhanced-format metafile. This device context can be used to store a device-independent picture.
        /// </summary>
        /// <param name="hdc">A handle to a reference device for the enhanced metafile. This parameter can be NULL; for more information, see Remarks.</param>
        /// <param name="lpFilename">A pointer to the file name for the enhanced metafile to be created. If this parameter is NULL, the enhanced metafile is memory based and its contents are lost when it is deleted by using the DeleteEnhMetaFile function.</param>
        /// <param name="lprc">A pointer to a RECT structure that specifies the dimensions (in .01-millimeter units) of the picture to be stored in the enhanced metafile.</param>
        /// <param name="lpDesc">A pointer to a string that specifies the name of the application that created the picture, as well as the picture's title. This parameter can be NULL; for more information, see Remarks.If the function succeeds, the return value is a handle to the device context for the enhanced metafile.If the function fails, the return value is NULL.Where text arguments must use Unicode characters, use the CreateEnhMetaFile function as a wide-character function. Where text arguments must use characters from the Windows character set, use this function as an ANSI function.The system uses the reference device identified by the hdcRef parameter to record the resolution and units of the device on which a picture originally appeared. If the hdcRef parameter is NULL, it uses the current display device for reference.The left and top members of the RECT structure pointed to by the lpRect parameter must be less than the right and bottom members, respectively. Points along the edges of the rectangle are included in the picture. If lpRect is NULL, the graphics device interface (GDI) computes the dimensions of the smallest rectangle that surrounds the picture drawn by the application. The lpRect parameter should be provided where possible.The string pointed to by the lpDescription parameter must contain a null character between the application name and the picture name and must terminate with two null characters, for example, "XYZ Graphics Editor\0Bald Eagle\0\0", where \0 represents the null character. If lpDescription is NULL, there is no corresponding entry in the enhanced-metafile header.Applications use the device context created by this function to store a graphics picture in an enhanced metafile. The handle identifying this device context can be passed to any GDI function.After an application stores a picture in an enhanced metafile, it can display the picture on any output device by calling the PlayEnhMetaFile function. When displaying the picture, the system uses the rectangle pointed to by the lpRect parameter and the resolution data from the reference device to position and scale the picture.The device context returned by this function contains the same default attributes associated with any new device context.Applications must use the GetWinMetaFileBits function to convert an enhanced metafile to the older Windows metafile format.The file name for the enhanced metafile should use the .emf extension.For an example, see Creating an Enhanced Metafile.CloseEnhMetaFileDeleteEnhMetaFileGetEnhMetaFileDescriptionGetEnhMetaFileHeaderGetWinMetaFileBitsMetafile FunctionsMetafiles OverviewPlayEnhMetaFileRECT</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateEnhMetaFileW(nint hdc, string lpFilename, RECT lprc, string lpDesc);

        /// <summary>
        ///The CreateFont function creates a logical font with the specified characteristics. The logical font can subsequently be selected as the font for any device.
        /// </summary>
        /// <param name="cHeight">The height, in logical units, of the font's character cell or character. The character height value (also known as the em height) is the character cell height value minus the internal-leading value. The font mapper interprets the value specified in nHeight in the following manner.For all height comparisons, the font mapper looks for the largest font that does not exceed the requested size.This mapping occurs when the font is used for the first time.For the MM_TEXT mapping mode, you can use the following formula to specify a height for a font with a specified point size:</param>
        /// <param name="cWidth">The average width, in logical units, of characters in the requested font. If this value is zero, the font mapper chooses a closest match value. The closest match value is determined by comparing the absolute values of the difference between the current device's aspect ratio and the digitized aspect ratio of available fonts.</param>
        /// <param name="cEscapement">The angle, in tenths of degrees, between the escapement vector and the x-axis of the device. The escapement vector is parallel to the base line of a row of text.When the graphics mode is set to GM_ADVANCED, you can specify the escapement angle of the string independently of the orientation angle of the string's characters.When the graphics mode is set to GM_COMPATIBLE, nEscapement specifies both the escapement and orientation. You should set nEscapement and nOrientation to the same value.</param>
        /// <param name="cOrientation">The angle, in tenths of degrees, between each character's base line and the x-axis of the device.</param>
        /// <param name="cWeight">The weight of the font in the range 0 through 1000. For example, 400 is normal and 700 is bold. If this value is zero, a default weight is used.The following values are defined for convenience.</param>
        /// <param name="bItalic">Specifies an italic font if set to TRUE.</param>
        /// <param name="bUnderline">Specifies an underlined font if set to TRUE.</param>
        /// <param name="bStrikeOut">A strikeout font if set to TRUE.</param>
        /// <param name="iCharSet">The character set. The following values are predefined:DEFAULT_CHARSET is set to a value based on the current system locale. For example, when the system locale is English (United States), it is set as ANSI_CHARSET.Fonts with other character sets may exist in the operating system. If an application uses a font with an unknown character set, it should not attempt to translate or interpret strings that are rendered with that font.To ensure consistent results when creating a font, do not specify OEM_CHARSET or DEFAULT_CHARSET. If you specify a typeface name in the lpszFace parameter, make sure that the fdwCharSet value matches the character set of the typeface specified in lpszFace.</param>
        /// <param name="iOutPrecision">The output precision. The output precision defines how closely the output must match the requested font's height, width, character orientation, escapement, pitch, and font type. It can be one of the following values.Applications can use the OUT_DEVICE_PRECIS, OUT_RASTER_PRECIS, OUT_TT_PRECIS, and OUT_PS_ONLY_PRECIS values to control how the font mapper chooses a font when the operating system contains more than one font with a specified name. For example, if an operating system contains a font named Symbol in raster and TrueType form, specifying OUT_TT_PRECIS forces the font mapper to choose the TrueType version. Specifying OUT_TT_ONLY_PRECIS forces the font mapper to choose a TrueType font, even if it must substitute a TrueType font of another name.</param>
        /// <param name="iClipPrecision">The clipping precision. The clipping precision defines how to clip characters that are partially outside the clipping region. It can be one or more of the following values.</param>
        /// <param name="iQuality">The output quality. The output quality defines how carefully GDI must attempt to match the logical-font attributes to those of an actual physical font. It can be one of the following values.If the output quality is DEFAULT_QUALITY, DRAFT_QUALITY, or PROOF_QUALITY, then the font is antialiased if the SPI_GETFONTSMOOTHING system parameter is TRUE. Users can control this system parameter from the Control Panel. (The precise wording of the setting in the Control panel depends on the version of Windows, but it will be words to the effect of "Smooth edges of screen fonts".)</param>
        /// <param name="iPitchAndFamily">The pitch and family of the font. The two low-order bits specify the pitch of the font and can be one of the following values:An application can specify a value for the fdwPitchAndFamily parameter by using the Boolean OR operator to join a pitch constant with a family constant.Font families describe the look of a font in a general way. They are intended for specifying fonts when the exact typeface requested is not available.</param>
        /// <param name="pszFaceName">A pointer to a null-terminated string that specifies the typeface name of the font. The length of this string must not exceed 32 characters, including the terminating null character. The EnumFontFamilies function can be used to enumerate the typeface names of all currently available fonts. For more information, see the Remarks.If lpszFace is NULL or empty string, GDI uses the first font that matches the other specified attributes.If the function succeeds, the return value is a handle to a logical font.If the function fails, the return value is NULL.When you no longer need the font, call the DeleteObject function to delete it.To help protect the copyrights of vendors who provide fonts for Windows, applications should always report the exact name of a selected font. Because available fonts can vary from system to system, do not assume that the selected font is always the same as the requested font. For example, if you request a font named Palatino, but no such font is available on the system, the font mapper will substitute a font that has similar attributes but a different name. Always report the name of the selected font to the user.To get the appropriate font on different language versions of the OS, call EnumFontFamiliesEx with the desired font characteristics in the LOGFONT structure, then retrieve the appropriate typeface name and create the font using CreateFont or CreateFontIndirect.The font mapper for CreateFont,CreateFontIndirect, and CreateFontIndirectEx recognizes both the English and the localized typeface name, regardless of locale.The following situations do not support ClearType antialiasing:For another example, see "Setting Fonts for Menu-Item Text Strings" in Using Menus.CreateFontIndirectCreateFontIndirectExDeleteObjectEnumFontFamiliesEnumFontFamiliesExEnumFontsFont and Text FunctionsFonts and Text OverviewLOGFONTSelectObject</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateFontA(int cHeight, int cWidth, int cEscapement, int cOrientation, int cWeight, uint bItalic, uint bUnderline, uint bStrikeOut, uint iCharSet, uint iOutPrecision, uint iClipPrecision, uint iQuality, uint iPitchAndFamily, string pszFaceName);

        /// <summary>
        ///The CreateFontIndirect function creates a logical font that has the specified characteristics. The font can subsequently be selected as the current font for any device context.
        /// </summary>
        /// <param name="lplf">A pointer to a LOGFONT structure that defines the characteristics of the logical font.If the function succeeds, the return value is a handle to a logical font.If the function fails, the return value is NULL.The CreateFontIndirect function creates a logical font with the characteristics specified in the LOGFONT structure. When this font is selected by using the SelectObject function, GDI's font mapper attempts to match the logical font with an existing physical font. If it fails to find an exact match, it provides an alternative whose characteristics match as many of the requested characteristics as possible.To get the appropriate font on different language versions of the OS, call EnumFontFamiliesEx with the desired font characteristics in the LOGFONT structure, retrieve the appropriate typeface name, and create the font using CreateFont or CreateFontIndirect.When you no longer need the font, call the DeleteObject function to delete it.The fonts for many East Asian languages have two typeface names: an English name and a localized name. CreateFont and CreateFontIndirect take the localized typeface name only on a system locale that matches the language, while they take the English typeface name on all other system locales. The best method is to try one name and, on failure, try the other. Note that EnumFonts, EnumFontFamilies, and EnumFontFamiliesEx return the English typeface name if the system locale does not match the language of the font.The font mapper for CreateFont, CreateFontIndirect, and CreateFontIndirectEx recognizes both the English and the localized typeface name, regardless of locale.For an example, see Creating a Logical Font.CreateFontCreateFontIndirectExDeleteObjectEnumFontFamiliesEnumFontFamiliesExEnumFontsFont and Text FunctionsFonts and Text OverviewLOGFONTSelectObject</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateFontIndirectA(LOGFONTA lplf);

        /// <summary>
        ///The CreateFontIndirectEx function specifies a logical font that has the characteristics in the specified structure. The font can subsequently be selected as the current font for any device context.
        /// </summary>
        /// <param name="unnamedParam1">Pointer to an ENUMLOGFONTEXDV structure that defines the characteristics of a multiple master font.Note, this function ignores the elfDesignVector member in ENUMLOGFONTEXDV.If the function succeeds, the return value is the handle to the new ENUMLOGFONTEXDV structure.If the function fails, the return value is zero. No extended error information is available.The CreateFontIndirectEx function creates a logical font with the characteristics specified in the ENUMLOGFONTEXDV structure. When this font is selected by using the SelectObject function, GDI's font mapper attempts to match the logical font with an existing physical font. If it fails to find an exact match, it provides an alternative whose characteristics match as many of the requested characteristics as possible.When you no longer need the font, call the DeleteObject function to delete it.The font mapper for CreateFont, CreateFontIndirect, and CreateFontIndirectEx recognizes both the English and the localized typeface name, regardless of locale.CreateFontCreateFontIndirectENUMLOGFONTEXDVEnumFontFamiliesEnumFontFamiliesExEnumFontsFont and Text FunctionsFonts and Text Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateFontIndirectExA(ENUMLOGFONTEXDVA unnamedParam1);

        /// <summary>
        ///The CreateFontIndirectEx function specifies a logical font that has the characteristics in the specified structure. The font can subsequently be selected as the current font for any device context.
        /// </summary>
        /// <param name="unnamedParam1">Pointer to an ENUMLOGFONTEXDV structure that defines the characteristics of a multiple master font.Note, this function ignores the elfDesignVector member in ENUMLOGFONTEXDV.If the function succeeds, the return value is the handle to the new ENUMLOGFONTEXDV structure.If the function fails, the return value is zero. No extended error information is available.The CreateFontIndirectEx function creates a logical font with the characteristics specified in the ENUMLOGFONTEXDV structure. When this font is selected by using the SelectObject function, GDI's font mapper attempts to match the logical font with an existing physical font. If it fails to find an exact match, it provides an alternative whose characteristics match as many of the requested characteristics as possible.When you no longer need the font, call the DeleteObject function to delete it.The font mapper for CreateFont, CreateFontIndirect, and CreateFontIndirectEx recognizes both the English and the localized typeface name, regardless of locale.CreateFontCreateFontIndirectENUMLOGFONTEXDVEnumFontFamiliesEnumFontFamiliesExEnumFontsFont and Text FunctionsFonts and Text Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateFontIndirectExW(ENUMLOGFONTEXDVW unnamedParam1);

        /// <summary>
        ///The CreateFontIndirect function creates a logical font that has the specified characteristics. The font can subsequently be selected as the current font for any device context.
        /// </summary>
        /// <param name="lplf">A pointer to a LOGFONT structure that defines the characteristics of the logical font.If the function succeeds, the return value is a handle to a logical font.If the function fails, the return value is NULL.The CreateFontIndirect function creates a logical font with the characteristics specified in the LOGFONT structure. When this font is selected by using the SelectObject function, GDI's font mapper attempts to match the logical font with an existing physical font. If it fails to find an exact match, it provides an alternative whose characteristics match as many of the requested characteristics as possible.To get the appropriate font on different language versions of the OS, call EnumFontFamiliesEx with the desired font characteristics in the LOGFONT structure, retrieve the appropriate typeface name, and create the font using CreateFont or CreateFontIndirect.When you no longer need the font, call the DeleteObject function to delete it.The fonts for many East Asian languages have two typeface names: an English name and a localized name. CreateFont and CreateFontIndirect take the localized typeface name only on a system locale that matches the language, while they take the English typeface name on all other system locales. The best method is to try one name and, on failure, try the other. Note that EnumFonts, EnumFontFamilies, and EnumFontFamiliesEx return the English typeface name if the system locale does not match the language of the font.The font mapper for CreateFont, CreateFontIndirect, and CreateFontIndirectEx recognizes both the English and the localized typeface name, regardless of locale.For an example, see Creating a Logical Font.CreateFontCreateFontIndirectExDeleteObjectEnumFontFamiliesEnumFontFamiliesExEnumFontsFont and Text FunctionsFonts and Text OverviewLOGFONTSelectObject</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateFontIndirectW(LOGFONTW lplf);

        /// <summary>
        ///The CreateFont function creates a logical font with the specified characteristics. The logical font can subsequently be selected as the font for any device.
        /// </summary>
        /// <param name="cHeight">The height, in logical units, of the font's character cell or character. The character height value (also known as the em height) is the character cell height value minus the internal-leading value. The font mapper interprets the value specified in nHeight in the following manner.For all height comparisons, the font mapper looks for the largest font that does not exceed the requested size.This mapping occurs when the font is used for the first time.For the MM_TEXT mapping mode, you can use the following formula to specify a height for a font with a specified point size:</param>
        /// <param name="cWidth">The average width, in logical units, of characters in the requested font. If this value is zero, the font mapper chooses a closest match value. The closest match value is determined by comparing the absolute values of the difference between the current device's aspect ratio and the digitized aspect ratio of available fonts.</param>
        /// <param name="cEscapement">The angle, in tenths of degrees, between the escapement vector and the x-axis of the device. The escapement vector is parallel to the base line of a row of text.When the graphics mode is set to GM_ADVANCED, you can specify the escapement angle of the string independently of the orientation angle of the string's characters.When the graphics mode is set to GM_COMPATIBLE, nEscapement specifies both the escapement and orientation. You should set nEscapement and nOrientation to the same value.</param>
        /// <param name="cOrientation">The angle, in tenths of degrees, between each character's base line and the x-axis of the device.</param>
        /// <param name="cWeight">The weight of the font in the range 0 through 1000. For example, 400 is normal and 700 is bold. If this value is zero, a default weight is used.The following values are defined for convenience.</param>
        /// <param name="bItalic">Specifies an italic font if set to TRUE.</param>
        /// <param name="bUnderline">Specifies an underlined font if set to TRUE.</param>
        /// <param name="bStrikeOut">A strikeout font if set to TRUE.</param>
        /// <param name="iCharSet">The character set. The following values are predefined:DEFAULT_CHARSET is set to a value based on the current system locale. For example, when the system locale is English (United States), it is set as ANSI_CHARSET.Fonts with other character sets may exist in the operating system. If an application uses a font with an unknown character set, it should not attempt to translate or interpret strings that are rendered with that font.To ensure consistent results when creating a font, do not specify OEM_CHARSET or DEFAULT_CHARSET. If you specify a typeface name in the lpszFace parameter, make sure that the fdwCharSet value matches the character set of the typeface specified in lpszFace.</param>
        /// <param name="iOutPrecision">The output precision. The output precision defines how closely the output must match the requested font's height, width, character orientation, escapement, pitch, and font type. It can be one of the following values.Applications can use the OUT_DEVICE_PRECIS, OUT_RASTER_PRECIS, OUT_TT_PRECIS, and OUT_PS_ONLY_PRECIS values to control how the font mapper chooses a font when the operating system contains more than one font with a specified name. For example, if an operating system contains a font named Symbol in raster and TrueType form, specifying OUT_TT_PRECIS forces the font mapper to choose the TrueType version. Specifying OUT_TT_ONLY_PRECIS forces the font mapper to choose a TrueType font, even if it must substitute a TrueType font of another name.</param>
        /// <param name="iClipPrecision">The clipping precision. The clipping precision defines how to clip characters that are partially outside the clipping region. It can be one or more of the following values.</param>
        /// <param name="iQuality">The output quality. The output quality defines how carefully GDI must attempt to match the logical-font attributes to those of an actual physical font. It can be one of the following values.If the output quality is DEFAULT_QUALITY, DRAFT_QUALITY, or PROOF_QUALITY, then the font is antialiased if the SPI_GETFONTSMOOTHING system parameter is TRUE. Users can control this system parameter from the Control Panel. (The precise wording of the setting in the Control panel depends on the version of Windows, but it will be words to the effect of "Smooth edges of screen fonts".)</param>
        /// <param name="iPitchAndFamily">The pitch and family of the font. The two low-order bits specify the pitch of the font and can be one of the following values:An application can specify a value for the fdwPitchAndFamily parameter by using the Boolean OR operator to join a pitch constant with a family constant.Font families describe the look of a font in a general way. They are intended for specifying fonts when the exact typeface requested is not available.</param>
        /// <param name="pszFaceName">A pointer to a null-terminated string that specifies the typeface name of the font. The length of this string must not exceed 32 characters, including the terminating null character. The EnumFontFamilies function can be used to enumerate the typeface names of all currently available fonts. For more information, see the Remarks.If lpszFace is NULL or empty string, GDI uses the first font that matches the other specified attributes.If the function succeeds, the return value is a handle to a logical font.If the function fails, the return value is NULL.When you no longer need the font, call the DeleteObject function to delete it.To help protect the copyrights of vendors who provide fonts for Windows, applications should always report the exact name of a selected font. Because available fonts can vary from system to system, do not assume that the selected font is always the same as the requested font. For example, if you request a font named Palatino, but no such font is available on the system, the font mapper will substitute a font that has similar attributes but a different name. Always report the name of the selected font to the user.To get the appropriate font on different language versions of the OS, call EnumFontFamiliesEx with the desired font characteristics in the LOGFONT structure, then retrieve the appropriate typeface name and create the font using CreateFont or CreateFontIndirect.The font mapper for CreateFont,CreateFontIndirect, and CreateFontIndirectEx recognizes both the English and the localized typeface name, regardless of locale.The following situations do not support ClearType antialiasing:For another example, see "Setting Fonts for Menu-Item Text Strings" in Using Menus.CreateFontIndirectCreateFontIndirectExDeleteObjectEnumFontFamiliesEnumFontFamiliesExEnumFontsFont and Text FunctionsFonts and Text OverviewLOGFONTSelectObject</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateFontW(int cHeight, int cWidth, int cEscapement, int cOrientation, int cWeight, uint bItalic, uint bUnderline, uint bStrikeOut, uint iCharSet, uint iOutPrecision, uint iClipPrecision, uint iQuality, uint iPitchAndFamily, string pszFaceName);

        /// <summary>
        ///The CreateHalftonePalette function creates a halftone palette for the specified device context (DC).
        /// </summary>
        /// <param name="hdc">A handle to the device context.If the function succeeds, the return value is a handle to a logical halftone palette.If the function fails, the return value is zero.An application should create a halftone palette when the stretching mode of a device context is set to HALFTONE. The logical halftone palette returned by CreateHalftonePalette should then be selected and realized into the device context before the StretchBlt or StretchDIBits function is called.When you no longer need the palette, call the DeleteObject function to delete it.Color FunctionsColors OverviewDeleteObjectRealizePaletteSelectPaletteSetStretchBltModeStretchBltStretchDIBits</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateHalftonePalette(nint hdc);

        /// <summary>
        ///The CreateHatchBrush function creates a logical brush that has the specified hatch pattern and color.
        /// </summary>
        /// <param name="iHatch">The hatch style of the brush. This parameter can be one of the following values.</param>
        /// <param name="color">The foreground color of the brush that is used for the hatches. To create a COLORREF color value, use the RGB macro.If the function succeeds, the return value identifies a logical brush.If the function fails, the return value is NULL.A brush is a bitmap that the system uses to paint the interiors of filled shapes.After an application creates a brush by calling CreateHatchBrush, it can select that brush into any device context by calling the SelectObject function. It can also call SetBkMode to affect the rendering of the brush.If an application uses a hatch brush to fill the backgrounds of both a parent and a child window with matching color, you must set the brush origin before painting the background of the child window. You can do this by calling the SetBrushOrgEx function. Your application can retrieve the current brush origin by calling the GetBrushOrgEx function.When you no longer need the brush, call the DeleteObject function to delete it.ICM: No color is defined at brush creation. However, color management is performed when the brush is selected into an ICM-enabled device context.The following example creates a logical brush that has the specified hatch pattern and color. You can also set a hatch brush background to transparent or to opaque.Brush FunctionsBrushes OverviewCOLORREFCreateDIBPatternBrushCreateDIBPatternBrushPtCreatePatternBrushCreateSolidBrushDeleteObjectGetBrushOrgExRGBSelectObjectSetBkModeSetBrushOrgEx</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateHatchBrush(int iHatch, int color);

        /// <summary>
        ///The CreateIC function creates an information context for the specified device. The information context provides a fast way to get information about the device without creating a device context (DC). However, GDI drawing functions cannot accept a handle to an information context.
        /// </summary>
        /// <param name="pszDriver">A pointer to a null-terminated character string that specifies the name of the device driver (for example, Epson).</param>
        /// <param name="pszDevice">A pointer to a null-terminated character string that specifies the name of the specific output device being used, as shown by the Print Manager (for example, Epson FX-80). It is not the printer model name. The lpszDevice parameter must be used.pszPortThis parameter is ignored and should be set to NULL. It is provided only for compatibility with 16-bit Windows.</param>
        /// <param name="pszPort"></param>
        /// <param name="pdm">A pointer to a DEVMODE structure containing device-specific initialization data for the device driver. The DocumentProperties function retrieves this structure filled in for a specified device. The lpdvmInit parameter must be NULL if the device driver is to use the default initialization (if any) specified by the user.If the function succeeds, the return value is the handle to an information context.If the function fails, the return value is NULL.When you no longer need the information DC, call the DeleteDC function.DEVMODEDeleteDCDevice Context FunctionsDevice Contexts OverviewDocumentPropertiesGetDeviceCaps</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateICA(string pszDriver, string pszDevice, string pszPort, int pdm);

        /// <summary>
        ///The CreateIC function creates an information context for the specified device. The information context provides a fast way to get information about the device without creating a device context (DC). However, GDI drawing functions cannot accept a handle to an information context.
        /// </summary>
        /// <param name="pszDriver">A pointer to a null-terminated character string that specifies the name of the device driver (for example, Epson).</param>
        /// <param name="pszDevice">A pointer to a null-terminated character string that specifies the name of the specific output device being used, as shown by the Print Manager (for example, Epson FX-80). It is not the printer model name. The lpszDevice parameter must be used.pszPortThis parameter is ignored and should be set to NULL. It is provided only for compatibility with 16-bit Windows.</param>
        /// <param name="pszPort"></param>
        /// <param name="pdm">A pointer to a DEVMODE structure containing device-specific initialization data for the device driver. The DocumentProperties function retrieves this structure filled in for a specified device. The lpdvmInit parameter must be NULL if the device driver is to use the default initialization (if any) specified by the user.If the function succeeds, the return value is the handle to an information context.If the function fails, the return value is NULL.When you no longer need the information DC, call the DeleteDC function.DEVMODEDeleteDCDevice Context FunctionsDevice Contexts OverviewDocumentPropertiesGetDeviceCaps</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateICW(string pszDriver, string pszDevice, string pszPort, int pdm);

        /// <summary>
        ///The CreateMetaFile function creates a device context for a Windows-format metafile.
        /// </summary>
        /// <param name="pszFile">A pointer to the file name for the Windows-format metafile to be created. If this parameter is NULL, the Windows-format metafile is memory based and its contents are lost when it is deleted by using the DeleteMetaFile function.If the function succeeds, the return value is a handle to the device context for the Windows-format metafile.If the function fails, the return value is NULL.Where text arguments must use Unicode characters, use the CreateMetaFile function as a wide-character function. Where text arguments must use characters from the Windows character set, use this function as an ANSI function.CreateMetaFile is a Windows-format metafile function. This function supports only 16-bit Windows-based applications, which are listed in Windows-Format Metafiles. It does not record or play back GDI functions such as PolyBezier, which were not part of 16-bit Windows.The device context created by this function can be used to record GDI output functions in a Windows-format metafile. It cannot be used with GDI query functions such as GetTextColor. When the device context is used with a GDI output function, the return value of that function becomes TRUE if the function is recorded and FALSE otherwise. When an object is selected by using the SelectObject function, only a copy of the object is recorded. The object still belongs to the application.To create a scalable Windows-format metafile, record the graphics output in the MM_ANISOTROPIC mapping mode. The file cannot contain functions that modify the viewport origin and extents, nor can it contain device-dependent functions such as the SelectClipRgn function. Once created, the Windows metafile can be scaled and rendered to any output device-format by defining the viewport origin and extents of the picture before playing it.CloseMetaFileCreateEnhMetaFileDeleteMetaFileGetTextColorMetafile FunctionsMetafiles OverviewSelectClipRgnSelectObject</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateMetaFileA(string pszFile);

        /// <summary>
        ///The CreateMetaFile function creates a device context for a Windows-format metafile.
        /// </summary>
        /// <param name="pszFile">A pointer to the file name for the Windows-format metafile to be created. If this parameter is NULL, the Windows-format metafile is memory based and its contents are lost when it is deleted by using the DeleteMetaFile function.If the function succeeds, the return value is a handle to the device context for the Windows-format metafile.If the function fails, the return value is NULL.Where text arguments must use Unicode characters, use the CreateMetaFile function as a wide-character function. Where text arguments must use characters from the Windows character set, use this function as an ANSI function.CreateMetaFile is a Windows-format metafile function. This function supports only 16-bit Windows-based applications, which are listed in Windows-Format Metafiles. It does not record or play back GDI functions such as PolyBezier, which were not part of 16-bit Windows.The device context created by this function can be used to record GDI output functions in a Windows-format metafile. It cannot be used with GDI query functions such as GetTextColor. When the device context is used with a GDI output function, the return value of that function becomes TRUE if the function is recorded and FALSE otherwise. When an object is selected by using the SelectObject function, only a copy of the object is recorded. The object still belongs to the application.To create a scalable Windows-format metafile, record the graphics output in the MM_ANISOTROPIC mapping mode. The file cannot contain functions that modify the viewport origin and extents, nor can it contain device-dependent functions such as the SelectClipRgn function. Once created, the Windows metafile can be scaled and rendered to any output device-format by defining the viewport origin and extents of the picture before playing it.CloseMetaFileCreateEnhMetaFileDeleteMetaFileGetTextColorMetafile FunctionsMetafiles OverviewSelectClipRgnSelectObject</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateMetaFileW(string pszFile);

        /// <summary>
        ///The CreatePalette function creates a logical palette.
        /// </summary>
        /// <param name="plpal">A pointer to a LOGPALETTE structure that contains information about the colors in the logical palette.If the function succeeds, the return value is a handle to a logical palette.If the function fails, the return value is NULL.An application can determine whether a device supports palette operations by calling the GetDeviceCaps function and specifying the RASTERCAPS constant.Once an application creates a logical palette, it can select that palette into a device context by calling the SelectPalette function. A palette selected into a device context can be realized by calling the RealizePalette function.When you no longer need the palette, call the DeleteObject function to delete it.Color FunctionsColors OverviewDeleteObjectGetDeviceCapsLOGPALETTERealizePaletteSelectPalette</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreatePalette(LOGPALETTE plpal);

        /// <summary>
        ///The CreatePatternBrush function creates a logical brush with the specified bitmap pattern. The bitmap can be a DIB section bitmap, which is created by the CreateDIBSection function, or it can be a device-dependent bitmap.
        /// </summary>
        /// <param name="hbm">A handle to the bitmap to be used to create the logical brush.If the function succeeds, the return value identifies a logical brush.If the function fails, the return value is NULL.A pattern brush is a bitmap that the system uses to paint the interiors of filled shapes.After an application creates a brush by calling CreatePatternBrush, it can select that brush into any device context by calling the SelectObject function.You can delete a pattern brush without affecting the associated bitmap by using the DeleteObject function. Therefore, you can then use this bitmap to create any number of pattern brushes.A brush created by using a monochrome (1 bit per pixel) bitmap has the text and background colors of the device context to which it is drawn. Pixels represented by a 0 bit are drawn with the current text color; pixels represented by a 1 bit are drawn with the current background color.ICM: No color is done at brush creation. However, color management is performed when the brush is selected into an ICM-enabled device context.For an example, see Using Brushes.Brush FunctionsBrushes OverviewCreateBitmapCreateBitmapIndirectCreateCompatibleBitmapCreateDIBPatternBrushCreateDIBPatternBrushPtCreateDIBSectionCreateHatchBrushDeleteObjectGetBrushOrgExLoadBitmapSelectObjectSetBrushOrgEx</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreatePatternBrush(nint hbm);

        /// <summary>
        ///The CreatePen function creates a logical pen that has the specified style, width, and color. The pen can subsequently be selected into a device context and used to draw lines and curves.
        /// </summary>
        /// <param name="iStyle">The pen style. It can be any one of the following values.</param>
        /// <param name="cWidth">The width of the pen, in logical units. If nWidth is zero, the pen is a single pixel wide, regardless of the current transformation.CreatePen returns a pen with the specified width but with the PS_SOLID style if you specify a width greater than one for the following styles: PS_DASH, PS_DOT, PS_DASHDOT, PS_DASHDOTDOT.</param>
        /// <param name="color">A color reference for the pen color. To generate a COLORREF structure, use the RGB macro.If the function succeeds, the return value is a handle that identifies a logical pen.If the function fails, the return value is NULL.After an application creates a logical pen, it can select that pen into a device context by calling the SelectObject function. After a pen is selected into a device context, it can be used to draw lines and curves.If the value specified by the nWidth parameter is zero, a line drawn with the created pen always is a single pixel wide regardless of the current transformation.If the value specified by nWidth is greater than 1, the fnPenStyle parameter must be PS_NULL, PS_SOLID, or PS_INSIDEFRAME.If the value specified by nWidth is greater than 1 and fnPenStyle is PS_INSIDEFRAME, the line associated with the pen is drawn inside the frame of all primitives except polygons and polylines.If the value specified by nWidth is greater than 1, fnPenStyle is PS_INSIDEFRAME, and the color specified by the crColor parameter does not match one of the entries in the logical palette, the system draws lines by using a dithered color. Dithered colors are not available with solid pens.When using an iStyle parameter of PS_DASH, PS_DOT, PS_DASHDOT or PS_DASHDOTDOT, in order to make the gaps between the dashes or dots transparent, use SetBkMode to set the mode to TRANSPARENT.When you no longer need the pen, call the DeleteObject function to delete it.ICM: No color management is done at creation. However, color management is performed when the pen is selected into an ICM-enabled device context.For an example, see Creating Colored Pens and Brushes.COLORREFCreatePenIndirectDeleteObjectExtCreatePenGetObjectPen FunctionsPens OverviewRGBSelectObject</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreatePen(int iStyle, int cWidth, int color);

        /// <summary>
        ///The CreatePenIndirect function creates a logical cosmetic pen that has the style, width, and color specified in a structure.
        /// </summary>
        /// <param name="plpen">Pointer to a LOGPEN structure that specifies the pen's style, width, and color.If the function succeeds, the return value is a handle that identifies a logical cosmetic pen.If the function fails, the return value is NULL.After an application creates a logical pen, it can select that pen into a device context by calling the SelectObject function. After a pen is selected into a device context, it can be used to draw lines and curves.When you no longer need the pen, call the DeleteObject function to delete it.CreatePenDeleteObjectExtCreatePenGetObjectLOGPENPen FunctionsPens OverviewRGBSelectObject</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreatePenIndirect(LOGPEN plpen);

        /// <summary>
        ///The CreatePolygonRgn function creates a polygonal region.
        /// </summary>
        /// <param name="pptl">A pointer to an array of POINT structures that define the vertices of the polygon in logical units. The polygon is presumed closed. Each vertex can be specified only once.</param>
        /// <param name="cPoint">The number of points in the array.</param>
        /// <param name="iMode">The fill mode used to determine which pixels are in the region. This parameter can be one of the following values.For more information about these modes, see the SetPolyFillMode function.If the function succeeds, the return value is the handle to the region.If the function fails, the return value is NULL.When you no longer need the HRGN object, call the DeleteObject function to delete it.Region coordinates are represented as 27-bit signed integers.Regions created by the Create<shape>Rgn methods (such as CreateRectRgn and CreatePolygonRgn) only include the interior of the shape; the shape's outline is excluded from the region. This means that any point on a line between two sequential vertices is not included in the region. If you were to call PtInRegion for such a point, it would return zero as the result.CreatePolyPolygonRgnCreateRectRgnCreateRectRgnIndirectCreateRoundRectRgnDeleteObjectExtCreateRegionGetRegionDataPOINTRegion FunctionsRegions OverviewSelectObjectSetPolyFillMode</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreatePolygonRgn(POINT pptl, int cPoint, int iMode);

        /// <summary>
        ///The CreatePolyPolygonRgn function creates a region consisting of a series of polygons. The polygons can overlap.
        /// </summary>
        /// <param name="pptl">A pointer to an array of POINT structures that define the vertices of the polygons in logical units. The polygons are specified consecutively. Each polygon is presumed closed and each vertex is specified only once.</param>
        /// <param name="pc">A pointer to an array of integers, each of which specifies the number of points in one of the polygons in the array pointed to by lppt.</param>
        /// <param name="cPoly">The total number of integers in the array pointed to by lpPolyCounts.</param>
        /// <param name="iMode">The fill mode used to determine which pixels are in the region. This parameter can be one of the following values.For more information about these modes, see the SetPolyFillMode function.If the function succeeds, the return value is the handle to the region.If the function fails, the return value is zero.When you no longer need the HRGN object, call the DeleteObject function to delete it.Region coordinates are represented as 27-bit signed integers.CreatePolygonRgnCreateRectRgnCreateRectRgnIndirectCreateRoundRectRgnDeleteObjectExtCreateRegionGetRegionDataPOINTRegion FunctionsRegions OverviewSelectObjectSetPolyFillMode</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreatePolyPolygonRgn(POINT pptl, int pc, int cPoly, int iMode);

        /// <summary>
        ///The CreateRectRgn function creates a rectangular region.
        /// </summary>
        /// <param name="x1">Specifies the x-coordinate of the upper-left corner of the region in logical units.</param>
        /// <param name="y1">Specifies the y-coordinate of the upper-left corner of the region in logical units.</param>
        /// <param name="x2">Specifies the x-coordinate of the lower-right corner of the region in logical units.</param>
        /// <param name="y2">Specifies the y-coordinate of the lower-right corner of the region in logical units.If the function succeeds, the return value is the handle to the region.If the function fails, the return value is NULL.When you no longer need the HRGN object, call the DeleteObject function to delete it.Region coordinates are represented as 27-bit signed integers.Regions created by the Create<shape>Rgn methods (such as CreateRectRgn and CreatePolygonRgn) only include the interior of the shape; the shape's outline is excluded from the region. This means that any point on a line between two sequential vertices is not included in the region. If you were to call PtInRegion for such a point, it would return zero as the result.For an example, see Drawing Markers.CreatePolyPolygonRgnCreatePolygonRgnCreateRectRgnIndirectCreateRoundRectRgnDeleteObjectExtCreateRegionGetRegionDataRegion FunctionsRegions OverviewSelectObject</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateRectRgn(int x1, int y1, int x2, int y2);

        /// <summary>
        ///The CreateRectRgnIndirect function creates a rectangular region.
        /// </summary>
        /// <param name="lprect">Pointer to a RECT structure that contains the coordinates of the upper-left and lower-right corners of the rectangle that defines the region in logical units.If the function succeeds, the return value is the handle to the region.If the function fails, the return value is NULL.When you no longer need the HRGN object, call the DeleteObject function to delete it.Region coordinates are represented as 27-bit signed integers.The region will be exclusive of the bottom and right edges.CreatePolyPolygonRgnCreatePolygonRgnCreateRectRgnCreateRoundRectRgnDeleteObjectExtCreateRegionGetRegionDataRECTRegion FunctionsRegions OverviewSelectObject</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateRectRgnIndirect(RECT lprect);

        /// <summary>
        ///The CreateRoundRectRgn function creates a rectangular region with rounded corners.
        /// </summary>
        /// <param name="x1">Specifies the x-coordinate of the upper-left corner of the region in device units.</param>
        /// <param name="y1">Specifies the y-coordinate of the upper-left corner of the region in device units.</param>
        /// <param name="x2">Specifies the x-coordinate of the lower-right corner of the region in device units.</param>
        /// <param name="y2">Specifies the y-coordinate of the lower-right corner of the region in device units.</param>
        /// <param name="w">Specifies the width of the ellipse used to create the rounded corners in device units.</param>
        /// <param name="h">Specifies the height of the ellipse used to create the rounded corners in device units.If the function succeeds, the return value is the handle to the region.If the function fails, the return value is NULL.When you no longer need the HRGN object call the DeleteObject function to delete it.Region coordinates are represented as 27-bit signed integers.CreatePolyPolygonRgnCreatePolygonRgnCreateRectRgnCreateRectRgnIndirectDeleteObjectExtCreateRegionGetRegionDataRegion FunctionsRegions OverviewSelectObject</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateRoundRectRgn(int x1, int y1, int x2, int y2, int w, int h);

        /// <summary>
        ///[The CreateScalableFontResource function is available for use in the operating systems specified in the Requirements section. It may be
        /// </summary>
        /// <param name="fdwHidden">Specifies whether the font is a read-only font. This parameter can be one of the following values.</param>
        /// <param name="lpszFont">A pointer to a null-terminated string specifying the name of the font resource file to create. If this parameter specifies an existing font resource file, the function fails.</param>
        /// <param name="lpszFile">A pointer to a null-terminated string specifying the name of the scalable font file that this function uses to create the font resource file.</param>
        /// <param name="lpszPath">A pointer to a null-terminated string specifying the path to the scalable font file.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.If lpszFontRes specifies an existing font file, GetLastError returns ERROR_FILE_EXISTSThe CreateScalableFontResource function is used by applications that install TrueType fonts. An application uses the CreateScalableFontResource function to create a font resource file (typically with a .fot file name extension) and then uses the AddFontResource function to install the font. The TrueType font file (typically with a .ttf file name extension) must be in the System subdirectory of the Windows directory to be used by the AddFontResource function.The CreateScalableFontResource function currently supports only TrueType-technology scalable fonts.When the lpszFontFile parameter specifies only a file name and extension, the lpszCurrentPath parameter must specify a path. When the lpszFontFile parameter specifies a full path, the lpszCurrentPath parameter must be NULL or a pointer to NULL.When only a file name and extension are specified in the lpszFontFile parameter and a path is specified in the lpszCurrentPath parameter, the string in lpszFontFile is copied into the .fot file as the .ttf file that belongs to this resource. When the AddFontResource function is called, the operating system assumes that the .ttf file has been copied into the System directory (or into the main Windows directory in the case of a network installation). The .ttf file need not be in this directory when the CreateScalableFontResource function is called, because the lpszCurrentPath parameter contains the directory information. A resource created in this manner does not contain absolute path information and can be used in any installation.When a path is specified in the lpszFontFile parameter and NULL is specified in the lpszCurrentPath parameter, the string in lpszFontFile is copied into the .fot file. In this case, when the AddFontResource function is called, the .ttf file must be at the location specified in the lpszFontFile parameter when the CreateScalableFontResource function was called; the lpszCurrentPath parameter is not needed. A resource created in this manner contains absolute references to paths and drives and does not work if the .ttf file is moved to a different location.AddFontResourceEnumFontFamiliesEnumFontsFont and Text FunctionsFonts and Text Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CreateScalableFontResourceA(uint fdwHidden, string lpszFont, string lpszFile, string lpszPath);

        /// <summary>
        ///[The CreateScalableFontResource function is available for use in the operating systems specified in the Requirements section. It may be
        /// </summary>
        /// <param name="fdwHidden">Specifies whether the font is a read-only font. This parameter can be one of the following values.</param>
        /// <param name="lpszFont">A pointer to a null-terminated string specifying the name of the font resource file to create. If this parameter specifies an existing font resource file, the function fails.</param>
        /// <param name="lpszFile">A pointer to a null-terminated string specifying the name of the scalable font file that this function uses to create the font resource file.</param>
        /// <param name="lpszPath">A pointer to a null-terminated string specifying the path to the scalable font file.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.If lpszFontRes specifies an existing font file, GetLastError returns ERROR_FILE_EXISTSThe CreateScalableFontResource function is used by applications that install TrueType fonts. An application uses the CreateScalableFontResource function to create a font resource file (typically with a .fot file name extension) and then uses the AddFontResource function to install the font. The TrueType font file (typically with a .ttf file name extension) must be in the System subdirectory of the Windows directory to be used by the AddFontResource function.The CreateScalableFontResource function currently supports only TrueType-technology scalable fonts.When the lpszFontFile parameter specifies only a file name and extension, the lpszCurrentPath parameter must specify a path. When the lpszFontFile parameter specifies a full path, the lpszCurrentPath parameter must be NULL or a pointer to NULL.When only a file name and extension are specified in the lpszFontFile parameter and a path is specified in the lpszCurrentPath parameter, the string in lpszFontFile is copied into the .fot file as the .ttf file that belongs to this resource. When the AddFontResource function is called, the operating system assumes that the .ttf file has been copied into the System directory (or into the main Windows directory in the case of a network installation). The .ttf file need not be in this directory when the CreateScalableFontResource function is called, because the lpszCurrentPath parameter contains the directory information. A resource created in this manner does not contain absolute path information and can be used in any installation.When a path is specified in the lpszFontFile parameter and NULL is specified in the lpszCurrentPath parameter, the string in lpszFontFile is copied into the .fot file. In this case, when the AddFontResource function is called, the .ttf file must be at the location specified in the lpszFontFile parameter when the CreateScalableFontResource function was called; the lpszCurrentPath parameter is not needed. A resource created in this manner contains absolute references to paths and drives and does not work if the .ttf file is moved to a different location.AddFontResourceEnumFontFamiliesEnumFontsFont and Text FunctionsFonts and Text Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CreateScalableFontResourceW(uint fdwHidden, string lpszFont, string lpszFile, string lpszPath);

        /// <summary>
        ///The CreateSolidBrush function creates a logical brush that has the specified solid color.
        /// </summary>
        /// <param name="color">The color of the brush. To create a COLORREF color value, use the RGB macro.If the function succeeds, the return value identifies a logical brush.If the function fails, the return value is NULL.When you no longer need the HBRUSH object, call the DeleteObject function to delete it.A solid brush is a bitmap that the system uses to paint the interiors of filled shapes.After an application creates a brush by calling CreateSolidBrush, it can select that brush into any device context by calling the SelectObject function.To paint with a system color brush, an application should use GetSysColorBrush (nIndex) instead of CreateSolidBrush(GetSysColor(nIndex)), because GetSysColorBrush returns a cached brush instead of allocating a new one.ICM: No color management is done at brush creation. However, color management is performed when the brush is selected into an ICM-enabled device context.For an example, see Creating Colored Pens and Brushes.Brush FunctionsBrushes OverviewCOLORREFCreateDIBPatternBrushCreateDIBPatternBrushPtCreateHatchBrushCreatePatternBrushDeleteObjectGetSysColorBrushRGBSelectObject</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint CreateSolidBrush(int color);

        /// <summary>
        ///The DeleteColorSpace function removes and destroys a specified color space.
        /// </summary>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool DeleteColorSpace(nint hcs);

        /// <summary>
        ///The DeleteDC function deletes the specified device context (DC).
        /// </summary>
        /// <param name="hdc">A handle to the device context.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.An application must not delete a DC whose handle was obtained by calling the GetDC function. Instead, it must call the ReleaseDC function to free the DC.For an example, see Retrieving the Capabilities of a Printer.CreateDCDevice Context FunctionsDevice Contexts OverviewGetDCReleaseDC</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool DeleteDC(nint hdc);

        /// <summary>
        ///The DeleteEnhMetaFile function deletes an enhanced-format metafile or an enhanced-format metafile handle.
        /// </summary>
        /// <param name="hmf">A handle to an enhanced metafile.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.If the hemf parameter identifies an enhanced metafile stored in memory, the DeleteEnhMetaFile function deletes the metafile. If hemf identifies a metafile stored on a disk, the function deletes the metafile handle but does not destroy the actual metafile. An application can retrieve the file by calling the GetEnhMetaFile function.For an example, see Opening an Enhanced Metafile and Displaying Its Contents.CopyEnhMetaFileCreateEnhMetaFileGetEnhMetaFileMetafile FunctionsMetafiles Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool DeleteEnhMetaFile(nint hmf);

        /// <summary>
        ///The DeleteMetaFile function deletes a Windows-format metafile or Windows-format metafile handle.
        /// </summary>
        /// <param name="hmf">A handle to a Windows-format metafile.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.If the metafile identified by the hmf parameter is stored in memory (rather than on a disk), its content is lost when it is deleted by using the DeleteMetaFile function.CopyMetaFileCreateMetaFileDeleteEnhMetaFileMetafile FunctionsMetafiles Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool DeleteMetaFile(nint hmf);

        /// <summary>
        ///The DeleteObject function deletes a logical pen, brush, font, bitmap, region, or palette, freeing all system resources associated with the object. After the object is deleted, the specified handle is no longer valid.
        /// </summary>
        /// <param name="ho">A handle to a logical pen, brush, font, bitmap, region, or palette.If the function succeeds, the return value is nonzero.If the specified handle is not valid or is currently selected into a DC, the return value is zero.Do not delete a drawing object (pen or brush) while it is still selected into a DC.When a pattern brush is deleted, the bitmap associated with the brush is not deleted. The bitmap must be deleted independently.For an example, see Creating Colored Pens and Brushes.Device Context FunctionsDevice Contexts OverviewSelectObject</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool DeleteObject(nint ho);

        /// <summary>
        ///The DescribePixelFormat function obtains information about the pixel format identified by iPixelFormat of the device associated with hdc. The function sets the members of the PIXELFORMATDESCRIPTOR structure pointed to by ppfd with that pixel format data.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int DescribePixelFormat(nint hdc, int iPixelFormat, uint nBytes, int ppfd);

        /// <summary>
        ///The DeviceCapabilities function retrieves the capabilities of a printer driver.
        /// </summary>
        /// <param name="pDevice">A pointer to a null-terminated string that contains the name of the printer. Note that this is the name of the printer, not of the printer driver.</param>
        /// <param name="pPort">A pointer to a null-terminated string that contains the name of the port to which the device is connected, such as LPT1.</param>
        /// <param name="fwCapability">The capabilities to be queried. This parameter can be one of the following values.</param>
        /// <param name="pOutput"></param>
        /// <param name="pDevMode">A pointer to a DEVMODE structure. If this parameter is NULL, DeviceCapabilities retrieves the current default initialization values for the specified printer driver. Otherwise, the function retrieves the values contained in the structure to which pDevMode points.If the function succeeds, the return value depends on the setting of the fwCapability parameter. A return value of zero generally indicates that, while the function completed successfully, there was some type of failure, such as a capability that is not supported. For more details, see the descriptions for the fwCapability values.If the function returns -1, this may mean either that the capability is not supported or there was a general function failure.If a printer driver supports custom device capabilities, the driver must call the SetPrinterData function for each custom capability. The SetPrinterData function adds the appropriate printer data to the print system, which enables 32-bit applications to access the custom capabilities on 64-bit Windows installations.For each custom capability, you must first add printer data that describes the type of the capability. To do this, when you call SetPrinterData, set the pValueName string to CustomDeviceCapabilityType_Xxx, where "Xxx" is the hexadecimal representation of the capability. For example, you might have "CustomDeviceCapabilityType_1234". The registry data that you set must be of the REG_DWORD type, and you must set its value to one of the following:DEVMODEDOCINFODocumentPropertiesGetDeviceCapsGetProcAddressLoadLibraryPOINTPrint Spooler API FunctionsPrintingStartDoc</param>

        [DllImport("WinSpool.drv", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int DeviceCapabilitiesA(string pDevice, string pPort, short fwCapability, out string pOutput, int pDevMode);

        /// <summary>
        ///The DeviceCapabilities function retrieves the capabilities of a printer driver.
        /// </summary>
        /// <param name="pDevice">A pointer to a null-terminated string that contains the name of the printer. Note that this is the name of the printer, not of the printer driver.</param>
        /// <param name="pPort">A pointer to a null-terminated string that contains the name of the port to which the device is connected, such as LPT1.</param>
        /// <param name="fwCapability">The capabilities to be queried. This parameter can be one of the following values.</param>
        /// <param name="pOutput"></param>
        /// <param name="pDevMode">A pointer to a DEVMODE structure. If this parameter is NULL, DeviceCapabilities retrieves the current default initialization values for the specified printer driver. Otherwise, the function retrieves the values contained in the structure to which pDevMode points.If the function succeeds, the return value depends on the setting of the fwCapability parameter. A return value of zero generally indicates that, while the function completed successfully, there was some type of failure, such as a capability that is not supported. For more details, see the descriptions for the fwCapability values.If the function returns -1, this may mean either that the capability is not supported or there was a general function failure.If a printer driver supports custom device capabilities, the driver must call the SetPrinterData function for each custom capability. The SetPrinterData function adds the appropriate printer data to the print system, which enables 32-bit applications to access the custom capabilities on 64-bit Windows installations.For each custom capability, you must first add printer data that describes the type of the capability. To do this, when you call SetPrinterData, set the pValueName string to CustomDeviceCapabilityType_Xxx, where "Xxx" is the hexadecimal representation of the capability. For example, you might have "CustomDeviceCapabilityType_1234". The registry data that you set must be of the REG_DWORD type, and you must set its value to one of the following:DEVMODEDOCINFODocumentPropertiesGetDeviceCapsGetProcAddressLoadLibraryPOINTPrint Spooler API FunctionsPrintingStartDoc</param>

        [DllImport("WinSpool.drv", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int DeviceCapabilitiesW(string pDevice, string pPort, short fwCapability, out string pOutput, int pDevMode);

        /// <summary>
        ///The DPtoLP function converts device coordinates into logical coordinates. The conversion depends on the mapping mode of the device context, the settings of the origins and extents for the window and viewport, and the world transformation.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="c">The number of points in the array.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The DPtoLP function fails if the device coordinates exceed 27 bits, or if the converted logical coordinates exceed 32 bits. In the case of such an overflow, the results for all the points are undefined.For an example, see Using Coordinate Spaces and Transformations.Coordinate Space and Transformation FunctionsCoordinate Spaces and Transformations OverviewLPtoDPPOINT</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool DPtoLP(nint hdc, int c);

        /// <summary>
        ///The DrawEscape function provides drawing capabilities of the specified video display that are not directly available through the graphics device interface (GDI).
        /// </summary>
        /// <param name="hdc">A handle to the DC for the specified video display.</param>
        /// <param name="iEscape">The escape function to be performed.</param>
        /// <param name="cjIn">The number of bytes of data pointed to by the lpszInData parameter.</param>
        /// <param name="lpIn">A pointer to the input structure required for the specified escape.If the function is successful, the return value is greater than zero except for the QUERYESCSUPPORT draw escape, which checks for implementation only.If the escape is not implemented, the return value is zero.If an error occurred, the return value is less than zero.When an application calls the DrawEscape function, the data identified by cbInput and lpszInData is passed directly to the specified display driver.Device Context FunctionsDevice Contexts Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int DrawEscape(nint hdc, int iEscape, int cjIn, string lpIn);

        /// <summary>
        ///The Ellipse function draws an ellipse. The center of the ellipse is the center of the specified bounding rectangle. The ellipse is outlined by using the current pen and is filled by using the current brush.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="left">The x-coordinate, in logical coordinates, of the upper-left corner of the bounding rectangle.</param>
        /// <param name="top">The y-coordinate, in logical coordinates, of the upper-left corner of the bounding rectangle.</param>
        /// <param name="right">The x-coordinate, in logical coordinates, of the lower-right corner of the bounding rectangle.</param>
        /// <param name="bottom">The y-coordinate, in logical coordinates, of the lower-right corner of the bounding rectangle.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The current position is neither used nor updated by Ellipse.For an example, see Using Filled Shapes.ArcArcToFilled Shape FunctionsFilled Shapes Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool Ellipse(nint hdc, int left, int top, int right, int bottom);

        /// <summary>
        ///The EndDoc function ends a print job.
        /// </summary>
        /// <param name="hdc">Handle to the device context for the print job.If the function succeeds, the return value is greater than zero.If the function fails, the return value is less than or equal to zero.For a sample program that uses this function, see How To: Print Using the GDI Print API.Print Spooler API FunctionsPrintingStartDoc</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int EndDoc(nint hdc);

        /// <summary>
        ///The EndPage function notifies the device that the application has finished writing to a page. This function is typically used to direct the device driver to advance to a new page.
        /// </summary>
        /// <param name="hdc">A handle to the device context for the print job.If the function succeeds, the return value is greater than zero.If the function fails, the return value is less than or equal to zero.When a page in a spooled file exceeds approximately 350 MB, it may fail to print and not send an error message. For example, this can occur when printing large EMF files. The page size limit depends on many factors including the amount of virtual memory available, the amount of memory allocated by calling processes, and the amount of fragmentation in the process heap.For a sample program that uses this function, see How To: Print Using the GDI Print API.Print Spooler API FunctionsPrintingResetDCStartPage</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int EndPage(nint hdc);

        /// <summary>
        ///The EndPath function closes a path bracket and selects the path defined by the bracket into the specified device context.
        /// </summary>
        /// <param name="hdc">A handle to the device context into which the new path is selected.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.BeginPathPath FunctionsPaths Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EndPath(nint hdc);

        /// <summary>
        ///The EnumEnhMetaFile function enumerates the records within an enhanced-format metafile by retrieving each record and passing it to the specified callback function. The application-supplied callback function processes each record as required. The enumeration continues until the last record is processed or when the callback function returns zero.
        /// </summary>
        /// <param name="hdc">A handle to a device context. This handle is passed to the callback function.</param>
        /// <param name="hmf">A handle to an enhanced metafile.</param>
        /// <param name="proc">A pointer to the application-supplied callback function. For more information, see the EnhMetaFileProc function.</param>
        /// <param name="param">A pointer to optional callback-function data.</param>
        /// <param name="lpRect">A pointer to a RECT structure that specifies the coordinates, in logical units, of the picture's upper-left and lower-right corners.If the callback function successfully enumerates all the records in the enhanced metafile, the return value is nonzero.If the callback function does not successfully enumerate all the records in the enhanced metafile, the return value is zero.Points along the edge of the rectangle pointed to by the lpRect parameter are included in the picture. If the hdc parameter is NULL, the system ignores lpRect.If the callback function calls the PlayEnhMetaFileRecord function, hdc must identify a valid device context. The system uses the device context's transformation and mapping mode to transform the picture displayed by the PlayEnhMetaFileRecord function.You can use the EnumEnhMetaFile function to embed one enhanced-metafile within another.EnhMetaFileProcMetafile FunctionsMetafiles OverviewPlayEnhMetaFilePlayEnhMetaFileRecordRECT</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EnumEnhMetaFile(nint hdc, nint hmf, nint proc, nint param, RECT lpRect);

        /// <summary>
        ///The EnumFontFamilies function enumerates the fonts in a specified font family that are available on a specified device.
        /// </summary>
        /// <param name="hdc">A handle to the device context from which to enumerate the fonts.</param>
        /// <param name="lpLogfont">A pointer to a null-terminated string that specifies the family name of the desired fonts. If lpszFamily is NULL, EnumFontFamilies selects and enumerates one font of each available type family.</param>
        /// <param name="lpProc">A pointer to the application defined callback function. For information, see EnumFontFamProc.</param>
        /// <param name="lParam">A pointer to application-supplied data. The data is passed to the callback function along with the font information.The return value is the last value returned by the callback function. Its meaning is implementation specific.For each font having the typeface name specified by the lpszFamily parameter, the EnumFontFamilies function retrieves information about that font and passes it to the function pointed to by the lpEnumFontFamProc parameter. The application defined callback function can process the font information as desired. Enumeration continues until there are no more fonts or the callback function returns zero.When the graphics mode on the device context is set to GM_ADVANCED using the SetGraphicsMode function and the DEVICE_FONTTYPE flag is passed to the FontType parameter, this function returns a list of type 1 and OpenType fonts on the system. When the graphics mode is not set to GM_ADVANCED, this function returns a list of type 1, OpenType, and TrueType fonts on the system.The fonts for many East Asian languages have two typeface names: an English name and a localized name. EnumFonts, EnumFontFamilies, and EnumFontFamiliesEx return the English typeface name if the system locale does not match the language of the font.For examples, see Enumerating the Installed Fonts.EnumFontFamProcEnumFontFamiliesExEnumFontsFont and Text FunctionsFonts and Text Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int EnumFontFamiliesA(nint hdc, string lpLogfont, int lpProc, nint lParam);

        /// <summary>
        ///The EnumFontFamiliesEx function enumerates all uniquely-named fonts in the system that match the font characteristics specified by the LOGFONT structure. EnumFontFamiliesEx enumerates fonts based on typeface name, character set, or both.
        /// </summary>
        /// <param name="hdc">A handle to the device context from which to enumerate the fonts.</param>
        /// <param name="lpLogfont">A pointer to a LOGFONT structure that contains information about the fonts to enumerate. The function examines the following members.</param>
        /// <param name="lpProc">A pointer to the application defined callback function. For more information, see the EnumFontFamExProc function.</param>
        /// <param name="lParam">An application defined value. The function passes this value to the callback function along with font information.dwFlagsThis parameter is not used and must be zero.The return value is the last value returned by the callback function. This value depends on which font families are available for the specified device.The EnumFontFamiliesEx function does not use tagged typeface names to identify character sets. Instead, it always passes the correct typeface name and a separate character set value to the callback function. The function enumerates fonts based on the values of the lfCharSet and lfFaceName members in the LOGFONT structure.As with EnumFontFamilies, EnumFontFamiliesEx enumerates all font styles. Not all styles of a font cover the same character sets. For example, Fontorama Bold might contain ANSI, Greek, and Cyrillic characters, but Fontorama Italic might contain only ANSI characters. For this reason, it's best not to assume that a specified font covers a specific character set, even if it is the ANSI character set. The following table shows the results of various combinations of values for lfCharSet and lfFaceName.The following code sample shows how these values are used.The callback functions for EnumFontFamilies and EnumFontFamiliesEx are very similar. The main difference is that the ENUMLOGFONTEX structure includes a script field.Note, based on the values of lfCharSet and lfFaceName, EnumFontFamiliesEx will enumerate the same font as many times as there are distinct character sets in the font. This can create an extensive list of fonts which can be burdensome to a user. For example, the Century Schoolbook font can appear for the Baltic, Western, Greek, Turkish, and Cyrillic character sets. To avoid this, an application should filter the list of fonts.The fonts for many East Asian languages have two typeface names: an English name and a localized name. EnumFonts, EnumFontFamilies, and EnumFontFamiliesEx return the English typeface name if the system locale does not match the language of the font.When the graphics mode on the device context is set to GM_ADVANCED using the SetGraphicsMode function and the DEVICE_FONTTYPE flag is passed to the FontType parameter, this function returns a list of type 1 and OpenType fonts on the system. When the graphics mode is not set to GM_ADVANCED, this function returns a list of type 1, OpenType, and TrueType fonts on the system.EnumFontFamExProcEnumFontFamiliesEnumFontsFont and Text FunctionsFonts and Text OverviewLOGFONT</param>
        /// <param name="dwFlags"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int EnumFontFamiliesExA(nint hdc, int lpLogfont, int lpProc, nint lParam, uint dwFlags);

        /// <summary>
        ///The EnumFontFamiliesEx function enumerates all uniquely-named fonts in the system that match the font characteristics specified by the LOGFONT structure. EnumFontFamiliesEx enumerates fonts based on typeface name, character set, or both.
        /// </summary>
        /// <param name="hdc">A handle to the device context from which to enumerate the fonts.</param>
        /// <param name="lpLogfont">A pointer to a LOGFONT structure that contains information about the fonts to enumerate. The function examines the following members.</param>
        /// <param name="lpProc">A pointer to the application defined callback function. For more information, see the EnumFontFamExProc function.</param>
        /// <param name="lParam">An application defined value. The function passes this value to the callback function along with font information.dwFlagsThis parameter is not used and must be zero.The return value is the last value returned by the callback function. This value depends on which font families are available for the specified device.The EnumFontFamiliesEx function does not use tagged typeface names to identify character sets. Instead, it always passes the correct typeface name and a separate character set value to the callback function. The function enumerates fonts based on the values of the lfCharSet and lfFaceName members in the LOGFONT structure.As with EnumFontFamilies, EnumFontFamiliesEx enumerates all font styles. Not all styles of a font cover the same character sets. For example, Fontorama Bold might contain ANSI, Greek, and Cyrillic characters, but Fontorama Italic might contain only ANSI characters. For this reason, it's best not to assume that a specified font covers a specific character set, even if it is the ANSI character set. The following table shows the results of various combinations of values for lfCharSet and lfFaceName.The following code sample shows how these values are used.The callback functions for EnumFontFamilies and EnumFontFamiliesEx are very similar. The main difference is that the ENUMLOGFONTEX structure includes a script field.Note, based on the values of lfCharSet and lfFaceName, EnumFontFamiliesEx will enumerate the same font as many times as there are distinct character sets in the font. This can create an extensive list of fonts which can be burdensome to a user. For example, the Century Schoolbook font can appear for the Baltic, Western, Greek, Turkish, and Cyrillic character sets. To avoid this, an application should filter the list of fonts.The fonts for many East Asian languages have two typeface names: an English name and a localized name. EnumFonts, EnumFontFamilies, and EnumFontFamiliesEx return the English typeface name if the system locale does not match the language of the font.When the graphics mode on the device context is set to GM_ADVANCED using the SetGraphicsMode function and the DEVICE_FONTTYPE flag is passed to the FontType parameter, this function returns a list of type 1 and OpenType fonts on the system. When the graphics mode is not set to GM_ADVANCED, this function returns a list of type 1, OpenType, and TrueType fonts on the system.EnumFontFamExProcEnumFontFamiliesEnumFontsFont and Text FunctionsFonts and Text OverviewLOGFONT</param>
        /// <param name="dwFlags"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int EnumFontFamiliesExW(nint hdc, int lpLogfont, int lpProc, nint lParam, uint dwFlags);

        /// <summary>
        ///The EnumFontFamilies function enumerates the fonts in a specified font family that are available on a specified device.
        /// </summary>
        /// <param name="hdc">A handle to the device context from which to enumerate the fonts.</param>
        /// <param name="lpLogfont">A pointer to a null-terminated string that specifies the family name of the desired fonts. If lpszFamily is NULL, EnumFontFamilies selects and enumerates one font of each available type family.</param>
        /// <param name="lpProc">A pointer to the application defined callback function. For information, see EnumFontFamProc.</param>
        /// <param name="lParam">A pointer to application-supplied data. The data is passed to the callback function along with the font information.The return value is the last value returned by the callback function. Its meaning is implementation specific.For each font having the typeface name specified by the lpszFamily parameter, the EnumFontFamilies function retrieves information about that font and passes it to the function pointed to by the lpEnumFontFamProc parameter. The application defined callback function can process the font information as desired. Enumeration continues until there are no more fonts or the callback function returns zero.When the graphics mode on the device context is set to GM_ADVANCED using the SetGraphicsMode function and the DEVICE_FONTTYPE flag is passed to the FontType parameter, this function returns a list of type 1 and OpenType fonts on the system. When the graphics mode is not set to GM_ADVANCED, this function returns a list of type 1, OpenType, and TrueType fonts on the system.The fonts for many East Asian languages have two typeface names: an English name and a localized name. EnumFonts, EnumFontFamilies, and EnumFontFamiliesEx return the English typeface name if the system locale does not match the language of the font.For examples, see Enumerating the Installed Fonts.EnumFontFamProcEnumFontFamiliesExEnumFontsFont and Text FunctionsFonts and Text Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int EnumFontFamiliesW(nint hdc, string lpLogfont, int lpProc, nint lParam);

        /// <summary>
        ///The EnumFonts function enumerates the fonts available on a specified device. For each font with the specified typeface name, the EnumFonts function retrieves information about that font and passes it to the application defined callback function. This callback function can process the font information as desired. Enumeration continues until there are no more fonts or the callback function returns zero.
        /// </summary>
        /// <param name="hdc">A handle to the device context from which to enumerate the fonts.</param>
        /// <param name="lpLogfont">A pointer to a null-terminated string that specifies the typeface name of the desired fonts. If lpFaceName is NULL, EnumFonts randomly selects and enumerates one font of each available typeface.</param>
        /// <param name="lpProc">A pointer to the application definedcallback function. For more information, see EnumFontsProc.</param>
        /// <param name="lParam">A pointer to any application-defined data. The data is passed to the callback function along with the font information.The return value is the last value returned by the callback function. Its meaning is defined by the application.Use EnumFontFamiliesEx instead of EnumFonts. The EnumFontFamiliesEx function differs from the EnumFonts function in that it retrieves the style names associated with a TrueType font. With EnumFontFamiliesEx, you can retrieve information about font styles that cannot be enumerated using the EnumFonts function.The fonts for many East Asian languages have two typeface names: an English name and a localized name. EnumFonts, EnumFontFamilies, and EnumFontFamiliesEx return the English typeface name if the system locale does not match the language of the font.EnumFontFamiliesEnumFontFamiliesExEnumFontsProcFont and Text FunctionsFonts and Text OverviewGetDeviceCaps</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int EnumFontsA(nint hdc, string lpLogfont, int lpProc, nint lParam);

        /// <summary>
        ///The EnumFonts function enumerates the fonts available on a specified device. For each font with the specified typeface name, the EnumFonts function retrieves information about that font and passes it to the application defined callback function. This callback function can process the font information as desired. Enumeration continues until there are no more fonts or the callback function returns zero.
        /// </summary>
        /// <param name="hdc">A handle to the device context from which to enumerate the fonts.</param>
        /// <param name="lpLogfont">A pointer to a null-terminated string that specifies the typeface name of the desired fonts. If lpFaceName is NULL, EnumFonts randomly selects and enumerates one font of each available typeface.</param>
        /// <param name="lpProc">A pointer to the application definedcallback function. For more information, see EnumFontsProc.</param>
        /// <param name="lParam">A pointer to any application-defined data. The data is passed to the callback function along with the font information.The return value is the last value returned by the callback function. Its meaning is defined by the application.Use EnumFontFamiliesEx instead of EnumFonts. The EnumFontFamiliesEx function differs from the EnumFonts function in that it retrieves the style names associated with a TrueType font. With EnumFontFamiliesEx, you can retrieve information about font styles that cannot be enumerated using the EnumFonts function.The fonts for many East Asian languages have two typeface names: an English name and a localized name. EnumFonts, EnumFontFamilies, and EnumFontFamiliesEx return the English typeface name if the system locale does not match the language of the font.EnumFontFamiliesEnumFontFamiliesExEnumFontsProcFont and Text FunctionsFonts and Text OverviewGetDeviceCaps</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int EnumFontsW(nint hdc, string lpLogfont, int lpProc, nint lParam);

        /// <summary>
        ///The EnumICMProfiles function enumerates the different output color profiles that the system supports for a given device context.
        /// </summary>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int EnumICMProfilesA(nint hdc, int proc, nint param);

        /// <summary>
        ///The EnumICMProfiles function enumerates the different output color profiles that the system supports for a given device context.
        /// </summary>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int EnumICMProfilesW(nint hdc, int proc, nint param);

        /// <summary>
        ///The EnumMetaFile function enumerates the records within a Windows-format metafile by retrieving each record and passing it to the specified callback function. The application-supplied callback function processes each record as required. The enumeration continues until the last record is processed or when the callback function returns zero.
        /// </summary>
        /// <param name="hdc">Handle to a device context. This handle is passed to the callback function.</param>
        /// <param name="hmf">Handle to a Windows-format metafile.</param>
        /// <param name="proc">Pointer to an application-supplied callback function. For more information, see EnumMetaFileProc.</param>
        /// <param name="param">Pointer to optional data.If the callback function successfully enumerates all the records in the Windows-format metafile, the return value is nonzero.If the callback function does not successfully enumerate all the records in the Windows-format metafile, the return value is zero.To convert a Windows-format metafile into an enhanced-format metafile, use the SetWinMetaFileBits function.You can use the EnumMetaFile function to embed one Windows-format metafile within another.EnumEnhMetaFileEnumMetaFileProcMetafile FunctionsMetafiles OverviewPlayMetaFilePlayMetaFileRecordSetWinMetaFileBits</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EnumMetaFile(nint hdc, nint hmf, int proc, nint param);

        /// <summary>
        ///The EnumObjects function enumerates the pens or brushes available for the specified device context (DC). This function calls the application-defined callback function once for each available object, supplying data describing that object. EnumObjects continues calling the callback function until the callback function returns zero or until all of the objects have been enumerated.
        /// </summary>
        /// <param name="hdc">A handle to the DC.</param>
        /// <param name="nType">The object type. This parameter can be OBJ_BRUSH or OBJ_PEN.</param>
        /// <param name="lpFunc">A pointer to the application-defined callback function. For more information about the callback function, see the EnumObjectsProc function.</param>
        /// <param name="lParam">A pointer to the application-defined data. The data is passed to the callback function along with the object information.If the function succeeds, the return value is the last value returned by the callback function. Its meaning is user-defined.If the objects cannot be enumerated (for example, there are too many objects), the function returns zero without calling the callback function.Device Context FunctionsDevice Contexts OverviewEnumObjectsProcGetObject</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int EnumObjects(nint hdc, int nType, int lpFunc, nint lParam);

        /// <summary>
        ///The EqualRgn function checks the two specified regions to determine whether they are identical. The function considers two regions identical if they are equal in size and shape.
        /// </summary>
        /// <param name="hrgn1">Handle to a region.</param>
        /// <param name="hrgn2">Handle to a region.If the two regions are equal, the return value is nonzero.If the two regions are not equal, the return value is zero. A return value of ERROR means at least one of the region handles is invalid.CreateRectRgnCreateRectRgnIndirectRegion FunctionsRegions Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EqualRgn(nint hrgn1, nint hrgn2);

        /// <summary>
        ///The Escape function enables an application to access the system-defined device capabilities that are not available through GDI. Escape calls made by an application are translated and sent to the driver.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="iEscape">The escape function to be performed. This parameter must be one of the predefined escape values listed in Remarks. Use the ExtEscape function if your application defines a private escape value.</param>
        /// <param name="cjIn">The number of bytes of data pointed to by the lpvInData parameter. This can be 0.</param>
        /// <param name="pvIn">A pointer to the input structure required for the specified escape.</param>
        /// <param name="pvOut"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int Escape(nint hdc, int iEscape, int cjIn, string pvIn, out nint pvOut);

        /// <summary>
        ///The ExcludeClipRect function creates a new clipping region that consists of the existing clipping region minus the specified rectangle.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="left">The x-coordinate, in logical units, of the upper-left corner of the rectangle.</param>
        /// <param name="top">The y-coordinate, in logical units, of the upper-left corner of the rectangle.</param>
        /// <param name="right">The x-coordinate, in logical units, of the lower-right corner of the rectangle.</param>
        /// <param name="bottom">The y-coordinate, in logical units, of the lower-right corner of the rectangle.The return value specifies the new clipping region's complexity; it can be one of the following values.The lower and right edges of the specified rectangle are not excluded from the clipping region.Clipping FunctionsClipping OverviewIntersectClipRect</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int ExcludeClipRect(nint hdc, int left, int top, int right, int bottom);

        /// <summary>
        ///The ExtCreatePen function creates a logical cosmetic or geometric pen that has the specified style, width, and brush attributes.
        /// </summary>
        /// <param name="iPenStyle">A combination of type, style, end cap, and join attributes. The values from each category are combined by using the bitwise OR operator ( | ).The pen type can be one of the following values.The pen style can be one of the following values.The end cap is only specified for geometric pens. The end cap can be one of the following values.The join is only specified for geometric pens. The join can be one of the following values.</param>
        /// <param name="cWidth">The width of the pen. If the dwPenStyle parameter is PS_GEOMETRIC, the width is given in logical units. If dwPenStyle is PS_COSMETIC, the width must be set to 1.</param>
        /// <param name="plbrush">A pointer to a LOGBRUSH structure. If dwPenStyle is PS_COSMETIC, the lbColor member specifies the color of the pen and the lpStyle member must be set to BS_SOLID. If dwPenStyle is PS_GEOMETRIC, all members must be used to specify the brush attributes of the pen.</param>
        /// <param name="cStyle">The length, in DWORD units, of the lpStyle array. This value must be zero if dwPenStyle is not PS_USERSTYLE.The style count is limited to 16.</param>
        /// <param name="pstyle">A pointer to an array. The first value specifies the length of the first dash in a user-defined style, the second value specifies the length of the first space, and so on. This pointer must be NULL if dwPenStyle is not PS_USERSTYLE.If the lpStyle array is exceeded during line drawing, the pointer is reset to the beginning of the array. When this happens and dwStyleCount is an even number, the pattern of dashes and spaces repeats. However, if dwStyleCount is odd, the pattern reverses when the pointer is reset -- the first element of lpStyle now refers to spaces, the second refers to dashes, and so forth.If the function succeeds, the return value is a handle that identifies a logical pen.If the function fails, the return value is zero.A geometric pen can have any width and can have any of the attributes of a brush, such as dithers and patterns. A cosmetic pen can only be a single pixel wide and must be a solid color, but cosmetic pens are generally faster than geometric pens.The width of a geometric pen is always specified in world units. The width of a cosmetic pen is always 1.End caps and joins are only specified for geometric pens.After an application creates a logical pen, it can select that pen into a device context by calling the SelectObject function. After a pen is selected into a device context, it can be used to draw lines and curves.If dwPenStyle is PS_COSMETIC and PS_USERSTYLE, the entries in the lpStyle array specify lengths of dashes and spaces in style units. A style unit is defined by the device where the pen is used to draw a line.If dwPenStyle is PS_GEOMETRIC and PS_USERSTYLE, the entries in the lpStyle array specify lengths of dashes and spaces in logical units.If dwPenStyle is PS_ALTERNATE, the style unit is ignored and every other pixel is set.If the lbStyle member of the LOGBRUSH structure pointed to by lplb is BS_PATTERN, the bitmap pointed to by the lbHatch member of that structure cannot be a DIB section. A DIB section is a bitmap created by CreateDIBSection. If that bitmap is a DIB section, the ExtCreatePen function fails.When an application no longer requires a specified pen, it should call the DeleteObject function to delete the pen.ICM: No color management is done at pen creation. However, color management is performed when the pen is selected into an ICM-enabled device context.For an example, see Using Pens.CreateDIBSectionCreatePenCreatePenIndirectDeleteObjectGetObjectLOGBRUSHPen FunctionsPens OverviewSelectObjectSetMiterLimit</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint ExtCreatePen(uint iPenStyle, uint cWidth, LOGBRUSH plbrush, uint cStyle, uint pstyle);

        /// <summary>
        ///The ExtCreateRegion function creates a region from the specified region and transformation data.
        /// </summary>
        /// <param name="lpx">A pointer to an XFORM structure that defines the transformation to be performed on the region. If this pointer is NULL, the identity transformation is used.</param>
        /// <param name="nCount">The number of bytes pointed to by lpRgnData.</param>
        /// <param name="lpData">A pointer to a RGNDATA structure that contains the region data in logical units.If the function succeeds, the return value is the value of the region.If the function fails, the return value is NULL.Region coordinates are represented as 27-bit signed integers.An application can retrieve data for a region by calling the GetRegionData function.CreatePolyPolygonRgnCreatePolygonRgnCreateRectRgnCreateRectRgnIndirectCreateRoundRectRgnGetRegionDataRGNDATARegion FunctionsRegions OverviewXFORM</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint ExtCreateRegion(XFORM lpx, uint nCount, RGNDATA lpData);

        /// <summary>
        ///The ExtEscape function enables an application to access device capabilities that are not available through GDI.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="iEscape">The escape function to be performed. It can be one of the following or it can be an application-defined escape function.</param>
        /// <param name="cjInput">The number of bytes of data pointed to by the lpszInData parameter.</param>
        /// <param name="lpInData">A pointer to the input structure required for the specified escape. See also Remarks.</param>
        /// <param name="cjOutput">The number of bytes of data pointed to by the lpszOutData parameter.</param>
        /// <param name="lpOutData"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int ExtEscape(nint hdc, int iEscape, int cjInput, string lpInData, int cjOutput, out string lpOutData);

        /// <summary>
        ///The ExtFloodFill function fills an area of the display surface with the current brush.
        /// </summary>
        /// <param name="hdc">A handle to a device context.</param>
        /// <param name="x">The x-coordinate, in logical units, of the point where filling is to start.</param>
        /// <param name="y">The y-coordinate, in logical units, of the point where filling is to start.</param>
        /// <param name="color">The color of the boundary or of the area to be filled. The interpretation of color depends on the value of the fuFillType parameter. To create a COLORREF color value, use the RGB macro.</param>
        /// <param name="type">The type of fill operation to be performed. This parameter must be one of the following values.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The following are some of the reasons this function might fail:If fuFillType is FLOODFILLSURFACE, the system assumes that the area to be filled is a single color. The function begins to fill the area at the point specified by nXStart and nYStart and continues in all directions, filling all adjacent regions containing the color specified by color.Only memory device contexts and devices that support raster-display operations support the ExtFloodFill function. To determine whether a device supports this technology, use the GetDeviceCaps function.For an example, see "Adding Lines and Graphs to a Menu" in Using Menus.Bitmap FunctionsBitmaps OverviewCOLORREFFloodFillGetDeviceCapsRGB</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ExtFloodFill(nint hdc, int x, int y, int color, uint type);

        /// <summary>
        ///The ExtSelectClipRgn function combines the specified region with the current clipping region using the specified mode.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="hrgn">A handle to the region to be selected. This handle must not be NULL unless the RGN_COPY mode is specified.</param>
        /// <param name="mode">The operation to be performed. It must be one of the following values.The return value specifies the new clipping region's complexity; it can be one of the following values.If an error occurs when this function is called, the previous clipping region for the specified device context is not affected.The ExtSelectClipRgn function assumes that the coordinates for the specified region are specified in device units.Only a copy of the region identified by the hrgn parameter is used. The region itself can be reused after this call or it can be deleted.Clipping FunctionsClipping OverviewSelectClipRgn</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int ExtSelectClipRgn(nint hdc, nint hrgn, int mode);

        /// <summary>
        ///The ExtTextOut function draws text using the currently selected font, background color, and text color. You can optionally provide dimensions to be used for clipping, opaquing, or both.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="x">The x-coordinate, in logical coordinates, of the reference point used to position the string.</param>
        /// <param name="y">The y-coordinate, in logical coordinates, of the reference point used to position the string.</param>
        /// <param name="options">Specifies how to use the application-defined rectangle. This parameter can be one or more of the following values.The ETO_GLYPH_INDEX and ETO_RTLREADING values cannot be used together. Because ETO_GLYPH_INDEX implies that all language processing has been completed, the function ignores the ETO_RTLREADING flag if also specified.</param>
        /// <param name="lprect">A pointer to an optional RECT structure that specifies the dimensions, in logical coordinates, of a rectangle that is used for clipping, opaquing, or both.</param>
        /// <param name="lpString">A pointer to a string that specifies the text to be drawn. The string does not need to be zero-terminated, since cbCount specifies the length of the string.</param>
        /// <param name="c">The length of the string pointed to by lpString.This value may not exceed 8192.</param>
        /// <param name="lpDx">A pointer to an optional array of values that indicate the distance between origins of adjacent character cells. For example, lpDx[i] logical units separate the origins of character cell i and character cell i + 1.If the string is drawn, the return value is nonzero. However, if the ANSI version of ExtTextOut is called with ETO_GLYPH_INDEX, the function returns TRUE even though the function does nothing.If the function fails, the return value is zero.The current text-alignment settings for the specified device context determine how the reference point is used to position the text. The text-alignment settings are retrieved by calling the GetTextAlign function. The text-alignment settings are altered by calling the SetTextAlign function. You can use the following values for text alignment. Only one flag can be chosen from those that affect horizontal and vertical alignment. In addition, only one of the two flags that alter the current position can be chosen.If the lpDx parameter is NULL, the ExtTextOut function uses the default spacing between characters. The character-cell origins and the contents of the array pointed to by the lpDx parameter are specified in logical units. A character-cell origin is defined as the upper-left corner of the character cell.By default, the current position is not used or updated by this function. However, an application can call the SetTextAlign function with the fMode parameter set to TA_UPDATECP to permit the system to use and update the current position each time the application calls ExtTextOut for a specified device context. When this flag is set, the system ignores the X and Y parameters on subsequent ExtTextOut calls.For the ANSI version of ExtTextOut, the lpDx array has the same number of INT values as there are bytes in lpString. For DBCS characters, you can apportion the dx in the lpDx entries between the lead byte and the trail byte, as long as the sum of the two bytes adds up to the desired dx. For DBCS characters with the Unicode version of ExtTextOut, each Unicode glyph gets a single pdx entry.Note, the alpDx values from GetTextExtentExPoint are not the same as the lpDx values for ExtTextOut. To use the alpDx values in lpDx, you must first process them.ExtTextOut will use Uniscribe when necessary resulting in font fallback. The ETO_IGNORELANGUAGE flag will inhibit this behavior and should not be passed.Additionally, ExtTextOut will perform internal batching of calls before transitioning to kernel mode, mitigating some of the performance concerns when weighing usage of PolyTextOut versus ExtTextOut.For an example, see "Setting Fonts for Menu-Item Text Strings" in Using Menus.Font and Text FunctionsFonts and Text OverviewGetTextAlignRECTSelectObjectSetBkColorSetTextAlignSetTextColor</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ExtTextOutA(nint hdc, int x, int y, uint options, RECT lprect, string lpString, uint c, int lpDx);

        /// <summary>
        ///The ExtTextOut function draws text using the currently selected font, background color, and text color. You can optionally provide dimensions to be used for clipping, opaquing, or both.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="x">The x-coordinate, in logical coordinates, of the reference point used to position the string.</param>
        /// <param name="y">The y-coordinate, in logical coordinates, of the reference point used to position the string.</param>
        /// <param name="options">Specifies how to use the application-defined rectangle. This parameter can be one or more of the following values.The ETO_GLYPH_INDEX and ETO_RTLREADING values cannot be used together. Because ETO_GLYPH_INDEX implies that all language processing has been completed, the function ignores the ETO_RTLREADING flag if also specified.</param>
        /// <param name="lprect">A pointer to an optional RECT structure that specifies the dimensions, in logical coordinates, of a rectangle that is used for clipping, opaquing, or both.</param>
        /// <param name="lpString">A pointer to a string that specifies the text to be drawn. The string does not need to be zero-terminated, since cbCount specifies the length of the string.</param>
        /// <param name="c">The length of the string pointed to by lpString.This value may not exceed 8192.</param>
        /// <param name="lpDx">A pointer to an optional array of values that indicate the distance between origins of adjacent character cells. For example, lpDx[i] logical units separate the origins of character cell i and character cell i + 1.If the string is drawn, the return value is nonzero. However, if the ANSI version of ExtTextOut is called with ETO_GLYPH_INDEX, the function returns TRUE even though the function does nothing.If the function fails, the return value is zero.The current text-alignment settings for the specified device context determine how the reference point is used to position the text. The text-alignment settings are retrieved by calling the GetTextAlign function. The text-alignment settings are altered by calling the SetTextAlign function. You can use the following values for text alignment. Only one flag can be chosen from those that affect horizontal and vertical alignment. In addition, only one of the two flags that alter the current position can be chosen.If the lpDx parameter is NULL, the ExtTextOut function uses the default spacing between characters. The character-cell origins and the contents of the array pointed to by the lpDx parameter are specified in logical units. A character-cell origin is defined as the upper-left corner of the character cell.By default, the current position is not used or updated by this function. However, an application can call the SetTextAlign function with the fMode parameter set to TA_UPDATECP to permit the system to use and update the current position each time the application calls ExtTextOut for a specified device context. When this flag is set, the system ignores the X and Y parameters on subsequent ExtTextOut calls.For the ANSI version of ExtTextOut, the lpDx array has the same number of INT values as there are bytes in lpString. For DBCS characters, you can apportion the dx in the lpDx entries between the lead byte and the trail byte, as long as the sum of the two bytes adds up to the desired dx. For DBCS characters with the Unicode version of ExtTextOut, each Unicode glyph gets a single pdx entry.Note, the alpDx values from GetTextExtentExPoint are not the same as the lpDx values for ExtTextOut. To use the alpDx values in lpDx, you must first process them.ExtTextOut will use Uniscribe when necessary resulting in font fallback. The ETO_IGNORELANGUAGE flag will inhibit this behavior and should not be passed.Additionally, ExtTextOut will perform internal batching of calls before transitioning to kernel mode, mitigating some of the performance concerns when weighing usage of PolyTextOut versus ExtTextOut.For an example, see "Setting Fonts for Menu-Item Text Strings" in Using Menus.Font and Text FunctionsFonts and Text OverviewGetTextAlignRECTSelectObjectSetBkColorSetTextAlignSetTextColor</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ExtTextOutW(nint hdc, int x, int y, uint options, RECT lprect, string lpString, uint c, int lpDx);

        /// <summary>
        ///The FillPath function closes any open figures in the current path and fills the path's interior by using the current brush and polygon-filling mode.
        /// </summary>
        /// <param name="hdc">A handle to a device context that contains a valid path.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.After its interior is filled, the path is discarded from the DC identified by the hdc parameter.BeginPathPath FunctionsPaths OverviewSetPolyFillModeStrokeAndFillPathStrokePath</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool FillPath(nint hdc);

        /// <summary>
        ///The FillRgn function fills a region by using the specified brush.
        /// </summary>
        /// <param name="hdc">Handle to the device context.</param>
        /// <param name="hrgn">Handle to the region to be filled. The region's coordinates are presumed to be in logical units.</param>
        /// <param name="hbr">Handle to the brush to be used to fill the region.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.CreateBrushIndirectCreateDIBPatternBrushCreateHatchBrushCreatePatternBrushCreateSolidBrushPaintRgnRegion FunctionsRegions Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool FillRgn(nint hdc, nint hrgn, nint hbr);

        /// <summary>
        ///The FlattenPath function transforms any curves in the path that is selected into the current device context (DC), turning each curve into a sequence of lines.
        /// </summary>
        /// <param name="hdc">A handle to a DC that contains a valid path.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.Path FunctionsPaths OverviewWidenPath</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool FlattenPath(nint hdc);

        /// <summary>
        ///The FloodFill function fills an area of the display surface with the current brush. The area is assumed to be bounded as specified by the color parameter.
        /// </summary>
        /// <param name="hdc">A handle to a device context.</param>
        /// <param name="x">The x-coordinate, in logical units, of the point where filling is to start.</param>
        /// <param name="y">The y-coordinate, in logical units, of the point where filling is to start.</param>
        /// <param name="color">The color of the boundary or the area to be filled. To create a COLORREF color value, use the RGB macro.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The following are reasons this function might fail:Bitmap FunctionsBitmaps OverviewCOLORREFExtFloodFillRGB</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool FloodFill(nint hdc, int x, int y, int color);

        /// <summary>
        ///The FrameRgn function draws a border around the specified region by using the specified brush.
        /// </summary>
        /// <param name="hdc">Handle to the device context.</param>
        /// <param name="hrgn">Handle to the region to be enclosed in a border. The region's coordinates are presumed to be in logical units.</param>
        /// <param name="hbr">Handle to the brush to be used to draw the border.</param>
        /// <param name="w">Specifies the width, in logical units, of vertical brush strokes.</param>
        /// <param name="h">Specifies the height, in logical units, of horizontal brush strokes.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.FillRgnPaintRgnRegion FunctionsRegions Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool FrameRgn(nint hdc, nint hrgn, nint hbr, int w, int h);

        /// <summary>
        ///The GdiAlphaBlend function displays bitmaps that have transparent or semitransparent pixels.
        /// </summary>
        /// <param name="hdcDest">A handle to the destination device context.</param>
        /// <param name="xoriginDest">The x-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
        /// <param name="yoriginDest">The y-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
        /// <param name="wDest">The width, in logical units, of the destination rectangle.</param>
        /// <param name="hDest">The height, in logical units, of the destination rectangle.</param>
        /// <param name="hdcSrc">A handle to the source device context.</param>
        /// <param name="xoriginSrc">The x-coordinate, in logical units, of the upper-left corner of the source rectangle.</param>
        /// <param name="yoriginSrc">The y-coordinate, in logical units, of the upper-left corner of the source rectangle.</param>
        /// <param name="wSrc">The width, in logical units, of the source rectangle.</param>
        /// <param name="hSrc">The height, in logical units, of the source rectangle.</param>
        /// <param name="ftn">The alpha-blending function for source and destination bitmaps, a global alpha value to be applied to the entire source bitmap, and format information for the source bitmap. The source and destination blend functions are currently limited to AC_SRC_OVER. See the BLENDFUNCTION and EMRALPHABLEND structures.If the function succeeds, the return value is TRUE.If the function fails, the return value is FALSE.This function can return the following value.The destination coordinates are transformed by using the transformation currently specified for the destination device context. The source coordinates are transformed by using the transformation currently specified for the source device context.An error occurs (and the function returns FALSE) if the source device context identifies an enhanced metafile device context.If destination and source bitmaps do not have the same color format, GdiAlphaBlend converts the source bitmap to match the destination bitmap.GdiAlphaBlend does not support mirroring. If either the width or height of the source or destination is negative, this call will fail.When rendering to a printer, first call GetDeviceCaps with SHADEBLENDCAPS to determine if the printer supports blending with GdiAlphaBlend. Note that, for a display DC, all blending operations are supported and these flags represent whether the operations are accelerated.If the source and destination are the same surface, that is, they are both the screen or the same memory bitmap and the source and destination rectangles overlap, an error occurs and the function returns FALSE.The source rectangle must lie completely within the source surface, otherwise an error occurs and the function returns FALSE.GdiAlphaBlend fails if the width or height of the source or destination is negative.The SourceConstantAlpha member of BLENDFUNCTION specifies an alpha transparency value to be used on the entire source bitmap. The SourceConstantAlpha value is combined with any per-pixel alpha values. If SourceConstantAlpha is 0, it is assumed that the image is transparent. Set the SourceConstantAlpha value to 255 (which indicates that the image is opaque) when you only want to use per-pixel alpha values.BLENDFUNCTIONBitmap FunctionsBitmaps OverviewEMRALPHABLENDGetDeviceCapsSetStretchBltMode</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GdiAlphaBlend(nint hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest, nint hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc, BLENDFUNCTION ftn);

        /// <summary>
        ///The GdiComment function copies a comment from a buffer into a specified enhanced-format metafile.
        /// </summary>
        /// <param name="hdc">A handle to an enhanced-metafile device context.</param>
        /// <param name="nSize">The length of the comment buffer, in bytes.</param>
        /// <param name="lpData">A pointer to the buffer that contains the comment.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.A comment can include any kind of private information, for example, the source of a picture and the date it was created. A comment should begin with an application signature, followed by the data.Comments should not contain application-specific or position-specific data. Position-specific data specifies the location of a record, and it should not be included because one metafile may be embedded within another metafile.A public comment is a comment that begins with the comment signature identifier GDICOMMENT_IDENTIFIER. The following public comments are defined.CreateEnhMetaFileMetafile FunctionsMetafiles OverviewSetWinMetaFileBits</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GdiComment(nint hdc, uint nSize, byte lpData);

        /// <summary>
        ///The GdiFlush function flushes the calling thread's current batch.
        /// </summary>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GdiFlush();

        /// <summary>
        ///The GdiGetBatchLimit function returns the maximum number of function calls that can be accumulated in the calling thread's current batch. The system flushes the current batch whenever this limit is exceeded.
        /// </summary>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GdiGetBatchLimit();

        /// <summary>
        ///The GdiGradientFill function fills rectangle and triangle structures.
        /// </summary>
        /// <param name="hdc">A handle to the destination device context.</param>
        /// <param name="pVertex">A pointer to an array of TRIVERTEX structures that each define a triangle vertex.</param>
        /// <param name="nVertex">The number of vertices in pVertex.</param>
        /// <param name="pMesh">An array of GRADIENT_TRIANGLE structures in triangle mode, or an array of GRADIENT_RECT structures in rectangle mode.</param>
        /// <param name="nCount">The number of elements (triangles or rectangles) in pMesh.</param>
        /// <param name="ulMode">The gradient fill mode. This parameter can be one of the following values.If the function succeeds, the return value is TRUE.If the function fails, the return value is FALSE.In the case of filling a triangle, pMesh points to an array of GRADIENT_TRIANGLE structures. Each GRADIENT_TRIANGLE structure specifies the index of three vertices in the pVertex array. These three vertices form one triangle.To simplify hardware acceleration, this routine is not required to be pixel-perfect in the triangle interior.Note that GdiGradientFill does not use the Alpha member of the TRIVERTEX structure. To use GdiGradientFill with transparency, call GdiGradientFill and then call GdiAlphaBlend with the desired values for the alpha channel of each vertex.For more information, see Smooth Shading, Drawing a Shaded Triangle, and Drawing a Shaded Rectangle.Bitmap FunctionsBitmaps OverviewEMRGRADIENTFILLGRADIENT_RECTGRADIENT_TRIANGLETRIVERTEX</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GdiGradientFill(nint hdc, int pVertex, uint nVertex, nint pMesh, uint nCount, uint ulMode);

        /// <summary>
        ///The GdiSetBatchLimit function sets the maximum number of function calls that can be accumulated in the calling thread's current batch. The system flushes the current batch whenever this limit is exceeded.
        /// </summary>
        /// <param name="dw">Specifies the batch limit to be set. A value of 0 sets the default limit. A value of 1 disables batching.If the function succeeds, the return value is the previous batch limit.If the function fails, the return value is zero.Only GDI drawing functions that return Boolean values can be accumulated in the current batch; calls to any other GDI functions immediately flush the current batch. Exceeding the batch limit or calling the GdiFlush function also flushes the current batch.When the system accumulates a function call, the function returns TRUE to indicate it is in the batch. When the system flushes the current batch and executes the function for the second time, the return value is either TRUE or FALSE, depending on whether the function succeeds. This second return value is reported only if GdiFlush is used to flush the batch.GdiFlushGdiGetBatchLimitPainting and Drawing FunctionsPainting and Drawing Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GdiSetBatchLimit(uint dw);

        /// <summary>
        ///The GdiTransparentBlt function performs a bit-block transfer of the color data corresponding to a rectangle of pixels from the specified source device context into a destination device context.
        /// </summary>
        /// <param name="hdcDest">A handle to the destination device context.</param>
        /// <param name="xoriginDest">The x-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
        /// <param name="yoriginDest">The y-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
        /// <param name="wDest">The width, in logical units, of the destination rectangle.</param>
        /// <param name="hDest">The height, in logical units, of the destination rectangle.</param>
        /// <param name="hdcSrc">A handle to the source device context.</param>
        /// <param name="xoriginSrc">The x-coordinate, in logical units, of the source rectangle.</param>
        /// <param name="yoriginSrc">The y-coordinate, in logical units, of the source rectangle.</param>
        /// <param name="wSrc">The width, in logical units, of the source rectangle.</param>
        /// <param name="hSrc">The height, in logical units, of the source rectangle.</param>
        /// <param name="crTransparent">The RGB color in the source bitmap to treat as transparent.If the function succeeds, the return value is TRUE.If the function fails, the return value is FALSE.The GdiTransparentBlt function works with compatible bitmaps (DDBs).The GdiTransparentBlt function supports all formats of source bitmaps. However, for 32 bpp bitmaps, it just copies the alpha value over. Use AlphaBlend to specify 32 bits-per-pixel bitmaps with transparency.If the source and destination rectangles are not the same size, the source bitmap is stretched to match the destination rectangle. When the SetStretchBltMode function is used, the iStretchMode modes of BLACKONWHITE and WHITEONBLACK are converted to COLORONCOLOR for the GdiTransparentBlt function.The destination device context specifies the transformation type for the destination coordinates. The source device context specifies the transformation type for the source coordinates.GdiTransparentBlt does not mirror a bitmap if either the width or height, of either the source or destination, is negative.When used in a multiple monitor system, both hdcSrc and hdcDest must refer to the same device or the function will fail. To transfer data between DCs for different devices, convert the memory bitmap to a DIB by calling GetDIBits. To display the DIB to the second device, call SetDIBits or StretchDIBits.AlphaBlendBitmap FunctionsBitmaps OverviewGetDIBitsSetDIBitsSetStretchBltModeStretchDIBits</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GdiTransparentBlt(nint hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest, nint hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc, uint crTransparent);

        /// <summary>
        ///The GetArcDirection function retrieves the current arc direction for the specified device context. Arc and rectangle functions use the arc direction.
        /// </summary>
        /// <param name="hdc">Handle to the device context.The return value specifies the current arc direction; it can be any one of the following values:Line and Curve FunctionsLines and Curves OverviewSetArcDirection</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetArcDirection(nint hdc);

        /// <summary>
        ///The GetAspectRatioFilterEx function retrieves the setting for the current aspect-ratio filter.
        /// </summary>
        /// <param name="hdc">Handle to a device context.</param>
        /// <param name="lpsize"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetAspectRatioFilterEx(nint hdc, out int lpsize);

        /// <summary>
        ///The GetBitmapBits function copies the bitmap bits of a specified device-dependent bitmap into a buffer.
        /// </summary>
        /// <param name="hbit">A handle to the device-dependent bitmap.</param>
        /// <param name="cb">The number of bytes to copy from the bitmap into the buffer.</param>
        /// <param name="lpvBits"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetBitmapBits(nint hbit, int cb, out nint lpvBits);

        /// <summary>
        ///The GetBitmapDimensionEx function retrieves the dimensions of a compatible bitmap. The retrieved dimensions must have been set by the SetBitmapDimensionEx function.
        /// </summary>
        /// <param name="hbit">A handle to a compatible bitmap (DDB).</param>
        /// <param name="lpsize"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetBitmapDimensionEx(nint hbit, out int lpsize);

        /// <summary>
        ///The GetBkColor function returns the current background color for the specified device context.
        /// </summary>
        /// <param name="hdc">Handle to the device context whose background color is to be returned.If the function succeeds, the return value is a COLORREF value for the current background color.If the function fails, the return value is CLR_INVALID.COLORREFGetBkModePainting and Drawing FunctionsPainting and Drawing OverviewSetBkColor</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetBkColor(nint hdc);

        /// <summary>
        ///The GetBkMode function returns the current background mix mode for a specified device context. The background mix mode of a device context affects text, hatched brushes, and pen styles that are not solid lines.
        /// </summary>
        /// <param name="hdc">Handle to the device context whose background mode is to be returned.If the function succeeds, the return value specifies the current background mix mode, either OPAQUE or TRANSPARENT.If the function fails, the return value is zero.GetBkColorPainting and Drawing FunctionsPainting and Drawing OverviewSetBkMode</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetBkMode(nint hdc);

        /// <summary>
        ///The GetBoundsRect function obtains the current accumulated bounding rectangle for a specified device context.
        /// </summary>
        /// <param name="hdc">A handle to the device context whose bounding rectangle the function will return.</param>
        /// <param name="lprect"></param>
        /// <param name="flags">Specifies how the GetBoundsRect function will behave. This parameter can be the following value.The return value specifies the state of the accumulated bounding rectangle; it can be one of the following values.The DCB_SET value is a combination of the bit values DCB_ACCUMULATE and DCB_RESET. Applications that check the DCB_RESET bit to determine whether the bounding rectangle is empty must also check the DCB_ACCUMULATE bit. The bounding rectangle is empty only if the DCB_RESET bit is 1 and the DCB_ACCUMULATE bit is 0.Painting and Drawing FunctionsPainting and Drawing OverviewSetBoundsRect</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetBoundsRect(nint hdc, out int lprect, uint flags);

        /// <summary>
        ///The GetBrushOrgEx function retrieves the current brush origin for the specified device context. This function replaces the GetBrushOrg function.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="lppt"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetBrushOrgEx(nint hdc, out int lppt);

        /// <summary>
        ///The GetCharABCWidths function retrieves the widths, in logical units, of consecutive characters in a specified range from the current TrueType font. This function succeeds only with TrueType fonts.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="wFirst">The first character in the group of consecutive characters from the current font.</param>
        /// <param name="wLast">The last character in the group of consecutive characters from the current font.</param>
        /// <param name="lpABC"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetCharABCWidthsA(nint hdc, uint wFirst, uint wLast, out int lpABC);

        /// <summary>
        ///The GetCharABCWidthsFloat function retrieves the widths, in logical units, of consecutive characters in a specified range from the current font.
        /// </summary>
        /// <param name="hdc">Handle to the device context.</param>
        /// <param name="iFirst">Specifies the code point of the first character in the group of consecutive characters where the ABC widths are seeked.</param>
        /// <param name="iLast">Specifies the code point of the last character in the group of consecutive characters where the ABC widths are seeked. This range is inclusive. An error is returned if the specified last character precedes the specified first character.</param>
        /// <param name="lpABC"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetCharABCWidthsFloatA(nint hdc, uint iFirst, uint iLast, out float lpABC);

        /// <summary>
        ///The GetCharABCWidthsFloat function retrieves the widths, in logical units, of consecutive characters in a specified range from the current font.
        /// </summary>
        /// <param name="hdc">Handle to the device context.</param>
        /// <param name="iFirst">Specifies the code point of the first character in the group of consecutive characters where the ABC widths are seeked.</param>
        /// <param name="iLast">Specifies the code point of the last character in the group of consecutive characters where the ABC widths are seeked. This range is inclusive. An error is returned if the specified last character precedes the specified first character.</param>
        /// <param name="lpABC"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetCharABCWidthsFloatW(nint hdc, uint iFirst, uint iLast, out float lpABC);

        /// <summary>
        ///The GetCharABCWidthsI function retrieves the widths, in logical units, of consecutive glyph indices in a specified range from the current TrueType font. This function succeeds only with TrueType fonts.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="giFirst">The first glyph index in the group of consecutive glyph indices from the current font. This parameter is only used if the pgi parameter is NULL.</param>
        /// <param name="cgi">The number of glyph indices.</param>
        /// <param name="pgi">A pointer to an array that contains glyph indices. If this parameter is NULL, the giFirst parameter is used instead. The cgi parameter specifies the number of glyph indices in this array.</param>
        /// <param name="pabc"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetCharABCWidthsI(nint hdc, uint giFirst, uint cgi, short pgi, out int pabc);

        /// <summary>
        ///The GetCharABCWidths function retrieves the widths, in logical units, of consecutive characters in a specified range from the current TrueType font. This function succeeds only with TrueType fonts.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="wFirst">The first character in the group of consecutive characters from the current font.</param>
        /// <param name="wLast">The last character in the group of consecutive characters from the current font.</param>
        /// <param name="lpABC"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetCharABCWidthsW(nint hdc, uint wFirst, uint wLast, out int lpABC);

        /// <summary>
        ///The GetCharacterPlacement function retrieves information about a character string, such as character widths, caret positioning, ordering within the string, and glyph rendering. The type of information returned depends on the dwFlags parameter and is based on the currently selected font in the specified display context. The function copies the information to the specified GCP_RESULTS structure or to one or more arrays specified by the structure.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="lpString">A pointer to the character string to process. The string does not need to be zero-terminated, since nCount specifies the length of the string.</param>
        /// <param name="nCount">The length of the string pointed to by lpString.</param>
        /// <param name="nMexExtent">The maximum extent (in logical units) to which the string is processed. Characters that, if processed, would exceed this extent are ignored. Computations for any required ordering or glyph arrays apply only to the included characters. This parameter is used only if the GCP_MAXEXTENT value is specified in the dwFlags parameter. As the function processes the input string, each character and its extent is added to the output, extent, and other arrays only if the total extent has not yet exceeded the maximum. Once the limit is reached, processing will stop.</param>
        /// <param name="dwFlags">Specifies how to process the string into the required arrays. This parameter can be one or more of the following values.It is recommended that an application use the GetFontLanguageInfo function to determine whether the GCP_DIACRITIC, GCP_DBCS, GCP_USEKERNING, GCP_LIGATE, GCP_REORDER, GCP_GLYPHSHAPE, and GCP_KASHIDA values are valid for the currently selected font. If not valid, GetCharacterPlacement ignores the value.The GCP_NODIACRITICS value is no longer defined and should not be used.If the function succeeds, the return value is the width and height of the string in logical units. The width is the low-order word and the height is the high-order word.If the function fails, the return value is zero.GetCharacterPlacement ensures that an application can correctly process text regardless of the international setting and type of fonts available. Applications use this function before using the ExtTextOut function and in place of the GetTextExtentPoint32 function (and occasionally in place of the GetCharWidth32 and GetCharABCWidths functions).Using GetCharacterPlacement to retrieve intercharacter spacing and index arrays is not always necessary unless justification or kerning is required. For non-Latin fonts, applications can improve the speed at which the ExtTextOut function renders text by using GetCharacterPlacement to retrieve the intercharacter spacing and index arrays before calling ExtTextOut. This is especially useful when rendering the same text repeatedly or when using intercharacter spacing to position the caret. If the lpGlyphs output array is used in the call to ExtTextOut, the ETO_GLYPH_INDEX flag must be set.GetCharacterPlacement checks the lpOrder, lpDX, lpCaretPos, lpOutString, and lpGlyphs members of the GCP_RESULTS structure and fills the corresponding arrays if these members are not set to NULL. If GetCharacterPlacement cannot fill an array, it sets the corresponding member to NULL. To ensure retrieval of valid information, the application is responsible for setting the member to a valid address before calling the function and for checking the value of the member after the call. If the GCP_JUSTIFY or GCP_USEKERNING values are specified, the lpDX and/or lpCaretPos members must have valid addresses.Note that the glyph indexes returned in GCP_RESULTS.lpGlyphs are specific to the current font in the device context and should only be used to draw text in the device context while that font remains selected.When computing justification, if the trailing characters in the string are spaces, the function reduces the length of the string and removes the spaces prior to computing the justification. If the array consists of only spaces, the function returns an error.ExtTextOut expects an lpDX entry for each byte of a DBCS string, whereas GetCharacterPlacement assigns an lpDX entry for each glyph. To correct this mismatch when using this combination of functions, either use GetGlyphIndices or expand the lpDX array with zero-width entries for the corresponding second byte of a DBCS byte pair.If the logical width is less than the width of the leading character in the input string, GCP_RESULTS.nMaxFit returns a bad value. For this case, call GetCharacterPlacement for glyph indexes and the lpDX array. Then use the lpDX array to do the extent calculation using the advance width of each character, where nMaxFit is the number of characters whose glyph indexes advance width is less than the width of the leading character.ExtTextOutFont and Text FunctionsFonts and Text OverviewGCP_RESULTSGetCharABCWidthsGetCharWidth32GetFontLanguageInfoGetStringTypeExGetTextExtentPoint32GetTextMetrics</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetCharacterPlacementA(nint hdc, string lpString, int nCount, int nMexExtent, uint dwFlags);

        /// <summary>
        ///The GetCharacterPlacement function retrieves information about a character string, such as character widths, caret positioning, ordering within the string, and glyph rendering. The type of information returned depends on the dwFlags parameter and is based on the currently selected font in the specified display context. The function copies the information to the specified GCP_RESULTS structure or to one or more arrays specified by the structure.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="lpString">A pointer to the character string to process. The string does not need to be zero-terminated, since nCount specifies the length of the string.</param>
        /// <param name="nCount">The length of the string pointed to by lpString.</param>
        /// <param name="nMexExtent">The maximum extent (in logical units) to which the string is processed. Characters that, if processed, would exceed this extent are ignored. Computations for any required ordering or glyph arrays apply only to the included characters. This parameter is used only if the GCP_MAXEXTENT value is specified in the dwFlags parameter. As the function processes the input string, each character and its extent is added to the output, extent, and other arrays only if the total extent has not yet exceeded the maximum. Once the limit is reached, processing will stop.</param>
        /// <param name="dwFlags">Specifies how to process the string into the required arrays. This parameter can be one or more of the following values.It is recommended that an application use the GetFontLanguageInfo function to determine whether the GCP_DIACRITIC, GCP_DBCS, GCP_USEKERNING, GCP_LIGATE, GCP_REORDER, GCP_GLYPHSHAPE, and GCP_KASHIDA values are valid for the currently selected font. If not valid, GetCharacterPlacement ignores the value.The GCP_NODIACRITICS value is no longer defined and should not be used.If the function succeeds, the return value is the width and height of the string in logical units. The width is the low-order word and the height is the high-order word.If the function fails, the return value is zero.GetCharacterPlacement ensures that an application can correctly process text regardless of the international setting and type of fonts available. Applications use this function before using the ExtTextOut function and in place of the GetTextExtentPoint32 function (and occasionally in place of the GetCharWidth32 and GetCharABCWidths functions).Using GetCharacterPlacement to retrieve intercharacter spacing and index arrays is not always necessary unless justification or kerning is required. For non-Latin fonts, applications can improve the speed at which the ExtTextOut function renders text by using GetCharacterPlacement to retrieve the intercharacter spacing and index arrays before calling ExtTextOut. This is especially useful when rendering the same text repeatedly or when using intercharacter spacing to position the caret. If the lpGlyphs output array is used in the call to ExtTextOut, the ETO_GLYPH_INDEX flag must be set.GetCharacterPlacement checks the lpOrder, lpDX, lpCaretPos, lpOutString, and lpGlyphs members of the GCP_RESULTS structure and fills the corresponding arrays if these members are not set to NULL. If GetCharacterPlacement cannot fill an array, it sets the corresponding member to NULL. To ensure retrieval of valid information, the application is responsible for setting the member to a valid address before calling the function and for checking the value of the member after the call. If the GCP_JUSTIFY or GCP_USEKERNING values are specified, the lpDX and/or lpCaretPos members must have valid addresses.Note that the glyph indexes returned in GCP_RESULTS.lpGlyphs are specific to the current font in the device context and should only be used to draw text in the device context while that font remains selected.When computing justification, if the trailing characters in the string are spaces, the function reduces the length of the string and removes the spaces prior to computing the justification. If the array consists of only spaces, the function returns an error.ExtTextOut expects an lpDX entry for each byte of a DBCS string, whereas GetCharacterPlacement assigns an lpDX entry for each glyph. To correct this mismatch when using this combination of functions, either use GetGlyphIndices or expand the lpDX array with zero-width entries for the corresponding second byte of a DBCS byte pair.If the logical width is less than the width of the leading character in the input string, GCP_RESULTS.nMaxFit returns a bad value. For this case, call GetCharacterPlacement for glyph indexes and the lpDX array. Then use the lpDX array to do the extent calculation using the advance width of each character, where nMaxFit is the number of characters whose glyph indexes advance width is less than the width of the leading character.ExtTextOutFont and Text FunctionsFonts and Text OverviewGCP_RESULTSGetCharABCWidthsGetCharWidth32GetFontLanguageInfoGetStringTypeExGetTextExtentPoint32GetTextMetrics</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetCharacterPlacementW(nint hdc, string lpString, int nCount, int nMexExtent, uint dwFlags);

        /// <summary>
        ///The GetCharWidth32 function retrieves the widths, in logical coordinates, of consecutive characters in a specified range from the current font.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="iFirst">The first character in the group of consecutive characters.</param>
        /// <param name="iLast">The last character in the group of consecutive characters, which must not precede the specified first character.</param>
        /// <param name="lpBuffer"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetCharWidth32A(nint hdc, uint iFirst, uint iLast, out int lpBuffer);

        /// <summary>
        ///The GetCharWidth32 function retrieves the widths, in logical coordinates, of consecutive characters in a specified range from the current font.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="iFirst">The first character in the group of consecutive characters.</param>
        /// <param name="iLast">The last character in the group of consecutive characters, which must not precede the specified first character.</param>
        /// <param name="lpBuffer"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetCharWidth32W(nint hdc, uint iFirst, uint iLast, out int lpBuffer);

        /// <summary>
        ///The GetCharWidth function retrieves the widths, in logical coordinates, of consecutive characters in a specified range from the current font.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="iFirst">The first character in the group of consecutive characters.</param>
        /// <param name="iLast">The last character in the group of consecutive characters, which must not precede the specified first character.</param>
        /// <param name="lpBuffer"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetCharWidthA(nint hdc, uint iFirst, uint iLast, out int lpBuffer);

        /// <summary>
        ///The GetCharWidthFloat function retrieves the fractional widths of consecutive characters in a specified range from the current font.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="iFirst">The code point of the first character in the group of consecutive characters.</param>
        /// <param name="iLast">The code point of the last character in the group of consecutive characters.</param>
        /// <param name="lpBuffer"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetCharWidthFloatA(nint hdc, uint iFirst, uint iLast, out float lpBuffer);

        /// <summary>
        ///The GetCharWidthFloat function retrieves the fractional widths of consecutive characters in a specified range from the current font.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="iFirst">The code point of the first character in the group of consecutive characters.</param>
        /// <param name="iLast">The code point of the last character in the group of consecutive characters.</param>
        /// <param name="lpBuffer"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetCharWidthFloatW(nint hdc, uint iFirst, uint iLast, out float lpBuffer);

        /// <summary>
        ///The GetCharWidthI function retrieves the widths, in logical coordinates, of consecutive glyph indices in a specified range from the current font.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="giFirst">The first glyph index in the group of consecutive glyph indices.</param>
        /// <param name="cgi">The number of glyph indices.</param>
        /// <param name="pgi">A pointer to an array of glyph indices. If this parameter is not NULL, it is used instead of the giFirst parameter.</param>
        /// <param name="piWidths"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetCharWidthI(nint hdc, uint giFirst, uint cgi, short pgi, out int piWidths);

        /// <summary>
        ///The GetCharWidth function retrieves the widths, in logical coordinates, of consecutive characters in a specified range from the current font.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="iFirst">The first character in the group of consecutive characters.</param>
        /// <param name="iLast">The last character in the group of consecutive characters, which must not precede the specified first character.</param>
        /// <param name="lpBuffer"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetCharWidthW(nint hdc, uint iFirst, uint iLast, out int lpBuffer);

        /// <summary>
        ///The GetClipBox function retrieves the dimensions of the tightest bounding rectangle that can be drawn around the current visible area on the device. The visible area is defined by the current clipping region or clip path, as well as any overlapping windows.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="lprect"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetClipBox(nint hdc, out int lprect);

        /// <summary>
        ///The GetClipRgn function retrieves a handle identifying the current application-defined clipping region for the specified device context.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="hrgn">A handle to an existing region before the function is called. After the function returns, this parameter is a handle to a copy of the current clipping region.If the function succeeds and there is no clipping region for the given device context, the return value is zero. If the function succeeds and there is a clipping region for the given device context, the return value is 1. If an error occurs, the return value is -1.An application-defined clipping region is a clipping region identified by the SelectClipRgn function. It is not a clipping region created when the application calls the BeginPaint function.If the function succeeds, the hrgn parameter is a handle to a copy of the current clipping region. Subsequent changes to this copy will not affect the current clipping region.BeginPaintClipping FunctionsClipping OverviewSelectClipRgn</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetClipRgn(nint hdc, nint hrgn);

        /// <summary>
        ///The GetColorAdjustment function retrieves the color adjustment values for the specified device context (DC).
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="lpca"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetColorAdjustment(nint hdc, out int lpca);

        /// <summary>
        ///The GetColorSpace function retrieves the handle to the input color space from a specified device context.
        /// </summary>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint GetColorSpace(nint hdc);

        /// <summary>
        ///The GetCurrentObject function retrieves a handle to an object of the specified type that has been selected into the specified device context (DC).
        /// </summary>
        /// <param name="hdc">A handle to the DC.</param>
        /// <param name="type">The object type to be queried. This parameter can be one of the following values.If the function succeeds, the return value is a handle to the specified object.If the function fails, the return value is NULL.An application can use the GetCurrentObject and GetObject functions to retrieve descriptions of the graphic objects currently selected into the specified DC.For an example, see Retrieving Graphic-Object Attributes and Selecting New Graphic Objects.CreateColorSpaceDeleteObjectDevice Context FunctionsDevice Contexts OverviewGetObjectSelectObject</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint GetCurrentObject(nint hdc, uint type);

        /// <summary>
        ///The GetCurrentPositionEx function retrieves the current position in logical coordinates.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="lppt"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetCurrentPositionEx(nint hdc, out int lppt);

        /// <summary>
        ///The GetDCBrushColor function retrieves the current brush color for the specified device context (DC).
        /// </summary>
        /// <param name="hdc">A handle to the DC whose brush color is to be returned.If the function succeeds, the return value is the COLORREF value for the current DC brush color.If the function fails, the return value is CLR_INVALID.For information on setting the brush color, see SetDCBrushColor.ICM: Color management is performed if ICM is enabled.COLORREFDevice Context FunctionsDevice Contexts OverviewSetDCBrushColor</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetDCBrushColor(nint hdc);

        /// <summary>
        ///The GetDCOrgEx function retrieves the final translation origin for a specified device context (DC). The final translation origin specifies an offset that the system uses to translate device coordinates into client coordinates (for coordinates in an application's window).
        /// </summary>
        /// <param name="hdc">A handle to the DC whose final translation origin is to be retrieved.</param>
        /// <param name="lppt"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetDCOrgEx(nint hdc, out int lppt);

        /// <summary>
        ///The GetDCPenColor function retrieves the current pen color for the specified device context (DC).
        /// </summary>
        /// <param name="hdc">A handle to the DC whose brush color is to be returned.If the function succeeds, the return value is a COLORREF value for the current DC pen color.If the function fails, the return value is CLR_INVALID.For information on setting the pen color, see SetDCPenColor.ICM: Color management is performed if ICM is enabled.COLORREFDevice Context FunctionsDevice Contexts OverviewSetDCPenColor</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetDCPenColor(nint hdc);

        /// <summary>
        ///The GetDeviceCaps function retrieves device-specific information for the specified device.
        /// </summary>
        /// <param name="hdc">A handle to the DC.</param>
        /// <param name="index">The item to be returned. This parameter can be one of the following values.The return value specifies the value of the desired item.When nIndex is BITSPIXEL and the device has 15bpp or 16bpp, the return value is 16.When nIndex is SHADEBLENDCAPS:For an example, see Preparing to Print.CreateEnhMetaFileCreateICDevice Context FunctionsDevice Contexts OverviewDeviceCapabilitiesGetDIBitsGetObjectTypeSetDIBitsSetDIBitsToDeviceStretchBltStretchDIBits</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetDeviceCaps(nint hdc, int index);

        /// <summary>
        ///The GetDeviceGammaRamp function gets the gamma ramp on direct color display boards having drivers that support downloadable gamma ramps in hardware.
        /// </summary>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetDeviceGammaRamp(nint hdc, nint lpRamp);

        /// <summary>
        ///The GetDIBColorTable function retrieves RGB (red, green, blue) color values from a range of entries in the color table of the DIB section bitmap that is currently selected into a specified device context.
        /// </summary>
        /// <param name="hdc">A handle to a device context. A DIB section bitmap must be selected into this device context.</param>
        /// <param name="iStart">A zero-based color table index that specifies the first color table entry to retrieve.</param>
        /// <param name="cEntries">The number of color table entries to retrieve.</param>
        /// <param name="prgbq"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetDIBColorTable(nint hdc, uint iStart, uint cEntries, out RGBQUAD prgbq);

        /// <summary>
        ///The GetDIBits function retrieves the bits of the specified compatible bitmap and copies them into a buffer as a DIB using the specified format.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="hbm">A handle to the bitmap. This must be a compatible bitmap (DDB).</param>
        /// <param name="start">The first scan line to retrieve.</param>
        /// <param name="cLines">The number of scan lines to retrieve.</param>
        /// <param name="lpvBits"></param>
        /// <param name="usage">The format of the bmiColors member of the BITMAPINFO structure. It must be one of the following values.If the lpvBits parameter is non-NULL and the function succeeds, the return value is the number of scan lines copied from the bitmap.If the lpvBits parameter is NULL and GetDIBits successfully fills the BITMAPINFO structure, the return value is nonzero.If the function fails, the return value is zero.This function can return the following value.If the requested format for the DIB matches its internal format, the RGB values for the bitmap are copied. If the requested format doesn't match the internal format, a color table is synthesized. The following table describes the color table synthesized for each format.If the lpvBits parameter is a valid pointer, the first six members of the BITMAPINFOHEADER structure must be initialized to specify the size and format of the DIB. The scan lines must be aligned on a DWORD except for RLE compressed bitmaps.A bottom-up DIB is specified by setting the height to a positive number, while a top-down DIB is specified by setting the height to a negative number. The bitmap color table will be appended to the BITMAPINFO structure.If lpvBits is NULL, GetDIBits examines the first member of the first structure pointed to by lpbi. This member must specify the size, in bytes, of a BITMAPCOREHEADER or a BITMAPINFOHEADER structure. The function uses the specified size to determine how the remaining members should be initialized.If lpvBits is NULL and the bit count member of BITMAPINFO is initialized to zero, GetDIBits fills in a BITMAPINFOHEADER structure or BITMAPCOREHEADER without the color table. This technique can be used to query bitmap attributes.The bitmap identified by the hbmp parameter must not be selected into a device context when the application calls this function.The origin for a bottom-up DIB is the lower-left corner of the bitmap; the origin for a top-down DIB is the upper-left corner.For an example, see Capturing an Image.BITMAPCOREHEADERBITMAPINFOBITMAPINFOHEADERBitmap FunctionsBitmaps OverviewSetDIBits</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetDIBits(nint hdc, nint hbm, uint start, uint cLines, out nint lpvBits, uint usage);

        /// <summary>
        ///The GetEnhMetaFile function creates a handle that identifies the enhanced-format metafile stored in the specified file.
        /// </summary>
        /// <param name="lpName">A pointer to a null-terminated string that specifies the name of an enhanced metafile.If the function succeeds, the return value is a handle to the enhanced metafile.If the function fails, the return value is NULL.When the application no longer needs an enhanced-metafile handle, it should delete the handle by calling the DeleteEnhMetaFile function.A Windows-format metafile must be converted to the enhanced format before it can be processed by the GetEnhMetaFile function. To convert the file, use the SetWinMetaFileBits function.Where text arguments must use Unicode characters, use this function as a wide-character function. Where text arguments must use characters from the Windows character set, use this function as an ANSI function.For an example, see Opening an Enhanced Metafile and Displaying Its Contents.DeleteEnhMetaFileGetEnhMetaFileMetafile FunctionsMetafiles OverviewSetWinMetaFileBits</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint GetEnhMetaFileA(string lpName);

        /// <summary>
        ///The GetEnhMetaFileBits function retrieves the contents of the specified enhanced-format metafile and copies them into a buffer.
        /// </summary>
        /// <param name="hEMF">A handle to the enhanced metafile.</param>
        /// <param name="nSize">The size, in bytes, of the buffer to receive the data.</param>
        /// <param name="lpData"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetEnhMetaFileBits(nint hEMF, uint nSize, out int lpData);

        /// <summary>
        ///The GetEnhMetaFileDescription function retrieves an optional text description from an enhanced-format metafile and copies the string to the specified buffer.
        /// </summary>
        /// <param name="hemf">A handle to the enhanced metafile.</param>
        /// <param name="cchBuffer">The size, in characters, of the buffer to receive the data. Only this many characters will be copied.</param>
        /// <param name="lpDescription"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetEnhMetaFileDescriptionA(nint hemf, uint cchBuffer, out string lpDescription);

        /// <summary>
        ///The GetEnhMetaFileDescription function retrieves an optional text description from an enhanced-format metafile and copies the string to the specified buffer.
        /// </summary>
        /// <param name="hemf">A handle to the enhanced metafile.</param>
        /// <param name="cchBuffer">The size, in characters, of the buffer to receive the data. Only this many characters will be copied.</param>
        /// <param name="lpDescription"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetEnhMetaFileDescriptionW(nint hemf, uint cchBuffer, out string lpDescription);

        /// <summary>
        ///The GetEnhMetaFileHeader function retrieves the record containing the header for the specified enhanced-format metafile.
        /// </summary>
        /// <param name="hemf">A handle to the enhanced metafile for which the header is to be retrieved.</param>
        /// <param name="nSize">The size, in bytes, of the buffer to receive the data. Only this many bytes will be copied.</param>
        /// <param name="lpEnhMetaHeader"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetEnhMetaFileHeader(nint hemf, uint nSize, out nint lpEnhMetaHeader);

        /// <summary>
        ///The GetEnhMetaFilePaletteEntries function retrieves optional palette entries from the specified enhanced metafile.
        /// </summary>
        /// <param name="hemf">A handle to the enhanced metafile.</param>
        /// <param name="nNumEntries">The number of entries to be retrieved from the optional palette.</param>
        /// <param name="lpPaletteEntries"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetEnhMetaFilePaletteEntries(nint hemf, uint nNumEntries, out int lpPaletteEntries);

        /// <summary>
        ///The GetEnhMetaFilePixelFormat function retrieves pixel format information for an enhanced metafile.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetEnhMetaFilePixelFormat(nint hemf, uint cbBuffer, PIXELFORMATDESCRIPTOR ppfd);

        /// <summary>
        ///The GetEnhMetaFile function creates a handle that identifies the enhanced-format metafile stored in the specified file.
        /// </summary>
        /// <param name="lpName">A pointer to a null-terminated string that specifies the name of an enhanced metafile.If the function succeeds, the return value is a handle to the enhanced metafile.If the function fails, the return value is NULL.When the application no longer needs an enhanced-metafile handle, it should delete the handle by calling the DeleteEnhMetaFile function.A Windows-format metafile must be converted to the enhanced format before it can be processed by the GetEnhMetaFile function. To convert the file, use the SetWinMetaFileBits function.Where text arguments must use Unicode characters, use this function as a wide-character function. Where text arguments must use characters from the Windows character set, use this function as an ANSI function.For an example, see Opening an Enhanced Metafile and Displaying Its Contents.DeleteEnhMetaFileGetEnhMetaFileMetafile FunctionsMetafiles OverviewSetWinMetaFileBits</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint GetEnhMetaFileW(string lpName);

        /// <summary>
        ///The GetFontData function retrieves font metric data for a TrueType font.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="dwTable">The name of a font metric table from which the font data is to be retrieved. This parameter can identify one of the metric tables documented in the TrueType Font Files specification published by Microsoft Corporation. If this parameter is zero, the information is retrieved starting at the beginning of the file for TrueType font files or from the beginning of the data for the currently selected font for TrueType Collection files. To retrieve the data from the beginning of the file for TrueType Collection files specify 'ttcf' (0x66637474).</param>
        /// <param name="dwOffset">The offset from the beginning of the font metric table to the location where the function should begin retrieving information. If this parameter is zero, the information is retrieved starting at the beginning of the table specified by the dwTable parameter. If this value is greater than or equal to the size of the table, an error occurs.</param>
        /// <param name="pvBuffer"></param>
        /// <param name="cjBuffer">The length, in bytes, of the information to be retrieved. If this parameter is zero, GetFontData returns the size of the data specified in the dwTable parameter.If the function succeeds, the return value is the number of bytes returned.If the function fails, the return value is GDI_ERROR.This function is intended to be used to retrieve TrueType font information directly from the font file by font-manipulation applications. For information about embedding fonts see the Font Embedding Reference.An application can sometimes use the GetFontData function to save a TrueType font with a document. To do this, the application determines whether the font can be embedded by checking the otmfsType member of the OUTLINETEXTMETRIC structure. If bit 1 of otmfsType is set, embedding is not permitted for the font. If bit 1 is clear, the font can be embedded. If bit 2 is set, the embedding is read-only. If embedding is permitted, the application can retrieve the entire font file, specifying zero for the dwTable, dwOffset, and cbData parameters.If an application attempts to use this function to retrieve information for a non-TrueType font, an error occurs.Font and Text FunctionsFonts and Text OverviewGetTextMetricsOUTLINETEXTMETRIC</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetFontData(nint hdc, uint dwTable, uint dwOffset, out nint pvBuffer, uint cjBuffer);

        /// <summary>
        ///The GetFontLanguageInfo function returns information about the currently selected font for the specified display context. Applications typically use this information and the GetCharacterPlacement function to prepare a character string for display.
        /// </summary>
        /// <param name="hdc">Handle to a display device context.The return value identifies characteristics of the currently selected font. The function returns 0 if the font is "normalized" and can be treated as a simple Latin font; it returns GCP_ERROR if an error occurs. Otherwise, the function returns a combination of the following values.The return value, when masked with FLI_MASK, can be passed directly to the GetCharacterPlacement function.ExtTextOutFont and Text FunctionsFonts and Text OverviewGetCharacterPlacement</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetFontLanguageInfo(nint hdc);

        /// <summary>
        ///The GetFontUnicodeRanges function returns information about which Unicode characters are supported by a font. The information is returned as a GLYPHSET structure.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="lpgs"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetFontUnicodeRanges(nint hdc, out nint lpgs);

        /// <summary>
        ///The GetGlyphIndices function translates a string into an array of glyph indices. The function can be used to determine whether a glyph exists in a font.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="lpstr">A pointer to the string to be converted.</param>
        /// <param name="c">The length of both the length of the string pointed to by lpstr and the size (in WORDs) of the buffer pointed to by pgi.</param>
        /// <param name="pgi"></param>
        /// <param name="fl">Specifies how glyphs should be handled if they are not supported. This parameter can be the following value.If the function succeeds, it returns the number of bytes (for the ANSI function) or WORDs (for the Unicode function) converted.If the function fails, the return value is GDI_ERROR.This function attempts to identify a single-glyph representation for each character in the string pointed to by lpstr. While this is useful for certain low-level purposes (such as manipulating font files), higher-level applications that wish to map a string to glyphs will typically wish to use the Uniscribe functions.Font and Text FunctionsFonts and Text OverviewGetFontUnicodeRanges</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetGlyphIndicesA(nint hdc, string lpstr, int c, out short pgi, uint fl);

        /// <summary>
        ///The GetGlyphIndices function translates a string into an array of glyph indices. The function can be used to determine whether a glyph exists in a font.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="lpstr">A pointer to the string to be converted.</param>
        /// <param name="c">The length of both the length of the string pointed to by lpstr and the size (in WORDs) of the buffer pointed to by pgi.</param>
        /// <param name="pgi"></param>
        /// <param name="fl">Specifies how glyphs should be handled if they are not supported. This parameter can be the following value.If the function succeeds, it returns the number of bytes (for the ANSI function) or WORDs (for the Unicode function) converted.If the function fails, the return value is GDI_ERROR.This function attempts to identify a single-glyph representation for each character in the string pointed to by lpstr. While this is useful for certain low-level purposes (such as manipulating font files), higher-level applications that wish to map a string to glyphs will typically wish to use the Uniscribe functions.Font and Text FunctionsFonts and Text OverviewGetFontUnicodeRanges</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetGlyphIndicesW(nint hdc, string lpstr, int c, out short pgi, uint fl);

        /// <summary>
        ///The GetGlyphOutline function retrieves the outline or bitmap for a character in the TrueType font that is selected into the specified device context.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="uChar">The character for which data is to be returned.</param>
        /// <param name="fuFormat">The format of the data that the function retrieves. This parameter can be one of the following values.Note that, for the GGO_GRAYn_BITMAP values, the function retrieves a glyph bitmap that contains n^2+1 (n squared plus one) levels of gray.</param>
        /// <param name="lpgm"></param>
        /// <param name="cjBuffer">The size, in bytes, of the buffer (*lpvBuffer) where the function is to copy information about the outline character. If this value is zero, the function returns the required size of the buffer.</param>
        /// <param name="pvBuffer"></param>
        /// <param name="lpmat2">A pointer to a MAT2 structure specifying a transformation matrix for the character.If GGO_BITMAP, GGO_GRAY2_BITMAP, GGO_GRAY4_BITMAP, GGO_GRAY8_BITMAP, or GGO_NATIVE is specified and the function succeeds, the return value is greater than zero; otherwise, the return value is GDI_ERROR. If one of these flags is specified and the buffer size or address is zero, the return value specifies the required buffer size, in bytes.If GGO_METRICS is specified and the function fails, the return value is GDI_ERROR.The glyph outline returned by the GetGlyphOutline function is for a grid-fitted glyph. (A grid-fitted glyph is a glyph that has been modified so that its bitmapped image conforms as closely as possible to the original design of the glyph.) If an application needs an unmodified glyph outline, it can request the glyph outline for a character in a font whose size is equal to the font's em unit. The value for a font's em unit is stored in the otmEMSquare member of the OUTLINETEXTMETRIC structure.The glyph bitmap returned by GetGlyphOutline when GGO_BITMAP is specified is a DWORD-aligned, row-oriented, monochrome bitmap. When GGO_GRAY2_BITMAP is specified, the bitmap returned is a DWORD-aligned, row-oriented array of bytes whose values range from 0 to 4. When GGO_GRAY4_BITMAP is specified, the bitmap returned is a DWORD-aligned, row-oriented array of bytes whose values range from 0 to 16. When GGO_GRAY8_BITMAP is specified, the bitmap returned is a DWORD-aligned, row-oriented array of bytes whose values range from 0 to 64.The native buffer returned by GetGlyphOutline when GGO_NATIVE is specified is a glyph outline. A glyph outline is returned as a series of one or more contours defined by a TTPOLYGONHEADER structure followed by one or more curves. Each curve in the contour is defined by a TTPOLYCURVE structure followed by a number of POINTFX data points. POINTFX points are absolute positions, not relative moves. The starting point of a contour is given by the pfxStart member of the TTPOLYGONHEADER structure. The starting point of each curve is the last point of the previous curve or the starting point of the contour. The count of data points in a curve is stored in the cpfx member of TTPOLYCURVE structure. The size of each contour in the buffer, in bytes, is stored in the cb member of TTPOLYGONHEADER structure. Additional curve definitions are packed into the buffer following preceding curves and additional contours are packed into the buffer following preceding contours. The buffer contains as many contours as fit within the buffer returned by GetGlyphOutline.The GLYPHMETRICS structure specifies the width of the character cell and the location of a glyph within the character cell. The origin of the character cell is located at the left side of the cell at the baseline of the font. The location of the glyph origin is relative to the character cell origin. The height of a character cell, the baseline, and other metrics global to the font are given by the OUTLINETEXTMETRIC structure.An application can alter the characters retrieved in bitmap or native format by specifying a 2-by-2 transformation matrix in the lpMatrix parameter. For example the glyph can be modified by shear, rotation, scaling, or any combination of the three using matrix multiplication.Additional information on a glyph outlines is located in the TrueType and the OpenType technical specifications.ExtTextOutFORM_INFO_1Font and Text FunctionsFonts and Text OverviewGLYPHMETRICSGetOutlineTextMetricsMAT2OUTLINETEXTMETRICPOINTPOINTFXTTPOLYCURVETTPOLYGONHEADER</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetGlyphOutlineA(nint hdc, uint uChar, uint fuFormat, out nint lpgm, uint cjBuffer, out nint pvBuffer, MAT2 lpmat2);

        /// <summary>
        ///The GetGlyphOutline function retrieves the outline or bitmap for a character in the TrueType font that is selected into the specified device context.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="uChar">The character for which data is to be returned.</param>
        /// <param name="fuFormat">The format of the data that the function retrieves. This parameter can be one of the following values.Note that, for the GGO_GRAYn_BITMAP values, the function retrieves a glyph bitmap that contains n^2+1 (n squared plus one) levels of gray.</param>
        /// <param name="lpgm"></param>
        /// <param name="cjBuffer">The size, in bytes, of the buffer (*lpvBuffer) where the function is to copy information about the outline character. If this value is zero, the function returns the required size of the buffer.</param>
        /// <param name="pvBuffer"></param>
        /// <param name="lpmat2">A pointer to a MAT2 structure specifying a transformation matrix for the character.If GGO_BITMAP, GGO_GRAY2_BITMAP, GGO_GRAY4_BITMAP, GGO_GRAY8_BITMAP, or GGO_NATIVE is specified and the function succeeds, the return value is greater than zero; otherwise, the return value is GDI_ERROR. If one of these flags is specified and the buffer size or address is zero, the return value specifies the required buffer size, in bytes.If GGO_METRICS is specified and the function fails, the return value is GDI_ERROR.The glyph outline returned by the GetGlyphOutline function is for a grid-fitted glyph. (A grid-fitted glyph is a glyph that has been modified so that its bitmapped image conforms as closely as possible to the original design of the glyph.) If an application needs an unmodified glyph outline, it can request the glyph outline for a character in a font whose size is equal to the font's em unit. The value for a font's em unit is stored in the otmEMSquare member of the OUTLINETEXTMETRIC structure.The glyph bitmap returned by GetGlyphOutline when GGO_BITMAP is specified is a DWORD-aligned, row-oriented, monochrome bitmap. When GGO_GRAY2_BITMAP is specified, the bitmap returned is a DWORD-aligned, row-oriented array of bytes whose values range from 0 to 4. When GGO_GRAY4_BITMAP is specified, the bitmap returned is a DWORD-aligned, row-oriented array of bytes whose values range from 0 to 16. When GGO_GRAY8_BITMAP is specified, the bitmap returned is a DWORD-aligned, row-oriented array of bytes whose values range from 0 to 64.The native buffer returned by GetGlyphOutline when GGO_NATIVE is specified is a glyph outline. A glyph outline is returned as a series of one or more contours defined by a TTPOLYGONHEADER structure followed by one or more curves. Each curve in the contour is defined by a TTPOLYCURVE structure followed by a number of POINTFX data points. POINTFX points are absolute positions, not relative moves. The starting point of a contour is given by the pfxStart member of the TTPOLYGONHEADER structure. The starting point of each curve is the last point of the previous curve or the starting point of the contour. The count of data points in a curve is stored in the cpfx member of TTPOLYCURVE structure. The size of each contour in the buffer, in bytes, is stored in the cb member of TTPOLYGONHEADER structure. Additional curve definitions are packed into the buffer following preceding curves and additional contours are packed into the buffer following preceding contours. The buffer contains as many contours as fit within the buffer returned by GetGlyphOutline.The GLYPHMETRICS structure specifies the width of the character cell and the location of a glyph within the character cell. The origin of the character cell is located at the left side of the cell at the baseline of the font. The location of the glyph origin is relative to the character cell origin. The height of a character cell, the baseline, and other metrics global to the font are given by the OUTLINETEXTMETRIC structure.An application can alter the characters retrieved in bitmap or native format by specifying a 2-by-2 transformation matrix in the lpMatrix parameter. For example the glyph can be modified by shear, rotation, scaling, or any combination of the three using matrix multiplication.Additional information on a glyph outlines is located in the TrueType and the OpenType technical specifications.ExtTextOutFORM_INFO_1Font and Text FunctionsFonts and Text OverviewGLYPHMETRICSGetOutlineTextMetricsMAT2OUTLINETEXTMETRICPOINTPOINTFXTTPOLYCURVETTPOLYGONHEADER</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetGlyphOutlineW(nint hdc, uint uChar, uint fuFormat, out nint lpgm, uint cjBuffer, out nint pvBuffer, MAT2 lpmat2);

        /// <summary>
        ///The GetGraphicsMode function retrieves the current graphics mode for the specified device context.
        /// </summary>
        /// <param name="hdc">A handle to the device context.If the function succeeds, the return value is the current graphics mode. It can be one of the following values.Otherwise, the return value is zero.An application can set the graphics mode for a device context by calling the SetGraphicsMode function.Coordinate Space and Transformation FunctionsCoordinate Spaces and Transformations OverviewSetGraphicsMode</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetGraphicsMode(nint hdc);

        /// <summary>
        ///The GetICMProfile function retrieves the file name of the current output color profile for a specified device context.
        /// </summary>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetICMProfileA(nint hdc, uint pBufSize, string pszFilename);

        /// <summary>
        ///The GetICMProfile function retrieves the file name of the current output color profile for a specified device context.
        /// </summary>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetICMProfileW(nint hdc, uint pBufSize, string pszFilename);

        /// <summary>
        ///The GetKerningPairs function retrieves the character-kerning pairs for the currently selected font for the specified device context.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="nPairs">The number of pairs in the lpkrnpair array. If the font has more than nNumPairs kerning pairs, the function returns an error.</param>
        /// <param name="lpKernPair"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetKerningPairsA(nint hdc, uint nPairs, out int lpKernPair);

        /// <summary>
        ///The GetKerningPairs function retrieves the character-kerning pairs for the currently selected font for the specified device context.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="nPairs">The number of pairs in the lpkrnpair array. If the font has more than nNumPairs kerning pairs, the function returns an error.</param>
        /// <param name="lpKernPair"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetKerningPairsW(nint hdc, uint nPairs, out int lpKernPair);

        /// <summary>
        ///The GetLayout function returns the layout of a device context (DC).
        /// </summary>
        /// <param name="hdc">A handle to the device context.If the function succeeds, it returns the layout flags for the current device context.If the function fails, it returns GDI_ERROR. For extended error information, call GetLastError.The layout specifies the order in which text and graphics are revealed in a window or device context. The default is left to right. The GetLayout function tells you if the default has been changed through a call to SetLayout. For more information, see "Window Layout and Mirroring" in Window Features.Device Context FunctionsDevice Contexts OverviewSetLayout</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetLayout(nint hdc);

        /// <summary>
        ///The GetLogColorSpace function retrieves the color space definition identified by a specified handle.
        /// </summary>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetLogColorSpaceA(nint hColorSpace, int lpBuffer, uint nSize);

        /// <summary>
        ///The GetLogColorSpace function retrieves the color space definition identified by a specified handle.
        /// </summary>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetLogColorSpaceW(nint hColorSpace, int lpBuffer, uint nSize);

        /// <summary>
        ///The GetMapMode function retrieves the current mapping mode.
        /// </summary>
        /// <param name="hdc">A handle to the device context.If the function succeeds, the return value specifies the mapping mode.If the function fails, the return value is zero.The following are the various mapping modes.Coordinate Space and Transformation FunctionsCoordinate Spaces and Transformations OverviewSetMapModeSetViewportExtExSetWindowExtEx</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetMapMode(nint hdc);

        /// <summary>
        ///[GetMetaFile is no longer available for use as of Windows 2000. Instead, use GetEnhMetaFile.]
        /// </summary>
        /// <param name="lpName">A pointer to a null-terminated string that specifies the name of a metafile.If the function succeeds, the return value is a handle to the metafile.If the function fails, the return value is NULL.This function is not implemented in the Win32 API. It is provided for compatibility with 16-bit versions of Windows. In Win32 applications, use the GetEnhMetaFile function.GetEnhMetaFile</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint GetMetaFileA(string lpName);

        /// <summary>
        ///The GetMetaFileBitsEx function retrieves the contents of a Windows-format metafile and copies them into the specified buffer.
        /// </summary>
        /// <param name="hMF">A handle to a Windows-format metafile.</param>
        /// <param name="cbBuffer">The size, in bytes, of the buffer to receive the data.</param>
        /// <param name="lpData"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetMetaFileBitsEx(nint hMF, uint cbBuffer, out nint lpData);

        /// <summary>
        ///[GetMetaFile is no longer available for use as of Windows 2000. Instead, use GetEnhMetaFile.]
        /// </summary>
        /// <param name="lpName">A pointer to a null-terminated string that specifies the name of a metafile.If the function succeeds, the return value is a handle to the metafile.If the function fails, the return value is NULL.This function is not implemented in the Win32 API. It is provided for compatibility with 16-bit versions of Windows. In Win32 applications, use the GetEnhMetaFile function.GetEnhMetaFile</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint GetMetaFileW(string lpName);

        /// <summary>
        ///The GetMetaRgn function retrieves the current metaregion for the specified device context.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="hrgn">A handle to an existing region before the function is called. After the function returns, this parameter is a handle to a copy of the current metaregion.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.If the function succeeds, hrgn is a handle to a copy of the current metaregion. Subsequent changes to this copy will not affect the current metaregion.The current clipping region of a device context is defined by the intersection of its clipping region and its metaregion.Clipping FunctionsClipping OverviewSetMetaRgn</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetMetaRgn(nint hdc, nint hrgn);

        /// <summary>
        ///The GetMiterLimit function retrieves the miter limit for the specified device context.
        /// </summary>
        /// <param name="hdc">Handle to the device context.</param>
        /// <param name="plimit"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetMiterLimit(nint hdc, out float plimit);

        /// <summary>
        ///The GetNearestColor function retrieves a color value identifying a color from the system palette that will be displayed when the specified color value is used.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="color">A color value that identifies a requested color. To create a COLORREF color value, use the RGB macro.If the function succeeds, the return value identifies a color from the system palette that corresponds to the given color value.If the function fails, the return value is CLR_INVALID.COLORREFColor FunctionsColors OverviewGetDeviceCapsGetNearestPaletteIndexRGB</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetNearestColor(nint hdc, int color);

        /// <summary>
        ///The GetNearestPaletteIndex function retrieves the index for the entry in the specified logical palette most closely matching a specified color value.
        /// </summary>
        /// <param name="h">A handle to a logical palette.</param>
        /// <param name="color">A color to be matched. To create a COLORREF color value, use the RGB macro.If the function succeeds, the return value is the index of an entry in a logical palette.If the function fails, the return value is CLR_INVALID.An application can determine whether a device supports palette operations by calling the GetDeviceCaps function and specifying the RASTERCAPS constant.If the given logical palette contains entries with the PC_EXPLICIT flag set, the return value is undefined.COLORREFColor FunctionsColors OverviewGetDeviceCapsGetNearestColorGetPaletteEntriesGetSystemPaletteEntriesRGB</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetNearestPaletteIndex(nint h, int color);

        /// <summary>
        ///The GetObject function retrieves information for the specified graphics object.
        /// </summary>
        /// <param name="h">A handle to the graphics object of interest. This can be a handle to one of the following: a logical bitmap, a brush, a font, a palette, a pen, or a device independent bitmap created by calling the CreateDIBSection function.</param>
        /// <param name="c">The number of bytes of information to be written to the buffer.</param>
        /// <param name="pv"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetObject(nint h, int c, out nint pv);

        /// <summary>
        ///The GetObject function retrieves information for the specified graphics object.
        /// </summary>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetObjectA(nint h, int c, nint pv);

        /// <summary>
        ///The GetObjectType retrieves the type of the specified object.
        /// </summary>
        /// <param name="h">A handle to the graphics object.If the function succeeds, the return value identifies the object. This value can be one of the following.If the function fails, the return value is zero.Device Context FunctionsDevice Contexts OverviewGetObjectSelectObject</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetObjectType(nint h);

        /// <summary>
        ///The GetObject function retrieves information for the specified graphics object.
        /// </summary>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetObjectW(nint h, int c, nint pv);

        /// <summary>
        ///The GetOutlineTextMetrics function retrieves text metrics for TrueType fonts.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="cjCopy">The size, in bytes, of the array that receives the text metrics.</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetOutlineTextMetricsA(nint hdc, uint cjCopy);

        /// <summary>
        ///The GetOutlineTextMetrics function retrieves text metrics for TrueType fonts.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="cjCopy">The size, in bytes, of the array that receives the text metrics.</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetOutlineTextMetricsW(nint hdc, uint cjCopy);

        /// <summary>
        ///The GetPaletteEntries function retrieves a specified range of palette entries from the given logical palette.
        /// </summary>
        /// <param name="hpal">A handle to the logical palette.</param>
        /// <param name="iStart">The first entry in the logical palette to be retrieved.</param>
        /// <param name="cEntries">The number of entries in the logical palette to be retrieved.</param>
        /// <param name="pPalEntries"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetPaletteEntries(nint hpal, uint iStart, uint cEntries, out int pPalEntries);

        /// <summary>
        ///The GetPath function retrieves the coordinates defining the endpoints of lines and the control points of curves found in the path that is selected into the specified device context.
        /// </summary>
        /// <param name="hdc">A handle to a device context that contains a closed path.</param>
        /// <param name="apt"></param>
        /// <param name="aj"></param>
        /// <param name="cpt">The total number of POINT structures that can be stored in the array pointed to by lpPoints. This value must be the same as the number of bytes that can be placed in the array pointed to by lpTypes.If the nSize parameter is nonzero, the return value is the number of points enumerated. If nSize is 0, the return value is the total number of points in the path (and GetPath writes nothing to the buffers). If nSize is nonzero and is less than the number of points in the path, the return value is 1.The device context identified by the hdc parameter must contain a closed path.The points of the path are returned in logical coordinates. Points are stored in the path in device coordinates, so GetPath changes the points from device coordinates to logical coordinates by using the inverse of the current transformation.The FlattenPath function may be called before GetPath to convert all curves in the path into line segments.FlattenPathPOINTPath FunctionsPaths OverviewPolyDrawWidenPath</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetPath(nint hdc, out int apt, out int aj, int cpt);

        /// <summary>
        ///The GetPixel function retrieves the red, green, blue (RGB) color value of the pixel at the specified coordinates.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="x">The x-coordinate, in logical units, of the pixel to be examined.</param>
        /// <param name="y">The y-coordinate, in logical units, of the pixel to be examined.The return value is the COLORREF value that specifies the RGB of the pixel. If the pixel is outside of the current clipping region, the return value is CLR_INVALID (0xFFFFFFFF defined in Wingdi.h).The pixel must be within the boundaries of the current clipping region.Not all devices support GetPixel. An application should call GetDeviceCaps to determine whether a specified device supports this function.A bitmap must be selected within the device context, otherwise, CLR_INVALID is returned on all pixels.Bitmap FunctionsBitmaps OverviewCOLORREFGetDeviceCapsSetPixel</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetPixel(nint hdc, int x, int y);

        /// <summary>
        ///The GetPixelFormat function obtains the index of the currently selected pixel format of the specified device context.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetPixelFormat(nint hdc);

        /// <summary>
        ///The GetPolyFillMode function retrieves the current polygon fill mode.
        /// </summary>
        /// <param name="hdc">Handle to the device context.If the function succeeds, the return value specifies the polygon fill mode, which can be one of the following values.If an error occurs, the return value is zero.Region FunctionsRegions OverviewSetPolyFillMode</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetPolyFillMode(nint hdc);

        /// <summary>
        ///The GetRandomRgn function copies the system clipping region of a specified device context to a specific region.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="hrgn">A handle to a region. Before the function is called, this identifies an existing region. After the function returns, this identifies a copy of the current system region. The old region identified by hrgn is overwritten.</param>
        /// <param name="i">This parameter must be SYSRGN.If the function succeeds, the return value is 1. If the function fails, the return value is -1. If the region to be retrieved is NULL, the return value is 0. If the function fails or the region to be retrieved is NULL, hrgn is not initialized.When using the SYSRGN flag, note that the system clipping region might not be current because of window movements. Nonetheless, it is safe to retrieve and use the system clipping region within the BeginPaint-EndPaint block during WM_PAINT processing. In this case, the system region is the intersection of the update region and the current visible area of the window. Any window movement following the return of GetRandomRgn and before EndPaint will result in a new WM_PAINT message. Any other use of the SYSRGN flag may result in painting errors in your application.The region returned is in screen coordinates.BeginPaintClipping FunctionsClipping OverviewEndPaintExtSelectClipRgnGetClipBoxGetClipRgnGetRegionDataOffsetRgn</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetRandomRgn(nint hdc, nint hrgn, int i);

        /// <summary>
        ///The GetRasterizerCaps function returns flags indicating whether TrueType fonts are installed in the system.
        /// </summary>
        /// <param name="lpraststat"></param>
        /// <param name="cjBytes">The number of bytes to be copied into the structure pointed to by the lprs parameter.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The GetRasterizerCaps function enables applications and printer drivers to determine whether TrueType fonts are installed.If the TT_AVAILABLE flag is set in the wFlags member of the RASTERIZER_STATUS structure, at least one TrueType font is installed. If the TT_ENABLED flag is set, TrueType is enabled for the system.The actual number of bytes copied is either the member specified in the cb parameter or the length of the RASTERIZER_STATUS structure, whichever is less.Font and Text FunctionsFonts and Text OverviewGetOutlineTextMetricsRASTERIZER_STATUS</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetRasterizerCaps(out int lpraststat, uint cjBytes);

        /// <summary>
        ///The GetRegionData function fills the specified buffer with data describing a region. This data includes the dimensions of the rectangles that make up the region.
        /// </summary>
        /// <param name="hrgn">A handle to the region.</param>
        /// <param name="nCount">The size, in bytes, of the lpRgnData buffer.</param>
        /// <param name="lpRgnData"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetRegionData(nint hrgn, uint nCount, out int lpRgnData);

        /// <summary>
        ///The GetRgnBox function retrieves the bounding rectangle of the specified region.
        /// </summary>
        /// <param name="hrgn">A handle to the region.</param>
        /// <param name="lprc"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetRgnBox(nint hrgn, out int lprc);

        /// <summary>
        ///The GetROP2 function retrieves the foreground mix mode of the specified device context. The mix mode specifies how the pen or interior color and the color already on the screen are combined to yield a new color.
        /// </summary>
        /// <param name="hdc">Handle to the device context.If the function succeeds, the return value specifies the foreground mix mode.If the function fails, the return value is zero.Following are the foreground mix modes.Painting and Drawing FunctionsPainting and Drawing OverviewSetROP2</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetROP2(nint hdc);

        /// <summary>
        ///The GetStockObject function retrieves a handle to one of the stock pens, brushes, fonts, or palettes.
        /// </summary>
        /// <param name="i">The type of stock object. This parameter can be one of the following values.If the function succeeds, the return value is a handle to the requested logical object.If the function fails, the return value is NULL.It is not recommended that you employ this method to obtain the current font used by dialogs and windows. Instead, use the SystemParametersInfo function with the SPI_GETNONCLIENTMETRICS parameter to retrieve the current font. SystemParametersInfo will take into account the current theme and provides font information for captions, menus, and message dialogs.Use the DKGRAY_BRUSH, GRAY_BRUSH, and LTGRAY_BRUSH stock objects only in windows with the CS_HREDRAW and CS_VREDRAW styles. Using a gray stock brush in any other style of window can lead to misalignment of brush patterns after a window is moved or sized. The origins of stock brushes cannot be adjusted.The HOLLOW_BRUSH and NULL_BRUSH stock objects are equivalent.It is not necessary (but it is not harmful) to delete stock objects by calling DeleteObject.Both DC_BRUSH and DC_PEN can be used interchangeably with other stock objects like BLACK_BRUSH and BLACK_PEN. For information on retrieving the current pen or brush color, see GetDCBrushColor and GetDCPenColor. See Setting the Pen or Brush Color for an example of setting colors. The GetStockObject function with an argument of DC_BRUSH or DC_PEN can be used interchangeably with the SetDCPenColor and SetDCBrushColor functions.For an example, see Setting the Pen or Brush Color.DeleteObjectDevice Context FunctionsDevice Contexts OverviewSelectObject</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint GetStockObject(int i);

        /// <summary>
        ///The GetStretchBltMode function retrieves the current stretching mode. The stretching mode defines how color data is added to or removed from bitmaps that are stretched or compressed when the StretchBlt function is called.
        /// </summary>
        /// <param name="hdc">A handle to the device context.If the function succeeds, the return value is the current stretching mode. This can be one of the following values.If the function fails, the return value is zero.Bitmap FunctionsBitmaps OverviewSetStretchBltMode</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetStretchBltMode(nint hdc);

        /// <summary>
        ///The GetSystemPaletteEntries function retrieves a range of palette entries from the system palette that is associated with the specified device context (DC).
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="iStart">The first entry to be retrieved from the system palette.</param>
        /// <param name="cEntries">The number of entries to be retrieved from the system palette.</param>
        /// <param name="pPalEntries"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetSystemPaletteEntries(nint hdc, uint iStart, uint cEntries, out int pPalEntries);

        /// <summary>
        ///The GetSystemPaletteUse function retrieves the current state of the system (physical) palette for the specified device context (DC).
        /// </summary>
        /// <param name="hdc">A handle to the device context.If the function succeeds, the return value is the current state of the system palette. This parameter can be one of the following values.By default, the system palette contains 20 static colors that are not changed when an application realizes its logical palette. An application can gain access to most of these colors by calling the SetSystemPaletteUse function.The device context identified by the hdc parameter must represent a device that supports color palettes.An application can determine whether a device supports color palettes by calling the GetDeviceCaps function and specifying the RASTERCAPS constant.Color FunctionsColors OverviewGetDeviceCapsSetSystemPaletteUse</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetSystemPaletteUse(nint hdc);

        /// <summary>
        ///The GetTextAlign function retrieves the text-alignment setting for the specified device context.
        /// </summary>
        /// <param name="hdc">A handle to the device context.If the function succeeds, the return value is the status of the text-alignment flags. For more information about the return value, see the Remarks section. The return value is a combination of the following values.When the current font has a vertical default base line (as with Kanji), the following values are used instead of TA_BASELINE and TA_CENTER.If the function fails, the return value is GDI_ERROR.The bounding rectangle is a rectangle bounding all of the character cells in a string of text. Its dimensions can be obtained by calling the GetTextExtentPoint32 function.The text-alignment flags determine how the TextOut and ExtTextOut functions align a string of text in relation to the string's reference point provided to TextOut or ExtTextOut.The text-alignment flags are not necessarily single bit flags and may be equal to zero. The flags must be examined in groups of related flags, as shown in the following list.To verify that a particular flag is set in the return value of this function:For an example, see Setting the Text Alignment.ExtTextOutFont and Text FunctionsFonts and Text OverviewGetTextExtentPoint32SetTextAlignTextOut</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetTextAlign(nint hdc);

        /// <summary>
        ///The GetTextCharacterExtra function retrieves the current intercharacter spacing for the specified device context.
        /// </summary>
        /// <param name="hdc">Handle to the device context.If the function succeeds, the return value is the current intercharacter spacing, in logical coordinates.If the function fails, the return value is 0x8000000.The intercharacter spacing defines the extra space, in logical units along the base line, that the TextOut or ExtTextOut functions add to each character as a line is written. The spacing is used to expand lines of text.ExtTextOutFont and Text FunctionsFonts and Text OverviewSetTextCharacterExtraTextOut</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetTextCharacterExtra(nint hdc);

        /// <summary>
        ///Retrieves a character set identifier for the font that is currently selected into a specified device context.
        /// </summary>
        /// <param name="hdc">Handle to a device context. The function obtains a character set identifier for the font that is selected into this device context.If successful, returns a value identifying the character set of the font that is currently selected into the specified device context. The following character set identifiers are defined:If the function fails, it returns DEFAULT_CHARSET.GetTextCharsetInfoUnicode and Character Set FunctionsUnicode and Character Sets</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetTextCharset(nint hdc);

        /// <summary>
        ///Retrieves information about the character set of the font that is currently selected into a specified device context.
        /// </summary>
        /// <param name="hdc">Handle to a device context. The function obtains information about the font that is selected into this device context.</param>
        /// <param name="dwFlags">Reserved; must be set to 0.If successful, returns a value identifying the character set of the font currently selected into the specified device context. The following character set identifiers are defined:If the function fails, the return value is DEFAULT_CHARSET.FONTSIGNATUREGetTextCharsetTranslateCharsetInfoUnicode and Character Set FunctionsUnicode and Character Sets</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetTextCharsetInfo(nint hdc, uint dwFlags);

        /// <summary>
        ///The GetTextColor function retrieves the current text color for the specified device context.
        /// </summary>
        /// <param name="hdc">Handle to the device context.If the function succeeds, the return value is the current text color as a COLORREF value.If the function fails, the return value is CLR_INVALID. No extended error information is available.The text color defines the foreground color of characters drawn by using the TextOut or ExtTextOut function.COLORREFExtTextOutFont and Text FunctionsFonts and Text OverviewSetTextColorTextOut</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetTextColor(nint hdc);

        /// <summary>
        ///The GetTextExtentExPoint function retrieves the number of characters in a specified string that will fit within a specified space and fills an array with the text extent for each of those characters. (A text extent is the distance between the beginning of the space and a character that will fit in the space.) This information is useful for word-wrapping calculations.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="lpszString">A pointer to the null-terminated string for which extents are to be retrieved.</param>
        /// <param name="cchString">The number of characters in the string pointed to by the lpszStr parameter. For an ANSI call it specifies the string length in bytes and for a Unicode it specifies the string length in WORDs. Note that for the ANSI function, characters in SBCS code pages take one byte each, while most characters in DBCS code pages take two bytes; for the Unicode function, most currently defined Unicode characters (those in the Basic Multilingual Plane (BMP)) are one WORD while Unicode surrogates are two WORDs.</param>
        /// <param name="nMaxExtent">The maximum allowable width, in logical units, of the formatted string.</param>
        /// <param name="lpnFit"></param>
        /// <param name="lpnDx"></param>
        /// <param name="lpSize"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetTextExtentExPointA(nint hdc, string lpszString, int cchString, int nMaxExtent, out int lpnFit, out int lpnDx, out int lpSize);

        /// <summary>
        ///The GetTextExtentExPointI function retrieves the number of characters in a specified string that will fit within a specified space and fills an array with the text extent for each of those characters. (A text extent is the distance between the beginning of the space and a character that will fit in the space.) This information is useful for word-wrapping calculations.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="lpwszString">A pointer to an array of glyph indices for which extents are to be retrieved.</param>
        /// <param name="cwchString">The number of glyphs in the array pointed to by the pgiIn parameter.</param>
        /// <param name="nMaxExtent">The maximum allowable width, in logical units, of the formatted string.</param>
        /// <param name="lpnFit"></param>
        /// <param name="lpnDx"></param>
        /// <param name="lpSize"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetTextExtentExPointI(nint hdc, short lpwszString, int cwchString, int nMaxExtent, out int lpnFit, out int lpnDx, out int lpSize);

        /// <summary>
        ///The GetTextExtentExPoint function retrieves the number of characters in a specified string that will fit within a specified space and fills an array with the text extent for each of those characters. (A text extent is the distance between the beginning of the space and a character that will fit in the space.) This information is useful for word-wrapping calculations.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="lpszString">A pointer to the null-terminated string for which extents are to be retrieved.</param>
        /// <param name="cchString">The number of characters in the string pointed to by the lpszStr parameter. For an ANSI call it specifies the string length in bytes and for a Unicode it specifies the string length in WORDs. Note that for the ANSI function, characters in SBCS code pages take one byte each, while most characters in DBCS code pages take two bytes; for the Unicode function, most currently defined Unicode characters (those in the Basic Multilingual Plane (BMP)) are one WORD while Unicode surrogates are two WORDs.</param>
        /// <param name="nMaxExtent">The maximum allowable width, in logical units, of the formatted string.</param>
        /// <param name="lpnFit"></param>
        /// <param name="lpnDx"></param>
        /// <param name="lpSize"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetTextExtentExPointW(nint hdc, string lpszString, int cchString, int nMaxExtent, out int lpnFit, out int lpnDx, out int lpSize);

        /// <summary>
        ///The GetTextExtentPoint32 function computes the width and height of the specified string of text.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="lpString">A pointer to a buffer that specifies the text string. The string does not need to be null-terminated, because the c parameter specifies the length of the string.</param>
        /// <param name="c">The length of the string pointed to by lpString.</param>
        /// <param name="psizl"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetTextExtentPoint32A(nint hdc, string lpString, int c, out int psizl);

        /// <summary>
        ///The GetTextExtentPoint32 function computes the width and height of the specified string of text.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="lpString">A pointer to a buffer that specifies the text string. The string does not need to be null-terminated, because the c parameter specifies the length of the string.</param>
        /// <param name="c">The length of the string pointed to by lpString.</param>
        /// <param name="psizl"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetTextExtentPoint32W(nint hdc, string lpString, int c, out int psizl);

        /// <summary>
        ///The GetTextExtentPoint function computes the width and height of the specified string of text.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="lpString">A pointer to the string that specifies the text. The string does not need to be zero-terminated, since cbString specifies the length of the string.</param>
        /// <param name="c">The length of the string pointed to by lpString.</param>
        /// <param name="lpsz"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetTextExtentPointA(nint hdc, string lpString, int c, out int lpsz);

        /// <summary>
        ///The GetTextExtentPointI function computes the width and height of the specified array of glyph indices.
        /// </summary>
        /// <param name="hdc">Handle to the device context.</param>
        /// <param name="pgiIn">Pointer to array of glyph indices.</param>
        /// <param name="cgi">Specifies the number of glyph indices.</param>
        /// <param name="psize"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetTextExtentPointI(nint hdc, short pgiIn, int cgi, out int psize);

        /// <summary>
        ///The GetTextExtentPoint function computes the width and height of the specified string of text.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="lpString">A pointer to the string that specifies the text. The string does not need to be zero-terminated, since cbString specifies the length of the string.</param>
        /// <param name="c">The length of the string pointed to by lpString.</param>
        /// <param name="lpsz"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetTextExtentPointW(nint hdc, string lpString, int c, out int lpsz);

        /// <summary>
        ///The GetTextFace function retrieves the typeface name of the font that is selected into the specified device context.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="c">The length of the buffer pointed to by lpFaceName. For the ANSI function it is a BYTE count and for the Unicode function it is a WORD count. Note that for the ANSI function, characters in SBCS code pages take one byte each, while most characters in DBCS code pages take two bytes; for the Unicode function, most currently defined Unicode characters (those in the Basic Multilingual Plane (BMP)) are one WORD while Unicode surrogates are two WORDs.</param>
        /// <param name="lpName"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetTextFaceA(nint hdc, int c, out string lpName);

        /// <summary>
        ///The GetTextFace function retrieves the typeface name of the font that is selected into the specified device context.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="c">The length of the buffer pointed to by lpFaceName. For the ANSI function it is a BYTE count and for the Unicode function it is a WORD count. Note that for the ANSI function, characters in SBCS code pages take one byte each, while most characters in DBCS code pages take two bytes; for the Unicode function, most currently defined Unicode characters (those in the Basic Multilingual Plane (BMP)) are one WORD while Unicode surrogates are two WORDs.</param>
        /// <param name="lpName"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetTextFaceW(nint hdc, int c, out string lpName);

        /// <summary>
        ///The GetTextMetrics function fills the specified buffer with the metrics for the currently selected font.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="lptm"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetTextMetrics(nint hdc, out int lptm);

        /// <summary>
        ///The GetTextMetrics function fills the specified buffer with the metrics for the currently selected font.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="lptm"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetTextMetricsA(nint hdc, out int lptm);

        /// <summary>
        ///The GetTextMetrics function fills the specified buffer with the metrics for the currently selected font.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="lptm"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetTextMetricsW(nint hdc, out int lptm);

        /// <summary>
        ///The GetViewportExtEx function retrieves the x-extent and y-extent of the current viewport for the specified device context.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="lpsize"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetViewportExtEx(nint hdc, out int lpsize);

        /// <summary>
        ///The GetViewportOrgEx function retrieves the x-coordinates and y-coordinates of the viewport origin for the specified device context.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="lppoint"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetViewportOrgEx(nint hdc, out int lppoint);

        /// <summary>
        ///This function retrieves the x-extent and y-extent of the window for the specified device context.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="lpsize"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetWindowExtEx(nint hdc, out int lpsize);

        /// <summary>
        ///The GetWindowOrgEx function retrieves the x-coordinates and y-coordinates of the window origin for the specified device context.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="lppoint"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetWindowOrgEx(nint hdc, out int lppoint);

        /// <summary>
        ///The GetWinMetaFileBits function converts the enhanced-format records from a metafile into Windows-format records and stores the converted records in the specified buffer.
        /// </summary>
        /// <param name="hemf">A handle to the enhanced metafile.</param>
        /// <param name="cbData16">The size, in bytes, of the buffer into which the converted records are to be copied.</param>
        /// <param name="pData16"></param>
        /// <param name="iMapMode">The mapping mode to use in the converted metafile.</param>
        /// <param name="hdcRef">A handle to the reference device context.If the function succeeds and the buffer pointer is NULL, the return value is the number of bytes required to store the converted records; if the function succeeds and the buffer pointer is a valid pointer, the return value is the size of the metafile data in bytes.If the function fails, the return value is zero.This function converts an enhanced metafile into a Windows-format metafile so that its picture can be displayed in an application that recognizes the older format.The system uses the reference device context to determine the resolution of the converted metafile.The GetWinMetaFileBits function does not invalidate the enhanced metafile handle. An application should call the DeleteEnhMetaFile function to release the handle when it is no longer needed.To create a scalable Windows-format metafile, specify MM_ANISOTROPIC as the fnMapMode parameter.The upper-left corner of the metafile picture is always mapped to the origin of the reference device.DeleteEnhMetaFileMetafile FunctionsMetafiles OverviewSetMapModeSetWinMetaFileBits</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetWinMetaFileBits(nint hemf, uint cbData16, out int pData16, int iMapMode, nint hdcRef);

        /// <summary>
        ///The GetWorldTransform function retrieves the current world-space to page-space transformation.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="lpxf"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetWorldTransform(nint hdc, out int lpxf);

        /// <summary>
        ///The GradientFill function fills rectangle and triangle structures.
        /// </summary>
        /// <param name="hdc">A handle to the destination device context.</param>
        /// <param name="pVertex">A pointer to an array of TRIVERTEX structures that each define a vertex.</param>
        /// <param name="nVertex">The number of vertices in pVertex.</param>
        /// <param name="pMesh">An array of GRADIENT_TRIANGLE structures in triangle mode, or an array of GRADIENT_RECT structures in rectangle mode.</param>
        /// <param name="nMesh">The number of elements (triangles or rectangles) in pMesh.</param>
        /// <param name="ulMode">The gradient fill mode. This parameter can be one of the following values.If the function succeeds, the return value is TRUE.If the function fails, the return value is FALSE.To add smooth shading to a triangle, call the GradientFill function with the three triangle endpoints. GDI will linearly interpolate and fill the triangle. Here is the drawing output of a shaded triangle.In the case of filling a triangle, pMesh points to an array of GRADIENT_TRIANGLE structures. Each GRADIENT_TRIANGLE structure specifies the index of three vertices in the pVertex array. These three vertices form one triangle.To simplify hardware acceleration, this routine is not required to be pixel-perfect in the triangle interior.Note that GradientFill does not use the Alpha member of the TRIVERTEX structure. To use GradientFill with transparency, call GradientFill and then call AlphaBlend with the desired values for the alpha channel of each vertex.For more information, see Smooth Shading, Drawing a Shaded Triangle, and Drawing a Shaded Rectangle.Bitmap FunctionsBitmaps OverviewEMRGRADIENTFILLGRADIENT_RECTGRADIENT_TRIANGLETRIVERTEX</param>

        [DllImport("Msimg32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GradientFill(nint hdc, int pVertex, uint nVertex, nint pMesh, uint nMesh, uint ulMode);

        /// <summary>
        ///The IntersectClipRect function creates a new clipping region from the intersection of the current clipping region and the specified rectangle.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="left">The x-coordinate, in logical units, of the upper-left corner of the rectangle.</param>
        /// <param name="top">The y-coordinate, in logical units, of the upper-left corner of the rectangle.</param>
        /// <param name="right">The x-coordinate, in logical units, of the lower-right corner of the rectangle.</param>
        /// <param name="bottom">The y-coordinate, in logical units, of the lower-right corner of the rectangle.The return value specifies the new clipping region's type and can be one of the following values.The lower and right-most edges of the given rectangle are excluded from the clipping region.If a clipping region does not already exist then the system may apply a default clipping region to the specified HDC. A clipping region is then created from the intersection of that default clipping region and the rectangle specified in the function parameters.Clipping FunctionsClipping OverviewExcludeClipRect</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int IntersectClipRect(nint hdc, int left, int top, int right, int bottom);

        /// <summary>
        ///The InvertRgn function inverts the colors in the specified region.
        /// </summary>
        /// <param name="hdc">Handle to the device context.</param>
        /// <param name="hrgn">Handle to the region for which colors are inverted. The region's coordinates are presumed to be logical coordinates.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.On monochrome screens, the InvertRgn function makes white pixels black and black pixels white. On color screens, this inversion is dependent on the type of technology used to generate the colors for the screen.For an example, see Using Brushes.FillRgnPaintRgnRegion FunctionsRegions Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool InvertRgn(nint hdc, nint hrgn);

        /// <summary>
        ///The LineDDA function determines which pixels should be highlighted for a line defined by the specified starting and ending points.
        /// </summary>
        /// <param name="xStart">Specifies the x-coordinate, in logical units, of the line's starting point.</param>
        /// <param name="yStart">Specifies the y-coordinate, in logical units, of the line's starting point.</param>
        /// <param name="xEnd">Specifies the x-coordinate, in logical units, of the line's ending point.</param>
        /// <param name="yEnd">Specifies the y-coordinate, in logical units, of the line's ending point.</param>
        /// <param name="lpProc">Pointer to an application-defined callback function. For more information, see the LineDDAProc callback function.</param>
        /// <param name="data">Pointer to the application-defined data.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The LineDDA function passes the coordinates for each point along the line, except for the line's ending point, to the application-defined callback function. In addition to passing the coordinates of a point, this function passes any existing application-defined data.The coordinates passed to the callback function match pixels on a video display only if the default transformations and mapping modes are used.Line and Curve FunctionsLineDDAProcLines and Curves Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool LineDDA(int xStart, int yStart, int xEnd, int yEnd, int lpProc, nint data);

        /// <summary>
        ///The LineTo function draws a line from the current position up to, but not including, the specified point.
        /// </summary>
        /// <param name="hdc">Handle to a device context.</param>
        /// <param name="x">Specifies the x-coordinate, in logical units, of the line's ending point.</param>
        /// <param name="y">Specifies the y-coordinate, in logical units, of the line's ending point.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The line is drawn by using the current pen and, if the pen is a geometric pen, the current brush.If LineTo succeeds, the current position is set to the specified ending point.For an example, see Drawing Markers.Line and Curve FunctionsLines and Curves OverviewMoveToExPolylinePolylineTo</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool LineTo(nint hdc, int x, int y);

        /// <summary>
        ///The LPtoDP function converts logical coordinates into device coordinates. The conversion depends on the mapping mode of the device context, the settings of the origins and extents for the window and viewport, and the world transformation.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="c">The number of points in the array.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The LPtoDP function fails if the logical coordinates exceed 32 bits, or if the converted device coordinates exceed 27 bits. In the case of such an overflow, the results for all the points are undefined.LPtoDP calculates complex floating-point arithmetic, and it has a caching system for efficiency. Therefore, the conversion result of an initial call to LPtoDP might not exactly match the conversion result of a later call to LPtoDP. We recommend not to write code that relies on the exact match of the conversion results from multiple calls to LPtoDP even if the parameters that are passed to each call are identical.Coordinate Space and Transformation FunctionsCoordinate Spaces and Transformations OverviewDPtoLPPOINT</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool LPtoDP(nint hdc, int c);

        /// <summary>
        ///The MaskBlt function combines the color data for the source and destination bitmaps using the specified mask and raster operation.
        /// </summary>
        /// <param name="hdcDest">A handle to the destination device context.</param>
        /// <param name="xDest">The x-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
        /// <param name="yDest">The y-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
        /// <param name="width">The width, in logical units, of the destination rectangle and source bitmap.</param>
        /// <param name="height">The height, in logical units, of the destination rectangle and source bitmap.</param>
        /// <param name="hdcSrc">A handle to the device context from which the bitmap is to be copied. It must be zero if the dwRop parameter specifies a raster operation that does not include a source.</param>
        /// <param name="xSrc">The x-coordinate, in logical units, of the upper-left corner of the source bitmap.</param>
        /// <param name="ySrc">The y-coordinate, in logical units, of the upper-left corner of the source bitmap.</param>
        /// <param name="hbmMask">A handle to the monochrome mask bitmap combined with the color bitmap in the source device context.</param>
        /// <param name="xMask">The horizontal pixel offset for the mask bitmap specified by the hbmMask parameter.</param>
        /// <param name="yMask">The vertical pixel offset for the mask bitmap specified by the hbmMask parameter.</param>
        /// <param name="rop">The foreground and background ternary raster operation codes (ROPs) that the function uses to control the combination of source and destination data. The background raster operation code is stored in the high-order byte of the high-order word of this value; the foreground raster operation code is stored in the low-order byte of the high-order word of this value; the low-order word of this value is ignored, and should be zero. The macro MAKEROP4 creates such combinations of foreground and background raster operation codes.For a discussion of foreground and background in the context of this function, see the following Remarks section.For a list of common raster operation codes (ROPs), see the BitBlt function. Note that the CAPTUREBLT ROP generally cannot be used for printing device contexts.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The MaskBlt function uses device-dependent bitmaps.A value of 1 in the mask specified by hbmMask indicates that the foreground raster operation code specified by dwRop should be applied at that location. A value of 0 in the mask indicates that the background raster operation code specified by dwRop should be applied at that location.If the raster operations require a source, the mask rectangle must cover the source rectangle. If it does not, the function will fail. If the raster operations do not require a source, the mask rectangle must cover the destination rectangle. If it does not, the function will fail.If a rotation or shear transformation is in effect for the source device context when this function is called, an error occurs. However, other types of transformation are allowed.If the color formats of the source, pattern, and destination bitmaps differ, this function converts the pattern or source format, or both, to match the destination format.If the mask bitmap is not a monochrome bitmap, an error occurs.When an enhanced metafile is being recorded, an error occurs (and the function returns FALSE) if the source device context identifies an enhanced-metafile device context.Not all devices support the MaskBlt function. An application should call the GetDeviceCaps function with the nIndex parameter as RC_BITBLT to determine whether a device supports this function.If no mask bitmap is supplied, this function behaves exactly like BitBlt, using the foreground raster operation code.ICM: No color management is performed when blits occur.When used in a multiple monitor system, both hdcSrc and hdcDest must refer to the same device or the function will fail. To transfer data between DCs for different devices, convert the memory bitmap (compatible bitmap, or DDB) to a DIB by calling GetDIBits. To display the DIB to the second device, call SetDIBits or StretchDIBits.BitBltBitmap FunctionsBitmaps OverviewGetDIBitsGetDeviceCapsPlgBltSetDIBitsStretchBltStretchDIBits</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool MaskBlt(nint hdcDest, int xDest, int yDest, int width, int height, nint hdcSrc, int xSrc, int ySrc, nint hbmMask, int xMask, int yMask, uint rop);

        /// <summary>
        ///The ModifyWorldTransform function changes the world transformation for a device context using the specified mode.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="lpxf">A pointer to an XFORM structure used to modify the world transformation for the given device context.</param>
        /// <param name="mode">Specifies how the transformation data modifies the current world transformation. This parameter must be one of the following values.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The ModifyWorldTransform function will fail unless graphics mode for the specified device context has been set to GM_ADVANCED by previously calling the SetGraphicsMode function. Likewise, it will not be possible to reset the graphics mode for the device context to the default GM_COMPATIBLE mode, unless world transform has first been reset to the default identity transform by calling SetWorldTransform or ModifyWorldTransform.Coordinate Space and Transformation FunctionsCoordinate Spaces and Transformations OverviewGetWorldTransformSetGraphicsModeSetWorldTransformXFORM</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ModifyWorldTransform(nint hdc, XFORM lpxf, uint mode);

        /// <summary>
        ///The MoveToEx function updates the current position to the specified point and optionally returns the previous position.
        /// </summary>
        /// <param name="hdc">Handle to a device context.</param>
        /// <param name="x">Specifies the x-coordinate, in logical units, of the new position, in logical units.</param>
        /// <param name="y">Specifies the y-coordinate, in logical units, of the new position, in logical units.</param>
        /// <param name="lppt"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool MoveToEx(nint hdc, int x, int y, out int lppt);

        /// <summary>
        ///The OffsetClipRgn function moves the clipping region of a device context by the specified offsets.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="x">The number of logical units to move left or right.</param>
        /// <param name="y">The number of logical units to move up or down.The return value specifies the new region's complexity and can be one of the following values.Clipping FunctionsClipping OverviewSelectClipRgn</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int OffsetClipRgn(nint hdc, int x, int y);

        /// <summary>
        ///The OffsetRgn function moves a region by the specified offsets.
        /// </summary>
        /// <param name="hrgn">Handle to the region to be moved.</param>
        /// <param name="x">Specifies the number of logical units to move left or right.</param>
        /// <param name="y">Specifies the number of logical units to move up or down.The return value specifies the new region's complexity. It can be one of the following values.Region FunctionsRegions Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int OffsetRgn(nint hrgn, int x, int y);

        /// <summary>
        ///The OffsetViewportOrgEx function modifies the viewport origin for a device context using the specified horizontal and vertical offsets.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="x">The horizontal offset, in device units.</param>
        /// <param name="y">The vertical offset, in device units.</param>
        /// <param name="lppt"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool OffsetViewportOrgEx(nint hdc, int x, int y, out int lppt);

        /// <summary>
        ///The OffsetWindowOrgEx function modifies the window origin for a device context using the specified horizontal and vertical offsets.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="x">The horizontal offset, in logical units.</param>
        /// <param name="y">The vertical offset, in logical units.</param>
        /// <param name="lppt"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool OffsetWindowOrgEx(nint hdc, int x, int y, out int lppt);

        /// <summary>
        ///The PaintRgn function paints the specified region by using the brush currently selected into the device context.
        /// </summary>
        /// <param name="hdc">Handle to the device context.</param>
        /// <param name="hrgn">Handle to the region to be filled. The region's coordinates are presumed to be logical coordinates.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.FillRgnRegion FunctionsRegions Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool PaintRgn(nint hdc, nint hrgn);

        /// <summary>
        ///The PatBlt function paints the specified rectangle using the brush that is currently selected into the specified device context. The brush color and the surface color or colors are combined by using the specified raster operation.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="x">The x-coordinate, in logical units, of the upper-left corner of the rectangle to be filled.</param>
        /// <param name="y">The y-coordinate, in logical units, of the upper-left corner of the rectangle to be filled.</param>
        /// <param name="w">The width, in logical units, of the rectangle.</param>
        /// <param name="h">The height, in logical units, of the rectangle.</param>
        /// <param name="rop">The raster operation code. This code can be one of the following values.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The values of the dwRop parameter for this function are a limited subset of the full 256 ternary raster-operation codes; in particular, an operation code that refers to a source rectangle cannot be used.Not all devices support the PatBlt function. For more information, see the description of the RC_BITBLT capability in the GetDeviceCaps function.For an example, see "Example of Menu-Item Bitmaps" in Using Menus.Brush FunctionsBrushes OverviewGetDeviceCaps</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool PatBlt(nint hdc, int x, int y, int w, int h, uint rop);

        /// <summary>
        ///The PathToRegion function creates a region from the path that is selected into the specified device context. The resulting region uses device coordinates.
        /// </summary>
        /// <param name="hdc">Handle to a device context that contains a closed path.If the function succeeds, the return value identifies a valid region.If the function fails, the return value is zero.When you no longer need the HRGN object call the DeleteObject function to delete it.The device context identified by the hdc parameter must contain a closed path.After PathToRegion converts a path into a region, the system discards the closed path from the specified device context.</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint PathToRegion(nint hdc);

        /// <summary>
        ///The Pie function draws a pie-shaped wedge bounded by the intersection of an ellipse and two radials. The pie is outlined by using the current pen and filled by using the current brush.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="left">The x-coordinate, in logical coordinates, of the upper-left corner of the bounding rectangle.</param>
        /// <param name="top">The y-coordinate, in logical coordinates, of the upper-left corner of the bounding rectangle.</param>
        /// <param name="right">The x-coordinate, in logical coordinates, of the lower-right corner of the bounding rectangle.</param>
        /// <param name="bottom">The y-coordinate, in logical coordinates, of the lower-right corner of the bounding rectangle.</param>
        /// <param name="xr1">The x-coordinate, in logical coordinates, of the endpoint of the first radial.</param>
        /// <param name="yr1">The y-coordinate, in logical coordinates, of the endpoint of the first radial.</param>
        /// <param name="xr2">The x-coordinate, in logical coordinates, of the endpoint of the second radial.</param>
        /// <param name="yr2">The y-coordinate, in logical coordinates, of the endpoint of the second radial.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The curve of the pie is defined by an ellipse that fits the specified bounding rectangle. The curve begins at the point where the ellipse intersects the first radial and extends counterclockwise to the point where the ellipse intersects the second radial.The current position is neither used nor updated by the Pie function.AngleArcArcArcToChordFilled Shape FunctionsFilled Shapes Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool Pie(nint hdc, int left, int top, int right, int bottom, int xr1, int yr1, int xr2, int yr2);

        /// <summary>
        ///The PlayEnhMetaFile function displays the picture stored in the specified enhanced-format metafile.
        /// </summary>
        /// <param name="hdc">A handle to the device context for the output device on which the picture will appear.</param>
        /// <param name="hmf">A handle to the enhanced metafile.</param>
        /// <param name="lprect">A pointer to a RECT structure that contains the coordinates of the bounding rectangle used to display the picture. The coordinates are specified in logical units.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.When an application calls the PlayEnhMetaFile function, the system uses the picture frame in the enhanced-metafile header to map the picture onto the rectangle pointed to by the lpRect parameter. (This picture may be sheared or rotated by setting the world transform in the output device before calling PlayEnhMetaFile.) Points along the edges of the rectangle are included in the picture.An enhanced-metafile picture can be clipped by defining the clipping region in the output device before playing the enhanced metafile.If an enhanced metafile contains an optional palette, an application can achieve consistent colors by setting up a color palette on the output device before calling PlayEnhMetaFile. To retrieve the optional palette, use the GetEnhMetaFilePaletteEntries function.An enhanced metafile can be embedded in a newly created enhanced metafile by calling PlayEnhMetaFile and playing the source enhanced metafile into the device context for the new enhanced metafile.The states of the output device context are preserved by this function. Any object created but not deleted in the enhanced metafile is deleted by this function.To stop this function, an application can call the CancelDC function from another thread to terminate the operation. In this case, the function returns FALSE.For an example, see Opening an Enhanced Metafile and Displaying Its Contents.CancelDCGetEnhMetaFileHeaderGetEnhMetaFilePaletteEntriesMetafile FunctionsMetafiles OverviewRECT</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool PlayEnhMetaFile(nint hdc, nint hmf, RECT lprect);

        /// <summary>
        ///The PlayEnhMetaFileRecord function plays an enhanced-metafile record by executing the graphics device interface (GDI) functions identified by the record.
        /// </summary>
        /// <param name="hdc">A handle to the device context passed to the EnumEnhMetaFile function.</param>
        /// <param name="pht">A pointer to a table of handles to GDI objects used when playing the metafile. The first entry in this table contains the enhanced-metafile handle.</param>
        /// <param name="pmr">A pointer to the enhanced-metafile record to be played.</param>
        /// <param name="cht">The number of handles in the handle table.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.This is an enhanced-metafile function.An application typically uses PlayEnhMetaFileRecord in conjunction with the EnumEnhMetaFile function to process and play an enhanced-format metafile one record at a time.The hdc, lpHandletable, and nHandles parameters must be exactly those passed to the EnhMetaFileProc callback procedure by the EnumEnhMetaFile function.If PlayEnhMetaFileRecord does not recognize a record, it ignores the record and returns TRUE.EnumEnhMetaFileMetafile FunctionsMetafiles OverviewPlayEnhMetaFile</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool PlayEnhMetaFileRecord(nint hdc, nint pht, ENHMETARECORD pmr, uint cht);

        /// <summary>
        ///The PlayMetaFile function displays the picture stored in the given Windows-format metafile on the specified device.
        /// </summary>
        /// <param name="hdc">Handle to a device context.</param>
        /// <param name="hmf">Handle to a Windows-format metafile.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.To convert a Windows-format metafile into an enhanced format metafile, use the SetWinMetaFileBits function.A Windows-format metafile can be played multiple times.A Windows-format metafile can be embedded in a second Windows-format metafile by calling the PlayMetaFile function and playing the source metafile into the device context for the target metafile.Any object created but not deleted in the Windows-format metafile is deleted by this function.To stop this function, an application can call the CancelDC function from another thread to terminate the operation. In this case, the function returns FALSE.CancelDCMetafile FunctionsMetafiles OverviewSetWinMetaFileBits</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool PlayMetaFile(nint hdc, nint hmf);

        /// <summary>
        ///The PlayMetaFileRecord function plays a Windows-format metafile record by executing the graphics device interface (GDI) function contained within that record.
        /// </summary>
        /// <param name="hdc">A handle to a device context.</param>
        /// <param name="lpHandleTable">A pointer to a HANDLETABLE structure representing the table of handles to GDI objects used when playing the metafile.</param>
        /// <param name="lpMR">A pointer to the Windows-format metafile record.</param>
        /// <param name="noObjs">The number of handles in the handle table.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.To convert a Windows-format metafile into an enhanced-format metafile, use the SetWinMetaFileBits function.An application typically uses PlayMetaFileRecord in conjunction with the EnumMetaFile function to process and play a Windows-format metafile one record at a time.The lpHandletable and nHandles parameters must be identical to those passed to the EnumMetaFileProc callback procedure by EnumMetaFile.If the PlayMetaFileRecord function does not recognize a record, it ignores the record and returns TRUE.EnumMetaFileHANDLETABLEMETARECORDMetafile FunctionsMetafiles OverviewPlayMetaFileSetWinMetaFileBits</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool PlayMetaFileRecord(nint hdc, nint lpHandleTable, int lpMR, uint noObjs);

        /// <summary>
        ///The PlgBlt function performs a bit-block transfer of the bits of color data from the specified rectangle in the source device context to the specified parallelogram in the destination device context. If the given bitmask handle identifies a valid monochrome bitmap, the function uses this bitmap to mask the bits of color data from the source rectangle.
        /// </summary>
        /// <param name="hdcDest">A handle to the destination device context.</param>
        /// <param name="lpPoint">A pointer to an array of three points in logical space that identify three corners of the destination parallelogram. The upper-left corner of the source rectangle is mapped to the first point in this array, the upper-right corner to the second point in this array, and the lower-left corner to the third point. The lower-right corner of the source rectangle is mapped to the implicit fourth point in the parallelogram.</param>
        /// <param name="hdcSrc">A handle to the source device context.</param>
        /// <param name="xSrc">The x-coordinate, in logical units, of the upper-left corner of the source rectangle.</param>
        /// <param name="ySrc">The y-coordinate, in logical units, of the upper-left corner of the source rectangle.</param>
        /// <param name="width">The width, in logical units, of the source rectangle.</param>
        /// <param name="height">The height, in logical units, of the source rectangle.</param>
        /// <param name="hbmMask">A handle to an optional monochrome bitmap that is used to mask the colors of the source rectangle.</param>
        /// <param name="xMask">The x-coordinate, in logical units, of the upper-left corner of the monochrome bitmap.</param>
        /// <param name="yMask">The y-coordinate, in logical units, of the upper-left corner of the monochrome bitmap.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The PlgBlt function works with device-dependent bitmaps.The fourth vertex of the parallelogram (D) is defined by treating the first three points (A, B, and C ) as vectors and computing D = B +CA.If the bitmask exists, a value of one in the mask indicates that the source pixel color should be copied to the destination. A value of zero in the mask indicates that the destination pixel color is not to be changed. If the mask rectangle is smaller than the source and destination rectangles, the function replicates the mask pattern.Scaling, translation, and reflection transformations are allowed in the source device context; however, rotation and shear transformations are not. If the mask bitmap is not a monochrome bitmap, an error occurs. The stretching mode for the destination device context is used to determine how to stretch or compress the pixels, if that is necessary.When an enhanced metafile is being recorded, an error occurs if the source device context identifies an enhanced-metafile device context.The destination coordinates are transformed according to the destination device context; the source coordinates are transformed according to the source device context. If the source transformation has a rotation or shear, an error is returned.If the destination and source rectangles do not have the same color format, PlgBlt converts the source rectangle to match the destination rectangle.Not all devices support the PlgBlt function. For more information, see the description of the RC_BITBLT raster capability in the GetDeviceCaps function.If the source and destination device contexts represent incompatible devices, PlgBlt returns an error.When used in a multiple monitor system, both hdcSrc and hdcDest must refer to the same device or the function will fail. To transfer data between DCs for different devices, convert the memory bitmap to a DIB by calling GetDIBits. To display the DIB to the second device, call SetDIBits or StretchDIBits.BitBltBitmap FunctionsBitmaps OverviewGetDIBitsGetDeviceCapsMaskBltSetDIBitsSetStretchBltModeStretchBltStretchDIBits</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool PlgBlt(nint hdcDest, POINT lpPoint, nint hdcSrc, int xSrc, int ySrc, int width, int height, nint hbmMask, int xMask, int yMask);

        /// <summary>
        ///The PolyBezier function draws one or more Bézier curves.
        /// </summary>
        /// <param name="hdc">A handle to a device context.</param>
        /// <param name="apt">A pointer to an array of POINT structures that contain the endpoints and control points of the curve(s), in logical units.</param>
        /// <param name="cpt">The number of points in the lppt array. This value must be one more than three times the number of curves to be drawn, because each Bézier curve requires two control points and an endpoint, and the initial curve requires an additional starting point.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The PolyBezier function draws cubic Bézier curves by using the endpoints and control points specified by the lppt parameter. The first curve is drawn from the first point to the fourth point by using the second and third points as control points. Each subsequent curve in the sequence needs exactly three more points: the ending point of the previous curve is used as the starting point, the next two points in the sequence are control points, and the third is the ending point.The current position is neither used nor updated by the PolyBezier function. The figure is not filled.This function draws lines by using the current pen.For an example, see Redrawing in the Update Region.Line and Curve FunctionsLines and Curves OverviewMoveToExPOINTPolyBezierTo</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool PolyBezier(nint hdc, POINT apt, uint cpt);

        /// <summary>
        ///The PolyBezierTo function draws one or more Bézier curves.
        /// </summary>
        /// <param name="hdc">A handle to a device context.</param>
        /// <param name="apt">A pointer to an array of POINT structures that contains the endpoints and control points, in logical units.</param>
        /// <param name="cpt">The number of points in the lppt array. This value must be three times the number of curves to be drawn because each Bézier curve requires two control points and an ending point.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.This function draws cubic Bézier curves by using the control points specified by the lppt parameter. The first curve is drawn from the current position to the third point by using the first two points as control points. For each subsequent curve, the function needs exactly three more points, and uses the ending point of the previous curve as the starting point for the next.PolyBezierTo moves the current position to the ending point of the last Bézier curve. The figure is not filled.This function draws lines by using the current pen.Line and Curve FunctionsLines and Curves OverviewMoveToExPOINTPolyBezier</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool PolyBezierTo(nint hdc, POINT apt, uint cpt);

        /// <summary>
        ///The PolyDraw function draws a set of line segments and Bézier curves.
        /// </summary>
        /// <param name="hdc">A handle to a device context.</param>
        /// <param name="apt">A pointer to an array of POINT structures that contains the endpoints for each line segment and the endpoints and control points for each Bézier curve, in logical units.</param>
        /// <param name="aj">A pointer to an array that specifies how each point in the lppt array is used. This parameter can be one of the following values.A PT_LINETO or PT_BEZIERTO type can be combined with the following value by using the bitwise operator OR to indicate that the corresponding point is the last point in a figure and the figure is closed.</param>
        /// <param name="cpt">The total number of points in the lppt array, the same as the number of bytes in the lpbTypes array.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The PolyDraw function can be used in place of consecutive calls to MoveToEx, LineTo, and PolyBezierTo functions to draw disjoint figures. The lines and curves are drawn using the current pen and figures are not filled. If there is an active path started by calling BeginPath, PolyDraw adds to the path.The points contained in the lppt array and in the lpbTypes array indicate whether each point is part of a MoveTo, LineTo, or PolyBezierTo operation. It is also possible to close figures.This function updates the current position.BeginPathEndPathLine and Curve FunctionsLineToLines and Curves OverviewMoveToExPOINTPolyBezierToPolyLine</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool PolyDraw(nint hdc, POINT apt, byte aj, int cpt);

        /// <summary>
        ///The Polygon function draws a polygon consisting of two or more vertices connected by straight lines. The polygon is outlined by using the current pen and filled by using the current brush and polygon fill mode.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="apt">A pointer to an array of POINT structures that specify the vertices of the polygon, in logical coordinates.</param>
        /// <param name="cpt">The number of vertices in the array. This value must be greater than or equal to 2.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The polygon is closed automatically by drawing a line from the last vertex to the first.The current position is neither used nor updated by the Polygon function.Any extra points are ignored. To draw a line with more points, divide your data into groups, each of which have less than the maximum number of points, and call the function for each group of points. Remember to connect the line segments.Filled Shape FunctionsFilled Shapes OverviewGetPolyFillModePOINTPolyPolygonPolylinePolylineToSetPolyFillMode</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool Polygon(nint hdc, POINT apt, int cpt);

        /// <summary>
        ///The Polyline function draws a series of line segments by connecting the points in the specified array.
        /// </summary>
        /// <param name="hdc">A handle to a device context.</param>
        /// <param name="apt">A pointer to an array of POINT structures, in logical units.</param>
        /// <param name="cpt">The number of points in the array. This number must be greater than or equal to two.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The lines are drawn from the first point through subsequent points by using the current pen. Unlike the LineTo or PolylineTo functions, the Polyline function neither uses nor updates the current position.Line and Curve FunctionsLineToLines and Curves OverviewMoveToExPOINTPolyPolylinePolylineTo</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool Polyline(nint hdc, POINT apt, int cpt);

        /// <summary>
        ///The PolylineTo function draws one or more straight lines.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="apt">A pointer to an array of POINT structures that contains the vertices of the line, in logical units.</param>
        /// <param name="cpt">The number of points in the array.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.Unlike the Polyline function, the PolylineTo function uses and updates the current position.A line is drawn from the current position to the first point specified by the lppt parameter by using the current pen. For each additional line, the function draws from the ending point of the previous line to the next point specified by lppt.PolylineTo moves the current position to the ending point of the last line.If the line segments drawn by this function form a closed figure, the figure is not filled.Line and Curve FunctionsLineToLines and Curves OverviewMoveToExPOINTPolyPolylinePolyline</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool PolylineTo(nint hdc, POINT apt, uint cpt);

        /// <summary>
        ///The PolyPolygon function draws a series of closed polygons. Each polygon is outlined by using the current pen and filled by using the current brush and polygon fill mode. The polygons drawn by this function can overlap.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="apt">A pointer to an array of POINT structures that define the vertices of the polygons, in logical coordinates. The polygons are specified consecutively. Each polygon is closed automatically by drawing a line from the last vertex to the first. Each vertex should be specified once.</param>
        /// <param name="asz">A pointer to an array of integers, each of which specifies the number of points in the corresponding polygon. Each integer must be greater than or equal to 2.</param>
        /// <param name="csz">The total number of polygons.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The current position is neither used nor updated by this function.Any extra points are ignored. To draw the polygons with more points, divide your data into groups, each of which have less than the maximum number of points, and call the function for each group of points. Note, it is best to have a polygon in only one of the groups.Filled Shape FunctionsFilled Shapes OverviewGetPolyFillModePOINTPolygonPolylinePolylineToSetPolyFillMode</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool PolyPolygon(nint hdc, POINT apt, int asz, int csz);

        /// <summary>
        ///The PolyPolyline function draws multiple series of connected line segments.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="apt">A pointer to an array of POINT structures that contains the vertices of the polylines, in logical units. The polylines are specified consecutively.</param>
        /// <param name="asz">A pointer to an array of variables specifying the number of points in the lppt array for the corresponding polyline. Each entry must be greater than or equal to two.</param>
        /// <param name="csz">The total number of entries in the lpdwPolyPoints array.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The line segments are drawn by using the current pen. The figures formed by the segments are not filled.The current position is neither used nor updated by this function.Line and Curve FunctionsLines and Curves OverviewPOINTPolylinePolylineTo</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool PolyPolyline(nint hdc, POINT apt, uint asz, uint csz);

        /// <summary>
        ///The PolyTextOut function draws several strings using the font and text colors currently selected in the specified device context.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="ppt">A pointer to an array of POLYTEXT structures describing the strings to be drawn. The array contains one structure for each string to be drawn.</param>
        /// <param name="nstrings">The number of POLYTEXT structures in the pptxt array.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.Each POLYTEXT structure contains the coordinates of a reference point that Windows uses to align the corresponding string of text. An application can specify how the reference point is used by calling the SetTextAlign function. An application can determine the current text-alignment setting for the specified device context by calling the GetTextAlign function.To draw a single string of text, the application should call the ExtTextOut function.PolyTextOut will not handle international scripting support automatically. To get international scripting support, use ExtTextOut instead. ExtTextOut will use Uniscribe when necessary resulting in font fallback. Additionally, ExtTextOut will perform internal batching of calls before transitioning to kernel mode, mitigating some of the performance concerns when weighing usage of PolyTextOut versus ExtTextOut.ExtTextOutFont and Text FunctionsFonts and Text OverviewGetTextAlignPOLYTEXTSetTextAlign</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool PolyTextOutA(nint hdc, POLYTEXTA ppt, int nstrings);

        /// <summary>
        ///The PolyTextOut function draws several strings using the font and text colors currently selected in the specified device context.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="ppt">A pointer to an array of POLYTEXT structures describing the strings to be drawn. The array contains one structure for each string to be drawn.</param>
        /// <param name="nstrings">The number of POLYTEXT structures in the pptxt array.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.Each POLYTEXT structure contains the coordinates of a reference point that Windows uses to align the corresponding string of text. An application can specify how the reference point is used by calling the SetTextAlign function. An application can determine the current text-alignment setting for the specified device context by calling the GetTextAlign function.To draw a single string of text, the application should call the ExtTextOut function.PolyTextOut will not handle international scripting support automatically. To get international scripting support, use ExtTextOut instead. ExtTextOut will use Uniscribe when necessary resulting in font fallback. Additionally, ExtTextOut will perform internal batching of calls before transitioning to kernel mode, mitigating some of the performance concerns when weighing usage of PolyTextOut versus ExtTextOut.ExtTextOutFont and Text FunctionsFonts and Text OverviewGetTextAlignPOLYTEXTSetTextAlign</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool PolyTextOutW(nint hdc, POLYTEXTW ppt, int nstrings);

        /// <summary>
        ///The PtInRegion function determines whether the specified point is inside the specified region.
        /// </summary>
        /// <param name="hrgn">Handle to the region to be examined.</param>
        /// <param name="x">Specifies the x-coordinate of the point in logical units.</param>
        /// <param name="y">Specifies the y-coordinate of the point in logical units.If the specified point is in the region, the return value is nonzero.If the specified point is not in the region, the return value is zero.RectInRegionRegion FunctionsRegions Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool PtInRegion(nint hrgn, int x, int y);

        /// <summary>
        ///The PtVisible function determines whether the specified point is within the clipping region of a device context.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="x">The x-coordinate, in logical units, of the point.</param>
        /// <param name="y">The y-coordinate, in logical units, of the point.If the specified point is within the clipping region of the device context, the return value is TRUE(1).If the specified point is not within the clipping region of the device context, the return value is FALSE(0).If the HDC is not valid, the return value is (BOOL)-1.Clipping FunctionsClipping OverviewRectVisible</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool PtVisible(nint hdc, int x, int y);

        /// <summary>
        ///The RealizePalette function maps palette entries from the current logical palette to the system palette.
        /// </summary>
        /// <param name="hdc">A handle to the device context into which a logical palette has been selected.If the function succeeds, the return value is the number of entries in the logical palette mapped to the system palette.If the function fails, the return value is GDI_ERROR.An application can determine whether a device supports palette operations by calling the GetDeviceCaps function and specifying the RASTERCAPS constant.The RealizePalette function modifies the palette for the device associated with the specified device context. If the device context is a memory DC, the color table for the bitmap selected into the DC is modified. If the device context is a display DC, the physical palette for that device is modified.A logical palette is a buffer between color-intensive applications and the system, allowing these applications to use as many colors as needed without interfering with colors displayed by other windows.When an application's window has the focus and it calls the RealizePalette function, the system attempts to realize as many of the requested colors as possible. The same is also true for applications with inactive windows.Color FunctionsColors OverviewCreatePaletteGetDeviceCapsSelectPalette</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint RealizePalette(nint hdc);

        /// <summary>
        ///The Rectangle function draws a rectangle. The rectangle is outlined by using the current pen and filled by using the current brush.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="left">The x-coordinate, in logical coordinates, of the upper-left corner of the rectangle.</param>
        /// <param name="top">The y-coordinate, in logical coordinates, of the upper-left corner of the rectangle.</param>
        /// <param name="right">The x-coordinate, in logical coordinates, of the lower-right corner of the rectangle.</param>
        /// <param name="bottom">The y-coordinate, in logical coordinates, of the lower-right corner of the rectangle.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The current position is neither used nor updated by Rectangle.The rectangle that is drawn excludes the bottom and right edges.If a PS_NULL pen is used, the dimensions of the rectangle are 1 pixel less in height and 1 pixel less in width.For an example, see Using Filled Shapes.Filled Shape FunctionsFilled Shapes OverviewRoundRect</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool Rectangle(nint hdc, int left, int top, int right, int bottom);

        /// <summary>
        ///The RectInRegion function determines whether any part of the specified rectangle is within the boundaries of a region.
        /// </summary>
        /// <param name="hrgn">Handle to the region.</param>
        /// <param name="lprect">Pointer to a RECT structure containing the coordinates of the rectangle in logical units. The lower and right edges of the rectangle are not included.If any part of the specified rectangle lies within the boundaries of the region, the return value is nonzero.If no part of the specified rectangle lies within the boundaries of the region, the return value is zero.PtInRegionRECTRegion FunctionsRegions Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool RectInRegion(nint hrgn, RECT lprect);

        /// <summary>
        ///The RectVisible function determines whether any part of the specified rectangle lies within the clipping region of a device context.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="lprect">A pointer to a RECT structure that contains the logical coordinates of the specified rectangle.If the current transform does not have a rotation and the rectangle lies within the clipping region, the return value is TRUE (1).If the current transform does not have a rotation and the rectangle does not lie within the clipping region, the return value is FALSE (0).If the current transform has a rotation and the rectangle lies within the clipping region, the return value is 2.If the current transform has a rotation and the rectangle does not lie within the clipping region, the return value is 1.All other return values are considered error codes. If the any parameter is not valid, the return value is undefined.Clipping FunctionsClipping OverviewCreateRectRgnPtVisibleRECTSelectClipRgn</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool RectVisible(nint hdc, RECT lprect);

        /// <summary>
        ///The RemoveFontMemResourceEx function removes the fonts added from a memory image file.
        /// </summary>
        /// <param name="h">A handle to the font-resource. This handle is returned by the AddFontMemResourceEx function.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. No extended error information is available.This function removes a font that was added by the AddFontMemResourceEx function. To remove the font, specify the same path and flags as were used in AddFontMemResourceEx. This function will only remove the font that is specified by fh.AddFontMemResourceExFont and Text FunctionsFonts and Text OverviewSendMessage</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool RemoveFontMemResourceEx(nint h);

        /// <summary>
        ///The RemoveFontResource function removes the fonts in the specified file from the system font table.
        /// </summary>
        /// <param name="lpFileName">A pointer to a null-terminated string that names a font resource file.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.We recommend that if an app adds or removes fonts from the system font table that it notify other windows of the change by sending a WM_FONTCHANGE message to all top-level windows in the system. The app sends this message by calling the SendMessage function with the hwnd parameter set to HWND_BROADCAST.If there are outstanding references to a font, the associated resource remains loaded until no device context is using it. Furthermore, if the font is listed in the font registry (HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts) and is installed to any location other than the %windir%\fonts\ folder, it may be loaded into other active sessions (including session 0).When you try to replace an existing font file that contains a font with outstanding references to it, you might get an error that indicates that the original font can't be deleted because it’s in use even after you call RemoveFontResource. If your app requires that the font file be replaced, to reduce the resource count of the original font to zero, call RemoveFontResource in a loop as shown in this example code. If you continue to get errors, this is an indication that the font file remains loaded in other sessions. Make sure the font isn't listed in the font registry and restart the system to ensure the font is unloaded from all sessions.AddFontResourceFont and Text FunctionsFonts and Text OverviewRemoveFontResourceExSendMessage</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool RemoveFontResourceA(string lpFileName);

        /// <summary>
        ///The RemoveFontResourceEx function removes the fonts in the specified file from the system font table.
        /// </summary>
        /// <param name="name">A pointer to a null-terminated string that names a font resource file.</param>
        /// <param name="fl">The characteristics of the font to be removed from the system. In order for the font to be removed, the flags used must be the same as when the font was added with the AddFontResourceEx function. See the AddFontResourceEx function for more information.</param>
        /// <param name="pdv">Reserved. Must be zero.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. No extended error information is available.This function will only remove the font if the flags specified are the same as when then font was added with the AddFontResourceEx function.When you try to replace an existing font file that contains a font with outstanding references to it, you might get an error that indicates that the original font can't be deleted because it’s in use even after you call RemoveFontResourceEx. If your app requires that the font file be replaced, to reduce the resource count of the original font to zero, call RemoveFontResourceEx in a loop as shown in this example code. If you continue to get errors, this is an indication that the font file remains loaded in other sessions. Make sure the font isn't listed in the font registry and restart the system to ensure the font is unloaded from all sessions.AddFontResourceExFont and Text FunctionsFonts and Text OverviewSendMessage</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool RemoveFontResourceExA(string name, uint fl, nint pdv);

        /// <summary>
        ///The RemoveFontResourceEx function removes the fonts in the specified file from the system font table.
        /// </summary>
        /// <param name="name">A pointer to a null-terminated string that names a font resource file.</param>
        /// <param name="fl">The characteristics of the font to be removed from the system. In order for the font to be removed, the flags used must be the same as when the font was added with the AddFontResourceEx function. See the AddFontResourceEx function for more information.</param>
        /// <param name="pdv">Reserved. Must be zero.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. No extended error information is available.This function will only remove the font if the flags specified are the same as when then font was added with the AddFontResourceEx function.When you try to replace an existing font file that contains a font with outstanding references to it, you might get an error that indicates that the original font can't be deleted because it’s in use even after you call RemoveFontResourceEx. If your app requires that the font file be replaced, to reduce the resource count of the original font to zero, call RemoveFontResourceEx in a loop as shown in this example code. If you continue to get errors, this is an indication that the font file remains loaded in other sessions. Make sure the font isn't listed in the font registry and restart the system to ensure the font is unloaded from all sessions.AddFontResourceExFont and Text FunctionsFonts and Text OverviewSendMessage</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool RemoveFontResourceExW(string name, uint fl, nint pdv);

        /// <summary>
        ///The RemoveFontResource function removes the fonts in the specified file from the system font table.
        /// </summary>
        /// <param name="lpFileName">A pointer to a null-terminated string that names a font resource file.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.We recommend that if an app adds or removes fonts from the system font table that it notify other windows of the change by sending a WM_FONTCHANGE message to all top-level windows in the system. The app sends this message by calling the SendMessage function with the hwnd parameter set to HWND_BROADCAST.If there are outstanding references to a font, the associated resource remains loaded until no device context is using it. Furthermore, if the font is listed in the font registry (HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts) and is installed to any location other than the %windir%\fonts\ folder, it may be loaded into other active sessions (including session 0).When you try to replace an existing font file that contains a font with outstanding references to it, you might get an error that indicates that the original font can't be deleted because it’s in use even after you call RemoveFontResource. If your app requires that the font file be replaced, to reduce the resource count of the original font to zero, call RemoveFontResource in a loop as shown in this example code. If you continue to get errors, this is an indication that the font file remains loaded in other sessions. Make sure the font isn't listed in the font registry and restart the system to ensure the font is unloaded from all sessions.AddFontResourceFont and Text FunctionsFonts and Text OverviewRemoveFontResourceExSendMessage</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool RemoveFontResourceW(string lpFileName);

        /// <summary>
        ///The ResetDC function updates the specified printer or plotter device context (DC) using the specified information.
        /// </summary>
        /// <param name="hdc">A handle to the DC to update.</param>
        /// <param name="lpdm">A pointer to a DEVMODE structure containing information about the new DC.If the function succeeds, the return value is a handle to the original DC.If the function fails, the return value is NULL.An application will typically use the ResetDC function when a window receives a WM_DEVMODECHANGE message. ResetDC can also be used to change the paper orientation or paper bins while printing a document.The ResetDC function cannot be used to change the driver name, device name, or the output port. When the user changes the port connection or device name, the application must delete the original DC and create a new DC with the new information.An application can pass an information DC to the ResetDC function. In that situation, ResetDC will always return a printer DC.ICM: The color profile of the DC specified by the hdc parameter will be reset based on the information contained in the lpInitData member of the DEVMODE structure.DEVMODEDevice Context FunctionsDevice Contexts OverviewDeviceCapabilitiesEscape</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint ResetDCA(nint hdc, int lpdm);

        /// <summary>
        ///The ResetDC function updates the specified printer or plotter device context (DC) using the specified information.
        /// </summary>
        /// <param name="hdc">A handle to the DC to update.</param>
        /// <param name="lpdm">A pointer to a DEVMODE structure containing information about the new DC.If the function succeeds, the return value is a handle to the original DC.If the function fails, the return value is NULL.An application will typically use the ResetDC function when a window receives a WM_DEVMODECHANGE message. ResetDC can also be used to change the paper orientation or paper bins while printing a document.The ResetDC function cannot be used to change the driver name, device name, or the output port. When the user changes the port connection or device name, the application must delete the original DC and create a new DC with the new information.An application can pass an information DC to the ResetDC function. In that situation, ResetDC will always return a printer DC.ICM: The color profile of the DC specified by the hdc parameter will be reset based on the information contained in the lpInitData member of the DEVMODE structure.DEVMODEDevice Context FunctionsDevice Contexts OverviewDeviceCapabilitiesEscape</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint ResetDCW(nint hdc, int lpdm);

        /// <summary>
        ///The ResizePalette function increases or decreases the size of a logical palette based on the specified value.
        /// </summary>
        /// <param name="hpal">A handle to the palette to be changed.</param>
        /// <param name="n">The number of entries in the palette after it has been resized.The number of entries is limited to 1024.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.An application can determine whether a device supports palette operations by calling the GetDeviceCaps function and specifying the RASTERCAPS constant.If an application calls ResizePalette to reduce the size of the palette, the entries remaining in the resized palette are unchanged. If the application calls ResizePalette to enlarge the palette, the additional palette entries are set to black (the red, green, and blue values are all 0) and their flags are set to zero.Color FunctionsColors OverviewGetDeviceCaps</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ResizePalette(nint hpal, uint n);

        /// <summary>
        ///The RestoreDC function restores a device context (DC) to the specified state. The DC is restored by popping state information off a stack created by earlier calls to the SaveDC function.
        /// </summary>
        /// <param name="hdc">A handle to the DC.</param>
        /// <param name="nSavedDC">The saved state to be restored. If this parameter is positive, nSavedDC represents a specific instance of the state to be restored. If this parameter is negative, nSavedDC represents an instance relative to the current state. For example, -1 restores the most recently saved state.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.Each DC maintains a stack of saved states. The SaveDC function pushes the current state of the DC onto its stack of saved states. That state can be restored only to the same DC from which it was created. After a state is restored, the saved state is destroyed and cannot be reused. Furthermore, any states saved after the restored state was created are also destroyed and cannot be used. In other words, the RestoreDC function pops the restored state (and any subsequent states) from the state information stack.Device Context FunctionsDevice Contexts OverviewSaveDC</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool RestoreDC(nint hdc, int nSavedDC);

        /// <summary>
        ///The RoundRect function draws a rectangle with rounded corners. The rectangle is outlined by using the current pen and filled by using the current brush.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="left">The x-coordinate, in logical coordinates, of the upper-left corner of the rectangle.</param>
        /// <param name="top">The y-coordinate, in logical coordinates, of the upper-left corner of the rectangle.</param>
        /// <param name="right">The x-coordinate, in logical coordinates, of the lower-right corner of the rectangle.</param>
        /// <param name="bottom">The y-coordinate, in logical coordinates, of the lower-right corner of the rectangle.</param>
        /// <param name="width">The width, in logical coordinates, of the ellipse used to draw the rounded corners.</param>
        /// <param name="height">The height, in logical coordinates, of the ellipse used to draw the rounded corners.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The current position is neither used nor updated by this function.For an example, see Using Filled Shapes.Filled Shape FunctionsFilled Shapes OverviewRectangle</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool RoundRect(nint hdc, int left, int top, int right, int bottom, int width, int height);

        /// <summary>
        ///The SaveDC function saves the current state of the specified device context (DC) by copying data describing selected objects and graphic modes (such as the bitmap, brush, palette, font, pen, region, drawing mode, and mapping mode) to a context stack.
        /// </summary>
        /// <param name="hdc">A handle to the DC whose state is to be saved.If the function succeeds, the return value identifies the saved state.If the function fails, the return value is zero.The SaveDC function can be used any number of times to save any number of instances of the DC state.A saved state can be restored by using the RestoreDC function.Device Context FunctionsDevice Contexts OverviewRestoreDC</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int SaveDC(nint hdc);

        /// <summary>
        ///The ScaleViewportExtEx function modifies the viewport for a device context using the ratios formed by the specified multiplicands and divisors.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="xn">The amount by which to multiply the current horizontal extent.</param>
        /// <param name="dx">The amount by which to divide the current horizontal extent.</param>
        /// <param name="yn">The amount by which to multiply the current vertical extent.</param>
        /// <param name="yd">The amount by which to divide the current vertical extent.</param>
        /// <param name="lpsz"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ScaleViewportExtEx(nint hdc, int xn, int dx, int yn, int yd, out int lpsz);

        /// <summary>
        ///The ScaleWindowExtEx function modifies the window for a device context using the ratios formed by the specified multiplicands and divisors.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="xn">The amount by which to multiply the current horizontal extent.</param>
        /// <param name="xd">The amount by which to divide the current horizontal extent.</param>
        /// <param name="yn">The amount by which to multiply the current vertical extent.</param>
        /// <param name="yd">The amount by which to divide the current vertical extent.</param>
        /// <param name="lpsz"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ScaleWindowExtEx(nint hdc, int xn, int xd, int yn, int yd, out int lpsz);

        /// <summary>
        ///The SelectClipPath function selects the current path as a clipping region for a device context, combining the new region with any existing clipping region using the specified mode.
        /// </summary>
        /// <param name="hdc">A handle to the device context of the path.</param>
        /// <param name="mode">The way to use the path. This parameter can be one of the following values.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The device context identified by the hdc parameter must contain a closed path.For an example, see Using Clipping.BeginPathClipping FunctionsClipping OverviewEndPath</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SelectClipPath(nint hdc, int mode);

        /// <summary>
        ///The SelectClipRgn function selects a region as the current clipping region for the specified device context.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="hrgn">A handle to the region to be selected.The return value specifies the region's complexity and can be one of the following values.Only a copy of the selected region is used. The region itself can be selected for any number of other device contexts or it can be deleted.The SelectClipRgn function assumes that the coordinates for a region are specified in device units.To remove a device-context's clipping region, specify a NULL region handle.For an example, see Clipping Output.Clipping FunctionsClipping OverviewExtSelectClipRgn</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int SelectClipRgn(nint hdc, nint hrgn);

        /// <summary>
        ///The SelectObject function selects an object into the specified device context (DC). The new object replaces the previous object of the same type.
        /// </summary>
        /// <param name="hdc">A handle to the DC.</param>
        /// <param name="h">A handle to the object to be selected. The specified object must have been created by using one of the following functions.If the selected object is not a region and the function succeeds, the return value is a handle to the object being replaced. If the selected object is a region and the function succeeds, the return value is one of the following values.If an error occurs and the selected object is not a region, the return value is NULL. Otherwise, it is HGDI_ERROR.This function returns the previously selected object of the specified type. An application should always replace a new object with the original, default object after it has finished drawing with the new object.An application cannot select a single bitmap into more than one DC at a time.ICM: If the object being selected is a brush or a pen, color management is performed.For an example, see Setting the Pen or Brush Color.CombineRgnCreateBitmapCreateBitmapIndirectCreateBrushIndirectCreateCompatibleBitmapCreateDIBPatternBrushCreateDIBitmapCreateEllipticRgnCreateEllipticRgnIndirectCreateFontCreateFontIndirectCreateHatchBrushCreatePatternBrushCreatePenCreatePenIndirectCreatePolygonRgnCreateRectRgnCreateRectRgnIndirectCreateSolidBrushDevice Context FunctionsDevice Contexts OverviewSelectClipRgnSelectPalette</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint SelectObject(nint hdc, nint h);

        /// <summary>
        ///The SelectPalette function selects the specified logical palette into a device context.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="hPal">A handle to the logical palette to be selected.</param>
        /// <param name="bForceBkgd">Specifies whether the logical palette is forced to be a background palette. If this value is TRUE, the RealizePalette function causes the logical palette to be mapped to the colors already in the physical palette in the best possible way. This is always done, even if the window for which the palette is realized belongs to a thread without active focus.If this value is FALSE, RealizePalette causes the logical palette to be copied into the device palette when the application is in the foreground. (If the hdc parameter is a memory device context, this parameter is ignored.)If the function succeeds, the return value is a handle to the device context's previous logical palette.If the function fails, the return value is NULL.An application can determine whether a device supports palette operations by calling the GetDeviceCaps function and specifying the RASTERCAPS constant.An application can select a logical palette into more than one device context only if device contexts are compatible. Otherwise SelectPalette fails. To create a device context that is compatible with another device context, call CreateCompatibleDC with the first device context as the parameter. If a logical palette is selected into more than one device context, changes to the logical palette will affect all device contexts for which it is selected.An application might call the SelectPalette function with the bForceBackground parameter set to TRUE if the child windows of a top-level window each realize their own palettes. However, only the child window that needs to realize its palette must set bForceBackground to TRUE; other child windows must set this value to FALSE.Color FunctionsColors OverviewCreateCompatibleDCCreatePaletteGetDeviceCapsRealizePalette</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint SelectPalette(nint hdc, nint hPal, bool bForceBkgd);

        /// <summary>
        ///The SetAbortProc function sets the application-defined abort function that allows a print job to be canceled during spooling.
        /// </summary>
        /// <param name="hdc">Handle to the device context for the print job.</param>
        /// <param name="proc">Pointer to the application-defined abort function. For more information about the callback function, see the AbortProc callback function.If the function succeeds, the return value is greater than zero.If the function fails, the return value is SP_ERROR.For an example, see How to Collect Print Job Information from the User.AbortDocAbortProcPrint Spooler API FunctionsPrinting</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int SetAbortProc(nint hdc, int proc);

        /// <summary>
        ///The SetArcDirection sets the drawing direction to be used for arc and rectangle functions.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="dir">The new arc direction. This parameter can be one of the following values.If the function succeeds, the return value specifies the old arc direction.If the function fails, the return value is zero.The default direction is counterclockwise.The SetArcDirection function specifies the direction in which the following functions draw:Line and Curve FunctionsLines and Curves Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int SetArcDirection(nint hdc, int dir);

        /// <summary>
        ///The SetBitmapBits function sets the bits of color data for a bitmap to the specified values.
        /// </summary>
        /// <param name="hbm">A handle to the bitmap to be set. This must be a compatible bitmap (DDB).</param>
        /// <param name="cb">The number of bytes pointed to by the lpBits parameter.</param>
        /// <param name="pvBits">A pointer to an array of bytes that contain color data for the specified bitmap.If the function succeeds, the return value is the number of bytes used in setting the bitmap bits.If the function fails, the return value is zero.The array identified by lpBits must be WORD aligned.Bitmap FunctionsBitmaps OverviewGetBitmapBitsSetDIBits</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int SetBitmapBits(nint hbm, uint cb, nint pvBits);

        /// <summary>
        ///The SetBitmapDimensionEx function assigns preferred dimensions to a bitmap. These dimensions can be used by applications; however, they are not used by the system.
        /// </summary>
        /// <param name="hbm">A handle to the bitmap. The bitmap cannot be a DIB-section bitmap.</param>
        /// <param name="w">The width, in 0.1-millimeter units, of the bitmap.</param>
        /// <param name="h">The height, in 0.1-millimeter units, of the bitmap.</param>
        /// <param name="lpsz"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetBitmapDimensionEx(nint hbm, int w, int h, out int lpsz);

        /// <summary>
        ///The SetBkColor function sets the current background color to the specified color value, or to the nearest physical color if the device cannot represent the specified color value.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="color">The new background color. To make a COLORREF value, use the RGB macro.If the function succeeds, the return value specifies the previous background color as a COLORREF value.If the function fails, the return value is CLR_INVALID.This function fills the gaps between styled lines drawn using a pen created by the CreatePen function; it does not fill the gaps between styled lines drawn using a pen created by the ExtCreatePen function. The SetBkColor function also sets the background colors for TextOut and ExtTextOut.If the background mode is OPAQUE, the background color is used to fill gaps between styled lines, gaps between hatched lines in brushes, and character cells. The background color is also used when converting bitmaps from color to monochrome and vice versa.For an example, see "Example of Owner-Drawn Menu Items" in Using Menus.COLORREFCreatePenExtCreatePenGetBKColorGetBkModePainting and Drawing FunctionsPainting and Drawing OverviewSetBkMode</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int SetBkColor(nint hdc, int color);

        /// <summary>
        ///The SetBkMode function sets the background mix mode of the specified device context. The background mix mode is used with text, hatched brushes, and pen styles that are not solid lines.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="mode">The background mode. This parameter can be one of the following values.If the function succeeds, the return value specifies the previous background mode.If the function fails, the return value is zero.The SetBkMode function affects the line styles for lines drawn using a pen created by the CreatePen function. SetBkMode does not affect lines drawn using a pen created by the ExtCreatePen function.To see how to make the background of a hatch brush transparent or opaque, refer to the example shown in the CreateHatchBrush topic.The next example draws a string 36 times, rotating it 10 degrees counterclockwise each time. It also sets the background mode to transparent to make the text visible.CreatePenExtCreatePenGetBkModePainting and Drawing FunctionsPainting and Drawing Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int SetBkMode(nint hdc, int mode);

        /// <summary>
        ///The SetBoundsRect function controls the accumulation of bounding rectangle information for the specified device context. The system can maintain a bounding rectangle for all drawing operations. An application can examine and set this rectangle. The drawing boundaries are useful for invalidating bitmap caches.
        /// </summary>
        /// <param name="hdc">A handle to the device context for which to accumulate bounding rectangles.</param>
        /// <param name="lprect">A pointer to a RECT structure used to set the bounding rectangle. Rectangle dimensions are in logical coordinates. This parameter can be NULL.</param>
        /// <param name="flags">Specifies how the new rectangle will be combined with the accumulated rectangle. This parameter can be one of more of the following values.If the function succeeds, the return value specifies the previous state of the bounding rectangle. This state can be a combination of the following values.If the function fails, the return value is zero.The DCB_SET value is a combination of the bit values DCB_ACCUMULATE and DCB_RESET. Applications that check the DCB_RESET bit to determine whether the bounding rectangle is empty must also check the DCB_ACCUMULATE bit. The bounding rectangle is empty only if the DCB_RESET bit is 1 and the DCB_ACCUMULATE bit is 0.GetBoundsRectPainting and Drawing FunctionsPainting and Drawing OverviewRECT</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint SetBoundsRect(nint hdc, RECT lprect, uint flags);

        /// <summary>
        ///The SetBrushOrgEx function sets the brush origin that GDI assigns to the next brush an application selects into the specified device context.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="x">The x-coordinate, in device units, of the new brush origin. If this value is greater than the brush width, its value is reduced using the modulus operator (nXOrg mod brush width).</param>
        /// <param name="y">The y-coordinate, in device units, of the new brush origin. If this value is greater than the brush height, its value is reduced using the modulus operator (nYOrg mod brush height).</param>
        /// <param name="lppt"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetBrushOrgEx(nint hdc, int x, int y, out int lppt);

        /// <summary>
        ///The SetColorAdjustment function sets the color adjustment values for a device context (DC) using the specified values.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="lpca">A pointer to a COLORADJUSTMENT structure containing the color adjustment values.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The color adjustment values are used to adjust the input color of the source bitmap for calls to the StretchBlt and StretchDIBits functions when HALFTONE mode is set.COLORADJUSTMENTColor FunctionsColors OverviewGetColorAdjustmentSetStretchBltModeStretchBltStretchDIBits</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetColorAdjustment(nint hdc, COLORADJUSTMENT lpca);

        /// <summary>
        ///The SetColorSpace function defines the input color space for a given device context.
        /// </summary>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint SetColorSpace(nint hdc, nint hcs);

        /// <summary>
        ///SetDCBrushColor function sets the current device context (DC) brush color to the specified color value. If the device cannot represent the specified color value, the color is set to the nearest physical color.
        /// </summary>
        /// <param name="hdc">A handle to the DC.</param>
        /// <param name="color">The new brush color.If the function succeeds, the return value specifies the previous DC brush color as a COLORREF value.If the function fails, the return value is CLR_INVALID.When the stock DC_BRUSH is selected in a DC, all the subsequent drawings will be done using the DC brush color until the stock brush is deselected. The default DC_BRUSH color is WHITE.The function returns the previous DC_BRUSH color, even if the stock brush DC_BRUSH is not selected in the DC: however, this will not be used in drawing operations until the stock DC_BRUSH is selected in the DC.The GetStockObject function with an argument of DC_BRUSH or DC_PEN can be used interchangeably with the SetDCPenColor and SetDCBrushColor functions.ICM: Color management is performed if ICM is enabled.For an example of setting colors, see Setting the Pen or Brush Color.COLORREFDevice Context FunctionsDevice Contexts OverviewGetDCBrushColor</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int SetDCBrushColor(nint hdc, int color);

        /// <summary>
        ///SetDCPenColor function sets the current device context (DC) pen color to the specified color value. If the device cannot represent the specified color value, the color is set to the nearest physical color.
        /// </summary>
        /// <param name="hdc">A handle to the DC.</param>
        /// <param name="color">The new pen color.If the function succeeds, the return value specifies the previous DC pen color as a COLORREF value. If the function fails, the return value is CLR_INVALID.The function returns the previous DC_PEN color, even if the stock pen DC_PEN is not selected in the DC; however, this will not be used in drawing operations until the stock DC_PEN is selected in the DC.The GetStockObject function with an argument of DC_BRUSH or DC_PEN can be used interchangeably with the SetDCPenColor and SetDCBrushColor functions.ICM: Color management is performed if ICM is enabled.For an example of setting colors, see Setting the Pen or Brush Color.COLORREFDevice Context FunctionsDevice Contexts OverviewGetDCPenColor</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int SetDCPenColor(nint hdc, int color);

        /// <summary>
        ///The SetDeviceGammaRamp function sets the gamma ramp on direct color display boards having drivers that support downloadable gamma ramps in hardware.
        /// </summary>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetDeviceGammaRamp(nint hdc, nint lpRamp);

        /// <summary>
        ///The SetDIBColorTable function sets RGB (red, green, blue) color values in a range of entries in the color table of the DIB that is currently selected into a specified device context.
        /// </summary>
        /// <param name="hdc">A device context. A DIB must be selected into this device context.</param>
        /// <param name="iStart">A zero-based color table index that specifies the first color table entry to set.</param>
        /// <param name="cEntries">The number of color table entries to set.</param>
        /// <param name="prgbq">A pointer to an array of RGBQUAD structures containing new color information for the DIB's color table.If the function succeeds, the return value is the number of color table entries that the function sets.If the function fails, the return value is zero.This function should be called to set the color table for DIBs that use 1, 4, or 8 bpp. The BitCount member of a bitmap's associated bitmap information header structure.BITMAPINFOHEADER structure specifies the number of bits-per-pixel. Device-independent bitmaps with a biBitCount value greater than 8 do not have a color table.The bV5BitCount member of a bitmap's associated BITMAPV5HEADER structure specifies the number of bits-per-pixel. Device-independent bitmaps with a bV5BitCount value greater than 8 do not have a color table.ICM: No color management is performed.BITMAPINFOHEADERBitmap FunctionsBitmaps OverviewCreateDIBSectionDIBSECTIONGetDIBColorTableGetObjectRGBQUAD</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint SetDIBColorTable(nint hdc, uint iStart, uint cEntries, RGBQUAD prgbq);

        /// <summary>
        ///The SetDIBits function sets the pixels in a compatible bitmap (DDB) using the color data found in the specified DIB.
        /// </summary>
        /// <param name="hdc">A handle to a device context.</param>
        /// <param name="hbm">A handle to the compatible bitmap (DDB) that is to be altered using the color data from the specified DIB.</param>
        /// <param name="start">The starting scan line for the device-independent color data in the array pointed to by the lpvBits parameter.</param>
        /// <param name="cLines">The number of scan lines found in the array containing device-independent color data.</param>
        /// <param name="lpBits">A pointer to the DIB color data, stored as an array of bytes. The format of the bitmap values depends on the biBitCount member of the BITMAPINFO structure pointed to by the lpbmi parameter.</param>
        /// <param name="lpbmi">A pointer to a BITMAPINFO structure that contains information about the DIB.</param>
        /// <param name="ColorUse">Indicates whether the bmiColors member of the BITMAPINFO structure was provided and, if so, whether bmiColors contains explicit red, green, blue (RGB) values or palette indexes. The fuColorUse parameter must be one of the following values.If the function succeeds, the return value is the number of scan lines copied.If the function fails, the return value is zero.This can be the following value.Optimal bitmap drawing speed is obtained when the bitmap bits are indexes into the system palette.Applications can retrieve the system palette colors and indexes by calling the GetSystemPaletteEntries function. After the colors and indexes are retrieved, the application can create the DIB. For more information, see System Palette.The device context identified by the hdc parameter is used only if the DIB_PAL_COLORS constant is set for the fuColorUse parameter; otherwise it is ignored.The bitmap identified by the hbmp parameter must not be selected into a device context when the application calls this function.The scan lines must be aligned on a DWORD except for RLE-compressed bitmaps.The origin for bottom-up DIBs is the lower-left corner of the bitmap; the origin for top-down DIBs is the upper-left corner of the bitmap.ICM: Color management is performed if color management has been enabled with a call to SetICMMode with the iEnableICM parameter set to ICM_ON. If the bitmap specified by lpbmi has a BITMAPV4HEADER that specifies the gamma and endpoints members, or a BITMAPV5HEADER that specifies either the gamma and endpoints members or the profileData and profileSize members, then the call treats the bitmap's pixels as being expressed in the color space described by those members, rather than in the device context's source color space.BITMAPINFOBitmap FunctionsBitmaps OverviewGetDIBitsGetSystemPaletteEntries</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int SetDIBits(nint hdc, nint hbm, uint start, uint cLines, nint lpBits, BITMAPINFO lpbmi, uint ColorUse);

        /// <summary>
        ///The SetDIBitsToDevice function sets the pixels in the specified rectangle on the device that is associated with the destination device context using color data from a DIB, JPEG, or PNG image.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="xDest">The x-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
        /// <param name="yDest">The y-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
        /// <param name="w">The width, in logical units, of the image.</param>
        /// <param name="h">The height, in logical units, of the image.</param>
        /// <param name="xSrc">The x-coordinate, in logical units, of the lower-left corner of the image.</param>
        /// <param name="ySrc">The y-coordinate, in logical units, of the lower-left corner of the image.</param>
        /// <param name="StartScan">The starting scan line in the image.</param>
        /// <param name="cLines">The number of DIB scan lines contained in the array pointed to by the lpvBits parameter.</param>
        /// <param name="lpvBits">A pointer to the color data stored as an array of bytes. For more information, see the following Remarks section.</param>
        /// <param name="lpbmi">A pointer to a BITMAPINFO structure that contains information about the DIB.</param>
        /// <param name="ColorUse">Indicates whether the bmiColors member of the BITMAPINFO structure contains explicit red, green, blue (RGB) values or indexes into a palette. For more information, see the following Remarks section.The fuColorUse parameter must be one of the following values.If the function succeeds, the return value is the number of scan lines set.If zero scan lines are set (such as when dwHeight is 0) or the function fails, the function returns zero.If the driver cannot support the JPEG or PNG file image passed to SetDIBitsToDevice, the function will fail and return GDI_ERROR. If failure does occur, the application must fall back on its own JPEG or PNG support to decompress the image into a bitmap, and then pass the bitmap to SetDIBitsToDevice.Optimal bitmap drawing speed is obtained when the bitmap bits are indexes into the system palette.Applications can retrieve the system palette colors and indexes by calling the GetSystemPaletteEntries function. After the colors and indexes are retrieved, the application can create the DIB. For more information about the system palette, see Colors.The scan lines must be aligned on a DWORD except for RLE-compressed bitmaps.The origin of a bottom-up DIB is the lower-left corner of the bitmap; the origin of a top-down DIB is the upper-left corner.To reduce the amount of memory required to set bits from a large DIB on a device surface, an application can band the output by repeatedly calling SetDIBitsToDevice, placing a different portion of the bitmap into the lpvBits array each time. The values of the uStartScan and cScanLines parameters identify the portion of the bitmap contained in the lpvBits array.The SetDIBitsToDevice function returns an error if it is called by a process that is running in the background while a full-screen MS-DOS session runs in the foreground.For an example, see Testing a Printer for JPEG or PNG Support.BITMAPINFOBitmap FunctionsBitmaps OverviewGetSystemPaletteEntriesSetDIBitsStretchDIBits</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int SetDIBitsToDevice(nint hdc, int xDest, int yDest, uint w, uint h, int xSrc, int ySrc, uint StartScan, uint cLines, nint lpvBits, BITMAPINFO lpbmi, uint ColorUse);

        /// <summary>
        ///The SetEnhMetaFileBits function creates a memory-based enhanced-format metafile from the specified data.
        /// </summary>
        /// <param name="nSize">Specifies the size, in bytes, of the data provided.</param>
        /// <param name="pb">Pointer to a buffer that contains enhanced-metafile data. (It is assumed that the data in the buffer was obtained by calling the GetEnhMetaFileBits function.)If the function succeeds, the return value is a handle to a memory-based enhanced metafile.If the function fails, the return value is NULL.When the application no longer needs the enhanced-metafile handle, it should delete the handle by calling the DeleteEnhMetaFile function.The SetEnhMetaFileBits function does not accept metafile data in the Windows format. To import Windows-format metafiles, use the SetWinMetaFileBits function.DeleteEnhMetaFileGetEnhMetaFileBitsMetafile FunctionsMetafiles OverviewSetWinMetaFileBits</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint SetEnhMetaFileBits(uint nSize, byte pb);

        /// <summary>
        ///The SetGraphicsMode function sets the graphics mode for the specified device context.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="iMode">The graphics mode. This parameter can be one of the following values.If the function succeeds, the return value is the old graphics mode.If the function fails, the return value is zero.There are three areas in which graphics output differs according to the graphics mode:For an example, see Using Coordinate Spaces and Transformations.Coordinate Space and Transformation FunctionsCoordinate Spaces and Transformations OverviewCreateDCGetArcDirectionGetDCGetGraphicsModeModifyWorldTransformSetArcDirectionSetViewportExtExSetViewportExtentSetWindowExtExSetWindowExtentSetWorldTransform</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int SetGraphicsMode(nint hdc, int iMode);

        /// <summary>
        ///The SetICMMode function causes Image Color Management to be enabled, disabled, or queried on a given device context (DC).
        /// </summary>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int SetICMMode(nint hdc, int mode);

        /// <summary>
        ///The SetICMProfile function sets a specified color profile as the output profile for a specified device context (DC).
        /// </summary>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetICMProfileA(nint hdc, string lpFileName);

        /// <summary>
        ///The SetICMProfile function sets a specified color profile as the output profile for a specified device context (DC).
        /// </summary>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetICMProfileW(nint hdc, string lpFileName);

        /// <summary>
        ///The SetLayout function changes the layout of a device context (DC).
        /// </summary>
        /// <param name="hdc">A handle to the DC.</param>
        /// <param name="l">The DC layout. This parameter can be one or more of the following values.If the function succeeds, it returns the previous layout of the DC.If the function fails, it returns GDI_ERROR.The layout specifies the order in which text and graphics are revealed in a window or a device context. The default is left to right. The SetLayout function changes this to be right to left, which is the standard in Arabic and Hebrew cultures.Once the LAYOUT_RTL flag is selected, flags normally specifying right or left are reversed. To avoid confusion, consider defining alternate words for standard flags, such as those in the following table.SetLayout cannot modify drawing directly into the bits of a DIB.For more information, see "Window Layout and Mirroring" in Window Features.Device Context FunctionsDevice Contexts OverviewGetLayout</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint SetLayout(nint hdc, uint l);

        /// <summary>
        ///The SetMapMode function sets the mapping mode of the specified device context. The mapping mode defines the unit of measure used to transform page-space units into device-space units, and also defines the orientation of the device's x and y axes.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="iMode">The new mapping mode. This parameter can be one of the following values.If the function succeeds, the return value identifies the previous mapping mode.If the function fails, the return value is zero.The MM_TEXT mode allows applications to work in device pixels, whose size varies from device to device.The MM_HIENGLISH, MM_HIMETRIC, MM_LOENGLISH, MM_LOMETRIC, and MM_TWIPS modes are useful for applications drawing in physically meaningful units (such as inches or millimeters).The MM_ISOTROPIC mode ensures a 1:1 aspect ratio.The MM_ANISOTROPIC mode allows the x-coordinates and y-coordinates to be adjusted independently.For an example, see Using Coordinate Spaces and Transformations.Coordinate Space and Transformation FunctionsCoordinate Spaces and Transformations OverviewGetMapModeSetViewportExtExSetViewportOrgExSetWindowExtExSetWindowOrgEx</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int SetMapMode(nint hdc, int iMode);

        /// <summary>
        ///The SetMapperFlags function alters the algorithm the font mapper uses when it maps logical fonts to physical fonts.
        /// </summary>
        /// <param name="hdc">A handle to the device context that contains the font-mapper flag.</param>
        /// <param name="flags">Specifies whether the font mapper should attempt to match a font's aspect ratio to the current device's aspect ratio. If bit zero is set, the mapper selects only matching fonts.If the function succeeds, the return value is the previous value of the font-mapper flag.If the function fails, the return value is GDI_ERROR.If the dwFlag parameter is set and no matching fonts exist, Windows chooses a new aspect ratio and retrieves a font that matches this ratio.The remaining bits of the dwFlag parameter must be zero.Font and Text FunctionsFonts and Text OverviewGetAspectRatioFilterEx</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint SetMapperFlags(nint hdc, uint flags);

        /// <summary>
        ///The SetMetaFileBitsEx function creates a memory-based Windows-format metafile from the supplied data.
        /// </summary>
        /// <param name="cbBuffer">Specifies the size, in bytes, of the Windows-format metafile.</param>
        /// <param name="lpData">Pointer to a buffer that contains the Windows-format metafile. (It is assumed that the data was obtained by using the GetMetaFileBitsEx function.)If the function succeeds, the return value is a handle to a memory-based Windows-format metafile.If the function fails, the return value is NULL.To convert a Windows-format metafile into an enhanced-format metafile, use the SetWinMetaFileBits function.When the application no longer needs the metafile handle returned by SetMetaFileBitsEx, it should delete it by calling the DeleteMetaFile function.DeleteMetaFileGetMetaFileBitsExMetafile FunctionsMetafiles OverviewSetEnhMetaFileBitsSetWinMetaFileBits</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint SetMetaFileBitsEx(uint cbBuffer, byte lpData);

        /// <summary>
        ///The SetMetaRgn function intersects the current clipping region for the specified device context with the current metaregion and saves the combined region as the new metaregion for the specified device context. The clipping region is reset to a null region.
        /// </summary>
        /// <param name="hdc">A handle to the device context.The return value specifies the new clipping region's complexity and can be one of the following values.The current clipping region of a device context is defined by the intersection of its clipping region and its metaregion.The SetMetaRgn function should only be called after an application's original device context was saved by calling the SaveDC function.Clipping FunctionsClipping OverviewGetMetaRgnSaveDC</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int SetMetaRgn(nint hdc);

        /// <summary>
        ///The SetMiterLimit function sets the limit for the length of miter joins for the specified device context.
        /// </summary>
        /// <param name="hdc">Handle to the device context.</param>
        /// <param name="limit">Specifies the new miter limit for the device context.</param>
        /// <param name="old"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetMiterLimit(nint hdc, float limit, out float old);

        /// <summary>
        ///The SetPaletteEntries function sets RGB (red, green, blue) color values and flags in a range of entries in a logical palette.
        /// </summary>
        /// <param name="hpal">A handle to the logical palette.</param>
        /// <param name="iStart">The first logical-palette entry to be set.</param>
        /// <param name="cEntries">The number of logical-palette entries to be set.</param>
        /// <param name="pPalEntries">A pointer to the first member of an array of PALETTEENTRY structures containing the RGB values and flags.If the function succeeds, the return value is the number of entries that were set in the logical palette.If the function fails, the return value is zero.An application can determine whether a device supports palette operations by calling the GetDeviceCaps function and specifying the RASTERCAPS constant.Even if a logical palette has been selected and realized, changes to the palette do not affect the physical palette in the surface. RealizePalette must be called again to set the new logical palette into the surface.Color FunctionsColors OverviewGetDeviceCapsGetPaletteEntriesPALETTEENTRYRealizePalette</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint SetPaletteEntries(nint hpal, uint iStart, uint cEntries, PALETTEENTRY pPalEntries);

        /// <summary>
        ///The SetPixel function sets the pixel at the specified coordinates to the specified color.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="x">The x-coordinate, in logical units, of the point to be set.</param>
        /// <param name="y">The y-coordinate, in logical units, of the point to be set.</param>
        /// <param name="color">The color to be used to paint the point. To create a COLORREF color value, use the RGB macro.If the function succeeds, the return value is the RGB value that the function sets the pixel to. This value may differ from the color specified by crColor; that occurs when an exact match for the specified color cannot be found.If the function fails, the return value is -1.This can be the following value.The function fails if the pixel coordinates lie outside of the current clipping region.Not all devices support the SetPixel function. For more information, see GetDeviceCaps.Bitmap FunctionsBitmaps OverviewCOLORREFGetDeviceCapsGetPixelRGBSetPixelV</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int SetPixel(nint hdc, int x, int y, int color);

        /// <summary>
        ///The SetPixelFormat function sets the pixel format of the specified device context to the format specified by the iPixelFormat index.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetPixelFormat(nint hdc, int format, PIXELFORMATDESCRIPTOR ppfd);

        /// <summary>
        ///The SetPixelV function sets the pixel at the specified coordinates to the closest approximation of the specified color. The point must be in the clipping region and the visible part of the device surface.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="x">The x-coordinate, in logical units, of the point to be set.</param>
        /// <param name="y">The y-coordinate, in logical units, of the point to be set.</param>
        /// <param name="color">The color to be used to paint the point. To create a COLORREF color value, use the RGB macro.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.Not all devices support the SetPixelV function. For more information, see the description of the RC_BITBLT capability in the GetDeviceCaps function.SetPixelV is faster than SetPixel because it does not need to return the color value of the point actually painted.Bitmap FunctionsBitmaps OverviewCOLORREFGetDeviceCapsRGBSetPixel</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetPixelV(nint hdc, int x, int y, int color);

        /// <summary>
        ///The SetPolyFillMode function sets the polygon fill mode for functions that fill polygons.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="mode">The new fill mode. This parameter can be one of the following values.The return value specifies the previous filling mode. If an error occurs, the return value is zero.In general, the modes differ only in cases where a complex, overlapping polygon must be filled (for example, a five-sided polygon that forms a five-pointed star with a pentagon in the center). In such cases, ALTERNATE mode fills every other enclosed region within the polygon (that is, the points of the star), but WINDING mode fills all regions (that is, the points and the pentagon).When the fill mode is ALTERNATE, GDI fills the area between odd-numbered and even-numbered polygon sides on each scan line. That is, GDI fills the area between the first and second side, between the third and fourth side, and so on.When the fill mode is WINDING, GDI fills any region that has a nonzero winding value. This value is defined as the number of times a pen used to draw the polygon would go around the region. The direction of each edge of the polygon is important.GetPolyFillModeRegion FunctionsRegions Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int SetPolyFillMode(nint hdc, int mode);

        /// <summary>
        ///The SetRectRgn function converts a region into a rectangular region with the specified coordinates.
        /// </summary>
        /// <param name="hrgn">Handle to the region.</param>
        /// <param name="left">Specifies the x-coordinate of the upper-left corner of the rectangular region in logical units.</param>
        /// <param name="top">Specifies the y-coordinate of the upper-left corner of the rectangular region in logical units.</param>
        /// <param name="right">Specifies the x-coordinate of the lower-right corner of the rectangular region in logical units.</param>
        /// <param name="bottom">Specifies the y-coordinate of the lower-right corner of the rectangular region in logical units.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The region does not include the lower and right boundaries of the rectangle.CreateRectRgnRegion FunctionsRegions Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetRectRgn(nint hrgn, int left, int top, int right, int bottom);

        /// <summary>
        ///The SetROP2 function sets the current foreground mix mode. GDI uses the foreground mix mode to combine pens and interiors of filled objects with the colors already on the screen. The foreground mix mode defines how colors from the brush or pen and the colors in the existing image are to be combined.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="rop2">The mix mode. This parameter can be one of the following values.If the function succeeds, the return value specifies the previous mix mode.If the function fails, the return value is zero.Mix modes define how GDI combines source and destination colors when drawing with the current pen. The mix modes are binary raster operation codes, representing all possible Boolean functions of two variables, using the binary operations AND, OR, and XOR (exclusive OR), and the unary operation NOT. The mix mode is for raster devices only; it is not available for vector devices.For an example, see Using Rectangles.GetROP2Painting and Drawing FunctionsPainting and Drawing Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int SetROP2(nint hdc, int rop2);

        /// <summary>
        ///The SetStretchBltMode function sets the bitmap stretching mode in the specified device context.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="mode">The stretching mode. This parameter can be one of the following values.If the function succeeds, the return value is the previous stretching mode.If the function fails, the return value is zero.This function can return the following value.The stretching mode defines how the system combines rows or columns of a bitmap with existing pixels on a display device when an application calls the StretchBlt function.The BLACKONWHITE (STRETCH_ANDSCANS) and WHITEONBLACK (STRETCH_ORSCANS) modes are typically used to preserve foreground pixels in monochrome bitmaps. The COLORONCOLOR (STRETCH_DELETESCANS) mode is typically used to preserve color in color bitmaps.The HALFTONE mode is slower and requires more processing of the source image than the other three modes; but produces higher quality images. Also note that SetBrushOrgEx must be called after setting the HALFTONE mode to avoid brush misalignment.Additional stretching modes might also be available depending on the capabilities of the device driver.Bitmap FunctionsBitmaps OverviewGetStretchBltModeSetBrushOrgExStretchBlt</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int SetStretchBltMode(nint hdc, int mode);

        /// <summary>
        ///The SetSystemPaletteUse function allows an application to specify whether the system palette contains 2 or 20 static colors. The default system palette contains 20 static colors. (Static colors cannot be changed when an application realizes a logical palette.)
        /// </summary>
        /// <param name="hdc">A handle to the device context. This device context must refer to a device that supports color palettes.</param>
        /// <param name="use">The new use of the system palette. This parameter can be one of the following values.If the function succeeds, the return value is the previous system palette. It can be either SYSPAL_NOSTATIC, SYSPAL_NOSTATIC256, or SYSPAL_STATIC.If the function fails, the return value is SYSPAL_ERROR.An application can determine whether a device supports palette operations by calling the GetDeviceCaps function and specifying the RASTERCAPS constant.When an application window moves to the foreground and the SYSPAL_NOSTATIC value is set, the application must call the GetSysColor function to save the current system colors setting. It must also call SetSysColors to set reasonable values using only black and white. When the application returns to the background or terminates, the previous system colors must be restored.If the function returns SYSPAL_ERROR, the specified device context is invalid or does not support color palettes.An application must call this function only when its window is maximized and has the input focus.If an application calls SetSystemPaletteUse with uUsage set to SYSPAL_NOSTATIC, the system continues to set aside two entries in the system palette for pure white and pure black, respectively.After calling this function with uUsage set to SYSPAL_NOSTATIC, an application must take the following steps:Color FunctionsColors OverviewGetDeviceCapsGetSysColorGetSystemPaletteUseSetSysColors</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint SetSystemPaletteUse(nint hdc, uint use);

        /// <summary>
        ///The SetTextAlign function sets the text-alignment flags for the specified device context.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="align">The text alignment by using a mask of the values in the following list. Only one flag can be chosen from those that affect horizontal and vertical alignment. In addition, only one of the two flags that alter the current position can be chosen.When the current font has a vertical default base line, as with Kanji, the following values must be used instead of TA_BASELINE and TA_CENTER.The default values are TA_LEFT, TA_TOP, and TA_NOUPDATECP.If the function succeeds, the return value is the previous text-alignment setting.If the function fails, the return value is GDI_ERROR.The TextOut and ExtTextOut functions use the text-alignment flags to position a string of text on a display or other device. The flags specify the relationship between a reference point and a rectangle that bounds the text. The reference point is either the current position or a point passed to a text output function.The rectangle that bounds the text is formed by the character cells in the text string.The best way to get left-aligned text is to use eitherorYou can also use SetTextAlign (hdc, TA_LEFT) for this purpose, but this loses any vertical or right-to-left settings.For an example, see Setting the Text Alignment.ExtTextOutFont and Text FunctionsFonts and Text OverviewGetTextAlignScriptStringOutTextOut</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint SetTextAlign(nint hdc, uint align);

        /// <summary>
        ///The SetTextCharacterExtra function sets the intercharacter spacing. Intercharacter spacing is added to each character, including break characters, when the system writes a line of text.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="extra">The amount of extra space, in logical units, to be added to each character. If the current mapping mode is not MM_TEXT, the nCharExtra parameter is transformed and rounded to the nearest pixel.If the function succeeds, the return value is the previous intercharacter spacing.If the function fails, the return value is 0x80000000.This function is supported mainly for compatibility with existing applications. New applications should generally avoid calling this function, because it is incompatible with complex scripts (scripts that require text shaping; Arabic script is an example of this).The recommended approach is that instead of calling this function and then TextOut, applications should call ExtTextOut and use its lpDx parameter to supply widths.DrawTextFont and Text FunctionsFonts and Text OverviewGetTextCharacterExtraTextOut</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int SetTextCharacterExtra(nint hdc, int extra);

        /// <summary>
        ///The SetTextColor function sets the text color for the specified device context to the specified color.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="color">The color of the text.If the function succeeds, the return value is a color reference for the previous text color as a COLORREF value.If the function fails, the return value is CLR_INVALID.The text color is used to draw the face of each character written by the TextOut and ExtTextOut functions. The text color is also used in converting bitmaps from color to monochrome and vice versa.For an example, see "Setting Fonts for Menu-Item Text Strings" in Using Menus.BitBltCOLORREFExtTextOutFont and Text FunctionsFonts and Text OverviewGetTextColorRGBSetBkColorStretchBltTextOut</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int SetTextColor(nint hdc, int color);

        /// <summary>
        ///The SetTextJustification function specifies the amount of space the system should add to the break characters in a string of text. The space is added when an application calls the TextOut or ExtTextOut functions.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="extra">The total extra space, in logical units, to be added to the line of text. If the current mapping mode is not MM_TEXT, the value identified by the nBreakExtra parameter is transformed and rounded to the nearest pixel.</param>
        /// <param name="count">The number of break characters in the line.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The break character is usually the space character (ASCII 32), but it may be defined by a font as some other character. The GetTextMetrics function can be used to retrieve a font's break character.The TextOut function distributes the specified extra space evenly among the break characters in the line.The GetTextExtentPoint32 function is always used with the SetTextJustification function. Sometimes the GetTextExtentPoint32 function takes justification into account when computing the width of a specified line before justification, and sometimes it does not. For more details on this, see GetTextExtentPoint32. This width must be known before an appropriate nBreakExtra value can be computed.SetTextJustification can be used to justify a line that contains multiple strings in different fonts. In this case, each string must be justified separately.Because rounding errors can occur during justification, the system keeps a running error term that defines the current error value. When justifying a line that contains multiple runs, GetTextExtentPoint automatically uses this error term when it computes the extent of the next run, allowing TextOut to blend the error into the new run. After each line has been justified, this error term must be cleared to prevent it from being incorporated into the next line. The term can be cleared by calling SetTextJustification with nBreakExtra set to zero.ExtTextOutFont and Text FunctionsFonts and Text OverviewGetTextExtentPoint32GetTextMetricsTextOut</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetTextJustification(nint hdc, int extra, int count);

        /// <summary>
        ///The SetViewportExtEx function sets the horizontal and vertical extents of the viewport for a device context by using the specified values.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="x">The horizontal extent, in device units, of the viewport.</param>
        /// <param name="y">The vertical extent, in device units, of the viewport.</param>
        /// <param name="lpsz"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetViewportExtEx(nint hdc, int x, int y, out int lpsz);

        /// <summary>
        ///The SetViewportOrgEx function specifies which device point maps to the window origin (0,0).
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="x">The x-coordinate, in device units, of the new viewport origin.</param>
        /// <param name="y">The y-coordinate, in device units, of the new viewport origin.</param>
        /// <param name="lppt"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetViewportOrgEx(nint hdc, int x, int y, out int lppt);

        /// <summary>
        ///The SetWindowExtEx function sets the horizontal and vertical extents of the window for a device context by using the specified values.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="x">The window's horizontal extent in logical units.</param>
        /// <param name="y">The window's vertical extent in logical units.</param>
        /// <param name="lpsz"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetWindowExtEx(nint hdc, int x, int y, out int lpsz);

        /// <summary>
        ///The SetWindowOrgEx function specifies which window point maps to the viewport origin (0,0).
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="x">The x-coordinate, in logical units, of the new window origin.</param>
        /// <param name="y">The y-coordinate, in logical units, of the new window origin.</param>
        /// <param name="lppt"></param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetWindowOrgEx(nint hdc, int x, int y, out int lppt);

        /// <summary>
        ///The SetWinMetaFileBits function converts a metafile from the older Windows format to the new enhanced format and stores the new metafile in memory.
        /// </summary>
        /// <param name="nSize">The size, in bytes, of the buffer that contains the Windows-format metafile.</param>
        /// <param name="lpMeta16Data">A pointer to a buffer that contains the Windows-format metafile data. (It is assumed that the data was obtained by using the GetMetaFileBitsEx or GetWinMetaFileBits function.)</param>
        /// <param name="hdcRef">A handle to a reference device context.</param>
        /// <param name="lpMFP">A pointer to a METAFILEPICT structure that contains the suggested size of the metafile picture and the mapping mode that was used when the picture was created.If the function succeeds, the return value is a handle to a memory-based enhanced metafile.If the function fails, the return value is NULL.Windows uses the reference device context's resolution data and the data in the METAFILEPICT structure to scale a picture. If the hdcRef parameter is NULL, the system uses resolution data for the current output device. If the lpmfp parameter is NULL, the system uses the MM_ANISOTROPIC mapping mode to scale the picture so that it fits the entire device surface. The hMF member of the METAFILEPICT structure is not used.When the application no longer needs the enhanced metafile handle, it should delete it by calling the DeleteEnhMetaFile function.The handle returned by this function can be used with other enhanced-metafile functions.If the reference device context is not identical to the device in which the metafile was originally created, some GDI functions that use device units may not draw the picture correctly.DeleteEnhMetaFileGetMetaFileBitsExGetWinMetaFileBitsMETAFILEPICTMetafile FunctionsMetafiles OverviewPlayEnhMetaFile</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint SetWinMetaFileBits(uint nSize, byte lpMeta16Data, nint hdcRef, METAFILEPICT lpMFP);

        /// <summary>
        ///The SetWorldTransform function sets a two-dimensional linear transformation between world space and page space for the specified device context. This transformation can be used to scale, rotate, shear, or translate graphics output.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="lpxf">A pointer to an XFORM structure that contains the transformation data.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.Below is the transformation matrix (note that the digits in the element notation are 1-based column number followed by 1-based row number, rather than the reverse).So for any coordinates (x, y) in world space, the transformed coordinates in page space (x', y') can be determined in the way shown below.This function uses logical units.The world transformation is usually used to scale or rotate logical images in a device-independent way.The default world transformation is the identity matrix with zero offset.The SetWorldTransform function will fail unless the graphics mode for the given device context has been set to GM_ADVANCED by previously calling the SetGraphicsMode function. Likewise, it will not be possible to reset the graphics mode for the device context to the default GM_COMPATIBLE mode, unless the world transformation has first been reset to the default identity transformation by calling SetWorldTransform or ModifyWorldTransform.For an example, see Using Coordinate Spaces and Transformations.Coordinate Space and Transformation FunctionsCoordinate Spaces and Transformations OverviewGetWorldTransformModifyWorldTransformSetGraphicsModeSetMapModeSetViewportExtExSetViewportOrgExSetWindowExtExSetWindowOrgExXFORM</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetWorldTransform(nint hdc, XFORM lpxf);

        /// <summary>
        ///The StartDoc function starts a print job.
        /// </summary>
        /// <param name="hdc">A handle to the device context for the print job.</param>
        /// <param name="lpdi">A pointer to a DOCINFO structure containing the name of the document file and the name of the output file.If the function succeeds, the return value is greater than zero. This value is the print job identifier for the document.If the function fails, the return value is less than or equal to zero.Applications can use the value returned by StartDoc to retrieve or set the priority of a print job. Call the GetJob or SetJob function and supply this value as one of the required arguments.For a sample program that uses this function, see How To: Print Using the GDI Print API.DOCINFOEndDocGetJobPrint Spooler API FunctionsPrintingSetJob</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int StartDocA(nint hdc, DOCINFOA lpdi);

        /// <summary>
        ///The StartDoc function starts a print job.
        /// </summary>
        /// <param name="hdc">A handle to the device context for the print job.</param>
        /// <param name="lpdi">A pointer to a DOCINFO structure containing the name of the document file and the name of the output file.If the function succeeds, the return value is greater than zero. This value is the print job identifier for the document.If the function fails, the return value is less than or equal to zero.Applications can use the value returned by StartDoc to retrieve or set the priority of a print job. Call the GetJob or SetJob function and supply this value as one of the required arguments.For a sample program that uses this function, see How To: Print Using the GDI Print API.DOCINFOEndDocGetJobPrint Spooler API FunctionsPrintingSetJob</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int StartDocW(nint hdc, DOCINFOW lpdi);

        /// <summary>
        ///The StartPage function prepares the printer driver to accept data.
        /// </summary>
        /// <param name="hdc">A handle to the device context for the print job.If the function succeeds, the return value is greater than zero.If the function fails, the return value is less than or equal to zero.Neither EndPage nor StartPage resets the device context attributes. Device context attributes remain constant across subsequent pages. You do not need to re-select objects and set up the mapping mode again before printing the next page; however, doing so will produce the same results and reduce code differences between versions of Windows.For a sample program that uses this function, see How To: Print Using the GDI Print API.EndPagePrint Spooler API FunctionsPrintingResetDC</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int StartPage(nint hdc);

        /// <summary>
        ///The StretchBlt function copies a bitmap from a source rectangle into a destination rectangle, stretching or compressing the bitmap to fit the dimensions of the destination rectangle, if necessary. The system stretches or compresses the bitmap according to the stretching mode currently set in the destination device context.
        /// </summary>
        /// <param name="hdcDest">A handle to the destination device context.</param>
        /// <param name="xDest">The x-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
        /// <param name="yDest">The y-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
        /// <param name="wDest">The width, in logical units, of the destination rectangle.</param>
        /// <param name="hDest">The height, in logical units, of the destination rectangle.</param>
        /// <param name="hdcSrc">A handle to the source device context.</param>
        /// <param name="xSrc">The x-coordinate, in logical units, of the upper-left corner of the source rectangle.</param>
        /// <param name="ySrc">The y-coordinate, in logical units, of the upper-left corner of the source rectangle.</param>
        /// <param name="wSrc">The width, in logical units, of the source rectangle.</param>
        /// <param name="hSrc">The height, in logical units, of the source rectangle.</param>
        /// <param name="rop">The raster operation to be performed. Raster operation codes define how the system combines colors in output operations that involve a brush, a source bitmap, and a destination bitmap.See BitBlt for a list of common raster operation codes (ROPs). Note that the CAPTUREBLT ROP generally cannot be used for printing device contexts.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.StretchBlt stretches or compresses the source bitmap in memory and then copies the result to the destination rectangle. This bitmap can be either a compatible bitmap (DDB) or the output from CreateDIBSection. The color data for pattern or destination pixels is merged after the stretching or compression occurs.When an enhanced metafile is being recorded, an error occurs (and the function returns FALSE) if the source device context identifies an enhanced-metafile device context.If the specified raster operation requires a brush, the system uses the brush currently selected into the destination device context.The destination coordinates are transformed by using the transformation currently specified for the destination device context; the source coordinates are transformed by using the transformation currently specified for the source device context.If the source transformation has a rotation or shear, an error occurs.If destination, source, and pattern bitmaps do not have the same color format, StretchBlt converts the source and pattern bitmaps to match the destination bitmap.If StretchBlt must convert a monochrome bitmap to a color bitmap, it sets white bits (1) to the background color and black bits (0) to the foreground color. To convert a color bitmap to a monochrome bitmap, it sets pixels that match the background color to white (1) and sets all other pixels to black (0). The foreground and background colors of the device context with color are used.StretchBlt creates a mirror image of a bitmap if the signs of the nWidthSrc and nWidthDest parameters or if the nHeightSrc and nHeightDest parameters differ. If nWidthSrc and nWidthDest have different signs, the function creates a mirror image of the bitmap along the x-axis. If nHeightSrc and nHeightDest have different signs, the function creates a mirror image of the bitmap along the y-axis.Not all devices support the StretchBlt function. For more information, see the GetDeviceCaps.ICM: No color management is performed when a blit operation occurs.When used in a multiple monitor system, both hdcSrc and hdcDest must refer to the same device or the function will fail. To transfer data between DCs for different devices, convert the memory bitmap to a DIB by calling GetDIBits. To display the DIB to the second device, call SetDIBits or StretchDIBits.For an example, see Scaling an Image.BitBltBitmap FunctionsBitmaps OverviewCreateDIBSectionGetDIBitsGetDeviceCapsMaskBltPlgBltSetDIBitsSetStretchBltModeStretchDIBits</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool StretchBlt(nint hdcDest, int xDest, int yDest, int wDest, int hDest, nint hdcSrc, int xSrc, int ySrc, int wSrc, int hSrc, uint rop);

        /// <summary>
        ///The StretchDIBits function copies the color data for a rectangle of pixels in a DIB, JPEG, or PNG image to the specified destination rectangle. If the destination rectangle is larger than the source rectangle, this function stretches the rows and columns of color data to fit the destination rectangle. If the destination rectangle is smaller than the source rectangle, this function compresses the rows and columns by using the specified raster operation.
        /// </summary>
        /// <param name="hdc">A handle to the destination device context.</param>
        /// <param name="xDest">The x-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
        /// <param name="yDest">The y-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
        /// <param name="DestWidth">The width, in logical units, of the destination rectangle.</param>
        /// <param name="DestHeight">The height, in logical units, of the destination rectangle.</param>
        /// <param name="xSrc">The x-coordinate, in pixels, of the source rectangle in the image.</param>
        /// <param name="ySrc">The y-coordinate, in pixels, of the source rectangle in the image.</param>
        /// <param name="SrcWidth">The width, in pixels, of the source rectangle in the image.</param>
        /// <param name="SrcHeight">The height, in pixels, of the source rectangle in the image.</param>
        /// <param name="lpBits">A pointer to the image bits, which are stored as an array of bytes. For more information, see the Remarks section.</param>
        /// <param name="lpbmi">A pointer to a BITMAPINFO structure that contains information about the DIB.</param>
        /// <param name="iUsage">Specifies whether the bmiColors member of the BITMAPINFO structure was provided and, if so, whether bmiColors contains explicit red, green, blue (RGB) values or indexes. The iUsage parameter must be one of the following values.For more information, see the Remarks section.</param>
        /// <param name="rop">A raster-operation code that specifies how the source pixels, the destination device context's current brush, and the destination pixels are to be combined to form the new image. For a list of some common raster operation codes, see BitBlt.If the function succeeds, the return value is the number of scan lines copied. Note that this value can be negative for mirrored content.If the function fails, or no scan lines are copied, the return value is 0.If the driver cannot support the JPEG or PNG file image passed to StretchDIBits, the function will fail and return GDI_ERROR. If failure does occur, the application must fall back on its own JPEG or PNG support to decompress the image into a bitmap, and then pass the bitmap to StretchDIBits.The origin of a bottom-up DIB is the lower-left corner; the origin of a top-down DIB is the upper-left corner.StretchDIBits creates a mirror image of a bitmap if the signs of the nSrcWidth and nDestWidth parameters, or if the nSrcHeight and nDestHeight parameters differ. If nSrcWidth and nDestWidth have different signs, the function creates a mirror image of the bitmap along the x-axis. If nSrcHeight and nDestHeight have different signs, the function creates a mirror image of the bitmap along the y-axis.StretchDIBits creates a top-down image if the sign of the biHeight member of the BITMAPINFOHEADER structure for the DIB is negative. For a code example, see Sizing a JPEG or PNG Image.This function allows a JPEG or PNG image to be passed as the source image. How each parameter is used remains the same, except:For an example, see Sizing a JPEG or PNG Image.BITMAPINFOBitmap FunctionsBitmaps OverviewSetMapModeSetStretchBltMode</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int StretchDIBits(nint hdc, int xDest, int yDest, int DestWidth, int DestHeight, int xSrc, int ySrc, int SrcWidth, int SrcHeight, nint lpBits, BITMAPINFO lpbmi, uint iUsage, uint rop);

        /// <summary>
        ///The StrokeAndFillPath function closes any open figures in a path, strokes the outline of the path by using the current pen, and fills its interior by using the current brush.
        /// </summary>
        /// <param name="hdc">A handle to the device context.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The device context identified by the hdc parameter must contain a closed path.The StrokeAndFillPath function has the same effect as closing all the open figures in the path, and stroking and filling the path separately, except that the filled region will not overlap the stroked region even if the pen is wide.For an example, see Drawing a Pie Chart.BeginPathFillPathPath FunctionsPaths OverviewSetPolyFillModeStrokePath</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool StrokeAndFillPath(nint hdc);

        /// <summary>
        ///The StrokePath function renders the specified path by using the current pen.
        /// </summary>
        /// <param name="hdc">Handle to a device context that contains the completed path.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The path, if it is to be drawn by StrokePath, must have been completed through a call to EndPath. Calling this function on a path for which EndPath has not been called will cause this function to fail and return zero. Unlike other path drawing functions such as StrokeAndFillPath, StrokePath will not attempt to close the path by drawing a straight line from the first point on the path to the last point on the path.BeginPathEndPathExtCreatePenPath FunctionsPaths Overview</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool StrokePath(nint hdc);

        /// <summary>
        ///The SwapBuffers function exchanges the front and back buffers if the current pixel format for the window referenced by the specified device context includes a back buffer.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SwapBuffers(nint unnamedParam1);

        /// <summary>
        ///The TextOut function writes a character string at the specified location, using the currently selected font, background color, and text color.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="x">The x-coordinate, in logical coordinates, of the reference point that the system uses to align the string.</param>
        /// <param name="y">The y-coordinate, in logical coordinates, of the reference point that the system uses to align the string.</param>
        /// <param name="lpString">A pointer to the string to be drawn. The string does not need to be zero-terminated, because cchString specifies the length of the string.</param>
        /// <param name="c">The length of the string pointed to by lpString, in characters.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The interpretation of the reference point depends on the current text-alignment mode. An application can retrieve this mode by calling the GetTextAlign function; an application can alter this mode by calling the SetTextAlign function. You can use the following values for text alignment. Only one flag can be chosen from those that affect horizontal and vertical alignment. In addition, only one of the two flags that alter the current position can be chosen.By default, the current position is not used or updated by this function. However, an application can call the SetTextAlign function with the fMode parameter set to TA_UPDATECP to permit the system to use and update the current position each time the application calls TextOut for a specified device context. When this flag is set, the system ignores the nXStart and nYStart parameters on subsequent TextOut calls.When the TextOut function is placed inside a path bracket, the system generates a path for the TrueType text that includes each character plus its character box. The region generated is the character box minus the text, rather than the text itself. You can obtain the region enclosed by the outline of the TrueType text by setting the background mode to transparent before placing the TextOut function in the path bracket. Following is sample code that demonstrates this procedure.For an example, see Enumerating the Installed Fonts.Font and Text FunctionsFonts and Text OverviewGetTextAlignSelectObjectSetBkColorSetTextAlignSetTextColorTabbedTextOut</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool TextOutA(nint hdc, int x, int y, string lpString, int c);

        /// <summary>
        ///The TextOut function writes a character string at the specified location, using the currently selected font, background color, and text color.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="x">The x-coordinate, in logical coordinates, of the reference point that the system uses to align the string.</param>
        /// <param name="y">The y-coordinate, in logical coordinates, of the reference point that the system uses to align the string.</param>
        /// <param name="lpString">A pointer to the string to be drawn. The string does not need to be zero-terminated, because cchString specifies the length of the string.</param>
        /// <param name="c">The length of the string pointed to by lpString, in characters.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The interpretation of the reference point depends on the current text-alignment mode. An application can retrieve this mode by calling the GetTextAlign function; an application can alter this mode by calling the SetTextAlign function. You can use the following values for text alignment. Only one flag can be chosen from those that affect horizontal and vertical alignment. In addition, only one of the two flags that alter the current position can be chosen.By default, the current position is not used or updated by this function. However, an application can call the SetTextAlign function with the fMode parameter set to TA_UPDATECP to permit the system to use and update the current position each time the application calls TextOut for a specified device context. When this flag is set, the system ignores the nXStart and nYStart parameters on subsequent TextOut calls.When the TextOut function is placed inside a path bracket, the system generates a path for the TrueType text that includes each character plus its character box. The region generated is the character box minus the text, rather than the text itself. You can obtain the region enclosed by the outline of the TrueType text by setting the background mode to transparent before placing the TextOut function in the path bracket. Following is sample code that demonstrates this procedure.For an example, see Enumerating the Installed Fonts.Font and Text FunctionsFonts and Text OverviewGetTextAlignSelectObjectSetBkColorSetTextAlignSetTextColorTabbedTextOut</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool TextOutW(nint hdc, int x, int y, string lpString, int c);

        /// <summary>
        ///Translates character set information and sets all members of a destination structure to appropriate values.
        /// </summary>
        /// <param name="lpCs"></param>
        /// <param name="dwFlags">Flags specifying how to perform the translation. This parameter can be one of the following values.</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError.
        /// </remarks>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool TranslateCharsetInfo(out char lpCs, uint dwFlags);

        /// <summary>
        ///The TransparentBlt function performs a bit-block transfer of the color data corresponding to a rectangle of pixels from the specified source device context into a destination device context.
        /// </summary>
        /// <param name="hdcDest">A handle to the destination device context.</param>
        /// <param name="xoriginDest">The x-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
        /// <param name="yoriginDest">The y-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
        /// <param name="wDest">The width, in logical units, of the destination rectangle.</param>
        /// <param name="hDest">The height, in logical units, of the destination rectangle.</param>
        /// <param name="hdcSrc">A handle to the source device context.</param>
        /// <param name="xoriginSrc">The x-coordinate, in logical units, of the source rectangle.</param>
        /// <param name="yoriginSrc">The y-coordinate, in logical units, of the source rectangle.</param>
        /// <param name="wSrc">The width, in logical units, of the source rectangle.</param>
        /// <param name="hSrc">The height, in logical units, of the source rectangle.</param>
        /// <param name="crTransparent">The RGB color in the source bitmap to treat as transparent.If the function succeeds, the return value is TRUE.If the function fails, the return value is FALSE.The TransparentBlt function works with compatible bitmaps (DDBs).The TransparentBlt function supports all formats of source bitmaps. However, for 32 bpp bitmaps, it just copies the alpha value over. Use AlphaBlend to specify 32 bits-per-pixel bitmaps with transparency.If the source and destination rectangles are not the same size, the source bitmap is stretched to match the destination rectangle. When the SetStretchBltMode function is used, the iStretchMode modes of BLACKONWHITE and WHITEONBLACK are converted to COLORONCOLOR for the TransparentBlt function.The destination device context specifies the transformation type for the destination coordinates. The source device context specifies the transformation type for the source coordinates.TransparentBlt does not mirror a bitmap if either the width or height, of either the source or destination, is negative.When used in a multiple monitor system, both hdcSrc and hdcDest must refer to the same device or the function will fail. To transfer data between DCs for different devices, convert the memory bitmap to a DIB by calling GetDIBits. To display the DIB to the second device, call SetDIBits or StretchDIBits.AlphaBlendBitmap FunctionsBitmaps OverviewGetDIBitsSetDIBitsSetStretchBltModeStretchDIBits</param>

        [DllImport("Msimg32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool TransparentBlt(nint hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest, nint hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc, uint crTransparent);

        /// <summary>
        ///The UnrealizeObject function resets the origin of a brush or resets a logical palette. If the hgdiobj parameter is a handle to a brush, UnrealizeObject directs the system to reset the origin of the brush the next time it is selected. If the hgdiobj parameter is a handle to a logical palette, UnrealizeObject directs the system to realize the palette as though it had not previously been realized. The next time the application calls the RealizePalette function for the specified palette, the system completely remaps the logical palette to the system palette.
        /// </summary>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool UnrealizeObject(nint h);

        /// <summary>
        ///The UpdateColors function updates the client area of the specified device context by remapping the current colors in the client area to the currently realized logical palette.
        /// </summary>
        /// <param name="hdc">A handle to the device context.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.An application can determine whether a device supports palette operations by calling the GetDeviceCaps function and specifying the RASTERCAPS constant.An inactive window with a realized logical palette may call UpdateColors as an alternative to redrawing its client area when the system palette changes.The UpdateColors function typically updates a client area faster than redrawing the area. However, because UpdateColors performs the color translation based on the color of each pixel before the system palette changed, each call to this function results in the loss of some color accuracy.This function must be called soon after a WM_PALETTECHANGED message is received.Color FunctionsColors OverviewGetDeviceCapsRealizePalette</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool UpdateColors(nint hdc);

        /// <summary>
        ///(Obsolete; retained for backward compatibility)
        /// </summary>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool UpdateICMRegKeyA(uint reserved, string lpszCMID, string lpszFileName, uint command);

        /// <summary>
        ///(Obsolete; retained for backward compatibility)
        /// </summary>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool UpdateICMRegKeyW(uint reserved, string lpszCMID, string lpszFileName, uint command);

        /// <summary>
        ///The wglCopyContext function copies selected groups of rendering states from one OpenGL rendering context to another.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Opengl32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool wglCopyContext(nint unnamedParam1, nint unnamedParam2, uint unnamedParam3);

        /// <summary>
        ///The wglCreateContext function creates a new OpenGL rendering context, which is suitable for drawing on the device referenced by hdc. The rendering context has the same pixel format as the device context.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Opengl32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint wglCreateContext(nint unnamedParam1);

        /// <summary>
        ///The wglCreateLayerContext function creates a new OpenGL rendering context for drawing to a specified layer plane on a device context.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Opengl32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint wglCreateLayerContext(nint unnamedParam1, int unnamedParam2);

        /// <summary>
        ///The wglDeleteContext function deletes a specified OpenGL rendering context.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Opengl32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool wglDeleteContext(nint unnamedParam1);

        /// <summary>
        ///The wglDescribeLayerPlane function obtains information about the layer planes of a given pixel format.
        /// </summary>

        [DllImport("Opengl32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool wglDescribeLayerPlane(nint unnamedParam1, int unnamedParam2, int unnamedParam3, uint unnamedParam4, int unnamedParam5);

        /// <summary>
        ///The wglGetCurrentContext function obtains a handle to the current OpenGL rendering context of the calling thread.
        /// </summary>

        [DllImport("Opengl32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint wglGetCurrentContext();

        /// <summary>
        ///The wglGetCurrentDC function obtains a handle to the device context that is associated with the current OpenGL rendering context of the calling thread.
        /// </summary>

        [DllImport("Opengl32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint wglGetCurrentDC();

        /// <summary>
        ///Retrieves the palette entries from a given color-index layer plane for a specified device context.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Opengl32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int wglGetLayerPaletteEntries(nint unnamedParam1, int unnamedParam2, int unnamedParam3, int unnamedParam4, int unnamedParam5);

        /// <summary>
        ///The wglGetProcAddress function returns the address of an OpenGL extension function for use with the current OpenGL rendering context.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Opengl32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int wglGetProcAddress(string unnamedParam1);

        /// <summary>
        ///The wglMakeCurrent function makes a specified OpenGL rendering context the calling thread's current rendering context. All subsequent OpenGL calls made by the thread are drawn on the device identified by hdc. You can also use wglMakeCurrent to change the calling thread's current rendering context so it's no longer current.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Opengl32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool wglMakeCurrent(nint unnamedParam1, nint unnamedParam2);

        /// <summary>
        ///The wglRealizeLayerPalette function maps palette entries from a given color-index layer plane into the physical palette or initializes the palette of an RGBA layer plane.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Opengl32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool wglRealizeLayerPalette(nint unnamedParam1, int unnamedParam2, bool unnamedParam3);

        /// <summary>
        ///Sets the palette entries in a given color-index layer plane for a specified device context.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Opengl32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int wglSetLayerPaletteEntries(nint unnamedParam1, int unnamedParam2, int unnamedParam3, int unnamedParam4, int unnamedParam5);

        /// <summary>
        ///The wglShareLists function enables multiple OpenGL rendering contexts to share a single display-list space.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Opengl32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool wglShareLists(nint unnamedParam1, nint unnamedParam2);

        /// <summary>
        ///The wglSwapLayerBuffers function swaps the front and back buffers in the overlay, underlay, and main planes of the window referenced by a specified device context.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Opengl32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool wglSwapLayerBuffers(nint unnamedParam1, uint unnamedParam2);

        /// <summary>
        ///The wglUseFontBitmaps function creates a set of bitmap display lists for use in the current OpenGL rendering context. The set of bitmap display lists is based on the glyphs in the currently selected font in the device context. You can then use bitmaps to draw characters in an OpenGL image.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Opengl32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool wglUseFontBitmapsA(nint unnamedParam1, uint unnamedParam2, uint unnamedParam3, uint unnamedParam4);

        /// <summary>
        ///The wglUseFontBitmaps function creates a set of bitmap display lists for use in the current OpenGL rendering context. The set of bitmap display lists is based on the glyphs in the currently selected font in the device context. You can then use bitmaps to draw characters in an OpenGL image.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Opengl32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool wglUseFontBitmapsW(nint unnamedParam1, uint unnamedParam2, uint unnamedParam3, uint unnamedParam4);

        /// <summary>
        ///The wglUseFontOutlines function creates a set of display lists, one for each glyph of the currently selected outline font of a device context, for use with the current rendering context. The display lists are used to draw 3-D characters of TrueType fonts. Each display list describes a glyph outline in floating-point coordinates.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Opengl32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool wglUseFontOutlinesA(nint unnamedParam1, uint unnamedParam2, uint unnamedParam3, uint unnamedParam4, float unnamedParam5, float unnamedParam6, int unnamedParam7, nint unnamedParam8);

        /// <summary>
        ///The wglUseFontOutlines function creates a set of display lists, one for each glyph of the currently selected outline font of a device context, for use with the current rendering context. The display lists are used to draw 3-D characters of TrueType fonts. Each display list describes a glyph outline in floating-point coordinates.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Opengl32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool wglUseFontOutlinesW(nint unnamedParam1, uint unnamedParam2, uint unnamedParam3, uint unnamedParam4, float unnamedParam5, float unnamedParam6, int unnamedParam7, nint unnamedParam8);

        /// <summary>
        ///The WidenPath function redefines the current path as the area that would be painted if the path were stroked using the pen currently selected into the given device context.
        /// </summary>
        /// <param name="hdc">A handle to a device context that contains a closed path.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero.The WidenPath function is successful only if the current pen is a geometric pen created by the ExtCreatePen function, or if the pen is created with the CreatePen function and has a width, in device units, of more than one.The device context identified by the hdc parameter must contain a closed path.Any Bézier curves in the path are converted to sequences of straight lines approximating the widened curves. As such, no Bézier curves remain in the path after WidenPath is called.BeginPathCreatePenEndPathExtCreatePenPath FunctionsPaths OverviewSetMiterLimit</param>

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool WidenPath(nint hdc);


    }
}