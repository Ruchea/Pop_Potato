using UnityEngine;
using System.Collections;

public class Potato_StartController : MonoBehaviour {

	private Rigidbody2D start_PotatoBody;
	public float potatoBounceForce = 500f;

	// Use this for initialization
	void Start () {
		start_PotatoBody = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonUp ("Jump")) {
			start_PotatoBody.AddForce (transform.up * potatoBounceForce);
		}
	}

	//Function called to start the game
	public void StartGame()
	{
		Application.LoadLevel ("GameScene");
	}

}
