using NUnit.Framework;
using AltTester.AltTesterUnitySDK.Driver;

public class StartSceneTest
{   //Important! If your test file is inside a folder that contains an .asmdef file, please make sure that the assembly definition references NUnit.
    public AltDriver altDriver;
    //Before any test it connects with the socket
    [OneTimeSetUp]
    public void SetUp()
    {
        altDriver = new AltDriver();
    }

    //At the end of the test closes the connection with the socket
    [OneTimeTearDown]
    public void TearDown()
    {
        altDriver.Stop();
    }

    [Test]
    public void LoadStartScene()
    {
        
        altDriver.FindObject(By.NAME, "StartButton").Click(); // Busca el objeto (bot�n) con el nombre
                                                              // StartButton en la jerarqu�a y simula darle click.

        var startGame = altDriver.WaitForObject(By.NAME, "Game"); // Busca el objeto inactivo (que ser�a el panel del juego) con el nombre
                                                                  // Game en la jerarqu�a y lo "almacena" en la variable startGame
        
        Assert.IsTrue(startGame.enabled); // Verifica que el objeto est� activo
        
       
        
        
        altDriver.FindObject(By.NAME, "StartButton").Click(); // Busca el objeto (bot�n) con el nombre
                                                              // StartButton en la jerarqu�a y simula darle click.
        
        altDriver.WaitForCurrentSceneToBe("Start"); // Cambia la escena del men� a la escena de juego 

    }



}