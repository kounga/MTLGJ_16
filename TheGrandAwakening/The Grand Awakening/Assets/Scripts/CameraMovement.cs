using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public Transform target;
	public float smooth = 5f;
	Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = new Vector3 (0f, 2f, -4f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Lerp (transform.position, target.position + offset, Time.deltaTime * smooth);
	}
}
