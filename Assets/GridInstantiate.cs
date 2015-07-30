using UnityEngine;
using System.Collections;

public class GridInstantiate : MonoBehaviour {

	public Transform floorTilePrefab, wallTilePrefab;

	// Use this for initialization
	void Start () {
		for ( int x = 0; x < 5; x++ ) {
			for ( int z = 0; z < 5; z++ ) {
				Vector3 pos = new Vector3 ( x * 5, 0, z * 5 ) + transform.position;
				float randomNumber = Random.value;
				if (randomNumber < 0.7f ) {
					Instantiate ( floorTilePrefab, pos, Quaternion.identity );

				} else if ( randomNumber < 0.95f ) {
					Instantiate ( wallTilePrefab, pos, Quaternion.identity );

				} else {


				}

			}
				
		}

		Destroy (this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
