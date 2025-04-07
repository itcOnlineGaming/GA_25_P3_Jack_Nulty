using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string SceneName;
    public GameObject Object;
    public Rigidbody centre;

    void Start()
    {

    }

    public void loadScene()
    {
        StartCoroutine(LoadYourAsyncScene());
    }

    IEnumerator LoadYourAsyncScene()
    {

        // Set the current Scene to be able to unload it later
        UnityEngine.SceneManagement.Scene currentScene = SceneManager.GetActiveScene();

        // The Application loads the Scene in the background at the same time as the current Scene.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(SceneName, LoadSceneMode.Additive);

        // Wait until the last operation fully loads to return anything
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        centre.useGravity = true;
        centre.isKinematic = false;

        if (Object.tag == "gameObj")
        {
            Object.transform.SetPositionAndRotation(new Vector3(0, 4f, 0), transform.rotation);
            foreach (Transform child in Object.transform)
            {
                if (child.gameObject != this.gameObject)
                {
                    BoxCollider boxCollider = child.gameObject.GetComponent<BoxCollider>();
                    if (boxCollider != null)
                    {
                        boxCollider.enabled = true;
                    }
                }
            }
        }

        // Move the GameObject (you attach this in the Inspector) to the newly loaded Scene
        SceneManager.MoveGameObjectToScene(Object, SceneManager.GetSceneByName(SceneName));
        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);
    }
}
