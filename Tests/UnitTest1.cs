namespace Tests;

using PrismDialogTestingError;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var viewModel = new DialogTestViewModel();
        viewModel.DialogCloseCommand.Execute();
    }
}