#pragma checksum "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\News\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a521f726e596ddd7c29cf0591ee2bff0505b1437"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Delete), @"mvc.1.0.view", @"/Views/News/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/News/Delete.cshtml", typeof(AspNetCore.Views_News_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a521f726e596ddd7c29cf0591ee2bff0505b1437", @"/Views/News/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32bfb32fa9b181d17022fed956ca4d8938b74142", @"/Views/_ViewImports.cshtml")]
    public class Views_News_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FightSports.Models.News>
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
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\News\Delete.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/admin_panel.cshtml";

#line default
#line hidden
            BeginContext(126, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(155, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37af5c87b6a0403fb0cb0d22db3d5dd6", async() => {
                BeginContext(161, 88, true);
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
            BeginContext(256, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(258, 3116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "faea55487cf244a7be35592dd0875727", async() => {
                BeginContext(264, 176, true);
                WriteLiteral("\r\n\r\n    <h3>Are you sure you want to delete this?</h3>\r\n    <div>\r\n        <h4>News</h4>\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(441, 44, false);
#line 23 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\News\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.NewsName));

#line default
#line hidden
                EndContext();
                BeginContext(485, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(541, 40, false);
#line 26 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\News\Delete.cshtml"
           Write(Html.DisplayFor(model => model.NewsName));

#line default
#line hidden
                EndContext();
                BeginContext(581, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(637, 45, false);
#line 29 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\News\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.NewsTitle));

#line default
#line hidden
                EndContext();
                BeginContext(682, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(738, 41, false);
#line 32 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\News\Delete.cshtml"
           Write(Html.DisplayFor(model => model.NewsTitle));

#line default
#line hidden
                EndContext();
                BeginContext(779, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(835, 48, false);
#line 35 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\News\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.NewsBigTitle));

#line default
#line hidden
                EndContext();
                BeginContext(883, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(939, 44, false);
#line 38 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\News\Delete.cshtml"
           Write(Html.DisplayFor(model => model.NewsBigTitle));

#line default
#line hidden
                EndContext();
                BeginContext(983, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1039, 43, false);
#line 41 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\News\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.NewsTxt));

#line default
#line hidden
                EndContext();
                BeginContext(1082, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1138, 39, false);
#line 44 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\News\Delete.cshtml"
           Write(Html.DisplayFor(model => model.NewsTxt));

#line default
#line hidden
                EndContext();
                BeginContext(1177, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1233, 45, false);
#line 47 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\News\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.NewsViews));

#line default
#line hidden
                EndContext();
                BeginContext(1278, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1334, 41, false);
#line 50 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\News\Delete.cshtml"
           Write(Html.DisplayFor(model => model.NewsViews));

#line default
#line hidden
                EndContext();
                BeginContext(1375, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1431, 49, false);
#line 53 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\News\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.NewsAddedDate));

#line default
#line hidden
                EndContext();
                BeginContext(1480, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1536, 45, false);
#line 56 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\News\Delete.cshtml"
           Write(Html.DisplayFor(model => model.NewsAddedDate));

#line default
#line hidden
                EndContext();
                BeginContext(1581, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1637, 53, false);
#line 59 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\News\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.OptionalLongitude));

#line default
#line hidden
                EndContext();
                BeginContext(1690, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1746, 49, false);
#line 62 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\News\Delete.cshtml"
           Write(Html.DisplayFor(model => model.OptionalLongitude));

#line default
#line hidden
                EndContext();
                BeginContext(1795, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1851, 52, false);
#line 65 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\News\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.OptionalLatitude));

#line default
#line hidden
                EndContext();
                BeginContext(1903, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1959, 48, false);
#line 68 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\News\Delete.cshtml"
           Write(Html.DisplayFor(model => model.OptionalLatitude));

#line default
#line hidden
                EndContext();
                BeginContext(2007, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(2063, 50, false);
#line 71 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\News\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.OptionalAdress));

#line default
#line hidden
                EndContext();
                BeginContext(2113, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(2169, 46, false);
#line 74 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\News\Delete.cshtml"
           Write(Html.DisplayFor(model => model.OptionalAdress));

#line default
#line hidden
                EndContext();
                BeginContext(2215, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(2271, 54, false);
#line 77 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\News\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.NewsFirstPhotoPath));

#line default
#line hidden
                EndContext();
                BeginContext(2325, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(2381, 50, false);
#line 80 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\News\Delete.cshtml"
           Write(Html.DisplayFor(model => model.NewsFirstPhotoPath));

#line default
#line hidden
                EndContext();
                BeginContext(2431, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(2487, 54, false);
#line 83 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\News\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.NewsFirstVideoPath));

#line default
#line hidden
                EndContext();
                BeginContext(2541, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(2597, 50, false);
#line 86 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\News\Delete.cshtml"
           Write(Html.DisplayFor(model => model.NewsFirstVideoPath));

#line default
#line hidden
                EndContext();
                BeginContext(2647, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(2703, 44, false);
#line 89 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\News\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.NewsType));

#line default
#line hidden
                EndContext();
                BeginContext(2747, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(2803, 53, false);
#line 92 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\News\Delete.cshtml"
           Write(Html.DisplayFor(model => model.NewsType.NewsTypeName));

#line default
#line hidden
                EndContext();
                BeginContext(2856, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(2912, 49, false);
#line 95 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\News\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.SportCategory));

#line default
#line hidden
                EndContext();
                BeginContext(2961, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(3017, 63, false);
#line 98 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\News\Delete.cshtml"
           Write(Html.DisplayFor(model => model.SportCategory.SportCategoryName));

#line default
#line hidden
                EndContext();
                BeginContext(3080, 46, true);
                WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n\r\n        ");
                EndContext();
                BeginContext(3126, 227, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34b40c4f87324f218b4141b6977cce38", async() => {
                    BeginContext(3152, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(3166, 40, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1bc5d4ca13c74c5083a5fc7c085111a5", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 103 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\News\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NewsId);

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
                    BeginContext(3206, 92, true);
                    WriteLiteral("\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n            ");
                    EndContext();
                    BeginContext(3298, 38, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42b5a270830f41a0a023f313608ec509", async() => {
                        BeginContext(3320, 12, true);
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
                    BeginContext(3336, 10, true);
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
                BeginContext(3353, 14, true);
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
            BeginContext(3374, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FightSports.Models.News> Html { get; private set; }
    }
}
#pragma warning restore 1591
