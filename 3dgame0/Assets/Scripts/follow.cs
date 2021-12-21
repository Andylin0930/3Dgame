using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    private Vector3 offect = new Vector3(0, 3.5f, -4.6f);
    public GameObject play;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = play.transform.position + offect;
    }
}
