using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LoadScene : MonoBehaviour
{
    public int sceneID;
    public Image loadIMG;
    public Text loadText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(AsyncLoad());
    }

    IEnumerator AsyncLoad()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneID);
        
        while (!operation.isDone)
        {
            float progress = operation.progress / 0.9f;
            loadIMG.fillAmount = progress;
            loadText.text = string.Format("{0:0}%", progress * 100);
            yield return null;
        }
    }
}
