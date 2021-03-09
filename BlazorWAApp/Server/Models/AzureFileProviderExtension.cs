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
            var files = new List<string> { "/Deudor","/Codeudor", "/Garantia/Escritura", "/Garantia/Tasacion" };
            foreach(var newFile in files)
            {
                var fullPath = (name + newFile).Replace("//", "/");
                az.Create(path, fullPath, selectedItems);
            }
            FileManagerResponse response = new FileManagerResponse();
            return az.GetFiles(path,false,selectedItems);
        }
    }
}
