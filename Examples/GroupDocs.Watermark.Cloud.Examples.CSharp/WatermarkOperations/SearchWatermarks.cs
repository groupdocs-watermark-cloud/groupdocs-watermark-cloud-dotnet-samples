using GroupDocs.Watermark.Cloud.Sdk.Api;
using GroupDocs.Watermark.Cloud.Sdk.Client;
using GroupDocs.Watermark.Cloud.Sdk.Model;
using GroupDocs.Watermark.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Watermark.Cloud.Examples.CSharp.WatermarkOperations
{
    /// <summary>
    /// This example demonstrates how to find watermarks in the document.
    /// </summary>
    public class SearchWatermarks
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

                var options = new SearchOptions
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
                    SaveFoundImages = true,
                    OutputFolder = "found_image_watermarks"
                };

                var request = new SearchRequest(options);

                var response = apiInstance.Search(request);
                foreach (var watermark in response.Watermarks)
                {
                    Console.WriteLine(
                        $"Id: {watermark.Id}, Type: {watermark.PossibleWatermarkType}, Height: {watermark.Height}, Width: {watermark.Width}");
                    if (!string.IsNullOrEmpty(watermark.Text))
                    {
                        Console.WriteLine($"Text: {watermark.Text}");
                    }

                    if (!string.IsNullOrEmpty(watermark.ImageUrl))
                    {
                        Console.WriteLine($"ImageUrl: {watermark.ImageUrl}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while calling WatermarkApi: " + e.Message);
            }
        }
    }
}