﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class GameManager : MonoBehaviour {

	public float timeDelay;
	[HideInInspector]
	public bool isPlaying = false;

	private GridManager grid;
	private AutomataManager autoManager;


	private void Awake() {
		grid = GetComponent<GridManager>();
		autoManager = GetComponent<AutomataManager>();
	}

	private void Start() {
		grid.GenerateGrid();
	}

	private void Update() {
		if (isPlaying) {
			autoManager.SmoothGrid();
		}
	}



}