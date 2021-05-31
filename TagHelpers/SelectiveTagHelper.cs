using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ExampleWebApp.TagHelpers
{
    [HtmlTargetElement("div", Attributes = "show-when-gt, for")]
    public class SelectiveTagHelper : TagHelper
    {
        public decimal ShowWhenGt { get; set; }
        public ModelExpression For { get; set; }

        // Don't show the tag helper if the Product price is less than the ShowWhenGt price.
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (For.Model.GetType() == typeof(decimal)
                    && (decimal)For.Model <= ShowWhenGt)
            {
                output.SuppressOutput();
            }
        }
    }
}
