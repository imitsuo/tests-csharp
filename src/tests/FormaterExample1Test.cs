using application;
using Xunit;

namespace tests
{
    public class FormaterExample1Test
    {
        FormaterExample1 _formater;
        
        public FormaterExample1Test()
        {
            _formater = new FormaterExample1();
        }

        // val1 = Bval1
        // null = B

        [Fact(DisplayName="test_Formate__string1__expected_B_plus_string1")]
        public void test_Formate__string1__expected_B_plus_string1()
        {
            // FIXTURES

            var value = "init bla  bla bla bla";

            // EXERCISE
            var result = _formater.Format(value);

            // ASSERTS
            Assert.Equal("Binit bla  bla bla bla", result);
        }

        [Fact(DisplayName="test_Formate__null__expected_B")]
        public void test_Formate__null__expected_B()
        {
            // FIXTURES

            string init = "";

            // EXERCISE
            var result = _formater.Format(init);

            // ASSERTS
            Assert.Equal("B", result);
        }

    }
}
