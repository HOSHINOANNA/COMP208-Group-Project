using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterAttribute : MonoBehaviour
{
    public double blood = 200.0; // 血量， 实际运行时请换成private
    private double experience = 0.0; // 经验
    private int level = 0; // 等级
    private int money = 0; // 钱
    public Animator animator;

    private double playerBloodUpperLimit = 150.0; // 血上限
    private double playerAttack = 10.0; // 基础攻击

    private int weaponID = 0; // 手持武器ID

    // Start is called before the first frame update
    void Start()
    {
        readSaveFile();
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // 每个单帧调用一次（待写）

        updateBloodBar(); // 测试用，可以注释掉。
        updateLevel();
        checkBlood();
        getBlood();
    }

    void readSaveFile()
    {
        // 读取存档(待写）
    }

    void writeToSaveFile()
    {
        // 写入存档（待写）
    }

    void playerDie()
    {//死亡动画控制
        animator.SetBool("die", true);

    
    }

    void attack()
    {
        // 人物攻击（待写）
    }

    void updateBloodBar()
    {
        float ratio = (float)(blood / playerBloodUpperLimit);
        GameObject.Find("BloodBarSlider").GetComponent<Slider>().value = ratio;

        string display = blood + "/" + playerBloodUpperLimit;
        GameObject.Find("BloodBarText").GetComponent<Text>().text = display;

    }

    void updateLevel()
    {
        // 升级所需经验是一个二次函数
        double upgradeNeededExp = this.level * this.level;

        if (this.level >= 30)
        {
            // 最高只能是30级
            return;
        }

        if (this.experience >= upgradeNeededExp)
        {
            this.experience = this.experience - upgradeNeededExp;
            this.level++;
            updatePlayerAttack();
            updatePlayerBloodUpperLimit();
        }
    }

    void updatePlayerAttack()
    {
        // 人物基础攻击为10，最高30级，为160
        this.playerAttack = this.level * 5 + 10;
    }

    void updatePlayerBloodUpperLimit()
    {
        // 人物基础血上限200，满级500
        this.playerBloodUpperLimit = this.level * 10 + 200;
    }

    public void addBlood(double addBlood)
    {
        // 调用这个函数，如果你想让人物回血
        // 输入：你想加多少血（double）
        this.blood = this.blood + addBlood;
        if (addBlood > this.playerBloodUpperLimit)
        {
            this.blood = this.playerBloodUpperLimit;
        }
        updateBloodBar();
    }

    public bool minusBlood(double minusBlood)
    {
        // 调用这个函数，如果你想让人物减血
        // 输入：你想减多少血（double）
        // 如果是致死伤害，会返回false，否则true

        this.blood = this.blood - minusBlood;

        if (this.blood <= 0)
        {
            this.blood = 0;
            updateBloodBar();
            playerDie();
            return false;
        }
        updateBloodBar();
        return true;
    }

    public void addExperience(double addExp)
    {
        // 调用这个函数，如果你想增加人物经验值
        // 输入：你想加多少（double）
        this.experience = this.experience + addExp;
        updateLevel();
    }

    public void addMoney(int addMoney)
    {
        // 调用这个函数，如果你想要增加金钱
        // 输入： 你想加多少（int）
        this.money = this.money + addMoney;
    }

    public bool minusMoney(int minusMoney)
    {
        // 调用这个函数，如果你想要扣除金钱
        // 输入：扣除的值（int）
        // 如果没有那么多钱，扣除失败并返回false，否则true
        if (this.money < minusMoney)
        {
            return false;
        }
        else
        {
            this.money = this.money - minusMoney;
            return true;
        }
    }

    public double getPlayerAttack()
    {
        // 人物攻击力的getter
        return this.playerAttack;
    }

    public double getPlayerBloodUpperLimit()
    {
        // 人物血上限的getter
        return this.playerBloodUpperLimit;
    }

    public double getBlood()
    {
        // 人物血量的getter
        return this.blood;
    }

    public double getEXP()
    {
        // 人物经验的getter
        return this.experience;
    }

    public double getLevel()
    {
        // 人物等级的getter
        return this.level;
    }

    

    public double getMoney()
    {
        // 人物金币的getter
        return this.money;
    }

    public void equipWithWeapon(int id)
    {
        // 装备武器，输入参数为武器ID（int）
        this.weaponID = id;
    }

    public void unequip()
    {
        // 去掉武器装备
        this.weaponID = 0;
    }
    public void checkBlood()
    {
        if (blood == 0)
        {
            playerDie();

        }


    }
}