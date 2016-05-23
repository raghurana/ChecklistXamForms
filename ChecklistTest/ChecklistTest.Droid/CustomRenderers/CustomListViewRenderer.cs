using ChecklistTest.Droid.CustomRenderers;
using ChecklistTest.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomListView), typeof(CustomListViewRenderer))]
namespace ChecklistTest.Droid.CustomRenderers
{
    public class CustomListViewRenderer : ListViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
        {
            base.OnElementChanged(e);

            if (Control?.OnItemClickListener != null)
                Control.OnItemClickListener = null;
        }
    }

}