using NUnit.Framework;
using AltTester.AltTesterUnitySDK.Driver;

public class SettingsButtonTest
{   //Important! If your test file is inside a folder that contains an .asmdef file, please make sure that the assembly definition references NUnit.
    public AltDriver altDriver;
    //Before any test it connects with the socket
    [OneTimeSetUp]
    public void SetUp()
    {
        altDriver =new AltDriver();
    }

    //At the end of the test closes the connection with the socket
    [OneTimeTearDown]
    public void TearDown()
    {
        altDriver.Stop();
    }

    [Test]
    public void ButtonTest()
    {
        altDriver.FindObject(By.NAME, "SettingButton").Click(); // Busca el objeto (botón) con el nombre SettingButton en la jerarquía y simula darle click.
        var panelElement = altDriver.WaitForObject(By.NAME, "SettingPopup"); // Busca el objeto (panel de opciones) con el nombre SettingPopup en la jerarquía
                                                                             // y lo "almacena" en la variable panelElement
        Assert.IsTrue(panelElement.enabled); // Verifica que el panel esté activo
    }

}