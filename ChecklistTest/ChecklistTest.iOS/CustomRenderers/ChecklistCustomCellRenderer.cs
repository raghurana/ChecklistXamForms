using ChecklistTest.iOS.CustomRenderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ViewCell), typeof(ChecklistCustomCellRenderer))]
namespace ChecklistTest.iOS.CustomRenderers
{
    public class ChecklistCustomCellRenderer : ViewCellRenderer
    {
        public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
        {
            var cell = base.GetCell(item, reusableCell, tv);
            if (cell != null)
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
            return cell;
        }
    }
}