using ColorDash.Managers.AudioManager;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class In_Game_UI : MonoBehaviour
{
    public static In_Game_UI instance;

    [Header("P A N E L:")]
    [SerializeField] private GameObject GameoverPanel;

    [Header("L I V E  S C O R E  T E X T:")]
    [SerializeField] private TMP_Text _ScoreText;
    [SerializeField] private TMP_Text _HighScoreText;

    [Header("G A M E  O V E R  T E X T")]
    [SerializeField] private TMP_Text _GameOverScoreText;
    [SerializeField] private TMP_Text _GameOverHighScoreText;

    [Space(5f)]
    [Header("B U T T O N S:")]
    [SerializeField] private Button _PlayButton;
    [SerializeField] private Button _RetryButton;
    [SerializeField] private Button _QuitButton;

    [Header("U N I T Y  E V E N T S:")]
    public UnityEvent OnPlay;

    private int Score;
    private int HighScore = 0;

    private void OnEnable()
    {
        _PlayButton.onClick.AddListener(Play);
        _QuitButton.onClick.AddListener(OnQuit);
        _RetryButton.onClick.AddListener(OnRetry);
    }

    private void Awake()
    {
        instance = this;
        HighScore = PlayerPrefs.GetInt("HighScore", 0);
        UpdateScoreUI();
    }

    public void InceraseScore(int Value)
    {
        Score += Value;

        if (Score > HighScore)
        {
            HighScore = Score;
            PlayerPrefs.SetInt("HighScore", HighScore);
        }
        UpdateScoreUI();
    }

    public void GameOverUI()
    {
        Audio_Manager.AudioInstance.PlaySFX(1);
        GameoverPanel.SetActive(true);
        _GameOverScoreText.text = $"Score:{Score}";
        _GameOverHighScoreText.text = $"HighScore:{HighScore}";
    }

    public void UpdateScoreUI()
    {
        _ScoreText.text = $"Score:{Score}";
        _HighScoreText.text = $"HighScore:{HighScore}";
    }

    private void Play()
    {
        OnPlay.Invoke();
    }

    private void OnRetry()
    {
        Audio_Manager.AudioInstance.PlaySFX(0);
        Time.timeScale = 1.0f;
        GameoverPanel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
