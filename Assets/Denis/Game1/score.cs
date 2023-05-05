using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text lifeText;
    


    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + star.money.ToString();
        lifeText.text = "Life: " + star.life.ToString();

    }
}
