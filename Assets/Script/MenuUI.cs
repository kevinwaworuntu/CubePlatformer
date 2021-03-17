using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class MenuUI : MonoBehaviour
{
    [SerializeField] private GameObject instruction;
    [SerializeField] private string[] instructionArray;
    [SerializeField] private Text instructionText;
    [SerializeField] private float waitTime;
        
    public void _Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void _Instruction()
    {
        instruction.SetActive(true);
        StartCoroutine(InstructionText());
    } 
    private IEnumerator InstructionText()
    {
        instructionText.text = instructionArray[0];
        yield return new WaitForSeconds(waitTime);
        instructionText.text = instructionArray[1];
        yield return new WaitForSeconds(waitTime);
        instructionText.text = instructionArray[2];
        yield return new WaitForSeconds(waitTime);
        instructionText.text = instructionArray[3];
        yield return new WaitForSeconds(waitTime);
        instruction.SetActive(false);
    }

    public void _Quit()
    {
        Application.Quit();
    }
    
}
