using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces
{
    public class Context
    {
        protected override async Task OnInitializedAsync()
        {
            forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }
    }
}
