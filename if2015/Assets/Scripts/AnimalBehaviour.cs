using UnityEngine;
using System.Collections;

public class AnimalBehaviour : MonoBehaviour {

	public GameObject animals;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButton (0)) {
			animals.transform.position = new Vector3(animals.transform.position.x, animals.transform.position.y,animals.transform.position.z - 0.2f);

		}
		if (Input.GetMouseButton (1)) {
			animals.transform.position = new Vector3(animals.transform.position.x, animals.transform.position.y,animals.transform.position.z + 0.2f);
			
		}
	
	}
}
