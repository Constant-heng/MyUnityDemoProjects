using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseFunction : MonoBehaviour
{
    //账号，密码文本框
    public InputField usernameText, passwordText;
    private Method method;
    //提醒面板，文字
    public GameObject remindImage;
    public Text remindText;
    void Start()
    {
        //查询游戏物体name为Controller的，并获取其上面的组件Method（前提：将Method绑定到Controller上面）
        method = GameObject.Find("Controller").GetComponent<Method>();
    }
    public void Register()
    {
        string username = usernameText.text;
        string password = passwordText.text;
        if(string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
        {
            remindText.text = "账号或密码不能为空！！";
            ActiveRemind();
            //1s后关闭面板
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
            remindText.text = "账号或密码不能为空！！";
            ActiveRemind();
            //1s后关闭面板
            Invoke("CloseImage", 1.0f);
            return;
        }
        if(method.Login(username, password))
        {

        }
    }
    //打开提醒面板
    void ActiveRemind()
    {
        remindImage.SetActive(true);
    }
    //关闭面板
    void CloseImage()
    {
        remindImage.SetActive(false);
    }
}