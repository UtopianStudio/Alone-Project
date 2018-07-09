using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {

    public GameObject target;
    public float timeCam = 1;
    public float yy;
    private Vector3 posCam;
    public bool kameraIkutY = false;




    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (!kameraIkutY)
        {
            posCam = transform.position;
            transform.position = Vector3.Lerp(posCam, new Vector3(target.transform.position.x, target.transform.position.y + yy, transform.position.z), timeCam);
        }
        else
        {
            posCam = transform.position;
            transform.position = Vector3.Lerp(posCam, new Vector3(target.transform.position.x, transform.position.y, transform.position.z), timeCam);
        }

    }
}
