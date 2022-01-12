#pragma checksum "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2dd8f7cc3c547c4788ed7c3edf6284457346ed9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Details), @"mvc.1.0.view", @"/Views/Items/Details.cshtml")]
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
#line 1 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\_ViewImports.cshtml"
using SEIIIAssignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\_ViewImports.cshtml"
using SEIIIAssignment.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
using Microsoft.IdentityModel.Tokens;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2dd8f7cc3c547c4788ed7c3edf6284457346ed9", @"/Views/Items/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efd6c4cc725aa7cf17490d4e5b48b95fd0e65203", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SEIIIAssignment.Models.Item>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("product-detail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Archive", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
  
    ViewData["Title"] = "Details-" + @Model.ProductName;
    var userId = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Sid)?.Value;
    var role = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Role)?.Value;
    var id = Int32.Parse(userId);
    var commisson = 0.05 * Model.SellingAmount;




#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Details of ");
#nullable restore
#line 17 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
          Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<section class=\"bg-light\">\r\n<div class=\"container pb-5\">\r\n<div class=\"row\">\r\n<div class=\"col-lg-5 mt-5\">\r\n    <div class=\"card mb-3\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b2dd8f7cc3c547c4788ed7c3edf6284457346ed96803", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 708, "~/uploads/img/products/", 708, 23, true);
#nullable restore
#line 23 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
AddHtmlAttributeValue("", 731, Model.Image, 731, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 750, "Image", 750, 5, true);
            AddHtmlAttributeValue(" ", 755, "of:", 756, 4, true);
#nullable restore
#line 23 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
AddHtmlAttributeValue(" ", 759, Html.DisplayFor(model => model.ProductName), 760, 44, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n<!-- col end -->\r\n<div class=\"col-lg-7 mt-5\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h1 class=\"h2\">Item Name: ");
#nullable restore
#line 31 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
                                 Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n            <p class=\"py-2\">Produced year: ");
#nullable restore
#line 32 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
                                      Write(Html.DisplayFor(model => model.ProducedYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"py-2\">Auction Added by: ");
#nullable restore
#line 33 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
                                         Write(Html.DisplayFor(model => model.Postedby.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"py-2\">Estimated Amount: ");
#nullable restore
#line 34 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
                                         Write(Html.DisplayFor(model => model.EstimatedAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n            <h6>Description:</h6>\r\n            <p> ");
#nullable restore
#line 37 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
           Write(Html.DisplayFor(model => model.TextualDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            <ul class=""list-inline"">
                <li class=""list-inline-item"">
                    <h6>Artist:</h6>
                </li>
                <li class=""list-inline-item"">
                    <p class=""text-muted"">
                        <strong>");
#nullable restore
#line 44 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Artist));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                    </p>
                </li>
            </ul>
            <ul class=""list-inline"">
                <li class=""list-inline-item"">
                    <h6>Category:</h6>
                </li>
                <li class=""list-inline-item"">
                    <p class=""text-muted"">
                        <strong>");
#nullable restore
#line 54 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Category.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                    </p>
                </li>
            </ul>
            <ul class=""list-inline"">
                <li class=""list-inline-item"">
                    <h6>Classification:</h6>
                </li>
                <li class=""list-inline-item"">
                    <p class=""text-muted"">
                        <strong>");
#nullable restore
#line 64 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Classification.ClassificationName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                    </p>\r\n                </li>\r\n            </ul>\r\n\r\n");
#nullable restore
#line 69 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
             if (Model.Category.CategoryName is "Drawings" or "Paintings")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <ul class=""list-inline"">
                    <li class=""list-inline-item"">
                        <h6>Medium Used:</h6>
                    </li>
                    <li class=""list-inline-item"">
                        <p class=""text-muted"">
                            <strong>");
#nullable restore
#line 77 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
                               Write(Html.DisplayFor(model => model.Medium));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                        </p>
                    </li>
                </ul>
                <ul class=""list-inline"">
                    <li class=""list-inline-item"">
                        <h6>Framed:</h6>
                    </li>
                    <li class=""list-inline-item"">
                        <p class=""text-muted"">
");
#nullable restore
#line 87 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
                             if (Model.IsFramed == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <strong>No</strong>\r\n");
#nullable restore
#line 90 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
                            }
                            else if (Model.IsFramed == 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <strong>Yes</strong>\r\n");
#nullable restore
#line 94 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <strong>Unknown</strong>\r\n");
#nullable restore
#line 98 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </p>\r\n                    </li>\r\n                </ul>\r\n");
#nullable restore
#line 102 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
            }
            else if (Model.Category.CategoryName is "Sculptures" or "Carvings")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <ul class=""list-inline"">
                    <li class=""list-inline-item"">
                        <h6>Material used:</h6>
                    </li>
                    <li class=""list-inline-item"">
                        <p class=""text-muted"">
                            <strong>");
#nullable restore
#line 111 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
                               Write(Html.DisplayFor(model => model.Material));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                        </p>
                    </li>
                </ul>
                <ul class=""list-inline"">
                    <li class=""list-inline-item"">
                        <h6>Weight:</h6>
                    </li>
                    <li class=""list-inline-item"">
                        <p class=""text-muted"">
                            <strong>");
#nullable restore
#line 121 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
                               Write(Html.DisplayFor(model => model.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                        </p>
                    </li>
                </ul>
                <ul class=""list-inline"">
                    <li class=""list-inline-item"">
                        <h6>Width:</h6>
                    </li>
                    <li class=""list-inline-item"">
                        <p class=""text-muted"">
                            <strong>");
#nullable restore
#line 131 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
                               Write(Html.DisplayFor(model => model.Width));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                        </p>\r\n                    </li>\r\n                </ul>\r\n");
#nullable restore
#line 135 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
            }

            else if (Model.Category.CategoryName is "Photographic Images")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <ul class=""list-inline"">
                    <li class=""list-inline-item"">
                        <h6>Type of Image :</h6>
                    </li>
                    <li class=""list-inline-item"">
                        <p class=""text-muted"">
                            <strong>");
#nullable restore
#line 145 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
                               Write(Html.DisplayFor(model => model.ImageType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                        </p>\r\n                    </li>\r\n                </ul>\r\n");
#nullable restore
#line 149 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <ul class=""list-inline"">
                <li class=""list-inline-item"">
                    <h6>Height:</h6>
                </li>
                <li class=""list-inline-item"">
                    <p class=""text-muted"">
                        <strong>");
#nullable restore
#line 156 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Height));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                    </p>
                </li>
            </ul>
            <ul class=""list-inline"">
                <li class=""list-inline-item"">
                    <h6>Length :</h6>
                </li>
                <li class=""list-inline-item"">
                    <p class=""text-muted"">
                        <strong>");
#nullable restore
#line 166 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Length));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                    </p>
                </li>
            </ul>
            <ul class=""list-inline"">
                <li class=""list-inline-item"">
                    <h6>Auction Date :</h6>
                </li>
                <li class=""list-inline-item"">
                    <p class=""text-muted"">
                        <strong>");
#nullable restore
#line 176 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
                           Write(Html.DisplayFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("- ");
#nullable restore
#line 176 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
                                                                       Write(Html.DisplayFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                    </p>\r\n                </li>\r\n            </ul>\r\n\r\n");
#nullable restore
#line 181 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
             if (Model.SellingAmount != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <ul class=""list-inline"">
                    <li class=""list-inline-item"">
                        <h6>Sold at :</h6>
                    </li>
                    <li class=""list-inline-item"">
                        <p class=""text-muted"">
                            <strong>Rs. ");
#nullable restore
#line 189 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.SellingAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                        </p>
                    </li>
                </ul>
                <ul class=""list-inline"">
                    <li class=""list-inline-item"">
                        <h6>Comission to the system:</h6>
                    </li>
                    <li class=""list-inline-item"">
                        <p class=""text-muted"">
                            <strong>Rs. ");
#nullable restore
#line 199 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
                                   Write(commisson);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                        </p>
                    </li>
                </ul>
                <ul class=""list-inline"">
                    <li class=""list-inline-item"">
                        <h6>Bought by:</h6>
                    </li>
                    <li class=""list-inline-item"">
                        <p class=""text-muted"">
                            <strong>");
#nullable restore
#line 209 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
                               Write(Html.DisplayFor(model => model.Boughtby.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                        </p>\r\n                    </li>\r\n                </ul>\r\n");
#nullable restore
#line 213 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 214 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
             if (Model.StartDate >= DateTime.Now && Model.EndDate >= DateTime.Now)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 216 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
                 if (id != Model.PostedbyId || role != "Admin")
                {
                    {
                        Html.RenderPartial("~/Views/Bids/Create.cshtml", new SEIIIAssignment.Models.Bid(), new ViewDataDictionary(ViewData) {{"ItemId", Model.ItemId}});
                    }
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 221 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>
</div>
</div>
</section>

<section class=""py-5"">
    <div class=""container"">
        <table class=""table"">
            <thead>
            <tr>
                <th>
                    Bidder's Name
                </th>
                <th>Bid Amount</th>
            </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 242 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
             foreach (var bid in ViewBag.Bids)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 246 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
                   Write(bid.Bidder.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        Rs. ");
#nullable restore
#line 249 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
                       Write(bid.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 252 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</section>\r\n<div>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2dd8f7cc3c547c4788ed7c3edf6284457346ed925978", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 260 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
     if (id == Model.PostedbyId || role == "Admin")
    {
        if (Model.SellingAmount == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2dd8f7cc3c547c4788ed7c3edf6284457346ed927451", async() => {
                WriteLiteral("Edit |");
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
#nullable restore
#line 264 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
                                   WriteLiteral(Model.ItemId);

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
            WriteLiteral("\r\n");
#nullable restore
#line 265 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2dd8f7cc3c547c4788ed7c3edf6284457346ed929801", async() => {
                WriteLiteral("Delete |");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 266 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
                                 WriteLiteral(Model.ItemId);

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
            WriteLiteral("\r\n");
#nullable restore
#line 267 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
        if (Model.ArchiveStatus == 0)
        {



#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2dd8f7cc3c547c4788ed7c3edf6284457346ed932198", async() => {
                WriteLiteral("Archive |");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 271 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
                                      WriteLiteral(Model.ItemId);

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
            WriteLiteral("\r\n");
#nullable restore
#line 272 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 275 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
 if (ViewBag.Message != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script type=\"text/javascript\">\r\n        alert(\"");
#nullable restore
#line 278 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
          Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n  </script>\r\n");
#nullable restore
#line 280 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 284 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Items\Details.cshtml"
       await Html.RenderPartialAsync("_ValidationScriptsPartial"); 

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SEIIIAssignment.Models.Item> Html { get; private set; }
    }
}
#pragma warning restore 1591
