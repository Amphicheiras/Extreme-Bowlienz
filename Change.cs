using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour {

	public GameObject mr;
	public GameObject rm;
	public bool kserw;
	public bool enable = true;
	public float timeOn;
	public float timeOFf;
	private float changeTime = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (enable) {
			
			if (Time.time > changeTime) {
				mr.SetActive (kserw);
				rm.SetActive (!kserw);
				if (kserw){
					changeTime = Time.time + timeOn;
				}
				else 
				{
					changeTime = Time.time + timeOFf;
				}
				kserw = !kserw;
			}
		}

	}

	public void Enable(){
//		if (enable) {
			enable = !enable;
//			kserw = enable;
//			mr.SetActive (kserw);
//			rm.SetActive (!kserw);

		}
	}
//}
