#pragma checksum "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\Pages\EditAlumno.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fce1bff3c219fc84eab7920018e856e2e07860b"
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
#line 2 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\Pages\EditAlumno.razor"
using t1_blazorcrud_alumnos.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditAlumno/{Id}")]
    public partial class EditAlumno : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit Alumno</h3>\r\n\r\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.AddMarkupContent(8, "<label for=\"Matricula\" class=\"control-label\">Matricula</label>\r\n                ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "form", "Matricula");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\Pages\EditAlumno.razor"
                                                                     obj.Matricula

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Matricula = __value, obj.Matricula));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "<label for=\"Nombre\" class=\"control-label\">Nombre</label>\r\n                ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "form", "Nombre");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\Pages\EditAlumno.razor"
                                                                  obj.Nombre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Nombre = __value, obj.Nombre));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "form-group");
            __builder.AddMarkupContent(26, "<label for=\"PrimerApellido\" class=\"control-label\">Primer Apellido</label>\r\n                ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "form", "PrimerApellido");
            __builder.AddAttribute(29, "class", "form-control");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\Pages\EditAlumno.razor"
                                                                          obj.PrimerApellido

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.PrimerApellido = __value, obj.PrimerApellido));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "form-group");
            __builder.AddMarkupContent(35, "<label for=\"SegundoApellido\" class=\"control-label\">Segundo Apellido</label>\r\n                ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "form", "SegundoApellido");
            __builder.AddAttribute(38, "class", "form-control");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\Pages\EditAlumno.razor"
                                                                           obj.SegundoApellido

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.SegundoApellido = __value, obj.SegundoApellido));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "form-group");
            __builder.AddMarkupContent(44, "<label for=\"FechaNacimiento\" class=\"control-label\">Fecha Nacimiento</label>\r\n                ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "type", "date");
            __builder.AddAttribute(47, "form", "FechaNacimiento");
            __builder.AddAttribute(48, "class", "form-control");
            __builder.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\Pages\EditAlumno.razor"
                                                                                       obj.FechaNacimiento

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.FechaNacimiento = __value, obj.FechaNacimiento, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n\r\n            ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "form-group");
            __builder.AddMarkupContent(54, "<label for=\"Genero\" class=\"control-label\"></label>\r\n                ");
            __builder.OpenElement(55, "select");
            __builder.AddAttribute(56, "class", "form-control");
            __builder.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\Pages\EditAlumno.razor"
                                obj.Genero

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Genero = __value, obj.Genero));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(59, "option");
            __builder.AddAttribute(60, "value");
            __builder.AddAttribute(61, "selected");
            __builder.AddAttribute(62, "disabled");
            __builder.AddContent(63, "-Selecciona genero");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                    ");
            __builder.OpenElement(65, "option");
            __builder.AddAttribute(66, "value", "Masculino");
            __builder.AddContent(67, "Masculino");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                    ");
            __builder.OpenElement(69, "option");
            __builder.AddAttribute(70, "value", "Femenino");
            __builder.AddContent(71, "Femenino");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n\r\n    ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "row");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "col-md-4");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "form-group");
            __builder.OpenElement(79, "input");
            __builder.AddAttribute(80, "type", "button");
            __builder.AddAttribute(81, "class", "btn btn-primary");
            __builder.AddAttribute(82, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\Pages\EditAlumno.razor"
                                                                        UpdateAlumno

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                ");
            __builder.OpenElement(85, "input");
            __builder.AddAttribute(86, "type", "button");
            __builder.AddAttribute(87, "class", "btn btn-primary");
            __builder.AddAttribute(88, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\Pages\EditAlumno.razor"
                                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(89, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "D:\Universidad\Semestre9\DAI\desappint21\t1-blazorcrud-alumnos\Pages\EditAlumno.razor"
       
    
    [Parameter]
    public string Id { get; set; }
    Alumno obj = new Alumno();
    protected override void OnInitialized()
    {
        obj = alumnoService.GetAlumno(Convert.ToInt32(Id));
    }
    protected void UpdateAlumno()
    {
        alumnoService.UpdateAlumno(obj);
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
