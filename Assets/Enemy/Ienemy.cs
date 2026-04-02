namespace enemy
{
using UnityEngine;

    interface Ienemy
    {
        //enemys hp
        float Hp();

        //enemy skader target som vælges af argument
        void Attack(GameObject target);

        //bool, om hvorvidt den lever
        bool Alive();

    }
}
