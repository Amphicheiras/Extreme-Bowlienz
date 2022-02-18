using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour
{	
	public GameObject[] ballz;
	public GameObject[] player;
	public GameObject[] pins;
	public GameObject[] cams;
	public GameObject[] pin;
	public GameObject[] music;
	public Text first;
	public Text countdown;
	Vector3[,] startPos = new Vector3[4,10];
	Vector3[] camstart = new Vector3[4];
	Vector3[] ballstart = new Vector3[4];
	public int[] score = new int[4];
	public int[] scorez = new int[2];
	public int playah = 0;
	public int multi = 0;
	public bool stop = false;
	public bool[] restore;
	public float timeleft = 30.0f;
	float rounded;

	
     //int time,a;
     float x;
     public bool countb;
     public string timeDisp;

	void Start ()
	{
		scorez [0] = 0;
		scorez [1] = 0;
		for (int j = 0; j < 4; j++) {
			camstart[j] = cams[j].transform.position;
			ballstart [j] = ballz [j].transform.position;
			score[j] = 0; 
			restore [j] = false;
			for (int i = 0; i < 10; i++) {
				startPos[j,i] = pins[j].gameObject.transform.GetChild (i).position;
			}
		}
		UpdateScore();
	}

	void Update (){
		if (stop == false) {
			if (score [playah] == 10 || timeleft < 0) {
				if (playah == 3 && multi == 1) {
					if (scorez [0] > scorez [1]) {
						first.text = "Player 1 won!";
					} else if (scorez [0] == scorez [1]) {
						first.text = "Player 2 won!";
					} else {
						first.text = "Tie!";
					}
					stop = true;
					multi = 0;
				}
				ChangeLane ();
				timeleft = 30;
			}
		}

		timeleft -= Time.deltaTime;
		rounded = (int)(timeleft * 100.0f)/100.0f;
		countdown.text = +rounded+"";
	}

	public void AddScore (int playah, int value)
	{
		score[playah] = score[playah] + value;
		scorez [multi] = scorez [multi] + value;
		UpdateScore ();
	}

	void UpdateScore()
	{
			first.text = scorez[0] + " - " + scorez[1];
	}
	
	public void SpawnPins(int playah)
	{
		for(int i=0; i<10; i++){
			
			//pins[playah].gameObject.transform.GetChild(i).GetComponent<nn> ().jee(true);
			pins[playah].gameObject.transform.GetChild(i).rotation = Quaternion.Euler(0,0,0);
			pins[playah].gameObject.transform.GetChild(i).position = startPos[playah,i];
			restore [playah] = true;

		}
	}

	void ChangeLane(){
		score[playah] = 0;
		UpdateScore ();
		if (playah == 3) {
			playah = 0;			
			player [3].SetActive (false);
			player [0].SetActive (true);
			for (int i=0; i<4; i++){
				SpawnPins(i);
			}
			multi++;
		}else {
			player [playah + 1].SetActive (true);
			player [playah].SetActive (false);
			playah++;
		}
		ballz[playah].transform.position = new Vector3 (ballstart[playah].x, ballstart[playah].y, ballstart[playah].z);
		cams[0].transform.rotation = Quaternion.Euler (24, 0, 0);;
		cams[0].transform.position = new Vector3 (camstart[playah].x, camstart[playah].y, camstart[playah].z);
	}
     
     // Update is called once per frame
//     void FixedUpdate (){
//         if (countb){
//             timeDisp = time.ToString ();
//			par.gameObject.Find ("zz").GetComponent<Text> ().text = timeDisp;
//             x += Time.deltaTime;
//             a = (int)x;
//             print (a);
//             switch(a){
////			case 0: par.gameObject.Find ("zz").GetComponent<Text> ().text = "3"; break;
////			case 1: par.gameObject.Find ("zz").GetComponent<Text> ().text = "2"; break;
////			case 2: par.gameObject.Find ("zz").GetComponent<Text> ().text = "1"; break;
////			case 3: par.gameObject.Find ("zz").GetComponent<Text> ().enabled = false;
//                     countb = false; break;
//             }
//         }
//     }
}



