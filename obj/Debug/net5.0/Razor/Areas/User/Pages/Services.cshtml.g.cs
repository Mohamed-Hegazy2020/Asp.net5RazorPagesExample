#pragma checksum "F:\sys programs\myGithubProfile\Asp.net5RazorPagesExample\Asp.net5RazorPagesExample\Areas\User\Pages\Services.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2249f59d64dbe314606bbf5d09d41feb3c0927a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Pages_Services), @"mvc.1.0.razor-page", @"/Areas/User/Pages/Services.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2249f59d64dbe314606bbf5d09d41feb3c0927a7", @"/Areas/User/Pages/Services.cshtml")]
    public class Areas_User_Pages_Services : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "F:\sys programs\myGithubProfile\Asp.net5RazorPagesExample\Asp.net5RazorPagesExample\Areas\User\Pages\Services.cshtml"
  
    ViewData["Title"] = "Services";
    Layout = "~/Pages/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Services</h1>\r\n\r\n");
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 57 "F:\sys programs\myGithubProfile\Asp.net5RazorPagesExample\Asp.net5RazorPagesExample\Areas\User\Pages\Services.cshtml"
     foreach (var item in Model.Service)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card m-1\" style=\"width: 18rem;\">\r\n            <img class=\"card-img-top\" src=\"...\" alt=\"Card image cap\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 62 "F:\sys programs\myGithubProfile\Asp.net5RazorPagesExample\Asp.net5RazorPagesExample\Areas\User\Pages\Services.cshtml"
                                  Write(item.NameAr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 63 "F:\sys programs\myGithubProfile\Asp.net5RazorPagesExample\Asp.net5RazorPagesExample\Areas\User\Pages\Services.cshtml"
                                Write(item.DescriptionAr);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n                <a href=\"#\" class=\"btn btn-primary\">Go somewhere</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 67 "F:\sys programs\myGithubProfile\Asp.net5RazorPagesExample\Asp.net5RazorPagesExample\Areas\User\Pages\Services.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Asp.net5RazorPagesExample.Areas.User.Pages.ServicesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Asp.net5RazorPagesExample.Areas.User.Pages.ServicesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Asp.net5RazorPagesExample.Areas.User.Pages.ServicesModel>)PageContext?.ViewData;
        public Asp.net5RazorPagesExample.Areas.User.Pages.ServicesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591