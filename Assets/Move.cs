using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Move : MonoBehaviour
{
    public SteamVR_Action_Boolean WalkAction;
    private Vector3 myVec;
    public GameObject myObj;
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (WalkAction.GetState(SteamVR_Input_Sources.Any))
        {
            myVec = myObj.transform.forward;
            myVec.y = 0.0f;
            myVec = Vector3.Normalize(myVec);
            transform.position += myVec * speed;
        };
    }
}
