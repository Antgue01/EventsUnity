using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D _rb;
    //Header sirve para poner texto en el editor. Generalmente se usa para separar grupos de variables
    [Header("Variables")]
    //Tooltip se usa para documentar el uso de una variable. Si pasas el ratón en el editor por una variable con un Tooltip te muestra
    //el texto
    [Tooltip("La fuerza del salto")]
    //Range sirve para mostrar la variable como un slider
    [SerializeField] [Range(1, 20)] float jumpForce;
    //Un delegate es la forma de declarar la signatura de un callback
    public delegate void OnJump();
    //si se combina con un event podemos hacer que otras clases se suscriban al evento y ejecuten el método o los métodos que hayan suscrito cuando
    //se lance el evento. Se suele poner static para que el evento sea de la clase y no dependa de instancias concretas
    static public event OnJump onJump;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(Vector2.up * jumpForce,ForceMode2D.Impulse);
            //El ? hace que el método sólo se invoque si onJump no es null
            onJump?.Invoke();
        }
    }
}
