using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public Slider slider;
    public AudioSource Ball;
    public AudioSource DIO;
    public GameObject EndScene;
    public bool Skill;
    public bool isGameOver;
    public float SkillTime;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = slider.maxValue;
        EndScene.SetActive(false);
        Skill = false;
        isGameOver = false;
        SkillTime = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (Skill == true)
        {
            SkillTime -= 1 * Time.deltaTime;
            if (SkillTime <= 0)
            {
                Skill = false;
            }
        }


        if (slider.value > 0 && Skill != true)
        { 
            slider.value -= 1 * Time.deltaTime;
        }
        else if (slider.value <= 0 && isGameOver != true)
        {
            if (!Ball.isPlaying)
            { 
                Ball.Play();
            }
            EndScene.SetActive(true);
        }
    }

    public void TheWorld()
    {
        Skill = true;
        if (!DIO.isPlaying)
        {
            DIO.Play();
        }
        Debug.Log("theworld");
    }    
}
