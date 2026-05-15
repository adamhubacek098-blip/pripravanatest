using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Policy;
using System.Text;

namespace AppTemplate.Classes
{
    public class Unit : INotifyPropertyChanged
    {
        // Vytvorte vlastnost _name
        //Vytvorte vlastnost Health
        //Vytvorte vlastnost Mana
        //Vytvorte vlastnost Strength 

        private string _name;
        private int _health;
        private int _mana;
        private int _strength;

        public Unit(string name, int health, int mana, int strength)
        {
            _name = name;
            _health = health;
            _mana = mana;
            _strength = strength;
        }

        //Vytvorenie getter setter s aktualizovaním UI

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public int Health
        {
            get => _health;
            set
            {
                _health = value;
                OnPropertyChanged(nameof(Health));
            }
        }

        public int Mana
        {
            get => _mana;
            set
            {
                _mana = value;
                OnPropertyChanged(nameof(Mana));
            }
        }

        public int Strength
        {
            get => _strength;
            set
            {
                _strength = value;
                OnPropertyChanged(nameof(Strength));
            }
        }

        // Udalost, metoda OnPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        //vytvorte konstruktor

        //Vytvorenie getter setter s aktualizovaním UI


        // Udalost, metoda OnPropertyChanged
    }
}
