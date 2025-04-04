using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginUI : MonoBehaviour
{
    public InputField AccountInputfield;
    public InputField PasswordInputfield;

    public GameObject remindImage;
    public Text Remind;

    private AccountMananger accountMananger;

    private void Start()
    {
        accountMananger = GameObject.FindWithTag("Controller").GetComponent<AccountMananger>();
    }
    public void Register()
    {
        string username = AccountInputfield.text;
        string password = PasswordInputfield.text;
        if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            Remind.text = "�˺Ż����벻��Ϊ�գ�����";
            RemindActive();
            Invoke("RemindFalse", 1.0f);
            return;
        }
        if(accountMananger.Register(username, password))
        {
            Remind.text = "ע��ɹ�!!!";
            RemindActive();
            Invoke("RemindFalse", 1.0f);
        }
    }
    public void Login()
    {
        string username = AccountInputfield.text;
        string password = PasswordInputfield.text;

        if (accountMananger.Login(username, password))
        {
            //Debug.Log("��¼�ɹ�����ӭ������");
        }
    }
    void RemindActive()
    {
        remindImage.SetActive(true);
    }
    void RemindFalse()
    {
        remindImage.SetActive(false);
    }
}
