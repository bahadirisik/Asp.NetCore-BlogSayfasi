#pragma checksum "D:\Asp.Net Tutos\Asp.net Core Demo\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cf61052caa94629a08d08df59efc63062a2393e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogAdd), @"mvc.1.0.view", @"/Views/Blog/BlogAdd.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cf61052caa94629a08d08df59efc63062a2393e", @"/Views/Blog/BlogAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Asp.Net Tutos\Asp.net Core Demo\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
  
    ViewData["Title"] = "BlogAdd";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Yeni Blog Girişi</h1>\r\n\r\n<br />\r\n");
#nullable restore
#line 11 "D:\Asp.Net Tutos\Asp.net Core Demo\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
 using (Html.BeginForm("BlogAdd", "Blog", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Asp.Net Tutos\Asp.net Core Demo\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Asp.Net Tutos\Asp.net Core Demo\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.TextBoxFor(x => x.BlogTitle, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Asp.Net Tutos\Asp.net Core Demo\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.BlogTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 17 "D:\Asp.Net Tutos\Asp.net Core Demo\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog Görseli"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Asp.Net Tutos\Asp.net Core Demo\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.TextBoxFor(x => x.BlogImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Asp.Net Tutos\Asp.net Core Demo\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.BlogImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 21 "D:\Asp.Net Tutos\Asp.net Core Demo\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog Küçük Görsel"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Asp.Net Tutos\Asp.net Core Demo\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.TextBoxFor(x => x.BlogThumbnailImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 24 "D:\Asp.Net Tutos\Asp.net Core Demo\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Kategori"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Asp.Net Tutos\Asp.net Core Demo\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.DropDownListFor(x => x.CategoryID, (List<SelectListItem>)ViewBag.cv, new {@class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 27 "D:\Asp.Net Tutos\Asp.net Core Demo\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog İçeriği"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\Asp.Net Tutos\Asp.net Core Demo\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.TextAreaFor(x => x.BlogContent,15, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\Asp.Net Tutos\Asp.net Core Demo\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.BlogContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-success\">Bloğu Kaydet</button>\r\n");
#nullable restore
#line 33 "D:\Asp.Net Tutos\Asp.net Core Demo\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
