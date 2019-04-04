using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{   public Animator animator;
    public double blood = 200.0; // 怪物血量
    private double experience = 0.0; // 掉落经验
    private double attackPoint = 50;//怪物攻击值
    private double coin = 20;//怪物金币掉落？
    private int IDLE = 1;
    private int ATTACK = 2;


    
    Hashtable args = new Hashtable();
    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();



    }

    // Update is called once per frame
    void Update()
    {
        if (true) { 
            animator.SetBool("Walk", true);

            args.Add("path", iTweenPath.GetPath("path1"));//指定位移路径为Path1，这时候iTweenPath就发挥作用了
            args.Add("easeType", iTween.EaseType.linear);//设置动画类型为线性，平滑地在路径点中移动。
            args.Add("time", 10f);//ns内跑完这条路径
            args.Add("delay", 0f);//0.1s之后才开始 
            args.Add("movetopath", true);//要求物体先从原始位置走到路径中第一个点的位置，再跑这条路径
            args.Add("loopType", "loop");
            args.Add("orienttopath", true);
     

            iTween.MoveTo(gameObject, args);
           
        }
        
    }
}
