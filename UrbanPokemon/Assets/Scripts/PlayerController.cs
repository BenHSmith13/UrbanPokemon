using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float xDir;
	public float yDir;

	void Awake () {
		xDir = 0f;
		yDir = 0f;
	}


	void Update () {
		Move ();
	}

	void Move () {

		this.yDir = Input.GetAxis("Vertical");
		this.xDir = Input.GetAxis("Horizontal");
		transform.Translate(this.xDir * speed * Time.deltaTime, this.yDir * speed * Time.deltaTime, 0f);
	}

}
