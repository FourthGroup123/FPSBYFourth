using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using LitJson;
public class LSynopsis : MonoBehaviour
{
    Button _btn;
    // Animator ani;
   
    Text _text;
    int i = 0;
    JsonData jsd;
    public void Awake()
    {

        //btn = GameObject.FindWithTag("btn").GetComponent<Button>();
        _btn = transform.Find("Button").GetComponent<Button>();
        _text = transform.Find("Text").GetComponent<Text>();
        //Debug.Log(_btn);
      //  ani = GameObject.FindWithTag("bb").GetComponent<Animator>();
       
        
    }

    // Use this for initialization
    void Start()
    {
        TextAsset m_text = Resources.Load("JSONText") as TextAsset;
        string str = m_text.text;

        // Debug.LogError("str="+str);

         jsd = JsonMapper.ToObject(str);
        // Debug.Log(jsd.Count);
        _btn.onClick.AddListener(A);
        
    
    }

    void A()
    {
       //文字提示
        if (i < jsd.Count)
        {
            if (i==jsd.Count-1)
            {
                LUiMgr._UiMgr._Player.die();
            }
          //  Debug.Log("mosterID=" + jsd[i]["mosterID"]);
           // Debug.Log("Name=" + jsd[i]["MosterName"].ToString());
            _text.text= jsd[i]["MosterName"].ToString();
        }
        i++;
       // Debug.Log("aaaa");
       // _player.die();

    }
    void Update()
    {
       
    }
}
