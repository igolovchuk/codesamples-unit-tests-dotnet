namespace UnitTesting.DataDriven
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MsTestDataDriven
    {
        public TestContext TestContext { get; set; }
        
        [TestMethod]
        [DataSource("System.Data.OleDb",
            "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\\TestData.xls';Persist Security Info=False;Extended Properties='Excel 8.0'",
            "Sheet1$", DataAccessMethod.Sequential)]
        public void DataSourceTest()
        {
            string rowNumber = this.TestContext.DataRow["Number"].ToString();
            string rowText = this.TestContext.DataRow["Text"].ToString();

            Assert.IsNotNull(rowNumber);
            Assert.IsNotNull(rowText);
        }
    }
}
