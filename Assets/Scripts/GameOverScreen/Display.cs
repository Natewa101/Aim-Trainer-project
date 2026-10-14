using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Display : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI ScoreDisplay;
    public void Awake()
    {
        ScoreDisplay.text = "Score: " + ScoreManager.instance.score.ToString();
    }
}
