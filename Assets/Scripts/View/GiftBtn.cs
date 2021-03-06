using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiftBtn : MonoBehaviour
{
    [SerializeField] MatchData data;
    Image btnImg;
    bool startTimer;
    bool colorCh;
    [SerializeField] float delay = 0.5f;
    float temp;

    private void Awake()
    {
        btnImg = GetComponent<Image>();
    }

    

    private void FixedUpdate()
    {
        if (data.isGift && !startTimer )
        {
            ChangeColor();
            startTimer = true;
            temp = delay;
        }
        if (startTimer)
        {
            temp -= 0.02f;
            if(temp <= 0)
            {
                startTimer = false;
            }
        }
    }

    private void ChangeColor()
    {
        colorCh = !colorCh;
        btnImg.color = colorCh ? Color.white : Color.cyan;
    }
}
