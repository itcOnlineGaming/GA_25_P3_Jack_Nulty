using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointCreator : MonoBehaviour
{
    public GameObject objBase;
    public List<GameObject> compnents;
    public GameObject gameObj;

    bool turnOffCreateJoint = false;

    // Start is called before the first frame update
    void Start()
    {
        objBase = GameObject.FindGameObjectWithTag("objBase");

        gameObj = GameObject.FindGameObjectWithTag("gameObj");
        compnents = new List<GameObject>();

        //get all the children but do not add ourself
        foreach (Transform child in gameObj.transform)
        {
            if (child.gameObject != this.gameObject)
            {
                compnents.Add(child.gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (objBase != null && LoadPart.createJoint == true)
        {
            //remove all joints so we can redo them as a change to the cars structure has been made
            Joint[] joints = GetComponents<Joint>();
            foreach (Joint joint in joints)
            {
                Destroy(joint);
            }

            //get the list of components again as a change has been made
            compnents = new List<GameObject>();
            foreach (Transform child in gameObj.transform)
            {
                if (child.gameObject != this.gameObject)
                {
                    compnents.Add(child.gameObject);
                }
            }

            //go through all pieces and if they are close enough generate a joint between them
            foreach (GameObject component in compnents)
            {
                float distance = Vector3.Distance(transform.position, component.transform.position);
                if (distance < 2.1f)
                {
                    FixedJoint fixedJoint = gameObject.AddComponent<FixedJoint>();
                    fixedJoint.connectedBody = component.GetComponent<Rigidbody>();
                }
            }
            //can now stop trying to add joints as they are all now connected or none were found
            turnOffCreateJoint = true;
        }
    }
    private void LateUpdate()
    {
        //make sure all other pieces can do their joints before we swap the bool
        if (turnOffCreateJoint == true)
        {
            turnOffCreateJoint = false;
            LoadPart.createJoint = false;
        }
    }
}
