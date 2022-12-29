using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePlayer : MonoBehaviour
{

    [SerializeField] GameObject IntroCameraObject;

    //Player
    public GameObject PlayerCharacter;

    //UI
    [SerializeField] GameObject ToDoListObject;
    [SerializeField] GameObject MarkerObject;
    [SerializeField] GameObject XpObject;

    //Bed
    [SerializeField] GameObject BedObject;

    //ToolTips
    [SerializeField] GameObject ToolTipObject;

    public bool _ActivatePlayer;
    public bool _ActivateHUD;
    public void EnablePlayer()
    {
        if (_ActivatePlayer)
        {
            IntroCameraObject.gameObject.SetActive(false);
            PlayerCharacter.gameObject.SetActive(true);
            BedObject.gameObject.SetActive(false);
            ToolTipObject.gameObject.SetActive(true);
        }

        if (_ActivateHUD)
        {
            ToDoListObject.gameObject.SetActive(true);
            MarkerObject.gameObject.SetActive(true);
            XpObject.gameObject.SetActive(true);
        }

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
