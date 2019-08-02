using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderScript : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject panel;
    
    void Start()
    {
        panel = GameObject.Find("Panel");
        panel.gameObject.SetActive(true);
      

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void voiceInput()
    {
        Debug.Log("plays");
        SceneManager.LoadScene("Main");
    }
    public void textInput() {
        Debug.Log("plays");
        // Application.OpenURL("https://assistant-chat-eu-gb.watsonplatform.net/web/public/e91fd145-6292-47ff-b10c-b4f2af473345");
        chatApplication();
    }

    private void chatApplication()
    {

    }
}
