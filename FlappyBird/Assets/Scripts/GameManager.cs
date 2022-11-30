using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score;
    
    public void GameOver()
    {
        Debug.Log("game oveeeeeeeeeeeer");
    }

    public void IncreaseScore()
    {
        score++;
        Debug.Log("score is: " + score);
    }
}
