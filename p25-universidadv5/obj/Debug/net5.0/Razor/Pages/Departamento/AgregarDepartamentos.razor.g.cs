#pragma checksum "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\Departamento\AgregarDepartamentos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "756ddbb01128442afb28f2fae82680fb9a7e7825"
// <auto-generated/>
#pragma warning disable 1591
namespace p25_universidadv5.Pages.Departamento
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\_Imports.razor"
using p25_universidadv5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\_Imports.razor"
using p25_universidadv5.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\Departamento\AgregarDepartamentos.razor"
using p25_universidadv5.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\Departamento\AgregarDepartamentos.razor"
using p25_universidadv5.Servicio;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AgregarDepartamentos")]
    public partial class AgregarDepartamentos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Agregar Departamento</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-8");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\Departamento\AgregarDepartamentos.razor"
                          obj

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\Departamento\AgregarDepartamentos.razor"
                                               CrearDepartamento

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group");
                __builder2.AddMarkupContent(15, "<label for=\"Nombre\" class=\"control-label\">Nombre</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "id", "Nombre");
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\Departamento\AgregarDepartamentos.razor"
                                                                         obj.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.Nombre = __value, obj.Nombre))));
                __builder2.AddAttribute(21, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => obj.Nombre));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n            ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group");
                __builder2.AddMarkupContent(25, "<label for=\"Presupuesto\" class=\"control-label\">Presupuesto</label>\r\n                ");
                __Blazor.p25_universidadv5.Pages.Departamento.AgregarDepartamentos.TypeInference.CreateInputNumber_0(__builder2, 26, 27, "Presupuesto", 28, "form-control", 29, 
#nullable restore
#line 21 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\Departamento\AgregarDepartamentos.razor"
                                                                                obj.Presupuesto

#line default
#line hidden
#nullable disable
                , 30, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.Presupuesto = __value, obj.Presupuesto)), 31, () => obj.Presupuesto);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n            ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group");
                __builder2.AddMarkupContent(35, "<label for=\"FechaDeInicio\" class=\"control-label\">Fecha de Inicio</label>\r\n                ");
                __Blazor.p25_universidadv5.Pages.Departamento.AgregarDepartamentos.TypeInference.CreateInputDate_1(__builder2, 36, 37, "FechaDeInicio", 38, "form-control", 39, 
#nullable restore
#line 25 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\Departamento\AgregarDepartamentos.razor"
                                                                                obj.FechaDeInicio

#line default
#line hidden
#nullable disable
                , 40, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.FechaDeInicio = __value, obj.FechaDeInicio)), 41, () => obj.FechaDeInicio);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-group");
                __builder2.AddMarkupContent(45, "<label for=\"InstructorId\" class=\"control-label\">Instructor</label>\r\n                ");
                __Blazor.p25_universidadv5.Pages.Departamento.AgregarDepartamentos.TypeInference.CreateInputSelect_2(__builder2, 46, 47, "InstructorId", 48, "form-control", 49, 
#nullable restore
#line 29 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\Departamento\AgregarDepartamentos.razor"
                                                                                 obj.DepartamentoId

#line default
#line hidden
#nullable disable
                , 50, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.DepartamentoId = __value, obj.DepartamentoId)), 51, () => obj.DepartamentoId, 52, (__builder3) => {
                    __builder3.AddMarkupContent(53, "<option value=\"null\">-Sin asignar-</option>");
#nullable restore
#line 31 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\Departamento\AgregarDepartamentos.razor"
                 foreach(var i in @objins){

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(54, "option");
                    __builder3.AddAttribute(55, "value", 
#nullable restore
#line 32 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\Departamento\AgregarDepartamentos.razor"
                                    i.Id

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 32 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\Departamento\AgregarDepartamentos.razor"
__builder3.AddContent(56, i.NombreCompleto);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 33 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\Departamento\AgregarDepartamentos.razor"
                }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, " \r\n            ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "row");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "col-md-4");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "form-group");
                __builder2.AddMarkupContent(64, "<button type=\"submit\" class=\"btn btn-primary\">Guardar</button>\r\n                        ");
                __builder2.OpenElement(65, "button");
                __builder2.AddAttribute(66, "type", "button");
                __builder2.AddAttribute(67, "class", "btn btn-primary");
                __builder2.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\Departamento\AgregarDepartamentos.razor"
                                                                                 Cancelar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(69, "Cancelar");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\Departamento\AgregarDepartamentos.razor"
       
    Departamento obj = new Departamento();
    List<Instructor> objins;
    protected void CrearDepartamento()
    {
        serv.Insertar(obj);
        NavigationManager.NavigateTo("Departamentos");
    }
    void Cancelar()
    {
        NavigationManager.NavigateTo("Departamentos");
    }

    protected override void OnInitialized()
    {
        objins = sins.ObtenerTodo("");
        obj.FechaDeInicio = DateTime.Today;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioInstructores sins { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioDepartamentos serv { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.p25_universidadv5.Pages.Departamento.AgregarDepartamentos
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
