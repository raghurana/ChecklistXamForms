using System.Collections.Generic;

namespace ChecklistTest.Data
{
    public static class TestDataMother
    {
        public static IEnumerable<InspectionChecklistItem> GetTestChecklists()
        {
            yield return new InspectionChecklistItem
            {
                LabelText = "This is boolean",
                DataTypeCode = InspectionChecklistItem.Codes.Boolean
            };

            yield return new InspectionChecklistItem
            {
                LabelText = "This is boolean With comments",
                DataTypeCode = InspectionChecklistItem.Codes.Boolean,
                CommentFlag = InspectionChecklistItem.Codes.True
            };

            yield return new InspectionChecklistItem
            {
                LabelText = "This is Lookup",
                DataTypeCode = InspectionChecklistItem.Codes.Lookup,
                MandatoryDataFlag = InspectionChecklistItem.Codes.True
            };

            yield return new InspectionChecklistItem
            {
                LabelText = "This is Lookup With comments",
                DataTypeCode = InspectionChecklistItem.Codes.Lookup,
                CommentFlag = InspectionChecklistItem.Codes.True
            };

            yield return new InspectionChecklistItem
            {
                LabelText = "This is Date field",
                DataTypeCode = InspectionChecklistItem.Codes.Date,
            };

            yield return new InspectionChecklistItem
            {
                LabelText = "This is Date field With Comments",
                DataTypeCode = InspectionChecklistItem.Codes.Date,
                CommentFlag = InspectionChecklistItem.Codes.True
            };

            yield return new InspectionChecklistItem
            {
                LabelText = "This is Time field",
                DataTypeCode = InspectionChecklistItem.Codes.Time,
            };

            yield return new InspectionChecklistItem
            {
                LabelText = "This is Text",
                DataTypeCode = InspectionChecklistItem.Codes.Text,
                MandatoryDataFlag = InspectionChecklistItem.Codes.True
            };

            yield return new InspectionChecklistItem
            {
                LabelText = "This is Numeric",
                DataTypeCode = InspectionChecklistItem.Codes.Numeric1
            };

            yield return new InspectionChecklistItem
            {
                LabelText = "This is Numeric With Comments",
                DataTypeCode = InspectionChecklistItem.Codes.Numeric2,
                CommentFlag = InspectionChecklistItem.Codes.True
            };
        }
    }
}