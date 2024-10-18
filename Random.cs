public class cshTest : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //범위를 정수로 주었을 때
        int rnd = Random.Range(0, 2); //0~2까지가 아닌 0~1까지, 즉 0~n-1까지 범위이다.
        Debug.Log("정수 범위: "+rnd);

        //범위를 실수로 주었을 때
        float rnd2 = Random.Range(0.0f, 2.0f) //0~2 범위
        Debug.Log("실수 범위: "+rnd2); 
    }
}
