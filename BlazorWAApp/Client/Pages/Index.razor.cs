using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;

namespace BlazorWAApp.Client.Pages {
    public partial class Index {

        [CascadingParameter(Name = "context")]
        public (string name, string issuer) context { get; set; }
    }
}
