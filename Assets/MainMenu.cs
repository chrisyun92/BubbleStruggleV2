using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject loadingscreen;
    public Slider slider;
    public Text progressPercent;
    public GameObject boy1;
    public GameObject boy2;

    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));

    }

    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingscreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            slider.value = progress;
            Debug.Log(progress);
            progressPercent.text = progress * 100f + "%";
            yield return null;
        }
    }

    public void QuitGame ()
    {
        Application.Quit();
    }
}
