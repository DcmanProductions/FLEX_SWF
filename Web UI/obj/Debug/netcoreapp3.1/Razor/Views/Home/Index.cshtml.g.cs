#pragma checksum "D:\Workspaces\Visual Studio Workspace\C#\Web\FLEX_SWF\Web UI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "915ae358c445efceaf8fc83c7dbc0900467c0504"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Workspaces\Visual Studio Workspace\C#\Web\FLEX_SWF\Web UI\Views\_ViewImports.cshtml"
using Web_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Workspaces\Visual Studio Workspace\C#\Web\FLEX_SWF\Web UI\Views\_ViewImports.cshtml"
using Web_UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"915ae358c445efceaf8fc83c7dbc0900467c0504", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79e3141ff22bd7e08d5a4d5f909ceaf54ad348ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Workspaces\Visual Studio Workspace\C#\Web\FLEX_SWF\Web UI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Workspaces\Visual Studio Workspace\C#\Web\FLEX_SWF\Web UI\Views\Home\Index.cshtml"
 if (ChaseLabs.Games.SWF.STDLib.Lists.GameFiles.Singleton.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>URLS LOADING</p>\r\n");
#nullable restore
#line 8 "D:\Workspaces\Visual Studio Workspace\C#\Web\FLEX_SWF\Web UI\Views\Home\Index.cshtml"
}
else
{
    foreach (var f in ChaseLabs.Games.SWF.STDLib.Lists.GameFiles.Singleton)
    {
        int id = ChaseLabs.Games.SWF.STDLib.Lists.GameFiles.Singleton.IndexOf(f);
        if (id != -1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"btn btn-outline-primary\"");
            BeginWriteAttribute("href", " href=\"", 400, "\"", 420, 2);
            WriteAttributeValue("", 407, "Home/Play/", 407, 10, true);
#nullable restore
#line 16 "D:\Workspaces\Visual Studio Workspace\C#\Web\FLEX_SWF\Web UI\Views\Home\Index.cshtml"
WriteAttributeValue("", 417, id, 417, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "D:\Workspaces\Visual Studio Workspace\C#\Web\FLEX_SWF\Web UI\Views\Home\Index.cshtml"
                                                               Write(f.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 17 "D:\Workspaces\Visual Studio Workspace\C#\Web\FLEX_SWF\Web UI\Views\Home\Index.cshtml"
        }
    }
}

#line default
#line hidden
#nullable disable
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
