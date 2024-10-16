#pragma checksum "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f74871a27c0ef9b8643cfd3e03a27df7e7c83690"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_en_Index), @"mvc.1.0.view", @"/Views/Employee/en/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\_ViewImports.cshtml"
using HrSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\_ViewImports.cshtml"
using HrSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f74871a27c0ef9b8643cfd3e03a27df7e7c83690", @"/Views/Employee/en/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c400f7145c886ca6899f3334292d2f6d3f90f9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_en_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HrSystem.Models.EmployeeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Index.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Index</h2>

<p>
    <button class=""btn btn-primary"" onclick=""NewEmployee();"">Create New</button>
</p>
<table class=""table table-bordered table-striped table-hover"">
    <thead>
        <tr>
            <th>
                id
            </th>
            <th>
                name
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 23 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Index.cshtml"
         foreach (var item in Model.Employees)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>\n        ");
#nullable restore
#line 27 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 30 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.First_Name_En));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 33 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Index.cshtml"
   Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n        ");
#nullable restore
#line 34 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Index.cshtml"
   Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n        ");
#nullable restore
#line 35 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Index.cshtml"
   Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n</tr>");
#nullable restore
#line 37 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
            WriteLiteral(@"<div id=""form-modal"" class=""modal fade"" tabindex=""-1"" aria-hidden=""true"" role=""dialog"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Add New Employee</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div id=""EmployeeContent"" class=""modal-body"">

            </div>
        </div>
    </div>
</div>
");
            WriteLiteral("\n<script>\n    function NewEmployee() {\n        $.ajax({\n\n            url: \'");
#nullable restore
#line 62 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Index.cshtml"
             Write(Url.Action("Create", "Employee"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\n            datatype: \"text\",\n            type: \"Get\",\n            success: function (data) {\n                $(\'#EmployeeContent\').html(data);\n                $(\'#form-modal\').modal(\'show\');\n            },\n        });\n    }\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HrSystem.Models.EmployeeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
