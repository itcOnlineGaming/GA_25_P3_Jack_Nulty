using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadPart : MonoBehaviour
{
    public GameObject part1;
    public GameObject part2;
    public GameObject part3;
    public GameObject part4;
    public GameObject part5;
    public GameObject part6;
    public GameObject part7;

    public GameObject build;

    GameObject parts;

    public static bool createJoint = false;
    bool partHeld = false;
    bool grabbed = false;
    int timer = 0;
    Vector3 pieceOffset;
    Vector3 piecePosition;
    Vector3 spawnPos = new Vector3(-6, 1, 0);
    float pieceSpawnOffset = 3.0f;

    // Update is called once per frame
    void Update()
    {
        if (parts != null && partHeld == true)
        {

            if (Input.touchCount > 0 && timer <= 0)
            {
                pieceOffset = new Vector3(0, 0, 0);
                grabbed = true;
                Touch touch = Input.GetTouch(0);
                Vector3 inputPos = touch.position;

                inputPos.z = Camera.main.nearClipPlane;
                piecePosition = Camera.main.ScreenToWorldPoint(inputPos);
            }
            parts.transform.position = new Vector3(Mathf.Round(piecePosition.x) - pieceOffset.x, Mathf.Round(piecePosition.y) + pieceOffset.y, pieceOffset.z);
        }

        if (partHeld == true && (Input.GetMouseButtonUp(0) && grabbed == true || grabbed == true && (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)) && timer <= 0)
        {
            createJoint = true;
            partHeld = false;
        }
    }

    private void FixedUpdate()
    {
        if (timer > 0)
        {
            timer--;
        }
        if (timer < 0)
        {
            timer = 0;
        }
    }

    public void LoadPart1OnClick()
    {
        if (partHeld == false)
        {
            timer = 10;
            partHeld = true;
            Vector3 inputPos = Input.mousePosition;
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                inputPos = touch.position;
            }
            inputPos.z = Camera.main.nearClipPlane;
            piecePosition = Camera.main.ScreenToWorldPoint(inputPos);
            piecePosition.y += pieceSpawnOffset;
            pieceOffset = new Vector3(0, 0, 0);

            parts = Instantiate(part1, build.transform);
            parts.transform.position = new Vector3(piecePosition.x, piecePosition.y, 0);
            parts.transform.rotation = Quaternion.identity;
            parts.transform.localScale = new Vector3(1, 1, 1);

            Input.ResetInputAxes();
        }
    }

    public void LoadPart2OnClick()
    {
        if (partHeld == false)
        {
            timer = 10;
            partHeld = true;
            Vector3 inputPos = Input.mousePosition;
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                inputPos = touch.position;
            }
            inputPos.z = Camera.main.nearClipPlane;
            piecePosition = Camera.main.ScreenToWorldPoint(inputPos);
            piecePosition.y += pieceSpawnOffset;
            pieceOffset = new Vector3(0, 0, 0);

            parts = Instantiate(part2, build.transform);
            parts.transform.position = new Vector3(piecePosition.x, piecePosition.y, 0);
            parts.transform.rotation = Quaternion.identity;
            parts.transform.localScale = new Vector3(1, 1, 1);

            Input.ResetInputAxes();
        }
    }

    public void LoadPart3OnClick()
    {
        if (partHeld == false)
        {
            timer = 10;
            partHeld = true;
            Vector3 inputPos = Input.mousePosition;
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                inputPos = touch.position;
            }
            inputPos.z = Camera.main.nearClipPlane;
            piecePosition = Camera.main.ScreenToWorldPoint(inputPos);
            piecePosition.y += pieceSpawnOffset;
            pieceOffset = new Vector3(0, 0, 0);

            parts = Instantiate(part3, build.transform);
            parts.transform.position = new Vector3(piecePosition.x, piecePosition.y, 0);
            parts.transform.rotation = Quaternion.identity;
            parts.transform.localScale = new Vector3(1, 1, 1);

            Input.ResetInputAxes();
        }
    }

    public void LoadPart4OnClick()
    {
        if (partHeld == false)
        {
            timer = 10;
            partHeld = true;
            Vector3 inputPos = Input.mousePosition;
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                inputPos = touch.position;
            }
            inputPos.z = Camera.main.nearClipPlane;
            piecePosition = Camera.main.ScreenToWorldPoint(inputPos);
            piecePosition.y += pieceSpawnOffset;
            pieceOffset = new Vector3(0, 0, 0);

            parts = Instantiate(part4, build.transform);
            parts.transform.position = new Vector3(piecePosition.x, piecePosition.y, 0);
            parts.transform.rotation = Quaternion.identity;
            parts.transform.localScale = new Vector3(1, 1, 1);

            Input.ResetInputAxes();
        }
    }

    public void LoadPart5OnClick()
    {
        if (partHeld == false)
        {
            timer = 10;
            partHeld = true;
            Vector3 inputPos = Input.mousePosition;
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                inputPos = touch.position;
            }
            inputPos.z = Camera.main.nearClipPlane;
            piecePosition = Camera.main.ScreenToWorldPoint(inputPos);
            piecePosition.y += pieceSpawnOffset;
            pieceOffset = new Vector3(0, 0, 0);

            parts = Instantiate(part5, build.transform);
            parts.transform.position = new Vector3(piecePosition.x, piecePosition.y, 0);
            parts.transform.rotation = Quaternion.identity;
            parts.transform.localScale = new Vector3(1, 1, 1);

            Input.ResetInputAxes();
        }
    }

    public void LoadPart6OnClick()
    {
        if (partHeld == false)
        {
            timer = 10;
            partHeld = true;
            Vector3 inputPos = Input.mousePosition;
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                inputPos = touch.position;
            }
            inputPos.z = Camera.main.nearClipPlane;
            piecePosition = Camera.main.ScreenToWorldPoint(inputPos);
            piecePosition.y += pieceSpawnOffset;
            pieceOffset = new Vector3(0, 0, 0);

            parts = Instantiate(part6, build.transform);
            parts.transform.position = new Vector3(piecePosition.x, piecePosition.y, 0);
            parts.transform.rotation = Quaternion.identity;
            parts.transform.localScale = new Vector3(1, 1, 1);

            Input.ResetInputAxes();
        }
    }

    public void LoadPart7OnClick()
    {
        if (partHeld == false)
        {
            timer = 10;
            partHeld = true;
            Vector3 inputPos = Input.mousePosition;
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                inputPos = touch.position;
            }
            inputPos.z = Camera.main.nearClipPlane;
            piecePosition = Camera.main.ScreenToWorldPoint(inputPos);
            piecePosition.y += pieceSpawnOffset;
            pieceOffset = new Vector3(0, 0, 0);

            parts = Instantiate(part7, build.transform);
            parts.transform.position = new Vector3(piecePosition.x, piecePosition.y, 0);
            parts.transform.rotation = Quaternion.identity;
            parts.transform.localScale = new Vector3(1, 1, 1);

            Input.ResetInputAxes();
        }
    }
}
