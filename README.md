# AspnetCore2.1-Tag-Helper
Asp.net Core 2.1 Custom Tag Helper Example

In Asp.net Core 2.1 you can create your specific tag helpers and use in any view file.

</br>

Create CustomTagHelper class:

```
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
```

Edit _ViewImports.cshtml file:
<br/>

```
@using TagHelper
@using TagHelper.Models
@addTagHelper *, TagHelper // You must set name of your project assembly name here instead of TagHelper
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers

```

And finally add this tag helper any view file in your project like below:

```
<custom-button-tag-helper button-name="Mustafa"></custom-button-tag-helper>

```

And output will look like the following:

![Imgur Image](https://i.imgur.com/sdTTBjV.png)


