using System;

namespace application
{
    public class FormaterExample3
    {
        private readonly IStringUtil _formater;

        public FormaterExample3()
        {
            _formater = new StringUtil();
        }

        public FormaterExample3(IStringUtil stringUtil)
        {
            _formater = stringUtil;
        }

        public string Format(string init)
        {
            return $"B{_formater.Change(init)}";
        }

    }

    public interface IStringUtil
    {
        string Change(string value);
    }

    public class StringUtil : IStringUtil
    {
        public string Change(string value)
        {
            if (value == null)
                return "B";

            if (value == "B")
                return "C";

            return value.ToUpper();
        }
    }
}
