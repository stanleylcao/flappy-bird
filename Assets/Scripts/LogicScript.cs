using UnityEngine;
using UnityEngine.UI;
public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    public void addScore(int increment = 1)
    {
        playerScore += increment;
        scoreText.text = playerScore.ToString();
    }
}
