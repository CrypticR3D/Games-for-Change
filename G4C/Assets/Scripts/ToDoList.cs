using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToDoList : MonoBehaviour
{

    public bool IsOnList;

    [SerializeField] GameObject ToDoListObject;

    internal bool canOpen = true;

    //Player
    public SC_FPSController PlayerCharacter;

    //UI
    public UIManager HUDManager;

    //Animations
    public Animator toDoAnim;
    [SerializeField] private string openAnimationName = "listOpen";
    [SerializeField] private string closeAnimationName = "listClose";

    //Pause Input
    [SerializeField] private int waitTimer = 1;
    [SerializeField] private bool pauseInteraction = false;

    // Start is called before the first frame update
    void Awake()
    {
        HUDManager = FindObjectOfType<UIManager>();
        PlayerCharacter = FindObjectOfType<SC_FPSController>();
        toDoAnim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canOpen)
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                if (IsOnList == false)
                {
                    toDoAnim.Play(openAnimationName, 0, 0f);
                    IsOnList = true;
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                    PlayerCharacter.canMove = false;
                    StartCoroutine(PauseInput());
                    //ToDoListObject.SetActive(true);
                }

                else if (IsOnList == true)
                {
                    toDoAnim.Play(closeAnimationName, 0, 0f);
                    IsOnList = false;
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;
                    PlayerCharacter.canMove = true;
                    StartCoroutine(PauseInput());
                    //ToDoListObject.SetActive(false);
                }
            }
        }

    }

    private IEnumerator PauseInput()
    {
        pauseInteraction = true;
        yield return new WaitForSeconds(waitTimer);
        pauseInteraction = false;
    }
}
