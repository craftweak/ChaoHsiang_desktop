using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderColorControll : MonoBehaviour {

public Renderer renderer;
	public Color _Color = Color.grey ;
	public Color _Wire_Color =  Color.white ;
	
	[SerializeField]
	public Color Color {
		get { return _Color; }
		set { _Color = value; }
	}
	[SerializeField]
	public Color Wire_Color {
		get { return _Wire_Color; }
		set { _Wire_Color = value; }
	}

	void Start () {
		_Color = Color.grey ;
		_Wire_Color = Color.white ;
	}
	
	// Update is called once per frame
	void Update () {
		renderer.material.SetColor ("_Color", _Color);
		renderer.material.SetColor ("_V_WIRE_Color", _Wire_Color);
	}
}


