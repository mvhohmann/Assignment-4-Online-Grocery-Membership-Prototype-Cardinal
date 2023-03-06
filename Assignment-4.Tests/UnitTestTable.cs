using System.Threading.Tasks;
using Xunit;

namespace UnitTestTable
{
    public class Table_Test
    {
        [Fact]
        public async Task Should_Get_Table_of_Orders()
        {
            var response = await GetResponseAsStringAsyunc("/DriverHome");

            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(response);

            var tableElement = htmlDocument.GetElementById("orderTable");
            tableElement.ShouldNotBeNull();

            var trNodes = tableElement.SelectNodes("//tr");
            trNodes.Count.ShouldBeGreaterThan(0);
        }
    }
}
