using GroupDocs.Watermark.Cloud.Sdk.Api;
using GroupDocs.Watermark.Cloud.Sdk.Client;
using GroupDocs.Watermark.Cloud.Sdk.Model;
using GroupDocs.Watermark.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Watermark.Cloud.Examples.CSharp.WatermarkOperations
{
    /// <summary>
    /// This example demonstrates how to remove watermarks from the document.
    /// </summary>
    public class RemoveWatermarks
    {
        public static void Run()
        {
            var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
            var apiInstance = new WatermarkApi(configuration);

            try
            {
                var fileInfo = new FileInfo
                {
                    FilePath = "with_watermarks/sample.pdf",
                    StorageName = Common.MyStorage
                };

                var options = new RemoveOptions
                {
                    FileInfo = fileInfo,
                    ImageSearchCriteria = new ImageSearchCriteria
                    {
                        ImageFileInfo = new FileInfo { FilePath = "watermark_images/sample_watermark.png", StorageName = Common.MyStorage }
                    },
                    TextSearchCriteria = new TextSearchCriteria
                    {
                        SearchText = "Watermark text"
                    },
                    OutputFolder = "removed_watermarks"
                };

                var request = new RemoveRequest(options);

                var response = apiInstance.Remove(request);
                Console.WriteLine("Resultant file path: " + response.Path);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while calling WatermarkApi: " + e.Message);
            }
        }
    }
}