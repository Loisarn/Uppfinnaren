#pragma checksum "/Users/louiceborg/Documents/GitHub/Inlämning-Uppfinnaren/Inlämning-Uppfinnaren/Views/Art/Animals.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d374e569ef1d54dfecf3d3bbbd90a68f13011b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Art_Animals), @"mvc.1.0.view", @"/Views/Art/Animals.cshtml")]
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
#line 1 "/Users/louiceborg/Documents/GitHub/Inlämning-Uppfinnaren/Inlämning-Uppfinnaren/Views/_ViewImports.cshtml"
using Uppfinnaren;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/louiceborg/Documents/GitHub/Inlämning-Uppfinnaren/Inlämning-Uppfinnaren/Views/_ViewImports.cshtml"
using Uppfinnaren.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/louiceborg/Documents/GitHub/Inlämning-Uppfinnaren/Inlämning-Uppfinnaren/Views/_ViewImports.cshtml"
using Uppfinnaren.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d374e569ef1d54dfecf3d3bbbd90a68f13011b9", @"/Views/Art/Animals.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87438c2ca63b8ee86b69c61d0f6424bfa5232ad1", @"/Views/_ViewImports.cshtml")]
    public class Views_Art_Animals : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ArtListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Art", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div style=\"text-align: center;\">\n    <h1>Animals</h1>\n    <br>\n    <br>\n\n");
#nullable restore
#line 8 "/Users/louiceborg/Documents/GitHub/Inlämning-Uppfinnaren/Inlämning-Uppfinnaren/Views/Art/Animals.cshtml"
     foreach (var art in Model.Art)
    {
        if(art.CategoryId == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img");
            BeginWriteAttribute("src", " src=\"", 215, "\"", 234, 1);
#nullable restore
#line 12 "/Users/louiceborg/Documents/GitHub/Inlämning-Uppfinnaren/Inlämning-Uppfinnaren/Views/Art/Animals.cshtml"
WriteAttributeValue("", 221, art.ImageUrl, 221, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"djur\" style=\"width:80%; height: 60%;\">\n            <h2>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d374e569ef1d54dfecf3d3bbbd90a68f13011b94771", async() => {
#nullable restore
#line 14 "/Users/louiceborg/Documents/GitHub/Inlämning-Uppfinnaren/Inlämning-Uppfinnaren/Views/Art/Animals.cshtml"
                                                                                  Write(art.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "/Users/louiceborg/Documents/GitHub/Inlämning-Uppfinnaren/Inlämning-Uppfinnaren/Views/Art/Animals.cshtml"
                                                               WriteLiteral(art.ArtId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n            </h2>\n            <h2>Price: ");
#nullable restore
#line 16 "/Users/louiceborg/Documents/GitHub/Inlämning-Uppfinnaren/Inlämning-Uppfinnaren/Views/Art/Animals.cshtml"
                  Write(art.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</h2>\n            <h3>");
#nullable restore
#line 17 "/Users/louiceborg/Documents/GitHub/Inlämning-Uppfinnaren/Inlämning-Uppfinnaren/Views/Art/Animals.cshtml"
           Write(art.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n            <br>\n            <br>\n");
#nullable restore
#line 20 "/Users/louiceborg/Documents/GitHub/Inlämning-Uppfinnaren/Inlämning-Uppfinnaren/Views/Art/Animals.cshtml"
                }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArtListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
