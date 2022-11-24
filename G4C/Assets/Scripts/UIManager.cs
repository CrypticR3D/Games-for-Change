using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    //Crosshair
    [SerializeField] private Image crosshair = null;
    private bool isCrosshairActive;
    private bool doOnce;

    //Pause Menu
    public bool IsOnMenu;
    [SerializeField] private GameObject pauseMenu;
    internal bool canOpen = true;

    //Player
    public SC_FPSController PlayerCharacter;

    //Tasks
    [SerializeField] private GameObject _TaskOne;
    [SerializeField] private GameObject _TaskTwo;
    [SerializeField] private GameObject _TaskThree;
    [SerializeField] private GameObject _TaskFour;
    [SerializeField] private GameObject _TaskFive;

    //Day
    [SerializeField] private GameObject _Day;


    void Awake()
    {
        PlayerCharacter = FindObjectOfType<SC_FPSController>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsOnMenu == false)
            {
                Pause();
            }

            else if (IsOnMenu == true)
            {
                Resume();
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            TaskOne();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            TaskTwo();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            TaskThree();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            TaskFour();
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            TaskFive();
        }
    }


    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        IsOnMenu = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        PlayerCharacter.canMove = false;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        IsOnMenu = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        PlayerCharacter.canMove = true;
    }

    public void Home(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
        Time.timeScale = 1f;
    }

    public void Play(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
        //Time.timeScale = 1f;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void InteractIcon()
    {
        crosshair.color = Color.red;
    }

    public void DefaultIcon()
    {
        crosshair.color = Color.white;
    }

    public void TaskOne()
    {
        _TaskOne.SetActive(true);
    }

    public void TaskTwo()
    {
        _TaskTwo.SetActive(true);
    }

    public void TaskThree()
    {
        _TaskThree.SetActive(true);
    }

    public void TaskFour()
    {
        _TaskFour.SetActive(true);
    }

    public void TaskFive()
    {
        _TaskFive.SetActive(true);
    }
}
