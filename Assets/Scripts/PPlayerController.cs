using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PPlayerController : MonoBehaviour
{
	public static PPlayerController instancia;
	[Header("Movimiento")]
	public float moveSpeed;
	
	[Header("Componentes")]
	public Rigidbody2D theRB;

	
	[Header("Salto")]
	public float jumpForce;
	
	[Header("Grounded")]
	private bool isGrounded;
	public Transform groundCheckpoint;
	public LayerMask whatisGround;
	
	[Header("Animator")]
	private Animator anim;
	private SpriteRenderer thSR;

	private CanvasListener canvasListener = new CanvasListener();

	private BodyStatus bodyStatus = new BodyStatus();

	private GameStatus gameStatus = new GameStatus();
	public CanvasController CanvasController;

	[SerializeField]
	OxygenMachineController OxygenMachineController;

	private List<Enhancer> enhancers;

	public void Awake()
	{
		instancia = this;
	}

	void Start()
	{
		enhancers = new List<Enhancer>();
		canvasListener.Add(CanvasController.GetComponent<EnhancementStatusTextObserver>());
		canvasListener.Add(CanvasController.GetComponent<giOxygenInformationTextObserver>());
		canvasListener.Add(CanvasController.GetComponent<EnhancementStatusTextObserver>());
		canvasListener.Notify(bodyStatus);
		anim = GetComponent<Animator>();
		thSR = GetComponent<SpriteRenderer>();

	}
	void Update()
	{	
		OxygenMachineController.DecreaseOxygenTime();

		bodyStatus.UpdateBreathingTime(OxygenMachineController.GetOxygenTime());

		canvasListener.Notify(bodyStatus);
		
		theRB.velocity = new Vector2(moveSpeed * Input.GetAxis("Horizontal"), theRB.velocity.y);
		
		isGrounded = Physics2D.OverlapCircle(groundCheckpoint.position, .2f, whatisGround);
	
		
		if (Input.GetButton("Jump"))
		{
			if (isGrounded)
			{
				theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
			}
		}

		if (theRB.velocity.x < 0)
		{
			transform.eulerAngles = new Vector3(0, 180, 0);
		}else if (theRB.velocity.x > 0)
		{
		
			transform.eulerAngles = new Vector3(0, 0, 0);
		}
		anim.SetFloat("moveSpeed", Mathf.Abs(theRB.velocity.x));
		anim.SetBool("isGrounded",isGrounded);
	}
	
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision != null)
		{
			if (collision.gameObject.CompareTag("OxygenTank"))
			{
				OxygenMachineController.UpgradeOxygenMachine();
//				Debug.Log("Oxygen generated: " + OxygenMachineController.GetOxygenTime());
				bodyStatus.UpdateBreathingTime(OxygenMachineController.GetOxygenTime());
				bodyStatus.SetTankEquipped(true);
				// Notify the canvas
				canvasListener.Notify(bodyStatus);

			}

			else if (collision.gameObject.CompareTag("Elevator"))
			{
				collision.gameObject.transform.parent.gameObject.GetComponent<ElevatorTriggerController>().isPlayerOnElevator = true;
			}

			else if (collision.gameObject.CompareTag("Enhancer")) {

				if (collision.gameObject.GetComponent<Enhancer>().Activated == true)
				{
					Debug.Log("adding enhancer");
					this.AddEnhancer(collision.gameObject.GetComponent<Enhancer>());
					bodyStatus.UpdateBreathingTime(OxygenMachineController.GetOxygenTime());
					Debug.Log("New Oxygen generated Enhanced: " + bodyStatus.BreathingTime);
					canvasListener.Notify(bodyStatus);
					collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;
					collision.gameObject.GetComponent<Enhancer>().Activated = false;
				}
			}
		}
	}

	public void AddEnhancer(Enhancer enhancer)
	{
		enhancers.Add(enhancer);
		if (enhancers.Count <= 8) {
			OxygenMachineController.AddOxygenEnhancement(enhancer);

			gameStatus.Enhancements += 1;

			canvasListener.Notify(gameStatus);
		}
	}
}
