using UnityEngine;
using System.Collections;

public class LUiMgr : MonoBehaviour
{
    Lplayer _player;
   static LUiMgr _uiMgr;
   public static LUiMgr _UiMgr
    {
        get
        {
            return _uiMgr;
        }
    }

    public void Awake()
    {
        _uiMgr = this;
        _player = GameObject.FindWithTag("Player").GetComponent<Lplayer>();
    }

    public Lplayer _Player
    {
        get
        {
            return _player;
        }
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
