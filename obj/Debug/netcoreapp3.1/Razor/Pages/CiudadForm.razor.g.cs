#pragma checksum "C:\Users\Tonys\source\repos\SiberianTestFront\SiberianTestFront\Pages\CiudadForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87923e81b619e9c858830e2a8255fa2f3064dd5a"
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
#line 4 "C:\Users\Tonys\source\repos\SiberianTestFront\SiberianTestFront\Pages\CiudadForm.razor"
using SiberianTestFront.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Tonys\source\repos\SiberianTestFront\SiberianTestFront\Pages\CiudadForm.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Tonys\source\repos\SiberianTestFront\SiberianTestFront\Pages\CiudadForm.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Tonys\source\repos\SiberianTestFront\SiberianTestFront\Pages\CiudadForm.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ciudadForm")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/ciudadForm/{id:int}")]
    public partial class CiudadForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Crear/Editar Ciudad</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\Tonys\source\repos\SiberianTestFront\SiberianTestFront\Pages\CiudadForm.razor"
                  city

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\Users\Tonys\source\repos\SiberianTestFront\SiberianTestFront\Pages\CiudadForm.razor"
                                        Guardar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\r\n    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "container-fluid");
                __builder2.AddMarkupContent(12, "\r\n\r\n        ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group row");
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.AddMarkupContent(16, "<label class=\"col-sm-3\">Token, para fines de prueba</label>\r\n            ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "col-sm-12");
                __builder2.AddMarkupContent(19, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "class", "form-control");
                __builder2.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\Tonys\source\repos\SiberianTestFront\SiberianTestFront\Pages\CiudadForm.razor"
                                                              token

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => token = __value, token))));
                __builder2.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => token));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n\r\n        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group row");
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.AddMarkupContent(31, "<label class=\"col-sm-3\">Nombre Ciudad</label>\r\n            ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "col-sm-9");
                __builder2.AddMarkupContent(34, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(35);
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\Tonys\source\repos\SiberianTestFront\SiberianTestFront\Pages\CiudadForm.razor"
                                                              city._nombre_ciudad

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => city._nombre_ciudad = __value, city._nombre_ciudad))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => city._nombre_ciudad));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n\r\n        ");
                __builder2.AddMarkupContent(43, "<div class=\"form-group row\">\r\n            <div class=\"col-sm-12\">\r\n                <button class=\"btn btn-primary\" type=\"submit\">Guardar</button>\r\n            </div>\r\n        </div>\r\n\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\Tonys\source\repos\SiberianTestFront\SiberianTestFront\Pages\CiudadForm.razor"
       

    [Parameter]
    public int id { get; set; }

    Ciudad city = new Ciudad();

    string token;

    private async Task Guardar()
    {
        Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        if (id != 0)
        {
            object result = await Http.PutAsJsonAsync<Ciudad>("/api/ciudad/update", city);
        }
        else
        {
            object result = await Http.PostAsJsonAsync<Ciudad>("/api/ciudad/insert", city);

        }


        navigationManager.NavigateTo("/ciudades");
    }

    protected override async Task OnInitializedAsync()
    {
        if (id != 0)
        {
            List<Ciudad> cities = await Http.GetFromJsonAsync<List<Ciudad>>("/api/ciudad/buscar/" + id);

            city = cities[0];
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
