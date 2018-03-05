using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public static Player instance;

    public Rigidbody2D player;
    public GameObject gameOverText;
    public Text scoreText;
    public Text GameOverScore;
    public Text GameOverHighScore;
    public GameObject randomTrap;

    public bool gameOver = false;
    private float jumpForce;

    private int score;
    private int highScore;

    // Singleton
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start()
    {
        player.gravityScale = 0f;
        jumpForce = 8f;
    }

    // Update is called once per frame
    void Update()
    {
        // When Player tap the screen
        if (Input.GetMouseButtonDown(0))
        {
            player.velocity = Vector2.up * jumpForce;
            player.gravityScale = 3f;
        }
    }

    // Collision
    void OnTriggerEnter2D(Collider2D collider)
    {
        // Traps
        if (collider.tag == "Trap")
        {
            Debug.Log("GAME OVER!");

            // Player died
            PlayerDied();
        }

        // Re-Allocate Trap
        if (collider.tag == "TrapTrigger")
        {
            Vector2 newTrapOffset = new Vector2(0f, collider.gameObject.transform.position.y + 75f);
            collider.gameObject.transform.parent.position = newTrapOffset;
        }
    }

    // Player DIE
    public void PlayerDied ()
    {
        scoreText.gameObject.SetActive(false);
        player.gameObject.SetActive(false);
        
        // Show Game over
        gameOver = true;
        gameOverText.SetActive(true);
        
        // Show Scores
        score = PlayerPrefs.GetInt("score");
        highScore = PlayerPrefs.GetInt("highScore");

        GameOverScore.text = score + "";
        GameOverHighScore.text = highScore + "";
    }

    // Restart Game
    public void RestartGame ()
    {
        // Reload game scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        player.gravityScale = 0f;
        PlayerPrefs.SetInt("score", 0);
    }

    // Return to Main menu
    public void ShowMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
