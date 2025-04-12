using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TypeWord : MonoBehaviour
{
    //��������ͨ���ֻ��Ĺ����ļ�

    //�ı����
    public Text ShowText;
    //��Ҫչʾ������
    public string ShowStr;
    //ÿ����֮������ʱ��
    public float ShowTime;
    void Start()
    {
        StartCoroutine(Typing());
    }
    //��дЭ�̷�����ʵ�ִ��ֻ��Ĺ���
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
