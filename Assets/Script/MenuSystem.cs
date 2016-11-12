using UnityEngine;
using System.Collections;

public class MenuSystem : MonoBehaviour {

    [SerializeField]
    GameObject MainMenu;
    [SerializeField]
    GameObject HowMenu;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //when you press the start game button on the main menu it will load in the game
    public void StartGame()
    {
        Application.LoadLevel("Apartment");
    }

    //when you press the how to play button on the main menu will switch the game to this screen
    public void HowToMenu()
    {
        MainMenu.SetActive(false);
        HowMenu.SetActive(true);
    }
    //back button on the how to play screen
    public void goBack()
    {
        HowMenu.SetActive(false);
        MainMenu.SetActive(true);
    }
}
