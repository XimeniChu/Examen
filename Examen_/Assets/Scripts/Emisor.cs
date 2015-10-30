using UnityEngine;
using System.Collections;

public class Emisor : MonoBehaviour {
	public GameObject BlankCube;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//var myNewObject = Instantiate (BlankCube, Vector3(this.transform.position.x+pos, this.transform.position.y, this.transform.position.z)Quaternion.identity));
		//myNewObject.renderer.material.color = Color.red;
		float pos;
		pos = Random.Range (-2, 2);
		Vector3 newPos = new Vector3 (this.transform.position.x+pos, this.transform.position.y, this.transform.position.z );
		//Instantiate (PelotaPrefab, this.transform.position, Quaternion.identity);
		//var myNewObject = Instantiate (BlankCube, Vector3(x, y, z), Quaternion.identity)
		Instantiate (BlankCube, newPos, Quaternion.identity);
	
	}
}
