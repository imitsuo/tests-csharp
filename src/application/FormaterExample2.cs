using System;

namespace application
{
    public class FormaterExample2
    {
        private string _Change(string value)
        {
            if (value == null)
                return "B";

            if (value == "B")
                return "C";

            return value.ToUpper();
        }

        public string Format(string value)
        {
            if (value == "w")
                value = "W";

            return $"{_Change(value)}";
        }

    }
}
