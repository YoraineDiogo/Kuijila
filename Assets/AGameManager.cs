using System.Collections;
using System.Collections.Generic; //access to list
using UnityEngine;
using UnityEngine.UI; // Everytime a UI is added like Text
using System.Linq; //checking the

using UnityEngine.SceneManagement; //reloading a scene

public class AGameManager : MonoBehaviour {

	public Question[] questions;
	private static  List<Question> unansweredQuestions;
	
	private Question currentQuestion;
	
	[SerializeField]
	private Text factText;
	
	[SerializeField]
	private Text trueAnswerText;
	
	[SerializeField]
	private Text falseAnswerText;
	
	[SerializeField]
	private Animator animator;
	
	[SerializeField]
	private float timeBetweenQuestions = 1f;
	// Use this for initialization
	void Start () {
		
		//checking whether the questions have being answered or not
		if(unansweredQuestions == null || unansweredQuestions.Count == 0){
			unansweredQuestions = questions.ToList<Question>();
			
		}
		
		setCurrentQuestion();
		//Debug.Log(currentQuestion.fact + "is" + currentQuestion.isTrue);
	
	}
	
	void setCurrentQuestion () {
			
			int randomQuestionIndex = Random.Range(0,unansweredQuestions.Count);
			currentQuestion = unansweredQuestions[randomQuestionIndex];
			
			factText.text = currentQuestion.fact;
			if(currentQuestion.isTrue){
				
				trueAnswerText.text = "CORRECT";
				falseAnswerText.text = "WRONG";
			}else{
				
				trueAnswerText.text = "WRONG";
				falseAnswerText.text = "CORRECT";
			}
			//unansweredQuestions.RemoveAt(randomQuestionIndex);
		}
		
	IEnumerator TransitionToNextQuestion(){
		
		unansweredQuestions.Remove(currentQuestion);

		yield return new WaitForSeconds(timeBetweenQuestions);
		
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		
	}
	
	public void UserSelectTrue(){
		
		animator.SetTrigger("True");
		
		if(currentQuestion.isTrue){
			
			Debug.Log("CORRECT");
		}else{
			Debug.Log("WRONG");
			
		}
		StartCoroutine(TransitionToNextQuestion());
	}
	
	public void UserSelectFalse(){
		
		animator.SetTrigger("True");
		
		if(!currentQuestion.isTrue){
			
			Debug.Log("WRONG");
		}else{
			Debug.Log("CORRECT");
			
		}
		StartCoroutine(TransitionToNextQuestion());

	}
	// Update is called once per frame
	
}
