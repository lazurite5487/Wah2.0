using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackText : MonoBehaviour
{
	public GameObject card;
	private Vector3 TargetRotation;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	    TargetRotation.x = card.transform.position.x;
	    TargetRotation.z = card.transform.position.z;
	    TargetRotation.y = 0;
	    transform.LookAt(TargetRotation);
    }
}
