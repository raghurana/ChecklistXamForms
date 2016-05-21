using System;

namespace ChecklistTest.Data
{
    public partial class InspectionChecklistItem
    {
        public static class Codes
        {
            public const string Boolean  = "F";

            public const string Date     = "D";

            public const string Time     = "TIME";

            public const string Lookup   = "L";

            public const string Comment  = "COM";

            public const string Text     = "T";

            public const string Numeric1 = "A";

            public const string Numeric2 = "N";

            public const string True     = "Y";

            public const string False    = "N";
        }

        public bool IsBoolean  => IsOfType(Codes.Boolean);

        public bool IsDateTime => IsOfType(Codes.Date) || IsOfType(Codes.Time);

        public bool IsLookup   => IsOfType(Codes.Lookup);

        public bool IsTextual  => IsOfType(Codes.Comment) || IsOfType(Codes.Text);

        public bool IsNumeric  => IsOfType(Codes.Numeric1) || IsOfType(Codes.Numeric2);

        public bool HasComment => 
            !string.IsNullOrEmpty(CommentFlag) && 
            CommentFlag.Equals(Codes.True, StringComparison.CurrentCulture);

        public bool IsOfType(string code)
        {
            return DataTypeCode.Equals(code, StringComparison.CurrentCulture);
        }
    }
}