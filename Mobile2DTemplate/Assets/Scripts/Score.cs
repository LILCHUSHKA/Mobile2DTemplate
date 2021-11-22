using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text scoreText;
    int score = 0;

    private void Awake() => scoreText = GetComponent<Text>();

    private void Start() => StartCoroutine(Timer());

    public void RefreshScore(int _score) => score = _score;

    public void RecordScore() => scoreText.text = "Вы продержались : " + score + " секунд";

    IEnumerator Timer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);

            score++;
            scoreText.text = score.ToString();
        }
    }
}