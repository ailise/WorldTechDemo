using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PathInstantiate : MonoBehaviour
{

	private int counter = 0;
	public Transform floorPrefab;
	public List<Transform> listOfFloorClones = new List<Transform> ();

	// Use this for initialization
	void Start ()
	{
	
		
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (counter < 50){
			
			float rand = Random.Range (0.0f, 1.0f);
			counter++;
			Debug.Log (Random.Range (0.0f, 1.0f));
			
			if (rand < 0.25f) {
				
				floorPrefab.Rotate (0f, 90, 0f);
				
			} else if (rand > 0.5f) {
				
				floorPrefab.Rotate (0f, -90, 0f);
			}
		}


		Instantiate (floorPrefab, transform.position, Quaternion.identity);
		transform.Translate (0f,0f,5f);

		if (Input.GetKeyDown (KeyCode.R)) {
			
			Application.LoadLevel (Application.loadedLevel);
			
		}

//			listOfFloorClones.Add (floorClone);
		
//		else { 
//
//			Destroy.gameObject; }
//
		//		for (int i = 0; i < 100; i++) {
		//			
		//			Transform floorClone = (Transform)			
		
			}
		
		}
		

	

