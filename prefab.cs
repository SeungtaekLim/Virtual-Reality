using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class code : MonoBehaviour
{
    //prefab 변수 선언
    //Unity에서 스크립트를 준 오브젝트 클릭
    //-> Inspector항목에서 해당 스크립트에 prefab변수에 내가 만든 prefab객체를 지정해주어야 함.
    public GameObject prefab;

    void Update()
    {   
        //prefab(프리팹): 똑같은 객체를 여러번 그릴 때 메모리를 하나만 잡고 그리기만 여러 번 하는 작업(인스턴싱)
        if (Input.GetMouseButtonDown(0)){    //마우스버튼(좌클릭)을 누르면
            //Instantiate(): Unity에서 게임 오브젝트를 생성할 때 사용. 해당 프리팹을 복제하여 게임 내에 새로운 인스턴스를 만듭니다.
             GameObject go = GameObject.Instantiate(prefab) as GameObject;
            //프리팹 생성 후 (-2.0~2.0, 1.0, 1.0)로 위치시킨다.
            go.transform.position = new Vector3(Random.Range(-2.0f, 2.0f), 1.0f, 1.0f);
        }
    }
}
