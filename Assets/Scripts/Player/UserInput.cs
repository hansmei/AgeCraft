﻿using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using RTS;

public class UserInput : NetworkBehaviour {

	private Player player;
	private PlayerCamera playerCamera;
	private Mouse mouse;

	// Use this for initialization
	void Start () {
		player = GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update () {
		if(player.isHuman && isLocalPlayer) {
			player.playerCamera.MoveCamera();
			player.mouse.MouseTracker();
		}
	}

}
