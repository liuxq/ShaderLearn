using UnityEngine;
using System.Collections;

public class Animaton_Control : MonoBehaviour
{

    public GameObject frog;

    public AnimationClip[] AniList = new AnimationClip[9];

    void Start()
    {


    }

    void OnGUI()
    {

        //继续使用Ongui，是因为，排版/响应点击事件 便利
        //public void CrossFade(string animation, float fadeLength = 0.3F, PlayMode mode = PlayMode.StopSameLayer);

        if (GUI.Button(new Rect(20, 20, 70, 40), "Idle"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Once;
            frog.GetComponent<Animation>().CrossFade("Idle");
        }
        if (GUI.Button(new Rect(90, 20, 70, 40), "Walk"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            frog.GetComponent<Animation>().CrossFade("Walk");
        }
        if (GUI.Button(new Rect(160, 20, 70, 40), "L_Walk"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            frog.GetComponent<Animation>().CrossFade("L_Walk");
        }
        if (GUI.Button(new Rect(230, 20, 70, 40), "R_Walk"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            frog.GetComponent<Animation>().CrossFade("R_Walk");
        }
        if (GUI.Button(new Rect(300, 20, 70, 40), "B_Walk"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            frog.GetComponent<Animation>().CrossFade("B_Walk");
        }
        if (GUI.Button(new Rect(370, 20, 70, 40), "Talk"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            frog.GetComponent<Animation>().CrossFade("Talk");
        }
        if (GUI.Button(new Rect(440, 20, 70, 40), "Run"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            frog.GetComponent<Animation>().CrossFade("Run00");
        }
        if (GUI.Button(new Rect(510, 20, 70, 40), "L_Run"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            frog.GetComponent<Animation>().CrossFade("L_Run00");
        }
        if (GUI.Button(new Rect(580, 20, 70, 40), "R_Run"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            frog.GetComponent<Animation>().CrossFade("R_Run00");
        }
        if (GUI.Button(new Rect(650, 20, 70, 40), "B_Run"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            frog.GetComponent<Animation>().CrossFade("B_Run00");
        }
        if (GUI.Button(new Rect(720, 20, 70, 40), "Jump"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Once;
            frog.GetComponent<Animation>().CrossFade("Jump_NoBlade");
        }
        if (GUI.Button(new Rect(20, 65, 70, 40), "Draw Blade"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Once;
            frog.GetComponent<Animation>().CrossFade("DrawBlade");
        }
        if (GUI.Button(new Rect(90, 65, 70, 40), "AtkStandy"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            frog.GetComponent<Animation>().CrossFade("AttackStandy");
        }
        if (GUI.Button(new Rect(160, 65, 70, 40), "Attack00"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Once;
            frog.GetComponent<Animation>().CrossFade("Attack00");
        }
        if (GUI.Button(new Rect(230, 65, 70, 40), "Attack01"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Once;
            frog.GetComponent<Animation>().CrossFade("Attack");
        }
        if (GUI.Button(new Rect(300, 65, 70, 40), "Block"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Once;
            frog.GetComponent<Animation>().CrossFade("Block");
        }
        if (GUI.Button(new Rect(370, 65, 70, 40), "Attack02"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Once;
            frog.GetComponent<Animation>().CrossFade("Attack01");
        }
        if (GUI.Button(new Rect(440, 65, 70, 40), "Combo"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Once;
            frog.GetComponent<Animation>().CrossFade("ComboAttack");
        }
        if (GUI.Button(new Rect(510, 65, 70, 40), "Skill"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Once;
            frog.GetComponent<Animation>().CrossFade("Skill");
        }
        if (GUI.Button(new Rect(580, 65, 70, 40), "M_Avoid"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            frog.GetComponent<Animation>().CrossFade("M_Avoid");
        }
        if (GUI.Button(new Rect(650, 65, 70, 40), "L_Avoid"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            frog.GetComponent<Animation>().CrossFade("L_Avoid");
        }
        if (GUI.Button(new Rect(720, 65, 70, 40), "R_Avoid"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            frog.GetComponent<Animation>().CrossFade("R_Avoid");
        }
        if (GUI.Button(new Rect(20, 110, 70, 40), "Run01"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            frog.GetComponent<Animation>().CrossFade("Run");
        }
        if (GUI.Button(new Rect(90, 110, 70, 40), "L_Run01"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            frog.GetComponent<Animation>().CrossFade("L_Run");
        }
        if (GUI.Button(new Rect(160, 110, 70, 40), "R_Run01"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            frog.GetComponent<Animation>().CrossFade("R_Run");
        }
        if (GUI.Button(new Rect(230, 110, 70, 40), "B_Run01"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            frog.GetComponent<Animation>().CrossFade("B_Run");
        }

        if (GUI.Button(new Rect(300, 110, 70, 40), "Jump01"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Once;
            frog.GetComponent<Animation>().CrossFade("jump");
        }
        if (GUI.Button(new Rect(370, 110, 70, 40), "PickUp"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Once;
            frog.GetComponent<Animation>().CrossFade("Pickup");
        }

        if (GUI.Button(new Rect(440, 110, 70, 40), "Damage"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Once;
            frog.GetComponent<Animation>().CrossFade("Damage");
        }
        if (GUI.Button(new Rect(510, 110, 70, 40), "Death"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Once;
            frog.GetComponent<Animation>().CrossFade("Death");
        }
        if (GUI.Button(new Rect(580, 110, 120, 40), "GangnamStyle"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Once;
            frog.GetComponent<Animation>().CrossFade("GanamStyle");
        }
        if (GUI.Button(new Rect(620, 470, 120, 40), "Ver 2.0"))
        {
            frog.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            frog.GetComponent<Animation>().CrossFade("Idle");
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape)) Application.Quit();

    }

}
