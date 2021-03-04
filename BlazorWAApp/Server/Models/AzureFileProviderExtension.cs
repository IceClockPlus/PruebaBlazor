using Syncfusion.EJ2.FileManager.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWAApp.Server.Models
{
    public static class AzureFileProviderExtension
    {
        public static FileManagerResponse CreateTree(this AzureFileProvider az,string path, string name, params FileManagerDirectoryContent[] selectedItems)
        {
            throw new NotImplementedException();
        }
    }
}
