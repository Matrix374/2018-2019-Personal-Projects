using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegenWall : MonoBehaviour {

    public float wallHealth = 5f;
    public float wallRegen = 1f;

    private bool isDestroyed = false;

	// Update is called once per frame
	void Update () {

        wallHealth = Mathf.Clamp(wallHealth, 0f, 1f);

		if(wallHealth <= 5f && !isDestroyed)
        {
            wallHealth += wallRegen * Time.deltaTime;
        }

        if(wallHealth <= 0f)
        {
            isDestroyed = true;
            Destroy(gameObject, 2f);
        }
	}
}
