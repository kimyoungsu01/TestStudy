using UnityEngine;

public class Slims : BaseEnemy
{
    public override void Name()
    { 
      string[] Name = new string[3];
      Name[0] = "초록 슬라임";
      Name[1] = "파란 슬라임";
      Name[2] = "보라 슬라임";
    }

    public override void Lv()
    {
        int[] lv = new int[3];
        lv[0] = 1;
        lv[1] = 2;
        lv[2] = 3;
    }

    public override void Health(Collision collision)
    {
        int[] health = new int[3];
        health[0] = 10;
        health[1] = 20;
        health[2] = 30;
    }

    public override void Gold(Collision collision) 
    { 
        int[] gold = new int[3];
        gold[0] = 5;
        gold[1] = 10;
        gold[2] = 15;
    }

    public override void Attack(Collision collision)
    {
        // 슬라임 공격 패턴 작성
        collision.gameObject.GetComponent<BaseEnemy>().GetComponent<Player>();
        
        int[] AttackDamage = new int[3];
        AttackDamage[0] = damage;
        AttackDamage[1] = damage + 10;
        AttackDamage[2] = damage + 20;

        foreach (int Damage in AttackDamage) // 10 in [0,1,2]
        {
            
        }
    }
}
