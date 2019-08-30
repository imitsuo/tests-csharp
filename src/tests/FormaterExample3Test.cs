using System;
using application;
using Moq;
using Xunit;

namespace tests
{
    public class FormaterExample3Test
    {
        FormaterExample3 _formater;
        Mock<IStringUtil> _stringUtil = new Mock<IStringUtil>();
        
        public FormaterExample3Test()
        {
            _formater = new FormaterExample3(_stringUtil.Object);
            
            _stringUtil.Setup(x => x.Change(It.IsAny<string>())).Returns("");
        }


        [Fact(DisplayName="test_Format_null__expected_B")]
        public void test_Format__null__expected_B()
        {
            // FIXTURES
            string value = null;

            // EXERCISE
            var result = _formater.Format(value);

            // ASSERTS
            Assert.Equal("B", result);
            _stringUtil.Verify(x => x.Change(null));
        }

        [Fact(DisplayName="test_Format__value__expected_B_plus_string")]
        public void test_Format__value__expected_B_plus_string()
        {
            // FIXTURES
            string value = "xablau";
            _stringUtil.Setup(x => x.Change(value)).Returns(value);

            // EXERCISE
            var result = _formater.Format(value);

            // ASSERTS
            Assert.Equal("Bxablau", result);
            _stringUtil.Verify(x => x.Change(value));
        }

    }
}
