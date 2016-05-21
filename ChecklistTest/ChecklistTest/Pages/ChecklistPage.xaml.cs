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

        public ChecklistPage()
        {
            InitializeComponent();
            BindingContext     = this;
            LookupItemTapped   = new Command<InspectionChecklistItem>(OnLookupItemTapped);
            CheckListItems     = TestDataMother.GetTestChecklists().ToList();
        }

        public void OnLookupItemTapped(InspectionChecklistItem item)
        {
            
        }
    }
}
