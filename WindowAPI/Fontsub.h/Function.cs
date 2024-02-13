
//Auto Create-#=
using static WindowAPI.Fontsub.h.Callback.CallBack;

namespace WindowAPI.Fontsub.h;

public static class Functions
{

    /// <summary>
    ///The CreateFontPackage function creates a subset version of a specified TrueType font, typically in order to pass it to a printer. In order to allow for the fact that pages later in a document may need characters or glyphs that were not used on the first page, this function can create an initial subset font package, then create "Delta" font packages that can be merged with the original subset font package, effectively extending it.
    /// </summary>
    /// <param name="puchSrcBuffer">Points to a buffer containing source TTF or TTC data, describing the font that is to be subsetted.</param>
    /// <param name="ulSrcBufferSize">Specifies size of *puchSrcBuffer, in bytes.</param>
    /// <param name="ppuchFontPackageBuffer"></param>
    /// <param name="pulFontPackageBufferSize"></param>
    /// <param name="pulBytesWritten"></param>
    /// <param name="usFlag">Specifies whether this font should be subsetted, compressed, or both; whether it is a TTF or TTC; and whether*pusSubsetKeepListrepresents character codes or glyph indices. Any combination of the following flags may be specified:</param>
    /// <param name="usTTCIndex">The zero based TTC Index; only used if TTFCFP_FLAGS_TTC is set in usFlags.</param>
    /// <param name="usSubsetFormat">The format of the file to create. Select one of these values; they cannot be combined.</param>
    /// <param name="usSubsetLanguage">The language in the Name table to retain. If Set to 0, all languages will be retained. Used only for initial subsetting: that is, used only if usSubsetFormat is either TTFCFP_SUBSET or TTFCFP_SUBSET1, and the TTFCFP_FLAGS_SUBSET flag is set in usFlags.</param>
    /// <param name="usSubsetPlatform">In conjunction with usSubsetEncoding, specifies which CMAP to use. Used only if *pusSubsetKeepList is a list of characters: that is, used only if TTFCFP_FLAGS_GLYPHLIST is not set in usFlags. In that case, by this CMAP subtable is applied to pusSubsetKeepList to create a list of glyphs to retain in the output font or font package.If used, this must take one of the following values; they cannot be combined:</param>
    /// <param name="usSubsetEncoding">In conjunction with usSubsetPlatform, specifies which CMAP to use. Used only if *pusSubsetKeepList is a list of characters: that is, used only if TTFCFP_FLAGS_GLYPHLIST is not set in usFlags.If used, this must take one of the following values; they cannot be combined:</param>
    /// <param name="pusSubsetKeepList">Points to an array of integers which comprise a list of character codes or glyph indices that should be retained in the output font or font package. If this list contains character codes (that is, if TTFCFP_FLAGS_GLYPHLIST is not set in usFlags), this list may be either Unicode or some other type of encoding, depending on the Platform-Encoding CMAP specified by usSubsetPlatform and usSubsetEncoding.</param>
    /// <param name="usSubsetListCount">The number of elements in the list *pusSubsetKeepList.</param>
    /// <param name="lpfnAllocate">The callback function to allocate initial memory for puchFontPackageBuffer and for temporary buffers.</param>
    /// <param name="lpfnReAllocate">The callback function to reallocate memory for puchFontPackageBuffer and for temporary buffers.</param>
    /// <param name="lpfnFree">The callback function to free up memory allocated by lpfnAllocate and lpfnReAllocate.</param>
    /// <param name="lpvReserved">Must be set to NULL.If the function is successful, returns zero.Otherwise, returns a nonzero value. See Font-Package Function Error Messages for possible error returns.By specifying a value of TTFCFP_SUBSET for usSubsetFormat, you can directly create a working font rather than a font package. This does not allow for future merging, but if there is no need for merging, this skips a step in the downstream processing: a font package needs to be converted back to a working font before it can be used.By specifying a value of TTFCFP_SUBSET1 for usSubsetFormat, you can create a font package that allows later merging. For example, consider the case where an application calls this function at the start of a large print job. Part way through the print job, the application discovers that it needs glyphs that are not in the subset it has built. The application can make another call to CreateFontPackage, this time specifying a value of TTFCFP_DELTA for usSubsetFormat. The printer can use MergeFontPackage to merge in these additional glyphs.A CMAP maps from character encodings to glyphs. If *pusSubsetKeepList is a list of character values, then the application uses parameters usSubsetPlatform and usSubsetEncoding to specify what type of CMAP is being used, so that character values can be mapped to glyphs.CFP_ALLOCPROCCFP_FREEPROCCFP_REALLOCPROCMergeFontPackage</param>

    [DllImport("FontSub.dll", SetLastError = true, CharSet = CharSet.Unicode)]
    public static extern byte CreateFontPackage(byte[] puchSrcBuffer, uint ulSrcBufferSize, out nint ppuchFontPackageBuffer, out uint pulFontPackageBufferSize, out uint pulBytesWritten, ushort usFlag, ushort usTTCIndex, ushort usSubsetFormat, ushort usSubsetLanguage, ushort usSubsetPlatform, ushort usSubsetEncoding, ushort[] pusSubsetKeepList, ushort usSubsetListCount, CFP_ALLOCPROC lpfnAllocate, CFP_REALLOCPROC lpfnReAllocate, CFP_FREEPROC lpfnFree, nint lpvReserved);

    /// <summary>
    ///The MergeFontPackage function manipulates fonts created by CreateFontPackage. It is slightly more flexible than its name might suggest: it can appropriately handle all of the subset fonts and font packages created by CreateFontPackage. It can turn a font package into a working font, and it can merge a Delta font package into an appropriately prepared working font.
    /// </summary>
    /// <param name="puchMergeFontBuffer">A pointer to a buffer containing a font to merge with. This is used only when usMode is TTFMFP_DELTA.</param>
    /// <param name="ulMergeFontBufferSize">Specifies size of *puchMergeFontBuffer, in bytes.</param>
    /// <param name="puchFontPackageBuffer">A pointer to a to buffer containing a font package.</param>
    /// <param name="ulFontPackageBufferSize">Specifies size of *puchMergeFontBuffer, in bytes.</param>
    /// <param name="ppuchDestBuffer"></param>
    /// <param name="pulDestBufferSize"></param>
    /// <param name="pulBytesWritten"></param>
    /// <param name="usMode">Specifies what kind of process to perform. Select one of these values; they cannot be combined.</param>
    /// <param name="lpfnAllocate">The callback function to allocate initial memory for ppuchDestBuffer and for temporary buffers.</param>
    /// <param name="lpfnReAllocate">The callback function to reallocate memory for ppuchDestBuffer and for temporary buffers.</param>
    /// <param name="lpfnFree">The callback function to free up memory allocated by lpfnAllocate and lpfnReAllocate.</param>
    /// <param name="lpvReserved">Must be set to NULL.If the function is successful, returns zero.Otherwise, returns a nonzero value. See Font-Package Function Error Messages for possible error returns.This function handles four distinct, related entities, each representing a subset font:CFP_ALLOCPROCCFP_FREEPROCCFP_REALLOCPROCCreateFontPackage</param>

    [DllImport("FontSub.dll", SetLastError = true, CharSet = CharSet.Unicode)]
    public static extern byte MergeFontPackage(
[In] byte[] puchMergeFontBuffer,
uint ulMergeFontBufferSize,
[In] byte[] puchFontPackageBuffer,
uint ulFontPackageBufferSize,
out nint ppuchDestBuffer,
out uint pulDestBufferSize,
out uint pulBytesWritten,
ushort usMode,
CFP_ALLOCPROC lpfnAllocate,
CFP_REALLOCPROC lpfnReAllocate,
CFP_FREEPROC lpfnFree,
nint lpvReserved);


}