﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trancelate : MonoBehaviour {

	public float speed = 5;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (speed * Time.deltaTime, 0, 0);
	}
}
