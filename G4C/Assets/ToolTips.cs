using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ToolTips : MonoBehaviour
{
    [SerializeField] private GameObject ToolTip;
    [SerializeField] private GameObject NextToolTip;

    [SerializeField] private TextMeshProUGUI ToolText;

    bool InTrigger = false;

    public bool ToolTip_0;
    public bool ToolTip_1;
    public bool ToolTip_2;
    public bool ToolTip_3;

    private void Update()
    {
        if (InTrigger)
        {
            if (ToolTip_0)
            {
                if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
                {
                    StartCoroutine(DelayTip());
                }
            }

            if (ToolTip_1)
            {
                if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
                {
                    StartCoroutine(DelayTip());
                }
            }

            if (ToolTip_2)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    StartCoroutine(DelayTip());
                }
            }

            if (ToolTip_3)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    StartCoroutine(DelayTipFinal());
                }
            }
        }
    }

    private IEnumerator DelayTip()
    {
        yield return new WaitForSeconds(3);
        Destroy(ToolTip);
        EnableNextTip();
        Destroy(gameObject);
    }

    private IEnumerator DelayTipFinal()
    {
        yield return new WaitForSeconds(3);
        Destroy(ToolTip);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        ShowToolTip();
        InTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        HideToolTip();
        InTrigger = false;
    }

    void ShowToolTip()
    {
        ToolTip.gameObject.SetActive(true);
    }

    void HideToolTip()
    {
        ToolTip.gameObject.SetActive(false);
    }

    void EnableNextTip()
    {
        NextToolTip.gameObject.SetActive(true);
    }
}
