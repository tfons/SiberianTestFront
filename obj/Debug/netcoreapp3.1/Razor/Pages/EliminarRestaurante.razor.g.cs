#pragma checksum "C:\Users\Tonys\source\repos\SiberianTestFront\SiberianTestFront\Pages\EliminarRestaurante.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f255789eb57518d215ddb9b63fd105530b50277b"
// <auto-generated/>
#pragma warning disable 1591
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
#line 5 "C:\Users\Tonys\source\repos\SiberianTestFront\SiberianTestFront\Pages\EliminarRestaurante.razor"
using SiberianTestFront.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Tonys\source\repos\SiberianTestFront\SiberianTestFront\Pages\EliminarRestaurante.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Tonys\source\repos\SiberianTestFront\SiberianTestFront\Pages\EliminarRestaurante.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/eliminarRes/{id:int}")]
    public partial class EliminarRestaurante : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Eliminar Restaurante</h3>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>¿Deseas eliminar este elemento?</p>\r\n");
            __builder.OpenElement(2, "a");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Tonys\source\repos\SiberianTestFront\SiberianTestFront\Pages\EliminarRestaurante.razor"
             Eliminar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "class", "btn btn-danger");
            __builder.AddContent(5, "Eliminar");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.AddMarkupContent(7, "<a href=\"/restaurantes\" class=\"btn btn-warning\">Cancelar</a>");
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\Tonys\source\repos\SiberianTestFront\SiberianTestFront\Pages\EliminarRestaurante.razor"
       
    [Parameter]
    public int id { get; set; }

    private async Task Eliminar()
    {
        if (id != 0)
        {
            var result = await Http.DeleteAsync("/api/restaurante/delete/" + id);
        }


        navigationManager.NavigateTo("/restaurantes");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
