//총알 움직임 스크립트
//Bullet 프리팹에 적용
public class cshFire : MonoBehaviour {
	private float bulletSpeed = 1000.0f;
	private Transform thisTransform;    //Unity에서 변수 지정해줘야함
	
	void Start () {
		thisTransform = GetComponent<Transform> ();
		FireBullet ();
	}

    //Bullet객체에 스크립트 적용하고 Rigidbody추가 후 Use gravity 체크해제
    //Prefab 갱신해줘야함
	void FireBullet(){
		GetComponent<Rigidbody> ().AddForce (thisTransform.forward * bulletSpeed);
	}
}

//총알 생성 스크립트
//BulletFirePos에 적용
public class cshSpawnBullet : MonoBehaviour {
	public Transform Bullet;
	public float fireTime = 1.0f;
	public float firePassTime = 0.0f;
	public Transform BulletFirePos;
	
	void Update () {
		if (firePassTime >= fireTime) {
			Instantiate (Bullet, BulletFirePos.position, BulletFirePos.rotation);
			firePassTime = 0.0f;
		} else {
			firePassTime += Time.deltaTime;
		}
	}
}

//Bullet 충돌처리
//Wall 객체에 각각 적용(4개)
//Bullet 프리팹에 BoxCollider 추가
public class cshHitBullet : MonoBehaviour {

    void Start () {
		
	}
    void Update () {
		
	}
    
    //OnCollisionEnter(Collision ~ ) 해당 스크립트가 적용된 객체에 Collision객체가 들어왔을 때 처리 함수 
    void OnCollisionEnter(Collision coll){
	    if (coll.gameObject.tag == "BULLET") {  //Collision객체의 태그가 BULLET이면
		    Destroy (coll.gameObject);          //Collision객체를 삭제
	    }
    }
}
