using ChecklistTest.Cells;
using ChecklistTest.WinPhone.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinRT;
using DataTemplate = Windows.UI.Xaml.DataTemplate;

[assembly: ExportRenderer(typeof(ViewCell), typeof(ChecklistCustomCellRenderer))]
namespace ChecklistTest.WinPhone.CustomRenderers
{
    public class ChecklistCustomCellRenderer : ViewCellRenderer
    {
        public override DataTemplate GetTemplate(Cell cell)
        {
            return base.GetTemplate(cell);
        }
    }
}