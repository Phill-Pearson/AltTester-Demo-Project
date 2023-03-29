using NUnit.Framework;
using Altom.AltDriver;
using System.Collections;
using UnityEngine;
using UnityEngine.TestTools;
using System.Linq;

// Class that constructs the basic x and y layouts for defining postional variables for the Menu Buttons
public class OptionsIconConstructor {
    public float x { get; set; }
    public float y { get; set; }
}

public class OptionsandEconomyTests
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

// ===================== Buy Economy Items ===================

    [Test]
    public void BuyTheCoinsUI()
    {
        const string StringNameToCompare = "ShopScreen";
        int ActionNumberValue = 0;
        var CoinShopIcon = new OptionsIconConstructor { x = 736f, y = 370f };
        var ShopScreenObject = altDriver.WaitForObject(By.NAME, "ShopScreen");

        altDriver.MoveMouse(new AltVector2(CoinShopIcon.x, CoinShopIcon.y), 1);
        altDriver.PressKey(AltKeyCode.Mouse0, 0.1f);
        ActionNumberValue++;
        Debug.Log("Action " + ActionNumberValue + ": Clicked The Coin shop Icon!");

        // verify we are on the shop screen
        if (ShopScreenObject.name == "ShopScreen")
        {
            Assert.AreEqual(ShopScreenObject.name, StringNameToCompare);
            ActionNumberValue++;
            Debug.Log("Action " + ActionNumberValue + ": Assertion that popup screen is: " + ShopScreenObject.name);
        }
        else
        {
            Debug.Log("Did not find: " + StringNameToCompare);
            Assert.Fail();
        }

        var FiftyCoins = new OptionsIconConstructor { x = 230f, y = 68f };
        var TwoHundredAndFiftyCoins = new OptionsIconConstructor { x = 400f, y = 68f };
        var SixHundredCoins = new OptionsIconConstructor { x = 600f, y = 68f };
        // var OneThousandFiveHundredCoins = new OptionsIconConstructor { x = 280f, y = 68f };  This will need comfirming after working out scroll vectors tested

        // scroll vectors
        var InitialScrollCoords = new OptionsIconConstructor { x = 220f, y = 20f };
        var EndScrollCoords = new OptionsIconConstructor { x = 750f, y = 20f };

        altDriver.MoveMouse(new AltVector2(InitialScrollCoords.x, InitialScrollCoords.y), 1); // start point over the scroll bar
        // mouse will need to be held down and scrolled here
        altDriver.MoveMouse(new AltVector2(EndScrollCoords.x, EndScrollCoords.y), 1); // scroll will ned up at these coordinates

        // Next we will need to go to the last coin shop item on the right and click it.
        // altDriver.MoveMouse(new AltVector2(OneThousandFiveHundredCoins.x, OneThousandFiveHundredCoins.y), 1)

        // Ideally we want to find a way to check the values that have been added each time the mouse has clicked the appropriate buttons,
        // though this we may need to forgo this based on current time constraints.

    }

    [Test]
    public void BuyTheDiamondsUI()
    {
        const string StringNameToCompare = "ShopScreen";
        int ActionNumberValue = 0;
        var DiamondShopIcon = new OptionsIconConstructor { x = 840f, y = 370f };
        var ShopScreenObject = altDriver.WaitForObject(By.NAME, "ShopScreen");
        var FiftyDiamonds = new OptionsIconConstructor { x = 618f, y = 60f };
        var TwentyFiveDiamonds = new OptionsIconConstructor { x = 430f, y = 60f };
        var TenDiamonds = new OptionsIconConstructor { x = 250f, y = 60f };

        altDriver.MoveMouse(new AltVector2(DiamondShopIcon.x, DiamondShopIcon.y), 1);
        altDriver.PressKey(AltKeyCode.Mouse0, 0.1f);
        ActionNumberValue++;
        Debug.Log("Action " + ActionNumberValue + ": Clicked the Diamond shop Icon!");

        // verify we are on the shop screen
        if (ShopScreenObject.name == "ShopScreen")
        {
            Assert.AreEqual(ShopScreenObject.name, StringNameToCompare);
            ActionNumberValue++; 
            Debug.Log("Action " + ActionNumberValue + ": Assertion that popup screen is: " + ShopScreenObject.name);
        }
        else
        {
            Debug.Log("Did not find: " + StringNameToCompare);
            Assert.Fail();
        }

        altDriver.MoveMouse(new AltVector2(FiftyDiamonds.x, FiftyDiamonds.y), 1);

        // loop through and click 10 up to 10 times
        for (int i = 1; i < 11; i++)
        {
            altDriver.PressKey(AltKeyCode.Mouse0, 0.1f);
            ActionNumberValue++;
            
            // check if the the i value needs to be semantically returned as a plural value
            if (i < 2)
            {
                Debug.Log("Action " + ActionNumberValue + ": Bought 50 Diamonds " + i + " time");
            }
            else
            {
                Debug.Log("Action " + ActionNumberValue + ": Bought 50 Diamonds " + i + " times");
            }
        }

        altDriver.MoveMouse(new AltVector2(TwentyFiveDiamonds.x, TwentyFiveDiamonds.y), 1);

        // loop through and click 10 up to 10 times
        for (int i = 1; i < 11; i++)
        {
            altDriver.PressKey(AltKeyCode.Mouse0, 0.1f);
            ActionNumberValue++;
            
            // check if the the i value needs to be semantically returned as a plural value
            if (i < 2)
            {
                Debug.Log("Action " + ActionNumberValue + ": Bought 25 Diamonds " + i + " time");
            }
            else
            {
                Debug.Log("Action " + ActionNumberValue + ": Bought 25 Diamonds " + i + " times");
            }
        }

        altDriver.MoveMouse(new AltVector2(TenDiamonds.x, TenDiamonds.y), 1);

        // loop through and click 10 up to 10 times
        for (int i = 1; i < 11; i++)
        {
            altDriver.PressKey(AltKeyCode.Mouse0, 0.1f);
            ActionNumberValue++;
            
            // check if the the i value needs to be semantically returned as a plural value
            if (i < 2)
            {
                Debug.Log("Action " + ActionNumberValue + ": Bought 10 Diamonds " + i + " time");
            }
            else
            {
                Debug.Log("Action " + ActionNumberValue + ": Bought 10 Diamonds " + i + " times");
            }
        }
    }
}