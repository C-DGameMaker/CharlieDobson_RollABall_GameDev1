using UnityEngine;

public class RollingBall : MonoBehaviour
{
    public GameObject myBall;
    public float timer = 0;

    static Vector3 start;
    static Vector3 end;

    void Start()
    {
        myBall.SetActive(true);

        start = new Vector3(-13, -3, 14.5f);
        end = new Vector3(13, -3, 14.5f);
        myBall.transform.position = start;
    }
    

   void Update()
    {

        timer += Time.deltaTime;
        float t = timer;
        t = Mathf.Clamp01(t);

        myBall.transform.position = Vector3.Lerp(start, end, t);

        if (t >= 1f)
        {
            timer = 0f;
            (start, end) = (end, start);
        }
    }
}
