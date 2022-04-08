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
    public static class GenerateCode
    {
        public static Bitmap CreateBarcode(string id)
        {
            BarcodeWriter barcodeWriter = new BarcodeWriter() { Format = BarcodeFormat.CODE_128, Options = new EncodingOptions(){ PureBarcode = true }};
            return barcodeWriter.Write(id);
        }

        public static string DecodeBarcode(Bitmap bitmap)
        {
            BarcodeReader barcodeReader = new BarcodeReader();
            Result result = barcodeReader.Decode(bitmap);
            return result.ToString();
        }

        public static Bitmap CreateQRCode(string email, string password)
        {
            BarcodeWriter barcodeWriter = new BarcodeWriter() { Format = BarcodeFormat.QR_CODE, Options = new EncodingOptions() { PureBarcode = true, Width = 500, Height = 500} };
            return barcodeWriter.Write($"{email}:{password}");
        }
    }
}
