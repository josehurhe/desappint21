#pragma checksum "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\OficinaAsignada\EliminarOficinaAsignadas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bea1f530cb0d15ed69327db43f14a477a6b8e0a7"
// <auto-generated/>
#pragma warning disable 1591
namespace p25_universidadv5.Pages.OficinaAsignada
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
#line 3 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\OficinaAsignada\EliminarOficinaAsignadas.razor"
using p25_universidadv5.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\OficinaAsignada\EliminarOficinaAsignadas.razor"
using p25_universidadv5.Servicio;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EliminarOficinaAsignadas/{Id}")]
    public partial class EliminarOficinaAsignadas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Eliminar Oficina Asignada</h3>\r\n<hr>\r\n");
            __builder.AddMarkupContent(1, "<h3>??Est??s seguro de que desear eliminar?</h3>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\OficinaAsignada\EliminarOficinaAsignadas.razor"
                          obj

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(9, "fieldset");
                __builder2.AddAttribute(10, "disabled", "true");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group");
                __builder2.AddMarkupContent(13, "<label for=\"InstructorId\" class=\"control-label\">Instructor</label>\r\n                    ");
                __Blazor.p25_universidadv5.Pages.OficinaAsignada.EliminarOficinaAsignadas.TypeInference.CreateInputSelect_0(__builder2, 14, 15, "InstructorId", 16, "form-control", 17, 
#nullable restore
#line 18 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\OficinaAsignada\EliminarOficinaAsignadas.razor"
                                                                                     obj.InstructorId

#line default
#line hidden
#nullable disable
                , 18, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.InstructorId = __value, obj.InstructorId)), 19, () => obj.InstructorId, 20, (__builder3) => {
                    __builder3.AddMarkupContent(21, "<option value=\"null\">-Elige un instructor-</option>");
#nullable restore
#line 20 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\OficinaAsignada\EliminarOficinaAsignadas.razor"
                     foreach(var i in @objins){

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(22, "option");
                    __builder3.AddAttribute(23, "value", 
#nullable restore
#line 21 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\OficinaAsignada\EliminarOficinaAsignadas.razor"
                                        i.Id

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 21 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\OficinaAsignada\EliminarOficinaAsignadas.razor"
__builder3.AddContent(24, i.NombreCompleto);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 22 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\OficinaAsignada\EliminarOficinaAsignadas.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group");
                __builder2.AddMarkupContent(28, "<label for=\"Apaterno\" class=\"control-label\">Ubicacion</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(29);
                __builder2.AddAttribute(30, "id", "Apaterno");
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\OficinaAsignada\EliminarOficinaAsignadas.razor"
                                                                               obj.Ubicacion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.Ubicacion = __value, obj.Ubicacion))));
                __builder2.AddAttribute(34, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => obj.Ubicacion));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n            ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "row");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "col-md-4");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group");
                __builder2.OpenElement(42, "button");
                __builder2.AddAttribute(43, "type", "button");
                __builder2.AddAttribute(44, "class", "btn btn-danger");
                __builder2.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\OficinaAsignada\EliminarOficinaAsignadas.razor"
                                                                                EliminarOficinaAsignada

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(46, "Eliminar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                        ");
                __builder2.OpenElement(48, "button");
                __builder2.AddAttribute(49, "type", "button");
                __builder2.AddAttribute(50, "class", "btn btn-primary");
                __builder2.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\OficinaAsignada\EliminarOficinaAsignadas.razor"
                                                                                 Cancelar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(52, "Cancelar");
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
#line 42 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\OficinaAsignada\EliminarOficinaAsignadas.razor"
       
    [Parameter]
    public string Id { get; set; }
    OficinaAsignada obj = new OficinaAsignada();
    List<Instructor> objins;
    protected void EliminarOficinaAsignada()
    {
        serv.Eliminar(obj);
        NavigationManager.NavigateTo("OficinaAsignadas");
    }
    void Cancelar()
    {
        NavigationManager.NavigateTo("OficinaAsignadas");
    }
    protected override void OnInitialized()
    {
        objins = sins.ObtenerTodo("");
        obj = serv.Obtener(Convert.ToInt32(Id));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioInstructores sins { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioOficinaAsignadas serv { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.p25_universidadv5.Pages.OficinaAsignada.EliminarOficinaAsignadas
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
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
