using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;

namespace Net8LoopError.CustomControls
{
    public class RadioButtonList : ComponentBase
    {

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "div");

            List<string> ListOfStrings = new List<string>() { "One","Two","Tree","This","Works!"};
            
            // uncomment following line to break it
            // ListOfStrings = new List<string>() { "One", "Two", "Tree", "This", "Works!", "One", "Two", "Tree", "This", "Works!", "One", "Two", "Works!", "One", "Two", "Now it's dead", "Now it's dead", "Now it's dead"};

            int i = 0;
            foreach (string item in ListOfStrings)
            {         

                base.BuildRenderTree(builder);
                builder.OpenElement(i++, "div");

                builder.OpenComponent(i++, typeof(RadioButton));
                builder.AddAttribute(i++, "LabelText", item);

                builder.CloseComponent();
                builder.CloseElement();

            }
            builder.CloseElement();

        }
    }
}
