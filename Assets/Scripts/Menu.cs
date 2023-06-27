using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void loadScene()
    {
        SceneManager.LoadScene("Assets/Scenes/GamePlayScene.unity");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
