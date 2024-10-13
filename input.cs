using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//code.cs라는 스크립트 파일로 만들었음.
public class code : MonoBehaviour
{
    // 첫 Update()호출 전 한번만 호출되는 Start()함수
    void Start()
    {
        
    }

    // 매 프레임마다 호출되는 Update()함수
    void Update()
    {
        //키보드 입력 예제
        //마우스 입력 메소드: Input.GetKey(키코드)/GetKeyDown(키코드)/GetKeyUp(키코드)/AnyKeyDown(키코드)
        //키코드: KeyCode.Return/UpArrow/DownArrow/LeftArrow/RightArrow/Escape/BackSpace/X/S/LeftShift/RightControll/F1 등등
        if (Input.GetKey (KeyCode.Space)) {
		    Debug.Log ("space!");
	    }

        //마우스 입력 예제
        //마우스 입력 메소드: Input.GetMouseButton/GetMouseButtonUp/GetMouseButtonDown
        //마우스 위치 메소드: Input.MousePosition
        if(Input.GetMouseButtonDown(0)){
            Debug.Log (Input.mousePosition);
        }
       


    }
}
