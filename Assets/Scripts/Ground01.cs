using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground01 : MonoBehaviour {

	// Use this for initialization
	public Renderer renderer;
	public float _Emission = 2f;
	public float _FresnelBias = 0f;

	[SerializeField]
	public float Emission {
		get { return _Emission; }
		set { _Emission = value; }
	}

	public float F_Bias {
		get { return _FresnelBias;}
		set { _FresnelBias = value;}
	}

	void Start () {
		_Emission = 1f;
		_FresnelBias = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		renderer.material.SetFloat ("_V_WIRE_EmissionStrength", _Emission);
		renderer.material.SetFloat ("_V_WIRE_FresnelBias", _FresnelBias);
	}
}
