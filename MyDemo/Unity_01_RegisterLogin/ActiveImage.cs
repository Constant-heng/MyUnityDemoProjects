using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveImage : MonoBehaviour
{
    //文本框
    public InputField rightTitle;
    public string Name;
    //密码框
    public GameObject NumberImage;
    //在InputField物体上面添加Event Trigger组件
    //并添加Pointer Click方法，将下面的方法绑定到其上面
    public void OpenNumberImage()
    {
        rightTitle.text = Name;
        NumberImage.SetActive(true);
    }
}