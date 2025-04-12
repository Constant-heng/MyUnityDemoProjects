using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InputNumber : MonoBehaviour
{
    public InputField usernameText, passwordText, rightTitle;
    //将下面的方法绑定到各个数字按钮上面，并拖入到Button组件上面进行方法调用,则可以实现添加数字的功能
    public void ButtonClick()
    {
        if(rightTitle.text == "账号")
        {
            usernameText.text += transform.gameObject.name;
        }
        if (rightTitle.text == "密码")
        {
            passwordText.text += transform.gameObject.name;
        }
    }
    //清空文本框
    public void Empty()
    {
        if (rightTitle.text == "账号")
        {
            usernameText.text = string.Empty;
        }
        if (rightTitle.text == "密码")
        {
            passwordText.text = string.Empty;
        }
    }
}