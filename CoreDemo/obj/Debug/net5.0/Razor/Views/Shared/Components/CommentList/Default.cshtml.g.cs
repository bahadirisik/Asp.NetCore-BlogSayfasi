#pragma checksum "D:\Asp.Net Tutos\Asp.net Core Demo\CoreDemo\CoreDemo\Views\Shared\Components\CommentList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af9d4f441900259202dd118f0aa99ce128c329e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CommentList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CommentList/Default.cshtml")]
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
#line 1 "D:\Asp.Net Tutos\Asp.net Core Demo\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Asp.Net Tutos\Asp.net Core Demo\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af9d4f441900259202dd118f0aa99ce128c329e7", @"/Views/Shared/Components/CommentList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CommentList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreDemo.Models.UserComment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Asp.Net Tutos\Asp.net Core Demo\CoreDemo\CoreDemo\Views\Shared\Components\CommentList\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 5 "D:\Asp.Net Tutos\Asp.net Core Demo\CoreDemo\CoreDemo\Views\Shared\Components\CommentList\Default.cshtml"
  Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 6 "D:\Asp.Net Tutos\Asp.net Core Demo\CoreDemo\CoreDemo\Views\Shared\Components\CommentList\Default.cshtml"
  Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 7 "D:\Asp.Net Tutos\Asp.net Core Demo\CoreDemo\CoreDemo\Views\Shared\Components\CommentList\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreDemo.Models.UserComment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
