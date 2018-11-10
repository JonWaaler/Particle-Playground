using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour {
	private bool gmMoveBack;
	private bool move = false;
	private Transform myGm;

	private bool gmMoveBackTornado;
	private bool moveTornado = false;
	private Transform myTor;

	public void toggleParticleSys(GameObject sys){
		sys.SetActive (!sys.activeInHierarchy);

	}

	public void toggleMoveFWBW(Transform gm){
		myGm = gm;
		move = !move;
	}

	public void toggleMoveTornado(Transform tor){
		myTor = tor;
		moveTornado = !moveTornado;
	}

	void Update(){
		if (move) {
			if (myGm.position.z > 30)
				gmMoveBack = true;
			if (myGm.position.z < -30)
				gmMoveBack = false;

			if (gmMoveBack)
				myGm.Translate (0, 0, -1);
			else
				myGm.Translate (0, 0, 1);
		}

		if (moveTornado) {
			if (myTor.position.z > 30)
				gmMoveBackTornado = true;
			if (myTor.position.z < -30)
				gmMoveBackTornado = false;

			if (gmMoveBackTornado)
				myTor.Translate (0, 0, -1);
			else
				myTor.Translate (0, 0, 1);
		}
	}
}
