#pragma checksum "E:\ISMProject\ISM_ToDo\ISM_ToDo\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21442bd042126c4f8e1c42d1579952e07cbed5c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "E:\ISMProject\ISM_ToDo\ISM_ToDo\Views\_ViewImports.cshtml"
using ISM_ToDo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ISMProject\ISM_ToDo\ISM_ToDo\Views\_ViewImports.cshtml"
using ISM_ToDo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21442bd042126c4f8e1c42d1579952e07cbed5c1", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce2f9df620cc85794c1114f3500161c6547c7325", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ISM_ToDo.Models.Affair>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\ISMProject\ISM_ToDo\ISM_ToDo\Views\Home\Details.cshtml"
  
    ViewBag.Title = Model.Task;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Пользователь ");
#nullable restore
#line 5 "E:\ISMProject\ISM_ToDo\ISM_ToDo\Views\Home\Details.cshtml"
            Write(Model.Task);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<div>\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>Идентификатор</dt>\r\n        <dd>");
#nullable restore
#line 9 "E:\ISMProject\ISM_ToDo\ISM_ToDo\Views\Home\Details.cshtml"
       Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n");
            WriteLiteral("    </dl>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ISM_ToDo.Models.Affair> Html { get; private set; }
    }
}
#pragma warning restore 1591
