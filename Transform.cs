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
        //position 변경
       if(Input.GetKeyDown(KeyCode.A)){ //A버튼을 눌렀을 때
		    float rnd = Random.Range(0.0f, 0.5f);   //0.0~0.5사이의 랜덤 실수
		    //이 스크립트를 적용한 게임오브젝트(this)의 transform 속성의 position(x,y,z)을 지정
            //position = (0.0, 1.0, 0.0~0.5)
            this.transform.position = new Vector3(0.0f, 1.0f, rnd); 
            
	    }

        //rotation 변경
	    if(Input.GetKeyDown(KeyCode.B)){    //B버튼을 눌렀을 때
		    float rnd = Random.Range(0.0f, 360.0f); //0.0~360.0사이의 랜덤 실수
            //이 스크립트를 적용한 게임오브젝트의 transform 속성의 rotation을 x축 기준으로 랜덤 회전
		    this.transform.rotation = Quaternion.Euler (rnd, 0.0f, 0.0f);   
	    }
        
        //Translate() 함수
        if(Input.GetKey(KeyCode.UpArrow)){  //위 화살표를 누르고 있는 동안

            //Time.deltaTime: Update()함수 호출 주기에 따라 다른 값
            //컴퓨터 사양에 따라 이동거리가 달라지지 않도록 움직임

            //Translate(): 위의 position을 직접 변경한 것과 다르게 현재 위치에서 z축으로 3만큼 움직인다.
            //오브젝트가 향한 방향에 따라 움직인다.(오브젝트의 축 유의)
		    this.transform.Translate (new Vector3 (0.0f, 0.0f, 3.0f * Time.deltaTime));
    	}

        //Rotate() 함수
        if(Input.GetKey(KeyCode.R)){
            //Rotate(): 위의 rotation을 직접 변경한 것과 다름. 현재 상태에서 x축 기준 90만큼 회전하는 것
		    this.transform.Rotate ( 90.0f * Time.deltaTime, 0.0f, 0.0f);
	    }
	    if(Input.GetKey(KeyCode.L)){
		    this.transform.Rotate (-90.0f * Time.deltaTime, 0.0f, 0.0f);
	    }

        //Scale
        if(Input.GetKey(KeyCode.S)){
            //x,y,z축 방향으로 3배 크기
            this.transform.localScale = new Vector3(3.0f, 3.0f, 3.0f);
        }
    }
}
