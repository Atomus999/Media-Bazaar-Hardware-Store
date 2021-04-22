using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using ZXing;
using ZXing.Common;
using System.Drawing;

namespace Hardware_App
{
    public class BarcodeGenerator
    {
        public void SavePicturesInAFolder()
        {
            string folderPath = @"..\..\BarcodeImages";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                SavePicturesInAFolder();
            }
            else
            {

                foreach (Product product in Product_Manager.GetInstance().GetProductList())
                {
                    //Change this part to create and save a barcode in the folder

                    //BadCode
                    /*GeneratedBarcode MybarCode = BarcodeWriter.CreateBarcode(product.Barcode, BarcodeWriterEncoding.Code128);
                    MybarCode.SaveAsPng(@"..\..\BarcodeImages\" + product.Barcode + ".png");*/
                    SaveBarcode(product.Barcode);
                }
            }
        }
        public void SaveBarcode(string barcode)
        {
            //pb_barcode.Image = WriteBarcode(barcode);
            string folderPath = @"..\..\BarcodeImages";
            string filename = barcode + ".png";
            string fileSavePath = Path.Combine(folderPath, filename);
            using (Bitmap img = WriteBarcode(barcode))
            {
                img.Save(fileSavePath, ImageFormat.Png);
            }
        }
        public Bitmap WriteBarcode(string barcode)
        {
            var bw = new ZXing.BarcodeWriter();
            var encOptions = new ZXing.Common.EncodingOptions() { Width = 150, Height = 80, Margin = 1  };
            bw.Options = encOptions;
            bw.Format = ZXing.BarcodeFormat.CODE_128;
            return bw.Write(barcode);
        }

        public List<string> GetAllPictureNames()
        {

            List<string> imageNames = new List<string>();
            string folderPath = @"..\..\BarcodeImages";
            DirectoryInfo d = new DirectoryInfo(folderPath);
            FileInfo[] Files = d.GetFiles("*.png");
            
            foreach (FileInfo file in Files)
            {
                imageNames.Add(file.Name);
            }
            return imageNames;
        }
        public void CreateADocument()
        {
            SavePicturesInAFolder();

            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            string fileName = @"..\..\BarcodeImages\"+currentDate+".pdf";

            Document document = new Document(PageSize.A4, 10, 10, 10, 10);
            PdfWriter write = PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));
            document.Open();
            PdfPTable table = new PdfPTable(3);
            table.AddCell("Product id ");
            table.AddCell("Product Name");
            table.AddCell("Product barcode");
            foreach (string pictureNames in GetAllPictureNames())
            {
                string barcodeImage = pictureNames.Replace(".png", "");
                if(Product_Manager.GetInstance().GetProductByBarcode(barcodeImage) != null)
                {
                    Product p = Product_Manager.GetInstance().GetProductByBarcode(barcodeImage);
                    iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance(@"..\..\BarcodeImages\" + pictureNames);
                    png.ScaleAbsolute(150, 50);


                    PdfPCell imageCell = new PdfPCell(png);

                    imageCell.Colspan = 3;
                    imageCell.Border = 0;
                    imageCell.Padding = 4;
                    imageCell.HorizontalAlignment = 1;

                    table.AddCell(p.Id.ToString()); //insert real values
                    table.AddCell(p.Name.ToString());
                    table.AddCell(p.Barcode);

                    table.AddCell(imageCell);

                }
               
            }


            //Add table and close
            document.Add(table);
            document.Close();
            write.Close();
            System.Diagnostics.Process.Start(fileName);


        }
    }
}
