#pragma checksum "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Instructor\Instructores.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01859700ede551aabff38e3ea2092b960e848a36"
// <auto-generated/>
#pragma warning disable 1591
namespace p22_universidadv2.Pages.Instructor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\_Imports.razor"
using p22_universidadv2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\_Imports.razor"
using p22_universidadv2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Instructor\Instructores.razor"
using p22_universidadv2.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Instructor\Instructores.razor"
using p22_universidadv2.Servicio;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Instructores")]
    public partial class Instructores : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(0);
            __builder.AddAttribute(1, "class", "btn btn-primary");
            __builder.AddAttribute(2, "href", "AgregarInstructores");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "<i class=\"oi oi-plus\"></i>&nbsp;Agregar Nuevo\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.AddMarkupContent(6, "<h1>Informacion de Instructores</h1>");
#nullable restore
#line 12 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Instructor\Instructores.razor"
 if (obj is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p><em>Cargando...!</em></p>");
#nullable restore
#line 15 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Instructor\Instructores.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table");
            __builder.AddMarkupContent(10, @"<thead><tr><th>Id</th>
                    <th>Apellido Paterno</th>
                    <th>Apellido Materno</th>
                    <th>Nombre</th>
                    <th>Email</th>
                    <th>Fecha de Contratacion</th>
                    <th></th></tr></thead>
        ");
            __builder.OpenElement(11, "tbody");
#nullable restore
#line 31 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Instructor\Instructores.razor"
             foreach(var i in obj)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "tr");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 34 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Instructor\Instructores.razor"
                     i.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 35 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Instructor\Instructores.razor"
                     i.Apaterno

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 36 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Instructor\Instructores.razor"
                     i.Amaterno

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 37 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Instructor\Instructores.razor"
                     i.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 38 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Instructor\Instructores.razor"
                     i.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 39 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Instructor\Instructores.razor"
                     i.FechaContratacion.ToString("yyyy-MMM-dd")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "td");
            __builder.OpenElement(32, "a");
            __builder.AddAttribute(33, "class", "btn btn-primary");
            __builder.AddAttribute(34, "href", "EditarInstructores/" + (
#nullable restore
#line 41 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Instructor\Instructores.razor"
                                                                         i.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(35, "<i class=\"oi oi-pencil\"></i>&nbsp;Editar\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "a");
            __builder.AddAttribute(38, "class", "btn btn-danger");
            __builder.AddAttribute(39, "href", "EliminarInstructores/" + (
#nullable restore
#line 44 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Instructor\Instructores.razor"
                                                                          i.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(40, "<i class=\"oi oi-trash\"></i>&nbsp;Eliminar\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 49 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Instructor\Instructores.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Instructor\Instructores.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Instructor\Instructores.razor"
      
    List<Instructor> obj;
    protected override void OnInitialized()
    {
        obj = serv.ObtienerTodo();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioInstructores serv { get; set; }
    }
}
#pragma warning restore 1591
