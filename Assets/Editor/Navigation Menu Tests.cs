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


// ================== Click the Main Menu Navigation Icons

    [Test]
    public void ClickTheHeroesMenuIcon()
    {

        // Declare the important variable. a string name "CharScreen".
        // A new object from the class constructor.
        const string StringNameToCompare = "CharScreen";
        var HeroesMenuIcon = new MenuIconConstructor { x = 40f, y = 200f };
        var GetCurrentScene = altDriver.GetCurrentScene();


        if (GetCurrentScene == "MainMenu")
        {
            var HomeScreen = altDriver.FindObject(By.NAME, "HomeScreen");
            var CharScreenObject = altDriver.WaitForObject(By.NAME, "CharScreen");

            // use positional variables to go to and click a new vector2 
            altDriver.MoveMouse(new AltVector2(HeroesMenuIcon.x, HeroesMenuIcon.y), 1);
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

        const string StringNameToCompare = "HomeScreen";
        var HomeMenuIcon = new MenuIconConstructor { x = 40f, y = 260f };
        var GetCurrentScene = altDriver.GetCurrentScene();

        if (GetCurrentScene == "MainMenu")
        {
            var HomeScreenObject = altDriver.WaitForObject(By.NAME, "HomeScreen");
            
            // use positional variables to go to and click a new vector2 
            altDriver.MoveMouse(new AltVector2(HomeMenuIcon.x, HomeMenuIcon.y), 1);
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

        const string StringNameToCompare = "InventoryScreen";
        var ResourcesMenuIcon = new MenuIconConstructor { x = 40f, y = 140f };
        var GetCurrentScene = altDriver.GetCurrentScene();

        if (GetCurrentScene == "MainMenu")
        {
            var InventoryScreenObject = altDriver.WaitForObject(By.NAME, "InventoryScreen");
            
            // use positional variables to go to and click a new vector2 
            altDriver.MoveMouse(new AltVector2(ResourcesMenuIcon.x, ResourcesMenuIcon.y), 1);
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

        const string StringNameToCompare = "ShopScreen";
        var ShopMenuIcon = new MenuIconConstructor { x = 40f, y = 90f };
        var GetCurrentScene = altDriver.GetCurrentScene();

        if (GetCurrentScene == "MainMenu")
        {
            var ShopScreenObject = altDriver.WaitForObject(By.NAME, "ShopScreen");
            
            // use positional variables to go to and click a new vector2 
            altDriver.MoveMouse(new AltVector2(ShopMenuIcon.x, ShopMenuIcon.y), 1);
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

        const string StringNameToCompare = "MailScreen";
        var MailMenuIcon = new MenuIconConstructor { x = 40f, y = 30f };
        var GetCurrentScene = altDriver.GetCurrentScene();

        if (GetCurrentScene == "MainMenu")
        {
            var MailScreenObject = altDriver.WaitForObject(By.NAME, "MailScreen");
            
            // use positional variables to go to and click a new vector2 
            altDriver.MoveMouse(new AltVector2(MailMenuIcon.x, MailMenuIcon.y), 1);
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