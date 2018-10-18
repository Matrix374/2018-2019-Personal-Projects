using UnityEngine;

public class TimeController : MonoBehaviour
{

    public float slowdownFactor = 0.2f;
    public float slowdownLength = 2.0f;
    private bool slowdownActivate = false;

    void Update()
    {
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
    }

    public void DoSlowdown()
    {
        Time.timeScale = slowdownFactor;
        slowdownActivate = true;
    }

    public bool CheckSlowdown()
    {
        return slowdownActivate;
    }

    public void Reset()
    {
        Time.timeScale = 1.0f;
        slowdownActivate = false;
    }


}
