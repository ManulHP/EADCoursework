#pragma checksum "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d01840cdc35d87b733b4708f16c246339a5325dc"
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
#line 2 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
using Coursework.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewPorject")]
    public partial class ViewProject : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 12 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
 if (EmpObj is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Fetching data... Please wait !</em></p>");
#nullable restore
#line 15 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div class=\"row\"><div class=\"col-lg-9\"><h1>WorkSpace</h1></div>\r\n        <div class=\"col-lg-3 text-right\"><a class=\"btn btn-success btn-sm\" href=\"AddProject\" role=\"button\">Create New</a></div></div>");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table table-borderless table-striped table-sm col px-md-2");
            __builder.AddMarkupContent(4, @"<thead class=""thead-dark""><tr><th style=""width:100px"">Title</th>
                <th style=""width:200px"">Comapany Name</th>
                <th style=""width:800px"">Description</th>
                <th style=""width:200px"">Project Type</th>
                <th></th></tr></thead>
        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 40 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
             foreach (var emp in EmpObj)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 43 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
                     emp.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 44 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
                     emp.CompanyName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 45 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
                     emp.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 46 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
                     emp.ProjectType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddAttribute(20, "class", "text-right");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "class", "btn btn-light btn-sm");
            __builder.AddAttribute(23, "href", "Dash/" + (
#nullable restore
#line 48 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
                                                                emp.Id

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 48 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
                                                                        emp.ProjectType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "role", "button");
            __builder.AddContent(25, "View");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "class", "btn btn-primary btn-sm");
            __builder.AddAttribute(29, "href", "EditProject/" + (
#nullable restore
#line 49 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
                                                                         emp.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "role", "button");
            __builder.AddContent(31, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "a");
            __builder.AddAttribute(34, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(35, "href", "DeleteProject/" + (
#nullable restore
#line 50 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
                                                                          emp.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "role", "button");
            __builder.AddContent(37, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 56 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"

}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(38, @"<style>
    .wrapper {
        max-height: 120px;
        border: 1px solid #808080;
        display: flex;
        overflow-x: auto;
    }

        .wrapper::webkit-scrollbar {
            width: 0;
        }

        .wrapper .item {
            width: 110px;
            height: 110px;
            line-height: 110px;
            text-align: center;
            background-color: aqua;
            margin-right: 2px;
        }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 110 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\ViewProject.razor"
       
    List<Coursework.Data.Project.Project> EmpObj;
    protected override async Task OnInitializedAsync()
    {
        EmpObj = await Task.Run(() => projectService.GetAllProjectAsync());

    }


    [Inject] IJSRuntime JSRuntime { get; set; }
    protected async Task MessageBox()
    {
        await JSRuntime.InvokeVoidAsync("exampleJsFunctions.ShowMsg",
                                                     "Hello Blazor");
    }

    private void PrintReport()
    {
        JS.InvokeVoidAsync("print");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.JSInterop.IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Coursework.Data.Ticket.TicketService ticketService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Coursework.Data.Project.ProjectService projectService { get; set; }
    }
}
#pragma warning restore 1591
