 using UnityEngine;
 using System.Collections;
 using UnityEngine.UI;
 using UnityEngine.EventSystems;
 
 public class BlinkText : MonoBehaviour {
 
	public Transform ffs;
 
  void Start(){
		
   //Call coroutine BlinkText on Start
   StartCoroutine(BlinkText());
  }
  
  //function to blink the text 
  public IEnumerator BlinkText(){
   //blink it forever. You can set a terminating condition depending upon your requirement
   while(true){
    //set the Text's text to blank
			Vector3 positionn = ffs.transform.position;
			positionn.x = 11;
			positionn.y = 50;
			positionn.z = 9;
			ffs.transform.position = positionn;
    //display blank text for 0.5 seconds
    yield return new WaitForSeconds(.5f);
			//display “I AM FLASHING TEXT” for the next 0.5 seconds
			positionn = ffs.transform.position;
			positionn.x = 0;
			positionn.y = 1;
			positionn.z = -5;
			ffs.transform.position = positionn;
    yield return new WaitForSeconds(.5f);
   }
  }
  
 }
