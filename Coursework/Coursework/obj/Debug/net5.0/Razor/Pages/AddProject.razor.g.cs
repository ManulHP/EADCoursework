#pragma checksum "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\AddProject.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de5bcf0935a0aa38ca062a910eb84c4520b9bd7f"
// <auto-generated/>
#pragma warning disable 1591
namespace Coursework.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\_Imports.razor"
using Coursework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\_Imports.razor"
using Coursework.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\AddProject.razor"
using Coursework.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddProject")]
    public partial class AddProject : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Add Project</h2>\r\n<hr>\r\n\r\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.AddMarkupContent(8, "<label for=\"Title\" class=\"control-label\">Title</label>\r\n                ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "form", "Title");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\AddProject.razor"
                                                                 obj.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Title = __value, obj.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "<label for=\"CompanyName\" class=\"control-label\">Company Name</label>\r\n                ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "form", "CompanyName");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\AddProject.razor"
                                                                       obj.CompanyName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.CompanyName = __value, obj.CompanyName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "row");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "col-md-4");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "form-group");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "type", "button");
            __builder.AddAttribute(32, "class", "btn btn-primary");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\AddProject.razor"
                                                                        CreateEmployee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "type", "button");
            __builder.AddAttribute(38, "class", "btn btn-primary");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\AddProject.razor"
                                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\AddProject.razor"
       
    Coursework.Data.Project.Project obj = new Coursework.Data.Project.Project();
    protected async void CreateEmployee()
    {
        await projectService.InsertEmployeeAsync(obj);
        NavigationManager.NavigateTo("");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Coursework.Data.Project.ProjectService projectService { get; set; }
    }
}
#pragma warning restore 1591
