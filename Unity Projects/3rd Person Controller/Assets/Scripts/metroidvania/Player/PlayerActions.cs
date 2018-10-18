using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour {

    public TimeController timeController;
    public Transform sword;

	// Update is called once per frame
	void Update () {
        if(Input.GetButtonDown("Fire3") && timeController.CheckSlowdown() == false)
        {
            timeController.DoSlowdown();
        }
        else if(Input.GetButtonDown("Fire3") && timeController.CheckSlowdown() == true)
        {
            timeController.Reset();
        }
		
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(sword);
        }
        else
        {
            Destroy(sword);
        }
	}
}
