using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInitiate : MonoBehaviour {
    private PlayerShoot _playerShoot;

    // Use this for initialization
    void Awake () {
        _playerShoot = GetComponent<PlayerShoot>();

    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp(0))
        {
            _playerShoot.Shoot();
        }
        if (Input.GetKeyDown("r"))
        {
            _playerShoot.reload();
        }
	}
}
