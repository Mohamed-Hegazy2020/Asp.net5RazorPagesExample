#pragma checksum "F:\sys programs\myGithubProfile\Asp.net5RazorPagesExample\Asp.net5RazorPagesExample\Areas\User\Pages\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d6c9b6b4402575a694f66a40163614b5c96ecac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Pages_Home), @"mvc.1.0.razor-page", @"/Areas/User/Pages/Home.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d6c9b6b4402575a694f66a40163614b5c96ecac", @"/Areas/User/Pages/Home.cshtml")]
    public class Areas_User_Pages_Home : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "F:\sys programs\myGithubProfile\Asp.net5RazorPagesExample\Asp.net5RazorPagesExample\Areas\User\Pages\Home.cshtml"
  
    ViewData["Title"] = "Home";
    Layout = "~/Pages/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Home</h1>\r\n\r\n<div>\r\n    <h4>CompanyMainData</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "F:\sys programs\myGithubProfile\Asp.net5RazorPagesExample\Asp.net5RazorPagesExample\Areas\User\Pages\Home.cshtml"
       Write(Html.DisplayNameFor(model => model.CompanyMainData.NameAr));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "F:\sys programs\myGithubProfile\Asp.net5RazorPagesExample\Asp.net5RazorPagesExample\Areas\User\Pages\Home.cshtml"
       Write(Html.DisplayFor(model => model.CompanyMainData.NameAr));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "F:\sys programs\myGithubProfile\Asp.net5RazorPagesExample\Asp.net5RazorPagesExample\Areas\User\Pages\Home.cshtml"
       Write(Html.DisplayNameFor(model => model.CompanyMainData.NameEn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "F:\sys programs\myGithubProfile\Asp.net5RazorPagesExample\Asp.net5RazorPagesExample\Areas\User\Pages\Home.cshtml"
       Write(Html.DisplayFor(model => model.CompanyMainData.NameEn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "F:\sys programs\myGithubProfile\Asp.net5RazorPagesExample\Asp.net5RazorPagesExample\Areas\User\Pages\Home.cshtml"
       Write(Html.DisplayNameFor(model => model.CompanyMainData.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "F:\sys programs\myGithubProfile\Asp.net5RazorPagesExample\Asp.net5RazorPagesExample\Areas\User\Pages\Home.cshtml"
       Write(Html.DisplayFor(model => model.CompanyMainData.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "F:\sys programs\myGithubProfile\Asp.net5RazorPagesExample\Asp.net5RazorPagesExample\Areas\User\Pages\Home.cshtml"
       Write(Html.DisplayNameFor(model => model.CompanyMainData.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "F:\sys programs\myGithubProfile\Asp.net5RazorPagesExample\Asp.net5RazorPagesExample\Areas\User\Pages\Home.cshtml"
       Write(Html.DisplayFor(model => model.CompanyMainData.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "F:\sys programs\myGithubProfile\Asp.net5RazorPagesExample\Asp.net5RazorPagesExample\Areas\User\Pages\Home.cshtml"
       Write(Html.DisplayNameFor(model => model.CompanyMainData.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "F:\sys programs\myGithubProfile\Asp.net5RazorPagesExample\Asp.net5RazorPagesExample\Areas\User\Pages\Home.cshtml"
       Write(Html.DisplayFor(model => model.CompanyMainData.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-page=\"./Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1474, "\"", 1514, 1);
#nullable restore
#line 48 "F:\sys programs\myGithubProfile\Asp.net5RazorPagesExample\Asp.net5RazorPagesExample\Areas\User\Pages\Home.cshtml"
WriteAttributeValue("", 1489, Model.CompanyMainData.Id, 1489, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-page=\"./Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Asp.net5RazorPagesExample.Areas.User.Pages.HomeModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Asp.net5RazorPagesExample.Areas.User.Pages.HomeModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Asp.net5RazorPagesExample.Areas.User.Pages.HomeModel>)PageContext?.ViewData;
        public Asp.net5RazorPagesExample.Areas.User.Pages.HomeModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
