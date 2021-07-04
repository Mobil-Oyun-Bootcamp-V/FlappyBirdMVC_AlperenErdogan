using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIView : MonoBehaviour
{
    private int _score;
    public Text _scoreText;
    public GameObject deathPanel;
    void Start()
    {
        _score = 0;
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GetScore()
    {
        _score++;
        _scoreText.text = _score.ToString();
    }

    public void OnDeath()
    {
        Time.timeScale = 0;
        deathPanel.SetActive(true);
    }
}
