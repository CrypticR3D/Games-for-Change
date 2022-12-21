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

    [SerializeField] GameObject Bed_1;
    [SerializeField] GameObject Bed_2;

    public bool isBedTask;
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
            if (isBedTask)
            {
                Bed_1.gameObject.SetActive(false);
                Bed_2.gameObject.SetActive(true);
            }

            Complete = true;
            questItem.GetComponent<Image>().enabled = true; //= completedColor;
            XpSlider.value++;
        }

    }

}
