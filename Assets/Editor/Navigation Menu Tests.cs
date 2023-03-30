using NUnit.Framework;
using Altom.AltDriver;
using System.Collections;
using UnityEngine;
using UnityEngine.TestTools;
using System.Linq;

// Class that constructs the basic x and y layouts for defining postional variables for the Menu Buttons
public class MenuIconConstructor {
    public float x { get; set; }
    public float y { get; set; }
}


public class NavigationMenuTests
{   //Important! If your test file is inside a folder that contains an .asmdef file, please make sure that the assembly definition references NUnit.
    public AltDriver altDriver;
    public AltVector2 screenSize;

    AltVector2 HomeMenuIcon = new AltVector2(0.05f, 0.65f);
    AltVector2 HeroesMenuIcon = new AltVector2(0.05f, 0.55f);
    AltVector2 ResourcesMenuIcon = new AltVector2(0.05f, 0.40f);
    AltVector2 ShopMenuIcon = new AltVector2(0.05f, 0.25f);
    AltVector2 MailMenuIcon = new AltVector2(0.05f, 0.10f);


    //Before any test it connects with the socket
    [OneTimeSetUp]
    public void SetUp()
    {
        altDriver = new AltDriver();
        screenSize = altDriver.GetApplicationScreenSize();
    }

    //At the end of the test closes the connection with the socket
    [OneTimeTearDown]
    public void TearDown()
    {
        altDriver.Stop();
    }


// ================== Click the Main Menu Navigation Icons

    [Test]
    public void ClickTheHeroesMenuIcon()
    {

        altDriver.LoadScene("MainMenu");
        altDriver.WaitForCurrentSceneToBe("MainMenu");
        Assert.AreEqual(altDriver.GetCurrentScene(), "MainMenu");

        const string StringNameToCompare = "CharScreen";
        var GetCurrentScene = altDriver.GetCurrentScene();

        if (GetCurrentScene == "MainMenu")
        {
            var HomeScreen = altDriver.FindObject(By.NAME, "HomeScreen");
            var CharScreenObject = altDriver.WaitForObject(By.NAME, "CharScreen");

            // use positional variables to go to and click a new vector2 
            altDriver.MoveMouse(screenSize * HeroesMenuIcon, 1);
            altDriver.PressKey(AltKeyCode.Mouse0, 0.1f);
            Debug.Log("Action 1: Heroes Menu Icon was clicked!");

            // if the CharScreen object is visible on the screen, then assert
            if (CharScreenObject.name == "CharScreen")
            {
                Assert.AreEqual(CharScreenObject.name, StringNameToCompare);
                Debug.Log("Action 2: Assertion that popup screen is: " + CharScreenObject.name);
            }
            else
            {
                Debug.Log("The End result was not expected!");
                Assert.Fail();
            }
        }
        else
        {
            Debug.Log("Wrong Scene Loaded!");
            Assert.Fail();
        }
        
    }

    [Test]
    public void ClickTheHomeMenuIcon()
    {

        altDriver.LoadScene("MainMenu");
        altDriver.WaitForCurrentSceneToBe("MainMenu");
        Assert.AreEqual(altDriver.GetCurrentScene(), "MainMenu");

        const string StringNameToCompare = "HomeScreen";
        var GetCurrentScene = altDriver.GetCurrentScene();

        if (GetCurrentScene == "MainMenu")
        {
            var HomeScreenObject = altDriver.WaitForObject(By.NAME, "HomeScreen");
            
            // use positional variables to go to and click a new vector2 
            altDriver.MoveMouse(screenSize * HomeMenuIcon, 1);
            altDriver.PressKey(AltKeyCode.Mouse0, 0.1f);
            Debug.Log("Action 1: Home Menu Icon was clicked!");

            // if the CharScreen object is visible on the screen, then assert
            if (HomeScreenObject.name == "HomeScreen")
            {
                Assert.AreEqual(HomeScreenObject.name, StringNameToCompare);
                Debug.Log("Action 2: Assertion that popup screen is: " + HomeScreenObject.name);
            }
            else
            {
                Debug.Log("The End result was not expected!");
                Assert.Fail();
            }
        }
        else
        {
            Debug.Log("Wrong Scene Loaded!");
            Assert.Fail();
        }

    }

    [Test]
    public void ClickTheResourcesMenuIcon()
    {
        altDriver.LoadScene("MainMenu");
        altDriver.WaitForCurrentSceneToBe("MainMenu");
        Assert.AreEqual(altDriver.GetCurrentScene(), "MainMenu");

        const string StringNameToCompare = "InventoryScreen";
        var GetCurrentScene = altDriver.GetCurrentScene();

        if (GetCurrentScene == "MainMenu")
        {
            var InventoryScreenObject = altDriver.WaitForObject(By.NAME, "InventoryScreen");
            
            // use positional variables to go to and click a new vector2 
            altDriver.MoveMouse(screenSize * ResourcesMenuIcon, 1);
            altDriver.PressKey(AltKeyCode.Mouse0, 0.1f);
            Debug.Log("Action 1: Resources Menu Icon was clicked!");

            // if the CharScreen object is visible on the screen, then assert
            if (InventoryScreenObject.name == "InventoryScreen")
            {
                Assert.AreEqual(InventoryScreenObject.name, StringNameToCompare);
                Debug.Log("Action 2: Assertion that popup screen is: " + InventoryScreenObject.name);
            }
            else
            {
                Debug.Log("The End result was not expected!");
                Assert.Fail();
            }
        }
        else
        {
            Debug.Log("Wrong Scene Loaded!");
            Assert.Fail();
        }

    }

    [Test]
    public void ClickTheShopMenuIcon()
    {
        altDriver.LoadScene("MainMenu");
        altDriver.WaitForCurrentSceneToBe("MainMenu");
        Assert.AreEqual(altDriver.GetCurrentScene(), "MainMenu");

        const string StringNameToCompare = "ShopScreen";
        var GetCurrentScene = altDriver.GetCurrentScene();

        if (GetCurrentScene == "MainMenu")
        {
            var ShopScreenObject = altDriver.WaitForObject(By.NAME, "ShopScreen");
            
            // use positional variables to go to and click a new vector2 
            altDriver.MoveMouse(screenSize * ShopMenuIcon, 1);
            altDriver.PressKey(AltKeyCode.Mouse0, 0.1f);
            Debug.Log("Action 1: Shop Menu Icon was clicked!");

            // if the CharScreen object is visible on the screen, then assert
            if (ShopScreenObject.name == "ShopScreen")
            {
                Assert.AreEqual(ShopScreenObject.name, StringNameToCompare);
                Debug.Log("Action 2: Assertion that popup screen is: " + ShopScreenObject.name);
            }
            else
            {
                Debug.Log("The End result was not expected!");
                Assert.Fail();
            }
        }
        else
        {
            Debug.Log("Wrong Scene Loaded!");
            Assert.Fail();
        }

    }

    [Test]
    public void ClickTheMailMenuIcon()
    {
        altDriver.LoadScene("MainMenu");
        altDriver.WaitForCurrentSceneToBe("MainMenu");
        Assert.AreEqual(altDriver.GetCurrentScene(), "MainMenu");

        const string StringNameToCompare = "MailScreen";
        var GetCurrentScene = altDriver.GetCurrentScene();

        if (GetCurrentScene == "MainMenu")
        {
            var MailScreenObject = altDriver.WaitForObject(By.NAME, "MailScreen");
            
            // use positional variables to go to and click a new vector2 
            altDriver.MoveMouse(screenSize * MailMenuIcon, 1);
            altDriver.PressKey(AltKeyCode.Mouse0, 0.1f);
            Debug.Log("Action 1: Mail Menu Icon was clicked!");

            // if the CharScreen object is visible on the screen, then assert
            if (MailScreenObject.name == "MailScreen")
            {
                Assert.AreEqual(MailScreenObject.name, StringNameToCompare);
                Debug.Log("Action 2: Assertion that popup screen is: " + MailScreenObject.name);
            }
            else
            {
                Debug.Log("The End result was not expected!");
                Assert.Fail();
            }
        }
        else
        {
            Debug.Log("Wrong Scene Loaded!");
            Assert.Fail();
        }


    }

}