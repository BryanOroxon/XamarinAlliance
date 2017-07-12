using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using System.IO;
using XamarinAllianceApp.Helpers;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage;

namespace XamarinAllianceApp.Services
{
    class ImageService
    {
        public static async Task <Stream> GetImage()
        {
            try
            {
                var client = new MobileServiceClient(Constants.MobileServiceURL);
                var token = await client.InvokeApiAsync<string>("/api/StorageToken/CreateToken");
                string storageAccountName = "xamarinalliance";

                StorageCredentials credentials = new StorageCredentials(token);

                CloudStorageAccount account = new CloudStorageAccount(credentials, storageAccountName, null, true);

                var blobClient = account.CreateCloudBlobClient();
                var container = blobClient.GetContainerReference("images");
                var blob = container.GetBlobReference("XAMARIN-Alliance-logo.png");
                MemoryStream stream = new MemoryStream();
                await blob.DownloadToStreamAsync(stream);
                return stream;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static async Task <string> GetGUID()
        {
            var client = new MobileServiceClient(Constants.MobileServiceURL);
            var guid = await client.InvokeApiAsync<string>("/api/XamarinAlliance/ReceiveCredit");
            return guid;


        }
    }
}
