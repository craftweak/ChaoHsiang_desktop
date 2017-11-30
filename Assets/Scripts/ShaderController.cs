using UnityEngine;
using System.Collections;

public class ShaderController : MonoBehaviour {

	public Renderer renderer;
	public float Cutoff {
		set { 
			renderer.material.SetFloat ("_Cutoff", value); }

	}
	public float width {
		set { 
			renderer.material.SetFloat ("_Width", value); }

	}


	void Start () {
		renderer.material.SetFloat ("_Cutoff", 0);
		renderer.material.SetFloat ("_Width", 0.1f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
