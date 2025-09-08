using UnityEngine;


public interface IEnemy
{
    void Name();
    void Lv();
    void Health(Collision collision);
    void Attack(Collision collision);
    void Gold(Collision collision);
}

public interface ITakeDamage
{
    void TakeDamage();
}

public abstract class BaseEnemy : MonoBehaviour, IEnemy
{
    [field: SerializeField] public string name { get; set; }
    [field: SerializeField] public int lv { get; set; }
    [field: SerializeField] public int health { get; set; }
    [field:SerializeField] public int damage { get; set; }
    [field: SerializeField] public int gold { get; set; }
    [field: SerializeField] public int takeDamage { get; set; }

    public virtual void Name()
    {
        Debug.Log("Name " + name);
    }

    public virtual void Lv()
    {
        Debug.Log("Lv " + lv);
    }

    public virtual void Health(Collision collision)
    {
        Debug.Log("Health " + health);
    }

    public virtual void Attack(Collision collision)
    {
        Debug.Log("Attack " + damage);
    }

    public virtual void Gold(Collision collision)
    {
        Debug.Log("Gold " + gold);
    }

    public void TakeDamage() 
    {
       Debug.Log("TakeDamage " + takeDamage);
        takeDamage -= damage;
    }
}



