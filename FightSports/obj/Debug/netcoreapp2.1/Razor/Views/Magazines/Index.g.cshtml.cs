#pragma checksum "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d362dcda6a1f5f6a023d87d290d4f118cecef1cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Magazines_Index), @"mvc.1.0.view", @"/Views/Magazines/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Magazines/Index.cshtml", typeof(AspNetCore.Views_Magazines_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d362dcda6a1f5f6a023d87d290d4f118cecef1cf", @"/Views/Magazines/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32bfb32fa9b181d17022fed956ca4d8938b74142", @"/Views/_ViewImports.cshtml")]
    public class Views_Magazines_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FightSports.Models.Magazine>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/admin_panel.cshtml";

#line default
#line hidden
            BeginContext(143, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(172, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "254a50dfb45445fb8354db873a54e1bd", async() => {
                BeginContext(178, 87, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
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
            BeginContext(272, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(274, 2388, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d98073883fa54f629064dd91cfab1a06", async() => {
                BeginContext(280, 19, true);
                WriteLiteral("\r\n    <p>\r\n        ");
                EndContext();
                BeginContext(299, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37f4a84bc7874dda831bde16ee976d56", async() => {
                    BeginContext(322, 10, true);
                    WriteLiteral("Create New");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(336, 116, true);
                WriteLiteral("\r\n    </p>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(453, 47, false);
#line 23 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
                EndContext();
                BeginContext(500, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(568, 50, false);
#line 26 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.MagazineAdress));

#line default
#line hidden
                EndContext();
                BeginContext(618, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(686, 53, false);
#line 29 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.MagazineLongitude));

#line default
#line hidden
                EndContext();
                BeginContext(739, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(807, 52, false);
#line 32 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.MagazineLatitude));

#line default
#line hidden
                EndContext();
                BeginContext(859, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(927, 46, false);
#line 35 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ProductTxt));

#line default
#line hidden
                EndContext();
                BeginContext(973, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(1041, 48, false);
#line 38 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ProductPrice));

#line default
#line hidden
                EndContext();
                BeginContext(1089, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(1157, 48, false);
#line 41 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ProductTitle));

#line default
#line hidden
                EndContext();
                BeginContext(1205, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(1273, 58, false);
#line 44 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.MagazineFirstPhotoPath));

#line default
#line hidden
                EndContext();
                BeginContext(1331, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(1399, 49, false);
#line 47 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.SportCategory));

#line default
#line hidden
                EndContext();
                BeginContext(1448, 106, true);
                WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
                EndContext();
#line 53 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(1611, 24, true);
                WriteLiteral("<tr>\r\n    <td>\r\n        ");
                EndContext();
                BeginContext(1636, 46, false);
#line 57 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
                EndContext();
                BeginContext(1682, 31, true);
                WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
                EndContext();
                BeginContext(1714, 49, false);
#line 60 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.MagazineAdress));

#line default
#line hidden
                EndContext();
                BeginContext(1763, 31, true);
                WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
                EndContext();
                BeginContext(1795, 52, false);
#line 63 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.MagazineLongitude));

#line default
#line hidden
                EndContext();
                BeginContext(1847, 31, true);
                WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
                EndContext();
                BeginContext(1879, 51, false);
#line 66 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.MagazineLatitude));

#line default
#line hidden
                EndContext();
                BeginContext(1930, 31, true);
                WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
                EndContext();
                BeginContext(1962, 45, false);
#line 69 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.ProductTxt));

#line default
#line hidden
                EndContext();
                BeginContext(2007, 31, true);
                WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
                EndContext();
                BeginContext(2039, 47, false);
#line 72 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.ProductPrice));

#line default
#line hidden
                EndContext();
                BeginContext(2086, 31, true);
                WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
                EndContext();
                BeginContext(2118, 47, false);
#line 75 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.ProductTitle));

#line default
#line hidden
                EndContext();
                BeginContext(2165, 31, true);
                WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
                EndContext();
                BeginContext(2197, 57, false);
#line 78 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.MagazineFirstPhotoPath));

#line default
#line hidden
                EndContext();
                BeginContext(2254, 31, true);
                WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
                EndContext();
                BeginContext(2286, 66, false);
#line 81 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.SportCategory.SportCategoryName));

#line default
#line hidden
                EndContext();
                BeginContext(2352, 31, true);
                WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
                EndContext();
                BeginContext(2383, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79815a89a01a4aeabf1c29dbb65dd592", async() => {
                    BeginContext(2436, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 84 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Index.cshtml"
                               WriteLiteral(item.MagazineId);

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
                BeginContext(2444, 12, true);
                WriteLiteral(" |\r\n        ");
                EndContext();
                BeginContext(2456, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e16c6eeb669f4e76bad9d5e567efba72", async() => {
                    BeginContext(2512, 7, true);
                    WriteLiteral("Details");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 85 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Index.cshtml"
                                  WriteLiteral(item.MagazineId);

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
                BeginContext(2523, 12, true);
                WriteLiteral(" |\r\n        ");
                EndContext();
                BeginContext(2535, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5eaecaa5fd3743fdb50f572259e8310b", async() => {
                    BeginContext(2590, 6, true);
                    WriteLiteral("Delete");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 86 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Index.cshtml"
                                 WriteLiteral(item.MagazineId);

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
                BeginContext(2600, 20, true);
                WriteLiteral("\r\n    </td>\r\n</tr>\r\n");
                EndContext();
#line 89 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\Magazines\Index.cshtml"
}

#line default
#line hidden
                BeginContext(2623, 32, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
            BeginContext(2662, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FightSports.Models.Magazine>> Html { get; private set; }
    }
}
#pragma warning restore 1591
