// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace p22_universidadv2.Pages.Estudiante
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
#line 3 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Estudiante\AgregarEstudiantes.razor"
using p22_universidadv2.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Estudiante\AgregarEstudiantes.razor"
using p22_universidadv2.Servicio;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AgregarEstudiantes")]
    public partial class AgregarEstudiantes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "D:\Universidad\Semestre9\DAI\desappint21\p22-universidadv2\Pages\Estudiante\AgregarEstudiantes.razor"
       
    Estudiante obj = new Estudiante();
    protected void CrearEstudiante()
    {
        serv.Insertar(obj);
        NavigationManager.NavigateTo("Estudiantes");
    }
    void Cancelar()
    {
        NavigationManager.NavigateTo("Estudiantes");
    }
    protected override void OnInitialized()
    {
        obj.FechaIngreso = DateTime.Today;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioEstudidantes serv { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
