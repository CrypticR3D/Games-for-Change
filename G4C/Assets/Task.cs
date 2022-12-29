using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Task : MonoBehaviour
{
    public Image questItem;
    public Slider XpSlider;
    public ActivatePlayer activatePlayer;

    private bool Complete = false;

    [SerializeField] GameObject Bed_1;
    [SerializeField] GameObject Bed_2;

    public bool isBedTask;

    public bool isDressTask;


    public void FinishQuest()
    {

        if (Complete == false)
        {
            if (isBedTask)
            {
                Bed_1.gameObject.SetActive(false);
                Bed_2.gameObject.SetActive(true);
            }

            if (isDressTask)
            {
                activatePlayer._ActivateHUD = true;
                activatePlayer.EnablePlayer();
            }

            Complete = true;
            questItem.GetComponent<Image>().enabled = true; //= completedColor;
            XpSlider.value++;
        }

    }

}
