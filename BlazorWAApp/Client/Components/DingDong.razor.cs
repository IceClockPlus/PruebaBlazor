
using Microsoft.AspNetCore.Components;

namespace BlazorWAApp.Client.Components
{
    public partial class DingDong
    {

        [Parameter]
        public string Message { get; set; }

        private string Texto = "¿Quien es ?";

        private string Answer = string.Empty;

        private void OnClick()
        {
            Answer = Message;
        }


    }
}
