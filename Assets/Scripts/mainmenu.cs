using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    // Start is called before the first frame update

	public GameObject MainMenuPanel;

    public void PlayGame() {
		SceneManager.LoadScene ("GameScene-ALU");
	}
    void Start()
    {
        ShowMainMenu();
    }

public void ShowMainMenu()
	{
		MainMenuPanel.SetActive(true);
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

