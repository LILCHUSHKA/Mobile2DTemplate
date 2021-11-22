using UnityEngine;

public class Menu : MonoBehaviour
{
    private void OnEnable() => Time.timeScale = 0;

    private void OnDisable() => Time.timeScale = 1;

    public void Quit() => Application.Quit();
}