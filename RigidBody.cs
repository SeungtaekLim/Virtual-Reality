using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class code : MonoBehaviour
{
    // 첫 Update()호출 전 한번만 호출되는 Start()함수
    void Start()
    {
        
    }

    // 매 프레임마다 호출되는 Update()함수
    void Update()
    {
        //Component: 오브젝트의 모든 속성
        //GetComponent<Rigidbody>: 이 스크립트가 적용된 오브젝트의 Component를 가져온다. 그 중 Rigidbody 속성을 가져옴.
        //주의사항: 스크립트를 적용할 오브젝트에 Rigidbody를 부여해야 정상작동
        if (Input.GetKey (KeyCode.UpArrow)) {
            //AddForce(): 가져온 Rigidbody 속성에 힘을 적용
            //foward/back: z축
		    GetComponent<Rigidbody> ().AddForce (Vector3.forward * 300 * Time.deltaTime);
	    }
	    if (Input.GetKey (KeyCode.DownArrow)) {
	    	GetComponent<Rigidbody> ().AddForce (Vector3.back * 300 * Time.deltaTime);
	    }
	    if (Input.GetKey (KeyCode.LeftArrow)) {
            //left/right: x축
		    GetComponent<Rigidbody> ().AddForce (Vector3.left * 300 * Time.deltaTime);
	    }
	    if (Input.GetKey (KeyCode.RightArrow)) {
	    	GetComponent<Rigidbody> ().AddForce (Vector3.right * 300 * Time.deltaTime);
	    }
	    if (Input.GetKey (KeyCode.U)) {
            //up/down: y축
	    	GetComponent<Rigidbody> ().AddForce (Vector3.up * 300 * Time.deltaTime);
	    }
	    if (Input.GetKey (KeyCode.D)) {
	    	GetComponent<Rigidbody> ().AddForce (Vector3.down * 300 * Time.deltaTime);
	    }

        //중력제어
        if (Input.GetKeyDown (KeyCode.Keypad0)) {
            //gravity파라미터 이용
            //중력을 제거
		    Physics.gravity = Vector3.zero;
	    }
	    if (Input.GetKeyDown (KeyCode.Keypad8)) {
            //중력을 위로 작용
	    	Physics.gravity = Vector3.up;
	    }
	    if (Input.GetKeyDown (KeyCode.Keypad2)) {
	    	Physics.gravity = Vector3.down;
	    }

    }
}
