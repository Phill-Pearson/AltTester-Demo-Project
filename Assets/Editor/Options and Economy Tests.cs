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
    public AltVector2 screenSize;

    //public AltVector2 COIN = new AltVector2(0.79f, 0.95f);
    public AltVector2 GEM = new AltVector2(0.93f, 0.95f);
    public AltVector2 BUY_TEN = new AltVector2(0.30f, 0.20f);
    public AltVector2 BUY_TWENTY_FIVE = new AltVector2(0.55f, 0.20f);
    public AltVector2 BUY_FIFTY = new AltVector2(0.80f, 0.20f);
    
    //Before any test it connects with the socket
    [OneTimeSetUp]
    public void SetUp()
    {
        altDriver =new AltDriver();
        screenSize = altDriver.GetApplicationScreenSize();
    }

    //At the end of the test closes the connection with the socket
    [OneTimeTearDown]
    public void TearDown()
    {
        altDriver.Stop();
    }

// ===================== Buy Economy Items ===================

    [Test]
    public void BuyTheDiamondsUI()
    {
        const string StringNameToCompare = "ShopScreen";
        int ActionNumberValue = 0;
        var ShopScreenObject = altDriver.WaitForObject(By.NAME, "ShopScreen");

        altDriver.MoveMouse(screenSize * GEM, 2);
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

        altDriver.MoveMouse(screenSize * BUY_FIFTY, 2);

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

        altDriver.MoveMouse(screenSize * BUY_TWENTY_FIVE, 2);

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

        altDriver.MoveMouse(screenSize * BUY_TEN, 2);

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