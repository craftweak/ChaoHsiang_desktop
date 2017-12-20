using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(VolumetricLight))]
public class LightNoiseScroller : MonoBehaviour {

[SerializeField]
        float _speed;

        public float speed {
            get { return _speed; }
            set { _speed = value; }
        }

	
	// Update is called once per frame
	void Update () {
		
            GetComponent<VolumetricLight>().NoiseVelocity.y +=  _speed * Time.deltaTime;
	}
}
