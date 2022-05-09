using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Routing;


namespace ClassSchedule.TagHelpers
{
    public class MyLinkButtonTagHelper : TagHelper
    {

        public string Action { get; set; }
        public string Controller { get; set; }
        public string Id { get; set; } = "";
        public bool IsActive { get; set; }

        private LinkGenerator linkBuilder;
        public MyLinkButtonTagHelper(LinkGenerator link)
        {
            linkBuilder = link;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewCtx { get; set; }


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

            string action = Action ?? ViewCtx.RouteData.Values["action"].ToString();
            string controller = Controller ?? ViewCtx.RouteData.Values["controller"].ToString();

            var routeSegment = (string.IsNullOrEmpty(Id)) ? null : new { Id };

            string url = linkBuilder.GetPathByAction(action, controller, routeSegment);
            string classes = IsActive ? "btn btn-dark" : "btn btn-outline-dark";


            output.BuildLink(url, classes);


        }
    }
}