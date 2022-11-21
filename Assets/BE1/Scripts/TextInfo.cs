using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInfo : MonoBehaviour
{
    public enum Info { Level, Score, Health, HighScore }

    public Info uiType;

    private Text myText;

    private void Awake()
    {
        myText = GetComponent<Text>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        switch (uiType)
        {
            case Info.Level:
                myText.text = "스테이지 " + GameManager.level;
                break;
            case Info.Score:
                myText.text = string.Format("{0:D3}",GameManager.score);
                break;
            case Info.Health:
                myText.text = "남은 공 " + GameManager.health + "개";
                break;
            case Info.HighScore:
                myText.text = "최고점수 " + PlayerPrefs.GetInt("Score");
                break;
        }
    }
}
