using Android.Content;
using Android.Views;
using ChecklistTest.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using View = Android.Views.View;

[assembly: ExportRenderer(typeof(ViewCell), typeof(ChecklistCustomCellRenderer))]
namespace ChecklistTest.Droid.CustomRenderers
{
    public class ChecklistCustomCellRenderer : ViewCellRenderer
    {
        protected override View GetCellCore(Cell item, View convertView, ViewGroup parent, Context context)
        {
            var listView = parent as Android.Widget.ListView;

            if(listView?.OnItemClickListener != null)
                listView.OnItemClickListener = null;

            return base.GetCellCore(item, convertView, parent, context);
        }
    }
}