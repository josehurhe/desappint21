#pragma checksum "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\Pages\OficinaAsignada\AgregarOficinaAsignadas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb89f0ce1eae9fc0a46a058f68666a58daba279a"
// <auto-generated/>
#pragma warning disable 1591
namespace p24_universidadv4.Pages.OficinaAsignada
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
#line 3 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\Pages\OficinaAsignada\AgregarOficinaAsignadas.razor"
using p24_universidadv4.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\Pages\OficinaAsignada\AgregarOficinaAsignadas.razor"
using p24_universidadv4.Servicio;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AgregarOficinaAsignadas")]
    public partial class AgregarOficinaAsignadas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Asignar Oficina</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-8");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\Pages\OficinaAsignada\AgregarOficinaAsignadas.razor"
                          obj

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\Pages\OficinaAsignada\AgregarOficinaAsignadas.razor"
                                               CrearOficinaAsignada

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
                __builder2.AddMarkupContent(15, "<label for=\"InstructorId\" class=\"control-label\">Instructor</label>\r\n                ");
                __Blazor.p24_universidadv4.Pages.OficinaAsignada.AgregarOficinaAsignadas.TypeInference.CreateInputSelect_0(__builder2, 16, 17, "InstructorId", 18, "form-control", 19, 
#nullable restore
#line 17 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\Pages\OficinaAsignada\AgregarOficinaAsignadas.razor"
                                                                                 obj.InstructorId

#line default
#line hidden
#nullable disable
                , 20, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.InstructorId = __value, obj.InstructorId)), 21, () => obj.InstructorId, 22, (__builder3) => {
                    __builder3.OpenElement(23, "option");
                    __builder3.AddAttribute(24, "value", 
#nullable restore
#line 18 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\Pages\OficinaAsignada\AgregarOficinaAsignadas.razor"
                                 0

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(25, "disabled");
                    __builder3.AddContent(26, "-Elige un instructor-");
                    __builder3.CloseElement();
#nullable restore
#line 19 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\Pages\OficinaAsignada\AgregarOficinaAsignadas.razor"
                 foreach(var i in @objins){

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(27, "option");
                    __builder3.AddAttribute(28, "value", 
#nullable restore
#line 20 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\Pages\OficinaAsignada\AgregarOficinaAsignadas.razor"
                                    i.Id

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 20 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\Pages\OficinaAsignada\AgregarOficinaAsignadas.razor"
__builder3.AddContent(29, i.NombreCompleto);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 21 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\Pages\OficinaAsignada\AgregarOficinaAsignadas.razor"
                }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.AddMarkupContent(33, "<label for=\"Ubicacion\" class=\"control-label\">Ubicacion</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(34);
                __builder2.AddAttribute(35, "id", "Ubicacion");
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\Pages\OficinaAsignada\AgregarOficinaAsignadas.razor"
                                                                            obj.Ubicacion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.Ubicacion = __value, obj.Ubicacion))));
                __builder2.AddAttribute(39, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => obj.Ubicacion));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n            ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "row");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "col-md-4");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group");
                __builder2.AddMarkupContent(47, "<button type=\"submit\" class=\"btn btn-primary\">Guardar</button>\r\n                        ");
                __builder2.OpenElement(48, "button");
                __builder2.AddAttribute(49, "type", "button");
                __builder2.AddAttribute(50, "class", "btn btn-primary");
                __builder2.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\Pages\OficinaAsignada\AgregarOficinaAsignadas.razor"
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
#line 40 "D:\Universidad\Semestre9\DAI\desappint21\p24-universidadv4\Pages\OficinaAsignada\AgregarOficinaAsignadas.razor"
       
    OficinaAsignada obj = new OficinaAsignada();
    List<Instructor> objins;
    protected void CrearOficinaAsignada()
    {
        serv.Insertar(obj);
        NavigationManager.NavigateTo("OficinaAsignadas");
    }
    void Cancelar()
    {
        NavigationManager.NavigateTo("OficinaAsignadas");
    }
    protected override void OnInitialized()
    {
        objins = sins.ObtenerTodo();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioInstructores sins { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioOficinaAsignadas serv { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.p24_universidadv4.Pages.OficinaAsignada.AgregarOficinaAsignadas
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
