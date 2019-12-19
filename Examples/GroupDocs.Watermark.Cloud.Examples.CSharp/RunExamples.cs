using System;
using GroupDocs.Watermark.Cloud.Examples.CSharp.InfoOperations;
using GroupDocs.Watermark.Cloud.Examples.CSharp.WatermarkOperations;
using GroupDocs.Watermark.Cloud.Examples.CSharp.WatermarkOperations.AddWatermarks;

namespace GroupDocs.Watermark.Cloud.Examples.CSharp
{
    public class RunExamples
    {
        public static void Main(string[] args)
        {
            //// ***********************************************************
            ////          GroupDocs.Watermark Cloud API Examples
            //// ***********************************************************

            //TODO: Get your AppSID and AppKey at https://dashboard.groupdocs.cloud (free registration is required).
            Common.MyAppSid = "xxxxxxxxxxxxxxxxx";
            Common.MyAppKey = "xxxxxxxxxxxxxxxxx";
            Common.MyStorage = "xxxxxxxxxxxxxxxx";

            // Uploading sample test files from local disk to cloud storage
            Common.UploadSampleTestFiles();

            #region Info operations

            GetSupportedFileTypes.Run();

            //GetDocumentInformation.Run();

            #endregion

            #region Watermark operations

            #region Add operations

            //AddTextWatermarks.Run();

            //AddImageWatermarks.Run();

            #endregion

            //RemoveWatermarks.Run();

            //ReplaceWatermarks.Run();

            //SearchWatermarks.Run();

            #endregion

            Console.WriteLine("Completed!");
            Console.ReadKey();
        }
    }
}