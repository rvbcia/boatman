using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine; 
 
 public class ScoreManager : MonoBehaviour {
  public static int currentScore;
  public static int highScore;
 
  Text currentScoreText;
  Text highScoreText;
 
  void Awake () 
  {
       //this is how you get "Text" component.
 
      //"CurrentScoreValue" is the name of gameobject which has "Text" component attached to show        value of current score.
  currentScoreText =  GameObject.Find ("CurrentScoreValue").GetComponent <Text>();
 
 //"HighScoreValue" is the name of gameobject which has "Text" component attached to show value of high score.
  highScoreText =  GameObject.Find ("HighScoreValue").GetComponent <Text>();
  score = 0; 
 }
 
 void GameOver()
 {
     currentScoreText.text = currentScore.toString();
      if(  PlayerPrefs.GetFloat("High Score", 0) > currentScore)
      {
           highScoreText.text = highScore.toString();
           //You need this to save high score across game sessions
           PlayerPrefs.SetFloat("High Score", highScore);
      }
     
 }
 }