using UnityEngine;
using System.Collections;

public class ShaderController1 : MonoBehaviour {
	
	public Renderer renderer;
	public float _Emission = 2f;
	
	
	[SerializeField]
	public float Emission {
		get { return _Emission; }
		set { _Emission = value; }
	}

	void Start () {
		
		_Emission = 1f;
	}
	
	// Update is called once per frame
	void Update () {
		renderer.material.SetFloat ("_V_WIRE_EmissionStrength", _Emission);
	}
}
