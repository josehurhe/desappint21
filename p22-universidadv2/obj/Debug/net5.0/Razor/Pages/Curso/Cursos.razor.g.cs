#pragma checksum "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Curso\Cursos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9544a3514f551b03701cea31b7c442aa6094f32a"
// <auto-generated/>
#pragma warning disable 1591
namespace p22_universidadv2.Pages.Curso
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
#line 2 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Curso\Cursos.razor"
using p22_universidadv2.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Curso\Cursos.razor"
using p22_universidadv2.Servicio;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Cursos")]
    public partial class Cursos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(0);
            __builder.AddAttribute(1, "class", "btn btn-primary");
            __builder.AddAttribute(2, "href", "AgregarCursos");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "<i class=\"oi oi-plus\"></i>&nbsp;Agregar Nuevo\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.AddMarkupContent(6, "<h1>Informacion de Cursos</h1>");
#nullable restore
#line 12 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Curso\Cursos.razor"
 if (obj is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p><em>Cargando...!</em></p>");
#nullable restore
#line 15 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Curso\Cursos.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table");
            __builder.AddMarkupContent(10, "<thead><tr><th>Id</th>\r\n                    <th>Titulo</th>\r\n                    <th>Creditos</th>\r\n                    <th>Departamento</th>\r\n                    <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(11, "tbody");
#nullable restore
#line 29 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Curso\Cursos.razor"
             foreach(var i in obj)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "tr");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 32 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Curso\Cursos.razor"
                     i.CursoId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 33 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Curso\Cursos.razor"
                     i.Titulo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 34 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Curso\Cursos.razor"
                     i.Creditos

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 35 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Curso\Cursos.razor"
                     i.Departamento.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "class", "btn btn-primary");
            __builder.AddAttribute(28, "href", "EditarCursos/" + (
#nullable restore
#line 37 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Curso\Cursos.razor"
                                                                   i.CursoId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(29, "<i class=\"oi oi-pencil\"></i>&nbsp;Editar\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "class", "btn btn-danger");
            __builder.AddAttribute(33, "href", "EliminarCursos/" + (
#nullable restore
#line 40 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Curso\Cursos.razor"
                                                                    i.CursoId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(34, "<i class=\"oi oi-trash\"></i>&nbsp;Eliminar\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Curso\Cursos.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Curso\Cursos.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Curso\Cursos.razor"
      
    List<Curso> obj;
    protected override void OnInitialized()
    {
        obj = serv.ObtienerTodo();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioCursos serv { get; set; }
    }
}
#pragma warning restore 1591