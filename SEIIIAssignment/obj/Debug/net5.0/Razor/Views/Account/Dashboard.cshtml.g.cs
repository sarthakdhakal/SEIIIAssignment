#pragma checksum "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52616a483623340b462e620aa181e6f6095ee288"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Dashboard), @"mvc.1.0.view", @"/Views/Account/Dashboard.cshtml")]
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
#line 1 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52616a483623340b462e620aa181e6f6095ee288", @"/Views/Account/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efd6c4cc725aa7cf17490d4e5b48b95fd0e65203", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SEIIIAssignment.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/uploads/img/user.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded-circle mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("128"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("128"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Items", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UnArchive", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
  
    ViewData["Title"] = "Profile";
    Layout = "_Layout";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <div class=""row"">
      <div class=""col-lg-4 mt-5"">
            <div class=""card mb-3"">
                <div class=""card-header"">
                    <h5 class=""card-title mb-0""></h5>
                </div>
                <div class=""card-body text-center"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "52616a483623340b462e620aa181e6f6095ee2886336", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 18 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
AddHtmlAttributeValue("", 472, Model.UserName, 472, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <h3 class=\"card-title mb-0\"> ");
#nullable restore
#line 20 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
                                            Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h3>
                </div>
                <hr class=""my-0"" />

                <hr class=""my-0"" />
                <div class=""card-body"">
                    <h5 class=""h6 card-title"">About</h5>
                    <ul class=""list-unstyled mb-0"">
                        <li class=""mb-1""><span data-feather=""at-sign"" class=""feather-sm me-1""></span> Username :
                            ");
#nullable restore
#line 29 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
                       Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n                        <li class=\"mb-1\"><span data-feather=\"mail\" class=\"feather-sm me-1\"></span> Email: ");
#nullable restore
#line 31 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
                                                                                                     Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </li> <li class=\"mb-1\"><span data-feather=\"mail\" class=\"feather-sm me-1\"></span> Role: ");
#nullable restore
#line 32 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
                                                                                                          Write(Model.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                     </li>
                        
                    </ul>
                </div>
            </div>
        </div>

       <div class=""col-lg-8 mt-5"">
            <div class=""col pb-4"">
                <table class=""table"">
                    <thead>
                    <tr>
                        <th>
                            Posted Item Name
                        </th>

                    </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 52 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
                     foreach (var item in ViewBag.SoldItems)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52616a483623340b462e620aa181e6f6095ee28810822", async() => {
#nullable restore
#line 57 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
                                                          Write(item.ProductName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
                                     WriteLiteral(item.ItemId);

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
            WriteLiteral("\r\n                            </td>\r\n\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 62 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n");
#nullable restore
#line 65 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
                if (User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Role)?.Value == "Admin")
               {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                   <div class=""col pb-4"">
                      
                       <table class=""table"">
                           <thead>
                           <tr>
                               <th>
                                   Archived Items
                               </th>
                               <th>

                               </th>

                           </tr>
                           </thead>
");
#nullable restore
#line 81 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
                            if (ViewBag.Archives != null)
                           {

#line default
#line hidden
#nullable disable
            WriteLiteral("                               <tbody>\r\n");
#nullable restore
#line 84 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
                                foreach (var item in ViewBag.Archives)
                               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                   <tr>\r\n                                       <td>\r\n                                           ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52616a483623340b462e620aa181e6f6095ee28815245", async() => {
#nullable restore
#line 89 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
                                                                     Write(item.ProductName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
                                                WriteLiteral(item.ItemId);

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
            WriteLiteral("\r\n                                       </td>\r\n                                       <td>\r\n                                           ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52616a483623340b462e620aa181e6f6095ee28817961", async() => {
                WriteLiteral("UnArchive");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
                                                WriteLiteral(item.ItemId);

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
            WriteLiteral("\r\n                                       </td>\r\n\r\n                                   </tr>\r\n");
#nullable restore
#line 97 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
                               }

#line default
#line hidden
#nullable disable
            WriteLiteral("                               </tbody>\r\n");
#nullable restore
#line 99 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
                           }

#line default
#line hidden
#nullable disable
            WriteLiteral("                       </table>\r\n                   </div>\r\n");
#nullable restore
#line 102 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
            
           
               }
               else
               {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                   <div class=""col pb-4"">
                       <table class=""table"">
                           <thead>
                           <tr>
                               <th>
                                   Bought Item Name
                               </th>

                           </tr>
                           </thead>
                           <tbody>
");
#nullable restore
#line 118 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
                            foreach (var item in ViewBag.BoughtItems)
                           {

#line default
#line hidden
#nullable disable
            WriteLiteral("                               <tr>\r\n                                   <td>\r\n                                       ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52616a483623340b462e620aa181e6f6095ee28822061", async() => {
#nullable restore
#line 123 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
                                                                 Write(item.ProductName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 123 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
                                            WriteLiteral(item.ItemId);

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
            WriteLiteral("\r\n                                   </td>\r\n\r\n\r\n                               </tr>\r\n");
#nullable restore
#line 128 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
                           }

#line default
#line hidden
#nullable disable
            WriteLiteral("                           </tbody>\r\n                       </table>\r\n                   </div>\r\n");
            WriteLiteral(@"                   <div class=""col pb-4"">
                       <h5>Archived Items Added By the User</h5>
                       <table class=""table"">
                           <thead>
                           <tr>
                               <th>
                                   Archived Items
                               </th>
                               <th>

                               </th>

                           </tr>
                           </thead>
");
#nullable restore
#line 148 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
                            if (ViewBag.ArchivesByUser != null)
                           {

#line default
#line hidden
#nullable disable
            WriteLiteral("                               <tbody>\r\n");
#nullable restore
#line 151 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
                                foreach (var item in ViewBag.ArchivesByUser)
                               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                   <tr>\r\n                                       <td>\r\n                                           ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52616a483623340b462e620aa181e6f6095ee28826346", async() => {
#nullable restore
#line 156 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
                                                                     Write(item.ProductName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 156 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
                                                WriteLiteral(item.ItemId);

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
            WriteLiteral("\r\n                                       </td>\r\n                                       <td>\r\n                                           ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52616a483623340b462e620aa181e6f6095ee28829064", async() => {
                WriteLiteral("UnArchive");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 160 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
                                                WriteLiteral(item.ItemId);

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
            WriteLiteral("\r\n                                       </td>\r\n\r\n                                   </tr>\r\n");
#nullable restore
#line 164 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
                               }

#line default
#line hidden
#nullable disable
            WriteLiteral("                               </tbody>\r\n");
#nullable restore
#line 166 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
                           }

#line default
#line hidden
#nullable disable
            WriteLiteral("                       </table>\r\n                   </div>\r\n");
#nullable restore
#line 169 "D:\DotNetCore\SEIIIAssignment\SEIIIAssignment\Views\Account\Dashboard.cshtml"
               }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SEIIIAssignment.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
