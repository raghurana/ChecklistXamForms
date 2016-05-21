using System.Collections.Generic;
using System.Linq;
using ChecklistTest.Data;
using PropertyChanged;
using Xamarin.Forms;

namespace ChecklistTest.Pages
{
    [ImplementPropertyChanged]
    public partial class ChecklistPage : ContentPage
    {
        public List<InspectionChecklistItem> CheckListItems { get; set; }

        public Command<InspectionChecklistItem> LookupItemTapped { get; }

        public Command CompleteCommand { get; }

        public ChecklistPage()
        {
            InitializeComponent();
            BindingContext     = this;
            LookupItemTapped   = new Command<InspectionChecklistItem>(OnLookupItemTapped);
            CompleteCommand    = new Command(OnCompleteButtonTapped);
            CheckListItems     = TestDataMother.GetTestChecklists().ToList();
        }

        public void OnLookupItemTapped(InspectionChecklistItem item)
        {
            // navigation.push -> Lookup page
        }

        public void OnCompleteButtonTapped()
        {
            // Iterate over CheckListItems
            // If an item's DataValue is null or empty but had a DefaultValue value, then set DataValue to DefaultValue
            // Validate item (see AuthorityTaskValidator in the Actus App) 
            // If the errors collection is not empty then display alert and return
            // otherwise save item to the database
            // After all items are saved. navigate.pop back to the inspections list page.
        }
    }
}
