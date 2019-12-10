using GroupDocs.Watermark.Cloud.Sdk.Api;
using GroupDocs.Watermark.Cloud.Sdk.Client;
using GroupDocs.Watermark.Cloud.Sdk.Model;
using GroupDocs.Watermark.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Watermark.Cloud.Examples.CSharp.InfoOperations
{
    /// <summary>
    /// This example demonstrates how to obtain document file information.
    /// </summary>
    public class GetDocumentInformation
    {
        public static void Run()
        {
            var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
            var apiInstance = new InfoApi(configuration);

            try
            {
                var fileInfo = new FileInfo
                {
                    FilePath = "documents/password-protected.docx",
                    Password = "password",
                    StorageName = Common.MyStorage
                };

                var options = new InfoOptions()
                {
                    FileInfo = fileInfo
                };

                var request = new GetInfoRequest(options);

                var response = apiInstance.GetInfo(request);
                Console.WriteLine("InfoResult.PageCount: " + response.PageCount);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while calling InfoApi: " + e.Message);
            }
        }
    }
}