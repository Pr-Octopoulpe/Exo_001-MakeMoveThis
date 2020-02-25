using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Script Parameters

    public float playerSpeed = 3f;

    #endregion

    #region Unity Methods

    private void Update()
    {
        /**
         * En code, il est impossible de directement changer la position d'un objet
         * nous sommes donc obliger de créer un nouveau Vector3, de le modifier et
         * de l'assigner à notre objet à la fin
         * 
         * /!\ Chose importante :
         *  ici, le `this` représente l'objet auquel le script est attaché
         */
        Vector3 newPosition = this.transform.position;

        /**
         * OBJECTIF :
         *  - Vous aller dans un premier temps essayer de faire bouger `player` vers la gauche
         *  sans se soucier de si on appuie sur un bouton ou non
         *      - Pour savoir comment vous diriger, n'hésiter pas à le faire bouger sur Unity et voir quelle(s) valeur(s) change(nt)
         *  
         *  - Ensuite, vous allez vérifier que vous appuyez sur une touche de votre choix (A/Q/FlècheGauche) et ne faire le déplacement
         *  que si on appuie sur cette touche
         *  
         *  - Faites en de même pour les autres directions
         */


        /**
         * Après avoir fait les modifications sur `newPosition` il est essentiel
         * de l'affecter à la position de votre objet, sinon, rien ne se passera
         */
    }

    #endregion
}
