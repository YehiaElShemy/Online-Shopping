#pragma checksum "C:\Users\yehia\source\repos\OnlineShopingStore\OnlineShopingStore\Areas\Admin\Views\SpecialTag\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfb13a3ff1c0cfa7c5dfdb95ccd9925ef091bf77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SpecialTag_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/SpecialTag/Index.cshtml")]
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
#line 1 "C:\Users\yehia\source\repos\OnlineShopingStore\OnlineShopingStore\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineShopingStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yehia\source\repos\OnlineShopingStore\OnlineShopingStore\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineShopingStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfb13a3ff1c0cfa7c5dfdb95ccd9925ef091bf77", @"/Areas/Admin/Views/SpecialTag/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af9befcb0fbd8a449b476bc8098a6343fa392c3f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_SpecialTag_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineShopingStore.Models.SpecialTag>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Partial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<br />\r\n<br />\r\n<div class=\"row \">\r\n    <div class=\"Col-6\">\r\n        <h2 class=\" text-info\">SpecialTag List</h2>\r\n    </div>\r\n    <div class=\"Col-6  btn-lg float-right\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfb13a3ff1c0cfa7c5dfdb95ccd9925ef091bf774563", async() => {
                WriteLiteral("&nbsp; New Product Type");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<br />\r\n<div>\r\n    <table class=\"table table-striped\">\r\n        <thead>\r\n            <tr>\r\n                <th>");
#nullable restore
#line 17 "C:\Users\yehia\source\repos\OnlineShopingStore\OnlineShopingStore\Areas\Admin\Views\SpecialTag\Index.cshtml"
               Write(Html.DisplayNameFor(p => p.SpecialTagType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 21 "C:\Users\yehia\source\repos\OnlineShopingStore\OnlineShopingStore\Areas\Admin\Views\SpecialTag\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\yehia\source\repos\OnlineShopingStore\OnlineShopingStore\Areas\Admin\Views\SpecialTag\Index.cshtml"
                   Write(item.SpecialTagType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bfb13a3ff1c0cfa7c5dfdb95ccd9925ef091bf776951", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 26 "C:\Users\yehia\source\repos\OnlineShopingStore\OnlineShopingStore\Areas\Admin\Views\SpecialTag\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 29 "C:\Users\yehia\source\repos\OnlineShopingStore\OnlineShopingStore\Areas\Admin\Views\SpecialTag\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"//cdn.jsdelivr.net/npm/alertifyjs@1.13.1/build/alertify.min.js\"></script>\r\n    <script type=\"text/javascript\">\r\n        $(function () {\r\n            var Save = \'");
#nullable restore
#line 39 "C:\Users\yehia\source\repos\OnlineShopingStore\OnlineShopingStore\Areas\Admin\Views\SpecialTag\Index.cshtml"
                   Write(TempData["Save"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n            console.log(Save)\r\n            if (Save != \'\') {\r\n                alertify.success(Save)\r\n            }\r\n            var Edit = \'");
#nullable restore
#line 44 "C:\Users\yehia\source\repos\OnlineShopingStore\OnlineShopingStore\Areas\Admin\Views\SpecialTag\Index.cshtml"
                   Write(TempData["Edit"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n            console.log(Edit)\r\n            if (Edit != \'\') {\r\n                alertify.message(Edit)\r\n            }\r\n            var Remove = \'");
#nullable restore
#line 49 "C:\Users\yehia\source\repos\OnlineShopingStore\OnlineShopingStore\Areas\Admin\Views\SpecialTag\Index.cshtml"
                     Write(TempData["Remove"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n            console.log(Remove)\r\n            if (Remove != \'\') {\r\n                alertify.error(Remove)\r\n            }\r\n        })\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineShopingStore.Models.SpecialTag>> Html { get; private set; }
    }
}
#pragma warning restore 1591
