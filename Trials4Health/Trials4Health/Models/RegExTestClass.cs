using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trials4Health.Models
{
    public class RegExTestClass
    {

        // O + faz com que verifique se um ou mais caracteres são validos
        [RegularExpression("([A-z]+)", ErrorMessage = "Invalid Username")]
        public string Username { get; set; }

        // Verifica que a password contem pelo menos 8 caracteres, contem pelo menos 1 caracter lower e 1 uppercase, pode
        // Conter caracteres especiais
        [RegularExpression("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$", ErrorMessage = "Invalid Password")]
        public string Password { get; set; }

        public RegExTestClass()
        {
            Password = "";
            Username = "";
        }
    }
}
