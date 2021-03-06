using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2D;

    private float moveSpeed;
    private float jumpForce;
    private bool isJumping;
    private float moveHorizontal;
    private float moveVertical;

    public float Hitpoints;
    public float MaxHitpoints = 5;
    public HealthbarBehaviour Healthbar;

[SerializeField] SpriteRenderer spriteRenderer;


    Animator animator;
	string currentAnimState;
	// const string WARRIOR_IDLE= "WarriorIdle";
	// const string WARRIOR_WALKING= "WarriorWalking";
    [SerializeField] string PLAYER_IDLE_ANIMITION;
    [SerializeField] string PLAYER_WALKING_ANIMITION;

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public int attackDamage = 1;
    public LayerMask enemyLayers;

    public bool faceRight = true;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();

        moveSpeed = 1.5f;
        jumpForce = 35f;
        isJumping = false;

        Hitpoints = MaxHitpoints;
        Healthbar.SetHealth(Hitpoints, MaxHitpoints);
        
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Fire1"))
        {
            Attack();
        if(gameObject.tag == "Swordsman"){
            FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Player/Sword_Attack", GetComponent<Transform>().position);
        } 
                if(gameObject.tag == "Archer"){
           FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Player/Bow_Attack", GetComponent<Transform>().position);
        } 
        }
    }

    void FixedUpdate() 
    {
        if(moveHorizontal > 0.1f && !faceRight){
            flip();
        }
        if(moveHorizontal < -0.1f && faceRight){
            flip(); 
        }

        if(moveHorizontal > 0.1f || moveHorizontal < -0.1f)
        {
            ChangeAnimationstate(PLAYER_WALKING_ANIMITION);
            rb2D.AddForce(new Vector2(moveHorizontal * moveSpeed, 0f), ForceMode2D.Impulse);
        }

        if(!isJumping && moveVertical > 0.1f)
        {
            FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Player/Player_Jumping_1", GetComponent<Transform>().position);

            rb2D.AddForce(new Vector2(0f, moveVertical * jumpForce), ForceMode2D.Impulse);
        }
        
        if(moveHorizontal == 0f && moveVertical == 0f){
			ChangeAnimationstate(PLAYER_IDLE_ANIMITION);

        }


    }

    private void flip(){
        faceRight = !faceRight;
        transform.Rotate(0f,180f,0f);

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Platform")
        {
            isJumping = false;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Platform")
        {
            isJumping = true;
        }
    }

    	// Animation state changer
	void ChangeAnimationstate(string newState)
	{
		// Stop animation from interrupting itself
		if (currentAnimState == newState) return;

		// Play new animation
		animator.Play(newState);

		// Update current state
		currentAnimState = newState;
	}

    public void TakeHit(float damage)
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Player/Player_Damaged_1", GetComponent<Transform>().position);

        Hitpoints -= damage;
        Healthbar.SetHealth(Hitpoints, MaxHitpoints);


        if (Hitpoints <= 0)
        {
                    FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Player/Player_Death", GetComponent<Transform>().position);

            Destroy(gameObject);
            
        }
    }

    void Attack()
    {
        animator.SetTrigger("Attack");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<EnemyBehaviour>().TakeHit(attackDamage);
            

        }
    }

    void OnDrawGizmosSelected() {

        if(attackPoint == null){
            return;
        }
        
            Gizmos.DrawWireSphere(attackPoint.position, attackRange);
        
    }
}