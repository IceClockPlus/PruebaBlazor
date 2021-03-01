using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Syncfusion.EJ2.FileManager.AzureFileProvider;
using Syncfusion.EJ2.FileManager.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWAApp.Server.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowAllOrigins")]
    public class AzureProviderController : Controller
    {
        public AzureFileProvider operation;

        public AzureProviderController(IWebHostEnvironment hostingEnvironment)
        {
            this.operation = new AzureFileProvider();
            this.operation.RegisterAzure("storageaccounttesta881c", "lsnKCNWHZ2lMBJggRnRoUona5U3Hn4CqlCnKe9YSdu4zZ2fWRBdr3HOZybhqcrihvRFht9KKmIRhBRySzywZ6A==", "azure-documents");
        }

        [Route("AzureFileOperations")]
        public object AzureFileOperations([FromBody] FileManagerDirectoryContent args)
        {
            if(args.Path != "")
            {
                string startPath = "https://storageaccounttesta881c.blob.core.windows.net/azure-documents/";
                string originPath = ("https://storageaccounttesta881c.blob.core.windows.net/azure-documents/Docs/").Replace(startPath, "");

                args.Path = (originPath + args.Path).Replace("//", "/");
                args.TargetPath = (originPath + args.TargetPath).Replace("//", "/");
            }

            switch (args.Action)
            {
                case "read":
                    // Reads the file(s) or folder(s) from the given path.
                    return Json(this.ToCamelCase(this.operation.GetFiles(args.Path, args.ShowHiddenItems, args.Data)));
                case "delete":
                    // Deletes the selected file(s) or folder(s) from the given path.
                    return this.ToCamelCase(this.operation.Delete(args.Path, args.Names, args.Data));
                case "details":
                    // Gets the details of the selected file(s) or folder(s).
                    return this.ToCamelCase(this.operation.Details(args.Path, args.Names, args.Data));
                case "create":
                    // Creates a new folder in a given path.
                    return this.ToCamelCase(this.operation.Create(args.Path, args.Name, args.Data));
                case "search":
                    // Gets the list of file(s) or folder(s) from a given path based on the searched key string.
                    return this.ToCamelCase(this.operation.Search(args.Path, args.SearchString, args.ShowHiddenItems, args.CaseSensitive, args.Data));
                case "rename":
                    // Renames a file or folder.
                    return this.ToCamelCase(this.operation.Rename(args.Path, args.Name, args.NewName, false, args.Data));
                case "copy":
                    // Copies the selected file(s) or folder(s) from a path and then pastes them into a given target path.
                    return this.ToCamelCase(this.operation.Copy(args.Path, args.TargetPath, args.Names, args.RenameFiles, args.TargetData, args.Data));
                case "move":
                    // Cuts the selected file(s) or folder(s) from a path and then pastes them into a given target path.
                    return this.ToCamelCase(this.operation.Move(args.Path, args.TargetPath, args.Names, args.RenameFiles, args.TargetData, args.Data));
            }
            return null;
        
        }

        public string ToCamelCase(object userData)
        {
            return JsonConvert.SerializeObject(userData, new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy()
                }
            });
        }


    }
}
