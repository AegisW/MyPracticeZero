#pragma checksum "C:\Users\ewei3\Documents\GitHub\MyPracticeZero\Tutorial\tut6\Tutorial6\Tutorial6\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d15897002137066f9ac6f55374c725560e83f7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\ewei3\Documents\GitHub\MyPracticeZero\Tutorial\tut6\Tutorial6\Tutorial6\Views\_ViewImports.cshtml"
using Tutorial6;

#line default
#line hidden
#line 2 "C:\Users\ewei3\Documents\GitHub\MyPracticeZero\Tutorial\tut6\Tutorial6\Tutorial6\Views\_ViewImports.cshtml"
using Tutorial6.Models;

#line default
#line hidden
#line 1 "C:\Users\ewei3\Documents\GitHub\MyPracticeZero\Tutorial\tut6\Tutorial6\Tutorial6\Views\Home\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d15897002137066f9ac6f55374c725560e83f7f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7956d6761d8498887689b945cca3e2fb68e84061", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tutorial6.ViewModels.Home>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\ewei3\Documents\GitHub\MyPracticeZero\Tutorial\tut6\Tutorial6\Tutorial6\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(105, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\ewei3\Documents\GitHub\MyPracticeZero\Tutorial\tut6\Tutorial6\Tutorial6\Views\Home\Index.cshtml"
 using (Html.BeginForm("Index", "Home", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(169, 268, true);
            WriteLiteral(@"    <div class=""text-center"">
        <h1 class=""display-4"">Welcome</h1>
        <p>
            Learn about <a href=""https://docs.microsoft.com/aspnet/core"">
                building Web apps with
                ASP.NET Core
            </a>.
        </p>

");
            EndContext();
#line 19 "C:\Users\ewei3\Documents\GitHub\MyPracticeZero\Tutorial\tut6\Tutorial6\Tutorial6\Views\Home\Index.cshtml"
          
            var listItems = new List<SelectListItem>()
            {
                new SelectListItem {Text = "AGL", Value = "AGL"},

                new SelectListItem {Text = "BHP", Value = "BHP"},

                new SelectListItem {Text = "HFG", Value = "HFG"},

                new SelectListItem {Text = "BHP", Value = "BHP"},

                new SelectListItem {Text = "SAM", Value = "SAM"},

                new SelectListItem {Text = "SHE", Value = "SHE"},

                new SelectListItem {Text = "TPL", Value = "TPL"}
            };

            

#line default
#line hidden
            BeginContext(1031, 61, false);
#line 37 "C:\Users\ewei3\Documents\GitHub\MyPracticeZero\Tutorial\tut6\Tutorial6\Tutorial6\Views\Home\Index.cshtml"
       Write(Html.DropDownListFor(m => m.SecCode, listItems, string.Empty));

#line default
#line hidden
            EndContext();
            BeginContext(1105, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1116, 43, false);
#line 40 "C:\Users\ewei3\Documents\GitHub\MyPracticeZero\Tutorial\tut6\Tutorial6\Tutorial6\Views\Home\Index.cshtml"
   Write(Html.TextBoxFor(model => model.OffsetCount));

#line default
#line hidden
            EndContext();
            BeginContext(1159, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1170, 40, false);
#line 41 "C:\Users\ewei3\Documents\GitHub\MyPracticeZero\Tutorial\tut6\Tutorial6\Tutorial6\Views\Home\Index.cshtml"
   Write(Html.TextBoxFor(model => model.RowCount));

#line default
#line hidden
            EndContext();
            BeginContext(1210, 96, true);
            WriteLiteral("\r\n        <button type=\"submit\">Submit</button>\r\n        <div id=\"chartdiv\"></div>\r\n    </div>\r\n");
            EndContext();
#line 45 "C:\Users\ewei3\Documents\GitHub\MyPracticeZero\Tutorial\tut6\Tutorial6\Tutorial6\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1309, 231, true);
            WriteLiteral("\r\n<!-- <div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n    <div id=\"chartdiv\"></div>\r\n</div> -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tutorial6.ViewModels.Home> Html { get; private set; }
    }
}
#pragma warning restore 1591
