using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockBall : MonoBehaviour
{
    public CountDown PlayerWin;
    public GameObject WinScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Debug.Log("Unlocked");
            PlayerWin.isGameOver = true;
            WinScene.SetActive(true);
        }
    }
}
