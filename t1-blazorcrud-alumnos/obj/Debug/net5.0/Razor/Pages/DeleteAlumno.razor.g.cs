#pragma checksum "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\Pages\DeleteAlumno.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8e9e8def1a7c393d1eb45034222781a594026fd"
// <auto-generated/>
#pragma warning disable 1591
namespace t1_blazorcrud_alumnos.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\_Imports.razor"
using t1_blazorcrud_alumnos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\_Imports.razor"
using t1_blazorcrud_alumnos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\Pages\DeleteAlumno.razor"
using t1_blazorcrud_alumnos.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DeleteAlumno/{Id}")]
    public partial class DeleteAlumno : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Delete Alumno</h3>\r\n<hr>\r\n");
            __builder.AddMarkupContent(1, "<h3>Are you sure want to delete this?</h3>\r\n\r\n");
            __builder.OpenElement(2, "form");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", " col-md-8");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group");
            __builder.AddMarkupContent(9, "<label>Alumno Id:</label>\r\n                ");
            __builder.OpenElement(10, "label");
            __builder.AddContent(11, 
#nullable restore
#line 15 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\Pages\DeleteAlumno.razor"
                        obj.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-group");
            __builder.AddMarkupContent(15, "<label>Matricula:</label>\r\n                ");
            __builder.OpenElement(16, "label");
            __builder.AddContent(17, 
#nullable restore
#line 19 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\Pages\DeleteAlumno.razor"
                        obj.Matricula

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "form-group");
            __builder.AddMarkupContent(21, "<label>Nombre:</label>\r\n                ");
            __builder.OpenElement(22, "label");
            __builder.AddContent(23, 
#nullable restore
#line 23 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\Pages\DeleteAlumno.razor"
                        obj.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "form-group");
            __builder.AddMarkupContent(27, "<label>Primer Apellido:</label>\r\n                ");
            __builder.OpenElement(28, "label");
            __builder.AddContent(29, 
#nullable restore
#line 27 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\Pages\DeleteAlumno.razor"
                        obj.PrimerApellido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "form-group");
            __builder.AddMarkupContent(33, "<label>Segundo Apellido:</label>\r\n                ");
            __builder.OpenElement(34, "label");
            __builder.AddContent(35, 
#nullable restore
#line 31 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\Pages\DeleteAlumno.razor"
                        obj.SegundoApellido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "form-group");
            __builder.AddMarkupContent(39, "<label>Fecha Nacimiento:</label>\r\n                ");
            __builder.OpenElement(40, "label");
            __builder.AddContent(41, 
#nullable restore
#line 35 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\Pages\DeleteAlumno.razor"
                        obj.FechaNacimiento.Date.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "form-group");
            __builder.AddMarkupContent(45, "<label>Genero:</label>\r\n                ");
            __builder.OpenElement(46, "label");
            __builder.AddContent(47, 
#nullable restore
#line 39 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\Pages\DeleteAlumno.razor"
                        obj.Genero

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "row");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "col-md-4");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "form-group");
            __builder.OpenElement(55, "input");
            __builder.AddAttribute(56, "type", "button");
            __builder.AddAttribute(57, "class", "btn btn-danger");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\Pages\DeleteAlumno.razor"
                                                                       RemoveAlumno

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "value", "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.OpenElement(61, "input");
            __builder.AddAttribute(62, "type", "button");
            __builder.AddAttribute(63, "class", "btn btn-primary");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\Pages\DeleteAlumno.razor"
                                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\Pages\DeleteAlumno.razor"
       
    [Parameter]
    public string Id { get; set; }
    Alumno obj = new Alumno();
    protected override void OnInitialized()
    {
        obj = alumnoService.GetAlumno(Convert.ToInt32(Id));
    }
    protected void RemoveAlumno()
    {
        alumnoService.DeleteAlumno(obj);
        NavigationManager.NavigateTo("Alumnos");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("Alumnos");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AlumnoService alumnoService { get; set; }
    }
}
#pragma warning restore 1591
