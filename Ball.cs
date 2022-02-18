using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
    public float thrust;
	public Rigidbody rb;
	public GameObject camera;
	private Vector3 init;
	public Vector3 again;
	private Vector3 jjh = new Vector3( 0, -2f, -2f);
	public RectTransform power;
	private float powah;

    void Start()
	{
        rb = GetComponent<Rigidbody>();
		init = camera.transform.position;
		again = this.transform.position;
    }

    void FixedUpdate()
    {

		if (Input.GetKey(KeyCode.Mouse0))
        {
			rb.AddForce(0, 0, thrust*8, ForceMode.Impulse);
		}
		if (Input.GetKey(KeyCode.D))
        {
			rb.AddForce(thrust*3, 0, 0, ForceMode.Impulse);
		}
		if (Input.GetKey(KeyCode.S))
        {	
			rb.AddForce(0, 0, -thrust*3, ForceMode.Impulse);
		}
		if (Input.GetKey(KeyCode.A))
        {
			rb.AddForce(-thrust*3, 0, 0, ForceMode.Impulse);
		}
		if (Input.GetKey(KeyCode.Mouse1))
		{
			//rb.velocity = Vector3.zero;
			//rb.angularVelocity = Vector3.zero;
			this.transform.position = again;
			camera.transform.rotation = Quaternion.Euler (24, 0, 0);;
			camera.transform.position = init;

		}
		if(this.transform.position.z> -5){
			jjh = this.transform.position + new Vector3 (1f, 2f, -20f);
			camera.transform.rotation = Quaternion.Euler (5, 0, 0);;
			camera.transform.position = jjh;
		}	
		powah = (rb.velocity.magnitude*10);
		power.anchoredPosition = new Vector2 (0,powah);

    }
}