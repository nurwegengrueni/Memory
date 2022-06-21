﻿using System;
/*
 * Kindklasse von Spieler
 * Autoren: Alexander Bletsch, Anna Stork
 * Erstellt: 09.06.22
 */

namespace Memory {
    public class Computer : Spieler {
        string _difficulty;

        public string Difficulty {
            get => _difficulty;
            set {
                if (value == "Normal" || value == "Schwer") {
                    _difficulty = value ?? throw new ArgumentNullException(
                                                "Kein Schwierigkeitsgrad vorhanden!");
                } else {
                    throw new ArgumentException(
                        "Schwierigkeitsgrad ist nicht Normal oder Schwer!");
                }

            }
        }

        public Computer(string difficulty, bool aktiveRunde) : base(aktiveRunde) {
            Difficulty = difficulty;
        }

        public override void Gedaechtnis(string karte, int zeile, int spalte) {
            base.Gedaechtnis(karte, zeile, spalte);

        }

        public override string GetName() {
            return Difficulty;
        }

        public override void Random() {

        }

        public override void GedaechnisLoeschen() {

        }

        public override void ButtonDeaktivieren() {

        }
    }
}