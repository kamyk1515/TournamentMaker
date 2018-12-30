using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayersManager : MonoBehaviour
{
    List<string> playersList = new List<string>();
    public Text playersListText;
    public string[] playersArray;

    public void AddPlayer(string nickname)
    {
        playersList.Add(nickname);
    }

    public void updateText()
    {
        playersListText.text = null;
        for (int i = 0; i < playersList.Count; i++)
        {
            playersListText.text = playersListText.text + playersList[i] + '\n';
        }
    }

    public void ToArray()
    {
        playersArray = playersList.ToArray();
    }

    public void SortPlayers()
    {
        for (int t = 0; t < playersArray.Length; t++)
        {
            string tmp = playersArray[t];
            int r = Random.Range(t, playersArray.Length);
            playersArray[t] = playersArray[r];
            playersArray[r] = tmp;
        }
    }
}
