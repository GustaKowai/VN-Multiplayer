using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//garante que nada do teste vai aparecer em outros codigos
namespace TESTE
{
    public class TESTE_TextPrinter : MonoBehaviour
    {

        DialogueSystem ds;
        TextPrinter printer;

        string[] falas = new string[5]
        {
            "Oi, tudo bem?",
            "Me deixa em paz. Eu preciso de um tempo a s�s comigo mesmo. Espero que voc� entenda.",
            "Este texto est� saindo da minha boca de livre e espont�nea vontade e eu n�o sou um c�digo programado para imprimir esta sequ�ncia de caracteres.",
            "� um p�ssaro? � um avi�o? N�o, � apenas o esp�rito que me assombra todos os dias...",
            "Estou com muito frio. Mas o que mais me incomoda, � que est� frio por dentro, tamb�m..."
        };



        // Start is called before the first frame update
        void Start()
        {
            ds = DialogueSystem.instance;
            printer = new TextPrinter(ds.dialogueBox.dialogueText);
            printer.buildMethod = TextPrinter.BuildMethod.typewriter;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space)) //ADICIONAR PRA CLIQUE
                printer.Build(falas[Random.Range(0,falas.Length)]);
        }
    }
}