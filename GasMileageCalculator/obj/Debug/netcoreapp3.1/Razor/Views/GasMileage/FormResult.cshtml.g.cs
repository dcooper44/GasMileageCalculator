#pragma checksum "C:\Users\dylan\source\repos\GasMileageCalculator\GasMileageCalculator\Views\GasMileage\FormResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1baa5d3d84f1d704649faa9cd45241a56573d96b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GasMileage_FormResult), @"mvc.1.0.view", @"/Views/GasMileage/FormResult.cshtml")]
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
#line 1 "C:\Users\dylan\source\repos\GasMileageCalculator\GasMileageCalculator\Views\_ViewImports.cshtml"
using GasMileageCalculator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dylan\source\repos\GasMileageCalculator\GasMileageCalculator\Views\_ViewImports.cshtml"
using GasMileageCalculator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1baa5d3d84f1d704649faa9cd45241a56573d96b", @"/Views/GasMileage/FormResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b67b4cce80a2f707fbd74544e4721c32fa42f77", @"/Views/_ViewImports.cshtml")]
    public class Views_GasMileage_FormResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GasMileageCalculator.Models.GasMileage.FormResultViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\dylan\source\repos\GasMileageCalculator\GasMileageCalculator\Views\GasMileage\FormResult.cshtml"
  
	ViewData["Title"] = "FormResult";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Fuel Range (In Miles):</h1>\r\n<h2>");
#nullable restore
#line 9 "C:\Users\dylan\source\repos\GasMileageCalculator\GasMileageCalculator\Views\GasMileage\FormResult.cshtml"
Write(Model.FuelRange);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<h1>Can You Make The Trip?</h1>\r\n<h2>");
#nullable restore
#line 12 "C:\Users\dylan\source\repos\GasMileageCalculator\GasMileageCalculator\Views\GasMileage\FormResult.cshtml"
Write(Model.SuccessfulTrip);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GasMileageCalculator.Models.GasMileage.FormResultViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
