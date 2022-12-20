using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Task : MonoBehaviour
{
    public Image questItem;
    public Slider XpSlider;

    private bool Complete = false;
    //public Color completedColor;
    //public Color activeColor;

    //public QuestArrow arrow;

    //private void OnTriggerEnter(Collider collision)
    //{
    //    if (collision.tag == "Player")
    //    {
    //        FinishQuest();
    //        Destroy(gameObject);
    //    }
    //}

    public void FinishQuest()
    {
        if (Complete == false)
        {
            Complete = true;
            questItem.GetComponent<Image>().enabled = true; //= completedColor;
            XpSlider.value++;
        }

    }

}
