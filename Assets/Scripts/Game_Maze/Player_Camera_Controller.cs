using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Camera_Controller : MonoBehaviour {

	public RotationAxis m_Axis = RotationAxis.eMouseX;
	public float m_Speed_Horizontal = 10.0f;
	public float m_Speed_Vertical = 10.0f;

	public float m_MaximumVert = 45.0f;
	public float m_MinimumVert = -45.0f;

	public float m_RotationX = 0;

	public enum RotationAxis {
		eMouseX = 1,
		eMouseY = 2
	}

	// Update is called once per frame
	private void Update () {
		if(m_Axis == RotationAxis.eMouseX) {
			transform.Rotate(0, Input.GetAxis ("Mouse X") * m_Speed_Horizontal, 0);
		} else if(m_Axis == RotationAxis.eMouseY) {
			m_RotationX -= Input.GetAxis("Mouse Y") * m_Speed_Vertical;
			m_RotationX = Mathf.Clamp(m_RotationX, m_MinimumVert, m_MaximumVert);

			transform.localEulerAngles = new Vector3(m_RotationX,0,0);
		}
	}
}
