using TestProject1.Refrences;

namespace TestProject1
{
    [TestFixture]
    public class HtmlFormatter_Test
    {
        private HtmlFormatter _html; 
        [SetUp]
        public void Setup()
        {
            this._html = new HtmlFormatter();
        }
        [Test]
        public void FormatAsBold_StringinLowerCase_OutUperCase()
        {
            //The most important thing is to dont write your code very general or esepisefic 
            // for strings is better to check star , end and whole contain
            //and Also to make sure key sensetives dose not involve you can add some attribut 
            //to end of each Assert line as ignore Case
          var result=  _html.FormatAsBold("abc");
            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.EndWith("</strong>").IgnoreCase);
            Assert.That(result, Does.Contain("abc").IgnoreCase);

        }
    }
}