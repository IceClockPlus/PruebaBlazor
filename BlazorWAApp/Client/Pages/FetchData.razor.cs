using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

using BlazorWAApp.Shared;

using Microsoft.AspNetCore.Components;

namespace BlazorWAApp.Client.Pages {
    public partial class FetchData {
        [Inject]
        public HttpClient Http { get; set; }

        private WeatherForecast[] forecasts;

        protected override async Task OnInitializedAsync() {
            forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        }

        protected override void OnParametersSet() {
            base.OnParametersSet();
        }

        protected override void OnAfterRender(bool firstRender) {
            base.OnAfterRender(firstRender);
        }
    }
}
