using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinFall : MonoBehaviour {

	public int scoreValue;
	public GameController gameController;
	public AudioSource ass;
	public Rigidbody ffs;
	public int playah;
	public bool point = false;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameController.restore[playah] == true) {
			point = false;
		}
		if (point == false)
		{
			if (this.transform.position.y < -1 || this.transform.rotation.w < 0.7) {
//			Debug.Log (other.rotation.x + "x" );
//			Debug.Log (other.rotation.y + "y" );
//			Debug.Log (other.rotation.z + "z" );
				ffs.velocity = Vector3.zero;
				ffs.angularVelocity = Vector3.zero;
				gameController.AddScore (playah, scoreValue);
				ass.Play ();
				point = true;
				gameController.restore[playah] = false;
			}
		}

	}

}

