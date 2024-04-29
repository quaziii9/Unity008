using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public TextMeshProUGUI ScoreText;

    private int score = 0;



    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.Log("2�� �̻� ���� �Ŵ����� �����մϴ�");
            Destroy(gameObject);
        }    
    }

    public void AddScore(int newScore)
    {
        score += newScore;
        ScoreText.text = "Score : " + score;
    }
}
