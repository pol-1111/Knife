using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreAndAppleCountSystem : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI appleText;
    [SerializeField] UserData userData;

    private void Start()
    {
        appleText.text = userData.apple.ToString();
        scoreText.text = userData.score.ToString();
    }
    public void AddApple()
    {
        userData.apple++;
        appleText.text = userData.apple.ToString();        
    }
}