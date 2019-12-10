using System;
using System.Collections.Generic;
using GroupDocs.Watermark.Cloud.Sdk.Api;
using GroupDocs.Watermark.Cloud.Sdk.Client;
using GroupDocs.Watermark.Cloud.Sdk.Model;
using GroupDocs.Watermark.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Watermark.Cloud.Examples.CSharp.WatermarkOperations.AddWatermarks
{
    /// <summary>
    /// This example demonstrates how to add image watermark to the document.
    /// </summary>
    public class AddImageWatermarks
    {
        public static void Run()
        {
            var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
            var apiInstance = new WatermarkApi(configuration);

            try
            {
                var fileInfo = new FileInfo
                {
                    FilePath = "documents/sample.docx",
                    StorageName = Common.MyStorage
                };

                var options = new WatermarkOptions()
                {
                    FileInfo = fileInfo,
                    WatermarkDetails = new List<WatermarkDetails>
                    {
                        new WatermarkDetails
                        {
                            ImageWatermarkOptions = new ImageWatermarkOptions()
                            {
                                Image = new FileInfo { FilePath = "watermark_images/sample_watermark.png", StorageName = Common.MyStorage }
                            }
                        }
                    },
                    ProtectLevel = WatermarkOptions.ProtectLevelEnum.DocumentAndImages
                };

                var request = new AddRequest(options);

                var response = apiInstance.Add(request);
                Console.WriteLine("Resultant file path: " + response.Path);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while calling WatermarkApi: " + e.Message);
            }
        }
    }
}