using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetPlayers : MonoBehaviour {

    private PlayersManager callFunction;
    public Text player1;
    public Text player2;
    public Text player3;
    public Text player4;
    public Text player5;
    public Text player6;
    public Text player7;
    public Text player8;

    // Use this for initialization
    void Start ()
    {
        callFunction = GetComponent<PlayersManager>();
    }

    public void PlayersToText()
    {
        int length = callFunction.playersArray.Length;
        if (7<length)
        {
            player1.text = callFunction.playersArray[7];
        }else
        {
            player1.text = "null";
        }

        if (0 < length)
        {
            player2.text = callFunction.playersArray[0];
        }
        else
        {
            player2.text = "null";
        }

        if (1 < length)
        {
            player3.text = callFunction.playersArray[1];
        }
        else
        {
            player3.text = "null";
        }

        if (2 < length)
        {
            player4.text = callFunction.playersArray[2];
        }
        else
        {
            player4.text = "null";
        }

        if (3 < length)
        {
            player5.text = callFunction.playersArray[3];
        }
        else
        {
            player5.text = "null";
        }

        if (4 < length)
        {
            player6.text = callFunction.playersArray[4];
        }
        else
        {
            player6.text = "null";
        }

        if (6 < length)
        {
            player7.text = callFunction.playersArray[6];
        }
        else
        {
            player7.text = "null";
        }

        if (5 < length)
        {
            player8.text = callFunction.playersArray[5];
        }
        else
        {
            player8.text = "null";
        }
    }
}
