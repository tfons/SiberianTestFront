#pragma checksum "C:\Users\Tonys\source\repos\SiberianTestFront\SiberianTestFront\Pages\Restaurantes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87ece29a572299f6186050ef5658e373431ff257"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SiberianTestFront.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\Tonys\source\repos\SiberianTestFront\SiberianTestFront\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tonys\source\repos\SiberianTestFront\SiberianTestFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tonys\source\repos\SiberianTestFront\SiberianTestFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Tonys\source\repos\SiberianTestFront\SiberianTestFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Tonys\source\repos\SiberianTestFront\SiberianTestFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Tonys\source\repos\SiberianTestFront\SiberianTestFront\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Tonys\source\repos\SiberianTestFront\SiberianTestFront\_Imports.razor"
using SiberianTestFront;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Tonys\source\repos\SiberianTestFront\SiberianTestFront\_Imports.razor"
using SiberianTestFront.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tonys\source\repos\SiberianTestFront\SiberianTestFront\Pages\Restaurantes.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tonys\source\repos\SiberianTestFront\SiberianTestFront\Pages\Restaurantes.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Tonys\source\repos\SiberianTestFront\SiberianTestFront\Pages\Restaurantes.razor"
using SiberianTestFront.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/restaurantes")]
    public partial class Restaurantes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\Tonys\source\repos\SiberianTestFront\SiberianTestFront\Pages\Restaurantes.razor"
       

    public List<Restaurante> res = new List<Restaurante>();
    public List<string> dias;

    protected override async Task OnInitializedAsync()
    {
        res = await Http.GetFromJsonAsync<List<Restaurante>>("/api/restaurante/all");

    }

    async Task MostrarLista()
    {
        var response = await JS.InvokeAsync<List<string>>("myArray");

        dias = response;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591