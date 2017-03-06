using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class player : MonoBehaviour
{

    Animator _ani;
    public void Awake()
    {
        _ani = GetComponent<Animator>();
        //die();
    }

    //死亡动画
    public void die()
    {
        //Debug.Log("aq");
        _ani.SetBool("Isdie", true);
    }

}
