using NUnit.Framework;
using AltTester.AltTesterUnitySDK.Driver;

public class CatPrefabTest
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
    public void CatPrefabIsVisible()
    {
        AltObject catPrefab = altDriver.FindObject(By.NAME, "CatMesh"); // Busca el objeto (la mesh del prefab del gato) con el nombre CatMesh en
                                                                        // la jerarquía y lo "almacena" en la variable catPrefab
                                                                        
        Assert.IsTrue(catPrefab.enabled); // Verifica que la mesh del prefab del gato esté activa
    }

}