using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class move : MonoBehaviour {
	public float Margin;
	public float Layer;
	float x;
	float y;
	float Easing = 0.2f;
	Vector3 pos;
	void Start () {
		pos = transform.position;
		Input.gyro.enabled = true;
	}

	void Update () {
		float targetX = -Input.gyro.rotationRateUnbiased.x - Screen.width / 2f;
		float dx = targetX - x;
		x += dx * Easing;
		float targetY = -Input.gyro.rotationRateUnbiased.y - Screen.height / 2f;
		float dy = targetY - y;
		y += dy * Easing;
		Vector3 direction = new Vector3(-Input.gyro.rotationRateUnbiased.y, -Input.gyro.rotationRateUnbiased.x, 0f);
		Vector3 depth = new Vector3(0f, 0f, Layer);
		this.transform.position = pos - direction/30f * Margin + depth;
	}
}

