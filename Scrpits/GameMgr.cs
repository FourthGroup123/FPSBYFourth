using UnityEngine;
using System.Collections;

public class GameMgr : MonoBehaviour {

    //单例
    static GameMgr Inst;
    public static GameMgr Instance
    {
        get
        {
            return Inst;
        }
    }
    //各个管理类
    EnemyMgr _enemy;
    UIMgr _ui;
    ShopMgr _shop;
    NPCMgr _npc;
    void Awake()
    {
        Inst = this;
        _enemy = gameObject.AddComponent<EnemyMgr>();
        _ui = gameObject.AddComponent<UIMgr>();
        _shop = gameObject.AddComponent<ShopMgr>();
        _npc = gameObject.AddComponent<NPCMgr>();
    }
    //获得管理类的属性
    public EnemyMgr getEnemyMgr
    {
        get
        {
            return _enemy;
        }
    }
    public UIMgr getUIMgr
    {
        get
        {
            return _ui;
        }
    }
    public ShopMgr getShopMgr
    {
        get
        {
            return _shop;
        }
    }
    public NPCMgr getNPCMgr
    {
        get
        {
            return _npc;
        }

    }



}
