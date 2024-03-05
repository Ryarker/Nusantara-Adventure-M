using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [Header("Attack")]
    [SerializeField] private float timeAttack = 1f;
    [SerializeField] GameObject hitEfxGo;
     [SerializeField]Transform efxspawn;
    [Header("Target")]
    private GameObject attackArea = default;

    PlayerControl controls;


    [Header("Cooldown")]
    private float timer = 0f;

    [Header("Boolean")]
    private bool attacking = false;


    [Header("References")]
    private PlayerMovement playerMovement;
    public ButoEnemy butoEnemy;

    void Awake()
    {
        controls = new PlayerControl();
        controls.Enable();

        controls.Ground.Attacking.performed += ctx => InitiateAttack();
    }

    void Start()
    {
        attackArea = transform.GetChild(0).gameObject;
        playerMovement = GetComponent<PlayerMovement>();
    }
    void Update()
    {
        InitiateAttack();
    }
    private void Attack()
    {
        Instantiate(hitEfxGo,efxspawn);
        AudioManager.Instance.Play("Punch");
        attacking = true;
        attackArea.SetActive(attacking);
        PlayerManager.Instance.animPlayer.SetTrigger("isAttack");
    }

    void InitiateAttack (){
        if (controls.Ground.Attacking.triggered && PlayerManager.Instance.animPlayer.GetBool("isGrounded"))
        {
            if(!attacking )
            {
                Attack();
            }
        }
        if (attacking)
        {
            timer += Time.deltaTime;

            if (timer >= timeAttack)
            {
                timer = 0;
                attacking = false;
                attackArea.SetActive(attacking);
            }
        }
    }

    private void OnEnable() {
        controls.Enable();
    }
    private void OnDisable() {
        controls.Disable();
    }
}