using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManagement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GoEasyScene()
    {
        SceneManager.LoadScene("EasyScene");
    }

    public void GoNormalScene()
    {
        SceneManager.LoadScene("NormalScene");
    }

    public void GoHardScene()
    {
        SceneManager.LoadScene("HardScene");
    }

    public void BackMain()
    {
        SceneManager.LoadScene("MainScene");
    }
}
