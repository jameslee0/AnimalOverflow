using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    public Text dialogueText;

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartD(Dialogue dialogue)
    {
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            SceneManager.LoadScene("FirstWave");
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(SentenceAni(sentence));
    }

    IEnumerator SentenceAni(string sentence)
    {
        dialogueText.text = "";
        foreach(char let in sentence.ToCharArray())
        {
            dialogueText.text += let;
            yield return null;
        }
    }
    void EndDialogue()
    {

    }
}
