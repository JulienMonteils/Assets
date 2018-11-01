using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCar : MonoBehaviour {


	public float m_speed = 0.03f;


	
		void Start () {
		m_speed = 0.03f;
	}
	
	void Update ()

	{
	m_speed += 0.001f;
		
			//renderer.material.mainTextureOffset = new Vector2(Time.time * m_speed, 0f);
		// Création d'un nouveau vecteur de déplacement

		Vector3 move = new Vector3();


		// Récupération des touches haut et bas
		//if(Input.GetKey(KeyCode.UpArrow))
			move.z -= m_speed;

			//if(Input.GetKey(KeyCode.DownArrow))
			//move.z += m_speed;

		// Récupération des touches gauche et droite

		if(Input.GetKey(KeyCode.LeftArrow))

			move.x += m_speed;

		if(Input.GetKey(KeyCode.RightArrow))

			move.x -= m_speed;


		// On applique le mouvement à l'objet

		transform.position += move;

	}

}