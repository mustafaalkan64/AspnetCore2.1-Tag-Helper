
namespace TagHelper.TagHelpers
{
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using System.Text;

    [HtmlTargetElement("custom-button-tag-helper")]
    public class CustomTagHelper : TagHelper
    {
        [HtmlAttributeName("button-name")]
        public string Name { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "CustumTagHelper";
            output.TagMode = TagMode.StartTagAndEndTag;

            var sb = new StringBuilder();
            sb.AppendFormat("<button type='button' class='btn btn-primary'>{0}</button>", this.Name);

            output.PreContent.SetHtmlContent(sb.ToString());
        }
    }
}
