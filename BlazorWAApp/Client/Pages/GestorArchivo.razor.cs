using Newtonsoft.Json;
using Syncfusion.Blazor.FileManager;
using Syncfusion.Blazor.Spinner;
using Syncfusion.Blazor.PdfViewer;
using System.Threading.Tasks;
using System;
using System.Net.Http;
using System.Net.Http.Json;

namespace BlazorWAApp.Client.Pages
{
    public partial class GestorArchivo
    {
        private bool IsVisible { get; set; }
        private string Document { get; set; }
        SfSpinner spinner;
        private SfPdfViewer pdfViewer;

        public string[] Items = new string[] { "NewFolder", "Upload", "Delete", "Download", "Rename", "SortBy", "Refresh", "Selection", "View", "Details", "Custom" };
        static HttpClient client = new HttpClient();
        public async void OnToolbarItemClick(ToolbarClickEventArgs<FileManagerDirectoryContent> args)
        {
            var rootFile = DateTime.Now.ToString("DDMMYYYY");
            FileManagerDirectoryContent file = new FileManagerDirectoryContent();
           
            if (args.Item.Text.Equals("Custom"))
            {
                file.Name = rootFile;
                HttpResponseMessage response = await client.PostAsJsonAsync("https://localhost:5001/api/AzureProvider/CreateTree", file);
                response.EnsureSuccessStatusCode();
            }
        }


    }
}
