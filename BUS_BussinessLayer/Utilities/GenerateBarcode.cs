using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using ZXing.Common;

namespace BUS_BussinessLayer.Utilities
{
    public static class GenerateBarcode
    {
        public static Bitmap CreateQrCode(string id, EncodingOptions options)
        {
            BarcodeWriter barcodeWriter = new BarcodeWriter() { Format = BarcodeFormat.CODE_128};
            barcodeWriter.Options = options;
            return barcodeWriter.Write(id);
        }
    }
}
