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

    public Vector3 part1Rotation;
    public Vector3 part2Rotation;
    public Vector3 part3Rotation;
    public Vector3 part4Rotation;
    public Vector3 part5Rotation;
    public Vector3 part6Rotation;
    public Vector3 part7Rotation;

    public GameObject build;
    public Button loadPart;

    GameObject parts;

    public static bool createJoint = false;
    bool partHeld = false;
    int timer = 0;
    Vector3 pieceOffset;

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer--;
        }
        if (timer < 0)
        {
            timer = 0;
        }

        if (parts != null && partHeld == true)
        {
            Vector3 inputPos = Input.mousePosition;
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                inputPos = touch.position;
            }
            inputPos.z = Camera.main.nearClipPlane;
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(inputPos);

            parts.transform.position = new Vector3(Mathf.Round(worldPos.x) - pieceOffset.x, Mathf.Round(worldPos.y) + pieceOffset.y, pieceOffset.z);
        }

        if (partHeld == true && (Input.GetMouseButtonUp(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)) && timer <= 0)
        {
            createJoint = true;
            partHeld = false;
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
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(inputPos);
            pieceOffset = new Vector3(0, 0, 0);
            parts = Instantiate(part1, build.transform);
            parts.transform.position = new Vector3(worldPos.x, worldPos.y, 0);
            parts.transform.rotation = Quaternion.Euler(part1Rotation);
            parts.transform.localScale = new Vector3(1, 1, 1);
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
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(inputPos);
            pieceOffset = new Vector3(0, 0, 0);
            parts = Instantiate(part2, build.transform);
            parts.transform.position = new Vector3(worldPos.x, worldPos.y, 0);
            parts.transform.rotation = Quaternion.Euler(part2Rotation);
            parts.transform.localScale = new Vector3(1, 1, 1);
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
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(inputPos);
            pieceOffset = new Vector3(0, 0, 0);
            parts = Instantiate(part3, build.transform);
            parts.transform.position = new Vector3(worldPos.x, worldPos.y, 0);
            parts.transform.rotation = Quaternion.Euler(part3Rotation);
            parts.transform.localScale = new Vector3(1, 1, 1);
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
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(inputPos);
            pieceOffset = new Vector3(0, 0, 0);
            parts = Instantiate(part4, build.transform);
            parts.transform.position = new Vector3(worldPos.x, worldPos.y, 0);
            parts.transform.rotation = Quaternion.Euler(part4Rotation);
            parts.transform.localScale = new Vector3(1, 1, 1);
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
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(inputPos);
            pieceOffset = new Vector3(0, 0, 0);
            parts = Instantiate(part5, build.transform);
            parts.transform.position = new Vector3(worldPos.x, worldPos.y, 0);
            parts.transform.rotation = Quaternion.Euler(part5Rotation);
            parts.transform.localScale = new Vector3(1, 1, 1);
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
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(inputPos);
            pieceOffset = new Vector3(0, 0, 0);
            parts = Instantiate(part6, build.transform);
            parts.transform.position = new Vector3(worldPos.x, worldPos.y, 0);
            parts.transform.rotation = Quaternion.Euler(part6Rotation);
            parts.transform.localScale = new Vector3(1, 1, 1);
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
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(inputPos);
            pieceOffset = new Vector3(0, 0, 0);
            parts = Instantiate(part7, build.transform);
            parts.transform.position = new Vector3(worldPos.x, worldPos.y, 0);
            parts.transform.rotation = Quaternion.Euler(part7Rotation);
            parts.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
