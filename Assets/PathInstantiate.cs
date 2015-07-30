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
		for (int i = 0; i < 100; i++) {
			
			Transform floorClone = (Transform)Instantiate (floorPrefab, new Vector3 (i * 5f, 0f, 0f), floorPrefab.rotation);
			//			floorClone.localScale = new Vector3 (5f, 0f, 0f);
			listOfFloorClones.Add (floorClone);
		
	
			if (counter < 50) {

				float rand = Random.Range (0.0f, 1.0f);
				counter++;
				Debug.Log (Random.Range (0.0f, 1.0f));

				if (rand < 0.25f) {
				
					floorClone.Rotate (0f, 90f, 0f);

				} else if (rand < 0.25f && rand > 0.5f) {

					floorClone.Rotate (0, -90, 0);
				}
			
		
			}
		
		}
		
		if (Input.GetKeyDown (KeyCode.R)) {
		
			Application.LoadLevel (Application.loadedLevel);
		
		}
	}
}
