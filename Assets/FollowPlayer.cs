using UnityEngine;
using UnityEngine.UI;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Text scoreText;
    private int score;
    private int highScore;

    private float currentY;
    private float previousY;
    private float distance;
    private float totalDistance;

    void Start ()
    {
        previousY = transform.position.y;
        currentY = transform.position.y;
        distance = currentY - previousY;
    }

    void Update ()
    {
        // Follow player if player jump up
        if (player.position.y > transform.position.y)
        {
            // Update Camera position
            transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);

            // Update Score
            previousY = currentY;
            currentY = transform.position.y;
            distance = currentY - previousY;
            totalDistance += distance;

            score = Mathf.RoundToInt(totalDistance / 2 * 100);
            scoreText.text = "" + score;

            // Save Score
            PlayerPrefs.SetInt("score", score);

            // Save high Score
            //highScore = PlayerPrefs.GetInt("highScore");
            if (score > PlayerPrefs.GetInt("highScore"))
            {
                PlayerPrefs.SetInt("highScore", score);
            }
        }
    }
}
