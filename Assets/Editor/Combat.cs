using NUnit.Framework;
using Altom.AltDriver;

using UnityEngine;


// This is the class that will contain all the tests for the combat menu
public class CombatMenus
{
    public AltDriver altDriver;
    public AltVector2 screenSize;

    private AltVector2 PLAY_BUTTON = new AltVector2(0.85f, 0.25f);
    private AltVector2 PAUSE_BUTTON = new AltVector2(0.95f, 0.95f);
    private AltVector2 RESUME_BUTTON = new AltVector2(0.65f, 0.75f);
    private AltVector2 RESUME_BUTTON_2 = new AltVector2(0.5f, 0.45f);
    private AltVector2 LEAVE_BUTTON = new AltVector2(0.5f, 0.3f);
    private AltVector2 QUIT_BUTTON = new AltVector2(0.5f, 0.25f);

    [OneTimeSetUp]
    public void SetUp()
    {
        altDriver =new AltDriver();

        screenSize = altDriver.GetApplicationScreenSize();
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        altDriver.Stop();
    }

    // utility functions
    // load 
    void EnterGame()
    {
        // insure that the game is in the main menu
        altDriver.LoadScene("MainMenu");
        altDriver.WaitForCurrentSceneToBe("MainMenu");
        Assert.AreEqual(altDriver.GetCurrentScene(), "MainMenu");

        // press the button to start the game
        altDriver.MoveMouse(screenSize * PLAY_BUTTON, 1);
        altDriver.PressKey(AltKeyCode.Mouse0, 0.1f);

        // wait for the game to load
        altDriver.WaitForCurrentSceneToBe("Game");
        Assert.AreEqual(altDriver.GetCurrentScene(), "Game");
    }

    void PauseGame()
    {
        // press the button to pause the game
        altDriver.MoveMouse(screenSize * PAUSE_BUTTON, 1);
        altDriver.SetDelayAfterCommand(2);
        altDriver.PressKey(AltKeyCode.Mouse0, 0.1f);
        
        // check time scale
        
        Assert.AreEqual(altDriver.GetTimeScale(), 0f);
        altDriver.SetDelayAfterCommand(0);
    }

    // make sure that everything loads correctly
    [Test]
    public void EnterGameFromMainMenu()
    {
        EnterGame();

        // make sure that the dragon is in the scene
        AltObject dragon = altDriver.FindObject(By.NAME, "Unit_Dragon_Rustum");
        Assert.AreEqual(dragon.name, "Unit_Dragon_Rustum");

        // make sure that the knight is in the scene
        AltObject knight = altDriver.FindObject(By.NAME, "Unit_Knight_Jarek");
        Assert.AreEqual(knight.name, "Unit_Knight_Jarek");

        // make sure that the witch giorgia is in the scene
        AltObject witch = altDriver.FindObject(By.NAME, "Unit_Witch_Giorgia");
        Assert.AreEqual(witch.name, "Unit_Witch_Giorgia");

        // make sure that the wolfman oriz is in the scene
        AltObject wolfman = altDriver.FindObject(By.NAME, "Unit_Wolfman_Oriz");
        Assert.AreEqual(wolfman.name, "Unit_Wolfman_Oriz");
    }

    [Test]
    public void EnterGameFromMainMenuAndLose()
    {
        EnterGame();

        altDriver.SetTimeScale(10f);

        altDriver.MoveMouse(screenSize * QUIT_BUTTON, 10);
        altDriver.PressKey(AltKeyCode.Mouse0, 0.1f);

        altDriver.WaitForCurrentSceneToBe("MainMenu");
        Assert.AreEqual(altDriver.GetCurrentScene(), "MainMenu");
    }

    

    [Test]
    public void EnterGameFromMainMenuAndPause()
    {
        EnterGame();

        PauseGame();
        
        altDriver.MoveMouse(screenSize * RESUME_BUTTON, 1);
        altDriver.PressKey(AltKeyCode.Mouse0, 0.1f);

        PauseGame();

        altDriver.MoveMouse(screenSize * RESUME_BUTTON_2, 1);
        altDriver.PressKey(AltKeyCode.Mouse0, 0.1f);

        PauseGame();
    }

    [Test]
    public void EnterGameFromMainMenuAndLeave()
    {
        EnterGame();

        PauseGame();

        // press the button to leave the game
        altDriver.MoveMouse(screenSize * LEAVE_BUTTON, 1);
        altDriver.PressKey(AltKeyCode.Mouse0, 0.1f);

        // wait for the game to return to the main menu
        altDriver.WaitForCurrentSceneToBe("MainMenu");
        Assert.AreEqual(altDriver.GetCurrentScene(), "MainMenu");
    }
}

// this is the class that will contain all the tests for the combat gameplay
public class CombatGameplay
{
    public AltDriver altDriver;
    [OneTimeSetUp]
    public void SetUp()
    {
        altDriver =new AltDriver();

        // insure that game is loaded
        altDriver.LoadScene("Game");
        altDriver.WaitForCurrentSceneToBe("Game");
        Assert.AreEqual(altDriver.GetCurrentScene(), "Game");
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        altDriver.Stop();
    }

    [Test]
    public void LoadsCorrectly()
    {
        // make sure that the dragon is in the scene
        AltObject dragon = altDriver.FindObject(By.NAME, "Unit_Dragon_Rustum");
        Assert.AreEqual(dragon.name, "Unit_Dragon_Rustum");
    }

    // cursed UIkit makes dragging very difficult, mouse position not being read correctly
    // [Test]
    // public void UsePotion() {
    //     // altDriver.MoveMouse(new AltVector2(40f, 40f), 1);
    //     // altDriver.KeyDown(AltKeyCode.Mouse0, 1);
    //     // altDriver.MoveMouse(new AltVector2(256f, 256f), 1);
    //     // altDriver.KeyUp(AltKeyCode.Mouse0);
    //     // altDriver.MoveMouse(new AltVector2(40f, 40f), 5);

    //     // altDriver.BeginTouch(new AltVector2(40f, 40f));
    //     // altDriver.MoveTouch(0, new AltVector2(256f, 256f));
    //     // altDriver.EndTouch(0);
    // }
}