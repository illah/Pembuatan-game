using UnityEngine;
using System.Collections;

public class masha : MonoBehaviour {
	public float jump;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<Rigidbody>().velocity = Vector3.zero;
			GetComponent<Rigidbody>().AddForce(Vector3.up * jump);
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			transform.position +=(Vector3.left/10);		
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			transform.position +=(Vector3.right/10);		
		}
	}
}
