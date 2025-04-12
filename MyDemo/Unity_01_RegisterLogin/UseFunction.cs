using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseFunction : MonoBehaviour
{
    //�˺ţ������ı���
    public InputField usernameText, passwordText;
    private Method method;
    //������壬����
    public GameObject remindImage;
    public Text remindText;
    void Start()
    {
        //��ѯ��Ϸ����nameΪController�ģ�����ȡ����������Method��ǰ�᣺��Method�󶨵�Controller���棩
        method = GameObject.Find("Controller").GetComponent<Method>();
    }
    public void Register()
    {
        string username = usernameText.text;
        string password = passwordText.text;
        if(string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
        {
            remindText.text = "�˺Ż����벻��Ϊ�գ���";
            ActiveRemind();
            //1s��ر����
            Invoke("CloseImage", 1.0f);
            return;
        }
        if(method.Register(username, password))
        {

        }
    }
    public void Login()
    {
        string username = usernameText.text;
        string password = passwordText.text;
        if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
        {
            remindText.text = "�˺Ż����벻��Ϊ�գ���";
            ActiveRemind();
            //1s��ر����
            Invoke("CloseImage", 1.0f);
            return;
        }
        if(method.Login(username, password))
        {

        }
    }
    //���������
    void ActiveRemind()
    {
        remindImage.SetActive(true);
    }
    //�ر����
    void CloseImage()
    {
        remindImage.SetActive(false);
    }
}