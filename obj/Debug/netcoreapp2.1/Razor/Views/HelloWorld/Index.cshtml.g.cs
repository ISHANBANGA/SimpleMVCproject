#pragma checksum "C:\Users\ishan\source\repos\CSharpEssentials\CSharpEssentials\bin\Debug\FirstMVCProject\FirstMVCProject\Views\HelloWorld\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ad1d66ec86e15a4d6f79ad62fb0a5eeffaf6492"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HelloWorld_Index), @"mvc.1.0.view", @"/Views/HelloWorld/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HelloWorld/Index.cshtml", typeof(AspNetCore.Views_HelloWorld_Index))]
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
#line 1 "C:\Users\ishan\source\repos\CSharpEssentials\CSharpEssentials\bin\Debug\FirstMVCProject\FirstMVCProject\Views\_ViewImports.cshtml"
using FirstMVCProject;

#line default
#line hidden
#line 2 "C:\Users\ishan\source\repos\CSharpEssentials\CSharpEssentials\bin\Debug\FirstMVCProject\FirstMVCProject\Views\_ViewImports.cshtml"
using FirstMVCProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ad1d66ec86e15a4d6f79ad62fb0a5eeffaf6492", @"/Views/HelloWorld/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3f9abbcd1768bec31f348ed80038b08d469bea1", @"/Views/_ViewImports.cshtml")]
    public class Views_HelloWorld_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FirstMVCProject.Models.DogViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(184, 96, true);
            WriteLiteral("\r\n<h1>Hello World Bro !</h1>\r\n<p>This is the index page of the HelloWorld Controller</p>\r\n<ul>\r\n");
            EndContext();
#line 13 "C:\Users\ishan\source\repos\CSharpEssentials\CSharpEssentials\bin\Debug\FirstMVCProject\FirstMVCProject\Views\HelloWorld\Index.cshtml"
 foreach(var dog in Model)
            {

#line default
#line hidden
            BeginContext(323, 20, true);
            WriteLiteral("                <li>");
            EndContext();
            BeginContext(344, 8, false);
#line 15 "C:\Users\ishan\source\repos\CSharpEssentials\CSharpEssentials\bin\Debug\FirstMVCProject\FirstMVCProject\Views\HelloWorld\Index.cshtml"
               Write(dog.Name);

#line default
#line hidden
            EndContext();
            BeginContext(352, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(355, 7, false);
#line 15 "C:\Users\ishan\source\repos\CSharpEssentials\CSharpEssentials\bin\Debug\FirstMVCProject\FirstMVCProject\Views\HelloWorld\Index.cshtml"
                          Write(dog.Age);

#line default
#line hidden
            EndContext();
            BeginContext(362, 8, true);
            WriteLiteral(")</li>\r\n");
            EndContext();
#line 16 "C:\Users\ishan\source\repos\CSharpEssentials\CSharpEssentials\bin\Debug\FirstMVCProject\FirstMVCProject\Views\HelloWorld\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(385, 5, true);
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FirstMVCProject.Models.DogViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
