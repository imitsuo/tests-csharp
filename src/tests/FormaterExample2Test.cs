using System;
using application;
using Xunit;

namespace tests
{
    public class FormaterExample2Test
    {
        FormaterExample2 _formater;
        
        public FormaterExample2Test()
        {
            _formater = new FormaterExample2();
        }

        // null = B
        // B = C
        // w = W
        // abcd = ABCD

        [Fact(DisplayName="test_Format__null__expected_B")]
        public void test_Format__null__expected_B()
        {
            // FIXTURES
            string value = null;

            // EXERCISE
            var result = _formater.Format(value);

            // ASSERTS
            Assert.Equal("B", result);
        }

        [Fact(DisplayName="test_Format__B__expected_C")]
        public void test_Format__B__expected_C()
        {
            // FIXTURES
            string value = "B";

            // EXERCISE
            var result = _formater.Format(value);

            // ASSERTS
            Assert.Equal("C", result);
        }

        [Fact(DisplayName="test_Format__asd__expected_ASD")]
        public void test_Format__asd__expected_ASD()
        {
            // FIXTURES
            string value = "asd";

            // EXERCISE
            var result = _formater.Format(value);

            // ASSERTS
            Assert.Equal("ASD", result);
        }

        [Fact(DisplayName="test_Format__w__expected_W")]
        public void test_Format__w__expected_W()
        {
            // FIXTURES
            string value = "w";

            // EXERCISE
            var result = _formater.Format(value);

            // ASSERTS
            Assert.Equal("W", result);
        }


    }
}
