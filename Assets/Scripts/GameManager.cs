using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gemeOverText;
    [SerializeField] GameObject gemeClearText;
    [SerializeField] Text scoreText;


    // SE
    [SerializeField] AudioClip gameClearSE;
    [SerializeField] AudioClip gameOverSE;
    AudioSource audioSource;

    const int MAX_SCORE = 9999;
    int score = 0;

    private void Start()
    {
        scoreText.text = score.ToString();
        audioSource = GetComponent<AudioSource>();
    }

    public void AddScore(int val)
    {
        score += val;
        if (score > MAX_SCORE)
        {
            score = MAX_SCORE;
        }
        scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        gemeOverText.SetActive(true);
        audioSource.PlayOneShot(gameOverSE);
        Invoke("RestartScene", 1.5f);
    }

    public void GameClear()
    {
        gemeClearText.SetActive(true);
        audioSource.PlayOneShot(gameClearSE);
        Invoke("RestartScene", 1.5f);
    }

    void RestartScene()
    {
        
        Scene thisScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(thisScene.name);
    }
}
