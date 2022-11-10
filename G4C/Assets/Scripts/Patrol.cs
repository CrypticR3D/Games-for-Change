using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.HID;

public class Patrol : MonoBehaviour
{
    public Transform[] waypoints;
    private int _currentWaypointIndex = 0;
    public float _speed = 20f;
    public float _waitSpeed;
    public float _defaultSpeed;
    public string currentPoint;
    public float rayDist = 25f;
    public bool isWait;
    public float waitTime = 1f;
    public bool rayOn;
    public float lookSpeed = 2f;

    private void Start()
    {
        _speed = Random.Range(20f, 60f);
        _defaultSpeed = _speed;
    }


    private void Update()
    {
        Transform wp = waypoints[_currentWaypointIndex];

        RaycastHit hit;

        if (rayOn)
        {
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, rayDist))
            {
                if (hit.transform.tag == "Car")
                {
                    isWait = true;
                    rayOn = false;

                    if (isWait)
                    {
                        //_waitSpeed = hit.collider.transform.gameObject.GetComponent<Patrol>()._speed - 10f;

                        StartCoroutine(Stop());
                    }

                    //_speed = _defaultSpeed;

                }
            }
        }


        if (Vector3.Distance(transform.position, wp.position) < 0.01f)
        {
            _currentWaypointIndex = (_currentWaypointIndex + 1) % waypoints.Length;
        }

        else
        {
            transform.position = Vector3.MoveTowards(transform.position, wp.position, _speed * Time.deltaTime);
            transform.LookAt(Vector3.Lerp (wp.position, wp.position, Time.deltaTime * lookSpeed));
        }

        currentPoint = ($"Current Way Point {wp}");
    }
    IEnumerator Stop()
    {
        _speed = 0f;
        yield return new WaitForSeconds(waitTime);
        _speed = _defaultSpeed;
        isWait = false;
        rayOn = true;
    }
}
