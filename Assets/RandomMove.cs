using UnityEngine;
using System.Collections;

public class RandomMove : MonoBehaviour {
	void start(){
		InvokeRepeating("Update",1,1);
}
	

	void Update () {
		float i = Random.Range (-0.2F, 0.2F);



		gameObject.transform.Translate (-i, 0, i);
	}

}
