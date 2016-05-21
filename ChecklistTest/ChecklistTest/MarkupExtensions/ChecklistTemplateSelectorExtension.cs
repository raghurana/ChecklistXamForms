using System;
using ChecklistTest.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChecklistTest.MarkupExtensions
{
    public class ChecklistTemplateSelectorExtension : IMarkupExtension
    {
        public Page Page { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return new DataTemplate(GetListCell);
        }

        private Cell GetListCell()
        {
            var content = new ViewCell();
            content.BindingContextChanged += OnListCellBindingContextChanged;
            return content;
        }

        private void OnListCellBindingContextChanged(object sender, EventArgs e)
        {
            var cell           = (ViewCell) sender;
            var bindingContext = cell.BindingContext as InspectionChecklistItem;

            if (bindingContext == null)
                return;

            var name = bindingContext.IsBoolean? "BooleanTemplate" : "NonBooleanTemplate";
            var pageDataTemplate = FindDataTemplateByName(name);
            if (pageDataTemplate == null)
                return;

            cell.View = ((ViewCell)pageDataTemplate.CreateContent()).View;
        }

        private DataTemplate FindDataTemplateByName(string name)
        {
            object namedDataTemplate;

            if (Page?.Resources == null)
                return null;

            if (!Page.Resources.TryGetValue(name, out namedDataTemplate))
                return null;

            return namedDataTemplate as DataTemplate;
        }
    }
}