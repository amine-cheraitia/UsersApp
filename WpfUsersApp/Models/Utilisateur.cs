﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfUsersApp.Models
{
    internal class Utilisateur
    {
        public string? Id { get; set; }
        public string? Nom { get; set; }
        public string? Prenom { get; set; }
        public string? Login { get; set; }
        public string? MotDePasse { get; set; }
    }
}
