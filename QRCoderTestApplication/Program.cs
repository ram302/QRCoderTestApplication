using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace QRCoderTestApplication
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            QrCode();
        }

        public static void QrCode()
        {
            /* CALENDAR EVENT:
            
            */
            PayloadGenerator.CalendarEvent generator = new PayloadGenerator.CalendarEvent("Rudy's Birthday", "Come to Rudy's Birthday Party! If the date has passed, sorry.", "40.749941, -73.990928", new DateTime(2018, 1, 31, 1, 0, 0), new DateTime(2017, 7, 31, 2, 0, 0), false, PayloadGenerator.CalendarEvent.EventEncoding.Universal);
            string payload = generator.ToString();

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            var qrCodeAsBitmap = qrCode.GetGraphic(10, Color.Black, Color.White, (Bitmap)Bitmap.FromFile(@".\favicon.ico"));



            /* PHONE NUMBER:
            
            PayloadGenerator.PhoneNumber generator = new PayloadGenerator.PhoneNumber("2125551212");
            string payload = generator.ToString();

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            var qrCodeAsBitmap = qrCode.GetGraphic(10, Color.Black, Color.White, (Bitmap)Bitmap.FromFile(@".\favicon.ico"));
            
            */

            /* URL:

            PayloadGenerator.Url url = new PayloadGenerator.Url("https://www.bing.com/");
            string payload = url.ToString();

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            var qrCodeAsBitmap = qrCode.GetGraphic(10, Color.Black, Color.White, (Bitmap)Bitmap.FromFile(@".\favicon.ico"));

            */

            /* WIFI:
            
            PayloadGenerator.WiFi wifi = new PayloadGenerator.WiFi("Premier-Alt", "3uropeanSwall0w", PayloadGenerator.WiFi.Authentication.WPA);
            string payload = wifi.ToString();

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            var qrCodeAsBitmap = qrCode.GetGraphic(10, Color.Black, Color.White, (Bitmap)Bitmap.FromFile(@".\favicon.ico"));

            */

            /* MMS:
                
            PayloadGenerator.MMS mms = new PayloadGenerator.MMS("19174423154", "I hope you're hanging in there and that you're feeling okay.", PayloadGenerator.MMS.MMSEncoding.MMS);
            string payload = mms.ToString();

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            var qrCodeAsBitmap = qrCode.GetGraphic(10, Color.Black, Color.White, (Bitmap)Bitmap.FromFile(@".\favicon.ico"));
              
            */

            Clipboard.Clear();
            Clipboard.SetImage((Image)qrCodeAsBitmap);
            Application.Exit();
        }
    }
}
