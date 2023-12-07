using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    public Dialogue dialogue;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1)) // Verifica o clique do mouse direito
        {
            // Este bloco de código será executado quando o objeto for clicado com o mouse direito
            dialogue.StartDialogue();
        }
    }
}
