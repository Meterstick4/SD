﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandMine : MonoBehaviour {
	public Object particles;
	void OnTriggerEnter(Collider other)
	{
		Instantiate (particles);

	}
}
