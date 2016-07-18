using UnityEngine;
using System.Collections;

public class MoveController : MonoBehaviour {

    private Animation ani;
    private SmoothFollow sf;
    private CharacterController cc;

    void Start()
    {
        ani = GetComponent<Animation>();
        sf = Camera.main.GetComponent<SmoothFollow>();
        cc = GetComponent<CharacterController>();
        sf.ResetView();
    }

    void OnEnable()
    {
        EasyJoystick.On_JoystickMove += OnJoystickMove;
        EasyJoystick.On_JoystickMoveEnd += OnJoystickMoveEnd;
    }

    void OnDisable()
    {
        EasyJoystick.On_JoystickMove -= OnJoystickMove;
        EasyJoystick.On_JoystickMoveEnd -= OnJoystickMoveEnd;
    }

    void OnDestroy()
    {
        EasyJoystick.On_JoystickMove -= OnJoystickMove;
        EasyJoystick.On_JoystickMoveEnd -= OnJoystickMoveEnd;
    }


    void OnJoystickMoveEnd(MovingJoystick move)
    {
        if (move.joystickName == "MoveJoystick")
        {
            ani.CrossFade("Idle");
        }
    }
    void OnJoystickMove(MovingJoystick move)
    {
        float joyPositionX = move.joystickAxis.x;
        float joyPositionY = move.joystickAxis.y;

        if (move.joystickName == "MoveJoystick")
        {
            if (joyPositionY != 0 || joyPositionX != 0)
            {
                //设置角色的朝向（朝向当前坐标+摇杆偏移量）
                Quaternion r = Quaternion.Euler(0, Camera.main.transform.eulerAngles.y, 0);

                Vector3 dir = r * new Vector3(joyPositionX, 0, joyPositionY);
                transform.LookAt(new Vector3(transform.position.x + dir.x, transform.position.y, transform.position.z + dir.z));
                
                //移动玩家的位置（按朝向位置移动）
                //transform.Translate(Vector3.forward * Time.deltaTime * 2);
                dir.Normalize();
                cc.Move(dir * Time.deltaTime * 2);
                //移动摄像机
                sf.FollowUpdate();
                //播放奔跑动画
                //ani.wrapMode = WrapMode.Loop;
                ani.CrossFade("Walk");
                //animator.speed = 2.0f;
                //animator.SetFloat("Speed", 1.0f);
            }
        }
    }

}
