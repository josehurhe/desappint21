#pragma checksum "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\Curso\EliminarCursos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9720e0e6f350e6e24ee5ab924ef5f7448772f739"
// <auto-generated/>
#pragma warning disable 1591
namespace p25_universidadv5.Pages.Curso
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
#line 3 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\Curso\EliminarCursos.razor"
using p25_universidadv5.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\Curso\EliminarCursos.razor"
using p25_universidadv5.Servicio;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EliminarCursos/{Id}")]
    public partial class EliminarCursos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Eliminar Curso</h3>\r\n<hr>\r\n");
            __builder.AddMarkupContent(1, "<h3>¿Estás seguro de que desear eliminar?</h3>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\Curso\EliminarCursos.razor"
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
                __builder2.AddMarkupContent(13, "<label for=\"Apaterno\" class=\"control-label\">Curso ID</label>\r\n                    ");
                __Blazor.p25_universidadv5.Pages.Curso.EliminarCursos.TypeInference.CreateInputNumber_0(__builder2, 14, 15, "Apaterno", 16, "form-control", 17, 
#nullable restore
#line 18 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\Curso\EliminarCursos.razor"
                                                                                 obj.CursoId

#line default
#line hidden
#nullable disable
                , 18, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.CursoId = __value, obj.CursoId)), 19, () => obj.CursoId);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n                ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.AddMarkupContent(23, "<label for=\"Amaterno\" class=\"control-label\">Titulo</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "id", "Amaterno");
                __builder2.AddAttribute(26, "class", "form-control");
                __builder2.AddAttribute(27, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\Curso\EliminarCursos.razor"
                                                                               obj.Titulo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.Titulo = __value, obj.Titulo))));
                __builder2.AddAttribute(29, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => obj.Titulo));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.AddMarkupContent(33, "<label for=\"Nombre\" class=\"control-label\">Creditos</label>\r\n                    ");
                __Blazor.p25_universidadv5.Pages.Curso.EliminarCursos.TypeInference.CreateInputNumber_1(__builder2, 34, 35, "Nombre", 36, "form-control", 37, 
#nullable restore
#line 26 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\Curso\EliminarCursos.razor"
                                                                               obj.Creditos

#line default
#line hidden
#nullable disable
                , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.Creditos = __value, obj.Creditos)), 39, () => obj.Creditos);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "<label for=\"DepartamentoId\" class=\"control-label\">Departamento</label>\r\n                    ");
                __Blazor.p25_universidadv5.Pages.Curso.EliminarCursos.TypeInference.CreateInputSelect_2(__builder2, 44, 45, "DepartamentoId", 46, "form-control", 47, 
#nullable restore
#line 30 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\Curso\EliminarCursos.razor"
                                                                                       obj.DepartamentoId

#line default
#line hidden
#nullable disable
                , 48, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.DepartamentoId = __value, obj.DepartamentoId)), 49, () => obj.DepartamentoId, 50, (__builder3) => {
#nullable restore
#line 31 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\Curso\EliminarCursos.razor"
                     foreach(var i in @objins){

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(51, "option");
                    __builder3.AddAttribute(52, "value", 
#nullable restore
#line 32 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\Curso\EliminarCursos.razor"
                                        i.DepartamentoId

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 32 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\Curso\EliminarCursos.razor"
__builder3.AddContent(53, i.Nombre);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 33 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\Curso\EliminarCursos.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n            ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "row");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "col-md-4");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "form-group");
                __builder2.OpenElement(61, "button");
                __builder2.AddAttribute(62, "type", "button");
                __builder2.AddAttribute(63, "class", "btn btn-danger");
                __builder2.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\Curso\EliminarCursos.razor"
                                                                                EliminarCurso

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(65, "Eliminar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n                        ");
                __builder2.OpenElement(67, "button");
                __builder2.AddAttribute(68, "type", "button");
                __builder2.AddAttribute(69, "class", "btn btn-primary");
                __builder2.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\Curso\EliminarCursos.razor"
                                                                                 Cancelar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(71, "Cancelar");
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
#line 49 "D:\Universidad\Semestre9\DAI\desappint21\p25-universidadv5\Pages\Curso\EliminarCursos.razor"
       
    [Parameter]
    public string Id { get; set; }
    Curso obj = new Curso();
    List<Departamento> objins;
    protected void EliminarCurso()
    {
        serv.Eliminar(obj);
        NavigationManager.NavigateTo("Cursos");
    }
    void Cancelar()
    {
        NavigationManager.NavigateTo("Cursos");
    }

    protected override void OnInitialized()
    {
        objins = sins.ObtenerTodo("");
        obj = serv.Obtener(Convert.ToInt32(Id));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioDepartamentos sins { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioCursos serv { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.p25_universidadv5.Pages.Curso.EliminarCursos
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
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
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
