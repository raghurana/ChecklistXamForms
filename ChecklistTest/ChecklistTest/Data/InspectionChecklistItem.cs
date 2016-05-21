namespace ChecklistTest.Data
{
    public partial class InspectionChecklistItem
    {
        public int InspectionChecklistId { get; set; }

        public string AlchkiKeyNum { get; set; }

        public string ItemNumber { get; set; }

        public string DataTypeCode { get; set; }

        public string LabelText { get; set; }

        public string CommentFlag { get; set; }

        public string DisplaySequence { get; set; }

        public string MandatoryDataFlag { get; set; }

        public string FieldLength { get; set; }

        public string DefaultValue { get; set; }

        public string DataValue { get; set; }

        public string CommentValue { get; set; }

        public int? MinValue { get; set; }

        public int? MaxValue { get; set; }
    }
}
