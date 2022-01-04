using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private float score;
    public GameObject bg1;
    public GameObject bg2;
    public GameObject bg3;

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();

            if (scoreText.text.Equals("10"))
            {
                bg1.SetActive(false);
                bg2.SetActive(true);
                bg3.SetActive(false);
            }

            if (scoreText.text.Equals("20"))
            {
                bg1.SetActive(false);
                bg2.SetActive(false);
                bg3.SetActive(true);
            }
        }
    }
}