using NUnit.Framework;
using Altom.AltDriver;

public class ResearchTests
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
    public void FindHiddenObjects()
    {
        // Find all objects in the scene
        var allObjects = altDriver.GetAllElements();

        // Iterate through all objects to find hidden objects
        foreach (var obj in allObjects)
        {
            if (obj != null)
            {
                // Print the name or ID of the object
                //Debug.Log("Object found: " + obj.name + ", " + obj.id);

            }
        }
    }

    [Test]
    public void TestForSceneSwitching()
    {
        // switch to main menu
        altDriver.LoadScene("MainMenu");
        altDriver.WaitForCurrentSceneToBe("MainMenu");
        //Debug.Log("Scene is Main Menu");

        // switch to game in progress
        altDriver.LoadScene("Game");
        altDriver.WaitForCurrentSceneToBe("Game");
        //Debug.Log("Scene is Game");

        // switch back to main menu
        altDriver.LoadScene("MainMenu");
        altDriver.WaitForCurrentSceneToBe("MainMenu");
        //Debug.Log("Scene is Main Menu");

    }

    [Test]
    public void FindHiddenObjectsResearchVersion()
    {
        // Find all objects in the scene
        var allObjects = altDriver.GetAllElements();
        // Iterate through all objects to find hidden objects
        foreach (var obj in allObjects)
        {
            if (obj != null)
            {
                // Print the name or ID of the object
                //Debug.Log("Object found: " + obj.name + ", " + obj.id);

                // Get all objects that have the current object as their parent
                var children = altDriver.FindObjects(By.NAME, obj.name);

                // Iterate through each child object to find hidden objects
                foreach (var child in children)
                {
                    if (child != null)
                    {
                        // Print the name or ID of the hidden child object
                        //Debug.Log("Child object found: " + child.name + ", " + child.id);

                    }
                }
            }
        }
    }

}