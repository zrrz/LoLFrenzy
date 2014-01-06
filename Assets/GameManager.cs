using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	public GameObject Teemo;
	public GameObject Malphite;

	List<GameObject> availableObjects;
	List<GameObject> usedObjects;

	void Start () {
		availableObjects = new List<GameObject>();
		usedObjects = new List<GameObject>();
	}

	void Update () {
		
	}

	void SpawnTeemo() {

	}

	void SpawnMalphite() {

	}
}