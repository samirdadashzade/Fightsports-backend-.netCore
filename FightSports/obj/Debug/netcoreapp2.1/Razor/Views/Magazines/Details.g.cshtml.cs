#pragma checksum "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d2f8e95ff99a369e9dd769c64699baba29b593a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Magazines_Details), @"mvc.1.0.view", @"/Views/Magazines/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Magazines/Details.cshtml", typeof(AspNetCore.Views_Magazines_Details))]
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
#line 1 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\_ViewImports.cshtml"
using FightSports;

#line default
#line hidden
#line 2 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\_ViewImports.cshtml"
using FightSports.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d2f8e95ff99a369e9dd769c64699baba29b593a", @"/Views/Magazines/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32bfb32fa9b181d17022fed956ca4d8938b74142", @"/Views/_ViewImports.cshtml")]
    public class Views_Magazines_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FightSports.Models.Magazine>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Details.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/admin_panel.cshtml";

#line default
#line hidden
            BeginContext(130, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(159, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73cd8b648179487ba7a0d00db3646fe6", async() => {
                BeginContext(165, 89, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Details</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(261, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(263, 2171, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bb599bbf1fb4e01a35f854e19bb6534", async() => {
                BeginContext(269, 128, true);
                WriteLiteral("\r\n\r\n    <div>\r\n        <h4>Magazine</h4>\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(398, 47, false);
#line 22 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
                EndContext();
                BeginContext(445, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(501, 43, false);
#line 25 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Details.cshtml"
           Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
                EndContext();
                BeginContext(544, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(600, 50, false);
#line 28 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.MagazineAdress));

#line default
#line hidden
                EndContext();
                BeginContext(650, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(706, 46, false);
#line 31 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Details.cshtml"
           Write(Html.DisplayFor(model => model.MagazineAdress));

#line default
#line hidden
                EndContext();
                BeginContext(752, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(808, 53, false);
#line 34 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.MagazineLongitude));

#line default
#line hidden
                EndContext();
                BeginContext(861, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(917, 49, false);
#line 37 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Details.cshtml"
           Write(Html.DisplayFor(model => model.MagazineLongitude));

#line default
#line hidden
                EndContext();
                BeginContext(966, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1022, 52, false);
#line 40 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.MagazineLatitude));

#line default
#line hidden
                EndContext();
                BeginContext(1074, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1130, 48, false);
#line 43 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Details.cshtml"
           Write(Html.DisplayFor(model => model.MagazineLatitude));

#line default
#line hidden
                EndContext();
                BeginContext(1178, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1234, 46, false);
#line 46 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductTxt));

#line default
#line hidden
                EndContext();
                BeginContext(1280, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1336, 42, false);
#line 49 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Details.cshtml"
           Write(Html.DisplayFor(model => model.ProductTxt));

#line default
#line hidden
                EndContext();
                BeginContext(1378, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1434, 48, false);
#line 52 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductPrice));

#line default
#line hidden
                EndContext();
                BeginContext(1482, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1538, 44, false);
#line 55 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Details.cshtml"
           Write(Html.DisplayFor(model => model.ProductPrice));

#line default
#line hidden
                EndContext();
                BeginContext(1582, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1638, 48, false);
#line 58 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductTitle));

#line default
#line hidden
                EndContext();
                BeginContext(1686, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1742, 44, false);
#line 61 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Details.cshtml"
           Write(Html.DisplayFor(model => model.ProductTitle));

#line default
#line hidden
                EndContext();
                BeginContext(1786, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1842, 58, false);
#line 64 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.MagazineFirstPhotoPath));

#line default
#line hidden
                EndContext();
                BeginContext(1900, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1956, 54, false);
#line 67 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Details.cshtml"
           Write(Html.DisplayFor(model => model.MagazineFirstPhotoPath));

#line default
#line hidden
                EndContext();
                BeginContext(2010, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(2066, 49, false);
#line 70 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.SportCategory));

#line default
#line hidden
                EndContext();
                BeginContext(2115, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(2171, 63, false);
#line 73 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Details.cshtml"
           Write(Html.DisplayFor(model => model.SportCategory.SportCategoryName));

#line default
#line hidden
                EndContext();
                BeginContext(2234, 67, true);
                WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(2301, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4336a53bd3140148f14687687d8f892", async() => {
                    BeginContext(2355, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 78 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Details.cshtml"
                               WriteLiteral(Model.MagazineId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2363, 12, true);
                WriteLiteral(" |\r\n        ");
                EndContext();
                BeginContext(2375, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4f41cbaaf8347c3b00e9cdc9b9f24d4", async() => {
                    BeginContext(2397, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2413, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2434, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FightSports.Models.Magazine> Html { get; private set; }
    }
}
#pragma warning restore 1591
