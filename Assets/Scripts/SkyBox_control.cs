using UnityEngine;
using System.Collections;

public class SkyBox_control : MonoBehaviour {

	public float _exposure = 0.1f;
	public float _rotation = 1.0f;

	//public Renderer renderer;

//	public float exposure01 {
//		set { 
//			renderer.material.SetFloat ("Exposure", value); }
//
//	}

//	

	[SerializeField]
	public float exposure {
		get { return _exposure; }
		set { _exposure = value; }
	}

	[SerializeField]
	public float rotation {
		get { return _rotation; }
		set { _rotation = value; }
	}

	// Use this for initialization
	void Start () {
//		renderer.material.SetFloat ("Exposure", 0);

		exposure = 0.1f;
		rotation = 50;
	}
	
	// Update is called once per frame
	void Update () {
	RenderSettings.skybox.SetFloat("_Exposure", _exposure);
	RenderSettings.skybox.SetFloat("_Rotation", _rotation);


	}
}
