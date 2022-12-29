using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using System;

public class AtWorkSystem : MonoBehaviour
{
    float _High = 75;
    float _Med = 50;
    float _Low = 25;

    [SerializeField] private GameObject Question_1_obj;
    [SerializeField] private GameObject Question_2_obj;
    [SerializeField] private GameObject Question_3_obj;
    [SerializeField] private GameObject Question_4_obj;
    [SerializeField] private GameObject Question_5_obj;

    [SerializeField] private GameObject BG;

    public GameManager gameManager;

    private bool Q1A1;
    private bool Q1A2;
    private bool Q1A3;

    private bool Q2A1;
    private bool Q2A2;
    private bool Q2A3;

    private bool Q3A1;
    private bool Q3A2;
    private bool Q3A3;

    private bool Q4A1;
    private bool Q4A2;
    private bool Q4A3;

    private bool Q5A1;
    private bool Q5A2;
    private bool Q5A3;

    public void StartWork()
    {
        BG.SetActive(true);
        Question_1_obj.SetActive(true);
    }

    public void Update()
    {
        /// ONE
        if (Q1A1)
        {
            Question_1_obj.SetActive(false);
            Question_2_obj.SetActive(true);
        }

        if (Q1A2)
        {
            Question_1_obj.SetActive(false);
            Question_2_obj.SetActive(true);
        }

        if (Q1A3)
        {
            Question_1_obj.SetActive(false);
            Question_2_obj.SetActive(true);
        }


        /// TWO
        if (Q2A1)
        {
            Question_2_obj.SetActive(false);
            Question_3_obj.SetActive(true);
        }

        if (Q2A2)
        {
            Question_2_obj.SetActive(false);
            Question_3_obj.SetActive(true);
        }

        if (Q2A3)
        {
            Question_2_obj.SetActive(false);
            Question_3_obj.SetActive(true);
        }


        /// THREE
        if (Q3A1)
        {
            Question_3_obj.SetActive(false);
            Question_4_obj.SetActive(true);
        }

        if (Q3A2)
        {
            Question_3_obj.SetActive(false);
            Question_4_obj.SetActive(true);
        }

        if (Q3A3)
        {
            Question_3_obj.SetActive(false);
            Question_4_obj.SetActive(true);
        }


        /// FOUR
        if (Q4A1)
        {
            Question_4_obj.SetActive(false);
            Question_5_obj.SetActive(true);
        }

        if (Q4A2)
        {
            Question_4_obj.SetActive(false);
            Question_5_obj.SetActive(true);
        }

        if (Q4A3)
        {
            Question_4_obj.SetActive(false);
            Question_5_obj.SetActive(true);
        }

        /// FIVE 
        if (Q5A1)
        {
            Question_5_obj.SetActive(false);
            BG.SetActive(false);
        }

        if (Q5A2)
        {
            Question_5_obj.SetActive(false);
            BG.SetActive(false);
        }

        if (Q5A3)
        {
            Question_5_obj.SetActive(false);
            BG.SetActive(false);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public void Q1_A1()
    {
        Q1A1 = true;
        gameManager.Stress += _Low;
    }

    public void Q1_A2()
    {
        Q1A2 = true;
        gameManager.Stress += _High;
    }

    public void Q1_A3()
    {
        Q1A3 = true;
        gameManager.Stress += _Med;
    }
    /// <summary>
    /// 
    /// </summary>
    public void Q2_A1()
    {
        Q2A1 = true;
        gameManager.Stress += _Med;
    }
    public void Q2_A2()
    {
        Q2A2 = true;
        gameManager.Stress += _High;
    }
    public void Q2_A3()
    {
        Q2A3 = true;
        gameManager.Stress += _Low;
    }
    /// <summary>
    /// 
    /// </summary>
    public void Q3_A1()
    {
        Q3A1 = true;
        gameManager.Stress += _High;
    }
    public void Q3_A2()
    {
        Q3A2 = true;
        gameManager.Stress += _Low;
    }
    public void Q3_A3()
    {
        Q3A3 = true;
        gameManager.Stress += _Med;
    }
    /// <summary>
    /// 
    /// </summary>
    public void Q4_A1()
    {
        Q4A1 = true;
        gameManager.Stress += _Med;
    }
    public void Q4_A2()
    {
        Q4A2 = true;
        gameManager.Stress += _High;
    }
    public void Q4_A3()
    {
        Q4A3 = true;
        gameManager.Stress += _Low;
    }
    /// <summary>
    /// 
    /// </summary>
    public void Q5_A1()
    {
        Q5A1 = true;
        gameManager.Stress += _Low;
    }
    public void Q5_A2()
    {
        Q5A2 = true;
        gameManager.Stress += _Med;
    }
    public void Q5_A3()
    {
        Q5A3 = true;
        gameManager.Stress += _High;
    }
}