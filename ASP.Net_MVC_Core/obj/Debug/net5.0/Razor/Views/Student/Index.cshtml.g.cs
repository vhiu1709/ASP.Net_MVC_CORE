#pragma checksum "G:\LeVanHieu-2200005488\ASP.Net_MVC_Core\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13ff60fe9fdc1bee41a50579516618f46ed35c4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
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
#line 1 "G:\LeVanHieu-2200005488\ASP.Net_MVC_Core\Views\_ViewImports.cshtml"
using ASP.Net_MVC_Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\LeVanHieu-2200005488\ASP.Net_MVC_Core\Views\_ViewImports.cshtml"
using ASP.Net_MVC_Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13ff60fe9fdc1bee41a50579516618f46ed35c4e", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4249edee1c5401150d5a65e7fd6d65bf92b5a3f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ASP.Net_MVC_Core.Models.Student>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container"">
    <div class=""row list_container"">
        <div class=""title col-12"">Danh sách sinh viên </div>
        <div>Tìm theo mã sinh viêm :  </div>
        <div class=""data_grid col-12"">
            <table>
                <tr>
                    <th>Mã SV</th>
                    <th>Họ và tên</th>
                    <th>Ngày sinh</th>
                    <th>Địa chỉ</th>
                </tr>
");
#nullable restore
#line 14 "G:\LeVanHieu-2200005488\ASP.Net_MVC_Core\Views\Student\Index.cshtml"
                  
                    if (Model != null && Model.Any())
                    {
                        foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 20 "G:\LeVanHieu-2200005488\ASP.Net_MVC_Core\Views\Student\Index.cshtml"
                               Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 21 "G:\LeVanHieu-2200005488\ASP.Net_MVC_Core\Views\Student\Index.cshtml"
                               Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 22 "G:\LeVanHieu-2200005488\ASP.Net_MVC_Core\Views\Student\Index.cshtml"
                               Write(item.birthday.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 23 "G:\LeVanHieu-2200005488\ASP.Net_MVC_Core\Views\Student\Index.cshtml"
                               Write(item.address_full);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 25 "G:\LeVanHieu-2200005488\ASP.Net_MVC_Core\Views\Student\Index.cshtml"
                        }
                    }

                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n        </div>\r\n\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ASP.Net_MVC_Core.Models.Student>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
