using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //场景管理器
public class MainMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("gameTest");//代表场景名字
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);   也可以用索引
    }
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

}
