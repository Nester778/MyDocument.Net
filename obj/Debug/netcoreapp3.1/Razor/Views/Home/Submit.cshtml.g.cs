#pragma checksum "C:\Users\anest\source\repos\MyDocument4\MyDocument4\Views\Home\Submit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56d87f6d3a20f281d66519128fc0cbd327963f98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Submit), @"mvc.1.0.view", @"/Views/Home/Submit.cshtml")]
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
#line 1 "C:\Users\anest\source\repos\MyDocument4\MyDocument4\Views\_ViewImports.cshtml"
using MyDocument4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anest\source\repos\MyDocument4\MyDocument4\Views\_ViewImports.cshtml"
using MyDocument4.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\anest\source\repos\MyDocument4\MyDocument4\Views\Home\Submit.cshtml"
using MyDocument4.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56d87f6d3a20f281d66519128fc0cbd327963f98", @"/Views/Home/Submit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"495221e4b6bb83e6f6801ff76e156ec37e0cecf6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Submit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyDocument4.Domain.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\anest\source\repos\MyDocument4\MyDocument4\Views\Home\Submit.cshtml"
  
    ViewData["Title"] = "Submit Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-wrapper"">
    <section class=""registration-section"">
        <div class=""registration-form-wrapper"">

            <div class=""form-card flex-column"">
                <div class=""form-wrapper"">


                    <h2 class=""form-title"">
                        Ви успішно
                        <span id=""text-to-change"">Зареєструвалися</span>
                    </h2>

                    <p class=""form-card-text"">Місце в черзі: ");
#nullable restore
#line 20 "C:\Users\anest\source\repos\MyDocument4\MyDocument4\Views\Home\Submit.cshtml"
                                                        Write(Model.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"form-card-text\">Ім\'я: ");
#nullable restore
#line 21 "C:\Users\anest\source\repos\MyDocument4\MyDocument4\Views\Home\Submit.cshtml"
                                               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"form-card-text\">Телефон: ");
#nullable restore
#line 22 "C:\Users\anest\source\repos\MyDocument4\MyDocument4\Views\Home\Submit.cshtml"
                                                  Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"form-card-text\">Планета: ");
#nullable restore
#line 23 "C:\Users\anest\source\repos\MyDocument4\MyDocument4\Views\Home\Submit.cshtml"
                                                  Write(Model.Planet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyDocument4.Domain.User> Html { get; private set; }
    }
}
#pragma warning restore 1591