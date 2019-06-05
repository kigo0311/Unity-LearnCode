﻿using UnityEngine;
[System.Serializable]
public class Dog
{
    #region 欄位
    public string name;
    public float weight;
    public string type;
    public string color;

    private string sex;
    private int age;
    #endregion

    #region 建構函式
    //建構函式可以多載
    public Dog()
    {

    }

    public Dog(string sex, int age);
    {
        this.sex = sex;
        this.age = age;
    }
    #endregion



    #region 方法
    /// <summary>
    /// 狗狗亂叫的方法
    /// </summary>
    public void Brark()
    {
        Debug.Log(name + "：汪汪!!!");
    }
    /// <summary>
    /// 狗狗轉換年齡的方法
    /// </summary>
    /// <returns></returns>
    public int ConvertAge()
    {
        return age * 7;
    }

    /// <summary>
    ///狗狗吃東西的方法。
    /// </summary>
    ///<param name = "food">食物<param/>
    ///<param name = "speed">吃飯速度<param/>
    public void Eat(string food, int count)
    {
        Debug.Log(name + ":" + food + ",份量" + count);
    }

    public void Eat(string food, string speed = "慢")
    {
        Debug.Log(name + ";" + food + "，速度" + speed);
    }
    #endregion
}