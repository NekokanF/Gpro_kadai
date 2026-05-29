using UnityEngine;

public class AttackAnimEvent : MonoBehaviour
{
    [SerializeField] PolygonCollider2D AttackColl;
    [SerializeField] Player player;
    public void AttackStart()
    {
        player.OnAttack = true;
    }
    public void AttackEnd()
    {
        player.OnAttack = false;
    }

    public void AttackColliderON()
    {
        AttackColl.enabled = true;
        Debug.Log("coll ON");
    }
    public void AttackColliderOFF()
    {
        AttackColl.enabled = false;
        Debug.Log("coll OFF");
    }
}
