#pragma checksum "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b8597be5579884d4883276db87aa564848f6d9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Magazines_Delete), @"mvc.1.0.view", @"/Views/Magazines/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Magazines/Delete.cshtml", typeof(AspNetCore.Views_Magazines_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b8597be5579884d4883276db87aa564848f6d9b", @"/Views/Magazines/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32bfb32fa9b181d17022fed956ca4d8938b74142", @"/Views/_ViewImports.cshtml")]
    public class Views_Magazines_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FightSports.Models.Magazine>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/admin_panel.cshtml";

#line default
#line hidden
            BeginContext(130, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(159, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "419374f828d3448781d1fe2b1e9e949f", async() => {
                BeginContext(165, 88, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Delete</title>\r\n");
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
            BeginContext(260, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(262, 2321, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c8c0e56e7114e2ba43132de9b5dfb62", async() => {
                BeginContext(268, 180, true);
                WriteLiteral("\r\n\r\n    <h3>Are you sure you want to delete this?</h3>\r\n    <div>\r\n        <h4>Magazine</h4>\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(449, 47, false);
#line 23 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
                EndContext();
                BeginContext(496, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(552, 43, false);
#line 26 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
                EndContext();
                BeginContext(595, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(651, 50, false);
#line 29 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.MagazineAdress));

#line default
#line hidden
                EndContext();
                BeginContext(701, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(757, 46, false);
#line 32 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayFor(model => model.MagazineAdress));

#line default
#line hidden
                EndContext();
                BeginContext(803, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(859, 53, false);
#line 35 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.MagazineLongitude));

#line default
#line hidden
                EndContext();
                BeginContext(912, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(968, 49, false);
#line 38 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayFor(model => model.MagazineLongitude));

#line default
#line hidden
                EndContext();
                BeginContext(1017, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1073, 52, false);
#line 41 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.MagazineLatitude));

#line default
#line hidden
                EndContext();
                BeginContext(1125, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1181, 48, false);
#line 44 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayFor(model => model.MagazineLatitude));

#line default
#line hidden
                EndContext();
                BeginContext(1229, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1285, 46, false);
#line 47 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductTxt));

#line default
#line hidden
                EndContext();
                BeginContext(1331, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1387, 42, false);
#line 50 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayFor(model => model.ProductTxt));

#line default
#line hidden
                EndContext();
                BeginContext(1429, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1485, 48, false);
#line 53 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductPrice));

#line default
#line hidden
                EndContext();
                BeginContext(1533, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1589, 44, false);
#line 56 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayFor(model => model.ProductPrice));

#line default
#line hidden
                EndContext();
                BeginContext(1633, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1689, 48, false);
#line 59 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductTitle));

#line default
#line hidden
                EndContext();
                BeginContext(1737, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1793, 44, false);
#line 62 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayFor(model => model.ProductTitle));

#line default
#line hidden
                EndContext();
                BeginContext(1837, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1893, 58, false);
#line 65 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.MagazineFirstPhotoPath));

#line default
#line hidden
                EndContext();
                BeginContext(1951, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(2007, 54, false);
#line 68 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayFor(model => model.MagazineFirstPhotoPath));

#line default
#line hidden
                EndContext();
                BeginContext(2061, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(2117, 49, false);
#line 71 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.SportCategory));

#line default
#line hidden
                EndContext();
                BeginContext(2166, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(2222, 63, false);
#line 74 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayFor(model => model.SportCategory.SportCategoryName));

#line default
#line hidden
                EndContext();
                BeginContext(2285, 46, true);
                WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n\r\n        ");
                EndContext();
                BeginContext(2331, 231, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12b1d04227914460b2e332f61d58ae2a", async() => {
                    BeginContext(2357, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(2371, 44, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0fb18ecdfa0e44ee80650a31dc7ed092", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 79 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MagazineId);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2415, 92, true);
                    WriteLiteral("\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n            ");
                    EndContext();
                    BeginContext(2507, 38, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49119bec3d884421b178803bc9595f91", async() => {
                        BeginContext(2529, 12, true);
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
                    BeginContext(2545, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2562, 14, true);
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
            BeginContext(2583, 11, true);
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
