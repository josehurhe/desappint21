#pragma checksum "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\Pages\AsignacionCurso\AsignacionCursos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8541f368f0ae749ce04e31d25216dfb2b5b5da9c"
// <auto-generated/>
#pragma warning disable 1591
namespace p24_universidadv4.Pages.AsignacionCurso
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\_Imports.razor"
using p24_universidadv4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\_Imports.razor"
using p24_universidadv4.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\Pages\AsignacionCurso\AsignacionCursos.razor"
using p24_universidadv4.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\Pages\AsignacionCurso\AsignacionCursos.razor"
using p24_universidadv4.Servicio;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AsignacionCursos")]
    public partial class AsignacionCursos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(0);
            __builder.AddAttribute(1, "class", "btn btn-primary");
            __builder.AddAttribute(2, "href", "AgregarAsignacionCursos");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "<i class=\"oi oi-plus\"></i>&nbsp;Agregar Nuevo\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.AddMarkupContent(6, "<h1>Informacion de Cursos Asignados</h1>");
#nullable restore
#line 12 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\Pages\AsignacionCurso\AsignacionCursos.razor"
 if (obj is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p><em>Cargando...!</em></p>");
#nullable restore
#line 15 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\Pages\AsignacionCurso\AsignacionCursos.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table");
            __builder.AddMarkupContent(10, "<thead><tr><th>Instructor</th>\r\n                    <th>Curso</th>\r\n                    <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(11, "tbody");
#nullable restore
#line 27 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\Pages\AsignacionCurso\AsignacionCursos.razor"
             foreach(var i in obj)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "tr");
            __builder.OpenElement(13, "td");
#nullable restore
#line 30 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\Pages\AsignacionCurso\AsignacionCursos.razor"
__builder.AddContent(14, i.Instructor.NombreCompleto);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
#nullable restore
#line 31 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\Pages\AsignacionCurso\AsignacionCursos.razor"
__builder.AddContent(17, i.Curso.Titulo);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.OpenElement(20, "a");
            __builder.AddAttribute(21, "class", "btn btn-primary");
            __builder.AddAttribute(22, "href", "EditarAsignacionCursos/" + (
#nullable restore
#line 33 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\Pages\AsignacionCurso\AsignacionCursos.razor"
                                                                             i.CursoId

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 33 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\Pages\AsignacionCurso\AsignacionCursos.razor"
                                                                                        i.InstructorId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(23, "<i class=\"oi oi-pencil\"></i>&nbsp;Editar\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "class", "btn btn-danger");
            __builder.AddAttribute(27, "href", "EliminarAsignacionCursos/" + (
#nullable restore
#line 36 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\Pages\AsignacionCurso\AsignacionCursos.razor"
                                                                              i.CursoId

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 36 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\Pages\AsignacionCurso\AsignacionCursos.razor"
                                                                                         i.InstructorId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "<i class=\"oi oi-trash\"></i>&nbsp;Eliminar\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\Pages\AsignacionCurso\AsignacionCursos.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\Pages\AsignacionCurso\AsignacionCursos.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\Pages\AsignacionCurso\AsignacionCursos.razor"
      
    List<AsignacionCurso> obj;
    protected override void OnInitialized()
    {
        obj = serv.ObtenerTodo();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioAsignacionCursos serv { get; set; }
    }
}
#pragma warning restore 1591