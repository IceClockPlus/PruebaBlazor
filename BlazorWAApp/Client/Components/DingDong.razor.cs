using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;

namespace BlazorWAApp.Client.Components {
    public partial class DingDong {

        [Parameter]
        public string Message { get; set; }

        private string Texto;

        private void OnClick() {
            Texto = Message;
        }
    }
}
