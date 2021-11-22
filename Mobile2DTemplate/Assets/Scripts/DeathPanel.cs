using UnityEngine;
using UnityEngine.UI;

public class DeathPanel : MonoBehaviour
{
    [SerializeField] Text tryCountText;
    [SerializeField] Score score;

    int tryCount = 1;

    private void OnEnable()
    {
        Time.timeScale = 0;

        score.RecordScore();
        RecordTryCount();
    }

    private void OnDisable() => Time.timeScale = 1;

    void RecordTryCount()
    {
        tryCount = PlayerPrefs.GetInt("Try_Count") + 1;
        PlayerPrefs.SetInt("Try_Count", tryCount);

        tryCountText.text = "Игра окончена\nВсего попыток - " + tryCount;
    }
}