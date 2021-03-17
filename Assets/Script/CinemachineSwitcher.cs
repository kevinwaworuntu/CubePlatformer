using UnityEngine;
using Cinemachine;
public class CinemachineSwitcher : MonoBehaviour
{
    public CinemachineVirtualCamera vCam1;
    public CinemachineVirtualCamera vCam2;
    public int currentPost;


    // Start is called before the first frame update
    void Start()
    {
        currentPost = 0;
    }

    // Update is called once per frame
    void Update()
    {
        SwitchPriority();
    }

    void SwitchPriority()
    {
        if(currentPost == 0)
        {
            vCam1.Priority = 2;
            vCam2.Priority = 1;
        }
        else
        {
            vCam1.Priority = 1;
            vCam2.Priority = 2;
        }
    }
}
