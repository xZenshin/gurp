namespace enemy;
using UnityEngine;
public class slime: MonoBehaviour, Ienemy
{
    //fields
    
    //hp, starter med 100
    private float hp{ get; private set; } = 100f;
    
    //attack: mængde af skade den gør, ens med alle. starter på 20
    private static float attack{ get; } = 20f;


    //constructor

    private slime(float hp)
    {
        
    }


    //methods

    //returnere nuværende hp
    public float Hp()
    {
        return this.hp;
    }

    //slime skader target for "attack" antal skade
    public void Attack(GameObject target)
    {
        target.hp -= attack;
    }

}