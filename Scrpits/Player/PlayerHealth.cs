using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100; // 玩家开始的血量
    public int currentHealth;  // 玩家当前的血量
    public Slider HealthSlider; // 玩家的血量条UI
    public Image damageImage; // 伤害图片
    public AudioClip deathClip; // 玩家死亡声音
    public float bulletSpeed = 5f; // 子弹的速度
    //public float flashSpeed = 5f; // 子弹的闪光速度
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f); // 子弹的闪光颜色

    Animator _anim; // 玩家动画
    AudioSource _playerAudio; // 玩家角色的声音 
    PlayerMovement _playerMovement; // 玩家移动类
    bool isDead; // bool值<玩家是否死亡>
    bool damaged; // bool值<玩家是否受到伤害>

    void Awake()
    {
        // 游戏开始获得基本的组件
        _anim = GetComponent<Animator>(); // 获得动画
        _playerAudio = GetComponent<AudioSource>(); // 获得声音
        _playerMovement = GetComponent<PlayerMovement>(); // 获得玩家移动类
        currentHealth = startingHealth; // 游戏开始 当前的血量 = 初始的血量
    }



	void Start ()
    {
	
	}
	
	void Update ()
    {
	
	}
}
