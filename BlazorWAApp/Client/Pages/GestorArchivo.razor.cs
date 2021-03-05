using Newtonsoft.Json;
using Syncfusion.Blazor.FileManager;
using Syncfusion.Blazor.Spinner;
using Syncfusion.Blazor.PdfViewer;
using System.Threading.Tasks;
using System;

namespace BlazorWAApp.Client.Pages
{
    public partial class GestorArchivo
    {
        private bool IsVisible { get; set; }
        private string Document { get; set; }
        SfSpinner spinner;
        private SfPdfViewer pdfViewer;

        public string[] Items = new string[] { "NewFolder", "Upload", "Delete", "Download", "Rename", "SortBy", "Refresh", "Selection", "View", "Details", "Custom" };

        public void OnToolbarItemClick(ToolbarClickEventArgs<FileManagerDirectoryContent> args)
        {
            var rootFile = DateTime.Now.ToString();
            if (args.Item.Text.Equals("Custom"))
            {

            }
        }
    }
}
