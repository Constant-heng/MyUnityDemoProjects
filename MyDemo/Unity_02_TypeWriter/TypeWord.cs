using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TypeWord : MonoBehaviour
{
    //以下是普通打字机的功能文件

    //文本组件
    public Text ShowText;
    //需要展示的文字
    public string ShowStr;
    //每个字之间间隔的时间
    public float ShowTime;
    void Start()
    {
        StartCoroutine(Typing());
    }
    //编写协程方法，实现打字机的功能
    IEnumerator Typing()
    {
        ShowText.text = string.Empty;
        string temp = string.Empty;

        for (int i = 0; i < ShowStr.Length; i++)
        {
            yield return new WaitForSeconds(ShowTime);
            temp += ShowStr[i];
            ShowText.text = temp;
        }
    }
}
