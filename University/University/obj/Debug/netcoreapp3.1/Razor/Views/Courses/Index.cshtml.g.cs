#pragma checksum "C:\Users\admin\C#projects\FoxmindedProjects\ASP.NET Core MVC\University\University\Views\Courses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e76c11979dfd972f15efd14afb81fd7788aa7419"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Index), @"mvc.1.0.view", @"/Views/Courses/Index.cshtml")]
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
#line 1 "C:\Users\admin\C#projects\FoxmindedProjects\ASP.NET Core MVC\University\University\Views\_ViewImports.cshtml"
using University;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\C#projects\FoxmindedProjects\ASP.NET Core MVC\University\University\Views\_ViewImports.cshtml"
using University.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e76c11979dfd972f15efd14afb81fd7788aa7419", @"/Views/Courses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e04dcc244e1469154104359d31508023c653ccb7", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Course>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\admin\C#projects\FoxmindedProjects\ASP.NET Core MVC\University\University\Views\Courses\Index.cshtml"
  
    ViewBag.Title = "Курсы";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Курсы</h2>\r\n<div class=\"table-section\">\r\n");
#nullable restore
#line 10 "C:\Users\admin\C#projects\FoxmindedProjects\ASP.NET Core MVC\University\University\Views\Courses\Index.cshtml"
     if (@Model.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Курсов ещё нет</p>\r\n");
#nullable restore
#line 13 "C:\Users\admin\C#projects\FoxmindedProjects\ASP.NET Core MVC\University\University\Views\Courses\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table style=\"width: 100%\">\r\n            <tr>\r\n                <th>Название</th>\r\n                <th>Описание</th>\r\n            </tr>\r\n");
#nullable restore
#line 21 "C:\Users\admin\C#projects\FoxmindedProjects\ASP.NET Core MVC\University\University\Views\Courses\Index.cshtml"
             foreach (var course in @Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 25 "C:\Users\admin\C#projects\FoxmindedProjects\ASP.NET Core MVC\University\University\Views\Courses\Index.cshtml"
                   Write(Html.ActionLink($"{course.Name}", "ShowGroups", "Courses", new { id = @course.CourseId}, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\admin\C#projects\FoxmindedProjects\ASP.NET Core MVC\University\University\Views\Courses\Index.cshtml"
                   Write(course.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 29 "C:\Users\admin\C#projects\FoxmindedProjects\ASP.NET Core MVC\University\University\Views\Courses\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
#nullable restore
#line 31 "C:\Users\admin\C#projects\FoxmindedProjects\ASP.NET Core MVC\University\University\Views\Courses\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591