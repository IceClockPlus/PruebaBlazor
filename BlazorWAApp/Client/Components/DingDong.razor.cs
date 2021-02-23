
using Microsoft.AspNetCore.Components;

namespace BlazorWAApp.Client.Components {
    public partial class DingDong {

        [Parameter]
        public string Message { get; set; }

        private string Texto = "Qeuen es ?";

        private void OnClick() {
            Texto = Message;
        }
    }
}
