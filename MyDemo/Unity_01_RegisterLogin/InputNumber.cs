using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InputNumber : MonoBehaviour
{
    public InputField usernameText, passwordText, rightTitle;
    //������ķ����󶨵��������ְ�ť���棬�����뵽Button���������з�������,�����ʵ��������ֵĹ���
    public void ButtonClick()
    {
        if(rightTitle.text == "�˺�")
        {
            usernameText.text += transform.gameObject.name;
        }
        if (rightTitle.text == "����")
        {
            passwordText.text += transform.gameObject.name;
        }
    }
    //����ı���
    public void Empty()
    {
        if (rightTitle.text == "�˺�")
        {
            usernameText.text = string.Empty;
        }
        if (rightTitle.text == "����")
        {
            passwordText.text = string.Empty;
        }
    }
}