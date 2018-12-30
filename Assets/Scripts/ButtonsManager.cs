using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ButtonsManager : MonoBehaviour
{
    public PlayersManager callFunction;
    public SetPlayers setPlayersScript;
    public Text nickname;
    public GameObject upperBracket;
    public GameObject lowerBracket;
    public GameObject screen;
    public GameObject brackets;

    public void CreateNewTournament()
    {
        SceneManager.LoadScene("AddPlayers");
    }

    public void QuitAPP()
    {
        Application.Quit();
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Add()
    {
        callFunction.AddPlayer(nickname.text);
        callFunction.updateText();
    }

    public void StartTournament()
    {
        callFunction.ToArray();
        callFunction.SortPlayers();
        setPlayersScript.PlayersToText();
        screen.SetActive(false);
        brackets.SetActive(true);
    }

    public void ShowAnotherBracker()
    {
        if (upperBracket.active)
        {
            upperBracket.SetActive(false);
            lowerBracket.SetActive(true);
        }else
        {
            lowerBracket.SetActive(false);
            upperBracket.SetActive(true);
        }
        
    }
}
