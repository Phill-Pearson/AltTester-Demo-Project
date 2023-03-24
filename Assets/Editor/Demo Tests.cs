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

        // Find the HomeScreen object
        var HomeScreen = altDriver.FindObject(By.NAME, "HomeScreen");
        // Waight for the object to assert
        var CharScreenObject = altDriver.WaitForObject(By.NAME, "CharScreen");

        // Declare constant string name
        const string name = "CharScreen";
        // Declare our positons
        var HeroesMenuIcon = new MenuIconConstructor { x = 40f, y = 200f };

        // Use a vector 2 to click on home screen
        altDriver.MoveMouse(new AltVector2(HomeScreen.x, HomeScreen.y), 1);
        altDriver.PressKey(AltKeyCode.Mouse0, 0.1f);

        // use positional variables to go to and click a new vector2 
        altDriver.MoveMouse(new AltVector2(HeroesMenuIcon.x, HeroesMenuIcon.y), 1);
        altDriver.PressKey(AltKeyCode.Mouse0, 0.1f);
        Debug.Log("Action 1: Heroes Menu Icon was clicked!");

        // if the CharScreen object is visible on the screen, then assert
        if (CharScreenObject.name == "CharScreen")
        {
            Assert.AreEqual(CharScreenObject.name, name);
            Debug.Log("Action 2: Assertion that popup screen is: " + CharScreenObject.name);
        }
        
    }

    [Test]
    public void ClickTheHomeMenuIcon()
    {

        // Find the HomeScreen object
        var HomeScreen = altDriver.FindObject(By.NAME, "HomeScreen");

        // Declare our positons
        var HomeMenuIcon = new MenuIconConstructor { x = 40f, y = 260f };

        // Use a vector 2 to click on home screen
        altDriver.MoveMouse(new AltVector2(HomeScreen.x, HomeScreen.y), 1);
        altDriver.PressKey(AltKeyCode.Mouse0, 0.1f);

        // use positional variables to go to and click a new vector2 
        altDriver.MoveMouse(new AltVector2(HomeMenuIcon.x, HomeMenuIcon.y), 1);
        altDriver.PressKey(AltKeyCode.Mouse0, 0.1f);
        Debug.Log("Home Menu Icon was clicked!");

    }

    [Test]
    public void ClickTheResourcesMenuIcon()
    {

        // Find the HomeScreen object
        var HomeScreen = altDriver.FindObject(By.NAME, "HomeScreen");

        // Declare our positons
        var ResourcesMenuIcon = new MenuIconConstructor { x = 40f, y = 140f };

        // Use a vector 2 to click on home screen
        altDriver.MoveMouse(new AltVector2(HomeScreen.x, HomeScreen.y), 1);
        altDriver.PressKey(AltKeyCode.Mouse0, 0.1f);

        // use positional variables to go to and click a new vector2 
        altDriver.MoveMouse(new AltVector2(ResourcesMenuIcon.x, ResourcesMenuIcon.y), 1);
        altDriver.PressKey(AltKeyCode.Mouse0, 0.1f);
        Debug.Log("Resources Menu Icon was clicked!");

    }

    [Test]
    public void ClickTheShopMenuIcon()
    {

        // Find the HomeScreen object
        var HomeScreen = altDriver.FindObject(By.NAME, "HomeScreen");

        // Declare our positons
        var ShopMenuIcon = new MenuIconConstructor { x = 40f, y = 90f };

        // Use a vector 2 to click on Home screen
        altDriver.MoveMouse(new AltVector2(HomeScreen.x, HomeScreen.y), 1);
        altDriver.PressKey(AltKeyCode.Mouse0, 0.1f);

        // use positional variables to go to and click a new vector2 
        altDriver.MoveMouse(new AltVector2(ShopMenuIcon.x, ShopMenuIcon.y), 1);
        altDriver.PressKey(AltKeyCode.Mouse0, 0.1f);
        Debug.Log("Shop Menu Icon was clicked!");

    }

    [Test]
    public void ClickTheMailMenuIcon()
    {

        // Find the HomeScreen object
        var HomeScreen = altDriver.FindObject(By.NAME, "HomeScreen");

        // Declare our positons
        var MailMenuIcon = new MenuIconConstructor { x = 40f, y = 30f };

        // Use a vector 2 to click on Home screen
        altDriver.MoveMouse(new AltVector2(HomeScreen.x, HomeScreen.y), 1);
        altDriver.PressKey(AltKeyCode.Mouse0, 0.1f);

        // use positional variables to go to and click a new vector2 
        altDriver.MoveMouse(new AltVector2(MailMenuIcon.x, MailMenuIcon.y), 1);
        altDriver.PressKey(AltKeyCode.Mouse0, 0.1f);
        Debug.Log("Mail Menu Icon was clicked!");

    }

}