#pragma checksum "C:\Users\josep\source\repos\InsuranceClaimsLossTypes\InsuranceClaimsLossTypes\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce7e4c3169487c2443d13582a04e78a78c102e8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\josep\source\repos\InsuranceClaimsLossTypes\InsuranceClaimsLossTypes\Views\_ViewImports.cshtml"
using InsuranceClaimsLossTypes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\josep\source\repos\InsuranceClaimsLossTypes\InsuranceClaimsLossTypes\Views\_ViewImports.cshtml"
using InsuranceClaimsLossTypes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce7e4c3169487c2443d13582a04e78a78c102e8b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e4610d07f0916f74ec6eed8726f98685e8004c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\josep\source\repos\InsuranceClaimsLossTypes\InsuranceClaimsLossTypes\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\"padding: 0 20px 0 20px;\">\r\n    <h1 class=\"display-4\">Login</h1>\r\n");
#nullable restore
#line 8 "C:\Users\josep\source\repos\InsuranceClaimsLossTypes\InsuranceClaimsLossTypes\Views\Home\Index.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"text\" placeholder=\"Username\" name=\"userName\" />\r\n        <input type=\"password\" placeholder=\"Password\" name=\"passWord\" />\r\n        <input type=\"submit\" />\r\n");
#nullable restore
#line 13 "C:\Users\josep\source\repos\InsuranceClaimsLossTypes\InsuranceClaimsLossTypes\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"text-black-50\">");
#nullable restore
#line 14 "C:\Users\josep\source\repos\InsuranceClaimsLossTypes\InsuranceClaimsLossTypes\Views\Home\Index.cshtml"
                        Write(ViewData["Feedback"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
