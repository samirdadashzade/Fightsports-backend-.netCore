#pragma checksum "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efd56f3bde20ae76d3b4c32b92c6a1620ba904df"
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
#line 1 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\_ViewImports.cshtml"
using FightSports;

#line default
#line hidden
#line 2 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\_ViewImports.cshtml"
using FightSports.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efd56f3bde20ae76d3b4c32b92c6a1620ba904df", @"/Views/Magazines/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32bfb32fa9b181d17022fed956ca4d8938b74142", @"/Views/_ViewImports.cshtml")]
    public class Views_Magazines_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FightSports.Models.Magazine>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/admin_panel.cshtml";

#line default
#line hidden
            BeginContext(130, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(159, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d931b43c34d34106a20a531d6099389c", async() => {
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
            BeginContext(262, 3242, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7f57414fdab4d54900946286d9160ec", async() => {
                BeginContext(268, 180, true);
                WriteLiteral("\r\n\r\n    <h3>Are you sure you want to delete this?</h3>\r\n    <div>\r\n        <h4>Magazine</h4>\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(449, 47, false);
#line 23 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
                EndContext();
                BeginContext(496, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(552, 43, false);
#line 26 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
                EndContext();
                BeginContext(595, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(651, 50, false);
#line 29 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.MagazineAdress));

#line default
#line hidden
                EndContext();
                BeginContext(701, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(757, 46, false);
#line 32 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayFor(model => model.MagazineAdress));

#line default
#line hidden
                EndContext();
                BeginContext(803, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(859, 53, false);
#line 35 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.MagazineLongitude));

#line default
#line hidden
                EndContext();
                BeginContext(912, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(968, 49, false);
#line 38 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayFor(model => model.MagazineLongitude));

#line default
#line hidden
                EndContext();
                BeginContext(1017, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1073, 52, false);
#line 41 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.MagazineLatitude));

#line default
#line hidden
                EndContext();
                BeginContext(1125, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1181, 48, false);
#line 44 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayFor(model => model.MagazineLatitude));

#line default
#line hidden
                EndContext();
                BeginContext(1229, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1285, 46, false);
#line 47 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductTxt));

#line default
#line hidden
                EndContext();
                BeginContext(1331, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1387, 42, false);
#line 50 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayFor(model => model.ProductTxt));

#line default
#line hidden
                EndContext();
                BeginContext(1429, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1485, 48, false);
#line 53 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductPrice));

#line default
#line hidden
                EndContext();
                BeginContext(1533, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1589, 44, false);
#line 56 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayFor(model => model.ProductPrice));

#line default
#line hidden
                EndContext();
                BeginContext(1633, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1689, 48, false);
#line 59 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductTitle));

#line default
#line hidden
                EndContext();
                BeginContext(1737, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1793, 44, false);
#line 62 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayFor(model => model.ProductTitle));

#line default
#line hidden
                EndContext();
                BeginContext(1837, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1893, 58, false);
#line 65 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.MagazineFirstPhotoPath));

#line default
#line hidden
                EndContext();
                BeginContext(1951, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(2007, 54, false);
#line 68 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayFor(model => model.MagazineFirstPhotoPath));

#line default
#line hidden
                EndContext();
                BeginContext(2061, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(2117, 59, false);
#line 71 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.MagazineSecondPhotoPath));

#line default
#line hidden
                EndContext();
                BeginContext(2176, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(2232, 55, false);
#line 74 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayFor(model => model.MagazineSecondPhotoPath));

#line default
#line hidden
                EndContext();
                BeginContext(2287, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(2343, 58, false);
#line 77 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.MagazineThirdPhotoPath));

#line default
#line hidden
                EndContext();
                BeginContext(2401, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(2457, 54, false);
#line 80 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayFor(model => model.MagazineThirdPhotoPath));

#line default
#line hidden
                EndContext();
                BeginContext(2511, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(2567, 59, false);
#line 83 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.MagazineFourthPhotoPath));

#line default
#line hidden
                EndContext();
                BeginContext(2626, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(2682, 55, false);
#line 86 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayFor(model => model.MagazineFourthPhotoPath));

#line default
#line hidden
                EndContext();
                BeginContext(2737, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(2793, 58, false);
#line 89 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.MagazineFifthPhotoPath));

#line default
#line hidden
                EndContext();
                BeginContext(2851, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(2907, 54, false);
#line 92 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayFor(model => model.MagazineFifthPhotoPath));

#line default
#line hidden
                EndContext();
                BeginContext(2961, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(3017, 49, false);
#line 95 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.SportCategory));

#line default
#line hidden
                EndContext();
                BeginContext(3066, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(3122, 63, false);
#line 98 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
           Write(Html.DisplayFor(model => model.SportCategory.SportCategoryName));

#line default
#line hidden
                EndContext();
                BeginContext(3185, 46, true);
                WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n\r\n        ");
                EndContext();
                BeginContext(3231, 252, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3f2d412fb054d848c4a6893d8885577", async() => {
                    BeginContext(3257, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(3271, 44, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "93ef51e123944760b600362b7a7f1ac7", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 103 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Magazines\Delete.cshtml"
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
                    BeginContext(3315, 92, true);
                    WriteLiteral("\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-success\" /> |\r\n            ");
                    EndContext();
                    BeginContext(3407, 59, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7bb399d349a4188981df3c09efd5a61", async() => {
                        BeginContext(3450, 12, true);
                        WriteLiteral("Back to List");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(3466, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3483, 14, true);
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
            BeginContext(3504, 11, true);
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
