#pragma checksum "C:\Users\yehia\source\repos\OnlineShopingStore\OnlineShopingStore\Areas\Admin\Views\Role\AssignUserRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "347938821cdcb00285e8e4f8eb86ea543525d59a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Role_AssignUserRole), @"mvc.1.0.view", @"/Areas/Admin/Views/Role/AssignUserRole.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"347938821cdcb00285e8e4f8eb86ea543525d59a", @"/Areas/Admin/Views/Role/AssignUserRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af9befcb0fbd8a449b476bc8098a6343fa392c3f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Role_AssignUserRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Role", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/DataTable_file.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<br />\r\n<br />\r\n<div class=\"row \">\r\n    <div class=\"Col-6\">\r\n        <h2 class=\" text-info\">User List</h2>\r\n    </div>\r\n    <div class=\"Col-6  btn-lg float-right\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "347938821cdcb00285e8e4f8eb86ea543525d59a5218", async() => {
                WriteLiteral("&nbsp; Add New Role");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div>\r\n    <table class=\"table table-striped \" id=\"myTable\">\r\n        <thead>\r\n            <tr>\r\n                <th>Name</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 20 "C:\Users\yehia\source\repos\OnlineShopingStore\OnlineShopingStore\Areas\Admin\Views\Role\AssignUserRole.cshtml"
             foreach (var item in ViewBag.UserRole)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                <td>");
#nullable restore
#line 24 "C:\Users\yehia\source\repos\OnlineShopingStore\OnlineShopingStore\Areas\Admin\Views\Role\AssignUserRole.cshtml"
               Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\yehia\source\repos\OnlineShopingStore\OnlineShopingStore\Areas\Admin\Views\Role\AssignUserRole.cshtml"
               Write(item.RoleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
            WriteLiteral("\r\n                 </tr>\r\n");
#nullable restore
#line 36 "C:\Users\yehia\source\repos\OnlineShopingStore\OnlineShopingStore\Areas\Admin\Views\Role\AssignUserRole.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "347938821cdcb00285e8e4f8eb86ea543525d59a8488", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script src=""//cdn.jsdelivr.net/npm/alertifyjs@1.13.1/build/alertify.min.js""></script>
    <script type=""text/javascript"">
        $(document).ready(function () {
            $(""#myTable"").DataTable();
        });
        $(function () {
            var Save = '");
#nullable restore
#line 52 "C:\Users\yehia\source\repos\OnlineShopingStore\OnlineShopingStore\Areas\Admin\Views\Role\AssignUserRole.cshtml"
                   Write(TempData["Save"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n            console.log(Save)\r\n            if (Save != \'\') {\r\n                alertify.success(Save)\r\n            }\r\n            var Edit = \'");
#nullable restore
#line 57 "C:\Users\yehia\source\repos\OnlineShopingStore\OnlineShopingStore\Areas\Admin\Views\Role\AssignUserRole.cshtml"
                   Write(TempData["update"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n            console.log(Edit)\r\n            if (Edit != \'\') {\r\n                alertify.message(Edit)\r\n            }\r\n            var Active = \'");
#nullable restore
#line 62 "C:\Users\yehia\source\repos\OnlineShopingStore\OnlineShopingStore\Areas\Admin\Views\Role\AssignUserRole.cshtml"
                     Write(TempData["Active"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n            console.log(Active)\r\n            if (Edit != \'\') {\r\n                alertify.Active(Active)\r\n            }\r\n            var Remove = \'");
#nullable restore
#line 67 "C:\Users\yehia\source\repos\OnlineShopingStore\OnlineShopingStore\Areas\Admin\Views\Role\AssignUserRole.cshtml"
                     Write(TempData["Remove"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n            console.log(Remove)\r\n            if (Remove != \'\') {\r\n                alertify.error(Remove)\r\n            }\r\n        })\r\n    </script>");
#nullable restore
#line 73 "C:\Users\yehia\source\repos\OnlineShopingStore\OnlineShopingStore\Areas\Admin\Views\Role\AssignUserRole.cshtml"
                await Html.RenderPartialAsync("_ValidationScriptsPartial.cshtml");
    

#line default
#line hidden
#nullable disable
            }
            );
            WriteLiteral("\r\n");
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