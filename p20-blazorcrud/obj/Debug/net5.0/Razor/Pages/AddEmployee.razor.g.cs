#pragma checksum "D:\Universidad\Semestre9\DAI\desappint21\p20-blazorcrud\Pages\AddEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aebebcec2c7b8455283f16fb76c2836bee511696"
// <auto-generated/>
#pragma warning disable 1591
namespace p20_blazorcrud.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Universidad\Semestre9\DAI\desappint21\p20-blazorcrud\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Universidad\Semestre9\DAI\desappint21\p20-blazorcrud\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Universidad\Semestre9\DAI\desappint21\p20-blazorcrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Universidad\Semestre9\DAI\desappint21\p20-blazorcrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Universidad\Semestre9\DAI\desappint21\p20-blazorcrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Universidad\Semestre9\DAI\desappint21\p20-blazorcrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Universidad\Semestre9\DAI\desappint21\p20-blazorcrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Universidad\Semestre9\DAI\desappint21\p20-blazorcrud\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Universidad\Semestre9\DAI\desappint21\p20-blazorcrud\_Imports.razor"
using p20_blazorcrud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Universidad\Semestre9\DAI\desappint21\p20-blazorcrud\_Imports.razor"
using p20_blazorcrud.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Universidad\Semestre9\DAI\desappint21\p20-blazorcrud\Pages\AddEmployee.razor"
using p20_blazorcrud.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddEmployee")]
    public partial class AddEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Add Employee</h3>\r\n<hr>\r\n\r\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.AddMarkupContent(8, "<label for=\"Name\" class=\"control-label\">Name</label>\r\n                ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "form", "Name");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "D:\Universidad\Semestre9\DAI\desappint21\p20-blazorcrud\Pages\AddEmployee.razor"
                                                                obj.EmployeeName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.EmployeeName = __value, obj.EmployeeName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "<label for=\"Gender\" class=\"control-label\"></label>\r\n                ");
            __builder.OpenElement(18, "select");
            __builder.AddAttribute(19, "class", "form-control");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "D:\Universidad\Semestre9\DAI\desappint21\p20-blazorcrud\Pages\AddEmployee.razor"
                                obj.Gender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Gender = __value, obj.Gender));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(22, "option");
            __builder.AddAttribute(23, "value");
            __builder.AddAttribute(24, "selected");
            __builder.AddAttribute(25, "disabled");
            __builder.AddContent(26, "-Select Gender");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "option");
            __builder.AddAttribute(29, "value", "Male");
            __builder.AddContent(30, "Male");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "option");
            __builder.AddAttribute(33, "value", "Female");
            __builder.AddContent(34, "Female");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "form-group");
            __builder.AddMarkupContent(38, "<label for=\"Designation\" class=\"control-label\">Designation</label>\r\n                ");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "form", "Designation");
            __builder.AddAttribute(41, "class", "form-control");
            __builder.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "D:\Universidad\Semestre9\DAI\desappint21\p20-blazorcrud\Pages\AddEmployee.razor"
                                                                       obj.Designation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Designation = __value, obj.Designation));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "form-group");
            __builder.AddMarkupContent(47, "<label for=\"City\" class=\"control-label\">City</label>\r\n                ");
            __builder.OpenElement(48, "input");
            __builder.AddAttribute(49, "form", "City");
            __builder.AddAttribute(50, "class", "form-control");
            __builder.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "D:\Universidad\Semestre9\DAI\desappint21\p20-blazorcrud\Pages\AddEmployee.razor"
                                                                obj.City

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.City = __value, obj.City));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\r\n    ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "row");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "col-md-4");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "form-group");
            __builder.OpenElement(60, "input");
            __builder.AddAttribute(61, "type", "button");
            __builder.AddAttribute(62, "class", "btn btn-primary");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "D:\Universidad\Semestre9\DAI\desappint21\p20-blazorcrud\Pages\AddEmployee.razor"
                                                                        CreateEmployee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.OpenElement(66, "input");
            __builder.AddAttribute(67, "type", "button");
            __builder.AddAttribute(68, "class", "btn btn-primary");
            __builder.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "D:\Universidad\Semestre9\DAI\desappint21\p20-blazorcrud\Pages\AddEmployee.razor"
                                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "D:\Universidad\Semestre9\DAI\desappint21\p20-blazorcrud\Pages\AddEmployee.razor"
       
    Employee obj = new Employee();
    protected void CreateEmployee()
    {
        employeeService.InsertEmployee(obj);
        NavigationManager.NavigateTo("Employees");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("Employees");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmployeeService employeeService { get; set; }
    }
}
#pragma warning restore 1591
