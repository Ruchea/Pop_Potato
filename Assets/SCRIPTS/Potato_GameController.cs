using UnityEngine;
using System.Collections;

public class Potato_GameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void SimonClicked(){
		GameObject.Find("buttonClickNoise").gameObject.GetComponent<AudioSource>().Play();
	}
}
