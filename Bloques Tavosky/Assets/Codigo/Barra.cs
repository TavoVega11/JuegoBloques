using UnityEngine;
using System.Collections;

public class Barra : MonoBehaviour {

	public float velocidad = 1.5f;
	private Vector3 posInicial;
	private float minPosBarra = -8f;
	private float maxPosBarra = 8f;

	// Use this for initialization
	void Start () {
		posInicial = transform.position;
	}

	public void Reset () {
		transform.position = posInicial;
	}
	
	// Update is called once per frame
	void Update () {
		float direccion;
		direccion = Input.GetAxisRaw("Horizontal");
		float posX = transform.position.x + (direccion * velocidad * Time.deltaTime);
		transform.position = new Vector3(Mathf.Clamp(posX, minPosBarra, maxPosBarra), transform.position.y, transform.position.z);
		transform.position += new Vector3(Input.acceleration.x, 0, 0) * Time.deltaTime * velocidad;
	}

}
