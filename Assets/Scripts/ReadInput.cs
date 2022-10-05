using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ReadInput : MonoBehaviour
{
    public TextMeshProUGUI userName;
    public TMP_InputField userInput;
    public TextMeshProUGUI highScorePlayerText;

    private void Start()
    {
        highScorePlayerText.text = "Best Score: " + MenuManager.instance.highScore + " Name: " + MenuManager.instance.playerHighScoreName;
    }


    public void SetName()
    {
        userName.text = userInput.text;
        MenuManager.instance.playerName = userName.text;
    }

    

}
