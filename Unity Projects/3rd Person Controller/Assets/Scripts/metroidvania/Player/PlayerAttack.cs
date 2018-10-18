using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    public Transform player;
    public Vector3 offset = (0.88f, 0f, 0f);

	// Update is called once per frame
	void Update () {
        transform.position = player.position + offset;
	}
}
