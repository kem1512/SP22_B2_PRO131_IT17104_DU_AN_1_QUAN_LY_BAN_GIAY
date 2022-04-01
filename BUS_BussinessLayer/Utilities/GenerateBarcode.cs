using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using ZXing.Common;
using ZXing.Rendering;

namespace BUS_BussinessLayer.Utilities
{
    public static class GenerateBarcode
    {
        public static Bitmap CreateQrCode(string id, EncodingOptions options)
        {
            BarcodeWriter barcodeWriter = new BarcodeWriter() { Format = BarcodeFormat.CODE_128, Renderer = new BitmapRenderer(){ TextFont = new Font("Major Mono Display", 16)}};
            barcodeWriter.Options = options;
            return barcodeWriter.Write(id);
        }
    }
}
