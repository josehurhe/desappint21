// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#pragma warning restore 1591
